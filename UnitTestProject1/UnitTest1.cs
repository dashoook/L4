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
            Assert.AreEqual("Вiтаємо вiдмiнника!", student1Message);
            Assert.AreEqual("Можна вчитися краще", student2Message);
            Assert.AreEqual("Варто бiльше уваги придiляти навчанню", student3Message);
        }
    }
}
