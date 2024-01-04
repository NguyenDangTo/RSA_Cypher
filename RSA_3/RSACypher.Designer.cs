namespace RSA_3
{
    partial class RSACypher
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
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button3 = new Button();
            txtEncrypt = new TextBox();
            txtDecrypt = new TextBox();
            txtbox = new TextBox();
            txtPublicKey = new TextBox();
            btnGeneratePublicKey = new Button();
            txtPrivateKey = new TextBox();
            btnGeneratePrivateKey = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtP = new TextBox();
            txtQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtE = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(111, 540);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(179, 43);
            button2.TabIndex = 1;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += encryptBtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(585, 540);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(177, 43);
            button3.TabIndex = 2;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += decryptBtn_Click;
            // 
            // txtEncrypt
            // 
            txtEncrypt.Location = new Point(111, 238);
            txtEncrypt.Margin = new Padding(3, 4, 3, 4);
            txtEncrypt.Multiline = true;
            txtEncrypt.Name = "txtEncrypt";
            txtEncrypt.Size = new Size(412, 276);
            txtEncrypt.TabIndex = 3;
            // 
            // txtDecrypt
            // 
            txtDecrypt.Location = new Point(585, 238);
            txtDecrypt.Margin = new Padding(3, 4, 3, 4);
            txtDecrypt.Multiline = true;
            txtDecrypt.Name = "txtDecrypt";
            txtDecrypt.Size = new Size(412, 276);
            txtDecrypt.TabIndex = 4;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(111, 118);
            txtbox.Margin = new Padding(3, 4, 3, 4);
            txtbox.Multiline = true;
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(412, 97);
            txtbox.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            txtPublicKey.Location = new Point(111, 606);
            txtPublicKey.Margin = new Padding(3, 4, 3, 4);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.Size = new Size(412, 69);
            txtPublicKey.TabIndex = 6;
            // 
            // btnGeneratePublicKey
            // 
            btnGeneratePublicKey.BackColor = Color.Lavender;
            btnGeneratePublicKey.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneratePublicKey.Location = new Point(111, 703);
            btnGeneratePublicKey.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePublicKey.Name = "btnGeneratePublicKey";
            btnGeneratePublicKey.Size = new Size(179, 43);
            btnGeneratePublicKey.TabIndex = 7;
            btnGeneratePublicKey.Text = "Random public key";
            btnGeneratePublicKey.UseVisualStyleBackColor = false;
            btnGeneratePublicKey.Click += btnGeneratePublicKey_Click;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(585, 606);
            txtPrivateKey.Margin = new Padding(3, 4, 3, 4);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.Size = new Size(412, 69);
            txtPrivateKey.TabIndex = 8;
            // 
            // btnGeneratePrivateKey
            // 
            btnGeneratePrivateKey.BackColor = Color.Lavender;
            btnGeneratePrivateKey.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneratePrivateKey.Location = new Point(585, 703);
            btnGeneratePrivateKey.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePrivateKey.Name = "btnGeneratePrivateKey";
            btnGeneratePrivateKey.Size = new Size(177, 43);
            btnGeneratePrivateKey.TabIndex = 9;
            btnGeneratePrivateKey.Text = "Random private key";
            btnGeneratePrivateKey.UseVisualStyleBackColor = false;
            btnGeneratePrivateKey.Click += btnGeneratePrivateKey_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtP
            // 
            txtP.Location = new Point(717, 118);
            txtP.Margin = new Padding(3, 4, 3, 4);
            txtP.Multiline = true;
            txtP.Name = "txtP";
            txtP.Size = new Size(280, 30);
            txtP.TabIndex = 12;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(717, 152);
            txtQ.Margin = new Padding(3, 4, 3, 4);
            txtQ.Multiline = true;
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(280, 30);
            txtQ.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(585, 114);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 14;
            label1.Text = "Prime p:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(585, 146);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 15;
            label2.Text = "Prime q:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(585, 179);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 17;
            label3.Text = "Key e:";
            // 
            // txtE
            // 
            txtE.Location = new Point(717, 185);
            txtE.Margin = new Padding(3, 4, 3, 4);
            txtE.Multiline = true;
            txtE.Name = "txtE";
            txtE.Size = new Size(280, 30);
            txtE.TabIndex = 18;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(344, 540);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(179, 43);
            button7.TabIndex = 21;
            button7.Text = "Clear encrypt";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(818, 540);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(179, 43);
            button8.TabIndex = 22;
            button8.Text = "Clear decrypt";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Lavender;
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(344, 703);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(179, 43);
            button9.TabIndex = 23;
            button9.Text = "Clear public key";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Lavender;
            button10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(818, 703);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(179, 43);
            button10.TabIndex = 24;
            button10.Text = "Clear private key";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(462, 53);
            label4.Name = "label4";
            label4.Size = new Size(226, 50);
            label4.TabIndex = 25;
            label4.Text = "RSA Cypher";
            // 
            // RSACypher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1102, 853);
            Controls.Add(label4);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(txtE);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQ);
            Controls.Add(txtP);
            Controls.Add(btnGeneratePrivateKey);
            Controls.Add(txtPrivateKey);
            Controls.Add(btnGeneratePublicKey);
            Controls.Add(txtPublicKey);
            Controls.Add(txtbox);
            Controls.Add(txtDecrypt);
            Controls.Add(txtEncrypt);
            Controls.Add(button3);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RSACypher";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private TextBox txtEncrypt;
        private TextBox txtDecrypt;
        private TextBox txtbox;
        private TextBox txtPublicKey;
        private Button btnGeneratePublicKey;
        private TextBox txtPrivateKey;
        private Button btnGeneratePrivateKey;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtP;
        private TextBox txtQ;
        private Label label1;
        private Label label2;
        private Button btnGenerateKeys;
        private Label label3;
        private TextBox txtE;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label4;
    }
}