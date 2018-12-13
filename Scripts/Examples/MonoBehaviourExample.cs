using InitialPrefabs.Attributes.Messages;
using UnityEngine;

namespace InitialPrefabs.Examples {

    public class MonoBehaviourExample : MonoBehaviour {
        
        [Msg("I'm an integer field, with default settings!")]
        public int intMsg;

        [Msg("I'm a float field, with a custom message level!", MessageLevel.Info)]
        public float floatMsg;
        
        [Msg("I'm a char field, with a custom message level and height!", MessageLevel.Warning, 5)]
        public char charMsg;
    }
}
