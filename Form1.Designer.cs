namespace CarRental
{
    partial class design1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(design1));
            this.myprogress = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parcentage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myprogress)).BeginInit();
            this.SuspendLayout();
            // 
            // myprogress
            // 
            this.myprogress.Image = ((System.Drawing.Image)(resources.GetObject("myprogress.Image")));
            this.myprogress.Location = new System.Drawing.Point(176, 80);
            this.myprogress.Name = "myprogress";
            this.myprogress.Size = new System.Drawing.Size(416, 251);
            this.myprogress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myprogress.TabIndex = 0;
            this.myprogress.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(176, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 33);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parcentage
            // 
            this.parcentage.AutoSize = true;
            this.parcentage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.parcentage.Location = new System.Drawing.Point(313, 369);
            this.parcentage.Name = "parcentage";
            this.parcentage.Size = new System.Drawing.Size(121, 16);
            this.parcentage.TabIndex = 4;
            this.parcentage.Text = "parcentageShower";
            this.parcentage.Click += new System.EventHandler(this.parcentage_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightCyan;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(300, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 34);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "Bike on Rentals";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // design1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.parcentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.myprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "design1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.design1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myprogress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myprogress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label parcentage;
        private System.Windows.Forms.TextBox textBox2;
    }
}

