namespace RoleplayGame
{
    public abstract class Heroe : Character 
    {
        protected Heroe(string name): base(name){}
        public int VictoryPoint{get; set;}
    }
}