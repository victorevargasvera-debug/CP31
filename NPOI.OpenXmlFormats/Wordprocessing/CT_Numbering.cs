using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000AD RID: 173
	public class CT_Numbering
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x0000D88C File Offset: 0x0000BA8C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering ct_Numbering = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering();
			ct_Numbering.numPicBullet = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet>();
			ct_Numbering.abstractNum = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum>();
			ct_Numbering.num = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "numIdMacAtCleanup")
				{
					ct_Numbering.numIdMacAtCleanup = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numPicBullet")
				{
					ct_Numbering.numPicBullet.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "abstractNum")
				{
					ct_Numbering.abstractNum.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "num")
				{
					ct_Numbering.num.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Numbering;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:numbering xmlns:wpc=\"http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas\" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp14=\"http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing\" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" ");
			sw.Write("xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\">");
			if (this.numIdMacAtCleanup != null)
			{
				this.numIdMacAtCleanup.Write(sw, "numIdMacAtCleanup");
			}
			if (this.numPicBullet != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet ct_NumPicBullet in this.numPicBullet)
				{
					ct_NumPicBullet.Write(sw, "numPicBullet");
				}
			}
			if (this.abstractNum != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ct_AbstractNum in this.abstractNum)
				{
					ct_AbstractNum.Write(sw, "abstractNum");
				}
			}
			if (this.num != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num in this.num)
				{
					ct_Num.Write(sw, "num");
				}
			}
			sw.Write("</w:numbering>");
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000DB04 File Offset: 0x0000BD04
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		[global::System.Xml.Serialization.XmlElement("numPicBullet", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet> numPicBullet
		{
			get
			{
				return this.numPicBulletField;
			}
			set
			{
				this.numPicBulletField = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000DB15 File Offset: 0x0000BD15
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x0000DB1D File Offset: 0x0000BD1D
		[global::System.Xml.Serialization.XmlElement("abstractNum", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum> abstractNum
		{
			get
			{
				return this.abstractNumField;
			}
			set
			{
				this.abstractNumField = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0000DB26 File Offset: 0x0000BD26
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x0000DB2E File Offset: 0x0000BD2E
		[global::System.Xml.Serialization.XmlElement("num", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num> num
		{
			get
			{
				return this.numField;
			}
			set
			{
				this.numField = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000DB37 File Offset: 0x0000BD37
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000DB3F File Offset: 0x0000BD3F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numIdMacAtCleanup
		{
			get
			{
				return this.numIdMacAtCleanupField;
			}
			set
			{
				this.numIdMacAtCleanupField = value;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000DB26 File Offset: 0x0000BD26
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num> GetNumList()
		{
			return this.numField;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000DB15 File Offset: 0x0000BD15
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum> GetAbstractNumList()
		{
			return this.abstractNumField;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num AddNewNum()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num();
			if (this.numField == null)
			{
				this.numField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num>();
			}
			this.numField.Add(ct_Num);
			return ct_Num;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		public void SetNumArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num)
		{
			if (this.numField == null)
			{
				this.numField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num>();
			}
			if (pos < 0 || pos >= this.numField.Count)
			{
				this.numField.Add(ct_Num);
			}
			this.numField[pos] = ct_Num;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum AddNewAbstractNum()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ct_AbstractNum = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum();
			if (this.abstractNumField == null)
			{
				this.abstractNumField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum>();
			}
			this.abstractNumField.Add(ct_AbstractNum);
			return ct_AbstractNum;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000DBEF File Offset: 0x0000BDEF
		public void SetAbstractNumArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum cT_AbstractNum)
		{
			if (this.abstractNumField == null)
			{
				this.abstractNumField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum>();
			}
			if (pos < 0 || pos >= this.abstractNumField.Count)
			{
				this.abstractNumField.Add(cT_AbstractNum);
			}
			this.abstractNumField[pos] = cT_AbstractNum;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		public void RemoveAbstractNum(int p)
		{
			if (this.abstractNumField == null)
			{
				return;
			}
			this.abstractNumField.RemoveAt(p);
		}

		// Token: 0x04000423 RID: 1059
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumPicBullet> numPicBulletField;

		// Token: 0x04000424 RID: 1060
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum> abstractNumField;

		// Token: 0x04000425 RID: 1061
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num> numField;

		// Token: 0x04000426 RID: 1062
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numIdMacAtCleanupField;
	}
}
