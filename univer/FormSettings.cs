using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univer
{
    public partial class FormSettings : Form
    {
        private ApplicationSettings appset;
        public FormSettings()
        {
            InitializeComponent();

            appset = new ApplicationSettings();
        }
        private void FormSetings_Load(object sender, EventArgs e)
        {
            appset.Load();
            textBoxMachineName.Text = appset.MachineName;
            textBoxUpdataRate.Text = appset.UpdateRate.ToString();
            textBoxServerClass.Text = appset.ServerClass;

            listBoxOPCTags.Items.Clear();
            foreach (var item in appset.OPCTags)
                listBoxOPCTags.Items.Add(item);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            appset.MachineName = textBoxMachineName.Text;
            appset.UpdateRate = Int32.Parse(textBoxUpdataRate.Text);
            appset.ServerClass = textBoxServerClass.Text;

            appset.Save();

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
