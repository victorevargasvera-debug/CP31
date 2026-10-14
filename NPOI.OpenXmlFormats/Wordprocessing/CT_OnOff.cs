using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000040 RID: 64
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OnOff
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00003EF0 File Offset: 0x000020F0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			if (node.Attributes["w:val"] != null)
			{
				ct_OnOff.valField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["w:val"]);
			}
			else
			{
				ct_OnOff.valField = true;
			}
			return ct_OnOff;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003F3F File Offset: 0x0000213F
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (!this.valField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.valField, true);
			}
			sw.Write("/>");
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00003F77 File Offset: 0x00002177
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00003F7F File Offset: 0x0000217F
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public bool val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
				this.valFieldSpecified = true;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00003F8F File Offset: 0x0000218F
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00003F97 File Offset: 0x00002197
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003FA0 File Offset: 0x000021A0
		public void UnSetVal()
		{
			this.val = false;
			this.valFieldSpecified = false;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003F8F File Offset: 0x0000218F
		public bool IsSetVal()
		{
			return this.valFieldSpecified;
		}

		// Token: 0x0400019F RID: 415
		private bool valField;

		// Token: 0x040001A0 RID: 416
		private bool valFieldSpecified;
	}
}
