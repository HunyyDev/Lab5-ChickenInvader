namespace Lab5
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
            this.components = new System.ComponentModel.Container();
            this.PlanePicBox = new System.Windows.Forms.PictureBox();
            this.MeteroritePicBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlanePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeteroritePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanePicBox
            // 
            this.PlanePicBox.BackColor = System.Drawing.Color.Transparent;
            this.PlanePicBox.Image = global::Lab5.Properties.Resources.pngwing_com;
            this.PlanePicBox.Location = new System.Drawing.Point(466, 488);
            this.PlanePicBox.Name = "PlanePicBox";
            this.PlanePicBox.Size = new System.Drawing.Size(72, 99);
            this.PlanePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlanePicBox.TabIndex = 1;
            this.PlanePicBox.TabStop = false;
            // 
            // MeteroritePicBox
            // 
            this.MeteroritePicBox.BackColor = System.Drawing.Color.Transparent;
            this.MeteroritePicBox.Image = global::Lab5.Properties.Resources.meteorite_pngrepo_com;
            this.MeteroritePicBox.Location = new System.Drawing.Point(184, 12);
            this.MeteroritePicBox.Name = "MeteroritePicBox";
            this.MeteroritePicBox.Size = new System.Drawing.Size(90, 90);
            this.MeteroritePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeteroritePicBox.TabIndex = 0;
            this.MeteroritePicBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 616);
            this.Controls.Add(this.PlanePicBox);
            this.Controls.Add(this.MeteroritePicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PlanePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeteroritePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MeteroritePicBox;
        private System.Windows.Forms.PictureBox PlanePicBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

