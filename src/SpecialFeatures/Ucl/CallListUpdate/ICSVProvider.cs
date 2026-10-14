namespace SpecialFeatures.UCL.CallListUpdate
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;

    internal interface ICSVProvider
    {
        IDictionary<string, string> getUnitIdAndAliasDict();
        NameValueCollection getUnitIdAndAliasList();
        IDictionary<string, string> getUnitIdAndSortedAliasDict();
        bool isCsvValid();
    }
}

