using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Mechanic_Maestro
{
    public partial class MechanicMaestro : Form
    {
        private string filenm = "";

        public MechanicMaestro()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MechanicMaestro_FormClosing);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Robert Hurley" + Environment.NewLine + "Wrench Wizard Version 1.0.0" + Environment.NewLine + "March 28, 2024", "About");
        }

        private void MechanicMaestro_Load(object sender, EventArgs e)
        {
            pbxCorvette.Visible = false;
        }
        private void ResetFormFields()
        {
            filenm = string.Empty;
            tbxName.Clear();
            tbxMake.Clear();
            tbxModel.Clear();
            tbxColor.Clear();
            tbxCustomOpt.Clear();
            lbxItems.Items.Clear();
            tbxAmountFinance.Clear();
            tbxMonthFinance.Clear();
            lbxFinance.Items.Clear();
            cbxServiceLvl.SelectedIndex = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbxCustomOpt.Text) == true)
            {
                lbxItems.Items.Add(tbxCustomOpt.Text);
                tbxCustomOpt.Clear();
                tbxCustomOpt.Focus();
                e.Handled = true;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Creating a new customer file will lose any unsaved data. Are you sure" +
                    " that you want to create a new customer file?", "New List?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (yOrN == DialogResult.Yes)
            {
                ResetFormFields();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yOrN, openOrCancel;
            

            try
            {
                yOrN = MessageBox.Show("Opening a file will lose any unsaved data. Are you sure" +
                    " that you want to open a file?", "Open File?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (yOrN == DialogResult.Yes)
                {
                    openOrCancel = openFileDialog1.ShowDialog();
                    if (openOrCancel == DialogResult.OK)
                    {
                        ResetFormFields();
                        filenm = openFileDialog1.FileName;
                        
                        using (StreamReader opener = new StreamReader(filenm, false))
                        {

                            string line;
                            
                            while ((line = opener.ReadLine()) != null)
                            {
                                switch (line)
                                {
                                    case"CustomerDetails":
                                        tbxName.Text = opener.ReadLine();
                                        tbxMake.Text = opener.ReadLine();
                                        tbxModel.Text = opener.ReadLine();
                                        tbxColor.Text = opener.ReadLine();
                                        dateTimePicker1.Value = DateTime.Parse(opener.ReadLine());
                                        break;
                                    case"ServiceLevel":
                                        cbxServiceLvl.SelectedIndexChanged -= cbxServiceLvl_SelectedIndexChanged;
                                        if (int.TryParse(opener.ReadLine(), out int serviceLevelIndex) &&
                                            serviceLevelIndex >= 0 && serviceLevelIndex < cbxServiceLvl.Items.Count)
                                        {
                                            cbxServiceLvl.SelectedIndex = serviceLevelIndex;
                                        }
                                        else
                                        {
                                            cbxServiceLvl.SelectedIndex = 0;
                                        }
                                        cbxServiceLvl.SelectedIndexChanged += cbxServiceLvl_SelectedIndexChanged;
                                        break;
                                    case"CustomOption":
                                        tbxCustomOpt.Text = opener.ReadLine();
                                        break;
                                    case"Items":
                                        while ((line = opener.ReadLine()) != null)
                                        {
                                            if (line == "FinancingDetails" || line == "EndOfFile")
                                            {
                                                break;
                                            }
                                            if (!string.IsNullOrEmpty(line))
                                            {
                                                lbxItems.Items.Add(line);
                                            }
                                        }
                                        break;
                                    case"FinancingDetails":
                                        tbxAmountFinance.Text = opener.ReadLine();
                                        tbxMonthFinance.Text = opener.ReadLine();
                                        break;
                                    case"FinanceCalculations":
                                        while ((line = opener.ReadLine()) != null && line != "EndOfFile")
                                        {
                                            lbxFinance.Items.Add(line);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error while opening the file: " + ex.Message, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFormData(StreamWriter saver)
        {
            // Save the customer details
            saver.WriteLine("CustomerDetails");
            saver.WriteLine(tbxName.Text);
            saver.WriteLine(tbxMake.Text);
            saver.WriteLine(tbxModel.Text);
            saver.WriteLine(tbxColor.Text);
            saver.WriteLine(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            // Save the selected service level
            saver.WriteLine("ServiceLevel");
            saver.WriteLine(cbxServiceLvl.SelectedIndex.ToString(""));

            //Save the Custom Options
            saver.WriteLine("CustomOption");
            saver.WriteLine(tbxCustomOpt.Text);

            // Save the items
            saver.WriteLine("Items");
            foreach (var item in lbxItems.Items)
            {
                saver.WriteLine(item.ToString());
            }

            // Save the financing details
            saver.WriteLine("FinancingDetails");
            saver.WriteLine(tbxAmountFinance.Text);
            saver.WriteLine(tbxMonthFinance.Text);

            // Save the finance calculations
            saver.WriteLine("FinanceCalculations");
            foreach (var financeItem in lbxFinance.Items)
            {
                saver.WriteLine(financeItem.ToString());
            }
            saver.WriteLine("EndOfFile");
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filenm))
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    return;
                }
                using (StreamWriter saver = new StreamWriter(filenm))
                {
                    SaveFormData(saver);
                }
            }
            catch
            {
                MessageBox.Show("There was an error. Data not saved.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveOrCancel;
            try
            {
                saveOrCancel = saveFileDialog1.ShowDialog();
                if (saveOrCancel == DialogResult.OK)
                {
                    filenm = saveFileDialog1.FileName;
                    using (StreamWriter saver = new StreamWriter(filenm))
                    {
                        SaveFormData(saver);
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error. Data not saved.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e, CancelEventHandler et)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Unsaved Changes will be lost. Are you sure you want to Exit?",
                                   "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button2);

            if (yOrN == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void windowColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.Controls.OfType<Label>().FirstOrDefault()?.ForeColor ?? Color.Black;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Control ctrl in this.Controls)

                    if (ctrl is Label label)
                    {
                        label.ForeColor = colorDialog1.Color;
                    }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Font = fontDialog1.Font;
                }
            }
        }

        private void cbxServiceLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxItems.Items.Clear();
            string[] noneServices = { };
            string[] basicServices =
                { "Rotate and inspect tires", "Multi-point vehicle inspection","Tire pressure check","Chassis lubrication as necessary",
                "Visual brake inspection","Air filter inspection","Wiper blades inspection", "Exterior lights inspection",
                "Inspect steering, suspension, & drive train","Visual inspection of all belts & hoses"
                };
            string[] bronzeServices =
                { "Rotate and inspect tires", "Multi-point vehicle inspection", "Tire pressure check","Chassis lubrication as necessary",
                "Visual brake inspection","Air filter inspection","Wiper blades inspection", "Exterior lights inspection",
                "Inspect steering, suspension, & drive train","Visual inspection of all belts & hoses","3-step fuel system service",
                "40-point inspection", "Inspect all fluids"
                };
            string[] silverServices =
                { "Rotate and inspect tires", "Multi-point vehicle inspection", "Tire pressure check","Chassis lubrication as necessary",
                "Visual brake inspection","Air filter inspection","Wiper blades inspection", "Exterior lights inspection",
                "Inspect steering, suspension, & drive train","Visual inspection of all belts & hoses","3-step fuel system service",
                "40-point inspection", "Inspect all fluids","Complete coolant exchange"
                };
            string[] goldServices =
                { "Rotate and inspect tires", "Multi-point vehicle inspection", "Tire pressure check", "Chassis lubrication as necessary",
                "Visual brake inspection","Air filter inspection","Wiper blades inspection", "Exterior lights inspection",
                "Inspect steering, suspension, & drive train","Visual inspection of all belts & hoses","3-step fuel system service",
                "40-point inspection", "Inspect all fluids","Complete coolant exchange","Complete transmission fluid exchange"
                };

            switch (cbxServiceLvl.SelectedIndex)
            {
                case 0: // None
                        // Do nothing
                    break;
                case 1: // Basic
                    lbxItems.Items.AddRange(basicServices);
                    break;
                case 2: // Bronze
                    lbxItems.Items.AddRange(bronzeServices);
                    break;
                case 3: // Silver
                    lbxItems.Items.AddRange(silverServices);
                    break;
                case 4: // Gold
                    lbxItems.Items.AddRange(goldServices);
                    break;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxCustomOpt.Text))
            {
                lbxItems.Items.Add(tbxCustomOpt.Text);
                tbxCustomOpt.Clear();
                tbxCustomOpt.Focus();
            }
        }

        private void buttonAddItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbxCustomOpt.Text))
            {
                lbxItems.Items.Add(tbxCustomOpt.Text);
                tbxCustomOpt.Clear();
                tbxCustomOpt.Focus();
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedIndex != -1)
            {
                lbxItems.Items.RemoveAt(lbxItems.SelectedIndex);
            }
        }

        //Finance Section

        private const decimal InterestRate = 0.05m;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            lbxFinance.Items.Clear();

            if (!decimal.TryParse(tbxAmountFinance.Text, out decimal principal))
            {
                MessageBox.Show("Please enter a valid dollar amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbxMonthFinance.Text, out int months) || months <= 0)
            {
                MessageBox.Show("Please enter a valid number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal balance = principal;
            for (int month = 1; month <= months; month++)
            {
                balance *= 1 + InterestRate; // Apply interest to the balance
                lbxFinance.Items.Add($"Month {month}: {balance:C2}");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Do you really want to clear the entire form?",
                    "Remove Everything?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            if (yOrN == DialogResult.Yes)
            {
                ResetFormFields();
            }
            else
            {
                //Do Nothing
            }
       
        }

        private void corvetteOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Corvette Picture
            pbxCorvette.Visible = corvetteOnOffToolStripMenuItem.Checked;
        }

        private void MechanicMaestro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Unsaved Changes will be lost. Are you sure you want to Exit?",
                                   "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button2);

            if (yOrN == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MechanicMaestro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}   
