using Microsoft.AspNetCore.Mvc;
using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.Courses;
using Restarunt.common.DTOs.service;
using Restarunt.common.Entities;

namespace Restarunt.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
       

        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _CourseService;
        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
         
        {
            _logger = logger;
            _CourseService = courseService;
        }

        [HttpPost(Name = "Create")]
        public async Task<BaseResponse> Create([FromBody] CreateCourseRequest request)
        {
            var response= await _CourseService.Create(request);
            return response;
        }

        [HttpPost(Name = "GetAll")]
        public async Task<GetAllResponse> GetAll([FromBody] GetAllRequest request)
        {
            var response = await _CourseService.GetAll(request);
            return response;
        }
    }
}
//knjaskaksk