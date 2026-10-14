using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F7 RID: 247
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	internal interface IXmlNode
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000CCD RID: 3277
		global::System.Xml.XmlNodeType NodeType { get; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000CCE RID: 3278
		string LocalName { get; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000CCF RID: 3279
		[global::System.Runtime.CompilerServices.Nullable(1)]
		global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> ChildNodes { [global::System.Runtime.CompilerServices.NullableContext(1)] get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000CD0 RID: 3280
		[global::System.Runtime.CompilerServices.Nullable(1)]
		global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> Attributes { [global::System.Runtime.CompilerServices.NullableContext(1)] get; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000CD1 RID: 3281
		global::Newtonsoft.Json.Converters.IXmlNode ParentNode { get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000CD2 RID: 3282
		// (set) Token: 0x06000CD3 RID: 3283
		string Value { get; set; }

		// Token: 0x06000CD4 RID: 3284
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		global::Newtonsoft.Json.Converters.IXmlNode AppendChild(global::Newtonsoft.Json.Converters.IXmlNode newChild);

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000CD5 RID: 3285
		string NamespaceUri { get; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000CD6 RID: 3286
		object WrappedNode { get; }
	}
}
