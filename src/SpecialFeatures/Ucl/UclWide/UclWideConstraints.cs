namespace SpecialFeatures.Ucl.UclWide
{
    using AcpCommonLib;
    using AcpCommonLib.UndoRedo;
    using System;

    public static class UclWideConstraints
    {
        internal static void conSetValueHotListEditable(IAcpFeatureSection self, ContainerTask task);
        internal static void conSetValueUclEditable(IAcpFeatureSection self, ContainerTask task);
        internal static bool ConUclIsEditable(IAcpFeatureSection self);
    }
}

