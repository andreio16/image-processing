namespace ComputerVision
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSourceLeft = new System.Windows.Forms.Panel();
            this.panelSourceRight = new System.Windows.Forms.Panel();
            this.btnLoadImageLeft = new System.Windows.Forms.Button();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.btnBlockMatch = new System.Windows.Forms.Button();
            this.btnLoadImageRight = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLineSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBlockSize = new System.Windows.Forms.TextBox();
            this.groupBoxOperations.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSourceLeft
            // 
            this.panelSourceLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSourceLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSourceLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSourceLeft.Location = new System.Drawing.Point(12, 36);
            this.panelSourceLeft.Name = "panelSourceLeft";
            this.panelSourceLeft.Size = new System.Drawing.Size(320, 240);
            this.panelSourceLeft.TabIndex = 0;
            // 
            // panelSourceRight
            // 
            this.panelSourceRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSourceRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSourceRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSourceRight.Location = new System.Drawing.Point(348, 36);
            this.panelSourceRight.Name = "panelSourceRight";
            this.panelSourceRight.Size = new System.Drawing.Size(320, 240);
            this.panelSourceRight.TabIndex = 1;
            // 
            // btnLoadImageLeft
            // 
            this.btnLoadImageLeft.Location = new System.Drawing.Point(12, 37);
            this.btnLoadImageLeft.Name = "btnLoadImageLeft";
            this.btnLoadImageLeft.Size = new System.Drawing.Size(69, 21);
            this.btnLoadImageLeft.TabIndex = 2;
            this.btnLoadImageLeft.Text = "Load Left";
            this.btnLoadImageLeft.UseVisualStyleBackColor = true;
            this.btnLoadImageLeft.Click += new System.EventHandler(this.btnLoadImageLeft_Click);
            // 
            // panelDestination
            // 
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDestination.Location = new System.Drawing.Point(348, 282);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(320, 240);
            this.panelDestination.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image Right";
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.btnBlockMatch);
            this.groupBoxOperations.Controls.Add(this.btnLoadImageRight);
            this.groupBoxOperations.Controls.Add(this.btnLoadImageLeft);
            this.groupBoxOperations.Location = new System.Drawing.Point(12, 282);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(181, 240);
            this.groupBoxOperations.TabIndex = 6;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // btnBlockMatch
            // 
            this.btnBlockMatch.Location = new System.Drawing.Point(47, 73);
            this.btnBlockMatch.Name = "btnBlockMatch";
            this.btnBlockMatch.Size = new System.Drawing.Size(80, 21);
            this.btnBlockMatch.TabIndex = 4;
            this.btnBlockMatch.Text = "BlockMatch";
            this.btnBlockMatch.UseVisualStyleBackColor = true;
            this.btnBlockMatch.Click += new System.EventHandler(this.btnBlockMatch_Click);
            // 
            // btnLoadImageRight
            // 
            this.btnLoadImageRight.Location = new System.Drawing.Point(98, 37);
            this.btnLoadImageRight.Name = "btnLoadImageRight";
            this.btnLoadImageRight.Size = new System.Drawing.Size(69, 21);
            this.btnLoadImageRight.TabIndex = 3;
            this.btnLoadImageRight.Text = "Load Right";
            this.btnLoadImageRight.UseVisualStyleBackColor = true;
            this.btnLoadImageRight.Click += new System.EventHandler(this.btnLoadImageRight_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.label4);
            this.groupBoxParams.Controls.Add(this.textBoxLineSize);
            this.groupBoxParams.Controls.Add(this.label3);
            this.groupBoxParams.Controls.Add(this.textBoxBlockSize);
            this.groupBoxParams.Location = new System.Drawing.Point(199, 282);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(133, 240);
            this.groupBoxParams.TabIndex = 7;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Block Line :";
            // 
            // textBoxLineSize
            // 
            this.textBoxLineSize.Location = new System.Drawing.Point(77, 60);
            this.textBoxLineSize.Name = "textBoxLineSize";
            this.textBoxLineSize.Size = new System.Drawing.Size(42, 20);
            this.textBoxLineSize.TabIndex = 2;
            this.textBoxLineSize.Text = "16";
            this.textBoxLineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Block Size :";
            // 
            // textBoxBlockSize
            // 
            this.textBoxBlockSize.Location = new System.Drawing.Point(77, 37);
            this.textBoxBlockSize.Name = "textBoxBlockSize";
            this.textBoxBlockSize.Size = new System.Drawing.Size(42, 20);
            this.textBoxBlockSize.TabIndex = 0;
            this.textBoxBlockSize.Text = "4";
            this.textBoxBlockSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 534);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSourceRight);
            this.Controls.Add(this.panelSourceLeft);
            this.Name = "MainForm";
            this.Text = "Stereo Vision Project";
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSourceLeft;
        private System.Windows.Forms.Panel panelSourceRight;
        private System.Windows.Forms.Button btnLoadImageLeft;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button btnLoadImageRight;
        private System.Windows.Forms.Button btnBlockMatch;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBlockSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLineSize;
    }
}

