using InitialPrefabs.Attributes;
using UnityEngine;

namespace InitialPrefabs.Examples {
    
    [System.Serializable]
    public struct Health {

        public int max;
        [DynamicProgressBar("max", "Health")]
        public int current;
    }

    public class DynamicProgressBarExample : MonoBehaviour {

        // NOTE: This also serves as the default field!
        [Tooltip("This is used for defining the max value of the progress bar.")]
        public float floatMax;

        // The string must match the variable in the same class.
        [DynamicProgressBar("floatMax", "Float Value")]
        public float floatProgress;

        public Health health;
    }
}
