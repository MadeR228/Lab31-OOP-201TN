using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeProcessList();
        }

        private void InitializeProcessList()
        {
            listViewProcesses.View = View.Details;
            listViewProcesses.Columns.Add("ID", 70);
            listViewProcesses.Columns.Add("Name", 150);

            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            listViewProcesses.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
                listViewProcesses.Items.Add(new ListViewItem(new string[] { process.Id.ToString(), process.ProcessName }));
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProcesses.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[0].Text);

                Process process = Process.GetProcessById(processId);
                MessageBox.Show($"ID процесу: {process.Id}\nНазва: {process.ProcessName}\nВіртуальна пам'ять: {process.VirtualMemorySize64} bytes");
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProcesses.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[0].Text);

                Process process = Process.GetProcessById(processId);
                process.Kill();
                RefreshProcessList();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("F:\\Projects\\WinFormsApp6\\WinFormsApp6\\process_list.txt"))
            {
                foreach (ListViewItem item in listViewProcesses.Items)
                {
                    writer.WriteLine($"ID: {item.SubItems[0].Text}, Name: {item.SubItems[1].Text}");
                }
            }
            MessageBox.Show("Список процесів експортовано в process_list.txt");
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RefreshProcessList();
        }
    }
}
