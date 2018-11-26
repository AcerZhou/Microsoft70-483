using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft70_483
{
    public class IEnumberableExample
    {

    }

    class PersonI
    {
        public PersonI(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    class PersonIE : IEnumerable<PersonI>
    {

        public PersonIE(PersonI[] people)
        {
            this.people = people;
        }
        PersonI[] people;
        public IEnumerator<PersonI> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}
