using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class CubeActivator : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                Debug.Log("E has been pressed");
            }
        }
    }
}

