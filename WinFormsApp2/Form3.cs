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
    public partial class Form3 : MaterialForm
    {
        
        IFirebaseConfig config = new FirebaseConfig
        {

            
            AuthSecret = "fPalsOgHmnJP9rw3LmdvAWmlD8ob93OVMLVIeDdn",
            
            BasePath = "https://csharpfr-428cd-default-rtdb.firebaseio.com/"

        };
        IFirebaseClient client;

        public Form3()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialTextBox1.Text) || string.IsNullOrEmpty(materialTextBox2.Text)
                || string.IsNullOrEmpty(materialTextBox3.Text))
            {
                //Validacion de textbox 
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {

                //Clase de Registro
                var register = new register
                {

                    usuario = materialTextBox2.Text,
                    password = materialTextBox3.Text,
                    correo = materialTextBox1.Text

                };

                
                FirebaseResponse response = client.Set("Usuario/" + materialTextBox1.Text, register);

                register res = response.ResultAs<register>();
                MessageBox.Show("Registro Realizado");
                materialTextBox1.Text = string.Empty;
                materialTextBox2.Text = string.Empty;
                materialTextBox3.Text = string.Empty;
            }

            Form2 obj = new Form2();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
        private void id_Leave(object sender, EventArgs e)
        {
            //Identifying if the ID is existed or not.
            // From looping it using foreach.

            FirebaseResponse response = client.Get("Usuario/");
            Dictionary<string, register> getSameId = response.ResultAs<Dictionary<string, register>>();
            foreach (var sameID in getSameId)
            {
                string getsame = sameID.Value.correo;
                if (materialTextBox1.Text == getsame)
                {
                    MessageBox.Show("Este correo ya esta en uso");
                    materialTextBox1.Text = string.Empty;
                    break;
                }


            }
        }

    }
}
