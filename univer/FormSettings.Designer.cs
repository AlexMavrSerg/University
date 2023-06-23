namespace univer
{
    partial class FormSettings
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
            this.textBoxMachineName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelUpdataRate = new System.Windows.Forms.Label();
            this.textBoxUpdataRate = new System.Windows.Forms.TextBox();
            this.labelServerClass = new System.Windows.Forms.Label();
            this.textBoxServerClass = new System.Windows.Forms.TextBox();
            this.listBoxOPCTags = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxMachineName
            // 
            this.textBoxMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMachineName.Location = new System.Drawing.Point(41, 65);
            this.textBoxMachineName.Name = "textBoxMachineName";
            this.textBoxMachineName.Size = new System.Drawing.Size(193, 30);
            this.textBoxMachineName.TabIndex = 0;
            this.textBoxMachineName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(204, 356);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(139, 32);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(349, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 32);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMachineName
            // 
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMachineName.Location = new System.Drawing.Point(49, 37);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(144, 25);
            this.labelMachineName.TabIndex = 12;
            this.labelMachineName.Text = "Machine Name";
            // 
            // labelUpdataRate
            // 
            this.labelUpdataRate.AutoSize = true;
            this.labelUpdataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdataRate.Location = new System.Drawing.Point(262, 37);
            this.labelUpdataRate.Name = "labelUpdataRate";
            this.labelUpdataRate.Size = new System.Drawing.Size(120, 25);
            this.labelUpdataRate.TabIndex = 14;
            this.labelUpdataRate.Text = "Updata Rate";
            // 
            // textBoxUpdataRate
            // 
            this.textBoxUpdataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUpdataRate.Location = new System.Drawing.Point(257, 65);
            this.textBoxUpdataRate.Name = "textBoxUpdataRate";
            this.textBoxUpdataRate.Size = new System.Drawing.Size(125, 30);
            this.textBoxUpdataRate.TabIndex = 13;
            // 
            // labelServerClass
            // 
            this.labelServerClass.AutoSize = true;
            this.labelServerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServerClass.Location = new System.Drawing.Point(49, 107);
            this.labelServerClass.Name = "labelServerClass";
            this.labelServerClass.Size = new System.Drawing.Size(125, 25);
            this.labelServerClass.TabIndex = 16;
            this.labelServerClass.Text = "Server Class";
            // 
            // textBoxServerClass
            // 
            this.textBoxServerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxServerClass.Location = new System.Drawing.Point(41, 135);
            this.textBoxServerClass.Name = "textBoxServerClass";
            this.textBoxServerClass.Size = new System.Drawing.Size(447, 30);
            this.textBoxServerClass.TabIndex = 15;
            // 
            // listBoxOPCTags
            // 
            this.listBoxOPCTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOPCTags.FormattingEnabled = true;
            this.listBoxOPCTags.ItemHeight = 25;
            this.listBoxOPCTags.Location = new System.Drawing.Point(41, 171);
            this.listBoxOPCTags.Name = "listBoxOPCTags";
            this.listBoxOPCTags.Size = new System.Drawing.Size(447, 179);
            this.listBoxOPCTags.TabIndex = 17;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.listBoxOPCTags);
            this.Controls.Add(this.labelServerClass);
            this.Controls.Add(this.textBoxServerClass);
            this.Controls.Add(this.labelUpdataRate);
            this.Controls.Add(this.textBoxUpdataRate);
            this.Controls.Add(this.labelMachineName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMachineName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSetings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMachineName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelUpdataRate;
        private System.Windows.Forms.TextBox textBoxUpdataRate;
        private System.Windows.Forms.Label labelServerClass;
        private System.Windows.Forms.TextBox textBoxServerClass;
        private System.Windows.Forms.ListBox listBoxOPCTags;
    }
}