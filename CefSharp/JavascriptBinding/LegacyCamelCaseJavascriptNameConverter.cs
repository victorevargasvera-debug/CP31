using System;
using System.Reflection;

namespace CefSharp.JavascriptBinding
{
	// Token: 0x020000C7 RID: 199
	public class LegacyCamelCaseJavascriptNameConverter : global::CefSharp.JavascriptBinding.IJavascriptNameConverter
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00009608 File Offset: 0x00007808
		string global::CefSharp.JavascriptBinding.IJavascriptNameConverter.ConvertReturnedObjectPropertyAndFieldToNameJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			return memberInfo.Name;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00009610 File Offset: 0x00007810
		string global::CefSharp.JavascriptBinding.IJavascriptNameConverter.ConvertToJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			string name = memberInfo.Name;
			return char.ToLowerInvariant(name[0]).ToString() + name.Substring(1);
		}
	}
}
