using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SatvaPartyRegister.Presentation.Web.Helpers
{
    public class ApiClient
    {
        private readonly HttpClient _client;


        public ApiClient(string basePath)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(basePath)
            };
        }

        public async Task<ApiResponse<TResponse>> GetAsync<TResponse>(string path, Dictionary<string, string> queryString = null, bool isAnonymousCall = false) where TResponse : class
        {
            var result = new ApiResponse<TResponse>();
            string apiPath = GeneratePathWithQueryString(path, queryString);
            var response = await _client.GetAsync(apiPath);
            if (response.IsSuccessStatusCode)
                result.ResponseObject = JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());
            result.StatusCode = response.StatusCode;
            result.IsSuccessStatusCode = response.IsSuccessStatusCode;
            return result;
        }

        public async Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string path, TRequest model, Dictionary<string, string> queryString = null, bool isAnonymousCall = false)
            where TRequest : class
            where TResponse : class
        {
            var result = new ApiResponse<TResponse>();
            HttpResponseMessage response = await PostDataAsync<TRequest>(path, model, queryString, result, isAnonymousCall);
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var reponseData = await response.Content.ReadAsStringAsync();
                    result.ResponseObject = JsonConvert.DeserializeObject<TResponse>(reponseData);
                    break;
                case HttpStatusCode.BadRequest:
                    var errorResponse = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                    break;
            }
            return result;
        }

        public async Task<ApiResponse> PostAsync<TRequest>(string path, TRequest model, Dictionary<string, string> queryString = null, bool isAnonymousCall = false) where TRequest : class
        {
            var result = new ApiResponse();
            await PostDataAsync<TRequest>(path, model, queryString, result, isAnonymousCall);
            return result;
        }

        #region Private Methods
        private async Task<HttpResponseMessage> PostDataAsync<TRequest>(string path, TRequest model, Dictionary<string, string> queryString, ApiResponse result, bool isAnonymousCall = false)
            where TRequest : class
        {
            string apiPath = GeneratePathWithQueryString(path, queryString);
            var response = await _client.PostAsync(apiPath, model == null ? null : new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
            result.StatusCode = response.StatusCode;
            result.IsSuccessStatusCode = response.IsSuccessStatusCode;
            return response;
        }

        private static string GeneratePathWithQueryString(string path, Dictionary<string, string> queryString)
        {
            string apiPath = path;
            if (queryString != null && queryString.Count > 0)
            {
                var queryStringResult = HttpUtility.ParseQueryString(string.Empty);
                foreach (var item in queryString)
                {
                    queryStringResult[item.Key] = item.Value;
                }
                apiPath = $"{apiPath}?{queryStringResult.ToString()}";
            }

            return apiPath;
        }
        #endregion
    }


    public class Rootobject
    {
        public Datum[] Data { get; set; }
        public int Total { get; set; }
        public object AggregateResults { get; set; }
        public object Errors { get; set; }
    }

    public class Datum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

}
