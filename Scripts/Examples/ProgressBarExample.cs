using InitialPrefabs.Attributes;
using UnityEngine;

namespace InitialPrefabs.Examples {

    /// <summary>
    /// Shows examples of progress bars.
    /// </summary>
    public class ProgressBarExample : MonoBehaviour {
        
        [ProgressBar("Int")]
        public int intValue;

        [ProgressBar(25, "Float")]
        public float floatValue;
    }
}
