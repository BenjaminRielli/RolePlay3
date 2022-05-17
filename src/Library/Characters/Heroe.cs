namespace RoleplayGame
{
    public abstract class Heroe : Character 
    {
        protected Heroe(string name): base(name){}
        int VictoryPoint{get; set;}

    }
}