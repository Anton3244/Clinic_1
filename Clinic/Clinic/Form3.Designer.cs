namespace Clinic
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboDayOfWeek = new ComboBox();
            txtTime = new TextBox();
            btnCheck = new Button();
            lblDayOfWeek = new Label();
            lblStartTime = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboDayOfWeek
            // 
            comboDayOfWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDayOfWeek.FormattingEnabled = true;
            comboDayOfWeek.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            comboDayOfWeek.Location = new Point(169, 88);
            comboDayOfWeek.Name = "comboDayOfWeek";
            comboDayOfWeek.Size = new Size(108, 28);
            comboDayOfWeek.TabIndex = 0;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(169, 130);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(108, 27);
            txtTime.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(86, 178);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(108, 46);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Перевірити";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Location = new Point(12, 91);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(111, 20);
            lblDayOfWeek.TabIndex = 10;
            lblDayOfWeek.Text = "День прийому";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(12, 137);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(101, 20);
            lblStartTime.TabIndex = 11;
            lblStartTime.Text = "Час прийому";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 12;
            label1.Text = "Відомості про травматолога";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(330, 307);
            Controls.Add(label1);
            Controls.Add(lblStartTime);
            Controls.Add(lblDayOfWeek);
            Controls.Add(btnCheck);
            Controls.Add(txtTime);
            Controls.Add(comboDayOfWeek);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboDayOfWeek;
        private TextBox txtTime;
        private Button btnCheck;
        private Label lblDayOfWeek;
        private Label lblStartTime;
        private Label label1;
    }
}
