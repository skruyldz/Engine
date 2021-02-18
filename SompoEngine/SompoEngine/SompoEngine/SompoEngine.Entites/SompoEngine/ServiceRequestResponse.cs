using SompoEngine.BaseLogic.Data;
using SompoEngine.BaseLogic.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SompoEngine.Entites
{
    public partial class ServiceRequestResponse : EntityBase,IEntity
    {
        public int Id { get; set; }
        public string ProposalNo { get; set; }
        public int EndorsNo { get; set; }
        public int RenewalNo { get; set; }
        public string ProductNo { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJson { get; set; }
    }
}