using System;
namespace TechJobsOOAutoGraded6
{
	public abstract class JobField
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; } //Is this right? (from other classes)
        public string Name { get; set; } //What about this? (from Job class)
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public JobField()
		{
            Id = nextId;
            nextId++;
        }

        // Can we have a constructor that assigns the Value field?
        public JobField(string value) : this()
        {
            Value = value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        //Custom Equals() is trickier (or is it?)
        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }

    }
}

