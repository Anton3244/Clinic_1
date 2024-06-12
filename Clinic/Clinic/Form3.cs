using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form3 : Form
    {
        private BindingList<Record> records;

        public Form3(BindingList<Record> records)
        {
            InitializeComponent();
            this.records = records;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Отримання введених значень
            string selectedDay = comboDayOfWeek.SelectedItem.ToString();
            TimeSpan selectedTime = TimeSpan.Parse(txtTime.Text);

            // Перевірка, чи приймає кабінет травматолога в цей час
            bool isTraumatologistAvailable = CheckTraumatologistAvailability(selectedDay, selectedTime);

            // Виведення результату перевірки
            if (isTraumatologistAvailable)
            {
                MessageBox.Show("Кабінет травматолога вільний в цей час.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Кабінет травматолога зайнятий в цей час.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckTraumatologistAvailability(string dayOfWeek, TimeSpan time)
        {
            foreach (var record in records)
            {
                if (record.RoomName == "Травматолог" && record.DayOfWeek == dayOfWeek && record.StartTime <= time && record.EndTime >= time)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
