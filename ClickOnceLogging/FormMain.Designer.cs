namespace ClickOnceLogging
{
    partial class FormMain
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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.checkVerbose = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRuntimeVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(13, 13);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(88, 13);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "Log file Location:";
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(107, 10);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(444, 20);
            this.textFilePath.TabIndex = 1;
            // 
            // checkVerbose
            // 
            this.checkVerbose.AutoSize = true;
            this.checkVerbose.Location = new System.Drawing.Point(13, 36);
            this.checkVerbose.Name = "checkVerbose";
            this.checkVerbose.Size = new System.Drawing.Size(157, 17);
            this.checkVerbose.TabIndex = 4;
            this.checkVerbose.Text = "Set logging level to verbose";
            this.checkVerbose.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(557, 10);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(50, 20);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(588, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.Location = new System.Drawing.Point(557, 36);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(106, 23);
            this.buttonDefaults.TabIndex = 5;
            this.buttonDefaults.Text = "Set to Default";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(613, 10);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(50, 20);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(476, 92);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRuntimeVersion
            // 
            this.labelRuntimeVersion.AutoSize = true;
            this.labelRuntimeVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRuntimeVersion.Location = new System.Drawing.Point(0, 112);
            this.labelRuntimeVersion.Name = "labelRuntimeVersion";
            this.labelRuntimeVersion.Size = new System.Drawing.Size(83, 13);
            this.labelRuntimeVersion.TabIndex = 8;
            this.labelRuntimeVersion.Text = "Runtime version";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(673, 125);
            this.Controls.Add(this.labelRuntimeVersion);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonDefaults);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.checkVerbose);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.labelFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Set ClickOnce Logging Settings";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.CheckBox checkVerbose;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRuntimeVersion;
    }
}

