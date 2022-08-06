using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Wall
{
    public class WallCollision : MonoBehaviour
    {

        private float _timeInWall = 0;


        [SerializeField] [Range(2, 10)] private float coolDown=2f;
        
        
        private void OnCollisionEnter(Collision collision)
        {
            _timeInWall = 0;
        }

        private void OnCollisionExit(Collision other)
        {
            
        }

        private void OnCollisionStay(Collision collisionInfo)
        { 
            _timeInWall += Time.deltaTime;

            double TOLERANCE=0.1f;
            if (Math.Abs(_timeInWall - coolDown) < TOLERANCE)
            {
                
                ChangeLocation();
            }
            
        }

        private void ChangeLocation()
        {
            float x = Random.Range(-2, 1);
            float z = Random.Range(-5,5);
            float rotation = Random.Range(-10, 10);
            
            
            transform.localPosition = new Vector3(x, transform.localPosition.y, z);

            transform.localRotation = Quaternion.Euler(0, rotation, 0);


        }
    }
}