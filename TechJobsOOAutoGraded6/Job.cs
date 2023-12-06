using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

        // DONE TODO: Task 3: Add the two necessary constructors
            public Job()
            {
                Id = nextId;
                nextId++;
            }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            } 


        // DONE TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        // Environment.NewLine is universal new line syntax
        public override string ToString()
        {
            string Employ = EmployerName.ToString();
            string Loca = EmployerLocation.ToString();
            string Type = JobType.ToString();
            string Competent = JobCoreCompetency.ToString();

            if (string.IsNullOrEmpty(Employ))
                Employ = "Data not available";
            if (string.IsNullOrEmpty(Loca))
                Loca = "Data not available";
            if (string.IsNullOrEmpty(Type))
                Type = "Data not available";
            if (string.IsNullOrEmpty(Competent))
                Competent = "Data not available";

            return Environment.NewLine + $"ID: {Id} "
                + Environment.NewLine + $"Name: {Name} "
                + Environment.NewLine + $"Employer: {Employ} "
                + Environment.NewLine + $"Location: {Loca} "
                + Environment.NewLine + $"Position Type: {Type} "
                + Environment.NewLine + $"Core Competency: {Competent} "
                + Environment.NewLine;

        }

        //*/
    }
}

