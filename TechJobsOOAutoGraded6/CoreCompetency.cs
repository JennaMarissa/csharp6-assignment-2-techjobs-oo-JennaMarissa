using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency : JobField
	{
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public CoreCompetency()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public CoreCompetency(string value) : this()
        //{
        //    Value = value;
        //}

        public CoreCompetency(string value) : base(value)
        {
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is CoreCompetency corecompetency &&
        //           Id == corecompetency.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}

