using System;
using UnityEngine;
using UnityEngine.AI;

namespace _Main.C_Scripts.Tomi
{
    public class Enemy : MonoBehaviour
    {
        // A script for Basic enemy damage component and Animations.
        //The final boss Script should be made apart from  this one.
        [SerializeField] private Animator animator;

        [SerializeField] private int maxHealth = 100;
        [SerializeField] private int currentHealth = 100;


        private void Start()
        {
            currentHealth = maxHealth;
        }


        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            
            
            if (currentHealth <= 0)
            {
                Die();
            }

           
        }
        
        
        void Die()
        {
                Debug.Log("Knight Destroyed!");
                
                //Die Animation
                
                gameObject.SetActive(false);
            

        }
    }
}
