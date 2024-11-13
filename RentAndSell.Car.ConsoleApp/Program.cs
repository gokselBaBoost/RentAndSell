// Http isteği atmak istiyorum kime?
// https://localhost:7104/api/Cars adresine istek atacağız
// Nasıl?

using RentAndSell.Car.ConsoleApp.Models;
using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://localhost:7104/api/");

#region HttpClient İstekle tipleri

    #region ResponseMessage İşlemleri ile yapılan istek
    //HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Cars").Result;
    //HttpContent content = httpResponseMessage.Content;
    //var responseContentJson = content.ReadFromJsonAsync(typeof(List<ArabaViewModel>)).Result;

    //string responseContent = content.ReadAsStringAsync().Result;
    //var responseContentJson = content.ReadFromJsonAsync(typeof(List<ArabaViewModel>)).Result;
    //List<ArabaViewModel> arabaViewModelList = content.ReadFromJsonAsync<List<ArabaViewModel>>().Result; 
    #endregion

    #region FromJsonAsync return Object isteği
    //List<ArabaViewModel> arabaViewModels = (List<ArabaViewModel>) httpClient.GetFromJsonAsync("Cars",typeof(List<ArabaViewModel>)).Result; 
    #endregion 

#endregion

List<ArabaViewModel> arabaViewModels = httpClient.GetFromJsonAsync<List<ArabaViewModel>>("Cars").Result;

Console.WriteLine("-------- ARABA LİSTESİ -------");

foreach (ArabaViewModel araba in arabaViewModels)
{
    Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Yili}");
}

Console.WriteLine("----------------");
Console.WriteLine("-------YENİ KAYIT--------");

Console.Write("Marka : ");
string marka = Console.ReadLine();
Console.Write("Model : ");
string model = Console.ReadLine();
Console.Write("Yılı : ");
string yili = Console.ReadLine();
Console.Write("Yakıt Türü : ");
string yakitTuru = Console.ReadLine();
Console.Write("Motor Tipi : ");
string motorTipi = Console.ReadLine();
Console.Write("Şanzıman Tipi : ");
string sanzimanTipi = Console.ReadLine();

Console.WriteLine("----------------");

ArabaViewModel yeniAraba = new ArabaViewModel();

yeniAraba.Marka = marka;
yeniAraba.Model = model;
yeniAraba.Yili = short.Parse(yili);
yeniAraba.YakitTuru = int.Parse(yakitTuru);
yeniAraba.MotorTipi = int.Parse(motorTipi);
yeniAraba.SanzimanTipi = int.Parse(sanzimanTipi);

HttpResponseMessage responsePostMessage =   httpClient.PostAsJsonAsync("Cars", yeniAraba).Result;

if (responsePostMessage.IsSuccessStatusCode)
{
    Console.WriteLine("Yeni araba kayıt edildi.");
    var resposenData = await responsePostMessage.Content.ReadAsStringAsync();

    Console.WriteLine("Yanıt : " + resposenData);
}

arabaViewModels = httpClient.GetFromJsonAsync<List<ArabaViewModel>>("Cars").Result;

Console.WriteLine("-------- GÜNCEL ARABA LİSTESİ -------");

foreach (ArabaViewModel araba in arabaViewModels)
{
    Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Yili}");
}

Console.WriteLine("----------------");

Console.ReadLine();
