using InitialPrefabs.Attributes;
using UnityEngine;

namespace InitialPrefabs.Examples {

    public class DynamicProgressBarExample : MonoBehaviour {

        [Tooltip("This is used for defining the max value of the progress bar.")]
        public float floatMax;

        [DynamicProgressBar("floatMax", "Float Value")]
        public float floatProgress;
    }
}
