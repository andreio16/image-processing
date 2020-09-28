function out = histogramaCumulativa(poza);
%parametrul functiei trebuie sa fie doar pe un singur strat
H = zeros(1, 156);
h = calculHistograma(poza);
H(1) = h(1);
for i= 2:256
    H(i)= H(i-1) + h(i);
end
out = H;