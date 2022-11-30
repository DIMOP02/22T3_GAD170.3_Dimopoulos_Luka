using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class ChangePOV : MonoBehaviour
    {
        public Transform Player;
        public Camera MainCamera, FrontCamera;
        public KeyCode CKey;
        public bool camSwitch = false;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(CKey))
            {
                camSwitch = !camSwitch;
                MainCamera.gameObject.SetActive(camSwitch);
                FrontCamera.gameObject.SetActive(!camSwitch);
            }
        }
    }
}
