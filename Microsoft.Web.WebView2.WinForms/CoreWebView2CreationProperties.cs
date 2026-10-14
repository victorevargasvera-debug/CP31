using System;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.WinForms
{
	// Token: 0x02000002 RID: 2
	public class CoreWebView2CreationProperties
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002060 File Offset: 0x00000260
		public string BrowserExecutableFolder
		{
			get
			{
				return this._browserExecutableFolder;
			}
			set
			{
				this._browserExecutableFolder = value;
				this._task = null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002078 File Offset: 0x00000278
		public string UserDataFolder
		{
			get
			{
				return this._userDataFolder;
			}
			set
			{
				this._userDataFolder = value;
				this._task = null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002090 File Offset: 0x00000290
		public string Language
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
				this._task = null;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A0 File Offset: 0x000002A0
		internal global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment> CreateEnvironmentAsync()
		{
			if (this._task == null)
			{
				this._task = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(this.BrowserExecutableFolder, this.UserDataFolder, new global::Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions(null, this.Language, null, false));
			}
			return this._task;
		}

		// Token: 0x04000001 RID: 1
		private string _browserExecutableFolder;

		// Token: 0x04000002 RID: 2
		private string _userDataFolder;

		// Token: 0x04000003 RID: 3
		private string _language;

		// Token: 0x04000004 RID: 4
		private global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment> _task;
	}
}
