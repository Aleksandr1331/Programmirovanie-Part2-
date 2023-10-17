namespace Lab1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Group1 = new System.Windows.Forms.GroupBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.YearsOfSTOLabel = new System.Windows.Forms.Label();
            this.YearsOfTOText = new System.Windows.Forms.TextBox();
            this.YearsOfOutLabel = new System.Windows.Forms.Label();
            this.YearsOfOutText = new System.Windows.Forms.TextBox();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.OwnerText = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.MarkaLabel = new System.Windows.Forms.Label();
            this.MarkaText = new System.Windows.Forms.TextBox();
            this.CatalogComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeCar = new System.Windows.Forms.Label();
            this.GetFine = new System.Windows.Forms.Button();
            this.GetFineText = new System.Windows.Forms.GroupBox();
            this.FineTextBox = new System.Windows.Forms.TextBox();
            this.ToPayFine = new System.Windows.Forms.Button();
            this.SelectFineComboBox = new System.Windows.Forms.ComboBox();
            this.SellCar = new System.Windows.Forms.Button();
            this.GoTechInspection = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group1.SuspendLayout();
            this.GetFineText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Group1
            // 
            this.Group1.Controls.Add(this.AddCar);
            this.Group1.Controls.Add(this.YearsOfSTOLabel);
            this.Group1.Controls.Add(this.YearsOfTOText);
            this.Group1.Controls.Add(this.YearsOfOutLabel);
            this.Group1.Controls.Add(this.YearsOfOutText);
            this.Group1.Controls.Add(this.OwnerLabel);
            this.Group1.Controls.Add(this.OwnerText);
            this.Group1.Controls.Add(this.ModelLabel);
            this.Group1.Controls.Add(this.ModelText);
            this.Group1.Controls.Add(this.MarkaLabel);
            this.Group1.Controls.Add(this.MarkaText);
            this.Group1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group1.Location = new System.Drawing.Point(16, 15);
            this.Group1.Margin = new System.Windows.Forms.Padding(4);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new System.Windows.Forms.Padding(4);
            this.Group1.Size = new System.Drawing.Size(423, 385);
            this.Group1.TabIndex = 0;
            this.Group1.TabStop = false;
            this.Group1.Text = "Область добавления машины";
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCar.Location = new System.Drawing.Point(4, 347);
            this.AddCar.Margin = new System.Windows.Forms.Padding(4);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(415, 33);
            this.AddCar.TabIndex = 10;
            this.AddCar.Text = "Добавить";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // YearsOfSTOLabel
            // 
            this.YearsOfSTOLabel.Location = new System.Drawing.Point(5, 274);
            this.YearsOfSTOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearsOfSTOLabel.Name = "YearsOfSTOLabel";
            this.YearsOfSTOLabel.Size = new System.Drawing.Size(191, 57);
            this.YearsOfSTOLabel.TabIndex = 8;
            this.YearsOfSTOLabel.Text = "Год прохождения тех осмотра";
            this.YearsOfSTOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearsOfTOText
            // 
            this.YearsOfTOText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YearsOfTOText.Location = new System.Drawing.Point(212, 287);
            this.YearsOfTOText.Margin = new System.Windows.Forms.Padding(4);
            this.YearsOfTOText.MaxLength = 4;
            this.YearsOfTOText.Name = "YearsOfTOText";
            this.YearsOfTOText.Size = new System.Drawing.Size(195, 34);
            this.YearsOfTOText.TabIndex = 9;
            this.YearsOfTOText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearsOfSTOText_KeyPress);
            // 
            // YearsOfOutLabel
            // 
            this.YearsOfOutLabel.Location = new System.Drawing.Point(5, 212);
            this.YearsOfOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearsOfOutLabel.Name = "YearsOfOutLabel";
            this.YearsOfOutLabel.Size = new System.Drawing.Size(191, 52);
            this.YearsOfOutLabel.TabIndex = 6;
            this.YearsOfOutLabel.Text = "Год выпуска машины";
            this.YearsOfOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearsOfOutText
            // 
            this.YearsOfOutText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YearsOfOutText.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.YearsOfOutText.Location = new System.Drawing.Point(212, 222);
            this.YearsOfOutText.Margin = new System.Windows.Forms.Padding(4);
            this.YearsOfOutText.MaxLength = 4;
            this.YearsOfOutText.Name = "YearsOfOutText";
            this.YearsOfOutText.Size = new System.Drawing.Size(195, 34);
            this.YearsOfOutText.TabIndex = 7;
            this.YearsOfOutText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearsOfOutText_KeyPress);
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.Location = new System.Drawing.Point(8, 153);
            this.OwnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(183, 53);
            this.OwnerLabel.TabIndex = 4;
            this.OwnerLabel.Text = "Владелец\r\n(ФИО)";
            this.OwnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OwnerText
            // 
            this.OwnerText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OwnerText.Location = new System.Drawing.Point(212, 162);
            this.OwnerText.Margin = new System.Windows.Forms.Padding(4);
            this.OwnerText.Name = "OwnerText";
            this.OwnerText.Size = new System.Drawing.Size(195, 34);
            this.OwnerText.TabIndex = 5;
            this.OwnerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerText_KeyPress);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(17, 108);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(168, 26);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель Машины";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelText
            // 
            this.ModelText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ModelText.Location = new System.Drawing.Point(215, 105);
            this.ModelText.Margin = new System.Windows.Forms.Padding(4);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(195, 34);
            this.ModelText.TabIndex = 3;
            this.ModelText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelText_KeyPress);
            // 
            // MarkaLabel
            // 
            this.MarkaLabel.AutoSize = true;
            this.MarkaLabel.Location = new System.Drawing.Point(19, 49);
            this.MarkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarkaLabel.Name = "MarkaLabel";
            this.MarkaLabel.Size = new System.Drawing.Size(154, 26);
            this.MarkaLabel.TabIndex = 1;
            this.MarkaLabel.Text = "Марка Машины";
            this.MarkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarkaText
            // 
            this.MarkaText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MarkaText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MarkaText.Location = new System.Drawing.Point(215, 46);
            this.MarkaText.Margin = new System.Windows.Forms.Padding(4);
            this.MarkaText.Name = "MarkaText";
            this.MarkaText.Size = new System.Drawing.Size(195, 34);
            this.MarkaText.TabIndex = 1;
            this.MarkaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarkaText_KeyPress);
            // 
            // CatalogComboBox
            // 
            this.CatalogComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CatalogComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogComboBox.FormattingEnabled = true;
            this.CatalogComboBox.Location = new System.Drawing.Point(447, 41);
            this.CatalogComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CatalogComboBox.MaxDropDownItems = 20;
            this.CatalogComboBox.Name = "CatalogComboBox";
            this.CatalogComboBox.Size = new System.Drawing.Size(593, 36);
            this.CatalogComboBox.Sorted = true;
            this.CatalogComboBox.TabIndex = 2;
            this.CatalogComboBox.Text = "Марка, год выпуска, владелец";
            this.CatalogComboBox.SelectedIndexChanged += new System.EventHandler(this.CatalogComboBox_SelectedIndexChanged);
            // 
            // ChangeCar
            // 
            this.ChangeCar.AutoSize = true;
            this.ChangeCar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCar.Location = new System.Drawing.Point(663, 2);
            this.ChangeCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeCar.Name = "ChangeCar";
            this.ChangeCar.Size = new System.Drawing.Size(161, 28);
            this.ChangeCar.TabIndex = 3;
            this.ChangeCar.Text = "Выбор машины";
            // 
            // GetFine
            // 
            this.GetFine.Location = new System.Drawing.Point(16, 80);
            this.GetFine.Margin = new System.Windows.Forms.Padding(4);
            this.GetFine.Name = "GetFine";
            this.GetFine.Size = new System.Drawing.Size(275, 48);
            this.GetFine.TabIndex = 8;
            this.GetFine.Text = "Получить штраф";
            this.GetFine.UseVisualStyleBackColor = true;
            this.GetFine.Click += new System.EventHandler(this.GetFine_Click);
            // 
            // GetFineText
            // 
            this.GetFineText.Controls.Add(this.FineTextBox);
            this.GetFineText.Controls.Add(this.ToPayFine);
            this.GetFineText.Controls.Add(this.SelectFineComboBox);
            this.GetFineText.Controls.Add(this.GetFine);
            this.GetFineText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetFineText.Location = new System.Drawing.Point(447, 263);
            this.GetFineText.Margin = new System.Windows.Forms.Padding(4);
            this.GetFineText.Name = "GetFineText";
            this.GetFineText.Padding = new System.Windows.Forms.Padding(4);
            this.GetFineText.Size = new System.Drawing.Size(595, 137);
            this.GetFineText.TabIndex = 9;
            this.GetFineText.TabStop = false;
            this.GetFineText.Text = "Штрафы";
            // 
            // FineTextBox
            // 
            this.FineTextBox.Location = new System.Drawing.Point(17, 34);
            this.FineTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FineTextBox.MaxLength = 7;
            this.FineTextBox.Name = "FineTextBox";
            this.FineTextBox.Size = new System.Drawing.Size(272, 35);
            this.FineTextBox.TabIndex = 11;
            this.FineTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FineTextBox_KeyPress);
            // 
            // ToPayFine
            // 
            this.ToPayFine.Location = new System.Drawing.Point(307, 80);
            this.ToPayFine.Margin = new System.Windows.Forms.Padding(4);
            this.ToPayFine.Name = "ToPayFine";
            this.ToPayFine.Size = new System.Drawing.Size(275, 48);
            this.ToPayFine.TabIndex = 10;
            this.ToPayFine.Text = "Оплатить штраф";
            this.ToPayFine.UseVisualStyleBackColor = true;
            this.ToPayFine.Click += new System.EventHandler(this.ToPayFine_Click);
            // 
            // SelectFineComboBox
            // 
            this.SelectFineComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SelectFineComboBox.DropDownWidth = 236;
            this.SelectFineComboBox.FormattingEnabled = true;
            this.SelectFineComboBox.Location = new System.Drawing.Point(307, 34);
            this.SelectFineComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFineComboBox.Name = "SelectFineComboBox";
            this.SelectFineComboBox.Size = new System.Drawing.Size(273, 36);
            this.SelectFineComboBox.Sorted = true;
            this.SelectFineComboBox.TabIndex = 9;
            this.SelectFineComboBox.Text = "Выбирите штраф";
            // 
            // SellCar
            // 
            this.SellCar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellCar.Location = new System.Drawing.Point(447, 407);
            this.SellCar.Margin = new System.Windows.Forms.Padding(4);
            this.SellCar.Name = "SellCar";
            this.SellCar.Size = new System.Drawing.Size(595, 57);
            this.SellCar.TabIndex = 10;
            this.SellCar.Text = "Продать выбранную машину";
            this.SellCar.UseVisualStyleBackColor = true;
            this.SellCar.Click += new System.EventHandler(this.SellCar_Click);
            // 
            // GoTechInspection
            // 
            this.GoTechInspection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoTechInspection.Location = new System.Drawing.Point(16, 407);
            this.GoTechInspection.Margin = new System.Windows.Forms.Padding(4);
            this.GoTechInspection.Name = "GoTechInspection";
            this.GoTechInspection.Size = new System.Drawing.Size(423, 57);
            this.GoTechInspection.TabIndex = 11;
            this.GoTechInspection.Text = "Пройти ТехОсмотр";
            this.GoTechInspection.UseVisualStyleBackColor = true;
            this.GoTechInspection.Click += new System.EventHandler(this.GoTechInspection_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Column2});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.Location = new System.Drawing.Point(447, 92);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(595, 170);
            this.dataGridView.TabIndex = 13;
            // 
            // Names
            // 
            this.Names.FillWeight = 101.3333F;
            this.Names.HeaderText = "Names";
            this.Names.MaxInputLength = 50;
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 140;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 98.66666F;
            this.Column2.HeaderText = "Cars";
            this.Column2.MaxInputLength = 50;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 306;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 474);
            this.Controls.Add(this.GetFineText);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.GoTechInspection);
            this.Controls.Add(this.SellCar);
            this.Controls.Add(this.ChangeCar);
            this.Controls.Add(this.CatalogComboBox);
            this.Controls.Add(this.Group1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Group1.ResumeLayout(false);
            this.Group1.PerformLayout();
            this.GetFineText.ResumeLayout(false);
            this.GetFineText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MarkaLabel;
        private System.Windows.Forms.Label YearsOfSTOLabel;
        private System.Windows.Forms.Label YearsOfOutLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Label ChangeCar;
        private System.Windows.Forms.Button GetFine;
        private System.Windows.Forms.GroupBox GetFineText;
        private System.Windows.Forms.Button ToPayFine;
        private System.Windows.Forms.TextBox FineTextBox;
        private System.Windows.Forms.Button SellCar;
        private System.Windows.Forms.Button GoTechInspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridView dataGridView;
        internal System.Windows.Forms.ComboBox CatalogComboBox;
        internal System.Windows.Forms.ComboBox SelectFineComboBox;
        internal System.Windows.Forms.GroupBox Group1;
        internal System.Windows.Forms.TextBox MarkaText;
        internal System.Windows.Forms.TextBox YearsOfTOText;
        internal System.Windows.Forms.TextBox YearsOfOutText;
        internal System.Windows.Forms.TextBox OwnerText;
        internal System.Windows.Forms.TextBox ModelText;
    }

}

