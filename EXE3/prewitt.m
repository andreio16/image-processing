function out = prewitt(poza)

poza = rgb2gray(poza);
poza = poza(:,:,1);

P = [-1,-1,-1;0,0,0;1,1,1];
Q = [-1,0,1;-1,0,1;-1,0,1];

[rows, cols,layers] = size(poza);
Y = double(zeros(rows, cols,layers));
newp = poza(:,:,1);
newq = poza(:,:,1);

for i=2 : (rows-1)
    for j=2: (cols-1)
        newp(i, j) = poza(i-1,j-1)*P(1,1)+poza(i-1, j)*P(1,2)+poza(i-1, j+1)*P(1,3)+ poza(i ,j-1)*P(2,1)+poza(i , j)*P(2,2)+poza(i , j+1)*P(2,3)+poza(i+1,j-1)*P(3,1)+poza(i+1, j)*P(3,2)+poza(i+1, j+1)*P(3,3);
        newq(i, j) = poza(i-1,j-1)*Q(1,1)+poza(i-1, j)*Q(1,2)+poza(i-1, j+1)*Q(1,3)+ poza(i ,j-1)*Q(2,1)+poza(i , j)*Q(2,2)+poza(i , j+1)*Q(2,3)+poza(i+1,j-1)*Q(3,1)+poza(i+1, j)*Q(3,2)+poza(i+1, j+1)*Q(3,3);
         Y(i,j) = sqrt( newp(i,j) * newp(i,j) + newq(i,j)*newq(i,j) );
    end
   
end
out = Y;