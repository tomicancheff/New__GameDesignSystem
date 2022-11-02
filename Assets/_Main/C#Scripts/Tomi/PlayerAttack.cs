using System;
using System.Collections;
using UnityEngine;

namespace _Main.C_Scripts.Tomi
{
    public class PlayerAttack : MonoBehaviour
    {
        public GameObject hand;
     
        
        //WEAPONS HOLDER
        // public GameObject warHammer;
        // public GameObject longSword;
        // public GameObject mace;
        // public GameObject spear;
        // public GameObject crossbow;
        
        //WEAPON ATTACK  TRIGGER
        public bool canAttack = true;
        public float attackCoolDown = 1.0f;
        private static readonly int Attack = Animator.StringToHash(("Attack"));


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (canAttack)
                {
                    AxeAttack();
                    HammerAttack();
                        SwordAttack();
                        MaceAttack();
                        SpearAttack();
                }
            }
        }
        //DIFFERENT WEAPON ATTACKS---------------------------------------

        // ReSharper disable Unity.PerformanceAnalysis
        private void AxeAttack()
        {
            canAttack = false;
            Animator anim = hand.GetComponent<Animator>();
            anim.SetTrigger(Attack);
            StartCoroutine(ResetAttackCoolDown());

        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void HammerAttack()
        {
            canAttack = false;
            Animator anim = hand.GetComponent<Animator>();
            anim.SetTrigger(Attack);
            StartCoroutine(ResetAttackCoolDown());
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        private void SwordAttack()
        {
            canAttack = false;
            Animator anim = hand.GetComponent<Animator>();
            anim.SetTrigger(Attack);
            StartCoroutine(ResetAttackCoolDown());
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        private void MaceAttack()
        {
            canAttack = false;
            Animator anim = hand.GetComponent<Animator>();
            anim.SetTrigger(Attack);
            StartCoroutine(ResetAttackCoolDown());
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        private void SpearAttack()
        {
            canAttack = false;
            Animator anim = hand.GetComponent<Animator>();
            anim.SetTrigger(Attack);
            StartCoroutine(ResetAttackCoolDown());
        }

        //COROUTINE FOR RESET ATTACK TRIGGER
        IEnumerator ResetAttackCoolDown()
        {
            yield return new WaitForSeconds(attackCoolDown);
            canAttack = true;
        }
        
    }
}
