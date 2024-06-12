namespace Clinic
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            comboRoomName = new ComboBox();
            txtRoomNumber = new TextBox();
            txtDoctorName = new TextBox();
            comboDayOfWeek = new ComboBox();
            txtStartTime = new TextBox();
            txtEndTime = new TextBox();
            lblRoomName = new Label();
            lblRoomNumber = new Label();
            lblDoctorName = new Label();
            lblDayOfWeek = new Label();
            lblStartTime = new Label();
            lblEndTime = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // comboRoomName
            // 
            comboRoomName.FormattingEnabled = true;
            comboRoomName.Items.AddRange(new object[] { "Травматолог", "Терапевт", "Кардіолог", "Невропатолог", "Педіатр" });
            comboRoomName.Location = new Point(218, 30);
            comboRoomName.Name = "comboRoomName";
            comboRoomName.Size = new Size(200, 28);
            comboRoomName.TabIndex = 0;
            comboRoomName.SelectedIndexChanged += comboRoomName_SelectedIndexChanged;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(218, 70);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(200, 27);
            txtRoomNumber.TabIndex = 1;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(218, 110);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(200, 27);
            txtDoctorName.TabIndex = 2;
            // 
            // comboDayOfWeek
            // 
            comboDayOfWeek.FormattingEnabled = true;
            comboDayOfWeek.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            comboDayOfWeek.Location = new Point(218, 150);
            comboDayOfWeek.Name = "comboDayOfWeek";
            comboDayOfWeek.Size = new Size(200, 28);
            comboDayOfWeek.TabIndex = 3;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new Point(218, 190);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(200, 27);
            txtStartTime.TabIndex = 4;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new Point(218, 230);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(200, 27);
            txtEndTime.TabIndex = 5;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(30, 30);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(113, 20);
            lblRoomName.TabIndex = 6;
            lblRoomName.Text = "Назва кабінету";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(30, 70);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(119, 20);
            lblRoomNumber.TabIndex = 7;
            lblRoomNumber.Text = "Номер кабінету";
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new Point(30, 110);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(81, 20);
            lblDoctorName.TabIndex = 8;
            lblDoctorName.Text = "ПІБ лікаря";
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(30, 150);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(111, 20);
            lblDayOfWeek.TabIndex = 9;
            lblDayOfWeek.Text = "День прийому";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(30, 190);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(159, 20);
            lblStartTime.TabIndex = 10;
            lblStartTime.Text = "Час початку прийому";
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(30, 230);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(182, 20);
            lblEndTime.TabIndex = 11;
            lblEndTime.Text = "Час закінчення прийому";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(466, 357);
            Controls.Add(btnSave);
            Controls.Add(lblEndTime);
            Controls.Add(lblStartTime);
            Controls.Add(lblDayOfWeek);
            Controls.Add(lblDoctorName);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblRoomName);
            Controls.Add(txtEndTime);
            Controls.Add(txtStartTime);
            Controls.Add(comboDayOfWeek);
            Controls.Add(txtDoctorName);
            Controls.Add(txtRoomNumber);
            Controls.Add(comboRoomName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboRoomName;
        private TextBox txtRoomNumber;
        private TextBox txtDoctorName;
        private ComboBox comboDayOfWeek;
        private TextBox txtStartTime;
        private TextBox txtEndTime;
        private Label lblRoomName;
        private Label lblRoomNumber;
        private Label lblDoctorName;
        private Label lblDayOfWeek;
        private Label lblStartTime;
        private Label lblEndTime;
        private Button btnSave;
    }
}
