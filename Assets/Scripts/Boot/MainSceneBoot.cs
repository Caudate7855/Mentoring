using System;
using UnityEngine;

namespace Scripts
{
    public class MainSceneBoot : MonoBehaviour
    {
        [SerializeField] private Ground _ground;
        [SerializeField] private Wall _wall;

        [SerializeField] private EnemySpawner _enemySpawner;
        [SerializeField] private EnemyMelee _enemyMelee;

        private void Start()
        {
            InitializeEnvironment();
            InitializeEnemySpawnSystem();
        }

        private void InitializeEnemySpawnSystem()
        {
            Instantiate(_enemySpawner);
        }

        private void InitializeEnvironment()
        {
            Instantiate(_ground);
            Instantiate(_wall);
        }
    }
}