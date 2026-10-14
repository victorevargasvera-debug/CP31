using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000617 RID: 1559
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_BooleanProperty
	{
		// Token: 0x060043F6 RID: 17398 RVA: 0x000A1AF0 File Offset: 0x0009FCF0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			if (node.Attributes["val"] != null)
			{
				ct_BooleanProperty.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["val"]);
			}
			return ct_BooleanProperty;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000A1B36 File Offset: 0x0009FD36
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (!this.val)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			}
			sw.Write("/>");
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000A1B6D File Offset: 0x0009FD6D
		// (set) Token: 0x060043F9 RID: 17401 RVA: 0x000A1B75 File Offset: 0x0009FD75
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool val
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

		// Token: 0x04002ABC RID: 10940
		private bool valField = true;
	}
}
