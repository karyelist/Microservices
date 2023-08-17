using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Infrastruce
{
    public interface IContactService
    {

        public ContactDto GetContactById(int Id);

    }
}
