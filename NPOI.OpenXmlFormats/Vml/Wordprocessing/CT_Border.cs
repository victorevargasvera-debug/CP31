using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x020001F9 RID: 505
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Border
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x00040008 File Offset: 0x0003E208
		public static global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border ct_Border = new global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border();
			if (node.Attributes["type"] != null)
			{
				ct_Border.type = (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderType), node.Attributes["type"].Value);
			}
			ct_Border.width = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["width"]);
			ct_Border.shadow = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadBorderShadow(node.Attributes["shadow"]);
			return ct_Border;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00040098 File Offset: 0x0003E298
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.type != global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "width", this.width);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "shadow", this.shadow);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0004011B File Offset: 0x0003E31B
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x00040123 File Offset: 0x0003E323
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0004012C File Offset: 0x0003E32C
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x00040134 File Offset: 0x0003E334
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0004013D File Offset: 0x0003E33D
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x00040145 File Offset: 0x0003E345
		[global::System.Xml.Serialization.XmlAttribute(DataType = "positiveInteger")]
		public string width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0004014E File Offset: 0x0003E34E
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x00040156 File Offset: 0x0003E356
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0004015F File Offset: 0x0003E35F
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x00040167 File Offset: 0x0003E367
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shadowSpecified
		{
			get
			{
				return this.shadowFieldSpecified;
			}
			set
			{
				this.shadowFieldSpecified = value;
			}
		}

		// Token: 0x04000FBE RID: 4030
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderType typeField;

		// Token: 0x04000FBF RID: 4031
		private bool typeFieldSpecified;

		// Token: 0x04000FC0 RID: 4032
		private string widthField;

		// Token: 0x04000FC1 RID: 4033
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.ST_BorderShadow shadowField;

		// Token: 0x04000FC2 RID: 4034
		private bool shadowFieldSpecified;
	}
}
