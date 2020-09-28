function out = kirsch(poza)

poza = rgb2gray(poza);
poza = poza(:,:,1);

H1 = [-1,0,1;-1,0,1;-1,0,1];
H2 = [0,1,1;-1,0,1;-1,-1,0];
H3 = [1,1,1;0,0,0;-1,-1,1];
H4 = [1,1,0;1,0,-1;0,-1,-1];
H5 = [1,0,-1;1,0,-1;1,0,-1];
H6 = [0,-1,-1;1,0,-1;1,1,0];
H7 = [-1,-1,-1;0,0,0;1,1,1];
H8 = [-1,-1,0;-1,0,1;0,1,1];

[rows, cols,layers] = size(poza);
Y = double(zeros(rows, cols,layers));
G = double(zeros(rows, cols,layers));
newh1 = poza(:,:,1);
newh2 = poza(:,:,1);
newh3 = poza(:,:,1);
newh4 = poza(:,:,1);
newh5 = poza(:,:,1);
newh6 = poza(:,:,1);
newh7 = poza(:,:,1);
newh8 = poza(:,:,1);

for i=2 : (rows-1)
    for j=2: (cols-1)
        newh1(i, j) = poza(i-1,j-1)*H1(1,1)+poza(i-1, j)*H1(1,2)+poza(i-1, j+1)*H1(1,3)+ poza(i ,j-1)*H1(2,1)+poza(i , j)*H1(2,2)+poza(i , j+1)*H1(2,3)+poza(i+1,j-1)*H1(3,1)+poza(i+1, j)*H1(3,2)+poza(i+1, j+1)*H1(3,3);
        newh2(i, j) = poza(i-1,j-1)*H2(1,1)+poza(i-1, j)*H2(1,2)+poza(i-1, j+1)*H2(1,3)+ poza(i ,j-1)*H2(2,1)+poza(i , j)*H2(2,2)+poza(i , j+1)*H2(2,3)+poza(i+1,j-1)*H2(3,1)+poza(i+1, j)*H2(3,2)+poza(i+1, j+1)*H2(3,3);
        newh3(i, j) = poza(i-1,j-1)*H3(1,1)+poza(i-1, j)*H3(1,2)+poza(i-1, j+1)*H3(1,3)+ poza(i ,j-1)*H3(2,1)+poza(i , j)*H3(2,2)+poza(i , j+1)*H3(2,3)+poza(i+1,j-1)*H3(3,1)+poza(i+1, j)*H3(3,2)+poza(i+1, j+1)*H3(3,3);
        newh4(i, j) = poza(i-1,j-1)*H4(1,1)+poza(i-1, j)*H4(1,2)+poza(i-1, j+1)*H4(1,3)+ poza(i ,j-1)*H4(2,1)+poza(i , j)*H4(2,2)+poza(i , j+1)*H4(2,3)+poza(i+1,j-1)*H4(3,1)+poza(i+1, j)*H4(3,2)+poza(i+1, j+1)*H4(3,3);
        newh5(i, j) = poza(i-1,j-1)*H5(1,1)+poza(i-1, j)*H5(1,2)+poza(i-1, j+1)*H5(1,3)+ poza(i ,j-1)*H5(2,1)+poza(i , j)*H5(2,2)+poza(i , j+1)*H5(2,3)+poza(i+1,j-1)*H5(3,1)+poza(i+1, j)*H5(3,2)+poza(i+1, j+1)*H5(3,3);
        newh6(i, j) = poza(i-1,j-1)*H6(1,1)+poza(i-1, j)*H6(1,2)+poza(i-1, j+1)*H6(1,3)+ poza(i ,j-1)*H6(2,1)+poza(i , j)*H6(2,2)+poza(i , j+1)*H6(2,3)+poza(i+1,j-1)*H6(3,1)+poza(i+1, j)*H6(3,2)+poza(i+1, j+1)*H6(3,3);
        newh7(i, j) = poza(i-1,j-1)*H7(1,1)+poza(i-1, j)*H7(1,2)+poza(i-1, j+1)*H7(1,3)+ poza(i ,j-1)*H7(2,1)+poza(i , j)*H7(2,2)+poza(i , j+1)*H7(2,3)+poza(i+1,j-1)*H7(3,1)+poza(i+1, j)*H7(3,2)+poza(i+1, j+1)*H7(3,3);
        newh8(i, j) = poza(i-1,j-1)*H8(1,1)+poza(i-1, j)*H8(1,2)+poza(i-1, j+1)*H8(1,3)+ poza(i ,j-1)*H8(2,1)+poza(i , j)*H8(2,2)+poza(i , j+1)*H8(2,3)+poza(i+1,j-1)*H8(3,1)+poza(i+1, j)*H8(3,2)+poza(i+1, j+1)*H8(3,3);
        G(i,j) = max(newh1(i,j), newh2(i,j));
        G(i,j) = max(Y(i,j), newh3(i,j));
        G(i,j) = max(Y(i,j), newh4(i,j));
        G(i,j) = max(Y(i,j), newh5(i,j));
        G(i,j) = max(Y(i,j), newh6(i,j));
        G(i,j) = max(Y(i,j), newh7(i,j));
        G(i,j) = max(Y(i,j), newh8(i,j));
        Y(i,j) = G(i,j);
    end
end
out = Y;