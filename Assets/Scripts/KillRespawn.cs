using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class KillRespawn : MonoBehaviour
    {
        public int Respawn;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}

