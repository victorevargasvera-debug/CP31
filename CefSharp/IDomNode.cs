using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CefSharp
{
	// Token: 0x0200006E RID: 110
	public interface IDomNode : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
	{
		// Token: 0x170000BF RID: 191
		string this[string attributeName]
		{
			get;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000241 RID: 577
		string TagName { get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000242 RID: 578
		global::System.Collections.ObjectModel.ReadOnlyCollection<string> AttributeNames { get; }

		// Token: 0x06000243 RID: 579
		bool HasAttribute(string attributeName);
	}
}
