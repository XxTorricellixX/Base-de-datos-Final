using System.Data;
using System.Windows.Forms;
using appEjemplo.logica;

namespace appEjemplo
 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona per = new Persona();

        private void rbExiste_Click(object sender, EventArgs e)
        {
            rbExiste.Visible = false;
            rbNoExiste.Visible = false;
            dtpEgreso.Visible = true;
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nit,r;
            string nom;
            nit= int.Parse(txtNit.Text);
            nom = txtNombre.Text;
            //int id, r;
            //string nom, eCivil, gen = "masculino";
            //id = int.Parse(txtNit.Text);
            //nom = txtNombre.Text;
            //eCivil = cbxECivil.SelectedItem.ToString();
            //if (rbFemenino.Checked) {
            //    gen = "femenino";
            //}
            //else if(rbMasculino.Checked){
            //    gen = "masculino";
            //}
            r = per.ingresarEmpresa(nit,nom);
            if (r > 0)
            {
                MessageBox.Show("Empresa registrada","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else{
                MessageBox.Show("Empresa no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarComputadora_Click(object sender, EventArgs e)
        {
            int serial,capacidad, r;
            string marca,tipoDisco;
            serial = int.Parse(txtSerial.Text);
            marca = cbxMarca.SelectedItem.ToString();
            capacidad = int.Parse(txtCapacidad.Text);
            tipoDisco = txtTipoDisco.Text;
            r = per.ingresarComputadora(serial,marca,capacidad,tipoDisco);
            if (r > 0)
            {
                MessageBox.Show("Computadora registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Computadora no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaIngreso=dtpIngreso.Value.Date;
            int nit, serial, r;
            nit = int.Parse(txtNitRep.Text);
            serial = int.Parse(txtSerialRep.Text);
            if (rbNoExiste.Checked)
            {
            r = per.ingresarReparacionNoEx(nit, serial, fechaIngreso);
            }
            else{
            DateTime fechaEgreso = dtpEgreso.Value.Date;
            r = per.ingresarReparacionEx(nit, serial, fechaIngreso, fechaEgreso);
            }
            if (r > 0)
            {
                MessageBox.Show("Reparación registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reparación no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

            private void btnConsultarPersonas_Click(object sender, EventArgs e)
        {
            int nit;
            DateTime fechaIngreso = dtpCons.Value.Date;
            nit = int.Parse(txtNitCons.Text);
            DataSet dsResultado = new DataSet();
            dsResultado = per.consulta1(nit,fechaIngreso);
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet miDs = new DataSet();
            miDs = per.consulta2();

            if (miDs.Tables[0].Rows.Count > 0) { 
            lbMostrarCons.Text=miDs.Tables[0].Rows[0]["count(compSerial)"].ToString();

            }
        }

       


        
    }
}