namespace MEdit
{
    partial class MEditForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MEditForm));
            this.DocOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DocSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DocFontDialog = new System.Windows.Forms.FontDialog();
            this.DocMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocHelpProvider = new System.Windows.Forms.HelpProvider();
            this.DocPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.DocToolStrip = new System.Windows.Forms.ToolStrip();
            this.FileCreateStripButton = new System.Windows.Forms.ToolStripButton();
            this.FileOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FileSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FilePrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DocTextBox = new System.Windows.Forms.TextBox();
            this.DocPrintDialog = new System.Windows.Forms.PrintDialog();
            this.DocMenuStrip.SuspendLayout();
            this.DocToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocOpenFileDialog
            // 
            this.DocOpenFileDialog.FileName = "openFileDialog1";
            // 
            // DocMenuStrip
            // 
            this.DocMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ParamToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.DocMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DocMenuStrip.Name = "DocMenuStrip";
            this.DocMenuStrip.Size = new System.Drawing.Size(684, 24);
            this.DocMenuStrip.TabIndex = 0;
            this.DocMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Checked = true;
            this.FileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCreateToolStripMenuItem,
            this.FileOpenToolStripMenuItem,
            this.FileSaveToolStripMenuItem,
            this.FilePrintToolStripMenuItem,
            this.FileExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // FileCreateToolStripMenuItem
            // 
            this.FileCreateToolStripMenuItem.Name = "FileCreateToolStripMenuItem";
            this.FileCreateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.FileCreateToolStripMenuItem.Text = "Создать";
            this.FileCreateToolStripMenuItem.Click += new System.EventHandler(this.FileCreateToolStripMenuItem_Click);
            // 
            // FileOpenToolStripMenuItem
            // 
            this.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            this.FileOpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.FileOpenToolStripMenuItem.Text = "Открыть";
            this.FileOpenToolStripMenuItem.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // FileSaveToolStripMenuItem
            // 
            this.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            this.FileSaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.FileSaveToolStripMenuItem.Text = "Сохранить";
            this.FileSaveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // FilePrintToolStripMenuItem
            // 
            this.FilePrintToolStripMenuItem.Name = "FilePrintToolStripMenuItem";
            this.FilePrintToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.FilePrintToolStripMenuItem.Text = "Печать";
            this.FilePrintToolStripMenuItem.Click += new System.EventHandler(this.FilePrintToolStripMenuItem_Click);
            // 
            // FileExitToolStripMenuItem
            // 
            this.FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            this.FileExitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.FileExitToolStripMenuItem.Text = "Выход";
            this.FileExitToolStripMenuItem.Click += new System.EventHandler(this.FileExitToolStripMenuItem_Click);
            // 
            // ParamToolStripMenuItem
            // 
            this.ParamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParamPanelToolStripMenuItem,
            this.ParamFontToolStripMenuItem});
            this.ParamToolStripMenuItem.Name = "ParamToolStripMenuItem";
            this.ParamToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ParamToolStripMenuItem.Text = "Параметры";
            // 
            // ParamPanelToolStripMenuItem
            // 
            this.ParamPanelToolStripMenuItem.Name = "ParamPanelToolStripMenuItem";
            this.ParamPanelToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ParamPanelToolStripMenuItem.Text = "Панель инструментов";
            this.ParamPanelToolStripMenuItem.Click += new System.EventHandler(this.ParamPanelToolStripMenuItem_Click);
            // 
            // ParamFontToolStripMenuItem
            // 
            this.ParamFontToolStripMenuItem.Name = "ParamFontToolStripMenuItem";
            this.ParamFontToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ParamFontToolStripMenuItem.Text = "Шрифт";
            this.ParamFontToolStripMenuItem.Click += new System.EventHandler(this.ParamFontToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AboutToolStripMenuItem.Text = "О Программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // DocToolStrip
            // 
            this.DocToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCreateStripButton,
            this.FileOpenToolStripButton,
            this.FileSaveToolStripButton,
            this.FilePrintToolStripButton});
            this.DocToolStrip.Location = new System.Drawing.Point(0, 24);
            this.DocToolStrip.Name = "DocToolStrip";
            this.DocToolStrip.Size = new System.Drawing.Size(684, 25);
            this.DocToolStrip.TabIndex = 1;
            this.DocToolStrip.Text = "toolStrip1";
            // 
            // FileCreateStripButton
            // 
            this.FileCreateStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FileCreateStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FileCreateStripButton.Image")));
            this.FileCreateStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileCreateStripButton.Name = "FileCreateStripButton";
            this.FileCreateStripButton.Size = new System.Drawing.Size(23, 22);
            this.FileCreateStripButton.Text = "Создать";
            this.FileCreateStripButton.Click += new System.EventHandler(this.FileCreateToolStripMenuItem_Click);
            // 
            // FileOpenToolStripButton
            // 
            this.FileOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FileOpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FileOpenToolStripButton.Image")));
            this.FileOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileOpenToolStripButton.Name = "FileOpenToolStripButton";
            this.FileOpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FileOpenToolStripButton.Text = "Открыть";
            this.FileOpenToolStripButton.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // FileSaveToolStripButton
            // 
            this.FileSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FileSaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FileSaveToolStripButton.Image")));
            this.FileSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileSaveToolStripButton.Name = "FileSaveToolStripButton";
            this.FileSaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FileSaveToolStripButton.Text = "Сохранить";
            this.FileSaveToolStripButton.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // FilePrintToolStripButton
            // 
            this.FilePrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilePrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FilePrintToolStripButton.Image")));
            this.FilePrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilePrintToolStripButton.Name = "FilePrintToolStripButton";
            this.FilePrintToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FilePrintToolStripButton.Text = "Печать";
            this.FilePrintToolStripButton.Click += new System.EventHandler(this.FilePrintToolStripMenuItem_Click);
            // 
            // DocTextBox
            // 
            this.DocTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocTextBox.Location = new System.Drawing.Point(0, 49);
            this.DocTextBox.Multiline = true;
            this.DocTextBox.Name = "DocTextBox";
            this.DocTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DocTextBox.Size = new System.Drawing.Size(684, 312);
            this.DocTextBox.TabIndex = 2;
            this.DocTextBox.TextChanged += new System.EventHandler(this.DocTextBox_TextChanged);
            // 
            // DocPrintDialog
            // 
            this.DocPrintDialog.UseEXDialog = true;
            // 
            // MEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.DocTextBox);
            this.Controls.Add(this.DocToolStrip);
            this.Controls.Add(this.DocMenuStrip);
            this.MainMenuStrip = this.DocMenuStrip;
            this.Name = "MEditForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MEditForm_FormClosing);
            this.DocMenuStrip.ResumeLayout(false);
            this.DocMenuStrip.PerformLayout();
            this.DocToolStrip.ResumeLayout(false);
            this.DocToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DocOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog DocSaveFileDialog;
        private System.Windows.Forms.FontDialog DocFontDialog;
        private System.Windows.Forms.MenuStrip DocMenuStrip;
        private System.Windows.Forms.HelpProvider DocHelpProvider;
        private System.Drawing.Printing.PrintDocument DocPrintDocument;
        private System.Windows.Forms.ToolStrip DocToolStrip;
        private System.Windows.Forms.TextBox DocTextBox;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton FileCreateStripButton;
        private System.Windows.Forms.ToolStripButton FileOpenToolStripButton;
        private System.Windows.Forms.ToolStripButton FileSaveToolStripButton;
        private System.Windows.Forms.ToolStripButton FilePrintToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem FileCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilePrintToolStripMenuItem;
        private System.Windows.Forms.PrintDialog DocPrintDialog;
    }
}

