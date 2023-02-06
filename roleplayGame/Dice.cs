namespace Dice
{
    class Dice
    {
        private int min;
        private int max;
        private string name; 

        public Dice(string _name,int _min, int _max){
            this.name = _name;
            this.min = _min;
            this.max = _max;
        }

        public void setMin(int _min){
            this.min = _min;
        }

        public void setMax(int _max){
            this.min = _max;
        }

        public string getDiceName(){
            return this.name;
        }

        public int diceValue(){
            Random number = new Random();
            return number.Next(this.min, this.max);
        } 
    }
}