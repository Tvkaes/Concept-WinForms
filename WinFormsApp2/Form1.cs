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

namespace WinFormsApp2
{
    public partial class Form1 : MaterialForm
    {
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
            usuario.Text = Form2.nombreUsuario;
            materialLabel6.Text = Form2.nombreUsuario;
            materialLabel7.Text = Form2.password;
            materialLabel5.Text = Form2.nombreCompleto;
            
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
    }
}
