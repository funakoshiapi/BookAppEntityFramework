namespace App.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Warrior Warrior { get; set; }
        public int WarriorId { get; set; }
    }
}