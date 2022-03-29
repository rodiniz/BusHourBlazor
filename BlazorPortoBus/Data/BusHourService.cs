using System.Net;

namespace BlazorPortoBus.Data
{
    public class BusHourService
    {       
       

        public async Task<List<BusHour>> GetHours(string code)
        {
            var handler = new HttpClientHandler
            {
                DefaultProxyCredentials = CredentialCache.DefaultCredentials
            };

            var client = new HttpClient(handler);
            return await client
                .GetFromJsonAsync<List<BusHour>>($"https://bushourapi.herokuapp.com/api/getTime?BusStopCode={code}");
        }
    }
}
