using InitialPrefabs.Attributes.Messages;
using UnityEngine;

namespace InitialPrefabs.Examples {
    
    /// <summary>
    /// Shows examples of the Msg attribute. You should not modify the variable names directly
    /// because they are currently being used for GUI tests.
    /// </summary>
    public class MsgExample : MonoBehaviour {

        [Msg("I'm an integer field, with default settings!")]
        public int defaultMsg;

        [Msg("I'm a float field, with a custom message level!", MessageLevel.Info)]
        public float customMsg;

        [Msg("I'm a char field, with a custom message level and height!", MessageLevel.Error, 5)]
        public char customMsgHeight;
    }
}
