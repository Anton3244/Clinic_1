using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Clinic
{
    public partial class Form1 : Form
    {
        private BindingList<Record> records = new BindingList<Record>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeEventHandlers();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = records;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RoomName", HeaderText = "Назва кабінету" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RoomNumber", HeaderText = "Номер кабінету" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DoctorName", HeaderText = "ПІБ лікаря" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DayOfWeek", HeaderText = "День прийому" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartTime", HeaderText = "Час початку прийому" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EndTime", HeaderText = "Час закінчення прийому" });

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void InitializeEventHandlers()
        {
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDeleteAll.Click += btnDeleteAll_Click;
            btnCheck.Click += btnCheck_Click;
            btnSort.Click += btnSort_Click;
            btnSearch.Click += btnSearch_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.RecordAdded += Form2_RecordAdded;
            form2.Show();
        }

        private void Form2_RecordAdded(object sender, RecordEventArgs e)
        {
            records.Add(e.Record);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRecord = dataGridView1.SelectedRows[0].DataBoundItem as Record;
                if (selectedRecord != null)
                {
                    var form2 = new Form2(selectedRecord);
                    form2.RecordAdded += (s, ev) => dataGridView1.Refresh();
                    form2.Show();
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            records.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var form3 = new Form3(records); // Передача змінної records в конструктор Form3
            form3.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Record> sortedList = new List<Record>(records);
            sortedList.Sort((x, y) => string.Compare(x.DoctorName, y.DoctorName));
            records = new BindingList<Record>(sortedList);
            dataGridView1.DataSource = records;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDoctorName = txtSearchDoctorName.Text;
            if (!string.IsNullOrEmpty(searchDoctorName))
            {
                List<Record> sortedList = new List<Record>(records);
                sortedList.Sort((x, y) => string.Compare(x.DoctorName, y.DoctorName));
                int index = sortedList.BinarySearch(new Record { DoctorName = searchDoctorName }, new RecordDoctorNameComparer());
                if (index >= 0)
                {
                    var record = sortedList[index];
                    MessageBox.Show($"Знайдено запис: {record.RoomName}, {record.RoomNumber}, {record.DoctorName}, {record.DayOfWeek}, {record.StartTime}, {record.EndTime}");
                }
                else
                {
                    MessageBox.Show("Лікаря не знайдено");
                }
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            }
        }

        private void btnCountDoctors_Click(object sender, EventArgs e)
        {
            var doctorsOnFridayAfternoon = records.Where(r => r.DayOfWeek == "П'ятниця" && r.StartTime > new TimeSpan(12, 0, 0)).ToList();

            // Вивести кількість лікарів
            MessageBox.Show($"Кількість лікарів, які починають прийом в п'ятницю після 12:00: {doctorsOnFridayAfternoon.Count}");

            // Видалити лікарів з оригінального списку
            foreach (var doctor in doctorsOnFridayAfternoon)
            {
                records.Remove(doctor);
            }

            // Додати лікарів на верх таблиці
            foreach (var doctor in doctorsOnFridayAfternoon)
            {
                records.Insert(0, doctor);
            }

            // Оновити DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = records;
        }

        private void btnLastTherapist_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибраний день
            if (comboDayOfWeek.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть день тижня.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримуємо вибраний день тижня
            string selectedDay = comboDayOfWeek.SelectedItem.ToString();

            // Отримуємо терапевтів, які приймають у вибраний день
            var therapistsOnSelectedDay = records.Where(r => r.RoomName == "Терапевт" && r.DayOfWeek == selectedDay).ToList();

            if (therapistsOnSelectedDay.Count == 0)
            {
                MessageBox.Show("У цей день немає терапевтів, які приймають.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Знаходимо терапевта, який останнім завершує прийом
            var latestTherapist = therapistsOnSelectedDay.OrderByDescending(r => r.EndTime).FirstOrDefault();

            if (latestTherapist != null)
            {
                MessageBox.Show($"Терапевт {latestTherapist.DoctorName} останнім завершує прийом у {selectedDay}. " +
                    $"Кабінет: {latestTherapist.RoomName}, номер: {latestTherapist.RoomNumber}. " +
                    $"Початок прийому: {latestTherapist.StartTime}, кінець прийому: {latestTherapist.EndTime}");
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибраний день
            if (comboTomorrowDayOfWeek.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть день тижня.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримуємо вибраний день тижня
            string selectedDay = comboTomorrowDayOfWeek.SelectedItem.ToString();

            // Отримуємо записи, що починаються до 14:00 і закінчуються після 14:00
            var employees = records.Where(r => r.DayOfWeek == selectedDay && r.StartTime < new TimeSpan(14, 0, 0) && r.EndTime > new TimeSpan(14, 0, 0)).ToList();

            if (employees.Count == 0)
            {
                MessageBox.Show("У цей день немає співробітників, які приймають у вказаний час.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Створюємо файл і записуємо інформацію
            string filePath = "employees_info.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (var employee in employees)
                {
                    file.WriteLine($"Кабінет: {employee.RoomName}, Номер: {employee.RoomNumber}, Лікар: {employee.DoctorName}, " +
                                   $"День: {employee.DayOfWeek}, Початок прийому: {employee.StartTime}, Кінець прийому: {employee.EndTime}");
                }
            }

            MessageBox.Show($"Інформація збережена у файл: {filePath}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveToXml_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Зберегти як";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Record>));
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, records);
                    }
                    MessageBox.Show($"Дані збережено у файл: {filePath}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoadFromXml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.Title = "Відкрити файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Record>));
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        records = (BindingList<Record>)serializer.Deserialize(reader);
                        dataGridView1.DataSource = records;
                    }
                    MessageBox.Show("Дані завантажено з файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboTomorrowDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Record
    {
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public string DoctorName { get; set; }
        public string DayOfWeek { get; set; }  // 1 Понеділок, 7 Неділя
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public class RecordEventArgs : EventArgs
    {
        public Record Record { get; }

        public RecordEventArgs(Record record)
        {
            Record = record;
        }
    }

    public class RecordDoctorNameComparer : IComparer<Record>
    {
        public int Compare(Record x, Record y)
        {
            return string.Compare(x.DoctorName, y.DoctorName);
        }
    }
}
