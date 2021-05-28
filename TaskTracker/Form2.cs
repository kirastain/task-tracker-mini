using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class NewTask : Form
    {
        public NewTask(bool DarkMode)
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(i);
            }

            if (DarkMode == true)
            {
                TurnDarkModeOn();
            }
            else
            {
                TurnDarkModeOff();
            }
        }

        private void TurnDarkModeOn()
        {
            this.BackColor = Color.FromArgb(56, 2, 59);
            saveTaskButton.BackColor = Color.FromArgb(91, 133, 170);
            saveTaskButton.ForeColor = Color.White;
            saveTaskButton.TabStop = false;
            saveTaskButton.FlatStyle = FlatStyle.Flat;
            saveTaskButton.FlatAppearance.BorderSize = 0;
            saveTaskButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = Color.White;
            taskName.BackColor = Color.FromArgb(91, 133, 170);
            taskName.ForeColor = Color.White;
            taskName.BorderStyle = BorderStyle.None;
            label1.ForeColor = Color.White;
        }

        private void TurnDarkModeOff()
        {
            this.BackColor = Color.LightGray;
            saveTaskButton.BackColor = Color.FromArgb(91, 133, 170);
            saveTaskButton.ForeColor = Color.White;
            saveTaskButton.TabStop = false;
            saveTaskButton.FlatStyle = FlatStyle.Flat;
            saveTaskButton.FlatAppearance.BorderSize = 0;
            saveTaskButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = Color.FromArgb(56, 2, 59);
            taskName.BackColor = Color.FromArgb(91, 133, 170);
            taskName.ForeColor = Color.White;
            taskName.BorderStyle = BorderStyle.None;
        }

        private void taskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskName.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Show();
            }
            else
            {
                int priority = 0;
                if (comboBox1.SelectedItem != null)
                {
                    priority = int.Parse(comboBox1.SelectedItem.ToString());
                }
                var task = new Task(taskName.Text, priority);
                MainForm.AddTaskToList(task);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
