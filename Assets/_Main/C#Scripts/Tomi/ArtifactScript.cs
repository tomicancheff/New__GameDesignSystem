using System;
using UnityEngine;

namespace _Main.C_Scripts.Tomi
{
    public class ArtifactScript : MonoBehaviour
    {
        //Artifact´s Rotation 
        [SerializeField] private Vector3 _rotation;
        [SerializeField] private float _speed;

       //Artifatc´s Particle VFX
       [SerializeField] private ParticleSystem pickUpParticle;

       public GameObject artifact;
       

      void Update()
        {
            //Artifact´s Rotating Movement
         transform.Rotate((_rotation * (_speed * Time.deltaTime)));
        }

        private void OnTriggerEnter(Collider other)
        {
            //Collectable´s deactivation, collectable´s effect.
                Debug.Log("Artifatc Found!");
                artifact.SetActive(false);
                pickUpParticle.Play();
            
        }
    }
}
