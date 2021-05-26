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
    public partial class Form4 : MaterialForm
    {
        //configuracion de firebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {


            AuthSecret = "fPalsOgHmnJP9rw3LmdvAWmlD8ob93OVMLVIeDdn",

            BasePath = "https://csharpfr-428cd-default-rtdb.firebaseio.com/"

        };
        //cliente de firebase
        IFirebaseClient client;
        public Form4()
        {
            InitializeComponent();
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }

        private void Form4_Load(object sender, EventArgs e)
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
       

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
        void registro(Dictionary<string, productos> record)
        {
            foreach (var get in record)
            {
                int consecutivoresult = get.Value.consecutivo;
                string nombreresult = get.Value.producto;
                int piezas = get.Value.piezas;
                int precio = get.Value.precio;


                if (materialTextBox1.Text.Equals(consecutivoresult))
                {
                    materialLabel7.Text = nombreresult;
                    materialLabel5.Text = Convert.ToString(piezas);
                    materialLabel6.Text = Convert.ToString(precio);
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            

                //Clase de Registro
                var productos = new productos
                {

                    piezas = Convert.ToInt32(materialTextBox3.Text),
                    precio = Convert.ToInt32(materialTextBox4.Text)

                };


                // registro en firebase 
                FirebaseResponse response = client.Update("Productos/" +Convert.ToInt32(materialTextBox1), productos);
                MaterialMessageBox.Show("Registro Actualizado");

                materialTextBox1.Text = string.Empty;
                materialTextBox3.Text = string.Empty;
                materialTextBox4.Text = string.Empty;



            
        }
    }
}
