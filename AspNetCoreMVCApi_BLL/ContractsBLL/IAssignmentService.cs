using AspNetCoreMVCApi_EL.ResultModels;
using AspNetCoreMVCApi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_BLL.ContractsBLL
{
    public interface IAssignmentService
    {
    
        IResult Add(AssignmentVM assignment);
        IResult Delete(int assignmentId);
        IResult Update(int assignmentId , string newAssignment);
        IDataResult<AssignmentVM> GetById(int assignmentId);
        IDataResult<ICollection<AssignmentVM>> GetAll();
        IDataResult<AssignmentVM> GetFirstOrDefault();

    }
}
