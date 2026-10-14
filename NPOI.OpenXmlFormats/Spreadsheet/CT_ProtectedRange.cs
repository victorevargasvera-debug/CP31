using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058A RID: 1418
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ProtectedRange
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x00096FA8 File Offset: 0x000951A8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ProtectedRange
			{
				password = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["password"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				securityDescriptor = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["securityDescriptor"]),
				sqref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sqref"])
			};
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0009702C File Offset: 0x0009522C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "password", this.password);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "securityDescriptor", this.securityDescriptor);
			if (this.sqref != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sqref", global::NPOI.OpenXml4Net.Util.XmlHelper.EncodeXml(this.sqref));
			}
			sw.Write("/>");
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000970A6 File Offset: 0x000952A6
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x000970AE File Offset: 0x000952AE
		public byte[] password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x000970B7 File Offset: 0x000952B7
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x000970BF File Offset: 0x000952BF
		public string sqref
		{
			get
			{
				return this.sqrefField;
			}
			set
			{
				this.sqrefField = value;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x000970C8 File Offset: 0x000952C8
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x000970D0 File Offset: 0x000952D0
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

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x000970D9 File Offset: 0x000952D9
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x000970E1 File Offset: 0x000952E1
		public string securityDescriptor
		{
			get
			{
				return this.securityDescriptorField;
			}
			set
			{
				this.securityDescriptorField = value;
			}
		}

		// Token: 0x04002794 RID: 10132
		private byte[] passwordField;

		// Token: 0x04002795 RID: 10133
		private string sqrefField;

		// Token: 0x04002796 RID: 10134
		private string nameField;

		// Token: 0x04002797 RID: 10135
		private string securityDescriptorField;
	}
}
