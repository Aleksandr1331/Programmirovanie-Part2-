namespace Laborotornay1
{
    partial class Form
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
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.YearsOfSTOLabel = new System.Windows.Forms.Label();
            this.YearsOfSTOText = new System.Windows.Forms.TextBox();
            this.YearsOfOutLabel = new System.Windows.Forms.Label();
            this.YearsOfOutText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
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
            this.Group1.Controls.Add(this.SecondNameLabel);
            this.Group1.Controls.Add(this.SecondNameText);
            this.Group1.Controls.Add(this.LastNameLabel);
            this.Group1.Controls.Add(this.LastNameText);
            this.Group1.Controls.Add(this.AddCar);
            this.Group1.Controls.Add(this.YearsOfSTOLabel);
            this.Group1.Controls.Add(this.YearsOfSTOText);
            this.Group1.Controls.Add(this.YearsOfOutLabel);
            this.Group1.Controls.Add(this.YearsOfOutText);
            this.Group1.Controls.Add(this.NameLabel);
            this.Group1.Controls.Add(this.NameText);
            this.Group1.Controls.Add(this.ModelLabel);
            this.Group1.Controls.Add(this.ModelText);
            this.Group1.Controls.Add(this.MarkaLabel);
            this.Group1.Controls.Add(this.MarkaText);
            this.Group1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group1.Location = new System.Drawing.Point(12, 12);
            this.Group1.Name = "Group1";
            this.Group1.Size = new System.Drawing.Size(317, 425);
            this.Group1.TabIndex = 0;
            this.Group1.TabStop = false;
            this.Group1.Text = "Область добавления машины";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondNameLabel.Location = new System.Drawing.Point(10, 227);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(137, 43);
            this.SecondNameLabel.TabIndex = 13;
            this.SecondNameLabel.Text = "Отчество владельца";
            this.SecondNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondNameText
            // 
            this.SecondNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondNameText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SecondNameText.Location = new System.Drawing.Point(159, 235);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(147, 28);
            this.SecondNameText.TabIndex = 14;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameLabel.Location = new System.Drawing.Point(0, 172);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(153, 43);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Фамилия владельца";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LastNameText.Location = new System.Drawing.Point(159, 182);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(147, 28);
            this.LastNameText.TabIndex = 12;
            // 
            // AddCar
            // 
            this.AddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCar.Location = new System.Drawing.Point(3, 392);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(311, 27);
            this.AddCar.TabIndex = 10;
            this.AddCar.Text = "Добавить";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // YearsOfSTOLabel
            // 
            this.YearsOfSTOLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearsOfSTOLabel.Location = new System.Drawing.Point(4, 333);
            this.YearsOfSTOLabel.Name = "YearsOfSTOLabel";
            this.YearsOfSTOLabel.Size = new System.Drawing.Size(143, 46);
            this.YearsOfSTOLabel.TabIndex = 8;
            this.YearsOfSTOLabel.Text = "Год прохождения тех осмотра";
            this.YearsOfSTOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearsOfSTOText
            // 
            this.YearsOfSTOText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearsOfSTOText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YearsOfSTOText.Location = new System.Drawing.Point(159, 343);
            this.YearsOfSTOText.MaxLength = 4;
            this.YearsOfSTOText.Name = "YearsOfSTOText";
            this.YearsOfSTOText.Size = new System.Drawing.Size(147, 28);
            this.YearsOfSTOText.TabIndex = 9;
            this.YearsOfSTOText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearsOfSTOText_KeyPress);
            // 
            // YearsOfOutLabel
            // 
            this.YearsOfOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearsOfOutLabel.Location = new System.Drawing.Point(4, 282);
            this.YearsOfOutLabel.Name = "YearsOfOutLabel";
            this.YearsOfOutLabel.Size = new System.Drawing.Size(143, 42);
            this.YearsOfOutLabel.TabIndex = 6;
            this.YearsOfOutLabel.Text = "Год выпуска машины";
            this.YearsOfOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearsOfOutText
            // 
            this.YearsOfOutText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearsOfOutText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YearsOfOutText.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.YearsOfOutText.Location = new System.Drawing.Point(159, 290);
            this.YearsOfOutText.MaxLength = 4;
            this.YearsOfOutText.Name = "YearsOfOutText";
            this.YearsOfOutText.Size = new System.Drawing.Size(147, 28);
            this.YearsOfOutText.TabIndex = 7;
            this.YearsOfOutText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearsOfOutText_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.Location = new System.Drawing.Point(6, 124);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 43);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Имя владельца";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameText.Location = new System.Drawing.Point(159, 132);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(147, 28);
            this.NameText.TabIndex = 5;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(13, 88);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(132, 20);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель Машины";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelText
            // 
            this.ModelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ModelText.Location = new System.Drawing.Point(161, 85);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(147, 28);
            this.ModelText.TabIndex = 3;
            // 
            // MarkaLabel
            // 
            this.MarkaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkaLabel.AutoSize = true;
            this.MarkaLabel.Location = new System.Drawing.Point(14, 40);
            this.MarkaLabel.Name = "MarkaLabel";
            this.MarkaLabel.Size = new System.Drawing.Size(120, 20);
            this.MarkaLabel.TabIndex = 1;
            this.MarkaLabel.Text = "Марка Машины";
            this.MarkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarkaText
            // 
            this.MarkaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MarkaText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MarkaText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MarkaText.Location = new System.Drawing.Point(161, 37);
            this.MarkaText.Name = "MarkaText";
            this.MarkaText.Size = new System.Drawing.Size(147, 28);
            this.MarkaText.TabIndex = 1;
            // 
            // CatalogComboBox
            // 
            this.CatalogComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CatalogComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogComboBox.FormattingEnabled = true;
            this.CatalogComboBox.Location = new System.Drawing.Point(429, 41);
            this.CatalogComboBox.MaxDropDownItems = 20;
            this.CatalogComboBox.Name = "CatalogComboBox";
            this.CatalogComboBox.Size = new System.Drawing.Size(331, 31);
            this.CatalogComboBox.Sorted = true;
            this.CatalogComboBox.TabIndex = 2;
            this.CatalogComboBox.Text = "Марка, год выпуска, владелец";
            this.CatalogComboBox.SelectedIndexChanged += new System.EventHandler(this.CatalogComboBox_SelectedIndexChanged);
            // 
            // ChangeCar
            // 
            this.ChangeCar.AutoSize = true;
            this.ChangeCar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCar.Location = new System.Drawing.Point(530, 9);
            this.ChangeCar.Name = "ChangeCar";
            this.ChangeCar.Size = new System.Drawing.Size(128, 23);
            this.ChangeCar.TabIndex = 3;
            this.ChangeCar.Text = "Выбор машины";
            // 
            // GetFine
            // 
            this.GetFine.Location = new System.Drawing.Point(17, 77);
            this.GetFine.Name = "GetFine";
            this.GetFine.Size = new System.Drawing.Size(206, 39);
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
            this.GetFineText.Location = new System.Drawing.Point(335, 239);
            this.GetFineText.Name = "GetFineText";
            this.GetFineText.Size = new System.Drawing.Size(488, 129);
            this.GetFineText.TabIndex = 9;
            this.GetFineText.TabStop = false;
            this.GetFineText.Text = "Штрафы";
            // 
            // FineTextBox
            // 
            this.FineTextBox.Location = new System.Drawing.Point(18, 40);
            this.FineTextBox.MaxLength = 7;
            this.FineTextBox.Name = "FineTextBox";
            this.FineTextBox.Size = new System.Drawing.Size(205, 30);
            this.FineTextBox.TabIndex = 11;
            this.FineTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FineTextBox_KeyPress);
            // 
            // ToPayFine
            // 
            this.ToPayFine.Location = new System.Drawing.Point(263, 77);
            this.ToPayFine.Name = "ToPayFine";
            this.ToPayFine.Size = new System.Drawing.Size(206, 36);
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
            this.SelectFineComboBox.Location = new System.Drawing.Point(263, 40);
            this.SelectFineComboBox.Name = "SelectFineComboBox";
            this.SelectFineComboBox.Size = new System.Drawing.Size(206, 31);
            this.SelectFineComboBox.Sorted = true;
            this.SelectFineComboBox.TabIndex = 9;
            this.SelectFineComboBox.Text = "Выбирите штраф";
            // 
            // SellCar
            // 
            this.SellCar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellCar.Location = new System.Drawing.Point(582, 391);
            this.SellCar.Name = "SellCar";
            this.SellCar.Size = new System.Drawing.Size(241, 46);
            this.SellCar.TabIndex = 10;
            this.SellCar.Text = "Продать выбранную машину";
            this.SellCar.UseVisualStyleBackColor = true;
            // 
            // GoTechInspection
            // 
            this.GoTechInspection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoTechInspection.Location = new System.Drawing.Point(335, 391);
            this.GoTechInspection.Name = "GoTechInspection";
            this.GoTechInspection.Size = new System.Drawing.Size(241, 46);
            this.GoTechInspection.TabIndex = 11;
            this.GoTechInspection.Text = "Пройти ТехОсмотр";
            this.GoTechInspection.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.Location = new System.Drawing.Point(414, 89);
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
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(361, 138);
            this.dataGridView.TabIndex = 13;
            // 
            // Names
            // 
            this.Names.FillWeight = 101.3333F;
            this.Names.HeaderText = "Names";
            this.Names.MaxInputLength = 50;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 110;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 98.66666F;
            this.Column2.HeaderText = "Cars";
            this.Column2.MaxInputLength = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 249;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 442);
            this.Controls.Add(this.GetFineText);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.GoTechInspection);
            this.Controls.Add(this.SellCar);
            this.Controls.Add(this.ChangeCar);
            this.Controls.Add(this.CatalogComboBox);
            this.Controls.Add(this.Group1);
            this.Name = "Form";
            this.Group1.ResumeLayout(false);
            this.Group1.PerformLayout();
            this.GetFineText.ResumeLayout(false);
            this.GetFineText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.Label MarkaLabel;
        private System.Windows.Forms.TextBox MarkaText;
        private System.Windows.Forms.Label YearsOfSTOLabel;
        private System.Windows.Forms.TextBox YearsOfSTOText;
        private System.Windows.Forms.Label YearsOfOutLabel;
        private System.Windows.Forms.TextBox YearsOfOutText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.ComboBox CatalogComboBox;
        private System.Windows.Forms.Label ChangeCar;
        private System.Windows.Forms.Button GetFine;
        private System.Windows.Forms.GroupBox GetFineText;
        private System.Windows.Forms.ComboBox SelectFineComboBox;
        private System.Windows.Forms.Button ToPayFine;
        private System.Windows.Forms.TextBox FineTextBox;
        private System.Windows.Forms.Button SellCar;
        private System.Windows.Forms.Button GoTechInspection;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.TextBox SecondNameText;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }

}

