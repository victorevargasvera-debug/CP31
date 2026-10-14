using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000250 RID: 592
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Cell3D
	{
		// Token: 0x0600180C RID: 6156 RVA: 0x00043789 File Offset: 0x00041989
		public CT_Cell3D()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.lightRigField = new global::NPOI.OpenXmlFormats.Dml.CT_LightRig();
			this.bevelField = new global::NPOI.OpenXmlFormats.Dml.CT_Bevel();
			this.prstMaterialField = global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType.plastic;
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000437B9 File Offset: 0x000419B9
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x000437C1 File Offset: 0x000419C1
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevel
		{
			get
			{
				return this.bevelField;
			}
			set
			{
				this.bevelField = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000437CA File Offset: 0x000419CA
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x000437D2 File Offset: 0x000419D2
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LightRig lightRig
		{
			get
			{
				return this.lightRigField;
			}
			set
			{
				this.lightRigField = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000437DB File Offset: 0x000419DB
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x000437E3 File Offset: 0x000419E3
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000437EC File Offset: 0x000419EC
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x000437F4 File Offset: 0x000419F4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType.plastic)]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType prstMaterial
		{
			get
			{
				return this.prstMaterialField;
			}
			set
			{
				this.prstMaterialField = value;
			}
		}

		// Token: 0x04001287 RID: 4743
		private global::NPOI.OpenXmlFormats.Dml.CT_Bevel bevelField;

		// Token: 0x04001288 RID: 4744
		private global::NPOI.OpenXmlFormats.Dml.CT_LightRig lightRigField;

		// Token: 0x04001289 RID: 4745
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400128A RID: 4746
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetMaterialType prstMaterialField;
	}
}
