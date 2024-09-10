using UnityEngine;

namespace Scripts
{
    public class Wall : MonoBehaviour
    {
        private int Health = 100;
        
        public void TakeDamage(int damage)
        {
            Health -= damage;
            
            Debug.Log($"- {damage} HP");

            if (Health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            Destroy(gameObject);
        }
    }
}