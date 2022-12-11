using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class QuitButton : MonoBehaviour
    {
        // Start is called before the first frame update
        public void QuitVutton()
        {
            Application.Quit();
            print("Wow... I can't believe you have done this.");
        }
    }
}