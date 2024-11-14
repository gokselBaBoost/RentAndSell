using RentAndSell.Car.FormApp.Commons.Enums;
using RentAndSell.Car.FormApp.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;

namespace RentAndSell.Car.FormApp
{
    public partial class CarPage : Form
    {
        private HttpClient _httpClient;
        private const string _endPoint = "Cars";

        public CarPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7104/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", Program.BasicAuth);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxYakitTuru.DataSource = Enum.GetValues(typeof(YakitTuru));
            cBoxMotorTipi.DataSource = Enum.GetValues(typeof(MotorTipi));
            cBoxSanzimanTipi.DataSource = Enum.GetValues(typeof(SanzimanTipi));

            nbrUpDownYil.Maximum = DateTime.Now.Year;
            //nbrUpDownYil.Minimum = DateTime.Now.Year - 50;

            //MessageBox.Show(cBoxYakitTuru.SelectedValue.ToString());
            //MessageBox.Show(cBoxMotorTipi.SelectedValue.ToString());
            //MessageBox.Show(cBoxSanzimanTipi.SelectedValue.ToString());

            //MessageBox.Show("" + (int)cBoxYakitTuru.SelectedValue);
            //MessageBox.Show("" + (int)cBoxMotorTipi.SelectedValue);
            //MessageBox.Show("" + (int)cBoxSanzimanTipi.SelectedValue);

            for (short i = 1940; i <= DateTime.Now.Year; i++)
                cBoxYil.Items.Add(i);

            cBoxYil.SelectedIndex = 0;
            ReloadedDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArabaViewModel model = new ArabaViewModel();
            model.Marka = txtMarka.Text;
            model.Model = txtModel.Text;
            model.Yili = (short)cBoxYil.SelectedItem;
            model.YakitTuru = (YakitTuru)cBoxYakitTuru.SelectedItem;
            model.MotorTipi = (MotorTipi)cBoxMotorTipi.SelectedItem;
            model.SanzimanTipi = (SanzimanTipi)cBoxSanzimanTipi.SelectedItem;

            HttpResponseMessage responseMessage = _httpClient.PostAsJsonAsync(_endPoint, model).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Kayıt başarılıdır. Yanıt: " + responseMessage.Content.ReadAsStringAsync().Result);

                ReloadedDataGridView();
            }

            else
                MessageBox.Show("Kayıt yapılamadı.");
        }

        private void ReloadedDataGridView()
        {
            List<ArabaViewModel> arabaViewModels = _httpClient.GetFromJsonAsync<List<ArabaViewModel>>(_endPoint).Result;

            dgvArabaList.DataSource = arabaViewModels;

            ClearForm();
        }

        private void dgvArabaList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //List<ArabaViewModel> arabaViewModels = _httpClient.GetFromJsonAsync<List<ArabaViewModel>>(_endPoint).Result;

            ArabaViewModel selectedAraba = (ArabaViewModel)dgvArabaList.SelectedRows[0].DataBoundItem;

            txtId.Text = selectedAraba.Id.ToString();
            txtMarka.Text = selectedAraba.Marka;
            txtModel.Text = selectedAraba.Model;

            cBoxYil.SelectedItem = selectedAraba.Yili;
            cBoxYakitTuru.SelectedItem = selectedAraba.YakitTuru;
            cBoxMotorTipi.SelectedItem = selectedAraba.MotorTipi;
            cBoxSanzimanTipi.SelectedItem = selectedAraba.SanzimanTipi;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArabaViewModel model = new ArabaViewModel();
            model.Marka = txtMarka.Text;
            model.Model = txtModel.Text;
            model.Yili = (short)cBoxYil.SelectedItem;
            model.YakitTuru = (YakitTuru)cBoxYakitTuru.SelectedItem;
            model.MotorTipi = (MotorTipi)cBoxMotorTipi.SelectedItem;
            model.SanzimanTipi = (SanzimanTipi)cBoxSanzimanTipi.SelectedItem;

            string id = txtId.Text;

            // https://localhost:7104/api/Cars/3 => Put

            HttpResponseMessage responseMessage = _httpClient.PutAsJsonAsync(_endPoint + $"/{id}", model).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Güncelleme başarılıdır. Yanıt: " + responseMessage.Content.ReadAsStringAsync().Result);

                ReloadedDataGridView();
            }

            else
                MessageBox.Show("Güncelleme yapılamadı.");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            // https://localhost:7104/api/Cars/3 => Delete

            HttpResponseMessage responseMessage = _httpClient.DeleteAsync(_endPoint + $"/{id}").Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Silme başarılıdır. Yanıt: " + responseMessage.Content.ReadAsStringAsync().Result);
                ReloadedDataGridView();
            }

            else
                MessageBox.Show("Güncelleme yapılamadı.");
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            cBoxYil.SelectedIndex = 0;
            cBoxYakitTuru.SelectedIndex = 0;
            cBoxSanzimanTipi.SelectedIndex = 0;
            cBoxMotorTipi.SelectedIndex = 0;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string carID = txtCarId.Text;

            ArabaViewModel model = _httpClient.GetFromJsonAsync<ArabaViewModel>(_endPoint + $"/{carID}").Result;

            if (model != null)
            {
                string metin = $@"
Marka : {model.Marka},
Model : {model.Model},
Yılı : {model.Yili},
Yakıt Türü : {model.YakitTuru},
Şanzıman Tipi : {model.SanzimanTipi},
Motor Tipi : {model.MotorTipi},
";

                MessageBox.Show(metin);
            }

            else
                MessageBox.Show("Güncelleme yapılamadı.");
        }
    }
}
