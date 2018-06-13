namespace AdbApkInstaller
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectAPKButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.packageNameLBL = new System.Windows.Forms.Label();
            this.versionLBL = new System.Windows.Forms.Label();
            this.installAPKBTN = new System.Windows.Forms.Button();
            this.iconLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectAPKButton
            // 
            this.SelectAPKButton.Location = new System.Drawing.Point(12, 118);
            this.SelectAPKButton.Name = "SelectAPKButton";
            this.SelectAPKButton.Size = new System.Drawing.Size(100, 27);
            this.SelectAPKButton.TabIndex = 0;
            this.SelectAPKButton.Text = "Selecionar  APK";
            this.SelectAPKButton.UseVisualStyleBackColor = true;
            this.SelectAPKButton.Click += new System.EventHandler(this.SelectAPK);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // packageNameLBL
            // 
            this.packageNameLBL.Font = new System.Drawing.Font("VL Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageNameLBL.Location = new System.Drawing.Point(12, 25);
            this.packageNameLBL.Name = "packageNameLBL";
            this.packageNameLBL.Size = new System.Drawing.Size(260, 23);
            this.packageNameLBL.TabIndex = 1;
            this.packageNameLBL.Text = "Package Name:";
            this.packageNameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLBL
            // 
            this.versionLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.versionLBL.Location = new System.Drawing.Point(12, 54);
            this.versionLBL.Name = "versionLBL";
            this.versionLBL.Size = new System.Drawing.Size(260, 13);
            this.versionLBL.TabIndex = 2;
            this.versionLBL.Text = "Version:";
            this.versionLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installAPKBTN
            // 
            this.installAPKBTN.Enabled = false;
            this.installAPKBTN.Location = new System.Drawing.Point(161, 118);
            this.installAPKBTN.Name = "installAPKBTN";
            this.installAPKBTN.Size = new System.Drawing.Size(111, 27);
            this.installAPKBTN.TabIndex = 5;
            this.installAPKBTN.Text = "Instalar APK";
            this.installAPKBTN.UseVisualStyleBackColor = true;
            this.installAPKBTN.Click += new System.EventHandler(this.installAPKBTN_Click);
            // 
            // iconLBL
            // 
            this.iconLBL.Location = new System.Drawing.Point(12, 79);
            this.iconLBL.Name = "iconLBL";
            this.iconLBL.Size = new System.Drawing.Size(260, 36);
            this.iconLBL.TabIndex = 4;
            this.iconLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.installAPKBTN);
            this.Controls.Add(this.iconLBL);
            this.Controls.Add(this.versionLBL);
            this.Controls.Add(this.packageNameLBL);
            this.Controls.Add(this.SelectAPKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AdbApkInstaller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectAPKButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label packageNameLBL;
        private System.Windows.Forms.Label versionLBL;
        private System.Windows.Forms.Button installAPKBTN;
        private System.Windows.Forms.Label iconLBL;
    }
}

