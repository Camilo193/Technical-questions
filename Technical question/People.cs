using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_question
{
    public class People
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullNameWithString { get; set; }
        public StringBuilder? FullNameWithStringBuilder { get; set; }

        public IEnumerable<People> AppendWithString(IEnumerable<People> people)
        {
            string fullName = "";

            foreach (var person in people)
            {
                fullName = fullName + person.FirstName + " " + person.LastName + ", ";
            }

            return people;
        }

        public string AppendWithStringFormat(IEnumerable<People> people)
        {
            string fullName = "";

            foreach (var person in people)
            {
                fullName = String.Format($"{0} {1} {2}, ", fullName, person.FirstName, person.LastName);
            }
            return fullName;
        }

        public string AppendWithStringFormat2(IEnumerable<People> people)
        {
            string fullName = "";
            foreach (var person in people)
            {
                fullName = $"{fullName} {person.FirstName} {person.LastName}, ";
            }
            return fullName;
        }

        public IEnumerable<People> AppendWithStringBuilder(IEnumerable<People> people)
        {
            StringBuilder FullName = new StringBuilder();

            foreach (var person in people)
            {
                //FullName.Append(person.FirstName).AppendLine(LastName).Append(", ");
                FullName.AppendFormat($"{0} {1}, ", person.FirstName, person.LastName);
            }

            return people;
        }

        public void ConcatWithString(IEnumerable<People> people)
        {
            foreach (var person in people)
            {
                person.FullNameWithString = person.FirstName + " " + person.LastName;
                //person.FullNameWithString = String.Format($"{0}, {1}", person.FirstName, person.LastName);
            }
        }
        public void ConcatWithStringBuilder(List<People> people)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var person in people)
            {
                stringBuilder.Clear();
                person.FullNameWithStringBuilder = stringBuilder.Append(person.FirstName).Append(person.LastName);
            }
        }

    }
}
