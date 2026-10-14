using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C5 RID: 709
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RelativeRect
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x0004D614 File Offset: 0x0004B814
		public static global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_RelativeRect
			{
				l = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["l"]),
				t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["t"]),
				r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["r"]),
				b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["b"])
			};
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0004D698 File Offset: 0x0004B898
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "l", this.l);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.b);
			sw.Write("/>");
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0004D705 File Offset: 0x0004B905
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0004D721 File Offset: 0x0004B921
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int l
		{
			get
			{
				if (this.lField == null)
				{
					return 0;
				}
				return this.lField.Value;
			}
			set
			{
				this.lField = new int?(value);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0004D72F File Offset: 0x0004B92F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lSpecified
		{
			get
			{
				return this.lField != null;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0004D73C File Offset: 0x0004B93C
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0004D758 File Offset: 0x0004B958
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int t
		{
			get
			{
				if (this.tField == null)
				{
					return 0;
				}
				return this.tField.Value;
			}
			set
			{
				this.tField = new int?(value);
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0004D766 File Offset: 0x0004B966
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tSpecified
		{
			get
			{
				return this.tField != null;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0004D773 File Offset: 0x0004B973
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0004D78F File Offset: 0x0004B98F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int r
		{
			get
			{
				if (this.rField == null)
				{
					return 0;
				}
				return this.rField.Value;
			}
			set
			{
				this.rField = new int?(value);
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0004D79D File Offset: 0x0004B99D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rSpecified
		{
			get
			{
				return this.rField != null;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0004D7AA File Offset: 0x0004B9AA
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0004D7C6 File Offset: 0x0004B9C6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int b
		{
			get
			{
				if (this.bField == null)
				{
					return 0;
				}
				return this.bField.Value;
			}
			set
			{
				this.bField = new int?(value);
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0004D7D4 File Offset: 0x0004B9D4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bSpecified
		{
			get
			{
				return this.bField != null;
			}
		}

		// Token: 0x040015F7 RID: 5623
		private int? lField;

		// Token: 0x040015F8 RID: 5624
		private int? tField;

		// Token: 0x040015F9 RID: 5625
		private int? rField;

		// Token: 0x040015FA RID: 5626
		private int? bField;
	}
}
