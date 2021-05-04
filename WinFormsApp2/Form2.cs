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
    public partial class Form2 : MaterialForm
    {

        //configuracion de firebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {

            
            AuthSecret = "fPalsOgHmnJP9rw3LmdvAWmlD8ob93OVMLVIeDdn",
            
            BasePath = "https://csharpfr-428cd-default-rtdb.firebaseio.com/"

        };
        //cliente de firebase
        IFirebaseClient client;

        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                //Prueba de Conexion a firebase
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {


                    this.CenterToScreen();
                    

                }

            }
            catch
            {
                MessageBox.Show("Conexion fallida");
            }
        }
        //declaracion de string statico
        public static string usernamepass;

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.ShowDialog();
            this.Close();

        }
    }
}
