using System;
using System.Collections.Specialized;
using System.Configuration;

namespace NLog.Internal
{
	// Token: 0x020000FB RID: 251
	public class ConfigurationManager : global::NLog.Internal.IConfigurationManager
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0001F301 File Offset: 0x0001D501
		public global::System.Collections.Specialized.NameValueCollection AppSettings
		{
			get
			{
				return global::System.Configuration.ConfigurationManager.AppSettings;
			}
		}
	}
}
