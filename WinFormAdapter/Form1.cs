using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdapter
{
    public partial class Form1 : Form
    {
        private string compound;
        private string display;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            compound = cmBoxCompound.Text;

            switch (compound.ToLower())
            {
                case "unknown":
                    Compound unknown = new RichCompound("Unknown");
                    display = unknown.Display();
                    break;

                case "water":
                    Compound water = new RichCompound("Water");
                    display = water.Display();
                    break;

                case "ethanol":
                    Compound alcohol = new RichCompound("Ethanol");
                    display = alcohol.Display();
                    break;

                case "benzene":
                    Compound benzene = new RichCompound("Benzene");
                    display = benzene.Display();
                    break;

                default:
                    break;
            }

            rTextDisplay.Text = display;
        }
    }
}
