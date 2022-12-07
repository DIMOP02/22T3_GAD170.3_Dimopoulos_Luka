using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukaDimopoulos
{
    public class EventsManager : MonoBehaviour
    {
        // This will contain ALL OF OUR EVENTS
        // event Delegates have two parts
        // the DELEGATE is the type of "event"
        // the EVENT itself, which gets "announced"

        // This is the TYPE of event we will call
        public delegate void VoidDelegate();

        // this is the EVENT itself
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnColourChangeEvent;
        public static VoidDelegate OnButtonBonkEvent;
    }
}



