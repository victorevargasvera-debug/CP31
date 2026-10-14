using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000003 RID: 3
	public class ExtendedPropertiesDocument
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000205F File Offset: 0x0000025F
		public ExtendedPropertiesDocument()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002169 File Offset: 0x00000369
		public ExtendedPropertiesDocument(global::NPOI.OpenXmlFormats.CT_ExtendedProperties prop)
		{
			this._props = prop;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002178 File Offset: 0x00000378
		public global::NPOI.OpenXmlFormats.CT_ExtendedProperties GetProperties()
		{
			return this._props;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002180 File Offset: 0x00000380
		public global::NPOI.OpenXmlFormats.CT_ExtendedProperties AddNewProperties()
		{
			this._props = new global::NPOI.OpenXmlFormats.CT_ExtendedProperties();
			return this._props;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002193 File Offset: 0x00000393
		public global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument Copy()
		{
			return new global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument
			{
				_props = this._props.Copy()
			};
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021AB File Offset: 0x000003AB
		public static global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument Parse(global::System.IO.Stream stream)
		{
			return new global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument((global::NPOI.OpenXmlFormats.CT_ExtendedProperties)global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument.serializer.Deserialize(stream));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021C2 File Offset: 0x000003C2
		public void Save(global::System.IO.Stream stream)
		{
			global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument.serializer.Serialize(stream, this._props, global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument.namespaces);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021DC File Offset: 0x000003DC
		public override string ToString()
		{
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter())
			{
				global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument.serializer.Serialize(stringWriter, this._props);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x04000004 RID: 4
		internal static global::System.Xml.Serialization.XmlSerializer serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::NPOI.OpenXmlFormats.CT_ExtendedProperties));

		// Token: 0x04000005 RID: 5
		internal static global::System.Xml.Serialization.XmlSerializerNamespaces namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces(new global::System.Xml.XmlQualifiedName[]
		{
			new global::System.Xml.XmlQualifiedName("", "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties"),
			new global::System.Xml.XmlQualifiedName("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")
		});

		// Token: 0x04000006 RID: 6
		private global::NPOI.OpenXmlFormats.CT_ExtendedProperties _props;
	}
}
