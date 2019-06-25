using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceLogging
{
    public partial class FormMain : Form
    {
        ClickOnceLogSettings logSettings;

        public FormMain()
        {
            InitializeComponent();
            labelRuntimeVersion.Text = String.Format("Runtime version: {0}", Environment.Version);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                logSettings = ClickOnceLogSettings.Create();
                textFilePath.Text = logSettings.LogFileLocation;
                checkVerbose.Checked = logSettings.VerboseLogging;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                logSettings.LogFileLocation = textFilePath.Text;
                logSettings.VerboseLogging = checkVerbose.Checked;
                logSettings.Save();
                MessageBox.Show(this, "ClickOnce log and verbosity changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog()
                {
                    DefaultExt = ".log",
                    FileName = textFilePath.Text,
                    Filter = "Log files (*.log)|*.log|All files (*.*)|*.*"
                })
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        textFilePath.Text = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            textFilePath.Text = String.Empty;
            checkVerbose.Checked = false;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textFilePath.Text))
                {
                    Process.Start("notepad.exe", String.Format("\"{0}\"", textFilePath.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
