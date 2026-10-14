namespace SpecialFeatures.Comms.Util
{
    using System;
    using System.Runtime.CompilerServices;

    [Extension]
    public static class ComparableExtention
    {
        [Extension]
        public static bool EqualTo(IComparable comarable, object obj);
        [Extension]
        public static bool GreaterThan(IComparable comarable, object obj);
        [Extension]
        public static bool LowerThan(IComparable comarable, object obj);
    }
}

