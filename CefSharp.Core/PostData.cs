using System;
using System.Collections.Generic;
using System.ComponentModel;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x02000009 RID: 9
	public class PostData : global::CefSharp.IPostData, global::System.IDisposable
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002CDF File Offset: 0x00000EDF
		public global::System.Collections.Generic.IList<global::CefSharp.IPostDataElement> Elements
		{
			get
			{
				return this.postData.Elements;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002CEC File Offset: 0x00000EEC
		public bool IsReadOnly
		{
			get
			{
				return this.postData.IsReadOnly;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public bool IsDisposed
		{
			get
			{
				return this.postData.IsDisposed;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002D06 File Offset: 0x00000F06
		public bool HasExcludedElements
		{
			get
			{
				return this.postData.HasExcludedElements;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002D13 File Offset: 0x00000F13
		public bool AddElement(global::CefSharp.IPostDataElement element)
		{
			return this.postData.AddElement(element);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002D21 File Offset: 0x00000F21
		public global::CefSharp.IPostDataElement CreatePostDataElement()
		{
			return new global::CefSharp.Core.PostDataElement();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002D28 File Offset: 0x00000F28
		public void Dispose()
		{
			this.postData.Dispose();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002D35 File Offset: 0x00000F35
		public bool RemoveElement(global::CefSharp.IPostDataElement element)
		{
			return this.postData.RemoveElement(element);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002D43 File Offset: 0x00000F43
		public void RemoveElements()
		{
			this.postData.RemoveElements();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002D50 File Offset: 0x00000F50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::CefSharp.IPostData UnWrap()
		{
			return this.postData;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002D58 File Offset: 0x00000F58
		public static global::CefSharp.IPostData Create()
		{
			return new global::CefSharp.Core.PostData();
		}

		// Token: 0x04000005 RID: 5
		private global::CefSharp.Core.PostData postData = new global::CefSharp.Core.PostData();
	}
}
