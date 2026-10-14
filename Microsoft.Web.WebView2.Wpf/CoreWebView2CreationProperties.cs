using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Wpf
{
	// Token: 0x02000002 RID: 2
	public class CoreWebView2CreationProperties : global::System.Windows.DependencyObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000206A File Offset: 0x0000026A
		public string BrowserExecutableFolder
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.BrowserExecutableFolderProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.BrowserExecutableFolderProperty, value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00000278
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000208A File Offset: 0x0000028A
		public string UserDataFolder
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.UserDataFolderProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.UserDataFolderProperty, value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020AA File Offset: 0x000002AA
		public string Language
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.LanguageProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.LanguageProperty, value);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B8 File Offset: 0x000002B8
		private static void PropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			((global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties)d)._task = null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020C6 File Offset: 0x000002C6
		internal global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment> CreateEnvironmentAsync()
		{
			if (this._task == null)
			{
				this._task = global::Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(this.BrowserExecutableFolder, this.UserDataFolder, new global::Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions(null, this.Language, null, false));
			}
			return this._task;
		}

		// Token: 0x04000001 RID: 1
		public static readonly global::System.Windows.DependencyProperty BrowserExecutableFolderProperty = global::System.Windows.DependencyProperty.Register("BrowserExecutableFolder", typeof(string), typeof(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.PropertyChanged)));

		// Token: 0x04000002 RID: 2
		public static readonly global::System.Windows.DependencyProperty UserDataFolderProperty = global::System.Windows.DependencyProperty.Register("UserDataFolder", typeof(string), typeof(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.PropertyChanged)));

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty LanguageProperty = global::System.Windows.DependencyProperty.Register("Language", typeof(string), typeof(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties.PropertyChanged)));

		// Token: 0x04000004 RID: 4
		private global::System.Threading.Tasks.Task<global::Microsoft.Web.WebView2.Core.CoreWebView2Environment> _task;
	}
}
