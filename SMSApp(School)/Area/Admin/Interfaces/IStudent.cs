using SMSApp_School_.Area.Admin.Model;

namespace SMSApp_School_.Area.Admin.Interface
{
    public interface IStudent
    {
        Task<List<StudentViewModel>> GetAllStudent();
        Task<bool> GetStudentById(int? id);
    }
}
