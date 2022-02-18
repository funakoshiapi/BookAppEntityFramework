using System.Collections.Generic;

namespace App.Domain
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Name { get; set; }
        public List<Warrior> Warriors { get; set; } = new List<Warrior>();
    }
}