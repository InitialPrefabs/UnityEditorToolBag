using UnityEngine;

namespace InitialPrefabs.Attributes {

    public class DynamicProgressBarAttribute : PropertyAttribute {
        public string maxProperty;
        public string label;

        public DynamicProgressBarAttribute(string maxProperty) {
            this.maxProperty = maxProperty;
            this.label       = "Ratio";
        }

        public DynamicProgressBarAttribute(string maxProperty, string label) : this(maxProperty) {
            this.label = label;
        }
    }
}
