using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MSCoE.WebUI
{

    public class Product
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }


    public static IEnumerable<Product> getAllProducts()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response =
            client.GetAsync("http://localhost:30000/api/Products/").Result;
        client.Dispose();

        return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
    }


    static Product getProduct(int id)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response =
            client.GetAsync("http://localhost:30000/api/Products/" + id).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<Product>().Result;
    }


    static Product AddProduct(Product newProduct)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:30000/");
        var response = client.PostAsJsonAsync("api/Product", newProduct).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<Product>().Result;
    }


    static bool UpdateProduct(Product newProduct)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:30000/");
        var response = client.PutAsJsonAsync("api/Products/", newProduct).Result;
        client.Dispose();
        return response.Content.ReadAsAsync<bool>().Result;
    }


    static void DeleteProduct(int id)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:30000/");
        var relativeUri = "api/Products/" + id.ToString();
        var response = client.DeleteAsync(relativeUri).Result;
        client.Dispose();
    }

}
 
}