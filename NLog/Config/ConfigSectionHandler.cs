using System;
using System.Configuration;
using System.Xml;
using NLog.Common;
using NLog.Internal.Fakeables;

namespace NLog.Config
{
	// Token: 0x0200015A RID: 346
	public sealed class ConfigSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06000F33 RID: 3891 RVA: 0x00026A74 File Offset: 0x00024C74
		private object Create(global::System.Xml.XmlNode section, global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			object result;
			try
			{
				string configurationFile = appDomain.ConfigurationFile;
				result = new global::NLog.Config.XmlLoggingConfiguration((global::System.Xml.XmlElement)section, configurationFile);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "ConfigSectionHandler error.");
				throw;
			}
			return result;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00026AB4 File Offset: 0x00024CB4
		object global::System.Configuration.IConfigurationSectionHandler.Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			return this.Create(section, global::NLog.LogFactory.CurrentAppDomain);
		}
	}
}
