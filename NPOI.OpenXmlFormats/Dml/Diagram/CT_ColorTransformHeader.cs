using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000384 RID: 900
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("colorsDefHdr", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_ColorTransformHeader
	{
		// Token: 0x060023F6 RID: 9206 RVA: 0x0005D08C File Offset: 0x0005B28C
		public CT_ColorTransformHeader()
		{
			this.catLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory>();
			this.descField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription>();
			this.titleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName>();
			this.minVerField = "http://schemas.openxmlformats.org/drawingml/2006/diagram";
			this.resIdField = 0;
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0005D0C7 File Offset: 0x0005B2C7
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x0005D0CF File Offset: 0x0005B2CF
		[global::System.Xml.Serialization.XmlElement("title", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName> title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0005D0E0 File Offset: 0x0005B2E0
		[global::System.Xml.Serialization.XmlElement("desc", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription> desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x0005D0E9 File Offset: 0x0005B2E9
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x0005D0F1 File Offset: 0x0005B2F1
		[global::System.Xml.Serialization.XmlArray(Order = 2)]
		[global::System.Xml.Serialization.XmlArrayItem("cat", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> catLst
		{
			get
			{
				return this.catLstField;
			}
			set
			{
				this.catLstField = value;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0005D0FA File Offset: 0x0005B2FA
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x0005D102 File Offset: 0x0005B302
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0005D10B File Offset: 0x0005B30B
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0005D113 File Offset: 0x0005B313
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueId
		{
			get
			{
				return this.uniqueIdField;
			}
			set
			{
				this.uniqueIdField = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0005D11C File Offset: 0x0005B31C
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0005D124 File Offset: 0x0005B324
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("http://schemas.openxmlformats.org/drawingml/2006/diagram")]
		public string minVer
		{
			get
			{
				return this.minVerField;
			}
			set
			{
				this.minVerField = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0005D12D File Offset: 0x0005B32D
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0005D135 File Offset: 0x0005B335
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int resId
		{
			get
			{
				return this.resIdField;
			}
			set
			{
				this.resIdField = value;
			}
		}

		// Token: 0x04001AA5 RID: 6821
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTName> titleField;

		// Token: 0x04001AA6 RID: 6822
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTDescription> descField;

		// Token: 0x04001AA7 RID: 6823
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_CTCategory> catLstField;

		// Token: 0x04001AA8 RID: 6824
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001AA9 RID: 6825
		private string uniqueIdField;

		// Token: 0x04001AAA RID: 6826
		private string minVerField;

		// Token: 0x04001AAB RID: 6827
		private int resIdField;
	}
}
