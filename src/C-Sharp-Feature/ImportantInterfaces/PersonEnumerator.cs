using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class PersonEnumerator : IEnumerator<Person>
    {
        private Person[] _persons;
        private int _current;
        public Person Current => _persons[_current];

        object IEnumerator.Current => _persons[_current];


        public PersonEnumerator(Person[] person)
        {
            _current = -1;
            _persons = person;
        }



        public void Dispose()
        {
            _persons = null;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < _persons.Length;
        }

        public void Reset()
        {
            _current = -1; 
        }
    }
}
