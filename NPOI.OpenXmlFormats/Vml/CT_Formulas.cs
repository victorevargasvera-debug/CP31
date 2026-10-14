using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D5 RID: 469
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public class CT_Formulas
	{
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0003C383 File Offset: 0x0003A583
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0003C38B File Offset: 0x0003A58B
		[global::System.Xml.Serialization.XmlElement("f", Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_F> f
		{
			get
			{
				return this.fField;
			}
			set
			{
				this.fField = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x0003C394 File Offset: 0x0003A594
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fSpecified
		{
			get
			{
				return this.fField != null;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0003C39F File Offset: 0x0003A59F
		public global::NPOI.OpenXmlFormats.Vml.CT_F AddNewF()
		{
			if (this.fField == null)
			{
				this.fField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_F>();
			}
			this.fField.Add(new global::NPOI.OpenXmlFormats.Vml.CT_F());
			return this.fField[this.fField.Count - 1];
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0003C3DC File Offset: 0x0003A5DC
		public static global::NPOI.OpenXmlFormats.Vml.CT_Formulas Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Formulas ct_Formulas = new global::NPOI.OpenXmlFormats.Vml.CT_Formulas();
			ct_Formulas.f = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_F>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "f")
				{
					ct_Formulas.f.Add(global::NPOI.OpenXmlFormats.Vml.CT_F.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Formulas;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0003C46C File Offset: 0x0003A66C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			sw.Write(">");
			if (this.f != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_F ct_F in this.f)
				{
					ct_F.Write(sw, "f");
				}
			}
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x04000E0E RID: 3598
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_F> fField;
	}
}
