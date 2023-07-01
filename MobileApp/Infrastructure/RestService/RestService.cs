using System.Text;
using System.Text.Json;

namespace Punjab_Ornaments.Infrastructure.RestService
{
    public class RestService : IRestService
    {
#if DEBUG
        private readonly static HttpClientHandler insecureHandler = GetInsecureHandler();
        private readonly HttpClient _client = new(insecureHandler);
#else
        private readonly HttpClient _client = new HttpClient();
#endif

        private readonly JsonSerializerOptions _serializerOptions;

        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public Task DeleteAsync(string uri, string token = "")
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetAsync<TResult>(string uri, string token = "", Dictionary<string, string> headers = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TResult> PostAsync<TResult>(string url, TResult data, string token = "", Dictionary<string, string> headers = null)
        {
            try
            {
                //var client = new HttpClient();
                //var request = new HttpRequestMessage(HttpMethod.Get, "https://10.0.2.2:5001/api/Approval/Getallgoldpurchaserequests");
                //var responsee = await client.SendAsync(request);
                //responsee.EnsureSuccessStatusCode();
                //Console.WriteLine(await responsee.Content.ReadAsStringAsync());

                Uri uri = new(string.Format(url, string.Empty));
                string json = System.Text.Json.JsonSerializer.Serialize(data, _serializerOptions);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await _client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return data;

        }

        public Task<TResult> PutAsync<TResult, TInput>(string uri, TInput data, string token = "", Dictionary<string, string> headers = null)
        {

            throw new NotImplementedException();
        }

        public static HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}
