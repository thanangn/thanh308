using System;
using System.Collections.Generic;
using System.Text;

namespace GOGOGO
{
    public class CAR
    {
        public float Speed;
        public float AttackPower;
        public float DefencePower;
        public float HP;

        public CAR(float speed, float hp , float attackPower, float defencePower)
        {
            this.Speed = speed;
            this.AttackPower = attackPower;
            this.DefencePower = defencePower;
            this.HP = hp;
        }

        public float Position = 0f;


        public void Run(float time)
        {
            Position = Speed * time;
        }


        public void Attack(CAR target)
        {
            target.HP -= DamageCalculator.CaclDamage(this, target);
        }

        public class DamageCalculator
        {
            public static float CaclDamage(CAR attacker, CAR target)
            {
                float damage = attacker.AttackPower - target.DefencePower;
                if (damage < 1f)
                    damage = 1f;

                return damage;
            }
        }

        
        
    }
}
