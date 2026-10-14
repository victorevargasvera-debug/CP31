using System;
using System.Collections.Generic;
using CefSharp.Enums;

namespace CefSharp
{
	// Token: 0x02000084 RID: 132
	public interface IValue : global::System.IDisposable
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000349 RID: 841
		global::CefSharp.Enums.ValueType Type { get; }

		// Token: 0x0600034A RID: 842
		bool GetBool();

		// Token: 0x0600034B RID: 843
		double GetDouble();

		// Token: 0x0600034C RID: 844
		int GetInt();

		// Token: 0x0600034D RID: 845
		string GetString();

		// Token: 0x0600034E RID: 846
		global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> GetDictionary();

		// Token: 0x0600034F RID: 847
		global::System.Collections.Generic.IList<global::CefSharp.IValue> GetList();

		// Token: 0x06000350 RID: 848
		object GetObject();
	}
}
