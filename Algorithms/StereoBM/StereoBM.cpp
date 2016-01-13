#include<iostream>
#include<opencv\cv.h>
#include<opencv\highgui.h>
#include<stdio.h>

using namespace std;

/* Main data structure definition */
typedef struct _ChData ChData;
struct _ChData
{
	/* OpenCV */
	CvStereoBMState *BMState; /* Block Matching State */
	IplImage *cv_image_left;
	IplImage *cv_image_right;
	CvMat *cv_image_depth;
	IplImage *cv_image_depth_aux;
	
};

/* Function to compute StereoBM and update the result on the window */
void computeStereoBM(ChData *data, char *pathBin, char *pathImage)
{
	int i, j, aux;
	IplImage *img;
	char nameImage[] = "DepthBM.png";
	uchar *ptr_dst;
	cvFindStereoCorrespondenceBM ( 
		data->cv_image_left,
		data->cv_image_right, 
		data->cv_image_depth, 
		data->BMState
	);
	//Normalize the result so we can display it
	cvNormalize( data->cv_image_depth, data->cv_image_depth, 0, 256, CV_MINMAX, NULL );
	for ( i = 0; i < data->cv_image_depth->rows; i++)
	{
		aux = data->cv_image_depth->cols * i;
		ptr_dst = (uchar*)(data->cv_image_depth_aux->imageData + i*data->cv_image_depth_aux->widthStep);
		for ( j = 0; j < data->cv_image_depth->cols; j++ )
		{
			//((float*)(mat->data.ptr + mat->step*i))[j]
			ptr_dst[3*j] = (uchar)((short int*)(data->cv_image_depth->data.ptr + data->cv_image_depth->step*i))[j];
			ptr_dst[3*j+1] = (uchar)((short int*)(data->cv_image_depth->data.ptr + data->cv_image_depth->step*i))[j];
			ptr_dst[3*j+2] = (uchar)((short int*)(data->cv_image_depth->data.ptr + data->cv_image_depth->step*i))[j];
		}
	}

	FILE *handleWrite=fopen(pathBin,"wb");
    fwrite(data->cv_image_depth->data.ptr, 2*data->cv_image_depth->cols*data->cv_image_depth->rows, 1, handleWrite);
    fclose(handleWrite);
	cout<<pathBin<<endl;

	strcat(pathImage, nameImage);

	img = data->cv_image_depth_aux; 
	cvSaveImage(pathImage,img);

}

int main(int argc, char *argv[])
{
	if (argc != 14)
	{
		cout<<"You did not enter the exact number of arguments(12)."<<endl;
		return 1; 
	}
	
	char *exe = argv[0];
	char *left_filename = argv[1];
	char *right_filename = argv[2];
	int norm_width = 640;
	int norm_height = 480;

	char *pathImage = argv[3];
	char *pathBin = argv[4];
	char nameBin[] = "DepthBM.bin";

	ChData *data = new ChData();

	data->BMState = cvCreateStereoBcdMState(CV_STEREO_BM_BASIC, 64);
	if(data->BMState == NULL)
	{
		fprintf(stderr,"ERROR: Could not create CvStereoBMState\n");
		return 1;
	}
	data->cv_image_left = cvLoadImage(left_filename, 0);
	if (data->cv_image_left == NULL) 
	{
		fprintf(stderr, "ERROR: Could not load %s\n",left_filename);
		return 1;
	}
	data->cv_image_right = cvLoadImage(right_filename, 0);
	if (data->cv_image_right == NULL) 
	{
		fprintf(stderr, "ERROR: Could not load %s\n",right_filename);
		return 1;
	}
	if (data->cv_image_left->width != data->cv_image_right->width || data->cv_image_left->height != data->cv_image_right->height)
	{
		fprintf(stderr,"ERROR: Left and right image different size.\n");
		return 1;
	}
	data->cv_image_depth = cvCreateMat ( data->cv_image_left->height, data->cv_image_left->width, CV_16S);
	if (data->cv_image_depth == NULL)
	{
		fprintf(stderr,"ERROR: Could not create depth image.\n");
		return 1;
	}
	data->cv_image_depth_aux = cvCreateImage (cvGetSize(data->cv_image_left),IPL_DEPTH_8U, 3);
	if (data->cv_image_depth_aux == NULL)
	{
		fprintf(stderr,"ERROR: Could not create depth image.\n");
		return 1;
	}

	data->BMState->preFilterSize = atoi(argv[5]);
	data->BMState->preFilterCap = atoi(argv[6]);
	data->BMState->SADWindowSize = atoi(argv[7]);
	data->BMState->minDisparity = atoi(argv[8]);
	data->BMState->numberOfDisparities = atoi(argv[9]);
	data->BMState->textureThreshold = atoi(argv[10]);
	data->BMState->uniquenessRatio = atoi(argv[11]);
	data->BMState->speckleWindowSize = atoi(argv[12]);
	data->BMState->speckleRange	= atoi(argv[13]);

	strcat(pathBin, nameBin);

	/* Execute first iteration */
	computeStereoBM(data, pathBin, pathImage);

	return 0;
}