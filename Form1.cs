
namespace TrackbarValue

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkTama�o_Scroll(object sender, EventArgs e)
        {
            int Valor;
            Valor = trkTama�o.Value;

            lblTama�o.Font = new Font(lblTama�o.Font.FontFamily, Valor);

           

        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}