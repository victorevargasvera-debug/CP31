using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002ED RID: 749
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2D
	{
		// Token: 0x06001CFD RID: 7421 RVA: 0x0004EB38 File Offset: 0x0004CD38
		public static global::NPOI.OpenXmlFormats.Dml.CT_Path2D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Path2D ct_Path2D = new global::NPOI.OpenXmlFormats.Dml.CT_Path2D();
			ct_Path2D.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["w"]);
			ct_Path2D.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["h"]);
			if (node.Attributes["fill"] != null)
			{
				ct_Path2D.fill = (global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode), node.Attributes["fill"].Value);
			}
			ct_Path2D.stroke = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["stroke"]);
			ct_Path2D.extrusionOk = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["extrusionOk"]);
			return ct_Path2D;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0004EC00 File Offset: 0x0004CE00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w", (double)this.w);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "h", (double)this.h);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fill", this.fill.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stroke", this.stroke);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "extrusionOk", this.extrusionOk);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0004EC9F File Offset: 0x0004CE9F
		public CT_Path2D()
		{
			this.wField = 0L;
			this.hField = 0L;
			this.fillField = global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode.norm;
			this.strokeField = true;
			this.extrusionOkField = true;
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0004ECCC File Offset: 0x0004CECC
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0004ECD4 File Offset: 0x0004CED4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0004ECDD File Offset: 0x0004CEDD
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0004ECE5 File Offset: 0x0004CEE5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0004ECEE File Offset: 0x0004CEEE
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0004ECF6 File Offset: 0x0004CEF6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode.norm)]
		public global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0004ECFF File Offset: 0x0004CEFF
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0004ED07 File Offset: 0x0004CF07
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool stroke
		{
			get
			{
				return this.strokeField;
			}
			set
			{
				this.strokeField = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0004ED10 File Offset: 0x0004CF10
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0004ED18 File Offset: 0x0004CF18
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool extrusionOk
		{
			get
			{
				return this.extrusionOkField;
			}
			set
			{
				this.extrusionOkField = value;
			}
		}

		// Token: 0x0400175D RID: 5981
		private long wField;

		// Token: 0x0400175E RID: 5982
		private long hField;

		// Token: 0x0400175F RID: 5983
		private global::NPOI.OpenXmlFormats.Dml.ST_PathFillMode fillField;

		// Token: 0x04001760 RID: 5984
		private bool strokeField;

		// Token: 0x04001761 RID: 5985
		private bool extrusionOkField;
	}
}
