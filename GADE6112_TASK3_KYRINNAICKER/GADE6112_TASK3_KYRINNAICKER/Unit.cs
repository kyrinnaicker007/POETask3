namespace GADE6112_TASK3_KYRINNAICKER
{
    abstract class Unit
    {
        //created a set of values for the ranged and meleeunit classes to inherit
        protected int xpos;
        protected int ypos;
        protected int hp;
        protected int speed;
        protected int attack;
        protected int atkRange;
        protected string team;
        protected string symbol;


        //created accesssors for the ranged and meleeunit class
        public int Xpos { get => xpos; set => xpos = value; }
        public int Ypos { get => ypos; set => ypos = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Attack { get => attack; set => attack = value; }
        public int AtkRange { get => atkRange; set => atkRange = value; }
        public string Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public Unit(int xpos, int ypos, int hp, int speed, int attack, int atkRange, string team, string symbol )
        {
            this.xpos = xpos;
            this.ypos = ypos;
            this.hp = hp;
            this.speed = speed;
            this.attack = attack;
            this.atkRange = atkRange;
            this.team = team;
            this.symbol = symbol;
        }

        public abstract void Newpos(int xpos, int ypos, int newPosx, int newPosy);




        public abstract void Combat(Unit[] unit, int xpos, int ypos);




        public abstract string ClosestUnit(Unit[] unit);




        public abstract bool WithinAtkRange(int enemyX, int enemyY);

        public abstract string toString();

        
        

        

        ~Unit()
        {

        }

       
        
    }
}
