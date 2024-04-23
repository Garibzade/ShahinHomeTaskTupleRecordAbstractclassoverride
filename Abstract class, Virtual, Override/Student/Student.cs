using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Student
{
    internal class Student
    {

        string _name;
        string _surname;
        int _age;

        static double _stip;


        public Student(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;

        }

        static Student()
        {

            _stip = 100;
        }


        public void GetInfo()
        {
            Console.WriteLine($"adi: {_name}\nsoy adi: {_surname}\nyasi: {_age}\nstipendiyasi: {_stip}");
        }

        public static void StipPlus(int bonus)
        {
            Console.WriteLine($"tebrikler siz bonus teqauq qazandiniz {_stip + bonus}");
        }

        public static void SayHi(string _name)
        {
            Console.WriteLine("salam " + _name);
        }
}
