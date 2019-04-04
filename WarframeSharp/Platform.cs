namespace WarframeSharp
{
    public struct Platform
    {
        private readonly string _value;

        private Platform(string value)
        {
            _value = value;
        }

        public static Platform Pc = new Platform("/pc");

        public static Platform Ps4 = new Platform("/ps4");

        public static Platform XboxOne = new Platform("/xb1");

        public static Platform Switch = new Platform("/swi");

        public static implicit operator string(Platform platform) => platform._value;
    }
}