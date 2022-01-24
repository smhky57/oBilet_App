using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        #region params
        private HttpClient httpClient;
        private static string apiUri = "https://v2-api.obilet.com/api/";
        #endregion
        #region ctor
        public APIController()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
        }
        #endregion
        #region Methods
        [HttpPost]
        public List<string> GetSession()
        {
            var content = new MultipartFormDataContent();
            content.Add(new StringContent("{\"mode\": \"raw\",\"raw\": \"{\n   \"type\":7,\n  \"connection\":{\"ip-address\":\"192.168.43.41\"  },\n  \"application\":{\n      \"version\":\"1.0.0.0\",\n      \"equipment-id\":\"DD2A0857-7C7D-4376-A83B-E045435E82BB\"\n  }\n}\"}"), "body");

            var response = httpClient.PostAsync(apiUri + "client/getsession", content);

            return new List<string>() { "YeuGTbds4x9bqCvaKldsOkHuwRmUT4rQwmFqxWNxn", "iEINPA0TvN2KuC8BS2c8heWIvdczuLvjcBxRY1a334" };
        }
        [HttpPost]
        public new List<JourneyDetail> GetBusLocations(Query query)
        {
            var content = new MultipartFormDataContent();
            content.Add(new StringContent("{\"mode\": \"raw\",\"raw\": \"{\n    \"data\":null,\n  " +
                "  \"device-session\":{\n        \"session-id\":" + query.SessionID + ",\n   " +
                "     \"device-id\": " + query.DeviceID + "\n  },\n " +
                "   \"date\":" + query.Date + ",\n    \"language\":\"tr-TR\"\n}\"}"), "body");

            var response = httpClient.PostAsync(apiUri + "location/getbuslocations", content);

            return  new List<JourneyDetail>(){
                    new JourneyDetail()
                    {
                         OriginID = 349,
                         DestinationID = 350,
                        StartHour = "09:30",
                        EndHour = "15:30",
                        StartPoint = "Esenler Otogarı",
                        EndPoint = "Ankara Aşti Otogarı",
                        Price = "75,00 TL",
                    },
                    new JourneyDetail()
                    {
                         OriginID = 349,
                         DestinationID = 350,
                        StartHour = "09:30",
                        EndHour = "15:30",
                        StartPoint = "Esenler Otogarı",
                        EndPoint = "Ankara Aşti Otogarı",
                        Price = "75,00 TL",
                    },
                    new JourneyDetail()
                    {
                         OriginID = 349,
                         DestinationID = 350,
                        StartHour = "09:30",
                        EndHour = "15:30",
                        StartPoint = "Esenler Otogarı",
                        EndPoint = "Ankara Aşti Otogarı",
                        Price = "75,00 TL",
                    },
                    new JourneyDetail()
                    {
                         OriginID = 349,
                         DestinationID = 350,
                        StartHour = "09:30",
                        EndHour = "15:30",
                        StartPoint = "Esenler Otogarı",
                        EndPoint = "Ankara Aşti Otogarı",
                        Price = "75,00 TL",
                    },
                    new JourneyDetail()
                    {
                         OriginID = 349,
                         DestinationID = 350,
                        StartHour = "09:30",
                        EndHour = "15:30",
                        StartPoint = "Esenler Otogarı",
                        EndPoint = "Ankara Aşti Otogarı",
                        Price = "75,00 TL",
                    }
            };
        }
        [HttpPost]
        public void GetJourneys(Query query,int originID,int destinationId)
        {
            var content = new MultipartFormDataContent();
            content.Add(new StringContent("{\"mode\": \"raw\",\"raw\": \"{\n  \"device-session\": {\n      " +
                "  \"session-id\": " + query.SessionID + ",\n       " +
                " \"device-id\": " + query.DeviceID + "\n  },\n " +
                " \"date\": " + query.Date + ",\n  \"language\": \"tr-TR\",\n  " +
                "\"data\": {\n    \"origin-id\": " + originID + ",\n    \"destination-id\": " + destinationId + ",\n   " +
                " \"departure-date\": " + query.Date + "\n  }\n}\"}"), "body");

            var response = httpClient.PostAsync(apiUri + "journey/getbusjourneys", content);
        }
        #endregion
    }
}
