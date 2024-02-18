using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LionWheelDataTransform;
using LionWheelDataTransform.Controllers;
using LionWheelDataTransform.Models;
using LionWheelDataTransform.Models.Request;
using LionWheelDataTransform.Models.Transformed;
using System.Reflection;
using AutoMapper;
using System.Runtime.CompilerServices;



[Route("api/[controller]")]
[ApiController]

public class TransformationController : ControllerBase
{
    private readonly IMapper _mapper; // stores automapper instance
    private readonly IHttpClientFactory _clientFactory; // client mapper (more robust than httpClient)
    private readonly IConfiguration _configuration;
    public TransformationController(IMapper mapper, IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        _mapper = mapper;
        _clientFactory = clientFactory;
        _configuration = configuration;
    }



    [HttpPost]
    public async Task<IActionResult> TransformAndForward([FromBody] dynamic jsonBody)
    {
        try
        {
            string jsonString = jsonBody.ToString(); // Converts json data to string
            var requestData = RequestDataModel.FromJson(jsonString); // Deserializes json data to RequestDataModel
            var transformedData = _mapper.Map<TransformedDataModel>(requestData); // Transforms RequestDataModel to TransformedDataModel

            (string streetNumber, string streetName) = TransformationMethods.SeparateAddress(transformedData.DestinationStreet);
            Console.WriteLine($"Street Number: {streetNumber}, Street Name: {streetName} | Long Live Edgydo" );

            transformedData.DestinationStreet = streetName;
            transformedData.DestinationNumber = streetNumber;

            // Optionally inspect the transformed data (consider removing in production)
            GetPropertyValues(transformedData);

            // Forward the transformed data
            var response = await SendNewRequest(transformedData);

           

            return Ok(response);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            return StatusCode(500, "An error occurred while processing the request.");
        }
    }



    // sends transformed data 
    private async Task<dynamic> SendNewRequest(TransformedDataModel data)
    {
        var newRequest = BuildNewRequest(data); // Ensure BuildNewRequest handles TransformedDataModel serialization
        using var client = _clientFactory.CreateClient(); // Uses IHttpClientFactory
        var response = await client.SendAsync(newRequest);
        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject(responseContent);
    }

    // serializes data into json format and sets the request's content type to application/json
    private HttpRequestMessage BuildNewRequest(TransformedDataModel data)
    {

        // Define JsonSerializerSettings
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Include, // include null values
        };

        // Serialize the data object to JSON using the defined settings
        string jsonData = JsonConvert.SerializeObject(data, settings);
        Console.WriteLine(jsonData);


        var ApiEndpoint = _configuration.GetValue<string>("AppSettings:DeliveryApiEndpoint"); ;
        var newRequest = new HttpRequestMessage(HttpMethod.Post, ApiEndpoint);
        newRequest.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        return newRequest;
    }




   

    public static List<object> GetPropertyValues(object obj)
    {
        List<object> values = new List<object>();
        PropertyInfo[] properties = obj.GetType().GetProperties();

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(obj, null);
            values.Add(value);
            Console.WriteLine($"{property.Name} - {value}");
        }

        return values;
    }
}


