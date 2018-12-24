using InitialPrefabs.Attributes.Messages;
using UnityEngine;

namespace InitialPrefabs.Examples {

    /// <summary>
    /// Shows some examples of using the MsgToggle. You should not modify the variable names directly as 
    /// they are being used for GUI Tests.
    /// </summary>
    public class MsgToggleExample : MonoBehaviour {

        // NOTE: This is only used for getting a default property height in the editor.
        public bool defaultBool;

        [MsgToggle("Should show when true!", MessageLevel.Info)]
        public bool toggleMsg = true;

        [MsgToggle("Should show when false!", true, MessageLevel.Warning)]
        public bool invertedToggleMsg = false;

        [MsgToggle]
        public string invalidMsgToggle = "An error would show below.";
    }
}
