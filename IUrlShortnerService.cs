using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortner.Core
{
    public interface IUrlShortnerService
    {
        Task<List<UrlDetails>> GetAllUrls();
        Task<List<UrlDetails>> InsertUrl(UrlDetails detail);
        Task<List<UrlDetails>> UpdateUrl(UrlDetails detail);
    }
}
