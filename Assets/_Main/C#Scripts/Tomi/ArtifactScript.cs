using System;
using UnityEngine;

namespace _Main.C_Scripts.Tomi
{
    public class ArtifactScript : MonoBehaviour
    {
        //Artifact´s Rotation 
        [SerializeField] private Vector3 _rotation;
        [SerializeField] private float _speed;
        
        //Artifact´s Viewpoint references:
        //[SerializeField] private GameObject viewPoint;

       //Artifatc´s Particle VFX
       [SerializeField] private ParticleSystem pickUpParticle;
       
       // Artifact´s audio and game Object references:
       public GameObject artifact;
       [SerializeField] private AudioSource pickUpSound;
       

      void Update()
        {
            //Artifact´s Rotating Movement
         transform.Rotate((_rotation * (_speed * Time.deltaTime)));
        }

        private void OnTriggerEnter(Collider other)
        {
            //Collectable´s deactivation, collectable´s effect.
                Debug.Log("Artifatc Found!");
                pickUpSound.Play();
                artifact.SetActive(false);
               // viewPoint.SetActive(false);
                pickUpParticle.Play();
                
            
        }
    }
}
