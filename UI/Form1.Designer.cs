namespace UI
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            orderByToolStripMenuItem = new ToolStripMenuItem();
            priceToolStripMenuItem = new ToolStripMenuItem();
            quantityToolStripMenuItem = new ToolStripMenuItem();
            availableToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem, orderByToolStripMenuItem, availableToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(77, 24);
            toolStripMenuItem1.Text = "Manage";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(224, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click_1;
            // 
            // orderByToolStripMenuItem
            // 
            orderByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { priceToolStripMenuItem, quantityToolStripMenuItem });
            orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            orderByToolStripMenuItem.Size = new Size(224, 26);
            orderByToolStripMenuItem.Text = "Order By";
            orderByToolStripMenuItem.Click += orderByToolStripMenuItem_Click;
            // 
            // priceToolStripMenuItem
            // 
            priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            priceToolStripMenuItem.Size = new Size(224, 26);
            priceToolStripMenuItem.Text = "Price";
            priceToolStripMenuItem.Click += priceToolStripMenuItem_Click;
            // 
            // quantityToolStripMenuItem
            // 
            quantityToolStripMenuItem.Name = "quantityToolStripMenuItem";
            quantityToolStripMenuItem.Size = new Size(224, 26);
            quantityToolStripMenuItem.Text = "Quantity";
            quantityToolStripMenuItem.Click += quantityToolStripMenuItem_Click;
            // 
            // availableToolStripMenuItem
            // 
            availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            availableToolStripMenuItem.Size = new Size(224, 26);
            availableToolStripMenuItem.Text = "Available";
            availableToolStripMenuItem.Click += availableToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem orderByToolStripMenuItem;
        private ToolStripMenuItem priceToolStripMenuItem;
        private ToolStripMenuItem quantityToolStripMenuItem;
        private ToolStripMenuItem availableToolStripMenuItem;
    }
}
