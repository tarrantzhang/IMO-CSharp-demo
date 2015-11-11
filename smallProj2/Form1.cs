using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallProj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createCheckbox(resturants);
        }


        private void timeCounter_Tick(object sender, EventArgs e)
        {

            dataLabel.Text = DateTime.Now.ToString("MMM dddd H:mm:ss");
        }

        String[] resturants = { "J Gumbo's", "Fat Sandwich", "Mia Zas", "Red herring" };
        String[] resturantDescriptions = {
        "Counter-service chain outpost dispensing gumbo, jambalaya, po' boys & other Cajun-Creole fare.\n\n" +
                "Address: 700 S Gregory St, Urbana, IL 61801\n\n"+
                "Phone:(217) 337-4840",
        "Quirky counter-serve cafe featuring hearty sandwiches with creative ingredients & irreverent names.\n\n"+
                "Address: 502 E John St #2, Champaign, IL 61820\n\n"+
                "Phone:(217) 328-5035",
        "Italian Restaurant\n\n"+
                "Address: 629 E Green St, Champaign, IL 61820\n\n"+
                "Phone:(217) 298-3198",
        "Vegetarian & globally inspired vegan fusion fare served in an eclectic space with special events.\n\n"+
                "Address: 1209 W Oregon St, Urbana, IL 61801\n\n"+
                "Phone:(217) 367-2340"};
        private void generateResturant()
        {
            int length = checkedListBox1.CheckedItems.Count;
            if (length == 0){
                MessageBox.Show("Please select atleast one resturant!");
                return;
            }
            String[] items = new String[length];
            int i = 0;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                items[i] = itemChecked.ToString();
                i++;
            }

            Random ran = new Random();
            int dice = ran.Next(0, 6);
            int index = dice % length;
            label1.Text = "I will eat at: " + items[index] + " today!";
        }

        private void showDetail()
        {
            int length = checkedListBox1.CheckedItems.Count;
            if (length != 1) { 
                MessageBox.Show("Please select exactly one resturant!");
                return;
            }
            else
            {
                String selected = checkedListBox1.CheckedItems[0].ToString();
                switch(selected)
                {
                    case "J Gumbo's":
                        label2.Text = resturantDescriptions[0];
                        break;
                    case "Fat Sandwich":
                        label2.Text = resturantDescriptions[1];
                        break;
                    case "Mia Zas":
                        label2.Text = resturantDescriptions[2];
                        break;
                    case "Red herring":
                        label2.Text = resturantDescriptions[3];
                        break;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateResturant();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showDetail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
