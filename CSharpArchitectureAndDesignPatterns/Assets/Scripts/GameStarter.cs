using UnityEngine;
using Asteroids.Object_Pool;

namespace Asteroids
{
    public class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            #region Factory Method
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            #endregion

            #region Factory Method with Interface
            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));
            #endregion

            #region Factory Static Method
            Enemy.Factory = factory;
            Enemy.Factory.Create(new Health(100.0f, 100.0f));
            #endregion

            #region Pool
            EnemyPool enemyPool = new EnemyPool(10);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
            #endregion

        }
    }
}