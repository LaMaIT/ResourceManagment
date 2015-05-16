//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaMa.ResourceManagment.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public Application()
        {
            this.ApplicationVersion = new HashSet<ApplicationVersion>();
        }
    
        public System.Guid ApplicationKey { get; set; }
        public string Name { get; set; }
        public string CodeName { get; set; }
        public byte[] Icon { get; set; }
        public string Description { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> FirstReleaseDate { get; set; }
        public Nullable<System.DateTime> StopSupportDate { get; set; }
        public bool HasCentralisedUserManagment { get; set; }
    
        public virtual Resource Resource { get; set; }
        public virtual ICollection<ApplicationVersion> ApplicationVersion { get; set; }
    }
}
