using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsiteLibrary.Models;

namespace PersonalWebsiteLibrary.Repositories
{
    public interface IContactRepository
    {
        Contact GetContactInformation();
    }
}
