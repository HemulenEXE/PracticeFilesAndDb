using ImportExpornInDB.DBLogic;
using ImportExpornInDB.DBLogic.Interface;
using PracticeFilesAndDB.DBLogic.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExpornInDB
{
    public partial class DataBaseFile : Form
    {

        private IDbInitializer dbInitializer;
        private IFileRepository fileRepository { get; set; }
        public DataBaseFile()
        {
            InitializeComponent();
            fileRepository = new PostgresFileRepository();
            dbInitializer = new PostgresDbInitializer();
            dbInitializer.InitDb();


            foreach (var item in fileRepository.GetFiles())
            {
                listFiles.Rows.Add(item.id, item.name, item.formatFile, item.dateCreate, item.dataFile);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            foreach (string filePath in openFileDialog1.FileNames)
            {
                string name = filePath.Split('\\').Last();

                FileInfo fi = new FileInfo(filePath);

                string extension = fi.Extension;              // .txt, .pdf, .docx и т.д.
                DateTime creationTime = fi.CreationTime;
                byte[] bytes = File.ReadAllBytes(filePath);

                EntityFile currentFile = new EntityFile(0, name, extension, creationTime, bytes);
                fileRepository.AddFile(currentFile);
                listFiles.Rows.Add(fileRepository.NextId(), name, extension, creationTime, bytes);
            }

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                int id = Convert.ToInt32(listFiles.CurrentRow.Cells["IdFile"].Value);
                if (id == 0) return;
                EntityFile entityFile = fileRepository.GetFile(id) ??
                    throw new Exception("Не найден обьект по id");
                File.WriteAllBytes(saveFileDialog.FileName + entityFile.formatFile, entityFile.dataFile);
                MessageBox.Show("Экспорт успешно выполнен.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения команды: {ex.Message}");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listFiles.CurrentRow.Cells["IdFile"].Value);
            if (id == 0) return;
            fileRepository.DeleteFile(id);
            listFiles.Rows.Remove(listFiles.CurrentRow);
            MessageBox.Show("Элемент удален.");
        }
    }
}
