namespace Baza2
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
            this.flowLayoutPanelSubjects = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.przedmiot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSubjects
            // 
            this.flowLayoutPanelSubjects.Location = new System.Drawing.Point(287, 26);
            this.flowLayoutPanelSubjects.Name = "flowLayoutPanelSubjects";
            this.flowLayoutPanelSubjects.Size = new System.Drawing.Size(469, 373);
            this.flowLayoutPanelSubjects.TabIndex = 0;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.ItemHeight = 16;
            this.listBoxTeachers.Location = new System.Drawing.Point(12, 26);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(247, 372);
            this.listBoxTeachers.TabIndex = 1;
            this.listBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.listBoxTeachers_SelectedIndexChanged);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(12, 415);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(247, 23);
            this.buttonAddTeacher.TabIndex = 2;
            this.buttonAddTeacher.Text = "Dodaj nauczyciela";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            // 
            // przedmiot
            // 
            this.przedmiot.Location = new System.Drawing.Point(287, 415);
            this.przedmiot.Name = "przedmiot";
            this.przedmiot.Size = new System.Drawing.Size(223, 23);
            this.przedmiot.TabIndex = 3;
            this.przedmiot.Text = "button1";
            this.przedmiot.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.przedmiot);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.flowLayoutPanelSubjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSubjects;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button przedmiot;
        private System.Windows.Forms.Button button2;
    }
}

