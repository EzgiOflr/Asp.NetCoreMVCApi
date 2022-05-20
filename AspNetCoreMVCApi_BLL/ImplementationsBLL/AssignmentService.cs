using AspNetCoreMVCApi_BLL.ContractsBLL;
using AspNetCoreMVCApi_DAL.Contracts;
using AspNetCoreMVCApi_EL.Models;
using AspNetCoreMVCApi_EL.ResultModels;
using AspNetCoreMVCApi_EL.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_BLL.ImplementationsBLL
{
   public class AssignmentService : IAssignmentService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssignmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IResult Add(AssignmentVM assignment)
        {
            try
            {
                Assignment newAssignment = _mapper.Map<AssignmentVM, Assignment>(assignment);
                var insertResult = _unitOfWork.AssignmentRepo.Add(newAssignment);
                return insertResult ?
                    new SuccessResult("Görev  eklendi.") :
                    new ErrorResult("Görev eklemede bir hata oluştu! Tekrar deneyiniz.");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IResult Delete(int assignmentId)
        {

            try
            {
                if (assignmentId > 0)
                {
                    var assignment = _unitOfWork.AssignmentRepo.GetById(assignmentId);
                    if (assignment == null)
                    {
                        throw new Exception("Hata : görev bulunamadığı için silme işlemi başarısızdır!");
                    }

                    var result = _unitOfWork.AssignmentRepo.Delete(assignment);
                    if (!result)
                    {
                        return new ErrorResult("HATA: Beklenmedik bir hata nedeniyle görev silme işlemi başarısızdır.");
                    }
                    return new SuccessResult("Görev silindi!");
                }
                else
                {
                    throw new Exception("HATA: assignmentId verisi istenilen formatta değildir!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<ICollection<AssignmentVM>> GetAll()
        {
            try
            {
                //Tamamlanmamış görevleri getirir.
                var assignments = _unitOfWork.AssignmentRepo.GetAll(x => !x.IsCompleted);

                ICollection<AssignmentVM> allAssignments = _mapper.Map<IQueryable<Assignment>, ICollection<AssignmentVM>>(assignments);

                return new SuccessDataResult<ICollection<AssignmentVM>>(allAssignments,
                    $"{allAssignments.Count} adet görev listelendi.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<AssignmentVM> GetById(int assignmentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AssignmentVM> GetFirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public IResult Update(int assignmentId, string newAssignment)
        {

            try
            {

                if (assignmentId > 0)
                {
                    var assignment = _unitOfWork.AssignmentRepo.GetById(assignmentId);
                    if (assignment == null)
                    {
                        throw new Exception("Hata : görev bulunamadığı için güncelleme başarısızdır!");
                    }
                    assignment.Description = newAssignment;
                    assignment.IsCompleted = false;
                    var result = _unitOfWork.AssignmentRepo.Update(assignment);
                    if (!result)
                    {
                        return new ErrorResult("HATA: Beklenmedik bir hata nedeniyle görev güncelleme işlemi başarısızdır.");
                    }
                    return new SuccessResult("Görev güncellendi!");
                }
                else
                {
                    throw new Exception("HATA: assignmentId verisi istenilen formatta değildir!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
