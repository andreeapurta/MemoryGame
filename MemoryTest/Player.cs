namespace MemoryGame
{
    public class Player : Score
    {
        public string name;
        public bool move;

        public Player(string name, bool move)
        {
            this.name = name;
            this.move = move;
        }
    }
}