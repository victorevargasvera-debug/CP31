namespace SpecialFeatures.UCL.CallListUpdate
{
    using System;
    using System.Configuration;
    using System.Xml;

    internal sealed class ConsoleAliasesListSettingsSectionHandler : IConfigurationSectionHandler
    {
        public ConsoleAliasesListSettingsSectionHandler();
        public object Create(object parent, object configContext, XmlNode section);
    }
}

