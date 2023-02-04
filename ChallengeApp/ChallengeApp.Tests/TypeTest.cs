namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void ComparisonValueType_Int()
        {
            // arrange

            int number1 = 2;
            int number2 = 2;

            // act

            // assert

            Assert.AreEqual(number1, number2);
        }
        
        [Test]
        public void ComparisonValueType_Float()
        {
            // arrange

            float number1 = 1.01f;
            float number2 = 11.04f;

            // act

            // assert

            Assert.AreNotEqual(number1, number2);

        }
        
        [Test]
        public void Comparison_String()
        {
            // arrange

            string number1 = "Andrzej";
            string number2 = "Andrzej";

            // act

            // assert

            Assert.AreEqual(number1, number2);
        }
        
        [Test]
        public void ComparisonReferenceType()
        {
            // arrange

            var employee1 = new Employee("Andrzej","Stefaniak", 37);
            var employee2 = new Employee("Andrzej","Stefaniak", 37);
           

            // act

            // assert

            Assert.AreNotEqual(employee1, employee2);
        }
    }
}
