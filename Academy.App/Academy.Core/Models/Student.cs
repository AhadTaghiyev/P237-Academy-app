
namespace Academy.Core.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public string Education { get; set; }

        public Student(string name, string surname, string group, string education)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Education = education;
        }

        public string GetFullInfo()
        {
            return $"Name:{Name} Surname:{Surname} Group:{Group} Educatinon:{Education}";
        }
    }
}
