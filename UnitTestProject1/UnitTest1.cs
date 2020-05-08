using L41;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student st1 = new Student();
            Student st2 = new Student();
            Student st3 = new Student();
            Student.StudentRating(95);
            Student.StudentRating(76);
            Student.StudentRating(60);
            string student1Message = Student.StudentRating(95);
            string student2Message = Student.StudentRating(76);
            string student3Message = Student.StudentRating(60);
            Assert.AreEqual("Congratulations to A-student!", student1Message);
            Assert.AreEqual("You can study better", student2Message);
            Assert.AreEqual("You must pay more attention to education", student3Message);
        }
    }
}
