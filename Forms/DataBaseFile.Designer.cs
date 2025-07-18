namespace ImportExpornInDB
{
    partial class DataBaseFile
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
            DeleteButton = new Button();
            ImportButton = new Button();
            ExportButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            listFiles = new DataGridView();
            IdFile = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Format = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listFiles).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(987, 149);
            DeleteButton.Margin = new Padding(4, 3, 4, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(88, 27);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(987, 84);
            ImportButton.Margin = new Padding(4, 3, 4, 3);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(88, 27);
            ImportButton.TabIndex = 1;
            ImportButton.Text = "Импорт";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(987, 20);
            ExportButton.Margin = new Padding(4, 3, 4, 3);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(88, 27);
            ExportButton.TabIndex = 2;
            ExportButton.Text = "Экспорт";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // listFiles
            // 
            listFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listFiles.Columns.AddRange(new DataGridViewColumn[] { IdFile, Name, Format, Date });
            listFiles.Location = new Point(14, 14);
            listFiles.Margin = new Padding(4, 3, 4, 3);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(869, 365);
            listFiles.TabIndex = 3;
            // 
            // IdFile
            // 
            IdFile.HeaderText = "Id";
            IdFile.Name = "IdFile";
            // 
            // Name
            // 
            Name.HeaderText = "Имя";
            Name.Name = "Name";
            Name.Width = 250;
            // 
            // Format
            // 
            Format.HeaderText = "Формат";
            Format.Name = "Format";
            Format.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Дата создания";
            Date.Name = "Date";
            Date.Width = 300;
            // 
            // DataBaseFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 486);
            Controls.Add(listFiles);
            Controls.Add(ExportButton);
            Controls.Add(ImportButton);
            Controls.Add(DeleteButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            //Name = "DataBaseFile";
            Text = "База Данных Файлов";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView listFiles;
        private DataGridViewTextBoxColumn IdFile;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Format;
        private DataGridViewTextBoxColumn Date;
    }
}

