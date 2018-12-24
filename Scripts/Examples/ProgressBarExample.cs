using InitialPrefabs.Attributes;
using UnityEngine;

namespace InitialPrefabs.Examples {

    /// <summary>
    /// Shows examples of progress bars. These are used for tests, so you should not modify the variable names directly,
    /// because they are being used for GUI Tests.
    /// </summary>
    public class ProgressBarExample : MonoBehaviour {

        // NOTE: This is a default field used for the tests.
        public float defaultFloat;
        
        [ProgressBar("Int")]
        public int intValue;

        [ProgressBar(25, "Float")]
        public float floatValue;

        [ProgressBar(1000, "This shouldn't work")]
        public string invalidField;
    }
}
