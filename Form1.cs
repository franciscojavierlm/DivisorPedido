using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIVISOR_PEDIDOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<pedidoDetalle> pedidoD = new List<pedidoDetalle>();
        List<pedidoDetalle> pedidoD2 = new List<pedidoDetalle>();
        private void Form1_Load(object sender, EventArgs e)
        {

            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 100, clave_articulo = "01", sector = 1 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 101, clave_articulo = "02", sector = 1 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 102, clave_articulo = "03", sector = 2 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 103, clave_articulo = "04", sector = 3 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 104, clave_articulo = "05", sector = 3 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 105, clave_articulo = "06", sector = 4 });
            pedidoD.Add(new pedidoDetalle() { docto_ve_id = 106, clave_articulo = "07", sector = 2 });          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            separaSectorUno();
        }

        private void separaSectorUno()
        {
  
            pedidoD2 = BuscaSector(pedidoD, 3).ToList();

            pedidoD.RemoveAll(sector =>
            {
                if (sector.sector == 3)
                    return true;
                else
                    return false;
            });
        }

        private IEnumerable<pedidoDetalle> BuscaSector(List<pedidoDetalle> pD,int sector)
        {
            var items = from x in pD
                        where x.sector == sector
                        select x;
            return items;
        }

    }
}
