using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F3 RID: 243
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	internal interface IXmlDocument : global::Newtonsoft.Json.Converters.IXmlNode
	{
		// Token: 0x06000CB4 RID: 3252
		global::Newtonsoft.Json.Converters.IXmlNode CreateComment([global::System.Runtime.CompilerServices.Nullable(2)] string text);

		// Token: 0x06000CB5 RID: 3253
		global::Newtonsoft.Json.Converters.IXmlNode CreateTextNode([global::System.Runtime.CompilerServices.Nullable(2)] string text);

		// Token: 0x06000CB6 RID: 3254
		global::Newtonsoft.Json.Converters.IXmlNode CreateCDataSection([global::System.Runtime.CompilerServices.Nullable(2)] string data);

		// Token: 0x06000CB7 RID: 3255
		global::Newtonsoft.Json.Converters.IXmlNode CreateWhitespace([global::System.Runtime.CompilerServices.Nullable(2)] string text);

		// Token: 0x06000CB8 RID: 3256
		global::Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace([global::System.Runtime.CompilerServices.Nullable(2)] string text);

		// Token: 0x06000CB9 RID: 3257
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		global::Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x06000CBA RID: 3258
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		global::Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000CBB RID: 3259
		global::Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, [global::System.Runtime.CompilerServices.Nullable(2)] string data);

		// Token: 0x06000CBC RID: 3260
		global::Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName);

		// Token: 0x06000CBD RID: 3261
		global::Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06000CBE RID: 3262
		global::Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, [global::System.Runtime.CompilerServices.Nullable(2)] string value);

		// Token: 0x06000CBF RID: 3263
		global::Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [global::System.Runtime.CompilerServices.Nullable(2)] string value);

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000CC0 RID: 3264
		[global::System.Runtime.CompilerServices.Nullable(2)]
		global::Newtonsoft.Json.Converters.IXmlElement DocumentElement { [global::System.Runtime.CompilerServices.NullableContext(2)] get; }
	}
}
