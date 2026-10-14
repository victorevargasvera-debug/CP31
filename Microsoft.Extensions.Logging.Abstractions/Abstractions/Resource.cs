using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.Extensions.Logging.Abstractions
{
	// Token: 0x02000010 RID: 16
	internal static class Resource
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002A83 File Offset: 0x00000C83
		internal static string UnexpectedNumberOfNamedParameters
		{
			get
			{
				return global::Microsoft.Extensions.Logging.Abstractions.Resource.GetString("UnexpectedNumberOfNamedParameters", new string[0]);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002A95 File Offset: 0x00000C95
		internal static string FormatUnexpectedNumberOfNamedParameters(object p0, object p1, object p2)
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Extensions.Logging.Abstractions.Resource.GetString("UnexpectedNumberOfNamedParameters", new string[0]), new object[]
			{
				p0,
				p1,
				p2
			});
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002AC4 File Offset: 0x00000CC4
		private static string GetString(string name, params string[] formatterNames)
		{
			string text = global::Microsoft.Extensions.Logging.Abstractions.Resource._resourceManager.GetString(name);
			if (formatterNames != null)
			{
				for (int i = 0; i < formatterNames.Length; i++)
				{
					text = text.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
				}
			}
			return text;
		}

		// Token: 0x04000019 RID: 25
		private static readonly global::System.Resources.ResourceManager _resourceManager = new global::System.Resources.ResourceManager("Microsoft.Extensions.Logging.Abstractions.Resource", typeof(global::Microsoft.Extensions.Logging.Abstractions.Resource).GetTypeInfo().Assembly);
	}
}
