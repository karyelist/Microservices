using Contact.Infrastruce;
using Contact.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;   
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]

        public ContactDto Contact(int Id)
        {

            return _contactService.GetContactById(Id);
        }

    }
}
