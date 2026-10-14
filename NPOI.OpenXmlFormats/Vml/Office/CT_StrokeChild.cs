using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200022A RID: 554
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StrokeChild
	{
		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00042B0A File Offset: 0x00040D0A
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00042B12 File Offset: 0x00040D12
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00042B1B File Offset: 0x00040D1B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00042B26 File Offset: 0x00040D26
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x00042B2E File Offset: 0x00040D2E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00042B37 File Offset: 0x00040D37
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00042B3F File Offset: 0x00040D3F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00042B48 File Offset: 0x00040D48
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00042B50 File Offset: 0x00040D50
		[global::System.Xml.Serialization.XmlAttribute]
		public string weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00042B59 File Offset: 0x00040D59
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00042B61 File Offset: 0x00040D61
		[global::System.Xml.Serialization.XmlAttribute]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00042B6A File Offset: 0x00040D6A
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00042B72 File Offset: 0x00040D72
		[global::System.Xml.Serialization.XmlAttribute]
		public string color2
		{
			get
			{
				return this.color2Field;
			}
			set
			{
				this.color2Field = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00042B7B File Offset: 0x00040D7B
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x00042B83 File Offset: 0x00040D83
		[global::System.Xml.Serialization.XmlAttribute]
		public string opacity
		{
			get
			{
				return this.opacityField;
			}
			set
			{
				this.opacityField = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00042B8C File Offset: 0x00040D8C
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00042B94 File Offset: 0x00040D94
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle linestyle
		{
			get
			{
				return this.linestyleField;
			}
			set
			{
				this.linestyleField = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00042B9D File Offset: 0x00040D9D
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00042BA5 File Offset: 0x00040DA5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool linestyleSpecified
		{
			get
			{
				return this.linestyleFieldSpecified;
			}
			set
			{
				this.linestyleFieldSpecified = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00042BAE File Offset: 0x00040DAE
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x00042BB6 File Offset: 0x00040DB6
		[global::System.Xml.Serialization.XmlAttribute]
		public decimal miterlimit
		{
			get
			{
				return this.miterlimitField;
			}
			set
			{
				this.miterlimitField = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00042BBF File Offset: 0x00040DBF
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x00042BC7 File Offset: 0x00040DC7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool miterlimitSpecified
		{
			get
			{
				return this.miterlimitFieldSpecified;
			}
			set
			{
				this.miterlimitFieldSpecified = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00042BD0 File Offset: 0x00040DD0
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00042BD8 File Offset: 0x00040DD8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle joinstyle
		{
			get
			{
				return this.joinstyleField;
			}
			set
			{
				this.joinstyleField = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00042BE1 File Offset: 0x00040DE1
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00042BE9 File Offset: 0x00040DE9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool joinstyleSpecified
		{
			get
			{
				return this.joinstyleFieldSpecified;
			}
			set
			{
				this.joinstyleFieldSpecified = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00042BF2 File Offset: 0x00040DF2
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x00042BFA File Offset: 0x00040DFA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap endcap
		{
			get
			{
				return this.endcapField;
			}
			set
			{
				this.endcapField = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00042C03 File Offset: 0x00040E03
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00042C0B File Offset: 0x00040E0B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endcapSpecified
		{
			get
			{
				return this.endcapFieldSpecified;
			}
			set
			{
				this.endcapFieldSpecified = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00042C14 File Offset: 0x00040E14
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00042C1C File Offset: 0x00040E1C
		[global::System.Xml.Serialization.XmlAttribute]
		public string dashstyle
		{
			get
			{
				return this.dashstyleField;
			}
			set
			{
				this.dashstyleField = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00042C25 File Offset: 0x00040E25
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00042C2D File Offset: 0x00040E2D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse insetpen
		{
			get
			{
				return this.insetpenField;
			}
			set
			{
				this.insetpenField = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x00042C36 File Offset: 0x00040E36
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00042C3E File Offset: 0x00040E3E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool insetpenSpecified
		{
			get
			{
				return this.insetpenFieldSpecified;
			}
			set
			{
				this.insetpenFieldSpecified = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00042C47 File Offset: 0x00040E47
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00042C4F File Offset: 0x00040E4F
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_FillType filltype
		{
			get
			{
				return this.filltypeField;
			}
			set
			{
				this.filltypeField = value;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00042C58 File Offset: 0x00040E58
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00042C60 File Offset: 0x00040E60
		[global::System.Xml.Serialization.XmlIgnore]
		public bool filltypeSpecified
		{
			get
			{
				return this.filltypeFieldSpecified;
			}
			set
			{
				this.filltypeFieldSpecified = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00042C69 File Offset: 0x00040E69
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00042C71 File Offset: 0x00040E71
		[global::System.Xml.Serialization.XmlAttribute]
		public string src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00042C7A File Offset: 0x00040E7A
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00042C82 File Offset: 0x00040E82
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect imageaspect
		{
			get
			{
				return this.imageaspectField;
			}
			set
			{
				this.imageaspectField = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00042C8B File Offset: 0x00040E8B
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00042C93 File Offset: 0x00040E93
		[global::System.Xml.Serialization.XmlIgnore]
		public bool imageaspectSpecified
		{
			get
			{
				return this.imageaspectFieldSpecified;
			}
			set
			{
				this.imageaspectFieldSpecified = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00042C9C File Offset: 0x00040E9C
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00042CA4 File Offset: 0x00040EA4
		[global::System.Xml.Serialization.XmlAttribute]
		public string imagesize
		{
			get
			{
				return this.imagesizeField;
			}
			set
			{
				this.imagesizeField = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00042CAD File Offset: 0x00040EAD
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00042CB5 File Offset: 0x00040EB5
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse imagealignshape
		{
			get
			{
				return this.imagealignshapeField;
			}
			set
			{
				this.imagealignshapeField = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00042CBE File Offset: 0x00040EBE
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00042CC6 File Offset: 0x00040EC6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool imagealignshapeSpecified
		{
			get
			{
				return this.imagealignshapeFieldSpecified;
			}
			set
			{
				this.imagealignshapeFieldSpecified = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00042CCF File Offset: 0x00040ECF
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00042CD7 File Offset: 0x00040ED7
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType startarrow
		{
			get
			{
				return this.startarrowField;
			}
			set
			{
				this.startarrowField = value;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00042CE0 File Offset: 0x00040EE0
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x00042CE8 File Offset: 0x00040EE8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowSpecified
		{
			get
			{
				return this.startarrowFieldSpecified;
			}
			set
			{
				this.startarrowFieldSpecified = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00042CF1 File Offset: 0x00040EF1
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x00042CF9 File Offset: 0x00040EF9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth startarrowwidth
		{
			get
			{
				return this.startarrowwidthField;
			}
			set
			{
				this.startarrowwidthField = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00042D02 File Offset: 0x00040F02
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00042D0A File Offset: 0x00040F0A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowwidthSpecified
		{
			get
			{
				return this.startarrowwidthFieldSpecified;
			}
			set
			{
				this.startarrowwidthFieldSpecified = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00042D13 File Offset: 0x00040F13
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00042D1B File Offset: 0x00040F1B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength startarrowlength
		{
			get
			{
				return this.startarrowlengthField;
			}
			set
			{
				this.startarrowlengthField = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00042D24 File Offset: 0x00040F24
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00042D2C File Offset: 0x00040F2C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowlengthSpecified
		{
			get
			{
				return this.startarrowlengthFieldSpecified;
			}
			set
			{
				this.startarrowlengthFieldSpecified = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00042D35 File Offset: 0x00040F35
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x00042D3D File Offset: 0x00040F3D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType endarrow
		{
			get
			{
				return this.endarrowField;
			}
			set
			{
				this.endarrowField = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00042D46 File Offset: 0x00040F46
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00042D4E File Offset: 0x00040F4E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowSpecified
		{
			get
			{
				return this.endarrowFieldSpecified;
			}
			set
			{
				this.endarrowFieldSpecified = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00042D57 File Offset: 0x00040F57
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x00042D5F File Offset: 0x00040F5F
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth endarrowwidth
		{
			get
			{
				return this.endarrowwidthField;
			}
			set
			{
				this.endarrowwidthField = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00042D68 File Offset: 0x00040F68
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x00042D70 File Offset: 0x00040F70
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowwidthSpecified
		{
			get
			{
				return this.endarrowwidthFieldSpecified;
			}
			set
			{
				this.endarrowwidthFieldSpecified = value;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00042D79 File Offset: 0x00040F79
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00042D81 File Offset: 0x00040F81
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength endarrowlength
		{
			get
			{
				return this.endarrowlengthField;
			}
			set
			{
				this.endarrowlengthField = value;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00042D8A File Offset: 0x00040F8A
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00042D92 File Offset: 0x00040F92
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowlengthSpecified
		{
			get
			{
				return this.endarrowlengthFieldSpecified;
			}
			set
			{
				this.endarrowlengthFieldSpecified = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00042D9B File Offset: 0x00040F9B
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00042DA3 File Offset: 0x00040FA3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string href
		{
			get
			{
				return this.hrefField;
			}
			set
			{
				this.hrefField = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00042DAC File Offset: 0x00040FAC
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x00042DB4 File Offset: 0x00040FB4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string althref
		{
			get
			{
				return this.althrefField;
			}
			set
			{
				this.althrefField = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00042DBD File Offset: 0x00040FBD
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00042DC5 File Offset: 0x00040FC5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string title
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00042DCE File Offset: 0x00040FCE
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00042DD6 File Offset: 0x00040FD6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse forcedash
		{
			get
			{
				return this.forcedashField;
			}
			set
			{
				this.forcedashField = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00042DDF File Offset: 0x00040FDF
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x00042DE7 File Offset: 0x00040FE7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool forcedashSpecified
		{
			get
			{
				return this.forcedashFieldSpecified;
			}
			set
			{
				this.forcedashFieldSpecified = value;
			}
		}

		// Token: 0x040011B3 RID: 4531
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x040011B4 RID: 4532
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse onField;

		// Token: 0x040011B5 RID: 4533
		private bool onFieldSpecified;

		// Token: 0x040011B6 RID: 4534
		private string weightField;

		// Token: 0x040011B7 RID: 4535
		private string colorField;

		// Token: 0x040011B8 RID: 4536
		private string color2Field;

		// Token: 0x040011B9 RID: 4537
		private string opacityField;

		// Token: 0x040011BA RID: 4538
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle linestyleField;

		// Token: 0x040011BB RID: 4539
		private bool linestyleFieldSpecified;

		// Token: 0x040011BC RID: 4540
		private decimal miterlimitField;

		// Token: 0x040011BD RID: 4541
		private bool miterlimitFieldSpecified;

		// Token: 0x040011BE RID: 4542
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle joinstyleField;

		// Token: 0x040011BF RID: 4543
		private bool joinstyleFieldSpecified;

		// Token: 0x040011C0 RID: 4544
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap endcapField;

		// Token: 0x040011C1 RID: 4545
		private bool endcapFieldSpecified;

		// Token: 0x040011C2 RID: 4546
		private string dashstyleField;

		// Token: 0x040011C3 RID: 4547
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse insetpenField;

		// Token: 0x040011C4 RID: 4548
		private bool insetpenFieldSpecified;

		// Token: 0x040011C5 RID: 4549
		private global::NPOI.OpenXmlFormats.Vml.ST_FillType filltypeField;

		// Token: 0x040011C6 RID: 4550
		private bool filltypeFieldSpecified;

		// Token: 0x040011C7 RID: 4551
		private string srcField;

		// Token: 0x040011C8 RID: 4552
		private global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect imageaspectField;

		// Token: 0x040011C9 RID: 4553
		private bool imageaspectFieldSpecified;

		// Token: 0x040011CA RID: 4554
		private string imagesizeField;

		// Token: 0x040011CB RID: 4555
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse imagealignshapeField;

		// Token: 0x040011CC RID: 4556
		private bool imagealignshapeFieldSpecified;

		// Token: 0x040011CD RID: 4557
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType startarrowField;

		// Token: 0x040011CE RID: 4558
		private bool startarrowFieldSpecified;

		// Token: 0x040011CF RID: 4559
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth startarrowwidthField;

		// Token: 0x040011D0 RID: 4560
		private bool startarrowwidthFieldSpecified;

		// Token: 0x040011D1 RID: 4561
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength startarrowlengthField;

		// Token: 0x040011D2 RID: 4562
		private bool startarrowlengthFieldSpecified;

		// Token: 0x040011D3 RID: 4563
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType endarrowField;

		// Token: 0x040011D4 RID: 4564
		private bool endarrowFieldSpecified;

		// Token: 0x040011D5 RID: 4565
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth endarrowwidthField;

		// Token: 0x040011D6 RID: 4566
		private bool endarrowwidthFieldSpecified;

		// Token: 0x040011D7 RID: 4567
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength endarrowlengthField;

		// Token: 0x040011D8 RID: 4568
		private bool endarrowlengthFieldSpecified;

		// Token: 0x040011D9 RID: 4569
		private string hrefField;

		// Token: 0x040011DA RID: 4570
		private string althrefField;

		// Token: 0x040011DB RID: 4571
		private string titleField;

		// Token: 0x040011DC RID: 4572
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse forcedashField;

		// Token: 0x040011DD RID: 4573
		private bool forcedashFieldSpecified;
	}
}
