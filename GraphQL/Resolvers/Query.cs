using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Schemas.Catalog;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace GraphQL.Resolvers
{
    public class Query
    {
      
        public readonly IConfiguration _configuration;
        public Query(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ProductModel Product(Guid id)
        {
            var baseUrl = _configuration["BaseApplicationUrl"];
            var uri = baseUrl + "api/v1/products/" + id;
            string response = GetTask(new Uri(uri)).Result;
            var responseJson = JObject.Parse(response);  
            return responseJson.ToObject<ProductModel>();
        }
        public ProductCollection ProductCollection(string categoryid, string query, int page, int pagesize, string sortType, string expand)
        {
            var baseUrl = _configuration["BaseApplicationUrl"];
            var queryV = (!string.IsNullOrEmpty(categoryid) ? ("categoryid=" + categoryid.ToString() + "&") : "") +
                (!string.IsNullOrEmpty(query) ? ("query=" + query.ToString() + "&") : "") +
                (page != null ? ("page=" + page.ToString()) + "&" : "") +
                (pagesize != null ? ("pagesize=" + pagesize.ToString()) + "&" : "") +
                (!string.IsNullOrEmpty(sortType) ? ("sortType=" + sortType.ToString() + "&") : "") +
                (!string.IsNullOrEmpty(expand) ? ("expand=" + expand.ToString()) : "");

            var uri = baseUrl + "api/v1/products/?" + queryV;
            string response = GetTask(new Uri(uri)).Result;
            var responseJson = JObject.Parse(response);
            return responseJson.ToObject<ProductCollection>();


        }
        public CategoryCollection CategoryCollection(int maxdepth, string startCategoryId, bool includeStartCategory)
        {
            var baseUrl = _configuration["BaseApplicationUrl"];
            var query = (maxdepth != null ? ("maxdepth=" + maxdepth.ToString() + "&") : "") +
                (!string.IsNullOrEmpty(startCategoryId) ? ("startCategoryId=" + startCategoryId.ToString()) + "&" : "") + (includeStartCategory ? ("includeStartCategory=" + includeStartCategory.ToString()) : "");

            var uri = baseUrl + "api/v1/categories/?" + query;
            string response = GetTask(new Uri(uri)).Result;
            var responseJson = JObject.Parse(response);
            return responseJson.ToObject<CategoryCollection>();


        }
        static async Task<string> GetTask(Uri uri)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                Console.WriteLine(responseBody.ToString());

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return string.Empty;
            }
        }

    }
}


