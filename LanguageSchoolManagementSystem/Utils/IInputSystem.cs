namespace LanguageSchoolManagementSystem.Utils
{
    public interface IInputSystem
    {
        public string FetchStringValue(string prompt);
        public int FetchIntValue(string prompt);
    }
}
