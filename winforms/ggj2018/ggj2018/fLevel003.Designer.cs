namespace ggj2018
{
    partial class fLevel003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLevel003));
            this.btnInfect = new System.Windows.Forms.Button();
            this.btnHeader = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.btnCountdown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfect
            // 
            this.btnInfect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfect.Font = new System.Drawing.Font("Kenney Pixel Square", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfect.Location = new System.Drawing.Point(138, 5);
            this.btnInfect.Name = "btnInfect";
            this.btnInfect.Size = new System.Drawing.Size(106, 50);
            this.btnInfect.TabIndex = 12;
            this.btnInfect.Text = "Infect";
            this.btnInfect.UseVisualStyleBackColor = true;
            this.btnInfect.Click += new System.EventHandler(this.btnInfect_Click_1);
            // 
            // btnHeader
            // 
            this.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeader.Font = new System.Drawing.Font("Kenney Pixel Square", 9F);
            this.btnHeader.Location = new System.Drawing.Point(250, 5);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(300, 51);
            this.btnHeader.TabIndex = 9;
            this.btnHeader.Text = "Level 3 - The Enemy Lies Within";
            this.btnHeader.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ggj2018.Properties.Resources.power;
            this.button1.Location = new System.Drawing.Point(717, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::ggj2018.Properties.Resources.returning;
            this.btnReturn.Location = new System.Drawing.Point(556, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(55, 51);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // picHero
            // 
            this.picHero.BackColor = System.Drawing.Color.Transparent;
            this.picHero.Image = global::ggj2018.Properties.Resources.Player_Scientist_01_Down;
            this.picHero.Location = new System.Drawing.Point(138, 252);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(64, 64);
            this.picHero.TabIndex = 13;
            this.picHero.TabStop = false;
            // 
            // btnCountdown
            // 
            this.btnCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountdown.Font = new System.Drawing.Font("Kenney Pixel Square", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountdown.Location = new System.Drawing.Point(12, 4);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(62, 50);
            this.btnCountdown.TabIndex = 14;
            this.btnCountdown.Text = "5";
            this.btnCountdown.UseVisualStyleBackColor = true;
            // 
            // fLevel003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ggj2018.Properties.Resources.Level003;
            this.ClientSize = new System.Drawing.Size(784, 574);
            this.Controls.Add(this.btnCountdown);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.btnInfect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLevel003";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLevel003";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.Button btnCountdown;
    }
}