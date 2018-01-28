namespace ggj2018
{
    partial class fLevel001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLevel001));
            this.btnHeader = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeader
            // 
            this.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeader.Font = new System.Drawing.Font("Kenney Pixel Square", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeader.Location = new System.Drawing.Point(250, 5);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(300, 51);
            this.btnHeader.TabIndex = 0;
            this.btnHeader.Text = "Level 1 - First Steps";
            this.btnHeader.UseVisualStyleBackColor = true;
            this.btnHeader.Click += new System.EventHandler(this.btnHeader_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::ggj2018.Properties.Resources.returning;
            this.btnReturn.Location = new System.Drawing.Point(556, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(55, 51);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // picHero
            // 
            this.picHero.BackColor = System.Drawing.Color.Transparent;
            this.picHero.Image = global::ggj2018.Properties.Resources.Player_Scientist_01_Down;
            this.picHero.Location = new System.Drawing.Point(138, 252);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(64, 64);
            this.picHero.TabIndex = 2;
            this.picHero.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ggj2018.Properties.Resources.power;
            this.button1.Location = new System.Drawing.Point(717, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfect
            // 
            this.btnInfect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfect.Font = new System.Drawing.Font("Kenney Pixel Square", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfect.Location = new System.Drawing.Point(138, 5);
            this.btnInfect.Name = "btnInfect";
            this.btnInfect.Size = new System.Drawing.Size(106, 50);
            this.btnInfect.TabIndex = 4;
            this.btnInfect.Text = "Infect";
            this.btnInfect.UseVisualStyleBackColor = true;
            this.btnInfect.Click += new System.EventHandler(this.btnInfect_Click);
            // 
            // fLevel001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ggj2018.Properties.Resources.Level001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 574);
            this.Controls.Add(this.btnInfect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLevel001";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabEscape - Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInfect;
    }
}