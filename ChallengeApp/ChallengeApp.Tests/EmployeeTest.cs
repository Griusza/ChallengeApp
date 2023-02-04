namespace ChallengeApp.Tests
{
    public class Tests
    {
        
        [Test]
        public void WhenSomeNumberAreAdded_ShouldReturnSum()
        {
            // arrange

            var employee = new Employee("Andrzej", "Stefaniak", 37);
            employee.AddScore(3);
            employee.AddScore(6);
            employee.AddScore(2);
            employee.AddScore(4);
            employee.AddScore(-4);

            // act

            var score = employee.Score;

            // assert

            Assert.AreEqual(11, score);
        }
    }
}