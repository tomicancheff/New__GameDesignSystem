using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
        [SerializeField] private ActorStats _actorStats;
        private int _currentLife;

        public int MaxLife => _actorStats.MaxLife;
        public int CurrentLife => _currentLife;

        private void Start()
        {
            _currentLife = _actorStats.MaxLife;
        }

        public virtual void TakeDamage(int damage)
        {
            _currentLife -= damage;
            Debug.Log($"{name} Remaining life {_currentLife}");
           
            if (_currentLife <= 0)
            {
                Die();
            }
        }

        public virtual void Die()
        {
            Destroy(gameObject);
        }
}
