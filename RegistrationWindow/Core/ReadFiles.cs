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
        public async static Task <ObservableCollection<Teacher>> ReadFilesOfTeaher()
        {
            var listTeacher = new ObservableCollection<Teacher>();

            using (StreamReader streamReader = new StreamReader(@"..\..\files\Teachers.txt"))
            {
                string asyncText = await streamReader.ReadToEndAsync();
                foreach (var item in asyncText.Split('\n'))
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

        public async static Task< ObservableCollection<Lessons>> ReadFilesOfLessons()
        {
            var listLessons = new ObservableCollection<Lessons>();
            using (StreamReader streamReader = new StreamReader(@"..\..\files\Lesson.txt"))
            {
                string asyncText = await streamReader.ReadToEndAsync();
                foreach (var item in asyncText.Split('\n'))
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
