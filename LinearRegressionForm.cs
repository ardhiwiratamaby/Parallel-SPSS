using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelSPSS
{
    public partial class LinearRegressionForm : Form
    {
        public LinearRegressionForm()
        {
            InitializeComponent();
        }

        private void LinearRegressionForm_Load(object sender, EventArgs e)
        {
            int y;
            for (int i = 0; i < Data.variableView.Count; i++)
            {
                y = i + 1;
                if (Data.variableView[i].nama != null && Data.variableView[i].nama != "VAR00" + y)
                    listBox1.Items.Add(Data.variableView[i].label);
            }

            for (int j = 0; j < Data.columnChoosen.Length; j++)
                Data.columnChoosen[j] = -1;
        }
        bool flag = true;
        bool flag2 = true;
        int order=0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && flag)
            {
                order = listBox1.SelectedIndex;
                dependentLabel.Text = listBox1.SelectedItem.ToString();
                dependentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.leftArrow;
                listBox1.Items.Remove(listBox1.SelectedItem);
                flag = false;
            }

            else if(dependentLabel.Text!=null && dependentLabel.Text!="" && !flag )
            {
                listBox1.Items.Insert(order, dependentLabel.Text);
                dependentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
                dependentLabel.Text = "";
                flag = true;
            }
        }

        private void independentButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1 && flag2)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                flag2 = false;
            }
            else if(listBox2.SelectedIndex!=-1 && !flag2)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
                flag2 = true;
            }
        }

        void listBox1_GotFocus(object sender, System.EventArgs e)
        {
            independentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
            if (listBox1.SelectedIndex != -1)
            {
                flag2 = true;
                listBox2.SelectedIndex = -1;
            }
        }

       void listBox2_GotFocus(object sender, System.EventArgs e)
        {
            independentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.leftArrow;
            if (listBox2.SelectedIndex != -1)
            {
                flag2 = false;
                listBox1.SelectedIndex = -1;
            } 

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            independentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.leftArrow;
            if (listBox2.SelectedIndex != -1)
            {
                flag2 = false;
                listBox1.SelectedIndex = -1;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // independentButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listBox2.Items.Count;i++)
            {
                for (int j = 0; j < Data.variableView.Count; j++)
                {
                   
                    if (Data.variableView[j].nama == listBox2.Items[i].ToString())
                        Data.columnChoosen[1] = j;
                }
            }

            for (int j = 0; j < Data.variableView.Count; j++)
            {
                if (Data.variableView[j].nama == dependentLabel.Text)
                    Data.columnChoosen[0] = j;
            }
        }
    }
}
