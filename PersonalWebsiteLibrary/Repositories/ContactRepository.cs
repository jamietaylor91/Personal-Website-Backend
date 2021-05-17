using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsiteLibrary.Models;

namespace PersonalWebsiteLibrary.Repositories
{
    public class ContactRepository: IContactRepository
    {
        public Contact GetContactInformation()
        {
            return new Contact { EmailAddress = "Jamie"};
        }
    }
}
