namespace MapBuilder
{
    partial class BuilderForm
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
            this.Canvas_pictureBox = new System.Windows.Forms.PictureBox();
            this.NewCanvas_button = new System.Windows.Forms.Button();
            this.NewCanvasWidth_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewCanvasHeight_textBox = new System.Windows.Forms.TextBox();
            this.NewSquarePreview_pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewSquareBadness_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewSquareHeight_textBox = new System.Windows.Forms.TextBox();
            this.NewSquare_button = new System.Windows.Forms.Button();
            this.FileName_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveFile_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewSquarePreview_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas_pictureBox
            // 
            this.Canvas_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.Canvas_pictureBox.Name = "Canvas_pictureBox";
            this.Canvas_pictureBox.Size = new System.Drawing.Size(700, 700);
            this.Canvas_pictureBox.TabIndex = 0;
            this.Canvas_pictureBox.TabStop = false;
            this.Canvas_pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_pictureBox_MouseClick);
            // 
            // NewCanvas_button
            // 
            this.NewCanvas_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCanvas_button.Location = new System.Drawing.Point(778, 113);
            this.NewCanvas_button.Name = "NewCanvas_button";
            this.NewCanvas_button.Size = new System.Drawing.Size(294, 59);
            this.NewCanvas_button.TabIndex = 1;
            this.NewCanvas_button.Text = "Create new canvas";
            this.NewCanvas_button.UseVisualStyleBackColor = true;
            this.NewCanvas_button.Click += new System.EventHandler(this.NewCanvas_button_Click);
            // 
            // NewCanvasWidth_textBox
            // 
            this.NewCanvasWidth_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCanvasWidth_textBox.Location = new System.Drawing.Point(917, 40);
            this.NewCanvasWidth_textBox.Name = "NewCanvasWidth_textBox";
            this.NewCanvasWidth_textBox.Size = new System.Drawing.Size(155, 29);
            this.NewCanvasWidth_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(778, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(778, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCanvasHeight_textBox
            // 
            this.NewCanvasHeight_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCanvasHeight_textBox.Location = new System.Drawing.Point(917, 78);
            this.NewCanvasHeight_textBox.Name = "NewCanvasHeight_textBox";
            this.NewCanvasHeight_textBox.Size = new System.Drawing.Size(155, 29);
            this.NewCanvasHeight_textBox.TabIndex = 4;
            // 
            // NewSquarePreview_pictureBox
            // 
            this.NewSquarePreview_pictureBox.Location = new System.Drawing.Point(946, 327);
            this.NewSquarePreview_pictureBox.Name = "NewSquarePreview_pictureBox";
            this.NewSquarePreview_pictureBox.Size = new System.Drawing.Size(200, 200);
            this.NewSquarePreview_pictureBox.TabIndex = 6;
            this.NewSquarePreview_pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(946, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Square preview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewSquareBadness_textBox
            // 
            this.NewSquareBadness_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSquareBadness_textBox.Location = new System.Drawing.Point(783, 327);
            this.NewSquareBadness_textBox.Name = "NewSquareBadness_textBox";
            this.NewSquareBadness_textBox.Size = new System.Drawing.Size(155, 29);
            this.NewSquareBadness_textBox.TabIndex = 8;
            this.NewSquareBadness_textBox.TextChanged += new System.EventHandler(this.NewSquare_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(792, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Badness";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(792, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewSquareHeight_textBox
            // 
            this.NewSquareHeight_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSquareHeight_textBox.Location = new System.Drawing.Point(783, 417);
            this.NewSquareHeight_textBox.Name = "NewSquareHeight_textBox";
            this.NewSquareHeight_textBox.Size = new System.Drawing.Size(155, 29);
            this.NewSquareHeight_textBox.TabIndex = 10;
            // 
            // NewSquare_button
            // 
            this.NewSquare_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSquare_button.Location = new System.Drawing.Point(784, 480);
            this.NewSquare_button.Name = "NewSquare_button";
            this.NewSquare_button.Size = new System.Drawing.Size(154, 47);
            this.NewSquare_button.TabIndex = 12;
            this.NewSquare_button.Text = "Select";
            this.NewSquare_button.UseVisualStyleBackColor = true;
            this.NewSquare_button.Click += new System.EventHandler(this.NewSquare_button_Click);
            // 
            // FileName_textBox
            // 
            this.FileName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName_textBox.Location = new System.Drawing.Point(951, 586);
            this.FileName_textBox.Name = "FileName_textBox";
            this.FileName_textBox.Size = new System.Drawing.Size(195, 29);
            this.FileName_textBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(792, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "File name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFile_button
            // 
            this.SaveFile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFile_button.Location = new System.Drawing.Point(784, 625);
            this.SaveFile_button.Name = "SaveFile_button";
            this.SaveFile_button.Size = new System.Drawing.Size(362, 87);
            this.SaveFile_button.TabIndex = 15;
            this.SaveFile_button.Text = "Save";
            this.SaveFile_button.UseVisualStyleBackColor = true;
            this.SaveFile_button.Click += new System.EventHandler(this.SaveFile_button_Click);
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 742);
            this.Controls.Add(this.SaveFile_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FileName_textBox);
            this.Controls.Add(this.NewSquare_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewSquareHeight_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewSquareBadness_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewSquarePreview_pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewCanvasHeight_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewCanvasWidth_textBox);
            this.Controls.Add(this.NewCanvas_button);
            this.Controls.Add(this.Canvas_pictureBox);
            this.Name = "BuilderForm";
            this.Text = "BuilderForm";
            this.Load += new System.EventHandler(this.BuilderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewSquarePreview_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas_pictureBox;
        private System.Windows.Forms.Button NewCanvas_button;
        private System.Windows.Forms.TextBox NewCanvasWidth_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewCanvasHeight_textBox;
        private System.Windows.Forms.PictureBox NewSquarePreview_pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewSquareBadness_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewSquareHeight_textBox;
        private System.Windows.Forms.Button NewSquare_button;
        private System.Windows.Forms.TextBox FileName_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveFile_button;
    }
}