using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001B7 RID: 439
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblCellMar
	{
		// Token: 0x0600109E RID: 4254 RVA: 0x0003600C File Offset: 0x0003420C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar ct_TblCellMar = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblCellMar();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "top")
				{
					ct_TblCellMar.top = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "left")
				{
					ct_TblCellMar.left = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_TblCellMar.bottom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_TblCellMar.right = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TblCellMar;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000360F4 File Offset: 0x000342F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.top != null)
			{
				this.top.Write(sw, "top");
			}
			if (this.left != null)
			{
				this.left.Write(sw, "left");
			}
			if (this.bottom != null)
			{
				this.bottom.Write(sw, "bottom");
			}
			if (this.right != null)
			{
				this.right.Write(sw, "right");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00036192 File Offset: 0x00034392
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0003619A File Offset: 0x0003439A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x000361A3 File Offset: 0x000343A3
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x000361AB File Offset: 0x000343AB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x000361B4 File Offset: 0x000343B4
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x000361BC File Offset: 0x000343BC
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000361C5 File Offset: 0x000343C5
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x000361CD File Offset: 0x000343CD
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000361D6 File Offset: 0x000343D6
		public bool IsSetLeft()
		{
			return this.leftField != null;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000361E1 File Offset: 0x000343E1
		public bool IsSetTop()
		{
			return this.topField != null;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000361EC File Offset: 0x000343EC
		public bool IsSetBottom()
		{
			return this.bottomField != null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000361F7 File Offset: 0x000343F7
		public bool IsSetRight()
		{
			return this.rightField != null;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00036202 File Offset: 0x00034402
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewLeft()
		{
			this.leftField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			return this.leftField;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00036215 File Offset: 0x00034415
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewTop()
		{
			this.topField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			return this.topField;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00036228 File Offset: 0x00034428
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewBottom()
		{
			this.bottomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			return this.bottomField;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0003623B File Offset: 0x0003443B
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth AddNewRight()
		{
			this.rightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth();
			return this.rightField;
		}

		// Token: 0x04000D2E RID: 3374
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth topField;

		// Token: 0x04000D2F RID: 3375
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth leftField;

		// Token: 0x04000D30 RID: 3376
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth bottomField;

		// Token: 0x04000D31 RID: 3377
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth rightField;
	}
}
