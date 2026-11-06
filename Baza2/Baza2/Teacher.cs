using System.Linq;

namespace Baza2
{
    partial class Teacher
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Subjects.Count()} przedmioty)";
        }
    }
}
