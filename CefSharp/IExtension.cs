using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x02000070 RID: 112
	public interface IExtension
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000263 RID: 611
		string Identifier { get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000264 RID: 612
		string Path { get; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000265 RID: 613
		global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> Manifest { get; }

		// Token: 0x06000266 RID: 614
		bool IsSame(global::CefSharp.IExtension that);

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000267 RID: 615
		global::CefSharp.IRequestContext LoaderContext { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000268 RID: 616
		bool IsLoaded { get; }

		// Token: 0x06000269 RID: 617
		void Unload();
	}
}
