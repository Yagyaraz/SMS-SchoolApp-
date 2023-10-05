using SMSApp_School_.Area.Admin.Model;

namespace SMSApp_School_.Area.Admin.Interface
{
    public interface IDepartment
    {
        Task<List<DepartmentViewModel>> GetAllDepartment();
        Task<DepartmentViewModel> GetDepartmentById(int? id);
        Task<bool> InsertDepartment(DepartmentViewModel model);

    }
}
