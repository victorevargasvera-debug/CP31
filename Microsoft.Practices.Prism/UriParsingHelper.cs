using System;

namespace Microsoft.Practices.Prism
{
	// Token: 0x0200008C RID: 140
	public static class UriParsingHelper
	{
		// Token: 0x060003BF RID: 959 RVA: 0x0000A6BB File Offset: 0x000088BB
		public static string GetQuery(global::System.Uri uri)
		{
			return global::Microsoft.Practices.Prism.UriParsingHelper.EnsureAbsolute(uri).Query;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public static string GetAbsolutePath(global::System.Uri uri)
		{
			return global::Microsoft.Practices.Prism.UriParsingHelper.EnsureAbsolute(uri).AbsolutePath;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public static global::Microsoft.Practices.Prism.UriQuery ParseQuery(global::System.Uri uri)
		{
			string query = global::Microsoft.Practices.Prism.UriParsingHelper.GetQuery(uri);
			return new global::Microsoft.Practices.Prism.UriQuery(query);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000A6F4 File Offset: 0x000088F4
		private static global::System.Uri EnsureAbsolute(global::System.Uri uri)
		{
			if (uri.IsAbsoluteUri)
			{
				return uri;
			}
			if (uri != null && !uri.OriginalString.StartsWith("/", global::System.StringComparison.Ordinal))
			{
				return new global::System.Uri("http://localhost/" + uri, global::System.UriKind.Absolute);
			}
			return new global::System.Uri("http://localhost" + uri, global::System.UriKind.Absolute);
		}
	}
}
