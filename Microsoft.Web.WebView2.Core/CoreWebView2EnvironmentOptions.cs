using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000007 RID: 7
	public class CoreWebView2EnvironmentOptions
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00005484 File Offset: 0x00003684
		public CoreWebView2EnvironmentOptions(string additionalBrowserArguments = null, string language = null, string targetCompatibleBrowserVersion = null, bool allowSingleSignOnUsingOSPrimaryAccount = false)
		{
			targetCompatibleBrowserVersion = global::Microsoft.Web.WebView2.Core.Raw.BrowserInfo.PRODUCT_VERSION;
			this._nativeICoreWebView2EnvironmentOptions = new global::Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions.RawOptions(additionalBrowserArguments, language, targetCompatibleBrowserVersion, allowSingleSignOnUsingOSPrimaryAccount);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00005504 File Offset: 0x00003704
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptions
		{
			get
			{
				bool flag = this._nativeICoreWebView2EnvironmentOptionsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentOptionsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2EnvironmentOptionsValue;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentOptionsValue = value;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000550E File Offset: 0x0000370E
		internal CoreWebView2EnvironmentOptions(object rawCoreWebView2EnvironmentOptions)
		{
			this._rawNative = rawCoreWebView2EnvironmentOptions;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00005520 File Offset: 0x00003720
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000055A0 File Offset: 0x000037A0
		public string AdditionalBrowserArguments
		{
			get
			{
				string additionalBrowserArguments;
				try
				{
					additionalBrowserArguments = this._nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
				return additionalBrowserArguments;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.AdditionalBrowserArguments = value;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005620 File Offset: 0x00003820
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000056A0 File Offset: 0x000038A0
		public string Language
		{
			get
			{
				string language;
				try
				{
					language = this._nativeICoreWebView2EnvironmentOptions.Language;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
				return language;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.Language = value;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005720 File Offset: 0x00003920
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000057A0 File Offset: 0x000039A0
		public string TargetCompatibleBrowserVersion
		{
			get
			{
				string targetCompatibleBrowserVersion;
				try
				{
					targetCompatibleBrowserVersion = this._nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
				return targetCompatibleBrowserVersion;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.TargetCompatibleBrowserVersion = value;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005820 File Offset: 0x00003A20
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000058A4 File Offset: 0x00003AA4
		public bool AllowSingleSignOnUsingOSPrimaryAccount
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount != 0);
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
				return result;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2EnvironmentOptions.AllowSingleSignOnUsingOSPrimaryAccount = (value ? 1 : 0);
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
			}
		}

		// Token: 0x04000028 RID: 40
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions _nativeICoreWebView2EnvironmentOptionsValue;

		// Token: 0x04000029 RID: 41
		internal object _rawNative;

		// Token: 0x020000EC RID: 236
		private class RawOptions : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions
		{
			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060004EC RID: 1260 RVA: 0x00012748 File Offset: 0x00010948
			// (set) Token: 0x060004ED RID: 1261 RVA: 0x00012750 File Offset: 0x00010950
			public string AdditionalBrowserArguments { get; set; } = null;

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060004EE RID: 1262 RVA: 0x00012759 File Offset: 0x00010959
			// (set) Token: 0x060004EF RID: 1263 RVA: 0x00012761 File Offset: 0x00010961
			public string Language { get; set; } = null;

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001276A File Offset: 0x0001096A
			// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00012772 File Offset: 0x00010972
			public string TargetCompatibleBrowserVersion { get; set; } = null;

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001277B File Offset: 0x0001097B
			// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00012783 File Offset: 0x00010983
			public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; } = 0;

			// Token: 0x060004F4 RID: 1268 RVA: 0x0001278C File Offset: 0x0001098C
			public RawOptions(string additionalBrowserArguments, string language, string targetCompatibleBrowserVersion, bool allowSingleSignOnUsingOSPrimaryAccount)
			{
				this.AdditionalBrowserArguments = additionalBrowserArguments;
				this.Language = language;
				this.TargetCompatibleBrowserVersion = targetCompatibleBrowserVersion;
				this.AllowSingleSignOnUsingOSPrimaryAccount = (allowSingleSignOnUsingOSPrimaryAccount ? 1 : 0);
			}
		}
	}
}
