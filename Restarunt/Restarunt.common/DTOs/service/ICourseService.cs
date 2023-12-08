using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.Courses;

namespace Restarunt.common.DTOs.service
{
    public interface ICourseService
    {
        Task<BaseResponse> Create(CreateCourseRequest request);

        Task<GetAllResponse> GetAll(GetAllRequest request);
    }
}