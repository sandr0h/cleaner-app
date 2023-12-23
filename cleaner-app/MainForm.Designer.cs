
using Cleaner.Core.Services;
using System.IO;

namespace cleaner_app
{
    partial class MainForm
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
            this.BT_Main_RunClean = new System.Windows.Forms.Button();
            this.RTB_Log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BT_Main_RunClean
            // 
            this.BT_Main_RunClean.Location = new System.Drawing.Point(12, 12);
            this.BT_Main_RunClean.Name = "BT_Main_RunClean";
            this.BT_Main_RunClean.Size = new System.Drawing.Size(75, 23);
            this.BT_Main_RunClean.TabIndex = 0;
            this.BT_Main_RunClean.Text = "Execute";
            this.BT_Main_RunClean.UseVisualStyleBackColor = true;
            this.BT_Main_RunClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTB_Log
            // 
            this.RTB_Log.BackColor = System.Drawing.SystemColors.WindowText;
            this.RTB_Log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTB_Log.Location = new System.Drawing.Point(12, 52);
            this.RTB_Log.Name = "RTB_Log";
            this.RTB_Log.ReadOnly = true;
            this.RTB_Log.Size = new System.Drawing.Size(776, 386);
            this.RTB_Log.TabIndex = 1;
            this.RTB_Log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTB_Log);
            this.Controls.Add(this.BT_Main_RunClean);
            this.Name = "MainForm";
            this.Text = "Cleaner";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_Main_RunClean;
        private System.Windows.Forms.RichTextBox RTB_Log;
    }
}

