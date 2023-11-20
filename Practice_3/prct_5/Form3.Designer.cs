namespace Practice_3.prct_5
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameSurname_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirth_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNumer_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameSurnameSorted_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthSorted_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNumberSorted_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surname_GUI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_GUI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.year_picker_gui = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numberSchoolPicker_GUI = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.schoolNumberForSort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSchoolPicker_GUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNumberForSort)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(16, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSurname_GUI,
            this.yearOfBirth_GUI,
            this.schoolNumer_GUI});
            this.dataGridView1.Location = new System.Drawing.Point(224, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 461);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameSurname_GUI
            // 
            this.nameSurname_GUI.HeaderText = "Призвіще та Ім\'я";
            this.nameSurname_GUI.MinimumWidth = 6;
            this.nameSurname_GUI.Name = "nameSurname_GUI";
            this.nameSurname_GUI.Width = 150;
            // 
            // yearOfBirth_GUI
            // 
            this.yearOfBirth_GUI.HeaderText = "Рік народження";
            this.yearOfBirth_GUI.MinimumWidth = 6;
            this.yearOfBirth_GUI.Name = "yearOfBirth_GUI";
            this.yearOfBirth_GUI.Width = 140;
            // 
            // schoolNumer_GUI
            // 
            this.schoolNumer_GUI.HeaderText = "Номер школи";
            this.schoolNumer_GUI.MinimumWidth = 6;
            this.schoolNumer_GUI.Name = "schoolNumer_GUI";
            this.schoolNumer_GUI.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSurnameSorted_GUI,
            this.yearOfBirthSorted_GUI,
            this.schoolNumberSorted_GUI});
            this.dataGridView2.Location = new System.Drawing.Point(800, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(570, 461);
            this.dataGridView2.TabIndex = 2;
            // 
            // nameSurnameSorted_GUI
            // 
            this.nameSurnameSorted_GUI.HeaderText = "Призвіще та Ім\'я";
            this.nameSurnameSorted_GUI.MinimumWidth = 6;
            this.nameSurnameSorted_GUI.Name = "nameSurnameSorted_GUI";
            this.nameSurnameSorted_GUI.Width = 150;
            // 
            // yearOfBirthSorted_GUI
            // 
            this.yearOfBirthSorted_GUI.HeaderText = "Рік народження";
            this.yearOfBirthSorted_GUI.MinimumWidth = 6;
            this.yearOfBirthSorted_GUI.Name = "yearOfBirthSorted_GUI";
            this.yearOfBirthSorted_GUI.Width = 140;
            // 
            // schoolNumberSorted_GUI
            // 
            this.schoolNumberSorted_GUI.HeaderText = "Номер школи";
            this.schoolNumberSorted_GUI.MinimumWidth = 6;
            this.schoolNumberSorted_GUI.Name = "schoolNumberSorted_GUI";
            this.schoolNumberSorted_GUI.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Інформація";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(796, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Відсортована інформація";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введення інформації";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Призвіще";
            // 
            // surname_GUI
            // 
            this.surname_GUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.surname_GUI.Location = new System.Drawing.Point(16, 53);
            this.surname_GUI.Name = "surname_GUI";
            this.surname_GUI.Size = new System.Drawing.Size(120, 26);
            this.surname_GUI.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ім\'я";
            // 
            // name_GUI
            // 
            this.name_GUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.name_GUI.Location = new System.Drawing.Point(16, 105);
            this.name_GUI.Name = "name_GUI";
            this.name_GUI.Size = new System.Drawing.Size(120, 26);
            this.name_GUI.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Рік народження";
            // 
            // year_picker_gui
            // 
            this.year_picker_gui.CustomFormat = "";
            this.year_picker_gui.Location = new System.Drawing.Point(16, 157);
            this.year_picker_gui.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.year_picker_gui.MinDate = new System.DateTime(1968, 1, 1, 0, 0, 0, 0);
            this.year_picker_gui.Name = "year_picker_gui";
            this.year_picker_gui.Size = new System.Drawing.Size(120, 22);
            this.year_picker_gui.TabIndex = 12;
            this.year_picker_gui.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер школи";
            // 
            // numberSchoolPicker_GUI
            // 
            this.numberSchoolPicker_GUI.Location = new System.Drawing.Point(16, 205);
            this.numberSchoolPicker_GUI.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numberSchoolPicker_GUI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberSchoolPicker_GUI.Name = "numberSchoolPicker_GUI";
            this.numberSchoolPicker_GUI.Size = new System.Drawing.Size(120, 22);
            this.numberSchoolPicker_GUI.TabIndex = 14;
            this.numberSchoolPicker_GUI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(16, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Додати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button3.Location = new System.Drawing.Point(16, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button4.Location = new System.Drawing.Point(16, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Запис ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button5.Location = new System.Drawing.Point(16, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "Читання";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(12, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Робота з файлом";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button6.Location = new System.Drawing.Point(1082, 531);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 30);
            this.button6.TabIndex = 20;
            this.button6.Text = "Сортувати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // schoolNumberForSort
            // 
            this.schoolNumberForSort.Location = new System.Drawing.Point(1082, 503);
            this.schoolNumberForSort.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.schoolNumberForSort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.schoolNumberForSort.Name = "schoolNumberForSort";
            this.schoolNumberForSort.Size = new System.Drawing.Size(120, 22);
            this.schoolNumberForSort.TabIndex = 21;
            this.schoolNumberForSort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(796, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 60);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введіть номер школи, щоб \r\nвідсортувати учнів з цієї школи \r\nза їх роком народжен" +
    "ня";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 573);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.schoolNumberForSort);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberSchoolPicker_GUI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.year_picker_gui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_GUI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surname_GUI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSchoolPicker_GUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolNumberForSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurname_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirth_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNumer_GUI;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameSorted_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthSorted_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNumberSorted_GUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname_GUI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_GUI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker year_picker_gui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numberSchoolPicker_GUI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown schoolNumberForSort;
        private System.Windows.Forms.Label label9;
    }
}