using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        int numberOfPeople;


        
        public Form1()
        {


            InitializeComponent();
            dinnerParty = new DinnerParty() {};
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            numberOfPeople = dinnerParty.GetNumberOfPeople();
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBox2.Checked);
            costLabel.Text = Cost.ToString("c");
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }
    }
}

