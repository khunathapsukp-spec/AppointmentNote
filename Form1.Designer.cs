namespace AppointmentNote
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            AppointmentID = new TextBox();
            label2 = new Label();
            Subjectinput = new TextBox();
            label3 = new Label();
            ImporTance = new ComboBox();
            label4 = new Label();
            Status = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 20F);
            label1.Location = new Point(50, 63);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "รหัสนัดหมาย";
            // 
            // AppointmentID
            // 
            AppointmentID.Location = new Point(285, 78);
            AppointmentID.Name = "AppointmentID";
            AppointmentID.Size = new Size(195, 23);
            AppointmentID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 20F);
            label2.Location = new Point(50, 106);
            label2.Name = "label2";
            label2.Size = new Size(203, 37);
            label2.TabIndex = 2;
            label2.Text = "หัวข้อการนัดหมาย";
            // 
            // Subjectinput
            // 
            Subjectinput.Location = new Point(285, 120);
            Subjectinput.Name = "Subjectinput";
            Subjectinput.Size = new Size(195, 23);
            Subjectinput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 20F);
            label3.Location = new Point(50, 148);
            label3.Name = "label3";
            label3.Size = new Size(137, 37);
            label3.TabIndex = 5;
            label3.Text = "ความสำคัญ";
            // 
            // ImporTance
            // 
            ImporTance.FormattingEnabled = true;
            ImporTance.Items.AddRange(new object[] { "Low", "Medium", "High" });
            ImporTance.Location = new Point(285, 162);
            ImporTance.Name = "ImporTance";
            ImporTance.Size = new Size(195, 23);
            ImporTance.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 20F);
            label4.Location = new Point(50, 189);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 7;
            label4.Text = "สภานะ";
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "Planned", "Confirmed", "Completed" });
            Status.Location = new Point(285, 203);
            Status.Name = "Status";
            Status.Size = new Size(195, 23);
            Status.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Leelawadee UI", 20F);
            button1.Location = new Point(523, 78);
            button1.Name = "button1";
            button1.Size = new Size(93, 51);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAddClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(727, 290);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Leelawadee UI", 20F);
            button2.Location = new Point(523, 148);
            button2.Name = "button2";
            button2.Size = new Size(93, 51);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Leelawadee UI", 20F);
            button3.Location = new Point(657, 78);
            button3.Name = "button3";
            button3.Size = new Size(93, 51);
            button3.TabIndex = 12;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnAddClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(Status);
            Controls.Add(label4);
            Controls.Add(ImporTance);
            Controls.Add(label3);
            Controls.Add(Subjectinput);
            Controls.Add(label2);
            Controls.Add(AppointmentID);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AppointmentID;
        private Label label2;
        private TextBox Subjectinput;
        private Label label3;
        private ComboBox ImporTance;
        private Label label4;
        private ComboBox Status;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}
