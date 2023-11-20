using Newtonsoft.Json.Linq;

namespace WinFormsApp10EjmploDecido1
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "851f9c8045354662b3e221057230411"; // Reemplaza con tu clave de API
        public Form1()
        {
            InitializeComponent();
            IconoIdaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            IconoVueltaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ObtenerClimaButton_Click(object sender, EventArgs e)
        {
            string ciudad = CiudadTextBox.Text;
            DateTime fechaIda = FechaIdaDateTimePicker.Value;
            DateTime fechaVuelta = FechaVueltaDateTimePicker.Value;

            await ObtenerClima(ciudad, fechaIda, "ida");
            await ObtenerClima(ciudad, fechaVuelta, "vuelta");
        }

        private async Task ObtenerClima(string ciudad, DateTime fecha, string tipo)
        {
            try
            {
                string apiUrl = $"https://api.weatherapi.com/v1/forecast.json?key=851f9c8045354662b3e221057230411&q={ciudad}&dt={fecha:yyyy-MM-dd}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        decimal temperaturaF = data.forecast.forecastday[0].day.avgtemp_f;
                        string iconoCondicion = data.forecast.forecastday[0].day.condition.icon.ToString();
                        int esDia = iconoCondicion.Contains("day") ? 1 : 0;

                        if (tipo == "ida")
                        {
                            TemperaturaIdaLabel.Text = $"Temperatura (ida): {temperaturaF} °F";
                            MostrarIcono(esDia, IconoIdaPictureBox);
                        }
                        else if (tipo == "vuelta")
                        {
                            TemperaturaVueltaLabel.Text = $"Temperatura (vuelta): {temperaturaF} °F";
                            MostrarIcono(esDia, IconoVueltaPictureBox);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error al obtener el pronóstico del clima para {tipo}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarIcono(int esDia, PictureBox pictureBox)
        {
            Image icono = esDia == 1 ? Properties.Resources.icono_dia : Properties.Resources.icono_noche;
            MostrarIcono(icono, pictureBox);
        }

        private void MostrarIcono(Image icono, PictureBox pictureBox)
        {
            int nuevoAncho = 50;
            int nuevoAlto = 50;

            Image nuevaImagen = new Bitmap(icono, new Size(nuevoAncho, nuevoAlto));
            pictureBox.Image = nuevaImagen;
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
