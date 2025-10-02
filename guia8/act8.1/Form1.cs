using act8._1.Models;

namespace act8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cuenta> cuentas = new List<Cuenta>();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double Importe = Convert.ToDouble(tbImporte.Text);

            Cuenta c = new Cuenta(nombre, dni, Importe);

            cuentas.Sort();

            int idx = cuentas.BinarySearch(c);
            if (idx >= 0)
            {
                cuentas[idx].Nombre = nombre;
                cuentas[idx].Importe = Importe;

            }
            else
            {
                cuentas.Add(c);
                tbDNI.Clear();
                tbImporte.Clear();
                tbNombre.Clear();
            }
            btnActualizar.PerformClick();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Cuenta c in cuentas)
            {

                listBox1.Items.Add(c);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta? c = listBox1.SelectedItem as Cuenta;

            if (c != null)
            {
                tbDNI.Text = $"{c.DNI}";
                tbNombre.Text = $"{c.Nombre}";
                tbImporte.Text = $"{c.Importe}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (sr.EndOfStream == false)
                {
                    string linea = sr.ReadLine();
                    string dni = linea.Substring(0, 9);
                    string nombre = linea.Substring(9,10).Trim();
                    string importar = linea.Substring(19,9);
                     Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToInt32(importar));
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
