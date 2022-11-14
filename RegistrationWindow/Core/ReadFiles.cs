using RegistrationWindow.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow.Core
{
    public static class ReadFiles
    {
        public static ObservableCollection<Teacher> ReadFilesOfTeaher()
        {
            var listTeacher = new ObservableCollection<Teacher>();

            using (StreamReader streamReader = new StreamReader(@"..\..\files\Teachers.txt"))
            {
                foreach (var item in streamReader.ReadToEnd().Split('\n'))
                {
                    var arrayStrings = item.Split(',');
                    if (arrayStrings[0] != "ID")
                    {
                        Teacher teacher = new Teacher()
                        {
                            ID = int.Parse(arrayStrings[0]),
                            FirstName = arrayStrings[1],
                            LastName = arrayStrings[2],
                            Login = arrayStrings[3],
                            Password = arrayStrings[4]
                        };
                        listTeacher.Add(teacher);
                    }
                }
            }
            return listTeacher;

        }

        public static ObservableCollection<Lessons> ReadFilesOfLessons()
        {
            var listLessons = new ObservableCollection<Lessons>();
            using (StreamReader streamReader = new StreamReader(@"..\..\files\Lesson.txt"))
            {
                foreach (var item in streamReader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split('?');
                    if (arrayString[0] != "ID")
                    {
                        Lessons lessons = new Lessons()
                        {
                            ID = int.Parse(arrayString[0]),
                            Name = arrayString[1]
                        };
                        listLessons.Add(lessons);
                    }
                }
            }
            return listLessons;
        }













    }
}
