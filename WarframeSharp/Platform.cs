namespace WarframeSharp
{
    public struct Platform
    {
        private readonly string _value;

        private Platform(string value)
        {
            _value = value;
        }

        public static readonly Platform Pc = new Platform("/pc");

        public static readonly Platform Ps4 = new Platform("/ps4");

        public static readonly Platform XboxOne = new Platform("/xb1");

        public static readonly Platform Switch = new Platform("/swi");

        public static implicit operator string(Platform platform) => platform._value;
    }
}