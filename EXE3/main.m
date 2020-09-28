clear all; close all;  clc;

pozaUINT8 = imread('L7img\img.jpg');
poza = double(pozaUINT8)/255;
figure(1); imshow(poza);

f1 = laplace1(poza);
figure(2); imshow(f1);

f1 = laplace2(poza);
figure(3); imshow(f1);

f1 = prewitt(poza);
figure(4); imshow(f1);

f1 = sobel(poza);
figure(5); imshow(f1);

f1 = kirsch(poza);
figure(6); imshow(f1);