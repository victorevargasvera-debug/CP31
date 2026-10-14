using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000625 RID: 1573
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FileSharing
	{
		// Token: 0x06004484 RID: 17540 RVA: 0x000A2C3E File Offset: 0x000A0E3E
		public CT_FileSharing()
		{
			this.readOnlyRecommendedField = false;
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000A2C50 File Offset: 0x000A0E50
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileSharing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FileSharing
			{
				readOnlyRecommended = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["readOnlyRecommended"]),
				userName = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["userName"]),
				reservationPassword = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["reservationPassword"])
			};
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x000A2CB8 File Offset: 0x000A0EB8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "readOnlyRecommended", this.readOnlyRecommended);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "userName", this.userName);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "reservationPassword", this.reservationPassword);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x000A2D25 File Offset: 0x000A0F25
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x000A2D2D File Offset: 0x000A0F2D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool readOnlyRecommended
		{
			get
			{
				return this.readOnlyRecommendedField;
			}
			set
			{
				this.readOnlyRecommendedField = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x000A2D36 File Offset: 0x000A0F36
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x000A2D3E File Offset: 0x000A0F3E
		[global::System.Xml.Serialization.XmlAttribute]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x000A2D47 File Offset: 0x000A0F47
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x000A2D4F File Offset: 0x000A0F4F
		[global::System.Xml.Serialization.XmlAttribute]
		public byte[] reservationPassword
		{
			get
			{
				return this.reservationPasswordField;
			}
			set
			{
				this.reservationPasswordField = value;
			}
		}

		// Token: 0x04002B02 RID: 11010
		private bool readOnlyRecommendedField;

		// Token: 0x04002B03 RID: 11011
		private string userNameField;

		// Token: 0x04002B04 RID: 11012
		private byte[] reservationPasswordField;
	}
}
