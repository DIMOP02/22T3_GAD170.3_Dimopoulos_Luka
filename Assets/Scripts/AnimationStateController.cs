using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class AnimationStateController : MonoBehaviour
    {
        Animator animator;
        int isWalkingHash;
        public KeyCode WKey;
        // Start is called before the first frame update
        void Start()
        {
            Animator animator = GetComponent<Animator>();
            isWalkingHash = Animator.StringToHash("isWalking");
        }

        // Update is called once per frame
        void Update()
        {
            bool isWalking = animator.GetBool(isWalkingHash);
            bool forwardPressed = Input.GetKey(WKey);
            //  if player presses w key...
            if (!isWalking && forwardPressed)
            {
                //  ... then set the isWalking boolean to be true
                animator.SetBool(isWalkingHash, true);
            }

            // if player is not pressing w...
            if (isWalking && !forwardPressed)
            {
                // then set the isWalking boolean to be false
                animator.SetBool(isWalkingHash, false);
            }
        }
    }
}

