using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000006 RID: 6
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties")]
	[global::System.Xml.Serialization.XmlRoot("Properties", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/custom-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomProperties
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000023BB File Offset: 0x000005BB
		public CT_CustomProperties()
		{
			this.propertyField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property>();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000023CE File Offset: 0x000005CE
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000023D6 File Offset: 0x000005D6
		[global::System.Xml.Serialization.XmlElement("property")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property> property
		{
			get
			{
				return this.propertyField;
			}
			set
			{
				this.propertyField = value;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023DF File Offset: 0x000005DF
		public int sizeOfPropertyArray()
		{
			return this.propertyField.Count;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000023EC File Offset: 0x000005EC
		public global::NPOI.OpenXmlFormats.CT_Property AddNewProperty()
		{
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = new global::NPOI.OpenXmlFormats.CT_Property();
			this.propertyField.Add(ct_Property);
			return ct_Property;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000240C File Offset: 0x0000060C
		public global::NPOI.OpenXmlFormats.CT_Property GetPropertyArray(int index)
		{
			return this.propertyField[index];
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000023CE File Offset: 0x000005CE
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property> GetPropertyList()
		{
			return this.propertyField;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000241C File Offset: 0x0000061C
		public global::NPOI.OpenXmlFormats.CT_Property GetProperty(string name)
		{
			for (int i = 0; i < this.propertyField.Count; i++)
			{
				if (this.propertyField[i].name.Equals(name, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					return this.propertyField[i];
				}
			}
			return null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002468 File Offset: 0x00000668
		public global::NPOI.OpenXmlFormats.CT_CustomProperties Copy()
		{
			global::NPOI.OpenXmlFormats.CT_CustomProperties ct_CustomProperties = new global::NPOI.OpenXmlFormats.CT_CustomProperties();
			ct_CustomProperties.propertyField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property>();
			foreach (global::NPOI.OpenXmlFormats.CT_Property item in this.propertyField)
			{
				ct_CustomProperties.propertyField.Add(item);
			}
			return ct_CustomProperties;
		}

		// Token: 0x0400000B RID: 11
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property> propertyField;
	}
}
