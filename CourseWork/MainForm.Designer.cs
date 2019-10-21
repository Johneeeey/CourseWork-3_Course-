namespace CourseWork
{
    partial class MainForm
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
            this.TablesDataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonNewTable = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenFIle = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TablesDataGridView
            // 
            this.TablesDataGridView.AllowUserToAddRows = false;
            this.TablesDataGridView.AllowUserToDeleteRows = false;
            this.TablesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesDataGridView.Location = new System.Drawing.Point(13, 315);
            this.TablesDataGridView.Name = "TablesDataGridView";
            this.TablesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablesDataGridView.Size = new System.Drawing.Size(660, 296);
            this.TablesDataGridView.TabIndex = 0;
            this.TablesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablesDataGridView_CellMouseDoubleClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "OpenFileDialogDetails";
            // 
            // buttonNewTable
            // 
            this.buttonNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewTable.Location = new System.Drawing.Point(12, 617);
            this.buttonNewTable.Name = "buttonNewTable";
            this.buttonNewTable.Size = new System.Drawing.Size(190, 31);
            this.buttonNewTable.TabIndex = 1;
            this.buttonNewTable.Text = "Создать";
            this.buttonNewTable.UseVisualStyleBackColor = true;
            this.buttonNewTable.Click += new System.EventHandler(this.buttonNewTable_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdr.Location = new System.Drawing.Point(13, 251);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(577, 20);
            this.textBoxAdr.TabIndex = 2;
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFile.Location = new System.Drawing.Point(515, 250);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(75, 21);
            this.buttonChooseFile.TabIndex = 3;
            this.buttonChooseFile.Text = "Выбрать";
            this.buttonChooseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ImageLocation = "Картинки\\\\Понорама.jpg";
            this.pictureBox.Location = new System.Drawing.Point(13, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(660, 232);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // buttonOpenFIle
            // 
            this.buttonOpenFIle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFIle.Location = new System.Drawing.Point(597, 250);
            this.buttonOpenFIle.Name = "buttonOpenFIle";
            this.buttonOpenFIle.Size = new System.Drawing.Size(76, 21);
            this.buttonOpenFIle.TabIndex = 5;
            this.buttonOpenFIle.Text = "Открыть";
            this.buttonOpenFIle.UseVisualStyleBackColor = true;
            this.buttonOpenFIle.Click += new System.EventHandler(this.buttonOpenFIle_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(237, 278);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(432, 22);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(594, 278);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите номер нужного стола:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonOpenFIle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonNewTable);
            this.Controls.Add(this.TablesDataGridView);
            this.Name = "MainForm";
            this.Text = "Бронирование столиков";
            ((System.ComponentModel.ISupportInitialize)(this.TablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablesDataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonNewTable;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonOpenFIle;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
    }
}

