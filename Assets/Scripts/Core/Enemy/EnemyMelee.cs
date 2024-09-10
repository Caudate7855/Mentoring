using System.Collections;
using UnityEngine;

namespace Scripts
{
    public class EnemyMelee : MonoBehaviour
    {
        public Wall Wall;

        [SerializeField] private int _health;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _attackSpeed;
        [SerializeField] private int _damage;

        private bool _isWallReached;
        
        private void Update()
        {
            if (!_isWallReached)
            {
                Move();
            }
        }

        private void Move()
        {
            var transformPosition = transform.position;
            transformPosition.x -= _moveSpeed * Time.deltaTime;

            transform.position = transformPosition;
        }

        public void StartAttack()
        {
            _isWallReached = true;   
            StartCoroutine(DealDamage());
        }

        private IEnumerator DealDamage()
        {
            var attackDelayNormalized = 1 / _attackSpeed;

            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(attackDelayNormalized);
                
                Wall.TakeDamage(_damage);
            }
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
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