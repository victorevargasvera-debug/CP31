using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044E RID: 1102
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AxDataSource
	{
		// Token: 0x06002C05 RID: 11269 RVA: 0x0006E994 File Offset: 0x0006CB94
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource ct_AxDataSource = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "numLit")
				{
					ct_AxDataSource.numLit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRef")
				{
					ct_AxDataSource.numRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strLit")
				{
					ct_AxDataSource.strLit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strRef")
				{
					ct_AxDataSource.strRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "multiLvlStrRef")
				{
					ct_AxDataSource.multiLvlStrRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AxDataSource;
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.numLit != null)
			{
				this.numLit.Write(sw, "numLit");
			}
			if (this.numRef != null)
			{
				this.numRef.Write(sw, "numRef");
			}
			if (this.strLit != null)
			{
				this.strLit.Write(sw, "strLit");
			}
			if (this.strRef != null)
			{
				this.strRef.Write(sw, "strRef");
			}
			if (this.multiLvlStrRef != null)
			{
				this.multiLvlStrRef.Write(sw, "multiLvlStrRef");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0006EB57 File Offset: 0x0006CD57
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef AddNewNumRef()
		{
			this.numRefField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef();
			return this.numRefField;
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x0006EB6A File Offset: 0x0006CD6A
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData AddNewNumLit()
		{
			this.numLit = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData();
			return this.numLit;
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x0006EB7D File Offset: 0x0006CD7D
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x0006EB85 File Offset: 0x0006CD85
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numLit
		{
			get
			{
				return this.numLitField;
			}
			set
			{
				this.numLitField = value;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x0006EB8E File Offset: 0x0006CD8E
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x0006EB96 File Offset: 0x0006CD96
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef numRef
		{
			get
			{
				return this.numRefField;
			}
			set
			{
				this.numRefField = value;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x0006EB9F File Offset: 0x0006CD9F
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x0006EBA7 File Offset: 0x0006CDA7
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData strLit
		{
			get
			{
				return this.strLitField;
			}
			set
			{
				this.strLitField = value;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x0006EBB8 File Offset: 0x0006CDB8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRef
		{
			get
			{
				return this.strRefField;
			}
			set
			{
				this.strRefField = value;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x0006EBC1 File Offset: 0x0006CDC1
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0006EBC9 File Offset: 0x0006CDC9
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef multiLvlStrRef
		{
			get
			{
				return this.multiLvlStrRefField;
			}
			set
			{
				this.multiLvlStrRefField = value;
			}
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0006EBD2 File Offset: 0x0006CDD2
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef AddNewStrRef()
		{
			this.strRef = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef();
			return this.strRef;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x0006EBE5 File Offset: 0x0006CDE5
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData AddNewStrLit()
		{
			this.strLit = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData();
			return this.strLit;
		}

		// Token: 0x04001F11 RID: 7953
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef multiLvlStrRefField;

		// Token: 0x04001F12 RID: 7954
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numLitField;

		// Token: 0x04001F13 RID: 7955
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef numRefField;

		// Token: 0x04001F14 RID: 7956
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData strLitField;

		// Token: 0x04001F15 RID: 7957
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef strRefField;
	}
}
