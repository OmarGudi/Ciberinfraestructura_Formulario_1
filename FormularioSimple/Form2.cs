using FormularioSimple.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FormularioSimple
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Conection dataAccess = new Conection();
            string server = textServer.Text;
            string password = textPassword.Text;
            string bd = db.Text;
            string user = textUser.Text;
            string cad = $"Server={server}; Database={bd}; Uid={user}; Pwd={password};";
            if (dataAccess.try_Conection(cad))
            {
                dgvdatos.DataSource = dataAccess.get_Data(cad);
            }
            else
            {
                MessageBox.Show("It is not possible to connect");
            }
        }
    }
}
