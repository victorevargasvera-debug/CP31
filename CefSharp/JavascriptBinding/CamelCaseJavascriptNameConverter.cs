using System;
using System.Linq;
using System.Reflection;

namespace CefSharp.JavascriptBinding
{
	// Token: 0x020000C4 RID: 196
	public class CamelCaseJavascriptNameConverter : global::CefSharp.JavascriptBinding.IJavascriptNameConverter
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x000094F8 File Offset: 0x000076F8
		string global::CefSharp.JavascriptBinding.IJavascriptNameConverter.ConvertToJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			return this.ConvertToJavascript(memberInfo);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00009501 File Offset: 0x00007701
		protected virtual string ConvertToJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			return global::CefSharp.JavascriptBinding.CamelCaseJavascriptNameConverter.ConvertMemberInfoNameToCamelCase(memberInfo);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00009509 File Offset: 0x00007709
		string global::CefSharp.JavascriptBinding.IJavascriptNameConverter.ConvertReturnedObjectPropertyAndFieldToNameJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			return this.ConvertReturnedObjectPropertyAndFieldToNameJavascript(memberInfo);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00009512 File Offset: 0x00007712
		protected virtual string ConvertReturnedObjectPropertyAndFieldToNameJavascript(global::System.Reflection.MemberInfo memberInfo)
		{
			return global::CefSharp.JavascriptBinding.CamelCaseJavascriptNameConverter.ConvertMemberInfoNameToCamelCase(memberInfo);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000951C File Offset: 0x0000771C
		protected static string ConvertMemberInfoNameToCamelCase(global::System.Reflection.MemberInfo memberInfo)
		{
			string name = memberInfo.Name;
			if (name.Length == 1)
			{
				return name;
			}
			if (name.All(new global::System.Func<char, bool>(char.IsUpper)))
			{
				return name;
			}
			string text = name.Substring(0, 1);
			string str = name.Substring(1);
			return text.ToLowerInvariant() + str;
		}
	}
}
