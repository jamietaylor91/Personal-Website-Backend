using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsiteLibrary.Models;

namespace PersonalWebsiteLibrary.Services
{
    public interface IContactService
    {
        Contact GetContactInformation();
    }
}
