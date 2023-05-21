namespace CalendarioMaker
{
    public partial class Form1 : Form
    {
        bool down = false;
        Point inicial;
        string imagePath = String.Empty;
        public Form1()
        {
            InitializeComponent();


        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                inicial = e.Location;
            }
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
            }
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e) => down = false;

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            //Seleccionar color
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblTitulo.ForeColor = colorDialog.Color;
            }
        }

        private void picImagen_DoubleClick(object sender, EventArgs e)
        {
            //Cambiar imagen
            Image img;
            Bitmap bp;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                img = Image.FromFile(openFileDialog.FileName);
                bp = (Bitmap)img;
                picImagen.Image = bp;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //if (imagePath != string.Empty)
            //{
            //    string path = imagePath.Replace("\\","/");
            //    string htmlText = HtmlText.GetHmltText2(path, lblTitulo.Location.X, lblTitulo.Location.Y, lblTitulo.ForeColor, Color.FromArgb(99999999));
            //    //await Crear.Calendario(htmlText);
            //    await Crear.OtroCalendario(htmlText);
            //}
            await Crear.OtroCalendarioMas( float.Parse(numericUpDown1.Value.ToString()), float.Parse(numericUpDown2.Value.ToString()));
        }
    }
}