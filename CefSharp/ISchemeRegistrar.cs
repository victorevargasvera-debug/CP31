using System;
using CefSharp.Enums;

namespace CefSharp
{
	// Token: 0x02000080 RID: 128
	public interface ISchemeRegistrar
	{
		// Token: 0x0600033E RID: 830
		bool AddCustomScheme(string schemeName, global::CefSharp.Enums.SchemeOptions schemeOptions);
	}
}
