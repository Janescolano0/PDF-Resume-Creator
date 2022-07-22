namespace pdf_creator
{
    partial class PDFandJSONcreator
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
            this.tbox__show = new System.Windows.Forms.TextBox();
            this.lbl__JSONfile = new System.Windows.Forms.Label();
            this.btn__generate = new System.Windows.Forms.Button();
            this.btn__show = new System.Windows.Forms.Button();
            this.lbl__PDFfile = new System.Windows.Forms.Label();
            this.btn__generate2 = new System.Windows.Forms.Button();
            this.lbl__display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox__show
            // 
            this.tbox__show.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbox__show.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox__show.Location = new System.Drawing.Point(32, 75);
            this.tbox__show.Multiline = true;
            this.tbox__show.Name = "tbox__show";
            this.tbox__show.Size = new System.Drawing.Size(309, 383);
            this.tbox__show.TabIndex = 0;
            // 
            // lbl__JSONfile
            // 
            this.lbl__JSONfile.AutoSize = true;
            this.lbl__JSONfile.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__JSONfile.ForeColor = System.Drawing.Color.Snow;
            this.lbl__JSONfile.Location = new System.Drawing.Point(445, 32);
            this.lbl__JSONfile.Name = "lbl__JSONfile";
            this.lbl__JSONfile.Size = new System.Drawing.Size(157, 45);
            this.lbl__JSONfile.TabIndex = 1;
            this.lbl__JSONfile.Text = "JSON File";
            // 
            // btn__generate
            // 
            this.btn__generate.BackColor = System.Drawing.Color.DimGray;
            this.btn__generate.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__generate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn__generate.Location = new System.Drawing.Point(608, 28);
            this.btn__generate.Name = "btn__generate";
            this.btn__generate.Size = new System.Drawing.Size(180, 56);
            this.btn__generate.TabIndex = 2;
            this.btn__generate.Text = "Generate";
            this.btn__generate.UseVisualStyleBackColor = false;
            // 
            // btn__show
            // 
            this.btn__show.BackColor = System.Drawing.Color.DimGray;
            this.btn__show.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn__show.Location = new System.Drawing.Point(347, 402);
            this.btn__show.Name = "btn__show";
            this.btn__show.Size = new System.Drawing.Size(151, 56);
            this.btn__show.TabIndex = 3;
            this.btn__show.Text = "Show Info";
            this.btn__show.UseVisualStyleBackColor = false;
            // 
            // lbl__PDFfile
            // 
            this.lbl__PDFfile.AutoSize = true;
            this.lbl__PDFfile.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__PDFfile.ForeColor = System.Drawing.Color.Snow;
            this.lbl__PDFfile.Location = new System.Drawing.Point(463, 195);
            this.lbl__PDFfile.Name = "lbl__PDFfile";
            this.lbl__PDFfile.Size = new System.Drawing.Size(139, 45);
            this.lbl__PDFfile.TabIndex = 4;
            this.lbl__PDFfile.Text = "PDF File";
            // 
            // btn__generate2
            // 
            this.btn__generate2.BackColor = System.Drawing.Color.DimGray;
            this.btn__generate2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__generate2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn__generate2.Location = new System.Drawing.Point(608, 184);
            this.btn__generate2.Name = "btn__generate2";
            this.btn__generate2.Size = new System.Drawing.Size(180, 56);
            this.btn__generate2.TabIndex = 5;
            this.btn__generate2.Text = "Generate";
            this.btn__generate2.UseVisualStyleBackColor = false;
            // 
            // lbl__display
            // 
            this.lbl__display.AutoSize = true;
            this.lbl__display.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__display.ForeColor = System.Drawing.Color.Snow;
            this.lbl__display.Location = new System.Drawing.Point(26, 39);
            this.lbl__display.Name = "lbl__display";
            this.lbl__display.Size = new System.Drawing.Size(93, 33);
            this.lbl__display.TabIndex = 6;
            this.lbl__display.Text = "Display";
            // 
            // PDFandJSONcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lbl__display);
            this.Controls.Add(this.btn__generate2);
            this.Controls.Add(this.lbl__PDFfile);
            this.Controls.Add(this.btn__show);
            this.Controls.Add(this.btn__generate);
            this.Controls.Add(this.lbl__JSONfile);
            this.Controls.Add(this.tbox__show);
            this.Name = "PDFandJSONcreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF and JSON Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox__show;
        private System.Windows.Forms.Label lbl__JSONfile;
        private System.Windows.Forms.Button btn__generate;
        private System.Windows.Forms.Button btn__show;
        private System.Windows.Forms.Label lbl__PDFfile;
        private System.Windows.Forms.Button btn__generate2;
        private System.Windows.Forms.Label lbl__display;
    }
}

