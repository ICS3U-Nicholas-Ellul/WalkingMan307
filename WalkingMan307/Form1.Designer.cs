namespace WalkingMan307
{
    partial class frmWalkingMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWalkingMan));
            this.picMan = new System.Windows.Forms.PictureBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picMan
            // 
            this.picMan.Location = new System.Drawing.Point(548, 188);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(100, 50);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMan.TabIndex = 0;
            this.picMan.TabStop = false;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(-9, 344);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(697, 13);
            this.lblFloor.TabIndex = 1;
            this.lblFloor.Text = resources.GetString("lblFloor.Text");
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(311, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "g2gFastM9";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(300, 277);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 3;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 416);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.picMan);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMan;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtBox;
    }
}

