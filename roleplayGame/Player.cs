namespace Player
{
    using Dice;
    class Player
    {
        private string name;
        private List<Dice> dices = new List<Dice>();

        public Player(string _name){
            this.name = _name;
        }

        public void addDice(Dice dice){
            this.dices.Add(dice);
        }
    }
}