using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaMa.Framework.Core.Web.MVCWrappers;
using LaMa.ResourceManagment.Business;
using LaMa.ResourceManagment.Data;

namespace LaMa.ResourceManagment.Web.Models
{
    public class ApplicationVM
    {
        public IList<ApplicationItem> ApplicationItems { get; set; }

        public ApplicationVM()
        {
            ApplicationItems = new List<ApplicationItem>(); 
        }
        public ApplicationVM(IEnumerable<Application> applications)
        {
            ApplicationItems = applications.Select(x => new ApplicationItem
                                                        {
                                                            Guid = x.ApplicationKey,
                                                            Name = x.Name,
                                                            Icon = x.Icon == null ? string.Empty : string.Format("data:image/png;base64,{0}", Convert.ToBase64String(x.Icon)),
                                                            NumberOfVersions = x.ApplicationVersion.Count,
                                                            IsSupported = x.StopSupportDate==null
                                                        }).ToList();
        }

        public class ApplicationItem
        {
            public Guid Guid { get; set; }
            public string Icon { get; set; }
            public string Name { get; set; }
            public int NumberOfVersions { get; set; }
            public bool IsSupported { get; set; }
        }

    }

    public class ApplicationPM:PresentationModel<ApplicationVM>
    {
        
    }
}