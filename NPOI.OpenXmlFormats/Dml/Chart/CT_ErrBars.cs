using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000443 RID: 1091
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ErrBars
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x0006DC30 File Offset: 0x0006BE30
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars ct_ErrBars = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars();
			ct_ErrBars.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "errDir")
				{
					ct_ErrBars.errDir = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "errBarType")
				{
					ct_ErrBars.errBarType = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "errValType")
				{
					ct_ErrBars.errValType = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noEndCap")
				{
					ct_ErrBars.noEndCap = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "plus")
				{
					ct_ErrBars.plus = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minus")
				{
					ct_ErrBars.minus = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_ErrBars.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_ErrBars.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ErrBars.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ErrBars;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.errDir != null)
			{
				this.errDir.Write(sw, "errDir");
			}
			if (this.errBarType != null)
			{
				this.errBarType.Write(sw, "errBarType");
			}
			if (this.errValType != null)
			{
				this.errValType.Write(sw, "errValType");
			}
			if (this.noEndCap != null)
			{
				this.noEndCap.Write(sw, "noEndCap");
			}
			if (this.plus != null)
			{
				this.plus.Write(sw, "plus");
			}
			if (this.minus != null)
			{
				this.minus.Write(sw, "minus");
			}
			if (this.val != null)
			{
				this.val.Write(sw, "val");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x0006DF3C File Offset: 0x0006C13C
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x0006DF44 File Offset: 0x0006C144
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir errDir
		{
			get
			{
				return this.errDirField;
			}
			set
			{
				this.errDirField = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x0006DF4D File Offset: 0x0006C14D
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x0006DF55 File Offset: 0x0006C155
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType errBarType
		{
			get
			{
				return this.errBarTypeField;
			}
			set
			{
				this.errBarTypeField = value;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x0006DF5E File Offset: 0x0006C15E
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x0006DF66 File Offset: 0x0006C166
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType errValType
		{
			get
			{
				return this.errValTypeField;
			}
			set
			{
				this.errValTypeField = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0006DF6F File Offset: 0x0006C16F
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x0006DF77 File Offset: 0x0006C177
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean noEndCap
		{
			get
			{
				return this.noEndCapField;
			}
			set
			{
				this.noEndCapField = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0006DF80 File Offset: 0x0006C180
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x0006DF88 File Offset: 0x0006C188
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource plus
		{
			get
			{
				return this.plusField;
			}
			set
			{
				this.plusField = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0006DF91 File Offset: 0x0006C191
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x0006DF99 File Offset: 0x0006C199
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource minus
		{
			get
			{
				return this.minusField;
			}
			set
			{
				this.minusField = value;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0006DFA2 File Offset: 0x0006C1A2
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x0006DFAA File Offset: 0x0006C1AA
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x0006DFB3 File Offset: 0x0006C1B3
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x0006DFBB File Offset: 0x0006C1BB
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x0006DFC4 File Offset: 0x0006C1C4
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x0006DFCC File Offset: 0x0006C1CC
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04001EEC RID: 7916
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrDir errDirField;

		// Token: 0x04001EED RID: 7917
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBarType errBarTypeField;

		// Token: 0x04001EEE RID: 7918
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrValType errValTypeField;

		// Token: 0x04001EEF RID: 7919
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean noEndCapField;

		// Token: 0x04001EF0 RID: 7920
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource plusField;

		// Token: 0x04001EF1 RID: 7921
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource minusField;

		// Token: 0x04001EF2 RID: 7922
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double valField;

		// Token: 0x04001EF3 RID: 7923
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001EF4 RID: 7924
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
