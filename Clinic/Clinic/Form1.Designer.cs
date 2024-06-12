namespace Clinic
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDeleteAll = new Button();
            btnSort = new Button();
            btnSearch = new Button();
            btnCheck = new Button();
            txtSearchDoctorName = new TextBox();
            listView1 = new ListView();
            listView2 = new ListView();
            btnCountDoctors = new Button();
            listView4 = new ListView();
            btnShowTherapist = new Button();
            listView3 = new ListView();
            listView5 = new ListView();
            comboDayOfWeek = new ComboBox();
            btnSaveToFile = new Button();
            comboTomorrowDayOfWeek = new ComboBox();
            btnSaveToXml = new Button();
            btnLoadFromXml = new Button();
            listView6 = new ListView();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(239, 12);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(792, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Таблиця";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(792, 317);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 23);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(25, 68);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(25, 113);
            btnDeleteAll.Margin = new Padding(4, 5, 4, 5);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(151, 35);
            btnDeleteAll.TabIndex = 3;
            btnDeleteAll.Text = "Видалити все";
            btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(25, 158);
            btnSort.Margin = new Padding(4, 5, 4, 5);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(151, 35);
            btnSort.TabIndex = 4;
            btnSort.Text = "Сортувати";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(35, 234);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 36);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Пошук за ім'ям";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(250, 385);
            btnCheck.Margin = new Padding(4, 5, 4, 5);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(148, 53);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Перевірити травматолога";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtSearchDoctorName
            // 
            txtSearchDoctorName.Location = new Point(35, 280);
            txtSearchDoctorName.Margin = new Padding(4, 5, 4, 5);
            txtSearchDoctorName.Name = "txtSearchDoctorName";
            txtSearchDoctorName.Size = new Size(151, 27);
            txtSearchDoctorName.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Location = new Point(14, 217);
            listView1.Name = "listView1";
            listView1.Size = new Size(192, 106);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(12, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(178, 194);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnCountDoctors
            // 
            btnCountDoctors.Location = new Point(445, 385);
            btnCountDoctors.Name = "btnCountDoctors";
            btnCountDoctors.Size = new Size(138, 53);
            btnCountDoctors.TabIndex = 11;
            btnCountDoctors.Text = "Підрахунок лікарів ";
            btnCountDoctors.UseVisualStyleBackColor = true;
            btnCountDoctors.Click += btnCountDoctors_Click;
            // 
            // listView4
            // 
            listView4.Location = new Point(427, 370);
            listView4.Name = "listView4";
            listView4.Size = new Size(171, 81);
            listView4.TabIndex = 12;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowTherapist
            // 
            btnShowTherapist.Location = new Point(35, 349);
            btnShowTherapist.Name = "btnShowTherapist";
            btnShowTherapist.Size = new Size(129, 53);
            btnShowTherapist.TabIndex = 13;
            btnShowTherapist.Text = "відомості про терапевта";
            btnShowTherapist.UseVisualStyleBackColor = true;
            btnShowTherapist.Click += btnLastTherapist_Click;
            // 
            // listView3
            // 
            listView3.Location = new Point(239, 370);
            listView3.Name = "listView3";
            listView3.Size = new Size(171, 81);
            listView3.TabIndex = 14;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            listView5.Location = new Point(12, 334);
            listView5.Name = "listView5";
            listView5.Size = new Size(175, 130);
            listView5.TabIndex = 15;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // comboDayOfWeek
            // 
            comboDayOfWeek.FormattingEnabled = true;
            comboDayOfWeek.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            comboDayOfWeek.Location = new Point(25, 420);
            comboDayOfWeek.Name = "comboDayOfWeek";
            comboDayOfWeek.Size = new Size(151, 28);
            comboDayOfWeek.TabIndex = 16;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(659, 420);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(129, 44);
            btnSaveToFile.TabIndex = 17;
            btnSaveToFile.Text = "Перевірити";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // comboTomorrowDayOfWeek
            // 
            comboTomorrowDayOfWeek.FormattingEnabled = true;
            comboTomorrowDayOfWeek.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            comboTomorrowDayOfWeek.Location = new Point(659, 482);
            comboTomorrowDayOfWeek.Name = "comboTomorrowDayOfWeek";
            comboTomorrowDayOfWeek.Size = new Size(151, 28);
            comboTomorrowDayOfWeek.TabIndex = 18;
            comboTomorrowDayOfWeek.SelectedIndexChanged += comboTomorrowDayOfWeek_SelectedIndexChanged;
            // 
            // btnSaveToXml
            // 
            btnSaveToXml.Location = new Point(243, 482);
            btnSaveToXml.Name = "btnSaveToXml";
            btnSaveToXml.Size = new Size(167, 51);
            btnSaveToXml.TabIndex = 19;
            btnSaveToXml.Text = "Зберегти XML";
            btnSaveToXml.UseVisualStyleBackColor = true;
            btnSaveToXml.Click += btnSaveToXml_Click;
            // 
            // btnLoadFromXml
            // 
            btnLoadFromXml.Location = new Point(427, 482);
            btnLoadFromXml.Name = "btnLoadFromXml";
            btnLoadFromXml.Size = new Size(171, 51);
            btnLoadFromXml.TabIndex = 20;
            btnLoadFromXml.Text = "Завантажити XML";
            btnLoadFromXml.UseVisualStyleBackColor = true;
            btnLoadFromXml.Click += btnLoadFromXml_Click;
            // 
            // listView6
            // 
            listView6.Location = new Point(629, 370);
            listView6.Name = "listView6";
            listView6.Size = new Size(332, 163);
            listView6.TabIndex = 21;
            listView6.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 382);
            label1.Name = "label1";
            label1.Size = new Size(298, 20);
            label1.TabIndex = 22;
            label1.Text = "Надати інформію про всіх співробітників";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1070, 753);
            Controls.Add(label1);
            Controls.Add(btnLoadFromXml);
            Controls.Add(btnSaveToXml);
            Controls.Add(comboTomorrowDayOfWeek);
            Controls.Add(btnSaveToFile);
            Controls.Add(comboDayOfWeek);
            Controls.Add(btnShowTherapist);
            Controls.Add(btnCountDoctors);
            Controls.Add(txtSearchDoctorName);
            Controls.Add(btnSearch);
            Controls.Add(btnCheck);
            Controls.Add(btnSort);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tabControl1);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView5);
            Controls.Add(listView6);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDeleteAll;
        private Button btnSort;
        private Button btnCheck;
        private Button btnSearch;
        private TextBox txtSearchDoctorName;
        private ListView listView1;
        private ListView listView2;
        private Button btnCountDoctors;
        private ListView listView4;
        private Button btnShowTherapist;
        private ListView listView3;
        private ListView listView5;
        private ComboBox comboDayOfWeek;
        private Button btnSaveToFile;
        private ComboBox comboTomorrowDayOfWeek;
        private Button btnSaveToXml;
        private Button btnLoadFromXml;
        private ListView listView6;
        private Label label1;
    }
}
