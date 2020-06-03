namespace karambol
{
    partial class Karambol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karambol));
            this.asztal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pontok = new System.Windows.Forms.Label();
            this.elet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asztal
            // 
            this.asztal.BackColor = System.Drawing.Color.Maroon;
            this.asztal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asztal.BackgroundImage")));
            this.asztal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asztal.Location = new System.Drawing.Point(0, 91);
            this.asztal.Name = "asztal";
            this.asztal.Size = new System.Drawing.Size(782, 459);
            this.asztal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontok: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Élet :";
            // 
            // pontok
            // 
            this.pontok.AutoSize = true;
            this.pontok.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pontok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pontok.Location = new System.Drawing.Point(106, 9);
            this.pontok.Name = "pontok";
            this.pontok.Size = new System.Drawing.Size(20, 23);
            this.pontok.TabIndex = 4;
            this.pontok.Text = "0";
            // 
            // elet
            // 
            this.elet.AutoSize = true;
            this.elet.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.elet.Location = new System.Drawing.Point(106, 46);
            this.elet.Name = "elet";
            this.elet.Size = new System.Drawing.Size(20, 23);
            this.elet.TabIndex = 5;
            this.elet.Text = "3";
            // 
            // Karambol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.elet);
            this.Controls.Add(this.pontok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asztal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Karambol";
            this.Text = "Karambol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel asztal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pontok;
        private System.Windows.Forms.Label elet;
    }
}

