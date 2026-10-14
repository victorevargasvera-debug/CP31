using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000010 RID: 16
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	public class HostObjectHelper
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00006BDC File Offset: 0x00004DDC
		public bool IsMethod(object obj, string name)
		{
			global::System.Type type = obj.GetType();
			bool flag = !type.IsClass || type.IsCOMObject;
			if (flag)
			{
				throw new global::System.Runtime.InteropServices.COMException(null, -2147352571);
			}
			global::System.Reflection.MemberInfo[] member = type.GetMember(name);
			bool flag2 = member.Length == 0;
			if (flag2)
			{
				throw new global::System.Runtime.InteropServices.COMException(null, -2147352573);
			}
			foreach (global::System.Reflection.MemberInfo memberInfo in type.GetMember(name))
			{
				bool flag3 = memberInfo.MemberType == global::System.Reflection.MemberTypes.Method;
				if (flag3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400003D RID: 61
		private const int DISP_E_MEMBERNOTFOUND = -2147352573;

		// Token: 0x0400003E RID: 62
		private const int DISP_E_TYPEMISMATCH = -2147352571;
	}
}
