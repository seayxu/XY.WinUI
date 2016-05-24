using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XY.WINUI.ControlEx.InvokeEx.Test
{
    using System.Threading;

    public partial class MainTest : Form
    {
        private Thread thread;
        public MainTest()
        {
            InitializeComponent();
        }

        #region //TextBox
        private void btnGetTextbox_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getTextBox));
            thread.Start();
        }

        private void getTextBox()
        {
            MessageBox.Show(Invokes.GetTextBoxText(textBox1));
        }

        private void setTextBox()
        {
            Invokes.SetTextBoxText(textBox1, textBox2.Text);
        }

        private void btnSetTextbox_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(setTextBox));
            thread.Start();
        } 
        #endregion

        #region //Label
        private void btnGetLabel_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getLabel));
            thread.Start();
        }
        private void getLabel()
        {
            MessageBox.Show(Invokes.GetLabelText(label1));
        }

        private void setLabel()
        {
            Invokes.SetLabelText(label1, textBox3.Text);
        }
        private void btnSetLabel_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(setLabel));
            thread.Start();
        } 
        #endregion

        #region //CheckBox
        private void btnGetCheckBox_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getCheckBox));
            thread.Start();
        }
        private void getCheckBox()
        {
            MessageBox.Show(Invokes.GetCheckBoxChecked(checkBox1).ToString());
        }

        private void setCheckBox()
        {
            Invokes.SetCheckBoxChecked(checkBox1, !Invokes.GetCheckBoxChecked(checkBox1));
        }
        private void btnSetCheckBox_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(setCheckBox));
            thread.Start();
        } 
        #endregion

        #region //Radiobutton
        private void btnGetRadioButton_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getRadioButton));
            thread.Start();
        }
        private void getRadioButton()
        {
            MessageBox.Show(Invokes.GetRadioButtonChecked(radioButton1).ToString());
        }

        private void setRadioButton()
        {
            Invokes.SetRadioButtonChecked(radioButton1, !Invokes.GetRadioButtonChecked(radioButton1));
        }
        private void btnSetRadioButton_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(setRadioButton));
            thread.Start();
        } 
        #endregion

        #region //ProgressBar
        private void btnGetProgressBar_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(getProgressBar));
            thread.Start();

        }
        private void getProgressBar()
        {
            MessageBox.Show(Invokes.GetProgressBarValue(progressBar1).ToString());
        }

        private void setProgressBar()
        {
            if (!string.IsNullOrEmpty(this.textBox4.Text))
            {
                if (int.Parse(Invokes.GetTextBoxText(textBox4).ToString()) > 100 || int.Parse(Invokes.GetTextBoxText(textBox4).ToString()) < 0)
                {
                    MessageBox.Show("值在0-100之间");
                    return;
                }
                Invokes.SetProgressBarValue(progressBar1, int.Parse((string.IsNullOrEmpty(Invokes.GetTextBoxText(textBox4)) ? "0" : Invokes.GetTextBoxText(textBox4).ToString())));
            }
        }
        private void btnSetProgressBar_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(setProgressBar));
            thread.Start();
        } 
        #endregion


    }
}
