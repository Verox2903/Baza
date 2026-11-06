namespace Baza2
{
    partial class UserControlSubject
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.labelGodziny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(57, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(312, 13);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 1;
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Location = new System.Drawing.Point(3, 10);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(48, 16);
            this.labelNazwa.TabIndex = 2;
            this.labelNazwa.Text = "Nazwa";
            // 
            // labelGodziny
            // 
            this.labelGodziny.AutoSize = true;
            this.labelGodziny.Location = new System.Drawing.Point(234, 13);
            this.labelGodziny.Name = "labelGodziny";
            this.labelGodziny.Size = new System.Drawing.Size(56, 16);
            this.labelGodziny.TabIndex = 3;
            this.labelGodziny.Text = "Godziny";
            // 
            // UserControlSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGodziny);
            this.Controls.Add(this.labelNazwa);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxName);
            this.Name = "UserControlSubject";
            this.Size = new System.Drawing.Size(452, 44);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.Label labelGodziny;
    }
}
