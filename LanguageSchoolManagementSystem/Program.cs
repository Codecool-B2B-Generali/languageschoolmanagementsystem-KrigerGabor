using LanguageSchoolManagementSystem.Handlers;

namespace LanguageSchoolManagementSystem
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AppHandler app = new AppHandler();
            app.Run();
        }
    }
}
