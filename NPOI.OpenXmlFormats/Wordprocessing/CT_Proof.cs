using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200017C RID: 380
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Proof
	{
		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002E914 File Offset: 0x0002CB14
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof ct_Proof = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Proof();
			if (node.Attributes["w:spelling"] != null)
			{
				ct_Proof.spelling = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof), node.Attributes["w:spelling"].Value);
			}
			if (node.Attributes["w:grammar"] != null)
			{
				ct_Proof.grammar = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof), node.Attributes["w:grammar"].Value);
			}
			return ct_Proof;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:spelling", this.spelling.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:grammar", this.grammar.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0002EA28 File Offset: 0x0002CC28
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x0002EA30 File Offset: 0x0002CC30
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof spelling
		{
			get
			{
				return this.spellingField;
			}
			set
			{
				this.spellingField = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0002EA39 File Offset: 0x0002CC39
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0002EA41 File Offset: 0x0002CC41
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spellingSpecified
		{
			get
			{
				return this.spellingFieldSpecified;
			}
			set
			{
				this.spellingFieldSpecified = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0002EA4A File Offset: 0x0002CC4A
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0002EA52 File Offset: 0x0002CC52
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof grammar
		{
			get
			{
				return this.grammarField;
			}
			set
			{
				this.grammarField = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0002EA5B File Offset: 0x0002CC5B
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0002EA63 File Offset: 0x0002CC63
		[global::System.Xml.Serialization.XmlIgnore]
		public bool grammarSpecified
		{
			get
			{
				return this.grammarFieldSpecified;
			}
			set
			{
				this.grammarFieldSpecified = value;
			}
		}

		// Token: 0x04000BAB RID: 2987
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof spellingField;

		// Token: 0x04000BAC RID: 2988
		private bool spellingFieldSpecified;

		// Token: 0x04000BAD RID: 2989
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Proof grammarField;

		// Token: 0x04000BAE RID: 2990
		private bool grammarFieldSpecified;
	}
}
