namespace SlotMachine
{
    partial class Form1
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
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.PicBox3 = new System.Windows.Forms.PictureBox();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreditsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox1
            // 
            this.PicBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.PicBox1.Location = new System.Drawing.Point(84, 121);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(60, 60);
            this.PicBox1.TabIndex = 0;
            this.PicBox1.TabStop = false;
            // 
            // PicBox2
            // 
            this.PicBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.PicBox2.Location = new System.Drawing.Point(312, 121);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(60, 60);
            this.PicBox2.TabIndex = 1;
            this.PicBox2.TabStop = false;
            // 
            // PicBox3
            // 
            this.PicBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.PicBox3.Location = new System.Drawing.Point(521, 121);
            this.PicBox3.Name = "PicBox3";
            this.PicBox3.Size = new System.Drawing.Size(60, 60);
            this.PicBox3.TabIndex = 2;
            this.PicBox3.TabStop = false;
            // 
            // SpinBtn
            // 
            this.SpinBtn.Location = new System.Drawing.Point(278, 300);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(125, 45);
            this.SpinBtn.TabIndex = 3;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = true;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(379, 27);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(20, 24);
            this.ScoreLbl.TabIndex = 5;
            this.ScoreLbl.Text = "0";
            this.ScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Credits:";
            // 
            // CreditsLbl
            // 
            this.CreditsLbl.AutoSize = true;
            this.CreditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLbl.Location = new System.Drawing.Point(150, 27);
            this.CreditsLbl.Name = "CreditsLbl";
            this.CreditsLbl.Size = new System.Drawing.Size(20, 24);
            this.CreditsLbl.TabIndex = 7;
            this.CreditsLbl.Text = "0";
            this.CreditsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 383);
            this.Controls.Add(this.CreditsLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.PicBox3);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.PicBox1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.PictureBox PicBox3;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CreditsLbl;
    }
}

