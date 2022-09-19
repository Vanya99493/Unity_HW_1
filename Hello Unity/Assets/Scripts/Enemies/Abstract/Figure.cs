using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public abstract class Figure : MonoBehaviour, IDamagable<int>
    {
        public int HealthPoints { get; private set; }

        public void SetHealthPoints(int healthPoints)
        {
            HealthPoints = healthPoints;
        }

        public void Damage(int damage)
        {
            HealthPoints -= damage;
            if(HealthPoints <= 0)
            {
                Destroy(gameObject);
                Destroyed();
            }
        }

        protected abstract string Destroyed();
    }
}