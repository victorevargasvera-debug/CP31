using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000209 RID: 521
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeDefaults
	{
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00040F05 File Offset: 0x0003F105
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x00040F0D File Offset: 0x0003F10D
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Fill fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00040F16 File Offset: 0x0003F116
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00040F1E File Offset: 0x0003F11E
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.CT_Stroke stroke
		{
			get
			{
				return this.strokeField;
			}
			set
			{
				this.strokeField = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00040F27 File Offset: 0x0003F127
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00040F2F File Offset: 0x0003F12F
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.CT_Textbox textbox
		{
			get
			{
				return this.textboxField;
			}
			set
			{
				this.textboxField = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00040F38 File Offset: 0x0003F138
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00040F40 File Offset: 0x0003F140
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.CT_Shadow shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00040F49 File Offset: 0x0003F149
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00040F51 File Offset: 0x0003F151
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Skew skew
		{
			get
			{
				return this.skewField;
			}
			set
			{
				this.skewField = value;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00040F5A File Offset: 0x0003F15A
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x00040F62 File Offset: 0x0003F162
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Extrusion extrusion
		{
			get
			{
				return this.extrusionField;
			}
			set
			{
				this.extrusionField = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00040F6B File Offset: 0x0003F16B
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x00040F73 File Offset: 0x0003F173
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Callout callout
		{
			get
			{
				return this.calloutField;
			}
			set
			{
				this.calloutField = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00040F7C File Offset: 0x0003F17C
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00040F84 File Offset: 0x0003F184
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock @lock
		{
			get
			{
				return this.lockField;
			}
			set
			{
				this.lockField = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x00040F8D File Offset: 0x0003F18D
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x00040F95 File Offset: 0x0003F195
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_ColorMru colormru
		{
			get
			{
				return this.colormruField;
			}
			set
			{
				this.colormruField = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00040F9E File Offset: 0x0003F19E
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x00040FA6 File Offset: 0x0003F1A6
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_ColorMenu colormenu
		{
			get
			{
				return this.colormenuField;
			}
			set
			{
				this.colormenuField = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00040FAF File Offset: 0x0003F1AF
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00040FB7 File Offset: 0x0003F1B7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00040FC0 File Offset: 0x0003F1C0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00040FCB File Offset: 0x0003F1CB
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x00040FD3 File Offset: 0x0003F1D3
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string spidmax
		{
			get
			{
				return this.spidmaxField;
			}
			set
			{
				this.spidmaxField = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00040FDC File Offset: 0x0003F1DC
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00040FE4 File Offset: 0x0003F1E4
		[global::System.Xml.Serialization.XmlAttribute]
		public string style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00040FED File Offset: 0x0003F1ED
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00040FF5 File Offset: 0x0003F1F5
		[global::System.Xml.Serialization.XmlAttribute("fill")]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse fill1
		{
			get
			{
				return this.fill1Field;
			}
			set
			{
				this.fill1Field = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00040FFE File Offset: 0x0003F1FE
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00041006 File Offset: 0x0003F206
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fill1Specified
		{
			get
			{
				return this.fill1FieldSpecified;
			}
			set
			{
				this.fill1FieldSpecified = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0004100F File Offset: 0x0003F20F
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00041017 File Offset: 0x0003F217
		[global::System.Xml.Serialization.XmlAttribute]
		public string fillcolor
		{
			get
			{
				return this.fillcolorField;
			}
			set
			{
				this.fillcolorField = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00041020 File Offset: 0x0003F220
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x00041028 File Offset: 0x0003F228
		[global::System.Xml.Serialization.XmlAttribute("stroke")]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse stroke1
		{
			get
			{
				return this.stroke1Field;
			}
			set
			{
				this.stroke1Field = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00041031 File Offset: 0x0003F231
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00041039 File Offset: 0x0003F239
		[global::System.Xml.Serialization.XmlIgnore]
		public bool stroke1Specified
		{
			get
			{
				return this.stroke1FieldSpecified;
			}
			set
			{
				this.stroke1FieldSpecified = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00041042 File Offset: 0x0003F242
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0004104A File Offset: 0x0003F24A
		[global::System.Xml.Serialization.XmlAttribute]
		public string strokecolor
		{
			get
			{
				return this.strokecolorField;
			}
			set
			{
				this.strokecolorField = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00041053 File Offset: 0x0003F253
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0004105B File Offset: 0x0003F25B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse allowincell
		{
			get
			{
				return this.allowincellField;
			}
			set
			{
				this.allowincellField = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00041064 File Offset: 0x0003F264
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0004106C File Offset: 0x0003F26C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool allowincellSpecified
		{
			get
			{
				return this.allowincellFieldSpecified;
			}
			set
			{
				this.allowincellFieldSpecified = value;
			}
		}

		// Token: 0x040010B6 RID: 4278
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Fill fillField;

		// Token: 0x040010B7 RID: 4279
		private global::NPOI.OpenXmlFormats.Vml.CT_Stroke strokeField;

		// Token: 0x040010B8 RID: 4280
		private global::NPOI.OpenXmlFormats.Vml.CT_Textbox textboxField;

		// Token: 0x040010B9 RID: 4281
		private global::NPOI.OpenXmlFormats.Vml.CT_Shadow shadowField;

		// Token: 0x040010BA RID: 4282
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Skew skewField;

		// Token: 0x040010BB RID: 4283
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Extrusion extrusionField;

		// Token: 0x040010BC RID: 4284
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Callout calloutField;

		// Token: 0x040010BD RID: 4285
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock lockField;

		// Token: 0x040010BE RID: 4286
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_ColorMru colormruField;

		// Token: 0x040010BF RID: 4287
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_ColorMenu colormenuField;

		// Token: 0x040010C0 RID: 4288
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x040010C1 RID: 4289
		private string spidmaxField;

		// Token: 0x040010C2 RID: 4290
		private string styleField;

		// Token: 0x040010C3 RID: 4291
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse fill1Field;

		// Token: 0x040010C4 RID: 4292
		private bool fill1FieldSpecified;

		// Token: 0x040010C5 RID: 4293
		private string fillcolorField;

		// Token: 0x040010C6 RID: 4294
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse stroke1Field;

		// Token: 0x040010C7 RID: 4295
		private bool stroke1FieldSpecified;

		// Token: 0x040010C8 RID: 4296
		private string strokecolorField;

		// Token: 0x040010C9 RID: 4297
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse allowincellField;

		// Token: 0x040010CA RID: 4298
		private bool allowincellFieldSpecified;
	}
}
