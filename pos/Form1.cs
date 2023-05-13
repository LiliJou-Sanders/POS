using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class titulo : Form
    {
        public titulo()
        {
            InitializeComponent();
        }

        private void titulo_Load(object sender, EventArgs e)
        {
            FechaHora.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            ///localizar el lable (titulo) de la pagina a la mitad
            Nombre.Location = new Point((this.Width /2)-(Nombre.Width / 2), 0);
            ///centrar el  lable Desarrollado por y ponerlo debajo  del titulo
            Desarrollado.Location = new Point((this.Width / 2)-(Desarrollado.Width / 2), Nombre.Height);
            ///centrada debajo del Desarrollado por...
            FechaHora.Location = new Point((this.Width / 2)-(FechaHora.Width / 2), (Nombre.Height + Desarrollado.Height));
            ///ubicar el dataGrid debajo de los titulos, 
            dataGridproductos.Location = new Point((10), (Nombre.Height + Desarrollado.Height + FechaHora.Height));
            dataGridproductos.Width = this.Width - 40;
            dataGridproductos.Height=(this.Height/ 4 )* 3;
            pictureBoxLogo.Location = new Point((this.Width-pictureBoxLogo.Width), 0);
            txtcodigo.Location = new Point((10), this.Height-txtcodigo.Height);
            txtcodigo.Width = this.Width - 40;/// segun el nivel del dataGrid
            dataGridproductos.Columns.Add("Cantidad", "Cantidad");
            dataGridproductos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridproductos.Columns[0].Width = (dataGridproductos.Width *10) / 100;
            dataGridproductos.Columns.Add("Nombre", "Nombre");
            dataGridproductos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridproductos.Columns[1].Width = (dataGridproductos.Width * 50) /100;
            dataGridproductos.Columns.Add("Precio", "Precio");
            dataGridproductos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridproductos.Columns[2].Width = (dataGridproductos.Width * 20)/100;
            dataGridproductos.Columns.Add("Total", "Total");
            dataGridproductos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridproductos.Columns[3].Width = (dataGridproductos.Width * 20) /100;
            dataGridproductos.ReadOnly=true;
            Font fuente = new Font("Arial", 20);
            LblTotal.Font = fuente;
            int posicion = (this.Height - (Nombre.Height + Desarrollado.Height + FechaHora.Height + dataGridproductos.Height + txtcodigo.Height));
            LblTotal.Location = new Point (10 + dataGridproductos.Columns[0].Width + dataGridproductos.Columns[1].Width + dataGridproductos.Columns[2].Width , (Nombre.Height + Desarrollado.Height + FechaHora.Height + dataGridproductos.Height) + posicion/4);
            txtcodigo.TabIndex = 0;
        }
        
        ///Personlizar el lable de hora y fecha segun la hora y fecha del sistema.
        private void time_Tick(object sender, EventArgs e)
        {
            FechaHora.Text=DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void txtcodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                MessageBox.Show("se encontro el articulo" + txtcodigo.Text);
                txtcodigo.Clear();
            }
        }
    }
}
