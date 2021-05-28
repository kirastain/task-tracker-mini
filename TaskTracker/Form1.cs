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
    public partial class MainForm : Form
    {
        private static List<Task> Tasks;
        private static bool DarkMode = false;

        public static void AddTaskToList(Task task)
        {
            Tasks.Add(task);
        }

        public void updateListBox()
        {
            listView1.Items.Clear();
            foreach (Task task in Tasks)
            {
                string[] listRow = new string[2];
                listRow[0] = task.getName();
                listRow[1] = task.ifDone();
                listView1.Items.Add(new ListViewItem(listRow));
                if (task.ifDone() == "done")
                {
                    int i = listView1.Items.Count;
                    listView1.Items[i - 1].BackColor = Color.FromArgb(204, 255, 203);
                    listView1.Items[i - 1].ForeColor = Color.FromArgb(56, 2, 59);
                }
                else if (task.getPriority() > 0)
                {
                    int i = listView1.Items.Count;
                    listView1.Items[i - 1].BackColor = Color.FromArgb(task.getPriority() * 50, 0, 0);
                }
            }
        }

        public MainForm()
        {
            Tasks = new List<Task>();
            InitializeComponent();
            TurnDarkModeOff();
            label3.Text = Tasks.Count.ToString();
            listView1.View = View.Details;
            listView1.Columns.Add("Task", 200);
            listView1.Columns.Add("Status", 110);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTask(DarkMode);
            newTaskForm.ShowDialog();
            label3.Text = Tasks.Count.ToString();
            updateListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            var indeces = listView1.SelectedIndices;
            foreach (int i in indeces)
            {
                Tasks[i].taskDone();
            }
            updateListBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var indeces = listView1.SelectedIndices;
            foreach (int i in indeces)
            {
                Tasks.RemoveAt(i);
            }
            updateListBox();
            label3.Text = Tasks.Count.ToString();
        }

        private void TurnDarkModeOn()
        {
            this.BackColor = Color.FromArgb(56, 2, 59);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            listView1.BackColor = Color.FromArgb(91, 133, 170);
        }

        private void TurnDarkModeOff()
        {
            this.BackColor = Color.LightGray;
            button1.BackColor = Color.FromArgb(91, 133, 170);
            button1.ForeColor = Color.White;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            addTaskButton.BackColor = Color.FromArgb(91, 133, 170);
            addTaskButton.ForeColor = Color.White;
            addTaskButton.TabStop = false;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            deleteButton.BackColor = Color.FromArgb(91, 133, 170);
            deleteButton.ForeColor = Color.White;
            deleteButton.TabStop = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            finishButton.BackColor = Color.FromArgb(91, 133, 170);
            finishButton.ForeColor = Color.White;
            finishButton.TabStop = false;
            finishButton.FlatStyle = FlatStyle.Flat;
            finishButton.FlatAppearance.BorderSize = 0;
            finishButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = Color.FromArgb(56, 2, 59);
            label2.ForeColor = Color.FromArgb(56, 2, 59);
            label3.ForeColor = Color.FromArgb(56, 2, 59);
            listView1.BackColor = Color.FromArgb(91, 133, 170);
            listView1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DarkMode == false)
            {
                TurnDarkModeOn();
                DarkMode = true;
                label1.Text = "On";
            }
            else
            {
                TurnDarkModeOff();
                DarkMode = false;
                label1.Text = "Off";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
