using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000608 RID: 1544
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OleItem
	{
		// Token: 0x0600439F RID: 17311 RVA: 0x000A0E94 File Offset: 0x0009F094
		public CT_OleItem()
		{
			this.iconField = false;
			this.adviseField = false;
			this.preferPicField = false;
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x000A0EB1 File Offset: 0x0009F0B1
		// (set) Token: 0x060043A1 RID: 17313 RVA: 0x000A0EB9 File Offset: 0x0009F0B9
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x000A0EC2 File Offset: 0x0009F0C2
		// (set) Token: 0x060043A3 RID: 17315 RVA: 0x000A0ECA File Offset: 0x0009F0CA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool icon
		{
			get
			{
				return this.iconField;
			}
			set
			{
				this.iconField = value;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x000A0ED3 File Offset: 0x0009F0D3
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x000A0EDB File Offset: 0x0009F0DB
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool advise
		{
			get
			{
				return this.adviseField;
			}
			set
			{
				this.adviseField = value;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x000A0EE4 File Offset: 0x0009F0E4
		// (set) Token: 0x060043A7 RID: 17319 RVA: 0x000A0EEC File Offset: 0x0009F0EC
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool preferPic
		{
			get
			{
				return this.preferPicField;
			}
			set
			{
				this.preferPicField = value;
			}
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000A0EF8 File Offset: 0x0009F0F8
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem Parse(global::System.Xml.XmlNode node)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				advise = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["advise"]),
				icon = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["icon"]),
				preferPic = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["preferPic"])
			};
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000A0F78 File Offset: 0x0009F178
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "advise", this.advise);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "icon", this.iconField, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "preferPic", this.preferPic);
			sw.Write(string.Format("/>", nodeName));
		}

		// Token: 0x04002A95 RID: 10901
		private string nameField;

		// Token: 0x04002A96 RID: 10902
		private bool iconField;

		// Token: 0x04002A97 RID: 10903
		private bool adviseField;

		// Token: 0x04002A98 RID: 10904
		private bool preferPicField;
	}
}
