using SMSApp_School_.Area.Admin.Model;

namespace SMSApp_School_.Area.Admin.Interface
{
    public interface IStaff
    {
        Task<List<StaffViewModel>> GetAllStaff();
        Task<List<StaffViewModel>> GetStaffById(int? id);
        Task<bool> InsertSraff(StaffViewModel model);
    }
}
