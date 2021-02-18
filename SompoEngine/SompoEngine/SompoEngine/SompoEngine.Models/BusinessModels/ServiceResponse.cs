using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Models
{
    public class ServiceResponse
    {
        public List<ServiceResult> Results { get; set; }
    }
    public class ServiceResult
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
    public class Status
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
