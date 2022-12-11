using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class TransientBlockActivator : MonoBehaviour
    {
        [SerializeField] private bool isPlayerCharacterNearby = false;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearby = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if(other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearby = false;
            }
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNearby == true)
            {
                EventsManager.OnButtonBonkEvent?.Invoke();
                Debug.Log("E has been pressed");
            }
        }
    }
}

