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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFact
            // 
            txtFact.Location = new Point(605, 12);
            txtFact.Multiline = true;
            txtFact.Name = "txtFact";
            txtFact.Size = new Size(183, 175);
            txtFact.TabIndex = 0;
            // 
            // btnGetFact
            // 
            btnGetFact.BackColor = SystemColors.HotTrack;
            btnGetFact.Location = new Point(605, 193);
            btnGetFact.Name = "btnGetFact";
            btnGetFact.Size = new Size(183, 28);
            btnGetFact.TabIndex = 1;
            btnGetFact.Text = "Узнать факт";
            btnGetFact.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 392);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(67, 410);
            button1.Name = "button1";
            button1.Size = new Size(234, 28);
            button1.TabIndex = 3;
            button1.Text = "Увидеть фото";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGetFact);
            Controls.Add(txtFact);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFact;
        private Button btnGetFact;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
