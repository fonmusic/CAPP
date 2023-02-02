using UnityEngine;
namespace Asteroids
{
    internal sealed class Weapon : MonoBehaviour
    {
        public Rigidbody2D Bullet { get; }
        public Transform Barrel { get; }
        public float Forse { get; }

        public Weapon(Rigidbody2D bullet, Transform barrel, float forse)
        {
            Bullet = bullet;
            Barrel = barrel;
            Forse = forse;
        }


        public void Fire()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var temAmmunition = Instantiate(Bullet, Barrel.position, Barrel.rotation);
                temAmmunition.AddForce(Barrel.up * Forse);
            }
        }
    }
}