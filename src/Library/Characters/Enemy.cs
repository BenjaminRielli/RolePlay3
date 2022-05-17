namespace RoleplayGame
{
    public abstract class Enemy : Character 
    {
        protected Enemy(string name): base(name){}
        int VictoryPoint{get; set;}

    }
}