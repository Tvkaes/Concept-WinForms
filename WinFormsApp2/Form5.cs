using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WinFormsApp2
{
    public partial class Form5 : MaterialForm

    {
        //configuracion de firebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {


            AuthSecret = "fPalsOgHmnJP9rw3LmdvAWmlD8ob93OVMLVIeDdn",

            BasePath = "https://csharpfr-428cd-default-rtdb.firebaseio.com/"

        };
        //cliente de firebase
        IFirebaseClient client;
        public Form5()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {

                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {

                    this.CenterToScreen();

                }

            }
            catch
            {
                MessageBox.Show("Connection Fail.");
            }
        }
    }
}
