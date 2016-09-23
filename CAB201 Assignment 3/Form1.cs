using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CAB201_Assignment_3
{
    public partial class Form1 : Form
    {
        private string crustType = "";
        private string sauceType = "";
        private double startPrice = 10.00;
        private double modifierPrice = 0.00;
        private int extraToppings = 0;

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(nameTextBox.Text);
            formState(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handlers fer er bertuns
            gfButton.CheckedChanged += new EventHandler(rButtonChanged); // gf bertun
            thinButton.CheckedChanged += new EventHandler(rButtonChanged); // thin 'n' shitty bertun
            thickButton.CheckedChanged += new EventHandler(rButtonChanged); // thick bertun
        }

        private void rButtonChanged(object sender, EventArgs e)
        {
            // Can't uncheck radio button                        
            sauceDropdown.Enabled = true;

            // Type erv crerst
            RadioButton btn = (RadioButton)sender;
            crustType = btn.Text.ToLower();

            if (gfButton.Checked)
            {
                // whert no fair y gf more
                modifierPrice += 2.00;
            }
            else
            {
                // rip gf crerst
                modifierPrice = 0.00;
            }
        }

        private void formState(bool state)
        {
            // Terppings group yum yum
            foreach (Control x in toppingsGroup.Controls)
            {
                if (x is CheckBox || x is ComboBox || x is RadioButton)
                {
                    x.Enabled = state;
                    Debug.WriteLine("true terppings lol");
                }
            }

            // Crersts group
            foreach (Control x in crustGroup.Controls)
            {
                if (x is CheckBox || x is ComboBox || x is RadioButton)
                {
                    x.Enabled = state;
                    Debug.WriteLine("true crersts lol");
                }
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                formState(true);
                Debug.WriteLine(nameTextBox);
            }

            else
            {
                formState(false);
                Debug.WriteLine("false lol");
            }
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            doneButton.Enabled = true;
            sauceDropdown.Enabled = true;

            CheckBox x = (CheckBox)sender;
            if (x.Checked)
            {
                extraToppings += 1;
            }

            else
            {
                extraToppings -= 1;
            }
        }

        // Wernt serm serce
        private void sauceChanged(object sender, EventArgs e)
        {
            sauceType = sauceDropdown.SelectedItem.ToString().ToLower(); // gimme mer serce
        }

        // How poor am I now RIP
        private double getTotalPrice()
        {
            double totalPrice = startPrice + modifierPrice;
            if (extraToppings - 4 > 0)
            {
                totalPrice += (extraToppings - 4);
            }
            return totalPrice;
        }


        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (crustType == "")
            {
                MessageBox.Show("You done goofed.  Please select a crust.");
                return;
            }

            if (sauceType == "")
            {
                MessageBox.Show("*tsk* *tsk* A sauce you must select!");
                return;
            }

            // No toppings
            if (extraToppings == 0)
            {
                MessageBox.Show("M8 - you gotta select at least one dank topping.  \n\n (p.s. up to 4 are free)");
            }

            // >0 toppings
            else
            {


                MessageBox.Show("Thanks m8 " + nameTextBox.Text + "\n for yer order of a " + crustType + " base with " + sauceType + " sauce and " + extraToppings.ToString() + " toppings.\n\nYou are now broker by $" + getTotalPrice().ToString("F"));
                MessageBox.Show("Thanks for ordering from Beagle Boys Pizza,\nyour pizza will be delivered in 30 minutes or its free!");
            }
        }

        // For some reason it breaks when I remove these... O_o

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
