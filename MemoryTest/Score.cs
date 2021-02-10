namespace MemoryGame
{
    public class Score
    {
        public int score;

        public Score()
        {
            score = 0;
        }

        public Score(int score)
        {
            this.score = score;
        }

        public void IncrementScore()
        {
            score += 100;
        }
    }
}