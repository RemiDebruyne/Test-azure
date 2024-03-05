using MVC.Models;

namespace MVC.Views.Home
{
    public class Index
    {
        public List<User> Users { get; set; } = new();  

        public async Task OnGet()
        {
            HttpClient client = new HttpClient();

            // Avec l'IP publique
            // Weathers = await client.GetFromJsonAsync<List<Weather>>("http://4.232.152.51/weatherforecast");

            // Avec l'IP privée
            // Weathers = await client.GetFromJsonAsync<List<Weather>>("http://10.1.1.16/weatherforecast");

            // Avec le nom d'hôte (recommandé)
            Users = await client.GetFromJsonAsync<List<User>>("http://DebruyneLineBack:80/user");

            //Weathers = await client.GetFromJsonAsync<List<Weather>>("https://localhost:7199/weatherforecast");
        }
    }
}
