using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000B RID: 11
	public class CoreWebView2HttpRequestHeaders : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
	{
		// Token: 0x060000AC RID: 172 RVA: 0x000060FC File Offset: 0x000042FC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006114 File Offset: 0x00004314
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000612C File Offset: 0x0000432C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetEnumerator()
		{
			return this.GetIterator();
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00006144 File Offset: 0x00004344
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000061A0 File Offset: 0x000043A0
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders _nativeICoreWebView2HttpRequestHeaders
		{
			get
			{
				bool flag = this._nativeICoreWebView2HttpRequestHeadersValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2HttpRequestHeadersValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2HttpRequestHeadersValue;
			}
			set
			{
				this._nativeICoreWebView2HttpRequestHeadersValue = value;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000061AA File Offset: 0x000043AA
		internal CoreWebView2HttpRequestHeaders(object rawCoreWebView2HttpRequestHeaders)
		{
			this._rawNative = rawCoreWebView2HttpRequestHeaders;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000061BC File Offset: 0x000043BC
		public string GetHeader(string name)
		{
			string header;
			try
			{
				header = this._nativeICoreWebView2HttpRequestHeaders.GetHeader(name);
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

		// Token: 0x060000B3 RID: 179 RVA: 0x0000623C File Offset: 0x0000443C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetHeaders(string name)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpRequestHeaders.GetHeaders(name));
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

		// Token: 0x060000B4 RID: 180 RVA: 0x000062C0 File Offset: 0x000044C0
		public bool Contains(string name)
		{
			bool result;
			try
			{
				result = (this._nativeICoreWebView2HttpRequestHeaders.Contains(name) != 0);
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

		// Token: 0x060000B5 RID: 181 RVA: 0x00006344 File Offset: 0x00004544
		public void SetHeader(string name, string value)
		{
			try
			{
				this._nativeICoreWebView2HttpRequestHeaders.SetHeader(name, value);
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

		// Token: 0x060000B6 RID: 182 RVA: 0x000063C4 File Offset: 0x000045C4
		public void RemoveHeader(string name)
		{
			try
			{
				this._nativeICoreWebView2HttpRequestHeaders.RemoveHeader(name);
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

		// Token: 0x060000B7 RID: 183 RVA: 0x00006444 File Offset: 0x00004644
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator GetIterator()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpHeadersCollectionIterator(this._nativeICoreWebView2HttpRequestHeaders.GetIterator());
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

		// Token: 0x04000034 RID: 52
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders _nativeICoreWebView2HttpRequestHeadersValue;

		// Token: 0x04000035 RID: 53
		internal object _rawNative;
	}
}
