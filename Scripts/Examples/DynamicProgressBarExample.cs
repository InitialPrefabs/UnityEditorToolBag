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

        [Tooltip("This is used for defining the max value of the progress bar.")]
        public float floatMax;

        [DynamicProgressBar("floatMax", "Float Value")]
        public float floatProgress;

        // TODO: Re-enable this
        public Health health;
    }
}
