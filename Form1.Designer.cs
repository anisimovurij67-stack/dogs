namespace DogPep
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFact = new TextBox();
            btnGetFact = new Button();
            SuspendLayout();
            // 
            // txtFact
            // 
            txtFact.Location = new Point(12, 12);
            txtFact.Multiline = true;
            txtFact.Name = "txtFact";
            txtFact.Size = new Size(159, 131);
            txtFact.TabIndex = 0;
            // 
            // btnGetFact
            // 
            btnGetFact.Location = new Point(177, 12);
            btnGetFact.Name = "btnGetFact";
            btnGetFact.Size = new Size(206, 104);
            btnGetFact.TabIndex = 1;
            btnGetFact.Text = "Узнать факт";
            btnGetFact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetFact);
            Controls.Add(txtFact);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFact;
        private Button btnGetFact;
    }
}
