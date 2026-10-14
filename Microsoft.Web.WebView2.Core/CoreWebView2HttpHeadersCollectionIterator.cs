using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000A RID: 10
	public class CoreWebView2HttpHeadersCollectionIterator : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00005ED0 File Offset: 0x000040D0
		public bool MoveNext()
		{
			bool flag = this.isInitialized;
			bool result;
			if (flag)
			{
				result = (this._nativeICoreWebView2HttpHeadersCollectionIterator.MoveNext() != 0);
			}
			else
			{
				this.isInitialized = true;
				result = this.HasCurrentHeader;
			}
			return result;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005F0B File Offset: 0x0000410B
		public void Reset()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005F13 File Offset: 0x00004113
		public void Dispose()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005F18 File Offset: 0x00004118
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005F38 File Offset: 0x00004138
		public global::System.Collections.Generic.KeyValuePair<string, string> Current
		{
			get
			{
				global::System.Collections.Generic.KeyValuePair<string, string> result;
				try
				{
					string key;
					string value;
					this.GetCurrentHeader(out key, out value);
					result = new global::System.Collections.Generic.KeyValuePair<string, string>(key, value);
				}
				catch (global::System.IndexOutOfRangeException)
				{
					throw new global::System.InvalidOperationException();
				}
				return result;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00005F78 File Offset: 0x00004178
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00005FD4 File Offset: 0x000041D4
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIterator
		{
			get
			{
				bool flag = this._nativeICoreWebView2HttpHeadersCollectionIteratorValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2HttpHeadersCollectionIteratorValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2HttpHeadersCollectionIteratorValue;
			}
			set
			{
				this._nativeICoreWebView2HttpHeadersCollectionIteratorValue = value;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005FDE File Offset: 0x000041DE
		internal CoreWebView2HttpHeadersCollectionIterator(object rawCoreWebView2HttpHeadersCollectionIterator)
		{
			this._rawNative = rawCoreWebView2HttpHeadersCollectionIterator;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005FF8 File Offset: 0x000041F8
		public bool HasCurrentHeader
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2HttpHeadersCollectionIterator.HasCurrentHeader != 0);
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
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000607C File Offset: 0x0000427C
		private void GetCurrentHeader(out string name, out string value)
		{
			try
			{
				this._nativeICoreWebView2HttpHeadersCollectionIterator.GetCurrentHeader(out name, out value);
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

		// Token: 0x04000031 RID: 49
		private bool isInitialized = false;

		// Token: 0x04000032 RID: 50
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpHeadersCollectionIterator _nativeICoreWebView2HttpHeadersCollectionIteratorValue;

		// Token: 0x04000033 RID: 51
		internal object _rawNative;
	}
}
