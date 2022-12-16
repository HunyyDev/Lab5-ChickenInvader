namespace Lab5
{
    partial class Game
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
            this.bulletsTm = new System.Windows.Forms.Timer(this.components);
            this.meteoriteGenerateTm = new System.Windows.Forms.Timer(this.components);
            this.meteoriteFallTm = new System.Windows.Forms.Timer(this.components);
            this.bulletsFly = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bulletsTm
            // 
            this.bulletsTm.Enabled = true;
            this.bulletsTm.Interval = 1;
            this.bulletsTm.Tick += new System.EventHandler(this.bulletsTm_Tick);
            // 
            // meteoriteGenerateTm
            // 
            this.meteoriteGenerateTm.Enabled = true;
            this.meteoriteGenerateTm.Interval = 500;
            this.meteoriteGenerateTm.Tick += new System.EventHandler(this.meteoriteGenerateTm_Tick);
            // 
            // meteoriteFallTm
            // 
            this.meteoriteFallTm.Enabled = true;
            this.meteoriteFallTm.Interval = 1;
            this.meteoriteFallTm.Tick += new System.EventHandler(this.meteoriteFallTm_Tick);
            // 
            // bulletsFly
            // 
            this.bulletsFly.Enabled = true;
            this.bulletsFly.Interval = 1;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer bulletsTm;
        private System.Windows.Forms.Timer meteoriteGenerateTm;
        private System.Windows.Forms.Timer meteoriteFallTm;
        private System.Windows.Forms.Timer bulletsFly;
    }
}