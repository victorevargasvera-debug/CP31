using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000002 RID: 2
	public class CustomPropertiesDocument
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public CustomPropertiesDocument(global::NPOI.OpenXmlFormats.CT_CustomProperties prop)
		{
			this._props = prop;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000025F
		public CustomPropertiesDocument()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002067 File Offset: 0x00000267
		public global::NPOI.OpenXmlFormats.CT_CustomProperties GetProperties()
		{
			return this._props;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000206F File Offset: 0x0000026F
		public global::NPOI.OpenXmlFormats.CT_CustomProperties AddNewProperties()
		{
			this._props = new global::NPOI.OpenXmlFormats.CT_CustomProperties();
			return this._props;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002082 File Offset: 0x00000282
		public global::NPOI.OpenXmlFormats.CustomPropertiesDocument Copy()
		{
			return new global::NPOI.OpenXmlFormats.CustomPropertiesDocument
			{
				_props = this._props.Copy()
			};
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209A File Offset: 0x0000029A
		public static global::NPOI.OpenXmlFormats.CustomPropertiesDocument Parse(global::System.IO.Stream stream)
		{
			return new global::NPOI.OpenXmlFormats.CustomPropertiesDocument((global::NPOI.OpenXmlFormats.CT_CustomProperties)global::NPOI.OpenXmlFormats.CustomPropertiesDocument.serializer.Deserialize(stream));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B1 File Offset: 0x000002B1
		public void Save(global::System.IO.Stream stream)
		{
			global::NPOI.OpenXmlFormats.CustomPropertiesDocument.serializer.Serialize(stream, this._props, global::NPOI.OpenXmlFormats.CustomPropertiesDocument.namespaces);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020CC File Offset: 0x000002CC
		public override string ToString()
		{
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter())
			{
				global::NPOI.OpenXmlFormats.CustomPropertiesDocument.serializer.Serialize(stringWriter, this._props);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		internal static global::System.Xml.Serialization.XmlSerializer serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::NPOI.OpenXmlFormats.CT_CustomProperties));

		// Token: 0x04000002 RID: 2
		internal static global::System.Xml.Serialization.XmlSerializerNamespaces namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces(new global::System.Xml.XmlQualifiedName[]
		{
			new global::System.Xml.XmlQualifiedName("", "http://schemas.openxmlformats.org/spreadsheetml/2006/main"),
			new global::System.Xml.XmlQualifiedName("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")
		});

		// Token: 0x04000003 RID: 3
		private global::NPOI.OpenXmlFormats.CT_CustomProperties _props;
	}
}
