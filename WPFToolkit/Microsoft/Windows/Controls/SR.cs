using System;
using System.Globalization;
using System.Resources;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000021 RID: 33
	internal static class SR
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00008D2F File Offset: 0x00006F2F
		internal static string Get(global::Microsoft.Windows.Controls.SRID id)
		{
			return global::Microsoft.Windows.Controls.SR._resourceManager.GetString(id.String);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008D44 File Offset: 0x00006F44
		internal static string Get(global::Microsoft.Windows.Controls.SRID id, params object[] args)
		{
			string text = global::Microsoft.Windows.Controls.SR._resourceManager.GetString(id.String);
			if (text != null && args != null && args.Length > 0)
			{
				text = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, text, args);
			}
			return text;
		}

		// Token: 0x04000081 RID: 129
		private static global::System.Resources.ResourceManager _resourceManager = new global::System.Resources.ResourceManager("ExceptionStringTable", typeof(global::Microsoft.Windows.Controls.SR).Assembly);
	}
}
