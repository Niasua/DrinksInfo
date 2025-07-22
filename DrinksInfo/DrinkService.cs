
using DrinksInfo.Models;
using Newtonsoft.Json;
using RestSharp;

namespace DrinksInfo;

public class DrinkService
{
    internal void GetCategories()
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
        var request = new RestRequest("list.php?c=list");
        var response = client.ExecuteAsync(request);

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

            List<Category> returnedList = serialize.Drinks;

            TableVisualisationEngine.ShowTable(returnedList, "Categories Menu");
        }
    }
}