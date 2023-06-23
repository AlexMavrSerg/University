using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpcLabs.EasyOpc;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;
using OpcLabs.EasyOpc.OperationModel;
using OpcLabs.BaseLib.ComponentModel;
using OpcLabs.BaseLib.Forms.Browsing.Specialized;
using OpcLabs.EasyOpc.DataAccess.AddressSpace;

namespace univer
{
    public partial class FormMain : Form
    {
        private ApplicationSettings appset;
        private OpcLabs.EasyOpc.DataAccess.EasyDAClient easyDAClient;
        private bool isSubsribed = false;

        public FormMain()
        {
            InitializeComponent();
            appset = new ApplicationSettings();
            easyDAClient = new EasyDAClient();
            easyDAClient.ItemChanged += EasyDAClient_ItemChanged;
        }

        private void EasyDAClient_ItemChanged( object sender, EasyDAItemChangedEventArgs e)
        {
            var itemID = e.Arguments.ItemDescriptor.ItemId;

            if (e.Vtq == null) 
            {
                //MessageBox.Show("Potential communication problem!", "ERROR", icon: MessageBoxIcon.Error, buttons:
                //    MessageBoxButtons.OK);
                //buttonSubscribe.PerformClick();
                return;
            }

            var itemValue = e.Vtq.DisplayValue();
            var state = (int)e.Arguments.State;

            double itemDouble = Double.Parse(itemValue);


            switch (state) 
            {
                case 1:
                    textBoxRamp1.Invoke((MethodInvoker)delegate
                    {
                        textBoxRamp1.Text = itemValue;
                    });

                    opcPanel1.Invoke((MethodInvoker)delegate
                    {
                        opcPanel1.Ramp = itemDouble;
                    });
                    break;
                case 2:
                    textBoxRamp2.Invoke((MethodInvoker)delegate
                    {
                        textBoxRamp2.Text = itemValue;
                    });

                    opcPanel2.Invoke((MethodInvoker)delegate
                    {
                        opcPanel2.Ramp = itemDouble;
                    });
                    break;
                case 3:
                    textBoxRamp3.Invoke((MethodInvoker)delegate
                    {
                        textBoxRamp3.Text = itemValue;
                    });

                    opcPanel3.Invoke((MethodInvoker)delegate
                    {
                        opcPanel3.Ramp = itemDouble;
                    });
                    break;
                case 4:
                    textBoxRamp4.Invoke((MethodInvoker)delegate
                    {
                        textBoxRamp4.Text = itemValue;
                    });

                    opcPanel4.Invoke((MethodInvoker)delegate
                    {
                        opcPanel4.Ramp = itemDouble;
                    });
                    break;
                default:
                    break;
            }
        }

        private void labelRamp1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonsettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            if (formSettings.ShowDialog() == DialogResult.OK)
               appset.Load();
              // MessageBox.Show("OK") ;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (appset != null)
                appset.Load();

            opcPanel1.PanelTitle = "Device 1";
            opcPanel2.PanelTitle = "Device 2";
            opcPanel3.PanelTitle = "Device 3";
            opcPanel4.PanelTitle = "Device 4";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationSettings a = new ApplicationSettings();
            a.Save();
        }

        private void buttonReadItemRamp1_Click(object sender, EventArgs e)
        {
            string tagName = "Simulation Examples.Functions.Ramp1";
            Cursor.Current = Cursors.WaitCursor;
            DAVtq vtq;

            try
            {
                vtq = easyDAClient.ReadItem(
                    appset.MachineName,
                    appset.ServerClass,
                    tagName);
                textBoxRamp1.Text = vtq.Value.ToString();
            }
            catch (OpcException ex) 
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(
                    ex.InnerException.ToString(),
                    ex.Message,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            string tagName1 = "Simulation Examples.Functions.Ramp1";
            string tagName2 = "Simulation Examples.Functions.Ramp2";
            string tagName3 = "Simulation Examples.Functions.Ramp3";
            string tagName4 = "Simulation Examples.Functions.Ramp4";

            isSubsribed = !isSubsribed;
            if (isSubsribed)
            {
                buttonSubscribe.Text = "UNSUBSCRIBE";

                var argumentArray = new DAItemGroupArguments[4];
                argumentArray[0] = new DAItemGroupArguments(
                    appset.MachineName,
                    appset.ServerClass,
                    tagName1, appset.UpdateRate, 1);
                

                argumentArray[1] = new DAItemGroupArguments(
                   appset.MachineName,
                   appset.ServerClass,
                   tagName2, appset.UpdateRate, 2);
               

                argumentArray[2] = new DAItemGroupArguments(
                   appset.MachineName,
                   appset.ServerClass,
                   tagName3, appset.UpdateRate, 3);

                argumentArray[3] = new DAItemGroupArguments(
                  appset.MachineName,
                  appset.ServerClass,
                  tagName4, appset.UpdateRate, 4);
                easyDAClient.SubscribeMultipleItems(argumentArray);
            }
            else
            {
                buttonSubscribe.Text = "SUBSCRIBE";
                easyDAClient.UnsubscribeAllItems();
            }
        }

     
    }
}
