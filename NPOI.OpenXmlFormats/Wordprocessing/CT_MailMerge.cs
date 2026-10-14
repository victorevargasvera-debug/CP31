using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000180 RID: 384
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMerge
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x0002EB34 File Offset: 0x0002CD34
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge ct_MailMerge = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMerge();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mainDocumentType")
				{
					ct_MailMerge.mainDocumentType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "linkToQuery")
				{
					ct_MailMerge.linkToQuery = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataType")
				{
					ct_MailMerge.dataType = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "connectString")
				{
					ct_MailMerge.connectString = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "query")
				{
					ct_MailMerge.query = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dataSource")
				{
					ct_MailMerge.dataSource = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headerSource")
				{
					ct_MailMerge.headerSource = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "doNotSuppressBlankLines")
				{
					ct_MailMerge.doNotSuppressBlankLines = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "destination")
				{
					ct_MailMerge.destination = global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "addressFieldName")
				{
					ct_MailMerge.addressFieldName = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mailSubject")
				{
					ct_MailMerge.mailSubject = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mailAsAttachment")
				{
					ct_MailMerge.mailAsAttachment = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "viewMergedData")
				{
					ct_MailMerge.viewMergedData = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "activeRecord")
				{
					ct_MailMerge.activeRecord = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "checkErrors")
				{
					ct_MailMerge.checkErrors = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "odso")
				{
					ct_MailMerge.odso = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_MailMerge;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.mainDocumentType != null)
			{
				this.mainDocumentType.Write(sw, "mainDocumentType");
			}
			if (this.linkToQuery != null)
			{
				this.linkToQuery.Write(sw, "linkToQuery");
			}
			if (this.dataType != null)
			{
				this.dataType.Write(sw, "dataType");
			}
			if (this.connectString != null)
			{
				this.connectString.Write(sw, "connectString");
			}
			if (this.query != null)
			{
				this.query.Write(sw, "query");
			}
			if (this.dataSource != null)
			{
				this.dataSource.Write(sw, "dataSource");
			}
			if (this.headerSource != null)
			{
				this.headerSource.Write(sw, "headerSource");
			}
			if (this.doNotSuppressBlankLines != null)
			{
				this.doNotSuppressBlankLines.Write(sw, "doNotSuppressBlankLines");
			}
			if (this.destination != null)
			{
				this.destination.Write(sw, "destination");
			}
			if (this.addressFieldName != null)
			{
				this.addressFieldName.Write(sw, "addressFieldName");
			}
			if (this.mailSubject != null)
			{
				this.mailSubject.Write(sw, "mailSubject");
			}
			if (this.mailAsAttachment != null)
			{
				this.mailAsAttachment.Write(sw, "mailAsAttachment");
			}
			if (this.viewMergedData != null)
			{
				this.viewMergedData.Write(sw, "viewMergedData");
			}
			if (this.activeRecord != null)
			{
				this.activeRecord.Write(sw, "activeRecord");
			}
			if (this.checkErrors != null)
			{
				this.checkErrors.Write(sw, "checkErrors");
			}
			if (this.odso != null)
			{
				this.odso.Write(sw, "odso");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0002EFA2 File Offset: 0x0002D1A2
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0002EFAA File Offset: 0x0002D1AA
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType mainDocumentType
		{
			get
			{
				return this.mainDocumentTypeField;
			}
			set
			{
				this.mainDocumentTypeField = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0002EFB3 File Offset: 0x0002D1B3
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0002EFBB File Offset: 0x0002D1BB
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkToQuery
		{
			get
			{
				return this.linkToQueryField;
			}
			set
			{
				this.linkToQueryField = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0002EFCC File Offset: 0x0002D1CC
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType dataType
		{
			get
			{
				return this.dataTypeField;
			}
			set
			{
				this.dataTypeField = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0002EFD5 File Offset: 0x0002D1D5
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x0002EFDD File Offset: 0x0002D1DD
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String connectString
		{
			get
			{
				return this.connectStringField;
			}
			set
			{
				this.connectStringField = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0002EFE6 File Offset: 0x0002D1E6
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x0002EFEE File Offset: 0x0002D1EE
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0002EFF7 File Offset: 0x0002D1F7
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0002EFFF File Offset: 0x0002D1FF
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel dataSource
		{
			get
			{
				return this.dataSourceField;
			}
			set
			{
				this.dataSourceField = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0002F008 File Offset: 0x0002D208
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0002F010 File Offset: 0x0002D210
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel headerSource
		{
			get
			{
				return this.headerSourceField;
			}
			set
			{
				this.headerSourceField = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0002F019 File Offset: 0x0002D219
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0002F021 File Offset: 0x0002D221
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressBlankLines
		{
			get
			{
				return this.doNotSuppressBlankLinesField;
			}
			set
			{
				this.doNotSuppressBlankLinesField = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0002F02A File Offset: 0x0002D22A
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0002F032 File Offset: 0x0002D232
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest destination
		{
			get
			{
				return this.destinationField;
			}
			set
			{
				this.destinationField = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0002F03B File Offset: 0x0002D23B
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0002F043 File Offset: 0x0002D243
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String addressFieldName
		{
			get
			{
				return this.addressFieldNameField;
			}
			set
			{
				this.addressFieldNameField = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0002F04C File Offset: 0x0002D24C
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0002F054 File Offset: 0x0002D254
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String mailSubject
		{
			get
			{
				return this.mailSubjectField;
			}
			set
			{
				this.mailSubjectField = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0002F05D File Offset: 0x0002D25D
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x0002F065 File Offset: 0x0002D265
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mailAsAttachment
		{
			get
			{
				return this.mailAsAttachmentField;
			}
			set
			{
				this.mailAsAttachmentField = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0002F06E File Offset: 0x0002D26E
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x0002F076 File Offset: 0x0002D276
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff viewMergedData
		{
			get
			{
				return this.viewMergedDataField;
			}
			set
			{
				this.viewMergedDataField = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0002F07F File Offset: 0x0002D27F
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x0002F087 File Offset: 0x0002D287
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber activeRecord
		{
			get
			{
				return this.activeRecordField;
			}
			set
			{
				this.activeRecordField = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0002F090 File Offset: 0x0002D290
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x0002F098 File Offset: 0x0002D298
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber checkErrors
		{
			get
			{
				return this.checkErrorsField;
			}
			set
			{
				this.checkErrorsField = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0002F0A1 File Offset: 0x0002D2A1
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0002F0A9 File Offset: 0x0002D2A9
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso odso
		{
			get
			{
				return this.odsoField;
			}
			set
			{
				this.odsoField = value;
			}
		}

		// Token: 0x04000BB7 RID: 2999
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType mainDocumentTypeField;

		// Token: 0x04000BB8 RID: 3000
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkToQueryField;

		// Token: 0x04000BB9 RID: 3001
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType dataTypeField;

		// Token: 0x04000BBA RID: 3002
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String connectStringField;

		// Token: 0x04000BBB RID: 3003
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String queryField;

		// Token: 0x04000BBC RID: 3004
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel dataSourceField;

		// Token: 0x04000BBD RID: 3005
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel headerSourceField;

		// Token: 0x04000BBE RID: 3006
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSuppressBlankLinesField;

		// Token: 0x04000BBF RID: 3007
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest destinationField;

		// Token: 0x04000BC0 RID: 3008
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String addressFieldNameField;

		// Token: 0x04000BC1 RID: 3009
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String mailSubjectField;

		// Token: 0x04000BC2 RID: 3010
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff mailAsAttachmentField;

		// Token: 0x04000BC3 RID: 3011
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff viewMergedDataField;

		// Token: 0x04000BC4 RID: 3012
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber activeRecordField;

		// Token: 0x04000BC5 RID: 3013
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber checkErrorsField;

		// Token: 0x04000BC6 RID: 3014
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Odso odsoField;
	}
}
