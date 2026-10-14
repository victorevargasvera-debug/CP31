using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F6 RID: 246
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	internal interface IXmlElement : global::Newtonsoft.Json.Converters.IXmlNode
	{
		// Token: 0x06000CCA RID: 3274
		void SetAttributeNode(global::Newtonsoft.Json.Converters.IXmlNode attribute);

		// Token: 0x06000CCB RID: 3275
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000CCC RID: 3276
		bool IsEmpty { get; }
	}
}
