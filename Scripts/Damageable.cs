using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
        [SerializeField] private int maxHealth;
        [SerializeField] private int health;

        private void Awake()
        {
                health = maxHealth;
        }

        public void OnHit(int damage)
        {
                if (health > 0)
                {
                        health -= damage;
                }
        }

        public void OnRepair(int repairPoints)
        {
                if (health > 0 && health < maxHealth)
                {
                        health += repairPoints;
                }
        }
}
