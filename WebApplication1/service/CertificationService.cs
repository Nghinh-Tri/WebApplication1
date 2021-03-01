using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EF;
using WebApplication1.ViewModel;

namespace WebApplication1.service
{
    public class CertificationService : ICertificationService
    {
        private readonly ESMSDbContext _context;

        public CertificationService(ESMSDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<ListCertificationViewModel>>> GetCertifications()
        {
            var query = from c in _context.Certifications
                        select new { c };
            var data = await query.Select(x => new ListCertificationViewModel()
            {
                CertificationID = x.c.CertificationID,
                CertificationName = x.c.CertificationName
            }).ToListAsync();

            return new ApiSuccessResult<List<ListCertificationViewModel>>(data);
        }
    }
}
