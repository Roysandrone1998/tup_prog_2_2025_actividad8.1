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
            foreach (Cuenta c in cuentas) {
            
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
    }
}
