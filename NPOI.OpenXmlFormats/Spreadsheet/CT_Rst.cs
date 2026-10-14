using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F8 RID: 1272
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Rst
	{
		// Token: 0x06003610 RID: 13840 RVA: 0x00086C5F File Offset: 0x00084E5F
		public void Set(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst o)
		{
			this.tField = o.tField;
			this.rField = o.rField;
			this.rPhField = o.rPhField;
			this.phoneticPrField = o.phoneticPrField;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00086C94 File Offset: 0x00084E94
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.t != null)
			{
				sw.Write(string.Format("<t xml:space=\"preserve\">{0}</t>", global::NPOI.OpenXml4Net.Util.XmlHelper.ExcelEncodeString(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.t))));
			}
			if (this.r != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in this.r)
				{
					ct_RElt.Write(sw, "r");
				}
			}
			if (this.rPh != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun ct_PhoneticRun in this.rPh)
				{
					ct_PhoneticRun.Write(sw, "rPh");
				}
			}
			if (this.phoneticPr != null)
			{
				this.phoneticPr.Write(sw, "phoneticPr");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00086DA4 File Offset: 0x00084FA4
		public bool IsSetT()
		{
			return this.tField != null;
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x00086DAF File Offset: 0x00084FAF
		public void unsetT()
		{
			this.tField = null;
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x00086DB8 File Offset: 0x00084FB8
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x00086DC0 File Offset: 0x00084FC0
		[global::System.Xml.Serialization.XmlElement("t", DataType = "string")]
		public string t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x00086DC9 File Offset: 0x00084FC9
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x00086DD1 File Offset: 0x00084FD1
		[global::System.Xml.Serialization.XmlElement("r")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt> r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x00086DDC File Offset: 0x00084FDC
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x0008721C File Offset: 0x0008541C
		[global::System.Xml.Serialization.XmlIgnore]
		public string XmlText
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(stringBuilder))
				{
					if (this.rField != null && this.rField.Count > 0)
					{
						foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in this.rField)
						{
							stringWriter.Write("<r>");
							if (ct_RElt.rPr != null)
							{
								stringWriter.Write("<rPr>");
								if (ct_RElt.rPr.b != null && ct_RElt.rPr.b.val)
								{
									stringWriter.Write("<b/>");
								}
								if (ct_RElt.rPr.i != null && ct_RElt.rPr.i.val)
								{
									stringWriter.Write("<i/>");
								}
								if (ct_RElt.rPr.u != null)
								{
									stringWriter.Write("<u val=\"" + ct_RElt.rPr.u.val.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.color != null && ct_RElt.rPr.color.theme > 0U)
								{
									stringWriter.Write("<color theme=\"" + ct_RElt.rPr.color.theme.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.color != null && ct_RElt.rPr.color.rgbSpecified)
								{
									stringWriter.Write("<color rgb=\"" + global::System.BitConverter.ToString(ct_RElt.rPr.color.rgb).Replace("-", string.Empty) + "\"/>");
								}
								if (ct_RElt.rPr.rFont != null)
								{
									stringWriter.Write("<rFont val=\"" + ct_RElt.rPr.rFont.val + "\"/>");
								}
								if (ct_RElt.rPr.family != null)
								{
									stringWriter.Write("<family val=\"" + ct_RElt.rPr.family.val.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.charset != null)
								{
									stringWriter.Write("<charset val=\"" + ct_RElt.rPr.charset.val.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.scheme != null)
								{
									stringWriter.Write("<scheme val=\"" + ct_RElt.rPr.scheme.val.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.sz != null)
								{
									stringWriter.Write("<sz val=\"" + ct_RElt.rPr.sz.val.ToString() + "\"/>");
								}
								if (ct_RElt.rPr.vertAlign != null)
								{
									stringWriter.Write("<vertAlign val=\"" + ct_RElt.rPr.vertAlign.val.ToString() + "\"/>");
								}
								stringWriter.Write("</rPr>");
							}
							if (ct_RElt.t != null)
							{
								stringWriter.Write("<t");
								if (ct_RElt.t.IndexOf(' ') >= 0)
								{
									stringWriter.Write(" xml:space=\"preserve\"");
								}
								stringWriter.Write(">");
								stringWriter.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(ct_RElt.t));
								stringWriter.Write("</t>");
							}
							stringWriter.Write("</r>");
						}
					}
					if (this.t != null)
					{
						stringWriter.Write("<t");
						if (this.t.IndexOf(' ') >= 0)
						{
							stringWriter.Write(" xml:space=\"preserve\"");
						}
						stringWriter.Write(">");
						stringWriter.Write(global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.t));
						stringWriter.Write("</t>");
					}
					this.xmltext = stringBuilder.ToString();
				}
				return this.xmltext;
			}
			set
			{
				this.xmltext = value;
			}
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00087228 File Offset: 0x00085428
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt AddNewR()
		{
			if (this.rField == null)
			{
				this.rField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt();
			this.rField.Add(ct_RElt);
			return ct_RElt;
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0008725B File Offset: 0x0008545B
		public int sizeOfRArray()
		{
			if (this.rField != null)
			{
				return this.r.Count;
			}
			return 0;
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00087272 File Offset: 0x00085472
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt GetRArray(int index)
		{
			if (this.rField != null)
			{
				return this.rField[index];
			}
			return null;
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x0008728A File Offset: 0x0008548A
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x00087292 File Offset: 0x00085492
		[global::System.Xml.Serialization.XmlElement("rPh")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun> rPh
		{
			get
			{
				return this.rPhField;
			}
			set
			{
				this.rPhField = value;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x0008729B File Offset: 0x0008549B
		// (set) Token: 0x06003620 RID: 13856 RVA: 0x000872A3 File Offset: 0x000854A3
		[global::System.Xml.Serialization.XmlElement("phoneticPr")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPr
		{
			get
			{
				return this.phoneticPrField;
			}
			set
			{
				this.phoneticPrField = value;
			}
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x000872AC File Offset: 0x000854AC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst ct_Rst = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();
			ct_Rst.r = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt>();
			ct_Rst.rPh = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "phoneticPr")
				{
					ct_Rst.phoneticPr = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_Rst.r.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rPh")
				{
					ct_Rst.rPh.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "t")
				{
					ct_Rst.t = xmlNode.InnerText.Replace("\r", "");
				}
			}
			return ct_Rst;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x000873BC File Offset: 0x000855BC
		public int SizeOfRArray()
		{
			return this.r.Count;
		}

		// Token: 0x040023A7 RID: 9127
		private string tField;

		// Token: 0x040023A8 RID: 9128
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt> rField;

		// Token: 0x040023A9 RID: 9129
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticRun> rPhField;

		// Token: 0x040023AA RID: 9130
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PhoneticPr phoneticPrField;

		// Token: 0x040023AB RID: 9131
		private string xmltext;
	}
}
