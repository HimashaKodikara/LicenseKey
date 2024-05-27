using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLicenser
{
    public partial class Licenser : Form
    {
        public Licenser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Licenser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SKGL.Validate validate = new SKGL.Validate();
                validate.secretPhase = "0748#!m";
                validate.Key = txtproductKey.Text;
                txtStatus.Text = "Creation date" + validate.CreationDate + "\r\n" + "Days remaining:" + validate.DaysLeft;
                Stat.Text = Conve(Result.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Invalid License private Key, contact support!");
            }
            btnCheck.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
               if(cbLicensetype.Text == "Custom")
                {
                    SKGL.Generate gen = new SKGL.Generate();
                    gen.secretPhase = "0748#!m";
                    string lkey = gen.doKey(Convert.ToInt32(txtValidity.Text));
                    txtproductKey.Text = lkey;
                    btnCheck.Enabled = true;
                    Result.Text = Returnhash( "  Email : " + Email.Text +"\r\n" +"  Server Mac Address : " +MacAddress.Text + "\r\n"+" HostUrl : " + HostUrl.Text);
                }
                else if(cbLicensetype.Text == "Full")
                {
                    SKGL.Generate gen = new SKGL.Generate();
                    gen.secretPhase = "0748#!m";
                    txtValidity.Text = "999";
                    txtValidity.Enabled = false;
                    string lkey = gen.doKey(Convert.ToInt32(txtValidity.Text));
                    txtproductKey.Text = lkey;
                    btnCheck.Enabled = true;
                    Result.Text = Returnhash("Email:" + Email.Text + "\r\n" + "Server Mac Address" + MacAddress.Text + "\r\n" + "HostUrl :" + HostUrl.Text);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string Returnhash(string input)
        {
            string result = "";
            try
            {
                result = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
                //result = Encoding.UTF8.GetString(System.Convert.FromBase64String(input));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        private string Conve(string input)
        {
            string result = "";
            try
            {
                //result = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
                result = Encoding.UTF8.GetString(System.Convert.FromBase64String(input));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

    }
}
