function out = calculHistograma(poza);
%imaginea data ca parametru trebuie sa aiba un singur strat
h = zeros(1,256);
[rows, cols] = size(poza);
for i = 1:rows
    for j = 1:cols
        g = poza(i,j);
        h(g+1) = h(g+1) + 1;
    end
end
out = h;