using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000322 RID: 802
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LinearShadeProperties
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x00055680 File Offset: 0x00053880
		public static global::NPOI.OpenXmlFormats.Dml.CT_LinearShadeProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_LinearShadeProperties
			{
				ang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["ang"]),
				scaled = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["scaled"])
			};
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000556CD File Offset: 0x000538CD
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ang", this.ang);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scaled", this.scaled);
			sw.Write("/>");
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0005570D File Offset: 0x0005390D
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00055715 File Offset: 0x00053915
		[global::System.Xml.Serialization.XmlAttribute]
		public int ang
		{
			get
			{
				return this.angField;
			}
			set
			{
				this.angField = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0005571E File Offset: 0x0005391E
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00055726 File Offset: 0x00053926
		[global::System.Xml.Serialization.XmlIgnore]
		public bool angSpecified
		{
			get
			{
				return this.angFieldSpecified;
			}
			set
			{
				this.angFieldSpecified = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0005572F File Offset: 0x0005392F
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00055737 File Offset: 0x00053937
		[global::System.Xml.Serialization.XmlAttribute]
		public bool scaled
		{
			get
			{
				return this.scaledField;
			}
			set
			{
				this.scaledField = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00055740 File Offset: 0x00053940
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00055748 File Offset: 0x00053948
		[global::System.Xml.Serialization.XmlIgnore]
		public bool scaledSpecified
		{
			get
			{
				return this.scaledFieldSpecified;
			}
			set
			{
				this.scaledFieldSpecified = value;
			}
		}

		// Token: 0x040018BC RID: 6332
		private int angField;

		// Token: 0x040018BD RID: 6333
		private bool angFieldSpecified;

		// Token: 0x040018BE RID: 6334
		private bool scaledField;

		// Token: 0x040018BF RID: 6335
		private bool scaledFieldSpecified;
	}
}
