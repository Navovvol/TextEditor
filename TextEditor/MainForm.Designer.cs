namespace TextEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this._txtFilePath = new System.Windows.Forms.TextBox();
            this._btnSelectFile = new System.Windows.Forms.Button();
            this._btnOpenFile = new System.Windows.Forms.Button();
            this._txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._numFont = new System.Windows.Forms.NumericUpDown();
            this._btnSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this._numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл";
            // 
            // _txtFilePath
            // 
            this._txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFilePath.Location = new System.Drawing.Point(105, 13);
            this._txtFilePath.Name = "_txtFilePath";
            this._txtFilePath.Size = new System.Drawing.Size(275, 20);
            this._txtFilePath.TabIndex = 1;
            // 
            // _btnSelectFile
            // 
            this._btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectFile.Location = new System.Drawing.Point(393, 12);
            this._btnSelectFile.Name = "_btnSelectFile";
            this._btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this._btnSelectFile.TabIndex = 2;
            this._btnSelectFile.Text = "Выбрать";
            this._btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // _btnOpenFile
            // 
            this._btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOpenFile.Location = new System.Drawing.Point(481, 12);
            this._btnOpenFile.Name = "_btnOpenFile";
            this._btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this._btnOpenFile.TabIndex = 3;
            this._btnOpenFile.Text = "Открыть";
            this._btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // _txtContent
            // 
            this._txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtContent.Location = new System.Drawing.Point(15, 74);
            this._txtContent.Multiline = true;
            this._txtContent.Name = "_txtContent";
            this._txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtContent.Size = new System.Drawing.Size(541, 282);
            this._txtContent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шрифт";
            // 
            // _numFont
            // 
            this._numFont.Location = new System.Drawing.Point(105, 41);
            this._numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this._numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this._numFont.Name = "_numFont";
            this._numFont.Size = new System.Drawing.Size(120, 20);
            this._numFont.TabIndex = 6;
            this._numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // _btnSaveFile
            // 
            this._btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveFile.Location = new System.Drawing.Point(480, 363);
            this._btnSaveFile.Name = "_btnSaveFile";
            this._btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this._btnSaveFile.TabIndex = 7;
            this._btnSaveFile.Text = "Сохранить";
            this._btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(575, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // _lblCount
            // 
            this._lblCount.Name = "_lblCount";
            this._lblCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 408);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._btnSaveFile);
            this.Controls.Add(this._numFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtContent);
            this.Controls.Add(this._btnOpenFile);
            this.Controls.Add(this._btnSelectFile);
            this.Controls.Add(this._txtFilePath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "TextEditor";
            ((System.ComponentModel.ISupportInitialize)(this._numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtFilePath;
        private System.Windows.Forms.Button _btnSelectFile;
        private System.Windows.Forms.Button _btnOpenFile;
        private System.Windows.Forms.TextBox _txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numFont;
        private System.Windows.Forms.Button _btnSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _lblCount;
    }
}

