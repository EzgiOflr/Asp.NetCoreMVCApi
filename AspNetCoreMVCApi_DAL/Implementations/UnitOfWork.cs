using AspNetCoreMVCApi_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_DAL.Implementations
{
   public class UnitOfWork:IUnitOfWork
    {
        protected MyContext _myContext;
        public IAssignmentRepo AssignmentRepo { get; }

        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            AssignmentRepo = new AssignmentRepo(_myContext);
        }
    }
}
//3 kaç tane repo varsa o repoları bana tek bi yerde topla
