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
        //{
        //      TurnIntangible();
        //}
        private void TurnTangible()
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
        private void TurnIntangible()
        {
            // if the box collider is enabled...
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // ...disable the box collider
                block.GetComponent<BoxCollider>().enabled = true;
                // and change the material to "Intangible" material
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }
    }

}