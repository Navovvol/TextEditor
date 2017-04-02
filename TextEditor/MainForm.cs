using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);

        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            _btnOpenFile.Click  +=  _btnOpenFile_Click;
            _btnSaveFile.Click  += _btnSaveFile_Click;
            _txtContent.TextChanged += _txtContent_TextChanged;
            _btnSelectFile.Click += _btnSelectFile_Click;
            _numFont.ValueChanged += _numFont_ValueChanged;
        }

        private void _numFont_ValueChanged(object sender, EventArgs e)
        {
            _txtContent.Font = new Font("Calibri", (float)_numFont.Value);
        }

        private void _btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                _txtFilePath.Text = dlg.FileName;

                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);
            }
        }

        #region Проброс событий

        private void _txtContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, EventArgs.Empty);
        }

        private void _btnSaveFile_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
                FileSaveClick(this, EventArgs.Empty);
        }

        private void _btnOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null)
                FileOpenClick(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm

        public string FilePath
        {
            get { return _txtFilePath.Text; }
        }

        public string Content
        {
            get { return _txtContent.Text; }
            set { _txtContent.Text = value; }
        }

        public void SetSymbolCount(int count)
        {
            _lblCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        #endregion


    }
}
