using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using CefSharp.DevTools.Browser;
using CefSharp.DevTools.DOMDebugger;
using CefSharp.DevTools.Emulation;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools
{
	// Token: 0x02000021 RID: 33
	public abstract class DevToolsDomainBase
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00004818 File Offset: 0x00002A18
		protected string EnumToString(global::System.Enum val)
		{
			global::System.Reflection.MemberInfo[] member = val.GetType().GetMember(val.ToString());
			global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(member[0], typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
			return enumMemberAttribute.Value;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004856 File Offset: 0x00002A56
		protected global::System.Collections.Generic.IEnumerable<string> EnumToString(global::CefSharp.DevTools.Network.ContentEncoding[] values)
		{
			foreach (global::CefSharp.DevTools.Network.ContentEncoding contentEncoding in values)
			{
				global::System.Reflection.MemberInfo[] member = contentEncoding.GetType().GetMember(contentEncoding.ToString());
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(member[0], typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
				yield return enumMemberAttribute.Value;
			}
			global::CefSharp.DevTools.Network.ContentEncoding[] array = null;
			yield break;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004866 File Offset: 0x00002A66
		protected global::System.Collections.Generic.IEnumerable<string> EnumToString(global::CefSharp.DevTools.Browser.PermissionType[] values)
		{
			foreach (global::CefSharp.DevTools.Browser.PermissionType permissionType in values)
			{
				global::System.Reflection.MemberInfo[] member = permissionType.GetType().GetMember(permissionType.ToString());
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(member[0], typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
				yield return enumMemberAttribute.Value;
			}
			global::CefSharp.DevTools.Browser.PermissionType[] array = null;
			yield break;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004876 File Offset: 0x00002A76
		protected global::System.Collections.Generic.IEnumerable<string> EnumToString(global::CefSharp.DevTools.Emulation.DisabledImageType[] values)
		{
			foreach (global::CefSharp.DevTools.Emulation.DisabledImageType disabledImageType in values)
			{
				global::System.Reflection.MemberInfo[] member = disabledImageType.GetType().GetMember(disabledImageType.ToString());
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(member[0], typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
				yield return enumMemberAttribute.Value;
			}
			global::CefSharp.DevTools.Emulation.DisabledImageType[] array = null;
			yield break;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00004886 File Offset: 0x00002A86
		protected global::System.Collections.Generic.IEnumerable<string> EnumToString(global::CefSharp.DevTools.DOMDebugger.CSPViolationType[] values)
		{
			foreach (global::CefSharp.DevTools.DOMDebugger.CSPViolationType cspviolationType in values)
			{
				global::System.Reflection.MemberInfo[] member = cspviolationType.GetType().GetMember(cspviolationType.ToString());
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(member[0], typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
				yield return enumMemberAttribute.Value;
			}
			global::CefSharp.DevTools.DOMDebugger.CSPViolationType[] array = null;
			yield break;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004896 File Offset: 0x00002A96
		protected string ToBase64String(byte[] bytes)
		{
			return global::System.Convert.ToBase64String(bytes);
		}
	}
}
