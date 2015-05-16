using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LaMa.ResourceManagment.Business
{
    public class ApplicationService
    {
        public ApplicationService()
        {
            
        }

        public IList<Data.Application> GetApplications(bool includeApplicationVersions)
        {
            
            using (var ctx = new Data.Entities())
            {
                var applications = ctx.Application.AsQueryable();
                if (includeApplicationVersions)
                {
                    applications= applications.Include(x => x.ApplicationVersion);
                }
                return applications.ToList();
            }
        }
 
    }
}
