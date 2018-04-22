using IMNWebService.ServiceReference1;
using System;
using System.Windows.Forms;

namespace IMNWebService
{
    public partial class FrmPronostico : Form
    {
        public FrmPronostico()
        {
            InitializeComponent();
            CenterToScreen();
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void pronósticoRegionalMenu_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;          
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void puestaSolMenu_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;      
            groupBox4.Visible = false;
            groupBox7.Visible = false;
        }
        private void CargarEfemerides()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            EFEMERIDES ef = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            lblSolSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_SOL.SALE);
            lblSolPone.Text = String.Format("Se Pone: {0}", ef.EFEMERIDE_SOL.SEPONE);
        }

        private void CargarCuidad()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            PRONOSTICO_PORCIUDADES pc = ws.pronosticoPorCiudad(new pronosticoCiudad()).ParseXML<PRONOSTICO_PORCIUDADES>();
            comboBox1.DataSource = pc.CIUDADES;
        }

        private void Pronostico_Load(object sender, EventArgs e)
        {
            CargarEfemerides();
            CargarCuidad();
            CargarRegiones();
        }
        private void CargarRegiones()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            PRONOSTICO_REGIONAL pr = ws.pronosticoRegional(new pronosticoRegion()).ParseXML<PRONOSTICO_REGIONAL>();
            cbxRegiones.DataSource = pr.REGIONES;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRONOSTICO_PORCIUDADESCIUDAD ciudad = comboBox1.SelectedItem as PRONOSTICO_PORCIUDADESCIUDAD;
            lblTemMax.Text = String.Format("{0} {1}", ciudad.TEMPMAX.ToString(), "°C");
            lblTemMin.Text = String.Format("{0} {1}", ciudad.TEMPMIN.ToString(), "°C");
            //lblTemMin.Text = ciudad.TEMPMIN.ToString();
        }

        private void cbxRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            int id = (cbxRegiones.SelectedItem as PRONOSTICO_REGIONALREGION)?.idRegion ?? -1;
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegionalxID(id).ParseXML<PRONOSTICO_REGIONAL>();
            grbMad.Hide();
            grbMa.Hide();
            grbTar.Hide();
            grbNo.Hide();
            if (reg.REGIONES[0].ESTADOMADRUGADA != null)
            {
                picMad.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADOMADRUGADA.imgPath);
                lblTituloMad.Text = reg.REGIONES[0].ESTADOMADRUGADA.Value;
                lblComentarioMad.Text = reg.REGIONES[0].COMENTARIOMADRUGADA;
                grbMad.Show();
            }
            if (reg.REGIONES[0].ESTADOMANANA != null)
            {
                picMan.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADOMANANA.imgPath);
                lblTituloM.Text = reg.REGIONES[0].ESTADOMANANA.Value;
                lblComentarioM.Text = reg.REGIONES[0].COMENTARIOMANANA;
                grbMa.Show();
            }
            if (reg.REGIONES[0].ESTADOTARDE != null)
            {
                picTar.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADOTARDE.imgPath);
                lblTituloT.Text = reg.REGIONES[0].ESTADOTARDE.Value;
                lblComentarioT.Text = reg.REGIONES[0].COMENTARIOTARDE;
                grbTar.Show();
            }
            if (reg.REGIONES[0].ESTADONOCHE != null)
            {
                picNoc.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADONOCHE.imgPath);
                lblTituloN.Text = reg.REGIONES[0].ESTADONOCHE.Value;
                lblComentarioN.Text = reg.REGIONES[0].COMENTARIONOCHE;
                grbNo.Show();
            }
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
        }
    }
}
