function out = calculHistograma(pic);
%imaginea de intrare trebuie sa aiba un singru strat
[rows, cols]= size(pic);
h = zeros(1,256);
for i = 1:rows
    for j = 1:cols
        g = pic(i,j);
        h(g+1) = h(g+1) + 1;
    end
end
out = h;