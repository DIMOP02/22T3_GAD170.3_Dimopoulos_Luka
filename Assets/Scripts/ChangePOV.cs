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
        public bool isMainCameraEnabled = false;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(CKey))
            {
                isMainCameraEnabled = !isMainCameraEnabled;
                MainCamera.gameObject.SetActive(isMainCameraEnabled);
                FrontCamera.gameObject.SetActive(!isMainCameraEnabled);
            }
        }
    }
}
