/*Программа "MEdit" (редактор текста) демонстрирует использование компонентов 
 * MainMenu, OpenDialog, SaveDialog, FontDialog, PrintDocument, 
 * а также отображение информации о программе в отдельном окне.
 * Информация о программе отображена в окне "О программе", которое 
 * появляется в результате выбора соответствующей команды в пункте меню "Справка"*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MEdit
{
    public partial class MEditForm : Form
    {
        private string FileName = string.Empty; //имя файла
        private bool DocChanged = false;
        
        //открывает документ
        private void OpenDocument()
        {
            DocOpenFileDialog.FileName = string.Empty;

            //отобразить диалог "Открыть"
            if (DocOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = DocOpenFileDialog.FileName;
                this.Text = FileName; //отобразить имя файла в заголовке окна

                try
                {
                    //считываем данные из файла
                    StreamReader sr = new StreamReader(FileName);
                    DocTextBox.Text = sr.ReadToEnd();
                    DocTextBox.SelectionStart = DocTextBox.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла\n" + exc, "MEdit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //сохраняет документ
        private int SaveDocument()
        {
            int result = 0;
            //если имя файла не задано, выводим диалог "Сохранить документ"
            if (FileName == string.Empty)
            {
                if (DocSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = DocSaveFileDialog.FileName;
                    this.Text = FileName; //отобразить имя файла в заголовке окна
                }
                else result = -1;
            }
            else
            {
                try
                {
                    //получим информацию о файле
                    FileInfo FileInformation = new FileInfo(FileName);

                    //поток для записи (перезаписываем файл)
                    StreamWriter sw = FileInformation.CreateText();
                    sw.Write(DocTextBox.Text);
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка доступа к файлу\n" + exc, "MEdit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }

        public MEditForm()
        {
            InitializeComponent();

            DocTextBox.ScrollBars = ScrollBars.Vertical;
            DocTextBox.Text = string.Empty;

            this.Text = "NkEdit - Новый документ";

            //отобразить панель инструментов
            DocToolStrip.Visible = false;
            FileToolStripMenuItem.Checked = true;
            
            //назначаем файл справки
            DocHelpProvider.HelpNamespace = "nkedit.chm";

            //настройка компонента DocOpenFileDialog
            DocOpenFileDialog.DefaultExt = "txt";
            DocOpenFileDialog.Filter = "текст|*.txt";
            DocOpenFileDialog.Title = "Открыть документ";
            DocOpenFileDialog.Multiselect = false;

            //настройка компонента DocSaveFileDialog
            DocSaveFileDialog.DefaultExt = "txt";
            DocSaveFileDialog.Filter = "текст|*.txt";
            DocSaveFileDialog.Title = "Сохранить документ";
        }

        //выбор в меню "Файл" команды "Создать"
        private void FileCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocChanged)
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", "MEdit", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() == 0)
                        {
                            DocTextBox.Clear();
                            DocChanged = false;
                        }
                        break;
                    case DialogResult.No:
                        DocTextBox.Clear();
                        DocChanged = false;
                        break;
                    case DialogResult.Cancel: break;
                }
            }
        }

        //выбор в меню "Файл" команды "Открыть"
        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        //выбор в меню "Файл" команды "Сохранить"
        private void FileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }
        
        //выбор в меню "Файл" команды "Печать"
        private void FilePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocPrintDialog.ShowDialog();
        }

        //выбор в меню "Файл" команды "Выход"
        private void FileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //выбор в меню "Параметры" команды "Панель инструментов"
        private void ParamPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //отобразить или скрыть панель инструментов
            DocToolStrip.Visible = !DocToolStrip.Visible;
            ParamPanelToolStripMenuItem.Checked = !ParamPanelToolStripMenuItem.Checked;
        }

        //выбор в меню "Параметры" команды "Шрифт"
        private void ParamFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocFontDialog.Font = DocTextBox.Font;
            if (DocFontDialog.ShowDialog() == DialogResult.OK)
                DocTextBox.Font = DocFontDialog.Font;
        }
        
        //выбор в меню "Справка" команды "О Программе"
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void DocTextBox_TextChanged(object sender, EventArgs e)
        {
            DocChanged = true;
        }
        
        //пользователь сделал щелчок на кнопке "Закрыть окно"
        private void MEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DocChanged)
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", "MEdit",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() != 0) e.Cancel = true;
                        break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
