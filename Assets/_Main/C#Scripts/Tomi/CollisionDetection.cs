using UnityEngine;

namespace _Main.C_Scripts.Tomi
{
    public class CollisionDetection : MonoBehaviour
    {
        [SerializeField] private PlayerAttack weapon;
        [SerializeField] private GameObject hitParticle;
        private static readonly int Hit = Animator.StringToHash("Hit");

        [SerializeField] private int attackDamage = 20;
        [SerializeField] private AudioClip hitEnemySound;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy") && weapon.isAttacking)
            {
                other.GetComponent<Animator>().SetTrigger(Hit);
                other.GetComponent<Enemy>().TakeDamage(attackDamage);
                AudioSource enemySound= GetComponent<AudioSource>();
                enemySound.PlayOneShot(this.hitEnemySound);
                Debug.Log(other.name);
                Instantiate(hitParticle, new Vector3(other.transform.position.x, transform.position.y,
                    other.transform.position.z), other.transform.rotation);
            
            }
        }
    }
}
