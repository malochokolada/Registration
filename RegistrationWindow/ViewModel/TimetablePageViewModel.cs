using RegistrationWindow.Core;
using RegistrationWindow.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow.ViewModel
{
    public class TimetablePageViewModel : BaseViewModel
    {
        private ObservableCollection<Lessons> _lessonsList;
        private ObservableCollection<Teacher> _teachersList;
        private ObservableCollection<string> _lessonsInfo;

        public ObservableCollection<Lessons> Lessons
        {
            get => _lessonsList;
            set
            {
                _lessonsList = value;
                OnPropertyChanged(nameof(Lessons));
            }
        }

        public ObservableCollection<Teacher> TeachersList
        {
            get => _teachersList;
            set
            {
                _teachersList = value;
                OnPropertyChanged(nameof(TeachersList));
            }
        }

        public async void FileReader()
        {
            Lessons = await ReadFiles.ReadFilesOfLessons();
            TeachersList = await ReadFiles.ReadFilesOfTeaher();
        }

        public  ObservableCollection<string> LessonsInfo
        {
            get => _lessonsInfo;
            set
            {
                _lessonsInfo = value;
                OnPropertyChanged(nameof(LessonsInfo));
            }
        }

        public void ListViewFill(object TeacherSelected, object LessonSelected)
        {
            if (TeacherSelected != null && LessonSelected != null)
            {
                string info = (TeacherSelected as Teacher).FirstName + " " + ( TeacherSelected as Teacher).LastName + ", " + (LessonSelected as Lessons).Name;
                _lessonsInfo.Add(info);
            }
        }


        public TimetablePageViewModel()
        {
            _lessonsList = new ObservableCollection<Lessons>();
            _teachersList = new ObservableCollection<Teacher>();
            _lessonsInfo = new ObservableCollection<string>();
        }

    }
}
