using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000009 RID: 9
	public class CoreWebView2HostObjectHelper
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00005E70 File Offset: 0x00004070
		private void Initialize()
		{
			this._nativeICoreWebView2StagingHostObjectHelper = new global::Microsoft.Web.WebView2.Core.CoreWebView2HostObjectHelper.RawHelper();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005E7E File Offset: 0x0000407E
		internal CoreWebView2HostObjectHelper(object rawCoreWebView2HostObjectHelper)
		{
			this._nativeICoreWebView2StagingHostObjectHelper = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StagingHostObjectHelper)rawCoreWebView2HostObjectHelper;
			this.Initialize();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005E9C File Offset: 0x0000409C
		public int IsMethodMember(object rawObject, string memberName)
		{
			return this._nativeICoreWebView2StagingHostObjectHelper.IsMethodMember(ref rawObject, memberName);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005EBC File Offset: 0x000040BC
		internal CoreWebView2HostObjectHelper()
		{
			this.Initialize();
		}

		// Token: 0x04000030 RID: 48
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StagingHostObjectHelper _nativeICoreWebView2StagingHostObjectHelper;

		// Token: 0x020000EE RID: 238
		private class RawHelper : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StagingHostObjectHelper
		{
			// Token: 0x060004F8 RID: 1272 RVA: 0x000127F4 File Offset: 0x000109F4
			public int IsMethodMember(ref object rawObject, string memberName)
			{
				global::System.Type type = rawObject.GetType();
				bool flag = !type.IsClass || type.IsCOMObject;
				if (flag)
				{
					throw new global::System.Runtime.InteropServices.COMException(null, -2147352571);
				}
				global::System.Reflection.MemberInfo[] member = type.GetMember(memberName);
				bool flag2 = member.Length == 0;
				if (flag2)
				{
					throw new global::System.Runtime.InteropServices.COMException(null, -2147352573);
				}
				foreach (global::System.Reflection.MemberInfo memberInfo in type.GetMember(memberName))
				{
					bool flag3 = memberInfo.MemberType == global::System.Reflection.MemberTypes.Method;
					if (flag3)
					{
						return 1;
					}
				}
				return 0;
			}

			// Token: 0x04000294 RID: 660
			private const int DISP_E_MEMBERNOTFOUND = -2147352573;

			// Token: 0x04000295 RID: 661
			private const int DISP_E_TYPEMISMATCH = -2147352571;

			// Token: 0x04000296 RID: 662
			private const int WIN_BOOL_TRUE = 1;

			// Token: 0x04000297 RID: 663
			private const int WIN_BOOL_FALSE = 0;
		}
	}
}
