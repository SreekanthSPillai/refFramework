using MSCoE.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MSCoE.WebUI
{

    public class ProductAPI
{

        public static string baseURL = "http://localhost:30000/";
        public static IEnumerable<ProductViewModel> getAllProductCategories()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response =
            client.GetAsync("http://localhost:30000/api/Products/").Result;
        client.Dispose();

        return response.Content.ReadAsAsync<IEnumerable<ProductViewModel>>().Result;
    }

        public static IEnumerable<ProductViewModel> getTopProducts()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync("http://localhost:30000/api/Products/1").Result;
            client.Dispose();

            return response.Content.ReadAsAsync<IEnumerable<ProductViewModel>>().Result;
        }


        static ProductViewModel getProduct(int id)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response =
            client.GetAsync(baseURL + "api/Products/" + id).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<ProductViewModel>().Result;
    }


        static ProductViewModel AddProduct(ProductViewModel newProduct)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(baseURL);
        var response = client.PostAsJsonAsync("api/Product", newProduct).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<ProductViewModel>().Result;
    }


        static bool UpdateProduct(ProductViewModel newProduct)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(baseURL);
        var response = client.PutAsJsonAsync("api/Products/", newProduct).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<bool>().Result;
    }


    static void DeleteProduct(int id)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(baseURL);
        var relativeUri = "api/Products/" + id.ToString();
        var response = client.DeleteAsync(relativeUri).Result;
        client.Dispose();
    }

}
 
}