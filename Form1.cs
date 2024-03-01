
namespace TrackbarValue

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkTamaño_Scroll(object sender, EventArgs e)
        {
            int Valor;
            Valor = trkTamaño.Value;

            lblTamaño.Font = new Font(lblTamaño.Font.FontFamily, Valor);

           

        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}