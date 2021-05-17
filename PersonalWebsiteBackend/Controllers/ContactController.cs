using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PersonalWebsiteLibrary.Services;
using PersonalWebsiteLibrary.Models;

namespace PersonalWebsiteBackend.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;

        }
        public IHttpActionResult Get()
        {
            return Ok(_contactService.GetContactInformation());
        }
    }
}
