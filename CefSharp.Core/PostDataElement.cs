using System;
using System.ComponentModel;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x0200000A RID: 10
	public class PostDataElement : global::CefSharp.IPostDataElement, global::System.IDisposable
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002D72 File Offset: 0x00000F72
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002D7F File Offset: 0x00000F7F
		public string File
		{
			get
			{
				return this.postDataElement.File;
			}
			set
			{
				this.postDataElement.File = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002D8D File Offset: 0x00000F8D
		public bool IsReadOnly
		{
			get
			{
				return this.postDataElement.IsReadOnly;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002D9A File Offset: 0x00000F9A
		public global::CefSharp.PostDataElementType Type
		{
			get
			{
				return this.postDataElement.Type;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002DA7 File Offset: 0x00000FA7
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public byte[] Bytes
		{
			get
			{
				return this.postDataElement.Bytes;
			}
			set
			{
				this.postDataElement.Bytes = value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public void Dispose()
		{
			this.postDataElement.Dispose();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002DCF File Offset: 0x00000FCF
		public void SetToEmpty()
		{
			this.postDataElement.SetToEmpty();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002DDC File Offset: 0x00000FDC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::CefSharp.IPostDataElement UnWrap()
		{
			return this.postDataElement;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public static global::CefSharp.IPostDataElement Create()
		{
			return new global::CefSharp.Core.PostDataElement();
		}

		// Token: 0x04000006 RID: 6
		internal global::CefSharp.Core.PostDataElement postDataElement = new global::CefSharp.Core.PostDataElement();
	}
}
