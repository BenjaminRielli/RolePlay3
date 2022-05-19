namespace RoleplayGame
{
    public abstract class Enemy : Character 
    {
        protected Enemy(string name): base(name){}
        public int VictoryPoint{get; set;}

    }
}