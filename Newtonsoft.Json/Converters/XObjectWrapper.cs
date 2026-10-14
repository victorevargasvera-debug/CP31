using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FF RID: 255
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class XObjectWrapper : global::Newtonsoft.Json.Converters.IXmlNode
	{
		// Token: 0x06000D0D RID: 3341 RVA: 0x0003353E File Offset: 0x0003173E
		public XObjectWrapper(global::System.Xml.Linq.XObject xmlObject)
		{
			this._xmlObject = xmlObject;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003354D File Offset: 0x0003174D
		public object WrappedNode
		{
			get
			{
				return this._xmlObject;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00033555 File Offset: 0x00031755
		public virtual global::System.Xml.XmlNodeType NodeType
		{
			get
			{
				global::System.Xml.Linq.XObject xmlObject = this._xmlObject;
				if (xmlObject == null)
				{
					return global::System.Xml.XmlNodeType.None;
				}
				return xmlObject.NodeType;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00033568 File Offset: 0x00031768
		public virtual string LocalName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0003356B File Offset: 0x0003176B
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public virtual global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> ChildNodes
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return global::Newtonsoft.Json.Converters.XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00033572 File Offset: 0x00031772
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public virtual global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> Attributes
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return global::Newtonsoft.Json.Converters.XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00033579 File Offset: 0x00031779
		public virtual global::Newtonsoft.Json.Converters.IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003357C File Offset: 0x0003177C
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0003357F File Offset: 0x0003177F
		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00033586 File Offset: 0x00031786
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::Newtonsoft.Json.Converters.IXmlNode AppendChild(global::Newtonsoft.Json.Converters.IXmlNode newChild)
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0003358D File Offset: 0x0003178D
		public virtual string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040003F2 RID: 1010
		private readonly global::System.Xml.Linq.XObject _xmlObject;
	}
}
