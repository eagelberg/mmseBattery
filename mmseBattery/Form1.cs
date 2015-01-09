using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mmseBattery
{
    public partial class Form1 : Form
    {
        public IEnumerator<Panel> currentPannel { get; set; }
        private const string FINAL_SCREEN_NAME = "analogWatch";

        public Form1()
        {
            InitializeComponent();
            year.Format = DateTimePickerFormat.Custom;
            year.CustomFormat = "yyyy";
            year.ShowUpDown = true;

            month.Format = DateTimePickerFormat.Custom;
            month.CustomFormat = "MMMM";
            month.ShowUpDown = true;

            today.Format = DateTimePickerFormat.Custom;
            today.CustomFormat = "dd";
            today.ShowUpDown = true;

            loactionPanel.Visible = false;
            List<Panel> pannels = new List<Panel>() {timePanel,loactionPanel};
            currentPannel = pannels.GetEnumerator();
            currentPannel.MoveNext();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentPannel.Current.Visible = false;
            if (currentPannel.MoveNext())
            {
                currentPannel.Current.Visible = true;
                if (currentPannel.Current.Name == FINAL_SCREEN_NAME) 
                {
                    nextBtn.Visible = false;
                }
            } 
        }
    }
}
