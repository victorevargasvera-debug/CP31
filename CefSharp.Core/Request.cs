using System;
using System.Collections.Specialized;
using System.ComponentModel;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x0200000B RID: 11
	public class Request : global::CefSharp.IRequest, global::System.IDisposable
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002DFE File Offset: 0x00000FFE
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002E0B File Offset: 0x0000100B
		public global::CefSharp.UrlRequestFlags Flags
		{
			get
			{
				return this.request.Flags;
			}
			set
			{
				this.request.Flags = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002E19 File Offset: 0x00001019
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002E26 File Offset: 0x00001026
		public string Url
		{
			get
			{
				return this.request.Url;
			}
			set
			{
				this.request.Url = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002E34 File Offset: 0x00001034
		public ulong Identifier
		{
			get
			{
				return this.request.Identifier;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002E41 File Offset: 0x00001041
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002E4E File Offset: 0x0000104E
		public string Method
		{
			get
			{
				return this.request.Method;
			}
			set
			{
				this.request.Method = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002E5C File Offset: 0x0000105C
		public string ReferrerUrl
		{
			get
			{
				return this.request.ReferrerUrl;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002E69 File Offset: 0x00001069
		public global::CefSharp.ResourceType ResourceType
		{
			get
			{
				return this.request.ResourceType;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002E76 File Offset: 0x00001076
		public global::CefSharp.ReferrerPolicy ReferrerPolicy
		{
			get
			{
				return this.request.ReferrerPolicy;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002E83 File Offset: 0x00001083
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002E90 File Offset: 0x00001090
		public global::System.Collections.Specialized.NameValueCollection Headers
		{
			get
			{
				return this.request.Headers;
			}
			set
			{
				this.request.Headers = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002E9E File Offset: 0x0000109E
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002EAB File Offset: 0x000010AB
		public global::CefSharp.IPostData PostData
		{
			get
			{
				return this.request.PostData;
			}
			set
			{
				this.request.PostData = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002EB9 File Offset: 0x000010B9
		public global::CefSharp.TransitionType TransitionType
		{
			get
			{
				return this.request.TransitionType;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002EC6 File Offset: 0x000010C6
		public bool IsDisposed
		{
			get
			{
				return this.request.IsDisposed;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002ED3 File Offset: 0x000010D3
		public bool IsReadOnly
		{
			get
			{
				return this.request.IsReadOnly;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002EE0 File Offset: 0x000010E0
		public void Dispose()
		{
			this.request.Dispose();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002EED File Offset: 0x000010ED
		public string GetHeaderByName(string name)
		{
			return this.request.GetHeaderByName(name);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002EFB File Offset: 0x000010FB
		public void InitializePostData()
		{
			this.request.InitializePostData();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002F08 File Offset: 0x00001108
		public void SetHeaderByName(string name, string value, bool overwrite)
		{
			this.request.SetHeaderByName(name, value, overwrite);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002F18 File Offset: 0x00001118
		public void SetReferrer(string referrerUrl, global::CefSharp.ReferrerPolicy policy)
		{
			this.request.SetReferrer(referrerUrl, policy);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002F27 File Offset: 0x00001127
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::CefSharp.IRequest UnWrap()
		{
			return this.request;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002F2F File Offset: 0x0000112F
		public static global::CefSharp.IRequest Create()
		{
			return new global::CefSharp.Core.Request();
		}

		// Token: 0x04000007 RID: 7
		internal global::CefSharp.Core.Request request = new global::CefSharp.Core.Request();
	}
}
