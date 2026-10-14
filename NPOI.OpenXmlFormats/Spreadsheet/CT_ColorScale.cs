using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200059E RID: 1438
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ColorScale
	{
		// Token: 0x06003F95 RID: 16277 RVA: 0x0009A1F5 File Offset: 0x000983F5
		public CT_ColorScale()
		{
			this.colorField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>();
			this.cfvoField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x0009A213 File Offset: 0x00098413
		// (set) Token: 0x06003F97 RID: 16279 RVA: 0x0009A21B File Offset: 0x0009841B
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo> cfvo
		{
			get
			{
				return this.cfvoField;
			}
			set
			{
				this.cfvoField = value;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x0009A224 File Offset: 0x00098424
		// (set) Token: 0x06003F99 RID: 16281 RVA: 0x0009A22C File Offset: 0x0009842C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x0009A238 File Offset: 0x00098438
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale ct_ColorScale = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale();
			ct_ColorScale.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
			ct_ColorScale.color = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cfvo")
				{
					ct_ColorScale.cfvo.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_ColorScale.color.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ColorScale;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0009A2F8 File Offset: 0x000984F8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo AddNewCfvo()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo();
			this.cfvo.Add(ct_Cfvo);
			return ct_Cfvo;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x0009A318 File Offset: 0x00098518
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color AddNewColor()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
			this.color.Add(ct_Color);
			return ct_Color;
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x0009A338 File Offset: 0x00098538
		public void RemoveCfvo(int p)
		{
			this.cfvo.RemoveAt(p);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0009A346 File Offset: 0x00098546
		public void RemoveColor(int p)
		{
			this.color.RemoveAt(p);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0009A354 File Offset: 0x00098554
		public int SizeOfCfvoArray()
		{
			if (this.cfvo != null)
			{
				return this.cfvo.Count;
			}
			return 0;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0009A36B File Offset: 0x0009856B
		public int SizeOfColorArray()
		{
			if (this.color != null)
			{
				return this.color.Count;
			}
			return 0;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0009A384 File Offset: 0x00098584
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.cfvo != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo in this.cfvo)
				{
					ct_Cfvo.Write(sw, "cfvo");
				}
			}
			if (this.color != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color in this.color)
				{
					ct_Color.Write(sw, "color");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002830 RID: 10288
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo> cfvoField;

		// Token: 0x04002831 RID: 10289
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> colorField;
	}
}
