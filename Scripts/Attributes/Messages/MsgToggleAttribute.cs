namespace InitialPrefabs.Attributes.Messages {

    /// <summary>
    /// Stores a message to display for a boolean field.
    /// </summary>
    public class MsgToggleAttribute : MsgAttribute {

        public bool isInverted;

        public MsgToggleAttribute() : base() { }

        public MsgToggleAttribute(string message) : base(message) { }

        public MsgToggleAttribute(string message, MessageLevel messageLevel) : base(message) {
            this.messageLevel = messageLevel;
        }

        public MsgToggleAttribute(string message, int height) : base(message) {
            this.height = height;
        }

        public MsgToggleAttribute(string message, int height, MessageLevel messageLevel) : base(message, height) {
            this.messageLevel = messageLevel;
        }

        public MsgToggleAttribute(string message, bool isInverted) : base(message) {
            this.isInverted = isInverted;
        }

        public MsgToggleAttribute(string message, bool isInverted, MessageLevel messageLevel) : 
            this(message, isInverted) {
            this.messageLevel = messageLevel;
        }

        public MsgToggleAttribute(string message, int height, bool isInverted) : base(message, height) {
            this.isInverted = isInverted;
        }

        public MsgToggleAttribute(string message, int height, bool isInverted, MessageLevel messageLevel) : 
            this(message, height, isInverted) {
            this.messageLevel = messageLevel;
        }
    }
}
