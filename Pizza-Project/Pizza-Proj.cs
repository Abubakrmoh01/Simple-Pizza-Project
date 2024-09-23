using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Pizza_proj : Form
    {
        public Pizza_proj()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if(rdbsmall.Checked)
            {
                lblsize.Text = "small";
                return;
            }
            if (rdbmeduim.Checked)
            {
                lblsize.Text = "medium";
                return;
            }
            if (rdblarg.Checked)
            {
                lblsize.Text = "Large";
                return;
            }
        }
        float GetSelectedSizePrice()
        {
            if (rdbsmall.Checked)
                return Convert.ToSingle(rdbsmall.Tag);
            else if (rdbmeduim.Checked)
                return Convert.ToSingle(rdbmeduim.Tag);
            else
                return Convert.ToSingle(rdblarg.Tag);
            
            
        }
       void Resetform()
        {
            gpCrustType.Enabled = true;
            gpSize.Enabled = true;
            gpToppings.Enabled = true;
            gpWhereToEat.Enabled = true;

            rdbmeduim.Checked=true;

            chkextrachees.Checked=false; 
            chkgreenpapper.Checked=false;
            chkmashroum.Checked=false;
            chkolvies.Checked=false;
            chkonion.Checked=false;
            chktomatos.Checked=false;


            rdbthin_Crust.Checked = true;

            rdbEat_IN.Checked = true;

            btnOrderPizza.Enabled = true;
        }

        float GetSelectedToppingPrice()
        {
            float TopppingtotalPrice = 0;
            if (chkextrachees.Checked)
                TopppingtotalPrice+= Convert.ToSingle(chkextrachees.Tag);
             if (chkgreenpapper.Checked)
                TopppingtotalPrice += Convert.ToSingle(chkgreenpapper.Tag);
             if (chkmashroum.Checked)
                TopppingtotalPrice += Convert.ToSingle(chkmashroum.Tag);
             if (chkolvies.Checked)
                TopppingtotalPrice += Convert.ToSingle(chkolvies.Tag);
             if (chkonion.Checked)
                TopppingtotalPrice += Convert.ToSingle(chkonion.Tag);
            if (chktomatos.Checked)
                TopppingtotalPrice += Convert.ToSingle(chktomatos.Tag);

            return TopppingtotalPrice;
            
        }
        
       
        float GetSelectedCrustPrice()
        {
            if (rdbthin_Crust.Checked)
                return Convert.ToSingle(rdbthin_Crust.Tag);
            else
                return Convert.ToSingle(rdbthink_crust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedToppingPrice() + GetSelectedCrustPrice();
        }
        void UpdateTotalPrice()
        {
            lblTotalPrice.Text="$"+ CalculateTotalPrice().ToString();
        }

        private void pizzaLable_Click(object sender, EventArgs e)
        {
            pizzaLable.Text = "MAKE YOUR PIZZA";
        }


        private void rdbEAT_OUT_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("confrim order","confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("order Placed sccussfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gpCrustType.Enabled = false;    
                gpSize.Enabled = false;
                gpToppings.Enabled = false;
                gpWhereToEat.Enabled = false;
            }
            else
            {

            }
        }

       void UpdateOrderSummary()
        {
            UpdateCrust();
            UpdateSize();
            UpdateTopping();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }


        private void rdbsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdbmeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rdblarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if(rdbthink_crust.Checked)
            {
                lblcrustype.Text = "Think Crust";
                return;
            }
            if (rdbthin_Crust.Checked)
            {
                lblcrustype.Text = "Thick Crust";
                return;
            }

        }
       void UpdateTopping()
        {
            UpdateTotalPrice();
            string sTopping = "";
            if (chkextrachees.Checked)
            {
              sTopping = "Extra Chees";
            }

            if (chkgreenpapper.Checked)
            {
             sTopping += ", Green Papper";
            }
            if (chkmashroum.Checked)
            { sTopping += ", Mashroum";
                 }
            if (chkolvies.Checked)
            { 
                sTopping += ", Olvis"; 
            }
            if (chktomatos.Checked)
            {
                sTopping += ", Tomatos";
            }
            if (chkonion.Checked)
            {
                sTopping += ", Onion";
            }

            if(sTopping.StartsWith(","))
            {
                sTopping=sTopping.Substring(1,sTopping.Length-1).Trim();
            }

            if (sTopping == "")
                sTopping = "NO Toppings";

            lbltoppings.Text = sTopping;

        }

        private void rdbthin_Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbthink_crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void chkextrachees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkmashroum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chktomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkonion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkolvies_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkgreenpapper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }
        
        void UpdateWhereToEat()
        {
            if (rdbEat_IN.Checked)
                lblwheretoeat.Text = "Eat IN";
            else
                lblwheretoeat.Text = "Take Out";
        }
        private void rdbEat_IN_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            Resetform();
        }

        private void Pizza_proj_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }
    }
}
