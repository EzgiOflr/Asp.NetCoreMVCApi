using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.ResultModels
{
    public class Result:IResult
    {
        //field, prop,ctor,methot yazma sirasi böyledir.
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public Result(bool success)
        {
            IsSuccess = success;
        }
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
    }
}
