using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrlShortner.Core
{
    public class UrlShortnerService:IUrlShortnerService
    {
        private readonly DbClient _context = null;
        public UrlShortnerService(IOptions<UrlStoreDbConfig> urlstoredbconfig)
        {
            _context = new DbClient(urlstoredbconfig);
        }
        public async Task<List<UrlDetails>> GetAllUrls()
        {
            try
            {
                
                return await _context.urls.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<List<UrlDetails>> InsertUrl(UrlDetails detail)
        {
            await _context.urls.InsertOneAsync(detail);
            return await _context.urls.Find(_ => true).ToListAsync();
        }
        public async Task<List<UrlDetails>> UpdateUrl(UrlDetails detail)
        {
            await _context.urls.FindOneAndUpdateAsync(Builders<UrlDetails>.Filter.Eq("_id", detail._id), Builders<UrlDetails>.Update.
                                                                                        Set(x=>x.urllong, detail.urllong)
                                                                                       .Set(x=>x.urlshort, detail.urlshort)
                                                                                       .Set(x=>x.count, detail.count));
            return await _context.urls.Find(_ => true).ToListAsync();
        }
    }
}
