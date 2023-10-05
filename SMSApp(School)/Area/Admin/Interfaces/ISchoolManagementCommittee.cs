using SMSApp_School_.Area.Admin.Model;

namespace SMSApp_School_.Area.Admin.Interface
{
    public interface ISchoolManagementCommittee
    {
        Task<List<SchoolManagementCommitteeViewModel>> GetAllCommittee();
        Task<SchoolManagementCommitteeViewModel> GetCommitteeById(int? id);
        Task<bool>InsertCommittee(SchoolManagementCommitteeViewModel model);
    }
}
