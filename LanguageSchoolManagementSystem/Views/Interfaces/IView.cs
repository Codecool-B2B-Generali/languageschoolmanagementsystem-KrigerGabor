using System.Collections.Generic;

namespace LanguageSchoolManagementSystem.Views
{
    public interface IView<T>
    {
        public void DisplayAll(List<T> entities);
        void DisplaySingle(T entity);
    }
}
