using System;
using System.Reflection;

namespace CefSharp.JavascriptBinding
{
	// Token: 0x020000C5 RID: 197
	public interface IJavascriptNameConverter
	{
		// Token: 0x060005E6 RID: 1510
		string ConvertToJavascript(global::System.Reflection.MemberInfo memberInfo);

		// Token: 0x060005E7 RID: 1511
		string ConvertReturnedObjectPropertyAndFieldToNameJavascript(global::System.Reflection.MemberInfo memberInfo);
	}
}
