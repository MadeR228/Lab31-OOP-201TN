
namespace WinFormsApp6
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
            components = new System.ComponentModel.Container();
            listViewProcesses = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            killToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewProcesses
            // 
            listViewProcesses.ContextMenuStrip = contextMenuStrip1;
            listViewProcesses.Location = new Point(12, 12);
            listViewProcesses.Name = "listViewProcesses";
            listViewProcesses.Size = new Size(260, 201);
            listViewProcesses.TabIndex = 0;
            listViewProcesses.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, killToolStripMenuItem, toolStripMenuItem1, refreshToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 92);
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(127, 22);
            infoToolStripMenuItem.Text = "Інфо";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new Size(127, 22);
            killToolStripMenuItem.Text = "Зупинити";
            killToolStripMenuItem.Click += killToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(127, 22);
            toolStripMenuItem1.Text = "Експорт";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(127, 22);
            refreshToolStripMenuItem.Text = "Оновити";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 240);
            Controls.Add(listViewProcesses);
            Name = "Form1";
            Text = "Габор 201-ТН";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void listViewProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListView listViewProcesses;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem killToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}
