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
using MaterialSkin.Properties;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WinFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        DataTable dt = new DataTable();
        //configuracion de firebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {


            AuthSecret = "fPalsOgHmnJP9rw3LmdvAWmlD8ob93OVMLVIeDdn",

            BasePath = "https://csharpfr-428cd-default-rtdb.firebaseio.com/"

        };
        //cliente de firebase
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }
        MaterialSkinManager obj = MaterialSkinManager.Instance;

        private void Form1_Load(object sender, EventArgs e)
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

            usuario.Text = Form2.nombreUsuario;
            materialLabel6.Text = Form2.nombreUsuario;
            materialLabel7.Text = Form2.password;
            materialLabel5.Text = Form2.nombreCompleto;

            dt.Columns.Add("Consecutivo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Piezas");
            dt.Columns.Add("Precio");

            dataGridView1.DataSource = dt;

            
        

            
            
        }
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked )
            {
                SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
            else { SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT; }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           obj.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Yellow500, MaterialSkin.Primary.Yellow700, MaterialSkin.Primary.Yellow100, MaterialSkin.Accent.Yellow200, TextShade.WHITE);
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Red200, TextShade.WHITE);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }

        private  void materialButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                //Validacion de textbox 
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {

                //Clase de Registro
                var productos = new productos
                {
                    
                    consecutivo = Convert.ToInt32(textBox1.Text),
                    producto = textBox2.Text,
                    piezas = Convert.ToInt32(textBox3.Text),
                    precio = Convert.ToInt32(textBox4.Text),
                };



                FirebaseResponse response = client.Set("Productos/" + Convert.ToInt32(textBox1.Text), productos);
                register res = response.ResultAs<register>();
                MessageBox.Show("Registro Realizado");

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
            }



        }
    }
}
