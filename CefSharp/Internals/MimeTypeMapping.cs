using System;
using System.Collections.Generic;

namespace CefSharp.Internals
{
	// Token: 0x020000EA RID: 234
	public static class MimeTypeMapping
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x0000B778 File Offset: 0x00009978
		public static string GetCustomMapping(string extension)
		{
			string result;
			if (!global::CefSharp.Internals.MimeTypeMapping.CustomMappings.TryGetValue(extension, out result))
			{
				return "application/octet-stream";
			}
			return result;
		}

		// Token: 0x040003C0 RID: 960
		public static readonly global::System.Collections.Generic.IDictionary<string, string> CustomMappings = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.InvariantCultureIgnoreCase)
		{
			{
				"woff2",
				"font/woff2"
			},
			{
				"ttf",
				"font/ttf"
			},
			{
				"otf",
				"font/otf"
			}
		};
	}
}
