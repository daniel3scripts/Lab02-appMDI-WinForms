using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string passw = txtPassword.Text;
           
            List<Usuario> users = new List<Usuario>();
            
            users.Add(new Usuario { usuario="pepito@gmail.com",password="123abc"});
            users.Add(new Usuario { usuario = "daniel1@gmail.com", password = "xyz789" });
            users.Add(new Usuario { usuario = "daniel2@gmail.com", password = "xyz789" });
            foreach (var x in users)
            {
                if (x.usuario == user && x.password == passw) 
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Error!!!Las credenciales son incorrectas");
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    
                }
                return;
                
            }

            //if (user is Usuario(usuario) && passw is Usuario(password) )
            //{
                
            //}
            
            

            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

    //internal class PrincipalMDI
    //{
    //    internal void Show()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}