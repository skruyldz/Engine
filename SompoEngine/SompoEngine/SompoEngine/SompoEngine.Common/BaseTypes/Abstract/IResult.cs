using SompoEngine.Common.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Common.BaseTypes.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception ExceptionMessage { get; }
    }
}
