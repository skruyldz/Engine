using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Models.BusinessModels
{
    public class ServiceRequest
    {
        public Authentications Authentication { get; set; }

        public Objects Object { get; set; }

        public class Authentications
        {
            public string Source { get; set; }
            public string Key { get; set; }
        }

        public class Objects
        {
            public long ProposalNo { get; set; }
            public int EndorsNo { get; set; }
            public int RenewalNo { get; set; }
            public string ProductNo { get; set; }
        }
    }
}
