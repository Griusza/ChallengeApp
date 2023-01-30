namespace ChallengeApp
{
    internal class Employee
    {
        private int score;

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.score = 0;
        }

        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }
        public int Score
        {
            get
            {
                return score;
            }
        }


        public void AddScore(int score)
        {
            this.score += score;
        }
    }
}
