using AspNetCoreMVCApi_DAL.Contracts;
using AspNetCoreMVCApi_EL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_DAL.Implementations
{
    public class AssignmentRepo : RepositoryBase<Assignment, int>, IAssignmentRepo
    {
    
        public AssignmentRepo(MyContext myContext) : base(myContext)
        {
            //generate 
        }
    }


}

//2


