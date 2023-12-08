using Microsoft.Identity.Client;
using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.Courses;
using Restarunt.common.DTOs.service;
using Restarunt.common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restarunt.Services
{
    public class CourseService : ICourseService
    {
        public readonly ICourseRepository _CourseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _CourseRepository = courseRepository;
        }
        public async Task<BaseResponse>Create(CreateCourseRequest request)
        {
            BaseResponse response = new BaseResponse();
            try
            {
           response.Success= await _CourseRepository.Create(new common.Entities.Course() { 
                Name=request.Name,
                DurationInDays=request.DurationInDays,
                TotalFees=request.TotalFees,
                CreatedById=0,
                UpdatedById=null,
                CreatedDateTime=DateTime.Now,
               UpdatedDateTime = null,

           });
 
                return response;
            }
            catch(Exception exp) 
            {
                throw;
            }


        }


        public async Task<GetAllResponse> GetAll(GetAllRequest request)
        {
            GetAllResponse response = new GetAllResponse();
            try
            {
                response.Data = await _CourseRepository.GetAll(request);

                return response;
            }
            catch (Exception exp)
            {
                throw;
            }


        }


    }


}
