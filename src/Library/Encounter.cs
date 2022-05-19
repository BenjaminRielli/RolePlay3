using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
        public List<Enemy> Enemies { get; } = new();

        public List<Heroe> Heroes { get; } = new();

        public void AddHeroe(Heroe h)
        {
            if (h.Health > 0)
            {
                Heroes.Add(h);
            }
        }

        public void AddEnemy(Enemy e)
        {
            if (e.Health > 0)
            {
                Enemies.Add(e);
            }
        }

        void DoEncounter()
        {
            while (Enemies.Count > 0 && Heroes.Count > 0)
            {
                for (int iEnemy = 0; iEnemy < Enemies.Count; iEnemy++)
                {
                    var heroe = Heroes[iEnemy % Heroes.Count];
                    heroe.ReceiveAttack(Enemies[iEnemy].AttackValue);
                    if (heroe.Health == 0)
                    {
                        Heroes.Remove(heroe);
                    }
                }


                foreach (var heroe in Heroes)
                {
                    var killedEnemies = new List<Enemy>();

                    foreach (var enemy in Enemies)
                    {
                        enemy.ReceiveAttack(heroe.AttackValue);
                        if (enemy.Health == 0)
                        {
                            heroe.VictoryPoint += enemy.VictoryPoint;
                            killedEnemies.Add(enemy);
                        }
                    }

                    foreach (var enemy in killedEnemies)
                    {
                        Enemies.Remove(enemy);
                    }
                }
            }

            foreach (var heroe in Heroes)
            {
                if (heroe.VictoryPoint >= 5)
                {
                    heroe.Cure();
                }
            }
        }
    }
}