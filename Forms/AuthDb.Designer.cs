namespace PracticeFilesAndDB.Forms
{
    partial class AuthDb
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
            label1 = new Label();
            boxConnect = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 23);
            label1.Name = "label1";
            label1.Size = new Size(249, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите строку подключения к базе данных";
            // 
            // boxConnect
            // 
            boxConnect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxConnect.Location = new Point(33, 64);
            boxConnect.Name = "boxConnect";
            boxConnect.Size = new Size(536, 23);
            boxConnect.TabIndex = 1;
            boxConnect.Text = "Host=localhost;Port=5432;Username=postgres;Password=1;Database=filesdb \\ пример";
            // 
            // button1
            // 
            button1.Location = new Point(166, 122);
            button1.Name = "button1";
            button1.Size = new Size(249, 23);
            button1.TabIndex = 5;
            button1.Text = "Сохранить путь и создать таблицу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AuthDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 184);
            Controls.Add(button1);
            Controls.Add(boxConnect);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthDb";
            Text = "AuthDb";
            Load += AuthDb_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox boxConnect;
        private Button button1;
    }
}