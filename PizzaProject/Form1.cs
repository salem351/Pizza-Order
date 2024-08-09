using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
           
        }

        float ClaculatePriceOf_Size()
        {
            
            if (rdSmall_Sz.Checked)
            
                return Convert.ToSingle(rdSmall_Sz.Tag);
            
            else if (rdMedium_Sz.Checked)
            
                return Convert.ToSingle(rdMedium_Sz.Tag);
            
            else
                return Convert.ToSingle(rdLarge_Sz.Tag);
           
        }
        float ClaculatePriceOf_Crust()
        {
          
            if (rdThinCrust.Checked)
           
                return Convert.ToSingle(rdThinCrust.Tag);
            
            else
            
                return Convert.ToSingle(rdThickCrust.Tag);
         
        }
        float ClaculatePriceOf_Topping()
        {
            float PriceOfTopping = 0;

            if (ckExtraChees_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckExtraChees_Tp.Tag);
            }
            if (ckOnine_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckOnine_Tp.Tag);
            }
            if (ckMushrooms_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckMushrooms_Tp.Tag);
            }
            if (ckOlives_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckOlives_Tp.Tag);
            }
            if (ckTomatoes_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckTomatoes_Tp.Tag);
            }
            if (ckGreenPapers_Tp.Checked)
            {
                PriceOfTopping += Convert.ToSingle(ckGreenPapers_Tp.Tag);
            }

            return PriceOfTopping;
        }

        float ClaculateTotalPrice()
        {
            return ClaculatePriceOf_Size() + ClaculatePriceOf_Crust() + ClaculatePriceOf_Topping();
        }
        void UpdateTotalPrice()
        {
            Price.Text = "$ " + ClaculateTotalPrice().ToString();
        }

        void UpdateSizeGroup()
        {
            UpdateTotalPrice();
            if (rdSmall_Sz.Checked)
            {
                labSize.Text = "Small";
                return;
            }
            if (rdMedium_Sz.Checked)
            {
                labSize.Text = "Medium";
                return;
            }
            if (rdLarge_Sz.Checked)
            {
                labSize.Text = "Large";
                return;
            }
        }
        void UpdateCrustTypeGroup()
        {
            UpdateTotalPrice();
            if (rdThinCrust.Checked)
            {
                labCrustType.Text = "Thin Crust";
                return;
            }
            if (rdThickCrust.Checked)
            {
                labCrustType.Text = "Thick Crust";
                return;
            }
        }
        void UpdateToppingGroup()
        {
            UpdateTotalPrice();

            string StringOfTopping = "";

            if (ckExtraChees_Tp.Checked)
            {
                StringOfTopping = "Extra Chees";
            }
            if (ckOnine_Tp.Checked)
            {
                StringOfTopping += ", Onine";
            }
            if (ckMushrooms_Tp.Checked)
            {
                StringOfTopping += ", Mushrooms\n";
            }
            if (ckOlives_Tp.Checked)
            {
                StringOfTopping += ", Olives";
            }
            if (ckTomatoes_Tp.Checked)
            {
                StringOfTopping += ", Tomatoes";
            }
            if (ckGreenPapers_Tp.Checked)
            {
                StringOfTopping += ", GreenPapers";
            }

            if (StringOfTopping.StartsWith(","))
            {
                StringOfTopping = StringOfTopping.Substring(1 , StringOfTopping.Length - 1).Trim();
            
            }

            if(StringOfTopping == "")
            {
                StringOfTopping = "No Topping";
            }

            labTopping.Text = StringOfTopping;

        }
        void UpdateWhereToEat()
        {
            if (rdEatin_WTE.Checked)
            {
                labWhereToEat.Text = "Eat in";
            }
            if (rdTakeOff_WTE.Checked)
            {
                labWhereToEat.Text = "Take Off";
            }
            
        }
        void UpdateLoadSummary()
        {
            UpdateSizeGroup();
            UpdateCrustTypeGroup();
            UpdateToppingGroup();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }


        private void rdSmall_Sz_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeGroup();
        }
        private void rdMedium_Sz_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeGroup();
        }
        private void rdLarge_Sz_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeGroup();
        }


        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustTypeGroup();
        }
        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustTypeGroup();
        }


        private void ckExtraChees_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }
        private void ckOnine_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }
        private void ckMushrooms_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }
        private void ckOlives_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }
        private void ckTomatoes_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }
        private void ckGreenPapers_Tp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingGroup();
        }


        private void rdTakeOff_WTE_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rdEatin_WTE_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


        private void OrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Conform Order" , "Conform" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_OrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }
        private void ResetForm_Click(object sender, EventArgs e)
        {
            btn_OrderPizza.Enabled = true;

            //gb of size
            gbSize.Enabled = true;
            rdSmall_Sz.Checked = true;
            rdMedium_Sz.Checked = false;
            rdLarge_Sz.Checked = false;

            //gb Crust
            gbCrustType.Enabled = true;
            rdThickCrust.Checked = false;
            rdThinCrust.Checked = true;

            //gb Topping
            gbToppings.Enabled = true;
            ckExtraChees_Tp.Checked = false;
            ckOlives_Tp.Checked = false;
            ckOnine_Tp.Checked = false;
            ckMushrooms_Tp.Checked = false;
            ckTomatoes_Tp.Checked = false;
            ckGreenPapers_Tp.Checked = false;
            labTopping.Text = "No Topping";

            // gb where to eat
            gbWhereToEat.Enabled = true;
            rdEatin_WTE.Checked = false;
            rdTakeOff_WTE.Checked = true;


        }


        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateLoadSummary();
        } 
    }
}
