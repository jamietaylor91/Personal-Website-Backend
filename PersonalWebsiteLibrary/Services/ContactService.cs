using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsiteLibrary.Models;
using PersonalWebsiteLibrary.Repositories;

namespace PersonalWebsiteLibrary.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact GetContactInformation()
        {
            return _contactRepository.GetContactInformation();
        }
    }
}
