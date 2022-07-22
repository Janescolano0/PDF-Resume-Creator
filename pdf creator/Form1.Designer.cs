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
            this.lbl__JSON = new System.Windows.Forms.Label();
            this.btn__generate = new System.Windows.Forms.Button();
            this.btn__show = new System.Windows.Forms.Button();
            this.lbl__PDF = new System.Windows.Forms.Label();
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
            this.tbox__show.ReadOnly = true;
            this.tbox__show.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox__show.Size = new System.Drawing.Size(391, 383);
            this.tbox__show.TabIndex = 0;
            // 
            // lbl__JSON
            // 
            this.lbl__JSON.AutoSize = true;
            this.lbl__JSON.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__JSON.ForeColor = System.Drawing.Color.Snow;
            this.lbl__JSON.Location = new System.Drawing.Point(507, 32);
            this.lbl__JSON.Name = "lbl__JSON";
            this.lbl__JSON.Size = new System.Drawing.Size(95, 45);
            this.lbl__JSON.TabIndex = 1;
            this.lbl__JSON.Text = "JSON";
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
            this.btn__generate.Click += new System.EventHandler(this.btn__generate_Click);
            // 
            // btn__show
            // 
            this.btn__show.BackColor = System.Drawing.Color.DimGray;
            this.btn__show.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn__show.Location = new System.Drawing.Point(429, 402);
            this.btn__show.Name = "btn__show";
            this.btn__show.Size = new System.Drawing.Size(151, 56);
            this.btn__show.TabIndex = 3;
            this.btn__show.Text = "Show Info";
            this.btn__show.UseVisualStyleBackColor = false;
            this.btn__show.Click += new System.EventHandler(this.btn__show_Click);
            // 
            // lbl__PDF
            // 
            this.lbl__PDF.AutoSize = true;
            this.lbl__PDF.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__PDF.ForeColor = System.Drawing.Color.Snow;
            this.lbl__PDF.Location = new System.Drawing.Point(525, 188);
            this.lbl__PDF.Name = "lbl__PDF";
            this.lbl__PDF.Size = new System.Drawing.Size(77, 45);
            this.lbl__PDF.TabIndex = 4;
            this.lbl__PDF.Text = "PDF";
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
            this.btn__generate2.Click += new System.EventHandler(this.btn__generate2_Click);
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
            this.Controls.Add(this.lbl__PDF);
            this.Controls.Add(this.btn__show);
            this.Controls.Add(this.btn__generate);
            this.Controls.Add(this.lbl__JSON);
            this.Controls.Add(this.tbox__show);
            this.Name = "PDFandJSONcreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF and JSON Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox__show;
        private System.Windows.Forms.Label lbl__JSON;
        private System.Windows.Forms.Button btn__generate;
        private System.Windows.Forms.Button btn__show;
        private System.Windows.Forms.Label lbl__PDF;
        private System.Windows.Forms.Button btn__generate2;
        private System.Windows.Forms.Label lbl__display;
    }
}

