using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFactoryMethod
{
    public partial class Form1 : Form
    {
        private string name;
        private string surname;
        private string birthday;
        private string card_type;

        CardFactory factory = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            name = txt_Name.Text;
            surname = txt_Surname.Text;
            birthday = date_Birthday.Value.ToString();
            card_type = cbox_Cards.Text;

            lbl_name_surname.Text = name + " " + surname;
            
            switch (card_type.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBankFactory(50000, 0);
                    break;
                case "platinium":
                    factory = new PlatiniumFarctory(500000, 1000);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            lbl_card_type.Text = creditCard.CardType;
            lbl_credit_limit.Text = creditCard.CreditLimit.ToString();
            lbl_annual_charge.Text = creditCard.AnnualCharge.ToString();
        }

        
    }
}
