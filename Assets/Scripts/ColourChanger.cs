using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class ColourChanger : MonoBehaviour
    {
        //This Cube will CHANGE COLOURS when the "OnChangeColourEvent" is announced
        // CHANGE COLOURS means to move the cube to a new, random colour.
        private void OnEnable()
        {
            EventsManager.OnColourChangeEvent += ChangeColour;
        }

        private void OnDisable()
        {
            EventsManager.OnColourChangeEvent -= ChangeColour;
        }
        private void ChangeColour()
        {
            float redValue = Random.Range(0f, 1f);
            float greenValue = Random.Range(0f, 1f);
            float blueValue = Random.Range(0f, 1f);

            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue, greenValue, blueValue);
        }

    }
}

