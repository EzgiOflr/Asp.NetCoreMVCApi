using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.ResultModels
{
   public class SuccessResult:Result
    {
        //public SuccessResult(bool success= true) : base(success)
        //{

        //}
        public SuccessResult() : base(true)
        {

        }
        public SuccessResult(string message) : base(true, message)
        {

        }
    }
}
