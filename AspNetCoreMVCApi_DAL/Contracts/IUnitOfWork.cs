using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_DAL.Contracts
{
    public interface IUnitOfWork
    { 
        //kaç tane repo varsa hepsinin birleştirecek birim.
     IAssignmentRepo AssignmentRepo { get; }
    }
}
