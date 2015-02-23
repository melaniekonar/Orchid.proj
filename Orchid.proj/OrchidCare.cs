using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orchid.proj
{
    public partial class OrchidCare : Form
    {
        public OrchidCare()
        {
            
            InitializeComponent();
        }

        
        Orchid orchid = OrchidDB.GetOrchid();
        DateTime lastWatering = DateTime.Parse("7/27/13");
        DateTime lastFertilizing = DateTime.Parse("7/27/13");
        
        private void OrchidCare_Load(object sender, EventArgs e)
        {
            txtWater.Text = orchid.NextWatering;
            txtFertilizer.Text = orchid.NextFertilizing;
        }

        

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {          
            if (chkWater.Checked == true)
            {
                lastWatering = DateTime.Today;
                DateTime nextWater = lastWatering.AddDays(9);

                orchid.NextWatering = Convert.ToString(nextWater);
                OrchidDB.SaveOrchid(orchid);
            }
        }

        private void chkFertilizer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFertilizer.Checked == true)
            {
                DateTime lastFertilizing = DateTime.Today;
                DateTime nextFertilize = lastFertilizing.AddDays(9);

                orchid.NextFertilizing = Convert.ToString(nextFertilize);
                OrchidDB.SaveOrchid(orchid);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
