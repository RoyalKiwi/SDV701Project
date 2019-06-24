using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAdmin
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetTypeNameAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Pokemon/GetTypeName/"));
        }
        internal async static Task<clsType> GetNamesAsync(string Name)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsType>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Pokemon/GetTypes?Name="+Name));
        }

        internal async static Task<List<clsOrder>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrder>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Pokemon/GetOrdersList"));
        }

        internal async static Task<clsInventory> GetPokemonAsync(string Name)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsInventory>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Pokemon/GetPokemon?Name=" + Name));
        }
        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.UTF8, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
        internal static async Task<string> InsertPokemonAsync(clsInventory pokemon)
        {
            return await InsertOrUpdateAsync(pokemon, "http://localhost:60064/api/Pokemon/PostPokemon", "POST");
        }

        internal static async Task<string> UpdatePokemonAsync(clsInventory pokemon)
        {
            return await InsertOrUpdateAsync(pokemon, "http://localhost:60064/api/Pokemon/PutPokemon", "PUT");
        }
    }

}
