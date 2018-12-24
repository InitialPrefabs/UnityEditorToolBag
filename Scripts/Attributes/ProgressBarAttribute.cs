using UnityEngine;

namespace InitialPrefabs.Attributes {

    /// <summary>
    /// Stores a max value for the progress bar.
    /// </summary>
    public class ProgressBarAttribute : PropertyAttribute {
        
        public float max;
        public string label;

        public ProgressBarAttribute() {
            max   = 100f;
        }

        public ProgressBarAttribute(string label) : this() {
            this.label = label;
        }

        public ProgressBarAttribute(float max) : this() { 
            this.max = max;
        }

        public ProgressBarAttribute(float max, string label) : this(max) {
            this.label = label;
        }
    }
}
