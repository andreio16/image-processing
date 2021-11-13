using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        private int lineSize;
        private int blockSize;
        private int[,] blockDistMatrix;
        private string sSourceFileName = "";
        private const int BLACK_COLOR_VALUE = 0;
        private const int WHITE_COLOR_VALUE = 255;

        private Bitmap image = null;
        private FastImage workImageLeft;
        private FastImage workImageRight;
        private FastImage workImageBlockMatch;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadImageLeft_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panelSourceLeft.BackgroundImage = new Bitmap(sSourceFileName);

            image = new Bitmap(sSourceFileName);
            workImageLeft = new FastImage(image);
            workImageBlockMatch = new FastImage(image);
            InitDistanceMatrix();
        }

        private void btnLoadImageRight_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panelSourceRight.BackgroundImage = new Bitmap(sSourceFileName);
            image = new Bitmap(sSourceFileName);
            workImageRight = new FastImage(image);
        }

        private void btnBlockMatch_Click(object sender, EventArgs e)
        {

            Color colorRef;
            Color colorDest;
            lineSize = Convert.ToInt32(textBoxLineSize.Text);
            blockSize = Convert.ToInt32(textBoxBlockSize.Text);
            var auxBitmap = workImageRight.GetBitMap();

            // all image search
            workImageLeft.Lock();
            for (int i = 0; i < workImageLeft.Width; i += blockSize)
            {
                for (int j = 0; j < workImageLeft.Height; j += blockSize)
                {
                    int sum_ref_R = 0;
                    int sum_ref_G = 0;
                    int sum_ref_B = 0;
                    var dest_sum_list = new List<ColorExtension>();

                    // block image search
                    if (i + blockSize < workImageLeft.Width && j + blockSize < workImageLeft.Height)
                    {
                        // calc the block sum from LEFT image with default size S=4 
                        for (int m = i; m < i + blockSize; m++)
                        {
                            for (int n = j; n < j + blockSize; n++)
                            {
                                colorRef = workImageLeft.GetPixel(m, n);
                                sum_ref_R += colorRef.R;
                                sum_ref_G += colorRef.G;
                                sum_ref_B += colorRef.B;

                            }
                        }

                        // calc the sum from RIGHT image with sliding window D=16 default
                        if (i + lineSize < workImageRight.Width || j + lineSize < workImageRight.Height)
                        {
                            var ct = 0;
                            var nextM = i;
                            var nextN = j;
                            var max_count = lineSize / blockSize;

                            while (ct < max_count)
                            {
                                int sum_dest_R = 0;
                                int sum_dest_G = 0;
                                int sum_dest_B = 0;
                                for (int m = nextM; m < nextM + blockSize; m++)
                                {
                                    for (int n = nextN; n < nextN + blockSize; n++)
                                    {
                                        colorDest = auxBitmap.GetPixel(nextM, nextN);
                                        sum_dest_R += colorDest.R;
                                        sum_dest_G += colorDest.G;
                                        sum_dest_B += colorDest.B;
                                    }
                                }
                                dest_sum_list.Add(new ColorExtension(sum_dest_R, sum_dest_G, sum_dest_B));
                                nextN++;
                                ct++;
                            }
                        }

                        // calc the sum of absolut diff (LEFT - RIGHT)
                        var minBlockSum = new ColorExtension(int.MaxValue, int.MaxValue, int.MaxValue);
                        foreach (var elem in dest_sum_list)
                        {
                            var diff_R = sum_ref_R - elem.R;
                            var diff_G = sum_ref_G - elem.G;
                            var diff_B = sum_ref_B - elem.B;
                            if (diff_R < minBlockSum.R && diff_G < minBlockSum.G && diff_B < minBlockSum.B)
                                minBlockSum = elem;
                        }

                        // get the index of the minimum block sum in order to set the color
                        var index = dest_sum_list.IndexOf(minBlockSum);
                        SetBlockDistMatrix(i, j, Math.Abs(index + 1));
                    }

                }
            }
            workImageLeft.Unlock();

            DrawDepthColorMatrix();
        }

        private void InitDistanceMatrix()
        {
            blockDistMatrix = new int[workImageLeft.Width, workImageLeft.Height];

            for (int i = 0; i < workImageLeft.Width; i++)
                for (int j = 0; j < workImageLeft.Height; j++)
                    blockDistMatrix[i, j] = BLACK_COLOR_VALUE;
        }

        private void DrawDepthColorMatrix()
        {
            var minValue = GetMinValueFromBlockDistMat();
            var maxValue = GetMaxValueFromBlockDistMat();

            workImageBlockMatch.Lock();
            for (int i = 0; i < workImageBlockMatch.Width; i++)
            {
                for (int j = 0; j < workImageBlockMatch.Height; j++)
                {
                    var colorValue = (blockDistMatrix[i, j] * WHITE_COLOR_VALUE) / maxValue;
                    Color color = Color.FromArgb(colorValue, colorValue, colorValue);

                    if (blockDistMatrix[i, j] == minValue)
                        color = Color.White;
                    else if (blockDistMatrix[i, j] == maxValue)
                        color = Color.Black;

                    workImageBlockMatch.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImageBlockMatch.GetBitMap();
            workImageBlockMatch.Unlock();
        }

        private void SetBlockDistMatrix(int row, int col, int value)
        {

            if (row + blockSize < workImageLeft.Width && col + blockSize < workImageLeft.Height)
            {
                for (int i = row; i < row + blockSize; i++)
                {
                    for (int j = col; j < col + blockSize; j++)
                    {
                        blockDistMatrix[i, j] = value;
                    }
                }
            }
        }


        private int GetMinValueFromBlockDistMat()
        {
            var min = int.MaxValue;
            for (int i = 0; i < workImageLeft.Width; i++)
                for (int j = 0; j < workImageLeft.Height; j++)
                    if (blockDistMatrix[i, j] < min)
                        min = blockDistMatrix[i, j];
            return min;
        }

        private int GetMaxValueFromBlockDistMat()
        {
            var max = int.MinValue;
            for (int i = 0; i < workImageLeft.Width; i++)
                for (int j = 0; j < workImageLeft.Height; j++)
                    if (blockDistMatrix[i, j] > max)
                        max = blockDistMatrix[i, j];
            return max;
        }
    }
}