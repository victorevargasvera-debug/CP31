using System;
using System.ComponentModel;

namespace CefSharp
{
	// Token: 0x02000079 RID: 121
	public interface IPostDataElement : global::System.IDisposable
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F6 RID: 758
		// (set) Token: 0x060002F7 RID: 759
		string File { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002F8 RID: 760
		bool IsReadOnly { get; }

		// Token: 0x060002F9 RID: 761
		void SetToEmpty();

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002FA RID: 762
		global::CefSharp.PostDataElementType Type { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002FB RID: 763
		// (set) Token: 0x060002FC RID: 764
		byte[] Bytes { get; set; }

		// Token: 0x060002FD RID: 765
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::CefSharp.IPostDataElement UnWrap();
	}
}
