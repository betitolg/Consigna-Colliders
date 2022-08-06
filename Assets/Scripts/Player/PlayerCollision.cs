using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerCollision : MonoBehaviour
    {
        private PlayerInfo _playerData;
        void Start()
        {
            _playerData =  GameObject.Find("Player").GetComponent<PlayerInfo>() as PlayerInfo;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCollisionEnter(Collision collision)
        {

   
            
            BoxCollider c = GameObject.Find(collision.gameObject.name).GetComponent<BoxCollider>();
            
            if ((c !=null) && _playerData.IsInPortal)
            {
                
                Debug.Log("Empezando a colisionar con Portal  y tiene Shrinker");
            }
            else
            {
                Debug.Log("Empezando a colisionar con " + collision.gameObject.name + " sin Shrinker");
            }




         
        
      
        
        }

        private void OnCollisionExit(Collision other)
        {
        
        }

        private void OnCollisionStay(Collision collisionInfo)
        {
        
        }
    }
}
