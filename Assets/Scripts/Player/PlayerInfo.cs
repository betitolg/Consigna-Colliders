using System;
using UnityEngine;

namespace Player
{
    public class PlayerInfo : MonoBehaviour
    {
        public bool FirstTimeInPortal { get; set; }

        public void Start()
        {
            FirstTimeInPortal = true;
        }

        public void ChangeSize()
        {

            if (FirstTimeInPortal)
            {
                transform.localScale = transform.localScale * 1.5f;
            }
            else
            {   transform.localScale = transform.localScale / 1.5f;
            }


        }


    }
}