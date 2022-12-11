using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LukaDimopoulos
{
    public class TransientBlock : MonoBehaviour
    {
        /* 1. Find block
           2. Check what state the block is in
              - If state is tangible, set to intangible
                  - Disable box collider component
                  - Change material to “TransientBlock - Intangible” material
              - Else state is intangible, set to tangible
                  - Enable box collider component
                  - Change material to “TransientBlock - Tangible” material
        */

        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        // We dont want the blocks to turn tnagible on Start...
        // We want them to turn tangible when the SWITCH IS TRIGGERED
        //private void Start()

        // TURN OFF AFTER X SECONDS
        // ? needs a timer
        // - make counter countdown to zero
        // - needs to check if timer has run out
        // - turns intangible after the timer has run out
        // have a way to reset the timer

        [SerializeField] private float intangibilityCountdownTimer = 8f;
        [SerializeField] private float intangibilityCountdownTimerReset = 8f;

        private void OnEnable()
        {
            EventsManager.OnButtonBonkEvent += TurnTangible;
        }

        private void OnDisable()
        {
            EventsManager.OnButtonBonkEvent -= TurnTangible;
        }

        private void Update()
        {
            intangibilityCountdownTimer -= Time.deltaTime;

            if(intangibilityCountdownTimer < 0 && block.GetComponent<BoxCollider>().enabled == true)
            {
                TurnIntangible();
                Debug.Log("Floors have disappeard...");
            }
        }
        private void TurnIntangible()
        {
            // if the box collider is enabled...
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                // ...disable the box collider
                block.GetComponent<BoxCollider>().enabled = false;
                // and change the material to "Intangible" material
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
        }
        private void TurnTangible()
        {
            // if the box collider is disabled...
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // ...enable the box collider
                block.GetComponent<BoxCollider>().enabled = true;
                // and change the material to "Tangible" material
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }

            intangibilityCountdownTimer = intangibilityCountdownTimerReset;

        }
    }

}