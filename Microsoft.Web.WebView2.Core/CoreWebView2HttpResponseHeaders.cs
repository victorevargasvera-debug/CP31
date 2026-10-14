using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000C RID: 12
	public class CoreWebView2HttpResponseHeaders : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000064C8 File Offset: 0x000046C8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000064E0 File Offset: 0x000046E0
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000064F8 File Offset: 0x000046F8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetEnumerator()
		{
			return this.GetIterator();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000656C File Offset: 0x0000476C
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeaders
		{
			get
			{
				bool flag = this._nativeICoreWebView2HttpResponseHeadersValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2HttpResponseHeadersValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2HttpResponseHeadersValue;
			}
			set
			{
				this._nativeICoreWebView2HttpResponseHeadersValue = value;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006576 File Offset: 0x00004776
		internal CoreWebView2HttpResponseHeaders(object rawCoreWebView2HttpResponseHeaders)
		{
			this._rawNative = rawCoreWebView2HttpResponseHeaders;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006588 File Offset: 0x00004788
		public void AppendHeader(string name, string value)
		{
			try
			{
				this._nativeICoreWebView2HttpResponseHeaders.AppendHeader(name, value);
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

		// Token: 0x060000BF RID: 191 RVA: 0x00006608 File Offset: 0x00004808
		public bool Contains(string name)
		{
			bool result;
			try
			{
				result = (this._nativeICoreWebView2HttpResponseHeaders.Contains(name) != 0);
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

		// Token: 0x060000C0 RID: 192 RVA: 0x0000668C File Offset: 0x0000488C
		public string GetHeader(string name)
		{
			string header;
			try
			{
				header = this._nativeICoreWebView2HttpResponseHeaders.GetHeader(name);
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
			return header;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000670C File Offset: 0x0000490C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetHeaders(string name)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpResponseHeaders.GetHeaders(name));
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00006790 File Offset: 0x00004990
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetIterator()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpResponseHeaders.GetIterator());
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

		// Token: 0x04000036 RID: 54
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders _nativeICoreWebView2HttpResponseHeadersValue;

		// Token: 0x04000037 RID: 55
		internal object _rawNative;
	}
}
