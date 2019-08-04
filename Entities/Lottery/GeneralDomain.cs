using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class GeneralDomain
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public string Code { get; set; }

        public virtual ICollection<GeneralDomain> GeneralDomain1 { get; set; }
        public virtual GeneralDomain GeneralDomain2 { get; set; }
        public virtual ICollection<FormFields_ConfigurationSettings> FormFields_ConfigurationSettings { get; set; }
    }
}