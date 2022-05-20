using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.ResultModels
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(T data, string errormessage) : base(data, false, errormessage)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
        public ErrorDataResult(string errormessage) : base(default, false, errormessage)
        {

        }

    }
}
