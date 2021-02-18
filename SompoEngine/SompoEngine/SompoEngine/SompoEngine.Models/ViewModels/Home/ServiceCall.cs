using SompoEngine.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Models
{
    public class ServiceCall
    {
        public string ProposalNo { get; set; }
        public int EndorsNo { get; set; }
        public int RenewalNo { get; set; }
        public string ProductNo { get; set; }
        public ServiceResponse Results { get; set; }
    }
}
