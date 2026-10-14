using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000006 RID: 6
	public class CoreWebView2Environment
	{
		// Token: 0x06000069 RID: 105
		[global::System.Runtime.InteropServices.DllImport("WebView2Loader.dll")]
		internal static extern int CreateCoreWebView2EnvironmentWithOptions([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string browserExecutableFolder, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string userDataFolder, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EnvironmentOptions options, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environment_created_handler);

		// Token: 0x0600006A RID: 106
		[global::System.Runtime.InteropServices.DllImport("WebView2Loader.dll")]
		internal static extern int GetAvailableCoreWebView2BrowserVersionString([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string browserExecutableFolder, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] ref string versionInfo);

		// Token: 0x0600006B RID: 107
		[global::System.Runtime.InteropServices.DllImport("WebView2Loader.dll")]
		internal static extern int CompareBrowserVersions([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string version1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string version2, ref int result);

		// Token: 0x0600006C RID: 108 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[global::System.Diagnostics.DebuggerStepThrough]
		public static global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment> CreateAsync(string browserExecutableFolder = null, string userDataFolder = null, global::Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions options = null)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateAsync>d__3 <CreateAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateAsync>d__3();
			<CreateAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment>.Create();
			<CreateAsync>d__.browserExecutableFolder = browserExecutableFolder;
			<CreateAsync>d__.userDataFolder = userDataFolder;
			<CreateAsync>d__.options = options;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateAsync>d__3>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004D48 File Offset: 0x00002F48
		public static string GetAvailableBrowserVersionString(string browserExecutableFolder = null)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.LoadWebView2LoaderDll();
			string result = null;
			int availableCoreWebView2BrowserVersionString = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, ref result);
			bool flag = availableCoreWebView2BrowserVersionString == -2147024894;
			if (flag)
			{
				throw new global::Microsoft.Web.WebView2.Core.WebView2RuntimeNotFoundException(global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(availableCoreWebView2BrowserVersionString));
			}
			global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(availableCoreWebView2BrowserVersionString);
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004D8C File Offset: 0x00002F8C
		public static int CompareBrowserVersions(string version1, string version2)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.LoadWebView2LoaderDll();
			int result = 0;
			int errorCode = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.CompareBrowserVersions(version1, version2, ref result);
			global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(errorCode);
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest CreateWebResourceRequest(string uri, string Method, global::System.IO.Stream postData, string Headers)
		{
			return new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest(this._nativeICoreWebView2Environment2.CreateWebResourceRequest(uri, Method, (postData == null) ? null : new global::Microsoft.Web.WebView2.Core.ManagedIStream(postData), Headers));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004DEC File Offset: 0x00002FEC
		private static global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture GetArchitecture()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.SYSTEM_INFO system_INFO;
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetSystemInfo(out system_INFO);
			return (global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture)system_INFO.wProcessorArchitecture;
		}

		// Token: 0x06000071 RID: 113
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private static extern void GetSystemInfo(out global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.SYSTEM_INFO lpSystemInfo);

		// Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern global::System.IntPtr LoadLibrary(string dllToLoad);

		// Token: 0x06000073 RID: 115 RVA: 0x00004E0C File Offset: 0x0000300C
		private static void LoadWebView2LoaderDll()
		{
			bool flag = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.webView2LoaderLoaded;
			if (!flag)
			{
				string frameworkDescription = global::System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
				bool flag2 = frameworkDescription.StartsWith(".NET Framework");
				if (flag2)
				{
					string localPath = new global::System.Uri(typeof(global::Microsoft.Web.WebView2.Core.CoreWebView2Environment).Assembly.CodeBase).LocalPath;
					string directoryName = global::System.IO.Path.GetDirectoryName(localPath);
					string text = "\\runtimes\\win-";
					global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture architecture = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.GetArchitecture();
					global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture processorArchitecture = architecture;
					global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture processorArchitecture2 = processorArchitecture;
					if (processorArchitecture2 != global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture.x86)
					{
						if (processorArchitecture2 != global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture.x64)
						{
							if (processorArchitecture2 != global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.ProcessorArchitecture.ARM64)
							{
								throw new global::System.NotSupportedException("Unknown Processor Architecture of WebView2Loader.dll is not supported");
							}
							text += "arm64";
						}
						else
						{
							text += "x64";
						}
					}
					else
					{
						text += "x86";
					}
					string text2 = directoryName + text + "\\native\\WebView2Loader.dll";
					bool flag3 = global::System.IO.File.Exists(text2);
					if (flag3)
					{
						global::System.IntPtr value = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.LoadLibrary(text2);
						bool flag4 = value == global::System.IntPtr.Zero;
						if (flag4)
						{
							int hrforLastWin32Error = global::System.Runtime.InteropServices.Marshal.GetHRForLastWin32Error();
							global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(hrforLastWin32Error);
						}
					}
				}
				global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.webView2LoaderLoaded = true;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004F24 File Offset: 0x00003124
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00004F80 File Offset: 0x00003180
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment _nativeICoreWebView2Environment
		{
			get
			{
				bool flag = this._nativeICoreWebView2EnvironmentValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2EnvironmentValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2EnvironmentValue;
			}
			set
			{
				this._nativeICoreWebView2EnvironmentValue = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004F8C File Offset: 0x0000318C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00004FE8 File Offset: 0x000031E8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2 _nativeICoreWebView2Environment2
		{
			get
			{
				bool flag = this._nativeICoreWebView2Environment2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Environment2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Environment2Value;
			}
			set
			{
				this._nativeICoreWebView2Environment2Value = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004FF4 File Offset: 0x000031F4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005050 File Offset: 0x00003250
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3 _nativeICoreWebView2Environment3
		{
			get
			{
				bool flag = this._nativeICoreWebView2Environment3Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Environment3Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Environment3Value;
			}
			set
			{
				this._nativeICoreWebView2Environment3Value = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000505C File Offset: 0x0000325C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000050B8 File Offset: 0x000032B8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4 _nativeICoreWebView2Environment4
		{
			get
			{
				bool flag = this._nativeICoreWebView2Environment4Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Environment4Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Environment4Value;
			}
			set
			{
				this._nativeICoreWebView2Environment4Value = value;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000050C2 File Offset: 0x000032C2
		internal CoreWebView2Environment(object rawCoreWebView2Environment)
		{
			this._rawNative = rawCoreWebView2Environment;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000050D4 File Offset: 0x000032D4
		public string BrowserVersionString
		{
			get
			{
				string browserVersionString;
				try
				{
					browserVersionString = this._nativeICoreWebView2Environment.BrowserVersionString;
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
				return browserVersionString;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600007E RID: 126 RVA: 0x00005154 File Offset: 0x00003354
		// (remove) Token: 0x0600007F RID: 127 RVA: 0x00005210 File Offset: 0x00003410
		public event global::System.EventHandler<object> NewBrowserVersionAvailable
		{
			add
			{
				bool flag = this.newBrowserVersionAvailable == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Environment.add_NewBrowserVersionAvailable(new global::Microsoft.Web.WebView2.Core.CoreWebView2NewBrowserVersionAvailableEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType(this.OnNewBrowserVersionAvailable)), out this._newBrowserVersionAvailableToken);
					}
					catch (global::System.InvalidCastException ex)
					{
						bool flag2 = ex.HResult == -2147467262;
						if (flag2)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
						}
						throw ex;
					}
					catch (global::System.Runtime.InteropServices.COMException ex2)
					{
						bool flag3 = ex2.HResult == -2147019873;
						if (flag3)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
						}
						throw ex2;
					}
				}
				this.newBrowserVersionAvailable = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.newBrowserVersionAvailable, value);
			}
			remove
			{
				this.newBrowserVersionAvailable = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.newBrowserVersionAvailable, value);
				bool flag = this.newBrowserVersionAvailable == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Environment.remove_NewBrowserVersionAvailable(this._newBrowserVersionAvailableToken);
					}
					catch (global::System.InvalidCastException ex)
					{
						bool flag2 = ex.HResult == -2147467262;
						if (flag2)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
						}
						throw ex;
					}
					catch (global::System.Runtime.InteropServices.COMException ex2)
					{
						bool flag3 = ex2.HResult == -2147019873;
						if (flag3)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
						}
						throw ex2;
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000052BC File Offset: 0x000034BC
		internal void OnNewBrowserVersionAvailable(object args)
		{
			global::System.EventHandler<object> eventHandler = this.newBrowserVersionAvailable;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000052D4 File Offset: 0x000034D4
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Controller> CreateCoreWebView2ControllerAsync(global::System.IntPtr ParentWindow)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2ControllerAsync>d__41 <CreateCoreWebView2ControllerAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2ControllerAsync>d__41();
			<CreateCoreWebView2ControllerAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Microsoft.Web.WebView2.Core.CoreWebView2Controller>.Create();
			<CreateCoreWebView2ControllerAsync>d__.<>4__this = this;
			<CreateCoreWebView2ControllerAsync>d__.ParentWindow = ParentWindow;
			<CreateCoreWebView2ControllerAsync>d__.<>1__state = -1;
			<CreateCoreWebView2ControllerAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2ControllerAsync>d__41>(ref <CreateCoreWebView2ControllerAsync>d__);
			return <CreateCoreWebView2ControllerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005320 File Offset: 0x00003520
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse CreateWebResourceResponse(global::System.IO.Stream Content, int StatusCode, string ReasonPhrase, string Headers)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse(this._nativeICoreWebView2Environment.CreateWebResourceResponse((Content == null) ? null : new global::Microsoft.Web.WebView2.Core.ManagedIStream(Content), StatusCode, ReasonPhrase, Headers));
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

		// Token: 0x06000083 RID: 131 RVA: 0x000053B4 File Offset: 0x000035B4
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController> CreateCoreWebView2CompositionControllerAsync(global::System.IntPtr ParentWindow)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2CompositionControllerAsync>d__43 <CreateCoreWebView2CompositionControllerAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2CompositionControllerAsync>d__43();
			<CreateCoreWebView2CompositionControllerAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController>.Create();
			<CreateCoreWebView2CompositionControllerAsync>d__.<>4__this = this;
			<CreateCoreWebView2CompositionControllerAsync>d__.ParentWindow = ParentWindow;
			<CreateCoreWebView2CompositionControllerAsync>d__.<>1__state = -1;
			<CreateCoreWebView2CompositionControllerAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.<CreateCoreWebView2CompositionControllerAsync>d__43>(ref <CreateCoreWebView2CompositionControllerAsync>d__);
			return <CreateCoreWebView2CompositionControllerAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005400 File Offset: 0x00003600
		public global::Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo(this._nativeICoreWebView2Environment3.CreateCoreWebView2PointerInfo());
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

		// Token: 0x04000020 RID: 32
		private static bool webView2LoaderLoaded;

		// Token: 0x04000021 RID: 33
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment _nativeICoreWebView2EnvironmentValue;

		// Token: 0x04000022 RID: 34
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2 _nativeICoreWebView2Environment2Value;

		// Token: 0x04000023 RID: 35
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment3 _nativeICoreWebView2Environment3Value;

		// Token: 0x04000024 RID: 36
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment4 _nativeICoreWebView2Environment4Value;

		// Token: 0x04000025 RID: 37
		internal object _rawNative;

		// Token: 0x04000026 RID: 38
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _newBrowserVersionAvailableToken;

		// Token: 0x04000027 RID: 39
		private global::System.EventHandler<object> newBrowserVersionAvailable;

		// Token: 0x020000E7 RID: 231
		private enum ProcessorArchitecture : ushort
		{
			// Token: 0x04000266 RID: 614
			x86,
			// Token: 0x04000267 RID: 615
			x64 = 9,
			// Token: 0x04000268 RID: 616
			ARM64 = 12,
			// Token: 0x04000269 RID: 617
			Unknown = 65535
		}

		// Token: 0x020000E8 RID: 232
		private struct SYSTEM_INFO
		{
			// Token: 0x0400026A RID: 618
			internal ushort wProcessorArchitecture;

			// Token: 0x0400026B RID: 619
			private ushort wReserved;

			// Token: 0x0400026C RID: 620
			private int dwPageSize;

			// Token: 0x0400026D RID: 621
			private global::System.IntPtr lpMinimumApplicationAddress;

			// Token: 0x0400026E RID: 622
			private global::System.IntPtr lpMaximumApplicationAddress;

			// Token: 0x0400026F RID: 623
			private global::System.IntPtr dwActiveProcessorMask;

			// Token: 0x04000270 RID: 624
			private int dwNumberOfProcessors;

			// Token: 0x04000271 RID: 625
			private int dwProcessorType;

			// Token: 0x04000272 RID: 626
			private int dwAllocationGranularity;

			// Token: 0x04000273 RID: 627
			private short wProcessorLevel;

			// Token: 0x04000274 RID: 628
			private short wProcessorRevision;
		}
	}
}
