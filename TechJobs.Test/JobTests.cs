namespace TechJobs.Tests
{
    [TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here

        [TestMethod] //1
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreNotEqual(job2.Id, job1.Id, "Should NOT have same Id");
        }

        [TestMethod] //2
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Should have same NAME");
            Assert.AreEqual("ACME", job3.EmployerName.ToString(), "Should have same Employer Name");
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString(), "Should same Location");
            Assert.AreEqual("Quality control", job3.JobType.ToString(), "Should be same JobType");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString(), "Should be same JobCoreCompetency");
        }

        [TestMethod] //3
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job1.Id, job3.Id, "Should return false");
        }
        // public void TestMethod()

        //TODO: Task 4: remove this method before you create your first test method 

    }
}

