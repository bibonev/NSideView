#include <iostream>
#include <string>
#include <opencv/cv.h>
#include <opencv/highgui.h>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/imgproc/imgproc_c.h>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/highgui/highgui_c.h>
#include <opencv2/legacy/legacy.hpp>

using namespace std;
using namespace cv;

typedef struct _ChData ChData;
struct _ChData
{
    /* OpenCV */
    CvStereoGCState *GCState; /* Graph Cut State */
    IplImage *cv_image_left;
    IplImage *cv_image_right;
    CvMat *cv_image_depthL;
    CvMat *cv_image_depthR;
    IplImage *cv_image_depth_aux;
};

void computeStereoGC(ChData *data, char *path)
{
    int i, j, aux;
    IplImage *img;
    uchar *ptr_dst;
    uchar *ptr_depth;
    cvFindStereoCorrespondenceGC (
        data->cv_image_left,
        data->cv_image_right,
        data->cv_image_depthL,
        data->cv_image_depthR,
        data->GCState,
        0
    );
    //Normalize the result so we can display it
    cvNormalize( data->cv_image_depthL, data->cv_image_depthL, 0, 256, CV_MINMAX, NULL );
    for ( i = 0; i < data->cv_image_depthL->rows; i++)
    {
        aux = data->cv_image_depthL->cols * i;
        ptr_dst = (uchar*)(data->cv_image_depth_aux->imageData + i*data->cv_image_depth_aux->widthStep);
        for ( j = 0; j < data->cv_image_depthL->cols; j++ )
        {
            //((float*)(mat->data.ptr + mat->step*i))[j]
            ptr_dst[3*j] = (uchar)((short int*)(data->cv_image_depthL->data.ptr + data->cv_image_depthL->step*i))[j];
            ptr_dst[3*j+1] = (uchar)((short int*)(data->cv_image_depthL->data.ptr + data->cv_image_depthL->step*i))[j];
            ptr_dst[3*j+2] = (uchar)((short int*)(data->cv_image_depthL->data.ptr + data->cv_image_depthL->step*i))[j];
        }
    }

    FILE *handleWrite=fopen(path,"wb");
    fwrite(data->cv_image_depthL->data.ptr, 2*data->cv_image_depthL->cols*data->cv_image_depthL->rows, 1, handleWrite);
    fclose(handleWrite);
}

int main(int argc, char *argv[])
{
	if (argc != 5)
    {
        fprintf(stderr,"USAGE: %s leftImage rightImage path\n",argv[0]);
        fprintf(stderr,"\t leftImage: Filename of the image left (string). Example : left.ppm\n");
        fprintf(stderr,"\t rightImage : Filename of the right left (string). Example : right.ppm\n");
		fprintf(stderr,"\t path : Name of the directory of the images (string). Example : C:\\Users\\Boyan\n");
		fprintf(stderr,"\t path : Name of the directory of the images (string). Example : C:\\Users\\Boyan\n");

		cout<<argv[1]<<endl;
		cout<<argv[2]<<endl;
		cout<<argv[3]<<endl;
		cout<<argv[4]<<endl;
        return 1;
    }
	
	char *left_filename = argv[1];
    char *right_filename = argv[2];
	
	char *pathImage = argv[3];
	char *pathBin = argv[4];
	char nameImage[] = "Depth.png";
	char nameBin[] = "DepthBin.bin";

    int norm_width = 640;
    int norm_height = 480;

    ChData *data = new ChData();
    data->GCState = cvCreateStereoGCState(289, 10);
    data->cv_image_left = cvLoadImage(left_filename, 0);
    data->cv_image_right = cvLoadImage(right_filename, 0);
    data->cv_image_depthL = cvCreateMat(data->cv_image_left->height, data->cv_image_left->width, CV_16S);
    data->cv_image_depthR = cvCreateMat(data->cv_image_right->height, data->cv_image_right->width, CV_16S);
    data->cv_image_depth_aux = cvCreateImage (cvGetSize(data->cv_image_left),IPL_DEPTH_8U, 3);

	strcat(pathBin, nameBin);

	computeStereoGC(data, pathBin);
	
	strcat(pathImage, nameImage);

	cvSaveImage(pathImage, data->cv_image_depth_aux);

	delete data;

	return 0;
}