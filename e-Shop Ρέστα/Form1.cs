using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_shop_change
{
    public partial class Form1 : Form
    {
        private int c500, c200, c100, c50, c20, c10, c5, c2, c1, c050, c020, c010, c005, c002, c001;
        private double sum, sum_m, sum_k;
        bool editOn = false;

        private void btn10_Click(object sender, EventArgs e)
        {
            c10 += 1;SetLabels();Calculate();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            c5 += 1;SetLabels();Calculate();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            c2 += 1;SetLabels();Calculate();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            c1 += 1;SetLabels();Calculate();
        }

        private void btn050c_Click(object sender, EventArgs e)
        {
            c050 += 1;SetLabels();Calculate();
        }

        private void btn020c_Click(object sender, EventArgs e)
        {
            c020 += 1;SetLabels();Calculate();
        }

        private void btn010c_Click(object sender, EventArgs e)
        {
            c010 += 1;SetLabels();Calculate();
        }

        private void btn005c_Click(object sender, EventArgs e)
        {
            c005 += 1;SetLabels();Calculate();
        }

        private void btn002c_Click(object sender, EventArgs e)
        {
            c002 += 1;SetLabels();Calculate();
        }

        private void btn001c_Click(object sender, EventArgs e)
        {
            c001 += 1;SetLabels();Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeNumbers();
            SetLabels();
            textBox2.Clear();
            textBox1.Clear();
            textBox3.BackColor = Color.Bisque;
            editOn = false;
        }

        private void btn500_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c500 -= 1; SetLabels(); Calculate();
        }

        private void btn200_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c200 -= 1; SetLabels(); Calculate();
        }

        private void btn100_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c100 -= 1; SetLabels(); Calculate();
        }

        private void btn50_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c50 -= 1; SetLabels(); Calculate();
        }

        private void btn20_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c20 -= 1; SetLabels(); Calculate();
        }

        private void btn10_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c10 -= 1; SetLabels(); Calculate();
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c5 -= 1; SetLabels(); Calculate();
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c2 -= 1; SetLabels(); Calculate();
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c1 -= 1; SetLabels(); Calculate();
        }

        private void btn050c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c050 -= 1; SetLabels(); Calculate();
        }

        private void btn020c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c020 -= 1; SetLabels(); Calculate();
        }

        private void btn010c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c010 -= 1; SetLabels(); Calculate();
        }

        private void btn005c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c005 -= 1; SetLabels(); Calculate();
        }

        private void btn002c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c002 -= 1; SetLabels(); Calculate();
        }

        private void btn001c_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) c001 -= 1; SetLabels(); Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string _value = textBox1.Text;
            if (textBox1.Text.Contains(","))
            {
                _value = _value.Replace(",", ".");
                textBox1.Text = _value;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                //MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                var cashlb = listView1.SelectedItems[0].SubItems[4].Text;
                c500 = Convert.ToInt32(cashlb.Substring(0, 1));
                c200 = Convert.ToInt32(cashlb.Substring(1, 1));
                c100 = Convert.ToInt32(cashlb.Substring(2, 1));
                c50 = Convert.ToInt32(cashlb.Substring(3, 1));
                c20 = Convert.ToInt32(cashlb.Substring(4, 1));
                c10 = Convert.ToInt32(cashlb.Substring(5, 1));
                c5 = Convert.ToInt32(cashlb.Substring(6, 1));
                c2 = Convert.ToInt32(cashlb.Substring(7, 1));
                c1 = Convert.ToInt32(cashlb.Substring(8, 1));
                c050 = Convert.ToInt32(cashlb.Substring(9, 1));
                c020 = Convert.ToInt32(cashlb.Substring(10, 1));
                c010 = Convert.ToInt32(cashlb.Substring(11, 1));
                c005 = Convert.ToInt32(cashlb.Substring(12, 1));
                c002 = Convert.ToInt32(cashlb.Substring(13, 1));
                c001 = Convert.ToInt32(cashlb.Substring(14, 1));
                SetLabels();
                sum_m -= Convert.ToDouble(listView1.SelectedItems[0].SubItems[1].Text);
                sum_k -= Convert.ToDouble(listView1.SelectedItems[0].SubItems[2].Text);
                editOn = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string _value = textBox2.Text;
            if (textBox2.Text.Contains(","))
            {
                _value = _value.Replace(",", ".");
                textBox2.Text = _value;
                textBox2.SelectionStart = textBox2.Text.Length;
                textBox2.SelectionLength = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Size = new Size(800, 600);
            }
            else
            {
                this.Size = new Size(400, 600);
            }
            Properties.Settings.Default.displayhistory = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            c20 += 1;SetLabels();Calculate();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            c50 += 1;SetLabels();Calculate();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            c100 += 1;SetLabels();Calculate();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            c200 += 1;SetLabels();Calculate();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            c500 += 1;SetLabels();Calculate();
        }

        public Form1()
        {
            InitializeComponent();
            InitializeNumbers();
            SetLabels();
            checkBox1.Checked = Properties.Settings.Default.displayhistory;
        }

        public void Calculate()
        {
            double u500 =  500  * c500;
            double u200 =  200  * c200;
            double u100 =  100  * c100;
            double u50  =  50   * c50;
            double u20  =  20   * c20;
            double u10  =  10   * c10;
            double u5   =  5    * c5;
            double u2   =  2    * c2;
            double u1   =  1    * c1;
            double u050 =  0.5  * c050;
            double u020 =  0.2  * c020;
            double u010 =  0.1  * c010;
            double u005 =  0.05 * c005;
            double u002 =  0.02 * c002;
            double u001 =  0.01 * c001;
            double sum = u500 + u200 + u100 + u50 + u20 + u10 + u5 + u2 + u1 + u050 + u020 + u010 + u005 + u002 + u001;
            textBox1.Text = sum.ToString();
            textBox2.Focus();
        }
        public void InitializeNumbers()
        {
            c500 = c200 = c100 = c50 = c20 = c10 = c5 = c2 = c1 = c050 = c020 = c010 = c005 = c002 = c001 = 0;
        }

        public void SetLabels()
        {
            lb001c.Text = c001.ToString();
            lb002c.Text = c002.ToString();
            lb005c.Text = c005.ToString();
            lb010c.Text = c010.ToString();
            lb020c.Text = c020.ToString();
            lb050c.Text = c050.ToString();
            lb1.Text = c1.ToString();
            lb2.Text = c2.ToString();
            lb5.Text = c5.ToString();
            lb10.Text = c10.ToString();
            lb20.Text = c20.ToString();
            lb50.Text = c50.ToString();
            lb100.Text = c100.ToString();
            lb200.Text = c200.ToString();
            lb500.Text = c500.ToString();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(textBox1, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl(textBox1, false, true, true, true);
            }
            else { return; }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(textBox2, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl(textBox2, false, true, true, true);
            }
            else { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1, value2, value3;
            string nowvar = DateTime.Now.ToString("T");
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]*$") || System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z ]*$"))
                {
                    MessageBox.Show("You may only enter numbers", "Error");
                    textBox1.Text = ""; textBox2.Text = ""; textBox1.Focus();
                    return;
                }
                else { 
                    value1 = double.Parse(textBox1.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
                    value2 = double.Parse(textBox2.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
                    value3 = value1 - value2;
                    if (value3 < 0)
                    {
                        MessageBox.Show($"Προσοχή ο πελάτης σας έδωσε λιγότερα χρήματα πρέπει να σας δώσει ακόμα {Math.Abs(value3)} ευρώ", $"ΠΡΟΣΟΧΗ!!! Λείπουν {Math.Abs(value3)} ευρώ!!!");
                        textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox3.BackColor = Color.GreenYellow;
                        //listBox1.Items.Add("[" + nowvar + "]M:" + value1 + " - K:" + value2 + " = " + Math.Round(value3, 2));
                        var cashlb = $"{lb500.Text}{lb200.Text}{lb100.Text}{lb50.Text}{lb20.Text}{lb10.Text}{lb5.Text}{lb2.Text}{lb1.Text}{lb050c.Text}{lb020c.Text}{lb010c.Text}{lb005c.Text}{lb002c.Text}{lb001c.Text}";
                        if (editOn == false)
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { nowvar, value1.ToString(), value2.ToString(), Math.Round(value3, 2).ToString(), cashlb }));
                        }
                        else
                        {
                            listView1.SelectedItems[0].SubItems[1].Text = textBox1.Text;
                            listView1.SelectedItems[0].SubItems[2].Text = textBox2.Text;
                            listView1.SelectedItems[0].SubItems[3].Text = Math.Round(value3, 2).ToString();
                            listView1.SelectedItems[0].SubItems[4].Text = cashlb;
                            listView1.SelectedIndices.Clear();
                            editOn = false;
                        }
                        sum_m += Math.Round(value1, 2);
                        sum_k += Math.Round(value2, 2);
                        SetCalcLabels();
                    }
                    textBox3.Text = Math.Round(value3, 2).ToString();
                }

            }
            if (textBox3.Text != "") { textBox1.Text = ""; textBox2.Text = ""; textBox1.Focus(); }
            else { MessageBox.Show("Wrong Input"); }
            InitializeNumbers();
            SetLabels();
        }
        private void SetCalcLabels()
        {

            sum = sum_m - sum_k;
            sumofall.Text = sum_k.ToString();
            sumcash.Text = sum_m.ToString();
            sumit.Text = Math.Round(sum,2).ToString();
        }

    }
}
