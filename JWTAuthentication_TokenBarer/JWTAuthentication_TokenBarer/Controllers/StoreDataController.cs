using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]

    public class StoreDataController : ControllerBase
    {
        private static readonly List<StoreData> storeData = new List<StoreData>();

        public StoreDataController()
        {
            storeData.Add(new StoreData()
            {
                StoreId = 100,
                StoreName = "Starbucks",
                Location = "Barrie",
                
            });
            storeData.Add(new StoreData()
            {
                StoreId = 101,
                StoreName = "Tim Hortons",
                Location = "Toronto",
                
            });
            storeData.Add(new StoreData()
            {
                StoreId = 102,
                StoreName = "Mc Donald's",
                Location = "London",
                
            });;
            storeData.Add(new StoreData()
            {
                StoreId = 103,
                StoreName = "Burger King",
                Location = "Montreal",
                
            });
            storeData.Add(new StoreData()
            {
                StoreId = 104,
                StoreName = "Walmart",
                Location = "North Bay",
                
            });
        }

        [HttpGet]
        public IEnumerable<StoreData> Get()
        {
            return storeData;
        }
        [HttpGet("{id}", Name = "Get")]
        public StoreData GetStoreById(int id)
        {
            return storeData.Find(x => x.StoreId == id);
        }
    }
}
