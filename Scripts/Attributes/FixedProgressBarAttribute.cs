using UnityEngine;

namespace InitialPrefabs.Attributes {

    /// <summary>
    /// Stores a max value for the progress bar.
    /// </summary>
    public class FixedProgressBarAttribute : PropertyAttribute {
        
        public float max;
        public string label;

        public FixedProgressBarAttribute() {
            max = 100f;
            label = "Ratio";
        }

        public FixedProgressBarAttribute(string label) : this() {
            this.label = label;
        }

        public FixedProgressBarAttribute(float max) : this() { 
            this.max = max;
        }

        public FixedProgressBarAttribute(float max, string label) : this(max) {
            this.label = label;
        }
    }
}
