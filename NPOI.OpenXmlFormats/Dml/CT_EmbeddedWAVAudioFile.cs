using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C8 RID: 712
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EmbeddedWAVAudioFile
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x0004DA97 File Offset: 0x0004BC97
		public CT_EmbeddedWAVAudioFile()
		{
			this.nameField = "";
			this.builtInField = false;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0004DAB4 File Offset: 0x0004BCB4
		public static global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_EmbeddedWAVAudioFile
			{
				embed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["embed"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				builtIn = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["builtIn"])
			};
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0004DB1C File Offset: 0x0004BD1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "embed", this.embed);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "builtIn", this.builtIn);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0004DB89 File Offset: 0x0004BD89
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0004DB91 File Offset: 0x0004BD91
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string embed
		{
			get
			{
				return this.embedField;
			}
			set
			{
				this.embedField = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0004DB9A File Offset: 0x0004BD9A
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0004DBA2 File Offset: 0x0004BDA2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
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

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0004DBAB File Offset: 0x0004BDAB
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0004DBB3 File Offset: 0x0004BDB3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool builtIn
		{
			get
			{
				return this.builtInField;
			}
			set
			{
				this.builtInField = value;
			}
		}

		// Token: 0x04001602 RID: 5634
		private string embedField;

		// Token: 0x04001603 RID: 5635
		private string nameField;

		// Token: 0x04001604 RID: 5636
		private bool builtInField;
	}
}
