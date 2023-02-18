namespace WinFormsEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            lbl_resultado.Text= string.Empty;
            rb_mayusuclas.Checked = true;
        }

        private void limpiar()
        {
            lbl_resultado.Text = string.Empty;
            tb_texto.Text = string.Empty;
        }

        private void mayusculas()
        {
           lbl_resultado.Text = tb_texto.Text.ToUpper();
        }

        private void minisculas()
        {
            lbl_resultado.Text = tb_texto.Text.ToLower();
        }


        private void btn_convertir_Click(object sender, EventArgs e)
        {
            if(rb_mayusuclas.Checked == true)
            {
                mayusculas();
            }
            if (rb_minuculas.Checked == true)
            {
                minisculas();
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}