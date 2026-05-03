using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        void UpDateSize ()
        {
            UpDateTotalPrice(); 

            if (radSmall.Checked)
                laSize.Text = "Small";
            if (radMedium.Checked)
                laSize.Text = "Medium";
            if (radLarge.Checked)
                laSize.Text = "Large";
        }


        void UpDateCurt()
        {
            UpDateTotalPrice ();

            if (radThikCrust.Checked)
                laCrust.Text = "Thik Curst";
            else if (radThinCrust.Checked)
                laCrust.Text = "Thin Crust";
        }

        void UpDateToppings()
        {
            UpDateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked) sToppings += "Extra Chees";

            if (chkOnion.Checked) sToppings += ",Onion";

            if (chkOlives.Checked) sToppings += ",Olives";

            if (chkTomatoes.Checked) sToppings += ",Tomatoes";

            if (chkMushrooms.Checked) sToppings += ",Mushrooms";

            if (chkGreenPeppers.Checked) sToppings += ",Green Peppers";

            if (sToppings.StartsWith(","))
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();

            if (sToppings == "")
                sToppings = "No Toppings";

            laToppings.Text = sToppings;
        }
        
        float GetSelectedSizePrice ()
        {
            if (radSmall.Checked)
                return Convert.ToSingle(radSmall.Tag);
            else if (radMedium.Checked)
                return Convert.ToSingle(radMedium.Tag);
            else
                return Convert.ToSingle(radLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float tToppigs = 0;

            if (chkExtraChees.Checked) tToppigs += Convert.ToSingle(chkExtraChees.Tag);

            if (chkGreenPeppers.Checked) tToppigs += Convert.ToSingle(chkGreenPeppers.Tag);

            if (chkMushrooms.Checked) tToppigs += Convert.ToSingle(chkMushrooms.Tag);

            if (chkOlives.Checked) tToppigs += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked) tToppigs += Convert.ToSingle(chkOnion.Tag);

            if (chkTomatoes.Checked) tToppigs += Convert.ToSingle(chkTomatoes.Tag);

            return tToppigs;    
        }

       float GetSelectedCurtPrice()
        {
            if (radThikCrust.Checked)
                return Convert.ToSingle(radThikCrust.Tag);
            else
                return Convert.ToSingle(radThinCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCurtPrice();
        }

        void UpDateTotalPrice ()
        {
            laTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void ResetForm()
        {
            //reset Group
            grSize.Enabled = true;
            grCrustType.Enabled = true;
            graToppings.Enabled = true;
            graWhrerYouEat.Enabled = true;

            // reset Toppings 
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            laToppings.Text = "No Toppings";

            // reset Buttons 
            butOrderPizza.Enabled = true;

            //reset Crust 
            radThikCrust.Checked = true;
        }

        void UpDateOrderForm ()
        {
            UpDateSize();
            UpDateCurt();
            UpDateToppings();
            UpDateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void graToppings_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpDateOrderForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
           
 

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpDateSize();
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpDateSize();
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpDateSize();
        }

        private void laSize_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {
           
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }
        private void label2_Click_3(object sender, EventArgs e)
        {
            
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void label2_Click_4(object sender, EventArgs e)
        {
            
        }

        private void radThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpDateCurt();
        }

        private void radThikCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpDateCurt(); 
        }

        private void label2_Click_5(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radTakeOut.Checked)
                laWhereYouEat.Text = radTakeOut.Text;

        }

        private void radEatIn_CheckedChanged(object sender, EventArgs e)
        {
           if(radEatIn.Checked)
                laWhereYouEat.Text = radEatIn.Text;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void butOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Your Oder", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Successfuly", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                butOrderPizza.Enabled = false;
                graToppings.Enabled = false;
                grSize.Enabled = false;
                grCrustType.Enabled = false;
                graWhrerYouEat.Enabled = false;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void laTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void laToppings_Click(object sender, EventArgs e)
        {

        }
    } 
   
}
