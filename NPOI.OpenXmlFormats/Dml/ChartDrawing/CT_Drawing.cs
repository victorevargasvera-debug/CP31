using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.ChartDrawing
{
	// Token: 0x0200047D RID: 1149
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Drawing
	{
		// Token: 0x06002DC9 RID: 11721 RVA: 0x00072DF1 File Offset: 0x00070FF1
		public CT_Drawing()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x00072E04 File Offset: 0x00071004
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x00072E0C File Offset: 0x0007100C
		[global::System.Xml.Serialization.XmlElement("absSizeAnchor", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_AbsSizeAnchor), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("relSizeAnchor", typeof(global::NPOI.OpenXmlFormats.Dml.ChartDrawing.CT_RelSizeAnchor), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x04001FC0 RID: 8128
		private global::System.Collections.Generic.List<object> itemsField;
	}
}
