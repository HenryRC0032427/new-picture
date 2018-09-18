namespace new_picture
{
    partial class pathway
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
            this.pBxLink = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBxLink)).BeginInit();
            this.SuspendLayout();
            // 
            // pBxLink
            // 
            this.pBxLink.Image = global::new_picture.Properties.Resources.link;
            this.pBxLink.Location = new System.Drawing.Point(-4, -1);
            this.pBxLink.Name = "pBxLink";
            this.pBxLink.Size = new System.Drawing.Size(140, 156);
            this.pBxLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBxLink.TabIndex = 1;
            this.pBxLink.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "pathway square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "pathway triangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pBxLink);
            this.Name = "pathway";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBxLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBxLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

