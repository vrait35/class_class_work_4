using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_work
{
    public class Person
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private int    _age;
        private bool   _gender;
        private static int ag2;
        public Person()
        {

        }
        static Person()
        {
            ag2 = 2;
        }
        public Person(string _firstname)
        {
            SetFirstName(_firstname);
        }
        //ctor ++tab2raza
        public void SetFirstName(string _firstName)
        {
            this._firstName = _firstName;
        }
        public string GetFirstName()
        {
            return _firstName;
        }
        public void SetMiddleName(string _middleName) {
            this._middleName = _middleName;
        }
        public string GetMiddleName()
        {
            return _middleName;
        }
        public void SetLastName(string _lastName)
        {
            this._lastName = _lastName;
        }
        public string GetLastName()
        {
            return _lastName;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetGender(bool _gender)
        {
            this._gender = _gender;
        }
        public bool GetGender()
        {
            return _gender;
        }
    }
}
