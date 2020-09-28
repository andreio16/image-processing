function out = vectTransformareHistograma(poza);
H = histogramaCumulativa(poza);
[rows, cols] = size(poza);
T = zeros(1, 256);
M = rows;
N = cols;
for i = 1:256
    T(i) = (H(i) * 255) / (M * N);
end
out = T;
