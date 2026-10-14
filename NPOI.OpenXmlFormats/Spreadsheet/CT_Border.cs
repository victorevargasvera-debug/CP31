using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F0 RID: 1264
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Border
	{
		// Token: 0x06003541 RID: 13633 RVA: 0x000853EC File Offset: 0x000835EC
		public override string ToString()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
			this.Write(streamWriter, "border");
			streamWriter.Flush();
			memoryStream.Position = 0L;
			string result;
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0008544C File Offset: 0x0008364C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ct_Border = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
			ct_Border.diagonalUp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["diagonalUp"]);
			ct_Border.diagonalDown = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["diagonalDown"]);
			ct_Border.outline = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["outline"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "left")
				{
					ct_Border.left = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "right")
				{
					ct_Border.right = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "top")
				{
					ct_Border.top = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bottom")
				{
					ct_Border.bottom = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "diagonal")
				{
					ct_Border.diagonal = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vertical")
				{
					ct_Border.vertical = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "horizontal")
				{
					ct_Border.horizontal = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Border;
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000855FC File Offset: 0x000837FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "diagonalUp", this.diagonalUp, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "diagonalDown", this.diagonalDown, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outline", this.outline, false);
			sw.Write(">");
			if (this.left != null)
			{
				this.left.Write(sw, "left");
			}
			if (this.right != null)
			{
				this.right.Write(sw, "right");
			}
			if (this.top != null)
			{
				this.top.Write(sw, "top");
			}
			if (this.bottom != null)
			{
				this.bottom.Write(sw, "bottom");
			}
			if (this.diagonal != null)
			{
				this.diagonal.Write(sw, "diagonal");
			}
			if (this.vertical != null)
			{
				this.vertical.Write(sw, "vertical");
			}
			if (this.horizontal != null)
			{
				this.horizontal.Write(sw, "horizontal");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0008571C File Offset: 0x0008391C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border
			{
				bottomField = ((this.bottomField == null) ? null : this.bottomField.Copy()),
				topField = ((this.topField == null) ? null : this.topField.Copy()),
				rightField = ((this.rightField == null) ? null : this.rightField.Copy()),
				leftField = ((this.leftField == null) ? null : this.leftField.Copy()),
				diagonalField = ((this.diagonalField == null) ? null : this.diagonalField.Copy()),
				verticalField = ((this.verticalField == null) ? null : this.verticalField.Copy()),
				horizontalField = ((this.horizontalField == null) ? null : this.horizontalField.Copy()),
				diagonalUpField = this.diagonalUpField,
				diagonalUpFieldSpecified = this.diagonalUpFieldSpecified,
				diagonalDownField = this.diagonalDownField,
				diagonalDownFieldSpecified = this.diagonalDownFieldSpecified,
				outlineField = this.outlineField
			};
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0008582E File Offset: 0x00083A2E
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr AddNewDiagonal()
		{
			if (this.diagonalField == null)
			{
				this.diagonalField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			}
			return this.diagonalField;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00085849 File Offset: 0x00083A49
		public bool IsSetDiagonal()
		{
			return this.diagonalField != null;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00085854 File Offset: 0x00083A54
		public void unsetDiagonal()
		{
			this.diagonalField = null;
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0008585D File Offset: 0x00083A5D
		public void unsetRight()
		{
			this.rightField = null;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00085866 File Offset: 0x00083A66
		public void unsetLeft()
		{
			this.leftField = null;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0008586F File Offset: 0x00083A6F
		public void unsetTop()
		{
			this.topField = null;
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00085878 File Offset: 0x00083A78
		public void UnsetBottom()
		{
			this.bottomField = null;
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00085881 File Offset: 0x00083A81
		public bool IsSetBottom()
		{
			return this.bottomField != null;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0008588C File Offset: 0x00083A8C
		public bool IsSetLeft()
		{
			return this.leftField != null;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x00085897 File Offset: 0x00083A97
		public bool IsSetRight()
		{
			return this.rightField != null;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000858A2 File Offset: 0x00083AA2
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border Parse(string p)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(p);
			return global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border.Parse(xmlDocument.DocumentElement, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.CreateDefaultNSM());
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000858BF File Offset: 0x00083ABF
		public bool IsSetTop()
		{
			return this.topField != null;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000858CA File Offset: 0x00083ACA
		public bool IsSetBorder()
		{
			return this.leftField != null || this.rightField != null || this.topField != null || this.bottomField != null;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000858EF File Offset: 0x00083AEF
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr AddNewTop()
		{
			if (this.topField == null)
			{
				this.topField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			}
			return this.topField;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0008590A File Offset: 0x00083B0A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr AddNewRight()
		{
			if (this.rightField == null)
			{
				this.rightField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			}
			return this.rightField;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00085925 File Offset: 0x00083B25
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr AddNewLeft()
		{
			if (this.leftField == null)
			{
				this.leftField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			}
			return this.leftField;
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00085940 File Offset: 0x00083B40
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr AddNewBottom()
		{
			if (this.bottomField == null)
			{
				this.bottomField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr();
			}
			return this.bottomField;
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x0008595B File Offset: 0x00083B5B
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x00085963 File Offset: 0x00083B63
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr left
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

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x0008596C File Offset: 0x00083B6C
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x00085974 File Offset: 0x00083B74
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr right
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

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0008597D File Offset: 0x00083B7D
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x00085985 File Offset: 0x00083B85
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr top
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

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x0008598E File Offset: 0x00083B8E
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x00085996 File Offset: 0x00083B96
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr bottom
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

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0008599F File Offset: 0x00083B9F
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x000859A7 File Offset: 0x00083BA7
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr diagonal
		{
			get
			{
				return this.diagonalField;
			}
			set
			{
				this.diagonalField = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000859B0 File Offset: 0x00083BB0
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x000859B8 File Offset: 0x00083BB8
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr vertical
		{
			get
			{
				return this.verticalField;
			}
			set
			{
				this.verticalField = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x000859C1 File Offset: 0x00083BC1
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x000859C9 File Offset: 0x00083BC9
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr horizontal
		{
			get
			{
				return this.horizontalField;
			}
			set
			{
				this.horizontalField = value;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x000859D2 File Offset: 0x00083BD2
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x000859DA File Offset: 0x00083BDA
		[global::System.Xml.Serialization.XmlAttribute]
		public bool diagonalUp
		{
			get
			{
				return this.diagonalUpField;
			}
			set
			{
				this.diagonalUpField = value;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x000859E3 File Offset: 0x00083BE3
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x000859EB File Offset: 0x00083BEB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool diagonalUpSpecified
		{
			get
			{
				return this.diagonalUpFieldSpecified;
			}
			set
			{
				this.diagonalUpFieldSpecified = value;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x000859F4 File Offset: 0x00083BF4
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x000859FC File Offset: 0x00083BFC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool diagonalDown
		{
			get
			{
				return this.diagonalDownField;
			}
			set
			{
				this.diagonalDownField = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00085A05 File Offset: 0x00083C05
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00085A0D File Offset: 0x00083C0D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool diagonalDownSpecified
		{
			get
			{
				return this.diagonalDownFieldSpecified;
			}
			set
			{
				this.diagonalDownFieldSpecified = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x00085A16 File Offset: 0x00083C16
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x00085A1E File Offset: 0x00083C1E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x0400237F RID: 9087
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr leftField;

		// Token: 0x04002380 RID: 9088
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr rightField;

		// Token: 0x04002381 RID: 9089
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr topField;

		// Token: 0x04002382 RID: 9090
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr bottomField;

		// Token: 0x04002383 RID: 9091
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr diagonalField;

		// Token: 0x04002384 RID: 9092
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr verticalField;

		// Token: 0x04002385 RID: 9093
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr horizontalField;

		// Token: 0x04002386 RID: 9094
		private bool diagonalUpField;

		// Token: 0x04002387 RID: 9095
		private bool diagonalUpFieldSpecified;

		// Token: 0x04002388 RID: 9096
		private bool diagonalDownField;

		// Token: 0x04002389 RID: 9097
		private bool diagonalDownFieldSpecified;

		// Token: 0x0400238A RID: 9098
		private bool outlineField;
	}
}
