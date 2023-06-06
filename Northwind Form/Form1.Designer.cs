namespace Northwind_Form
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
            productsGV = new DataGridView();
            menuStrip1 = new MenuStrip();
            manageMenu = new ToolStripMenuItem();
            loadOption = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveOption = new ToolStripMenuItem();
            deleteFirstToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)productsGV).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // productsGV
            // 
            productsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGV.Dock = DockStyle.Fill;
            productsGV.Location = new Point(0, 24);
            productsGV.Name = "productsGV";
            productsGV.RowTemplate.Height = 25;
            productsGV.Size = new Size(800, 426);
            productsGV.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageMenu
            // 
            manageMenu.DropDownItems.AddRange(new ToolStripItem[] { loadOption, toolStripSeparator1, saveOption, deleteFirstToolStripMenuItem });
            manageMenu.Name = "manageMenu";
            manageMenu.Size = new Size(62, 20);
            manageMenu.Text = "Manage";
            // 
            // loadOption
            // 
            loadOption.Name = "loadOption";
            loadOption.Size = new Size(180, 22);
            loadOption.Text = "Load";
            loadOption.Click += loadOption_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // saveOption
            // 
            saveOption.Name = "saveOption";
            saveOption.Size = new Size(180, 22);
            saveOption.Text = "Save";
            // 
            // deleteFirstToolStripMenuItem
            // 
            deleteFirstToolStripMenuItem.Name = "deleteFirstToolStripMenuItem";
            deleteFirstToolStripMenuItem.Size = new Size(180, 22);
            deleteFirstToolStripMenuItem.Text = "Delete First";
            deleteFirstToolStripMenuItem.Click += deleteFirstToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productsGV);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)productsGV).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsGV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem loadOption;
        private ToolStripMenuItem saveOption;
        private ToolStripMenuItem deleteFirstToolStripMenuItem;
    }
}