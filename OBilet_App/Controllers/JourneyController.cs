using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class JourneyController : Controller
    {
        private APIController api = new APIController();

        public IActionResult Index(Query query)
        {
            Journey journey = new Journey()
            {
                StartPoint = query.StartPointText,
                EndPoint = query.EndPointText,
                DeviceID = query.DeviceID,
                SessionID = query.SessionID,
                Date = query.Date,
                JourneyDetails = api.GetBusLocations(query)
            };

            return View(journey);
        }
       
        public IActionResult BusDetail(string originId,string destinationId, string sessionId, string deviceId, string date)
        {
            api.GetJourneys(new Query() { SessionID=sessionId,DeviceID=deviceId,Date=date},Convert.ToInt32(originId), Convert.ToInt32(destinationId));
            return View();
        }
    }
}
