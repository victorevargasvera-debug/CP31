using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000331 RID: 817
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BlurEffect
	{
		// Token: 0x06002085 RID: 8325 RVA: 0x000561D4 File Offset: 0x000543D4
		public static global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_BlurEffect
			{
				rad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["rad"]),
				grow = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["grow"])
			};
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00056224 File Offset: 0x00054424
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rad", (double)this.rad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "grow", this.grow);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00056281 File Offset: 0x00054481
		public CT_BlurEffect()
		{
			this.radField = 0L;
			this.growField = true;
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x00056298 File Offset: 0x00054498
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x000562A0 File Offset: 0x000544A0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long rad
		{
			get
			{
				return this.radField;
			}
			set
			{
				this.radField = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x000562A9 File Offset: 0x000544A9
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x000562B1 File Offset: 0x000544B1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool grow
		{
			get
			{
				return this.growField;
			}
			set
			{
				this.growField = value;
			}
		}

		// Token: 0x04001932 RID: 6450
		private long radField;

		// Token: 0x04001933 RID: 6451
		private bool growField;
	}
}
