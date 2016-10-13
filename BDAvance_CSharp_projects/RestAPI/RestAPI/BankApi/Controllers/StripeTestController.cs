using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Stripe;

namespace BankApi.Controllers
{
    public class StripeTestController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            StripePlan plan = new StripePlan();
            return plan.ToString();
        }
    }
}
