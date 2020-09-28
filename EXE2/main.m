clear all; close all; clc;
pozUINT8  = imread('imgL3\imagine6.png');
figure(1);  imshow(pozUINT8);
    %1)Calcul Histograma
h = calculHistograma(pozUINT8(:,:,1));
figure(2); stem(h);
    %2)Calcul Histograma cumulativa
hc = histogramaCumulativa(pozUINT8(:,:,1));
figure(3); stem(hc);
    %3)Calcul vector de transformare a histogramei
ht = vectTransformareHistograma(pozUINT8(:,:,1));
figure(4); imshow(ht);
    %4)Imbunatatirea contrastului prin EGALIZAREA HISTOGRAMEI
in = vectTransformareHistograma(pozUINT8(:,:,1));
new_img = in(pozUINT8 + 1);
figure(5); imshow(new_img/255);
    %5)Histograma rezultatului final
hf = calculHistograma(uint8(new_img));
figure(6); stem(hf);