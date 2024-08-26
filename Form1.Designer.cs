namespace StartButton_Fix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLeft = new System.Windows.Forms.RadioButton();
            this.btnCenter = new System.Windows.Forms.RadioButton();
            this.btnReapirStartButton = new System.Windows.Forms.Button();
            this.ckbCloseAfterRepair = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnCenter);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Current Button Location";
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Location = new System.Drawing.Point(17, 47);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(92, 17);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.TabStop = true;
            this.btnLeft.Tag = "0";
            this.btnLeft.Text = "Button is left ?";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.CheckedChanged += new System.EventHandler(this.btnLeft_CheckedChanged);
            // 
            // btnCenter
            // 
            this.btnCenter.AutoSize = true;
            this.btnCenter.Location = new System.Drawing.Point(17, 23);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(120, 17);
            this.btnCenter.TabIndex = 0;
            this.btnCenter.TabStop = true;
            this.btnCenter.Tag = "1";
            this.btnCenter.Text = "Button is centered ?";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.CheckedChanged += new System.EventHandler(this.btnCenter_CheckedChanged);
            // 
            // btnReapirStartButton
            // 
            this.btnReapirStartButton.Location = new System.Drawing.Point(29, 164);
            this.btnReapirStartButton.Name = "btnReapirStartButton";
            this.btnReapirStartButton.Size = new System.Drawing.Size(175, 23);
            this.btnReapirStartButton.TabIndex = 1;
            this.btnReapirStartButton.Text = "Repair Start Button";
            this.btnReapirStartButton.UseVisualStyleBackColor = true;
            this.btnReapirStartButton.Click += new System.EventHandler(this.btnReapirStartButton_Click);
            // 
            // ckbCloseAfterRepair
            // 
            this.ckbCloseAfterRepair.AutoSize = true;
            this.ckbCloseAfterRepair.Location = new System.Drawing.Point(46, 106);
            this.ckbCloseAfterRepair.Name = "ckbCloseAfterRepair";
            this.ckbCloseAfterRepair.Size = new System.Drawing.Size(111, 17);
            this.ckbCloseAfterRepair.TabIndex = 2;
            this.ckbCloseAfterRepair.Text = "Close after repair?";
            this.ckbCloseAfterRepair.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 135);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 199);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ckbCloseAfterRepair);
            this.Controls.Add(this.btnReapirStartButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Button Repair";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnLeft;
        private System.Windows.Forms.RadioButton btnCenter;
        private System.Windows.Forms.Button btnReapirStartButton;
        private System.Windows.Forms.CheckBox ckbCloseAfterRepair;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

