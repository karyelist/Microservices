using Contact.Infrastruce;
using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Contact.Api.Services
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int Id)
        {
            return new ContactDto()
            {
                id= Id,
                FirstName="Murat",
                LastName="Karakus",

            };
        }
    }
}
