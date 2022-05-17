namespace RoleplayGame
{
    public abstract class MagicCharacter: Heroe
    {
        protected MagicCharacter(string name): base(name){}

        public abstract void AddItem(IMagicalItem item);

        public abstract void RemoveItem(IMagicalItem item);
    }
}
