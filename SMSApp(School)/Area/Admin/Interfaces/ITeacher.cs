using SMSApp_School_.Area.Admin.Model;

namespace SMSApp_School_.Area.Admin.Interface
{
    public interface ITeacher
    {
        Task<List<TeacherViewModel>> GetAllTeachers();
        Task<TeacherViewModel> GetTeacherById(int id);
        Task<bool>InsertTeacher(TeacherViewModel model);

    }
}
