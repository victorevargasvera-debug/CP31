using System;
using System.Windows.Forms;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000094 RID: 148
	internal interface IConfigurationEditor : global::System.IDisposable
	{
		// Token: 0x0600069E RID: 1694
		global::System.Windows.Forms.DialogResult EditConfiguration(global::Loupe.Extensibility.Client.IRepositoryContext context, global::Loupe.Extensibility.Client.IRepositoryConfiguration configuration, bool initialConfiguration);
	}
}
