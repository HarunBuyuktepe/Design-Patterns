using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAbstractFactory
{
    public partial class Form1 : Form
    {
        private string brand;
        private string model;
        private string features;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            brand = cmBoxPhoneBrand.Text.ToLower();
            model = cmBoxPhoneModel.Text.ToLower();

            switch(brand)
            {
                case "nokia":

                        IMobilePhone nokiaMobilePhone = new Nokia();
                        MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

                        if (model.Equals("normal"))
                            features = nokiaClient.GetNormalPhoneModelDetails();
                        else
                            features = nokiaClient.GetSmartPhoneModelDetails();

                    break;

                case "samsung":

                        IMobilePhone samsungMobilePhone = new Samsung();
                        MobileClient samsungClient = new MobileClient(samsungMobilePhone);

                        if (model.Equals("normal"))
                            features = samsungClient.GetNormalPhoneModelDetails();
                        else
                            features = samsungClient.GetSmartPhoneModelDetails();

                    break;

                default:
                    break;
            }

            rTxtBox_Features.Text = features;

        }
    }
}
