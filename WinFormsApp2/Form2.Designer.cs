
namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.zzz = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.zzzzz = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(146, 287);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(128, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Iniciar Sesion";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.textbox1);
            this.materialCard.Controls.Add(this.zzz);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(71, 87);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(274, 50);
            this.materialCard.TabIndex = 5;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(84, 14);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(168, 23);
            this.textbox1.TabIndex = 1;
            // 
            // zzz
            // 
            this.zzz.AutoSize = true;
            this.zzz.Depth = 0;
            this.zzz.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.zzz.Location = new System.Drawing.Point(14, 16);
            this.zzz.MouseState = MaterialSkin.MouseState.HOVER;
            this.zzz.Name = "zzz";
            this.zzz.Size = new System.Drawing.Size(55, 19);
            this.zzz.TabIndex = 0;
            this.zzz.Text = "Usuario";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.textBox2);
            this.materialCard1.Controls.Add(this.zzzzz);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(71, 152);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(274, 59);
            this.materialCard1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(141, 23);
            this.textBox2.TabIndex = 1;
            // 
            // zzzzz
            // 
            this.zzzzz.AutoSize = true;
            this.zzzzz.Depth = 0;
            this.zzzzz.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.zzzzz.Location = new System.Drawing.Point(14, 18);
            this.zzzzz.MouseState = MaterialSkin.MouseState.HOVER;
            this.zzzzz.Name = "zzzzz";
            this.zzzzz.Size = new System.Drawing.Size(90, 19);
            this.zzzzz.TabIndex = 0;
            this.zzzzz.Text = "Constraseña";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(98, 240);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(225, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "No tines cuenta?, Haz click aqui";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 414);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialCard);
            this.Controls.Add(this.materialCard1);
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private System.Windows.Forms.TextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel zzz;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TextBox textbox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialLabel zzzzz;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}