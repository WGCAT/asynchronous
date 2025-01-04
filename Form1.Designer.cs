namespace asynchronous
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
            btnWalking = new Button();
            btnTalking = new Button();
            btnPhone = new Button();
            lblWalking = new Label();
            lblTalking = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // btnWalking
            // 
            btnWalking.Location = new Point(12, 12);
            btnWalking.Name = "btnWalking";
            btnWalking.Size = new Size(124, 69);
            btnWalking.TabIndex = 0;
            btnWalking.Text = "걷기";
            btnWalking.UseVisualStyleBackColor = true;
            btnWalking.Click += this.btnWalking_Click;
            // 
            // btnTalking
            // 
            btnTalking.Location = new Point(12, 162);
            btnTalking.Name = "btnTalking";
            btnTalking.Size = new Size(124, 69);
            btnTalking.TabIndex = 1;
            btnTalking.Text = "말하기";
            btnTalking.UseVisualStyleBackColor = true;
            btnTalking.Click += btnTalking_Click;
            // 
            // btnPhone
            // 
            btnPhone.Location = new Point(12, 87);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(124, 69);
            btnPhone.TabIndex = 2;
            btnPhone.Text = "휴대폰보기";
            btnPhone.UseVisualStyleBackColor = true;
            btnPhone.Click += this.btnPhone_Click;
            // 
            // lblWalking
            // 
            lblWalking.AutoSize = true;
            lblWalking.Location = new Point(142, 39);
            lblWalking.Name = "lblWalking";
            lblWalking.Size = new Size(39, 15);
            lblWalking.TabIndex = 3;
            lblWalking.Text = "label1";
            // 
            // lblTalking
            // 
            lblTalking.AutoSize = true;
            lblTalking.Location = new Point(142, 189);
            lblTalking.Name = "lblTalking";
            lblTalking.Size = new Size(39, 15);
            lblTalking.TabIndex = 4;
            lblTalking.Text = "label3";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(142, 114);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(39, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPhone);
            Controls.Add(lblTalking);
            Controls.Add(lblWalking);
            Controls.Add(btnPhone);
            Controls.Add(btnTalking);
            Controls.Add(btnWalking);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWalking;
        private Button btnTalking;
        private Button btnPhone;
        private Label lblWalking;
        private Label lblTalking;
        private Label lblPhone;
    }
}
