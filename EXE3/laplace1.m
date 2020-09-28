function out = laplace1(poza)

poza = rgb2gray(poza);
poza = poza(:,:,1);

H2 = [0,1,0;1,-4,1;0,1,0];

[rows, cols,layers] = size(poza);
Y = double(zeros(rows, cols,layers));
newh2 = poza(:,:,1);

for i=2 : (rows-1)
    for j=2: (cols-1)
        newh2(i, j) = poza(i-1,j-1)*H2(1,1)+poza(i-1, j)*H2(1,2)+poza(i-1, j+1)*H2(1,3)+ poza(i ,j-1)*H2(2,1)+poza(i , j)*H2(2,2)+poza(i , j+1)*H2(2,3)+poza(i+1,j-1)*H2(3,1)+poza(i+1, j)*H2(3,2)+poza(i+1, j+1)*H2(3,3);
        Y(i,j) = newh2(i,j);
    end
   
end
out = Y;