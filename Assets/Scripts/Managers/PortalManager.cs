using Player;
using UnityEngine;
using UnityEngine.Assertions.Must;

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
         
            _playerData.IsInPortal = true;
        }

        private void ChangeSize()
        {_playerData.ChangeSize();
        }

        private void OnTriggerExit(Collider other)
        {
         
            Invoke(nameof(ChangeSize),0.1f);
            _playerData.IsInPortal = false;
        }

        private void OnTriggerStay(Collider other)
        {
           
        }

     
    }
}
