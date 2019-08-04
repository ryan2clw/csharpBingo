using System;

namespace SpaBingo.Entities
{
    public class FormFields_ConfigurationSettings
    {
        public int ID { get; set; }
        public int FormID { get; set; }
        public int FranchiseID { get; set; }
        public string FieldName { get; set; }
        public bool IsRequired { get; set; }
        public bool IsDisplayed { get; set; }
        public string ExtraInfo { get; set; }
        public bool IsUnique { get; set; }
        public int? MinLength { get; set; }

        public virtual Franchise Franchise { get; set; }
        public virtual GeneralDomain GeneralDomain { get; set; }
    }
}