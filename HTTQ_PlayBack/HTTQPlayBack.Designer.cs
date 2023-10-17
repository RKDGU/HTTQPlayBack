
namespace HTTQ_PlayBack
{
    partial class HTTQPlayBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTTQPlayBack));
            this.ButtonPlayTable = new System.Windows.Forms.Button();
            this.ButtonLoadTable = new System.Windows.Forms.Button();
            this.ButtonRecordTable = new System.Windows.Forms.Button();
            this.ButtonStopTable = new System.Windows.Forms.Button();
            this.TextBoxTableSourcePath = new System.Windows.Forms.TextBox();
            this.TextBoxTableRecordPath = new System.Windows.Forms.TextBox();
            this.RichTextBoxDebug = new System.Windows.Forms.RichTextBox();
            this.ProgressBarFrameCount = new System.Windows.Forms.ProgressBar();
            this.RichTextBoxNextInputs = new System.Windows.Forms.RichTextBox();
            this.ButtonHookProcess = new System.Windows.Forms.Button();
            this.LabelFrameCounter = new System.Windows.Forms.Label();
            this.backgroundPlay = new System.ComponentModel.BackgroundWorker();
            this.backgroundRecord = new System.ComponentModel.BackgroundWorker();
            this.checkBoxInfo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonPlayTable
            // 
            this.ButtonPlayTable.Enabled = false;
            this.ButtonPlayTable.Location = new System.Drawing.Point(70, 90);
            this.ButtonPlayTable.Name = "ButtonPlayTable";
            this.ButtonPlayTable.Size = new System.Drawing.Size(62, 23);
            this.ButtonPlayTable.TabIndex = 7;
            this.ButtonPlayTable.Text = "Play ▶";
            this.ButtonPlayTable.UseVisualStyleBackColor = true;
            this.ButtonPlayTable.Click += new System.EventHandler(this.ButtonPlayTable_Click);
            // 
            // ButtonLoadTable
            // 
            this.ButtonLoadTable.Enabled = false;
            this.ButtonLoadTable.Location = new System.Drawing.Point(2, 32);
            this.ButtonLoadTable.Name = "ButtonLoadTable";
            this.ButtonLoadTable.Size = new System.Drawing.Size(62, 23);
            this.ButtonLoadTable.TabIndex = 2;
            this.ButtonLoadTable.Text = "Load";
            this.ButtonLoadTable.UseVisualStyleBackColor = true;
            this.ButtonLoadTable.Click += new System.EventHandler(this.ButtonLoadTable_Click);
            // 
            // ButtonRecordTable
            // 
            this.ButtonRecordTable.Enabled = false;
            this.ButtonRecordTable.Location = new System.Drawing.Point(2, 61);
            this.ButtonRecordTable.Name = "ButtonRecordTable";
            this.ButtonRecordTable.Size = new System.Drawing.Size(62, 23);
            this.ButtonRecordTable.TabIndex = 4;
            this.ButtonRecordTable.Text = "Record ●";
            this.ButtonRecordTable.UseVisualStyleBackColor = true;
            this.ButtonRecordTable.Click += new System.EventHandler(this.ButtonRecordTable_Click);
            // 
            // ButtonStopTable
            // 
            this.ButtonStopTable.Enabled = false;
            this.ButtonStopTable.Location = new System.Drawing.Point(2, 90);
            this.ButtonStopTable.Name = "ButtonStopTable";
            this.ButtonStopTable.Size = new System.Drawing.Size(62, 23);
            this.ButtonStopTable.TabIndex = 6;
            this.ButtonStopTable.Text = "Stop ■";
            this.ButtonStopTable.UseVisualStyleBackColor = true;
            this.ButtonStopTable.Click += new System.EventHandler(this.ButtonStopTable_Click);
            // 
            // TextBoxTableSourcePath
            // 
            this.TextBoxTableSourcePath.Location = new System.Drawing.Point(70, 34);
            this.TextBoxTableSourcePath.Name = "TextBoxTableSourcePath";
            this.TextBoxTableSourcePath.Size = new System.Drawing.Size(332, 20);
            this.TextBoxTableSourcePath.TabIndex = 3;
            this.TextBoxTableSourcePath.Text = "R:\\Desktop\\HTTQ_PlayBack\\InputTableBackUp.csv";
            this.TextBoxTableSourcePath.TextChanged += new System.EventHandler(this.TextBoxTableSourcePath_TextChanged);
            // 
            // TextBoxTableRecordPath
            // 
            this.TextBoxTableRecordPath.Location = new System.Drawing.Point(70, 63);
            this.TextBoxTableRecordPath.Name = "TextBoxTableRecordPath";
            this.TextBoxTableRecordPath.Size = new System.Drawing.Size(332, 20);
            this.TextBoxTableRecordPath.TabIndex = 5;
            this.TextBoxTableRecordPath.Text = "R:\\Desktop\\HTTQ_PlayBack\\RecordedInputTable.csv";
            // 
            // RichTextBoxDebug
            // 
            this.RichTextBoxDebug.Location = new System.Drawing.Point(408, 5);
            this.RichTextBoxDebug.Name = "RichTextBoxDebug";
            this.RichTextBoxDebug.Size = new System.Drawing.Size(205, 239);
            this.RichTextBoxDebug.TabIndex = 8;
            this.RichTextBoxDebug.Text = "Debug";
            this.RichTextBoxDebug.Click += new System.EventHandler(this.RichTextBoxDebug_Click);
            // 
            // ProgressBarFrameCount
            // 
            this.ProgressBarFrameCount.Location = new System.Drawing.Point(138, 90);
            this.ProgressBarFrameCount.Name = "ProgressBarFrameCount";
            this.ProgressBarFrameCount.Size = new System.Drawing.Size(180, 23);
            this.ProgressBarFrameCount.Step = 1;
            this.ProgressBarFrameCount.TabIndex = 13;
            // 
            // RichTextBoxNextInputs
            // 
            this.RichTextBoxNextInputs.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RichTextBoxNextInputs.Location = new System.Drawing.Point(2, 119);
            this.RichTextBoxNextInputs.Name = "RichTextBoxNextInputs";
            this.RichTextBoxNextInputs.Size = new System.Drawing.Size(400, 125);
            this.RichTextBoxNextInputs.TabIndex = 14;
            this.RichTextBoxNextInputs.Text = resources.GetString("RichTextBoxNextInputs.Text");
            // 
            // ButtonHookProcess
            // 
            this.ButtonHookProcess.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonHookProcess.Location = new System.Drawing.Point(2, 3);
            this.ButtonHookProcess.Name = "ButtonHookProcess";
            this.ButtonHookProcess.Size = new System.Drawing.Size(400, 23);
            this.ButtonHookProcess.TabIndex = 1;
            this.ButtonHookProcess.Text = "Attach Memory";
            this.ButtonHookProcess.UseVisualStyleBackColor = false;
            this.ButtonHookProcess.Click += new System.EventHandler(this.ButtonHookProcess_Click);
            // 
            // LabelFrameCounter
            // 
            this.LabelFrameCounter.AutoSize = true;
            this.LabelFrameCounter.BackColor = System.Drawing.Color.White;
            this.LabelFrameCounter.Font = new System.Drawing.Font("MS Gothic", 9.75F);
            this.LabelFrameCounter.Location = new System.Drawing.Point(331, 141);
            this.LabelFrameCounter.Name = "LabelFrameCounter";
            this.LabelFrameCounter.Size = new System.Drawing.Size(28, 13);
            this.LabelFrameCounter.TabIndex = 15;
            this.LabelFrameCounter.Text = "0/0";
            // 
            // backgroundPlay
            // 
            this.backgroundPlay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundPlay_DoWork);
            this.backgroundPlay.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundPlay_ProgressChanged);
            // 
            // backgroundRecord
            // 
            this.backgroundRecord.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundRecord_DoWork);
            // 
            // checkBoxInfo
            // 
            this.checkBoxInfo.AutoSize = true;
            this.checkBoxInfo.Checked = true;
            this.checkBoxInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInfo.Location = new System.Drawing.Point(324, 94);
            this.checkBoxInfo.Name = "checkBoxInfo";
            this.checkBoxInfo.Size = new System.Drawing.Size(78, 17);
            this.checkBoxInfo.TabIndex = 16;
            this.checkBoxInfo.Text = "DisplayInfo";
            this.checkBoxInfo.UseVisualStyleBackColor = true;
            // 
            // HTTQPlayBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 249);
            this.Controls.Add(this.checkBoxInfo);
            this.Controls.Add(this.LabelFrameCounter);
            this.Controls.Add(this.ButtonHookProcess);
            this.Controls.Add(this.RichTextBoxNextInputs);
            this.Controls.Add(this.ProgressBarFrameCount);
            this.Controls.Add(this.RichTextBoxDebug);
            this.Controls.Add(this.TextBoxTableRecordPath);
            this.Controls.Add(this.TextBoxTableSourcePath);
            this.Controls.Add(this.ButtonStopTable);
            this.Controls.Add(this.ButtonRecordTable);
            this.Controls.Add(this.ButtonLoadTable);
            this.Controls.Add(this.ButtonPlayTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HTTQPlayBack";
            this.Text = "Hype The Time Quest PlayBack - RayKinDar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlayTable;
        private System.Windows.Forms.Button ButtonLoadTable;
        private System.Windows.Forms.Button ButtonRecordTable;
        private System.Windows.Forms.Button ButtonStopTable;
        private System.Windows.Forms.TextBox TextBoxTableSourcePath;
        private System.Windows.Forms.TextBox TextBoxTableRecordPath;
        private System.Windows.Forms.RichTextBox RichTextBoxDebug;
        private System.Windows.Forms.ProgressBar ProgressBarFrameCount;
        private System.Windows.Forms.RichTextBox RichTextBoxNextInputs;
        private System.Windows.Forms.Button ButtonHookProcess;
        private System.Windows.Forms.Label LabelFrameCounter;
        private System.ComponentModel.BackgroundWorker backgroundPlay;
        private System.ComponentModel.BackgroundWorker backgroundRecord;
        private System.Windows.Forms.CheckBox checkBoxInfo;
    }
}

