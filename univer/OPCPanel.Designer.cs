namespace univer
{
    partial class OPCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.textBoxSine = new System.Windows.Forms.TextBox();
            this.labelSine = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.groupBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.textBoxRandom);
            this.groupBoxDevice.Controls.Add(this.labelRandom);
            this.groupBoxDevice.Controls.Add(this.textBoxSine);
            this.groupBoxDevice.Controls.Add(this.labelSine);
            this.groupBoxDevice.Controls.Add(this.textBoxRamp);
            this.groupBoxDevice.Controls.Add(this.labelRamp);
            this.groupBoxDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDevice.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(125, 244);
            this.groupBoxDevice.TabIndex = 1;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "Device ";
            
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(11, 180);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(100, 30);
            this.textBoxRandom.TabIndex = 5;
            this.textBoxRandom.Text = "0.00";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(6, 152);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(85, 25);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Random";
            // 
            // textBoxSine
            // 
            this.textBoxSine.Location = new System.Drawing.Point(11, 119);
            this.textBoxSine.Name = "textBoxSine";
            this.textBoxSine.Size = new System.Drawing.Size(100, 30);
            this.textBoxSine.TabIndex = 3;
            this.textBoxSine.Text = "0.00";
            // 
            // labelSine
            // 
            this.labelSine.AutoSize = true;
            this.labelSine.Location = new System.Drawing.Point(6, 90);
            this.labelSine.Name = "labelSine";
            this.labelSine.Size = new System.Drawing.Size(57, 25);
            this.labelSine.TabIndex = 2;
            this.labelSine.Text = "Sine ";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(11, 55);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(100, 30);
            this.textBoxRamp.TabIndex = 1;
            this.textBoxRamp.Text = "0.00";
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Location = new System.Drawing.Point(6, 26);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(68, 25);
            this.labelRamp.TabIndex = 0;
            this.labelRamp.Text = "Ramp ";
            // 
            // OPCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDevice);
            this.Name = "OPCPanel";
            this.Size = new System.Drawing.Size(134, 252);
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.TextBox textBoxSine;
        private System.Windows.Forms.Label labelSine;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label labelRamp;
    }
}
