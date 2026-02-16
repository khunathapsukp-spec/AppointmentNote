namespace AppointmentNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnAddClick(object? sender, EventArgs e)
        {
            // Validate AppointmentID and Subjectinput are not empty or whitespace
            if (string.IsNullOrWhiteSpace(AppointmentID.Text) || string.IsNullOrWhiteSpace(Subjectinput.Text))
            {
                MessageBox.Show("กรุณากรอก รหัสการนัดหมาย และ หัวข้อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // do not proceed to show summary or add
            }

            // Build Thai-labeled summary with AppointmentID, Subject, and Importance
            string importance = ImporTance.SelectedItem?.ToString() ?? "(ไม่ระบุ)";
            string summary = $"รหัสการนัด: {AppointmentID.Text}\nหัวข้อ: {Subjectinput.Text}\nความสำคัญ: {importance}";
            MessageBox.Show(summary, "สรุปการนัดหมาย", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
