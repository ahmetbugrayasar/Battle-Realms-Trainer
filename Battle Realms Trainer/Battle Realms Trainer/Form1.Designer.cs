namespace Battle_Realms_Trainer
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
            this.CheckboxRice = new System.Windows.Forms.CheckBox();
            this.CheckboxVillager = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // CheckboxRice
            // 
            this.CheckboxRice.AutoSize = true;
            this.CheckboxRice.Checked = true;
            this.CheckboxRice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxRice.Location = new System.Drawing.Point(12, 341);
            this.CheckboxRice.Name = "CheckboxRice";
            this.CheckboxRice.Size = new System.Drawing.Size(82, 17);
            this.CheckboxRice.TabIndex = 0;
            this.CheckboxRice.Text = "Infinite Rice";
            this.CheckboxRice.UseVisualStyleBackColor = true;
            // 
            // CheckboxVillager
            // 
            this.CheckboxVillager.AutoSize = true;
            this.CheckboxVillager.Checked = true;
            this.CheckboxVillager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxVillager.Location = new System.Drawing.Point(12, 318);
            this.CheckboxVillager.Name = "CheckboxVillager";
            this.CheckboxVillager.Size = new System.Drawing.Size(99, 17);
            this.CheckboxVillager.TabIndex = 1;
            this.CheckboxVillager.Text = "Infinite Villagers";
            this.CheckboxVillager.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 370);
            this.Controls.Add(this.CheckboxVillager);
            this.Controls.Add(this.CheckboxRice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckboxRice;
        private System.Windows.Forms.CheckBox CheckboxVillager;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

