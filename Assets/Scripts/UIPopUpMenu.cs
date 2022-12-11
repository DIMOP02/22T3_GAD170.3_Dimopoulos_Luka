using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class UIPopUpMenu : MonoBehaviour
    {
        public GameObject UIPopUpMessage;
        public static bool PopUp = false;
        // Start is called before the first frame update
        void Start()
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (PopUp)
                {
                    Play();

                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Play()
        {
            UIPopUpMessage.SetActive(false);
            PopUp = false;
        }
    }
}

