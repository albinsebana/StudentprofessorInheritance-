using System;

namespace CLASSWORK
{
    internal class Proffessor
    {
        public int Id { get; internal set; }
        public string Address { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public int Salary { get; internal set; }

        internal void DisplayProfessorInfo()
        {
            throw new NotImplementedException();
        }
    }
}