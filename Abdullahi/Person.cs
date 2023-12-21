using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullahi
{
    class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Hair hairinfo { get; set; }
        public string Eyecolor { get; set; }

        public Person(string name, Gender gender, DateTime birthday, Hair hairInfo, string eyecolor) 
        {
            Name = name;
            Eyecolor = eyecolor;
            Gender = gender;
            Birthday = birthday;
            hairinfo= hairInfo;
        } 
        public override string ToString()
        {
            return 
            $"Namn:{Name}\n"+
            $"Kön: {Gender}\n"+ 
            $"Födelsedatum: {Birthday:yyyy/MM/dd}\n"+ 
            $"Hårfärg: {hairinfo.Color}\n"+
            $"Hårlängd: {hairinfo.Length}\n"+ 
            $"Ögonfärg: {Eyecolor}\n";
        }
    }

}
  