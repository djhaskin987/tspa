using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TSP
{
    public partial class mainform : Form
    {
        private ProblemAndSolver CityData;

        public mainform()
        {
            InitializeComponent();

            CityData = new ProblemAndSolver();
            this.tbSeed.Text = CityData.Seed.ToString();
        }

        /// <summary>
        /// overloaded to call the redraw method for CityData. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetClip(new Rectangle(0,0,this.Width, this.Height - this.toolStrip1.Height-35));
            CityData.Draw(e.Graphics);
        }

        private void SetSeed()
        {
            if (Regex.IsMatch(this.tbSeed.Text, "^[0-9]+$"))
            {
                this.toolStrip1.Focus();
                CityData = new ProblemAndSolver(int.Parse(this.tbSeed.Text));
                this.Invalidate();
            }
            else
                MessageBox.Show("Seed must be an integer.");
        }

        private HardMode.Modes getMode()
        {
            return HardMode.getMode(cboMode.Text);
        }

        private int getProblemSize()
        {
            if (Regex.IsMatch(this.tbProblemSize.Text, "^[0-9]+$"))
            {
                return Int32.Parse(this.tbProblemSize.Text);
            }
            else
            {
                MessageBox.Show("Problem size must be an integer.");
                return 20;
            };
        }

        // not necessarily a new problem but resets the state using the specified settings
        private void reset()
        {
            this.SetSeed(); // also resets the CityData variable

            int size = getProblemSize();
            HardMode.Modes mode = getMode();

            CityData.GenerateProblem ( size, mode );
        }


#region GUI Event Handlers

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void tbSeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.reset();
//                this.SetSeed();
        }

#endregion // Event Handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            // use the parameters in the GUI controls
            this.reset();
        }

        private void tbProblemSize_Leave(object sender, EventArgs e)
        {
            this.reset();
        }

        private void tbProblemSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.reset();
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reset();
        }

        private void newProblem_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.tbProblemSize.Text, "^[0-9]+$"))
            {
                Random random = new Random();
                int seed = int.Parse(tbSeed.Text);
                
                this.reset();
                
                this.Invalidate(); 
            }
            else
            {
                MessageBox.Show("Problem size must be an integer.");
            };
        }

        private void randomProblem_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.tbProblemSize.Text, "^[0-9]+$"))
            {
                Random random = new Random();
                int seed = random.Next(1000); // 3-digit random number
                this.tbSeed.Text = "" + seed;

                this.reset();

                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Problem size must be an integer.");
            };
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reset();

            CityData.solveProblem();
        }

        private void greedyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Add a hook into your own implementation here.
            throw new NotImplementedException();
        }

        private void bBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Add a hook into your own implementation here.
            throw new NotImplementedException();
        }

        private void randomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // TODO: Add a hook into your own implementation here.
            throw new NotImplementedException();
        }

        private void yourTSPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // TODO: Add a hook into your own implementation here.
            throw new NotImplementedException();
        }

        private void AlgorithmMenu2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AlgorithmMenu2.Text = e.ClickedItem.Text;
            AlgorithmMenu2.Tag = e.ClickedItem;
        }

        private void AlgorithmMenu2_ButtonClick_1(object sender, EventArgs e)
        {
            if (AlgorithmMenu2.Tag != null)
            {
                (AlgorithmMenu2.Tag as ToolStripMenuItem).PerformClick();
            }
            else
            {
                AlgorithmMenu2.ShowDropDown();
            }
        }
    }
}