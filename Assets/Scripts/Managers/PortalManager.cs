using Player;
using UnityEngine;

namespace Managers
{
    public class PortalManager : MonoBehaviour
    {
        private PlayerInfo _playerData;

       

        public void Start()
        {
           
            _playerData =  GameObject.Find("Player").GetComponent<PlayerInfo>() as PlayerInfo;
            
        }

        private void OnTriggerEnter(Collider other)
        {
         
            _playerData.ChangeSize();
            _playerData.FirstTimeInPortal = !_playerData.FirstTimeInPortal;

        }

        private void OnTriggerExit(Collider other)
        {
         
          
      
        
            Debug.Log("salio");
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("stay");
            _playerData.FirstTimeInPortal = _playerData.FirstTimeInPortal;
        }
    }
}
