using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
using MusicBrainz.Domain;

namespace MusicBrainzWeb.ApiControllers
{
    public class ArtistController : ApiController
    {
        // GET: api/Artist
        public IEnumerable<artist> Get()
        {
            //return new string[] { "value1", "value2" };

            MusicStoreDbEntities artistDb = new MusicStoreDbEntities();

            //from p in context.Periods
            //join f in context.Facts on p.id equals f.periodid into fg
            //from fgi in fg.Where(f => f.otherid == 17).DefaultIfEmpty()
            //where p.companyid == 100
            //select f.value

            var query = from u in artistDb.artists
                join p in artistDb.artistalias on u.id equals p.artist into gj
                from x in gj.Where(a => a.name.Contains("joh")).DefaultIfEmpty()
                where u.name.Contains("joh")
                select u;
            
            //var newList = query.GroupBy(a => a.aname).SelectMany((k,y) => new { k.Key, y.ToString() } ;
                        //join p in artistDb.artists on u.artist equals p.id into gj
                        //from x in gj.DefaultIfEmpty()
            //            select} new
            //            {
            //                UsergroupID = u.UsergroupID,
            //                UsergroupName = u.UsergroupName,
            //                Price = (x == null ? String.Empty : x.Price)
            //            };
            //artistDb.artists.Join(artistDb.artistalias)

            return query.Distinct().ToList();// artistDb.artists.Select(a => a.name).ToList();
        }

        // GET: api/Artist/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Artist
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Artist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Artist/5
        public void Delete(int id)
        {
        }
    }
}
