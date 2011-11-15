namespace TSP
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbProblemSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cboMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbCostOfTour = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tbElapsedTime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.AlgorithmMenu2 = new System.Windows.Forms.ToolStripSplitButton();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourTSPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greedyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProblem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbSeed = new System.Windows.Forms.ToolStripTextBox();
            this.randomProblem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbProblemSize,
            this.toolStripSeparator5,
            this.cboMode,
            this.toolStripSeparator6,
            this.toolStripLabel3,
            this.tbCostOfTour,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.tbElapsedTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 587);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel2.Text = "Problem Size";
            // 
            // tbProblemSize
            // 
            this.tbProblemSize.Name = "tbProblemSize";
            this.tbProblemSize.Size = new System.Drawing.Size(50, 25);
            this.tbProblemSize.Text = "20";
            this.tbProblemSize.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbProblemSize.Leave += new System.EventHandler(this.tbProblemSize_Leave);
            this.tbProblemSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProblemSize_KeyDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // cboMode
            // 
            this.cboMode.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(75, 25);
            this.cboMode.Text = "Hard";
            this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel3.Text = "Cost of tour";
            // 
            // tbCostOfTour
            // 
            this.tbCostOfTour.Enabled = false;
            this.tbCostOfTour.Name = "tbCostOfTour";
            this.tbCostOfTour.Size = new System.Drawing.Size(100, 25);
            this.tbCostOfTour.Text = "--";
            this.tbCostOfTour.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel4.Text = "Solved in ";
            // 
            // tbElapsedTime
            // 
            this.tbElapsedTime.Enabled = false;
            this.tbElapsedTime.Name = "tbElapsedTime";
            this.tbElapsedTime.Size = new System.Drawing.Size(100, 25);
            this.tbElapsedTime.Text = "--";
            this.tbElapsedTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlgorithmMenu2,
            this.newProblem,
            this.toolStripLabel1,
            this.tbSeed,
            this.randomProblem,
            this.toolStripSeparator1,
            this.toolStripLabel5,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 562);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(634, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // AlgorithmMenu2
            // 
            this.AlgorithmMenu2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlgorithmMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.yourTSPToolStripMenuItem1,
            this.randomToolStripMenuItem1,
            this.bBToolStripMenuItem,
            this.greedyToolStripMenuItem});
            this.AlgorithmMenu2.Image = ((System.Drawing.Image)(resources.GetObject("AlgorithmMenu2.Image")));
            this.AlgorithmMenu2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlgorithmMenu2.Name = "AlgorithmMenu2";
            this.AlgorithmMenu2.Size = new System.Drawing.Size(77, 22);
            this.AlgorithmMenu2.Text = "Algorithm";
            this.AlgorithmMenu2.ButtonClick += new System.EventHandler(this.AlgorithmMenu2_ButtonClick_1);
            this.AlgorithmMenu2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AlgorithmMenu2_DropDownItemClicked);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.dToolStripMenuItem.Text = "Default";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // yourTSPToolStripMenuItem1
            // 
            this.yourTSPToolStripMenuItem1.Name = "yourTSPToolStripMenuItem1";
            this.yourTSPToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.yourTSPToolStripMenuItem1.Text = "Your TSP";
            this.yourTSPToolStripMenuItem1.Click += new System.EventHandler(this.yourTSPToolStripMenuItem1_Click);
            // 
            // randomToolStripMenuItem1
            // 
            this.randomToolStripMenuItem1.Name = "randomToolStripMenuItem1";
            this.randomToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.randomToolStripMenuItem1.Text = "Random";
            this.randomToolStripMenuItem1.Click += new System.EventHandler(this.randomToolStripMenuItem1_Click);
            // 
            // bBToolStripMenuItem
            // 
            this.bBToolStripMenuItem.Name = "bBToolStripMenuItem";
            this.bBToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.bBToolStripMenuItem.Text = "B and B";
            this.bBToolStripMenuItem.Click += new System.EventHandler(this.bBToolStripMenuItem_Click);
            // 
            // greedyToolStripMenuItem
            // 
            this.greedyToolStripMenuItem.Name = "greedyToolStripMenuItem";
            this.greedyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.greedyToolStripMenuItem.Text = "Greedy";
            this.greedyToolStripMenuItem.Click += new System.EventHandler(this.greedyToolStripMenuItem_Click);
            // 
            // newProblem
            // 
            this.newProblem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newProblem.Image = ((System.Drawing.Image)(resources.GetObject("newProblem.Image")));
            this.newProblem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newProblem.Name = "newProblem";
            this.newProblem.Size = new System.Drawing.Size(83, 22);
            this.newProblem.Text = "New Problem";
            this.newProblem.Click += new System.EventHandler(this.newProblem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Seed";
            // 
            // tbSeed
            // 
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.Size = new System.Drawing.Size(100, 25);
            // 
            // randomProblem
            // 
            this.randomProblem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.randomProblem.Image = ((System.Drawing.Image)(resources.GetObject("randomProblem.Image")));
            this.randomProblem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.randomProblem.Name = "randomProblem";
            this.randomProblem.Size = new System.Drawing.Size(104, 22);
            this.randomProblem.Text = "Random Problem";
            this.randomProblem.Click += new System.EventHandler(this.randomProblem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel5.Text = "Solution #";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(15, 25);
            this.toolStripTextBox1.Text = "--";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 612);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainform";
            this.Text = "Traveling Sales Person";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbProblemSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripTextBox tbCostOfTour;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        public System.Windows.Forms.ToolStripTextBox tbElapsedTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox cboMode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newProblem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbSeed;
        private System.Windows.Forms.ToolStripButton randomProblem;
        private System.Windows.Forms.ToolStripSplitButton AlgorithmMenu2;
        private System.Windows.Forms.ToolStripMenuItem yourTSPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greedyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;



    }
}

