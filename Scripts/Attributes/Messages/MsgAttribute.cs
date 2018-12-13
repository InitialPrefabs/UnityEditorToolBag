using UnityEngine;

namespace InitialPrefabs.Attributes.Messages {
    
    /// <summary>
    /// Stores a message to display onto the inspector.
    /// </summary>
    public class MsgAttribute : PropertyAttribute {

        public string message;
        public int height, messageLevel;

        public MsgAttribute(string message) {
            this.message = message;
            height       = 3;
            messageLevel = 0;
        }

        public MsgAttribute(string message, MessageLevel messageLevel) : this(message) {
            this.messageLevel = (int)messageLevel;
        }
        
        public MsgAttribute(string message, MessageLevel messageLevel, int height) : this(message, messageLevel) {
            this.height = height;
        }
    }
}
