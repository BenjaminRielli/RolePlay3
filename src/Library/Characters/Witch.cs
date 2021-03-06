using System.Collections.Generic;
namespace RoleplayGame
{
    public class Witch: Enemy
    {
        private int health = 100;
        private int victoryPoint = 0;

        private List<IItem> items = new List<IItem>();

        public string Name { get; set; }

        public Witch(string name): base(name)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public int VictoryPoint { 
            get
            {
                return this.victoryPoint;
            }
            set 
            {
                this.victoryPoint = value < 0 ? 0 : value;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public override void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}