using System;
using System.Collections;
using System.Collections.Generic;
using _Main.C_Scripts.Tomi;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private PlayerAttack weapon;
    [SerializeField] private GameObject hitParticle;
    private static readonly int Hit = Animator.StringToHash("Hit");


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && weapon.isAttacking)
        {
            other.GetComponent<Animator>().SetTrigger(Hit);
            Debug.Log(other.name);
            Instantiate(hitParticle, new Vector3(other.transform.position.x, transform.position.y,
                other.transform.position.z), other.transform.rotation);
            
        }
    }
}
