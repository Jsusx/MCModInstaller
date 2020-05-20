namespace ModInstaller
{
    partial class ModInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModInstaller));
            this.LabelBackUP = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.LabelModPath = new System.Windows.Forms.Label();
            this.cbEditPath = new System.Windows.Forms.CheckBox();
            this.LabelUpload = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.cboxVersions = new System.Windows.Forms.ComboBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LabelBackUP
            // 
            this.LabelBackUP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBackUP.Location = new System.Drawing.Point(-4, -2);
            this.LabelBackUP.Name = "LabelBackUP";
            this.LabelBackUP.Size = new System.Drawing.Size(491, 35);
            this.LabelBackUP.TabIndex = 0;
            this.LabelBackUP.Text = "label1";
            this.LabelBackUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 79);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(436, 20);
            this.txtPath.TabIndex = 1;
            // 
            // LabelModPath
            // 
            this.LabelModPath.Location = new System.Drawing.Point(12, 54);
            this.LabelModPath.Name = "LabelModPath";
            this.LabelModPath.Size = new System.Drawing.Size(199, 22);
            this.LabelModPath.TabIndex = 2;
            this.LabelModPath.Text = "label1";
            // 
            // cbEditPath
            // 
            this.cbEditPath.Location = new System.Drawing.Point(454, 77);
            this.cbEditPath.Name = "cbEditPath";
            this.cbEditPath.Size = new System.Drawing.Size(20, 22);
            this.cbEditPath.TabIndex = 3;
            this.cbEditPath.UseVisualStyleBackColor = true;
            this.cbEditPath.Click += new System.EventHandler(this.cbEditPath_Click);
            // 
            // LabelUpload
            // 
            this.LabelUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelUpload.Location = new System.Drawing.Point(305, 102);
            this.LabelUpload.Name = "LabelUpload";
            this.LabelUpload.Size = new System.Drawing.Size(143, 22);
            this.LabelUpload.TabIndex = 4;
            this.LabelUpload.Text = "Upload File";
            this.LabelUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelUpload.Click += new System.EventHandler(this.LabelUpload_Click);
            this.LabelUpload.MouseLeave += new System.EventHandler(this.LabelUpload_MouseLeave);
            this.LabelUpload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelUpload_MouseMove);
            // 
            // LabelVersion
            // 
            this.LabelVersion.Location = new System.Drawing.Point(9, 119);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(189, 22);
            this.LabelVersion.TabIndex = 5;
            this.LabelVersion.Text = "label1";
            // 
            // cboxVersions
            // 
            this.cboxVersions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxVersions.FormattingEnabled = true;
            this.cboxVersions.Location = new System.Drawing.Point(204, 120);
            this.cboxVersions.Name = "cboxVersions";
            this.cboxVersions.Size = new System.Drawing.Size(110, 21);
            this.cboxVersions.TabIndex = 6;
            this.cboxVersions.SelectedIndexChanged += new System.EventHandler(this.cboxVersions_SelectedIndexChanged);
            // 
            // btnInstalar
            // 
            this.btnInstalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstalar.Location = new System.Drawing.Point(86, 185);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(290, 46);
            this.btnInstalar.TabIndex = 7;
            this.btnInstalar.Text = "button1";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 268);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(488, 15);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 277);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.cboxVersions);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelUpload);
            this.Controls.Add(this.cbEditPath);
            this.Controls.Add(this.LabelModPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.LabelBackUP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBackUP;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label LabelModPath;
        private System.Windows.Forms.CheckBox cbEditPath;
        private System.Windows.Forms.Label LabelUpload;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.ComboBox cboxVersions;
        private System.Windows.Forms.Button btnInstalar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

