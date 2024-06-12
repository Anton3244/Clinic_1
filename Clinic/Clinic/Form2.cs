using System;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form2 : Form
    {
        private Record recordToEdit;

        public event EventHandler<RecordEventArgs> RecordAdded;
        public event EventHandler<RecordEventArgs> RecordUpdated;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Record record) : this()
        {
            recordToEdit = record;

            comboRoomName.Text = record.RoomName;
            txtRoomNumber.Text = record.RoomNumber.ToString();
            txtDoctorName.Text = record.DoctorName;
            comboDayOfWeek.SelectedItem = record.DayOfWeek;
            txtStartTime.Text = record.StartTime.ToString(@"hh\:mm");
            txtEndTime.Text = record.EndTime.ToString(@"hh\:mm");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Будь ласка, введіть всі необхідні дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (recordToEdit == null)
            {
                var newRecord = new Record
                {
                    RoomName = comboRoomName.Text,
                    RoomNumber = Convert.ToInt32(txtRoomNumber.Text),
                    DoctorName = txtDoctorName.Text,
                    DayOfWeek = comboDayOfWeek.SelectedItem.ToString(),
                    StartTime = TimeSpan.Parse(txtStartTime.Text),
                    EndTime = TimeSpan.Parse(txtEndTime.Text)
                };

                RecordAdded?.Invoke(this, new RecordEventArgs(newRecord));
            }
            else
            {
                recordToEdit.RoomName = comboRoomName.Text;
                recordToEdit.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                recordToEdit.DoctorName = txtDoctorName.Text;
                recordToEdit.DayOfWeek = comboDayOfWeek.SelectedItem.ToString();
                recordToEdit.StartTime = TimeSpan.Parse(txtStartTime.Text);
                recordToEdit.EndTime = TimeSpan.Parse(txtEndTime.Text);

                RecordUpdated?.Invoke(this, new RecordEventArgs(recordToEdit));
            }

            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(comboRoomName.Text) || string.IsNullOrWhiteSpace(txtRoomNumber.Text) || string.IsNullOrWhiteSpace(txtDoctorName.Text) ||
                comboDayOfWeek.SelectedItem == null || string.IsNullOrWhiteSpace(txtStartTime.Text) || string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                return false;
            }

            return true;
        }

        private void comboRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
