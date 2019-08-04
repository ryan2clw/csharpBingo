using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class aspnet_Roles
    {

        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public string Title { get; set; }
        public int? RoleGroupID { get; set; }
        public bool IsThirdPartyEnabled { get; set; }

        public virtual aspnet_Applications aspnet_Applications { get; set; }
        public virtual ICollection<Staff_Jobs> Staff_Jobs { get; set; }
    }
}