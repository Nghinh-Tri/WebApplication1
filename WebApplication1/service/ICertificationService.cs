using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ViewModel;

namespace WebApplication1.service
{
    public interface ICertificationService
    {
       public Task<ApiResult<List<ListCertificationViewModel>>> GetCertifications();
    }
}
