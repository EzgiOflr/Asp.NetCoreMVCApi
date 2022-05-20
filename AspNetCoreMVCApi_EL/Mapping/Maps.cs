using AspNetCoreMVCApi_EL.Models;
using AspNetCoreMVCApi_EL.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMVCApi_EL.Mapping
{
    public class Maps :Profile
    {
        public Maps()
        {
            CreateMap<AssignmentVM, Assignment>().ReverseMap();
        }
    }

}
