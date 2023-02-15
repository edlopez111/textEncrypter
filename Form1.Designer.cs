namespace Encrypter
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tcEncrypt = new System.Windows.Forms.TabControl();
            this.tpControls = new System.Windows.Forms.TabPage();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopyE = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecretw1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDecrypt = new System.Windows.Forms.TabPage();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretw2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tcEncrypt.SuspendLayout();
            this.tpControls.SuspendLayout();
            this.tcDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEncrypt
            // 
            this.tcEncrypt.Controls.Add(this.tpControls);
            this.tcEncrypt.Controls.Add(this.tcDecrypt);
            this.tcEncrypt.Location = new System.Drawing.Point(12, 12);
            this.tcEncrypt.Name = "tcEncrypt";
            this.tcEncrypt.SelectedIndex = 0;
            this.tcEncrypt.Size = new System.Drawing.Size(678, 177);
            this.tcEncrypt.TabIndex = 0;
            // 
            // tpControls
            // 
            this.tpControls.Controls.Add(this.txtText1);
            this.tpControls.Controls.Add(this.label6);
            this.tpControls.Controls.Add(this.btnCopyE);
            this.tpControls.Controls.Add(this.btnEncrypt);
            this.tpControls.Controls.Add(this.txtEncrypted);
            this.tpControls.Controls.Add(this.label2);
            this.tpControls.Controls.Add(this.txtSecretw1);
            this.tpControls.Controls.Add(this.label1);
            this.tpControls.Location = new System.Drawing.Point(4, 22);
            this.tpControls.Name = "tpControls";
            this.tpControls.Padding = new System.Windows.Forms.Padding(3);
            this.tpControls.Size = new System.Drawing.Size(670, 151);
            this.tpControls.TabIndex = 0;
            this.tpControls.Text = "Encrypt";
            this.tpControls.UseVisualStyleBackColor = true;
            // 
            // txtText1
            // 
            this.txtText1.Location = new System.Drawing.Point(81, 46);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(464, 20);
            this.txtText1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "You Text";
            // 
            // btnCopyE
            // 
            this.btnCopyE.Location = new System.Drawing.Point(552, 70);
            this.btnCopyE.Name = "btnCopyE";
            this.btnCopyE.Size = new System.Drawing.Size(101, 23);
            this.btnCopyE.TabIndex = 5;
            this.btnCopyE.Text = "Copy to Clipboard";
            this.btnCopyE.UseVisualStyleBackColor = true;
            this.btnCopyE.Click += new System.EventHandler(this.btnCopyE_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(81, 105);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(106, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(81, 72);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ReadOnly = true;
            this.txtEncrypted.Size = new System.Drawing.Size(464, 20);
            this.txtEncrypted.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted";
            // 
            // txtSecretw1
            // 
            this.txtSecretw1.Location = new System.Drawing.Point(81, 20);
            this.txtSecretw1.MaxLength = 16;
            this.txtSecretw1.Name = "txtSecretw1";
            this.txtSecretw1.Size = new System.Drawing.Size(217, 20);
            this.txtSecretw1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secret Key";
            // 
            // tcDecrypt
            // 
            this.tcDecrypt.Controls.Add(this.txtText2);
            this.tcDecrypt.Controls.Add(this.label5);
            this.tcDecrypt.Controls.Add(this.btnCopy2);
            this.tcDecrypt.Controls.Add(this.btnDecrypt);
            this.tcDecrypt.Controls.Add(this.txtDecrypted);
            this.tcDecrypt.Controls.Add(this.label3);
            this.tcDecrypt.Controls.Add(this.txtSecretw2);
            this.tcDecrypt.Controls.Add(this.label4);
            this.tcDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tcDecrypt.Name = "tcDecrypt";
            this.tcDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tcDecrypt.Size = new System.Drawing.Size(670, 151);
            this.tcDecrypt.TabIndex = 1;
            this.tcDecrypt.Text = "Decrypt";
            this.tcDecrypt.UseVisualStyleBackColor = true;
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(81, 46);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(464, 20);
            this.txtText2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Encrypt Text";
            // 
            // btnCopy2
            // 
            this.btnCopy2.Location = new System.Drawing.Point(552, 70);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(101, 23);
            this.btnCopy2.TabIndex = 10;
            this.btnCopy2.Text = "Copy to Clipboard";
            this.btnCopy2.UseVisualStyleBackColor = true;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(81, 105);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(106, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(81, 72);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(464, 20);
            this.txtDecrypted.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decrypted";
            // 
            // txtSecretw2
            // 
            this.txtSecretw2.Location = new System.Drawing.Point(81, 20);
            this.txtSecretw2.MaxLength = 16;
            this.txtSecretw2.Name = "txtSecretw2";
            this.txtSecretw2.Size = new System.Drawing.Size(217, 20);
            this.txtSecretw2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secret Key";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(580, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 230);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tcEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Encrypter";
            this.tcEncrypt.ResumeLayout(false);
            this.tpControls.ResumeLayout(false);
            this.tpControls.PerformLayout();
            this.tcDecrypt.ResumeLayout(false);
            this.tcDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEncrypt;
        private System.Windows.Forms.TabPage tpControls;
        private System.Windows.Forms.Button btnCopyE;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecretw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tcDecrypt;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecretw2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Label label5;
    }
}

