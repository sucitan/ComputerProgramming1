namespace Adventure_Game
{
    partial class frm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.Location = new System.Drawing.Point(90, 338);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "High Wall";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.Location = new System.Drawing.Point(268, 338);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 39);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Irithyll";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBox.Location = new System.Drawing.Point(90, 256);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(290, 62);
            this.txtBox.TabIndex = 4;
            this.txtBox.Text = "You awaken at firelink shrine \r\nyou see a bonfire which connects to \r\n other Bonf" +
    "ires one in Highwall and one in\r\n Irithyll";
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gold;
            this.btn4.Location = new System.Drawing.Point(268, 402);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(112, 33);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.Location = new System.Drawing.Point(90, 402);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(119, 33);
            this.btn3.TabIndex = 1;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picbox.Image = global::Adventure_Game.Properties.Resources.firelink_Shrine;
            this.picbox.Location = new System.Drawing.Point(90, 60);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(290, 167);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 6;
            this.picbox.TabStop = false;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(503, 481);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Name = "frm";
            this.Text = "Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
    }
}

