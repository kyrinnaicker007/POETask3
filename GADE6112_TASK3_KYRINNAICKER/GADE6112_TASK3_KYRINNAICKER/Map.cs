using System;

namespace GADE6112_TASK3_KYRINNAICKER
{
    public class Map
    {
        Unit[] arrUnit;
        MeleeUnit meleeUnit;
        RangedUnit rangedUnit;
        private string[,] arrMap;

        public string[,] ArrMap { get => arrMap; set => arrMap = value; }

        internal Unit[] ArrUnit { get => arrUnit; set => arrUnit = value; }
        internal MeleeUnit MeleeUnit { get => meleeUnit; set => meleeUnit = value; }
        internal RangedUnit RangedUnit { get => rangedUnit; set => rangedUnit = value; }
    }
}
