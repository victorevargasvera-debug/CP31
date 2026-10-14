using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CefSharp
{
	// Token: 0x02000078 RID: 120
	public interface IPostData : global::System.IDisposable
	{
		// Token: 0x060002ED RID: 749
		bool AddElement(global::CefSharp.IPostDataElement element);

		// Token: 0x060002EE RID: 750
		bool RemoveElement(global::CefSharp.IPostDataElement element);

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002EF RID: 751
		global::System.Collections.Generic.IList<global::CefSharp.IPostDataElement> Elements { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002F0 RID: 752
		bool IsReadOnly { get; }

		// Token: 0x060002F1 RID: 753
		void RemoveElements();

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F2 RID: 754
		bool IsDisposed { get; }

		// Token: 0x060002F3 RID: 755
		global::CefSharp.IPostDataElement CreatePostDataElement();

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F4 RID: 756
		bool HasExcludedElements { get; }

		// Token: 0x060002F5 RID: 757
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::CefSharp.IPostData UnWrap();
	}
}
