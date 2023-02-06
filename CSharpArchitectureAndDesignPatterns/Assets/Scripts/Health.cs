using UnityEngine;
namespace Asteroids
{
    public sealed class Health
    {
        public float Max { get; }
        public float Current { get; private set; }

        public bool IsDead { get; private set; }

        public Health(float max, float current)
        {
            IsDead = false;
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }

        public void TakeDamge()
        {
            if (Current <= 0)
            {
                IsDead = true;
            }
            else
            {
                Current--;
            }
        }
    }
}