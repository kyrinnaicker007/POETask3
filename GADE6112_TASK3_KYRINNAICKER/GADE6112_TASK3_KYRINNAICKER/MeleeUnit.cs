namespace GADE6112_TASK3_KYRINNAICKER
{
    class MeleeUnit:Unit
    {
        Map map;
        public MeleeUnit(int xpos, int ypos, int hp, int speed, int attack, int atkRange, string team, string symbol ): base(xpos,ypos,hp,speed,attack,atkRange,team,symbol)
        {

        }
        public int Xpos { get => xpos; set => xpos = value; }
        public int Ypos { get => ypos; set => ypos = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Attack { get => attack; set => attack = value; }
        public int AtkRange { get => atkRange; set => atkRange = value; }
        public string Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public override void Newpos(int xpos, int ypos, int newPosx, int newPosy)
        {
           if(newPosx <= 19 && xpos == Xpos )
            {
                Xpos = newPosx;
            }
           if(ypos <= 19 && Ypos == ypos)
            {
                Ypos = newPosy;
            }
        }

        public override void Combat(Unit[] unit, int xpos, int ypos)
        {
            for(int i =0; i < unit.Length; i++)
            {
                if(unit[i].Team != Team && unit[i].Xpos == xpos && unit[i].Ypos == ypos)
                {
                    unit[i].Hp -= Attack;
                    if(unit[i].Hp <=0)
                    {
                        string type = map.ArrUnit[i].GetType().ToString();//used casting for unit info 
                        string[] split = type.Split('.');
                        type = split[split.Length - 1];
                        map.ArrMap[unit[i].Ypos, unit[i].Xpos] = ".";
                    }
                }
            }
        }

        public override string ClosestUnit(Unit[] unit)
        {
           
            throw new System.NotImplementedException();
        }

        public override bool WithinAtkRange(int enemyX, int enemyY)
        {
            
            throw new System.NotImplementedException();
        }
        

        public override string toString()
        {
            throw new System.NotImplementedException();
        }
    }
}
