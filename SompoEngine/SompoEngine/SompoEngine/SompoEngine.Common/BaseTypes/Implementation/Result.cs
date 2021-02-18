using SompoEngine.Common.BaseTypes.Abstract;
using SompoEngine.Common.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Common.BaseTypes.Implementation
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message, Exception exceptionMessage)
        {
            ResultStatus = resultStatus;
            Message = message;
            ExceptionMessage = exceptionMessage;
        }
        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception ExceptionMessage { get; }
    }
}
