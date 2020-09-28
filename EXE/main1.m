clear all; close all; clc;
pozaUINT8 = imread('L1img\imag1.jpg');
poza = double(pozaUINT8)/255;
figure(1);  imshow(pozaUINT8);
figure(2);  imshow(poza);

%   1) LAB1 grayscale
i= 0.299*poza(:,:,1) + 0.587*poza(:,:,2) + 0.114*poza(:,:,3);   
figure(3);  imshow(i);

%   2) negative image
n= 1- poza; figure(4); imshow(n);

%   3) luminozitate
pozaL = poza + 20/255;  figure(4);  imshow(pozaL);
pozaL = poza - 20/255;  figure(5);  imshow(pozaL);

%   4) pseudocolor
pozaUINT8 = imread('L1img\imag3.jpg');
pic = double (pozaUINT8)/255;   %figure(6); imshow(pic);
pic(:,:,1) = 72/255 * pic(:,:,1) ;    
pic(:,:,2) = 162/255 * pic(:,:,2) ;  
pic(:,:,3) = 153/255 * pic(:,:,3) ; 
figure(7); imshow(pic);

%   5) LAB2 histograma
pic = imread('L2img\imag3.png');
figure(8);  imshow(pic);
I= 0.299*pic(:,:,1) + 0.587*pic(:,:,2) + 0.114*pic(:,:,3);   
figure(9);  imshow(I); 
h = calculHistograma(I(:,:,1));
figure(10); stem(h);
%   6) imbunatatire contrast 5)
pozaO = double(I);
M = max(pozaO(:));  m = min(pozaO(:));
pozaN = (255/(M-m))*(pozaO-m);
figure(11); imshow(uint8(pozaN));
%   7) histograma pentru 6)
x = calculHistograma(uint8(pozaN)); figure(12);stem(x);


