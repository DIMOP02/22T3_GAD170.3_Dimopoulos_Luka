using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace LukaDimopoulos
{
    public class StartMenuButtons : MonoBehaviour
    {
        public UnityEvent unityEvent = new UnityEvent();
        public GameObject button;
        void Start()
        {
            button = this.gameObject;
            AudioListener.volume = 1f;
        }

        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Input.GetMouseButtonDown(0))
            {
                if(Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    unityEvent.Invoke();
                    AudioListener.volume = 0f;
                }
            }

        }
    }
}


