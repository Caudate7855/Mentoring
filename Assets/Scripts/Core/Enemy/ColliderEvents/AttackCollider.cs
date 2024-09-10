using System;
using UnityEngine;

namespace Scripts
{
    public class AttackCollider : MonoBehaviour
    {
        [SerializeField] private EnemyMelee _enemyMelee;

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<Wall>() != null)
            {
                _enemyMelee.StartAttack();
            }
        }
    }
}