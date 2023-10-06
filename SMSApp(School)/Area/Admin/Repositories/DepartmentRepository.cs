using Microsoft.EntityFrameworkCore;
using SMSApp_School_.Area.Admin.Interface;
using SMSApp_School_.Area.Admin.Model;
using SMSApp_School_.Data;

namespace SMSApp_School_.Area.Admin.Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly SMSDbContext _context;
        public DepartmentRepository(SMSDbContext context)
        {
            _context = context;
        }
        public async Task<DepartmentViewModel> GetDepartmentById(int? id)
        {
            return await _context.Department.Where(x => x.Id == id).Select(x => new DepartmentViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                SubjectId = x.SubjectId,
                HOD = x.HOD,
            }).FirstOrDefaultAsync() ?? new DepartmentViewModel();
        }
        public async Task<List<DepartmentViewModel>> GetAllDepartment()
        {
            return await _context.Department.Select(x => new DepartmentViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                SubjectId = x.SubjectId,
                HOD = x.HOD,

            }).ToListAsync();
        }

        public async Task<bool> InsertDepartment(DepartmentViewModel model)
        {
            using (var transection = _context.Database.BeginTransaction())
            {
                if (model.Id > 0)
                {
                    var result = await _context.Department.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (result! == null)
                    {
                        result.SubjectId = model.SubjectId;
                        result.HOD = model.HOD;
                        result.Name = model.Name;
                        _context.Entry(result).State = EntityState.Modified;
                    }
                    else
                        return false;
                }
                else
                {
                    Department data = new Department()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        SubjectId = model.SubjectId,
                        HOD = model.HOD,
                    };
                    await _context.Department.AddAsync(data);
                }
                await _context.SaveChangesAsync();
                await transection.CommitAsync();

            }
            return true;
        }
    }
}


