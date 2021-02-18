using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.Common.BaseTypes.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }
    }
}
