using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000029 RID: 41
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Connection
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00003368 File Offset: 0x00001568
		public CT_Connection()
		{
			this.keepAliveField = false;
			this.intervalField = 0U;
			this.reconnectionMethodField = 1U;
			this.minRefreshableVersionField = 0;
			this.savePasswordField = false;
			this.newField = false;
			this.deletedField = false;
			this.onlyUseConnectionFileField = false;
			this.backgroundField = false;
			this.refreshOnLoadField = false;
			this.saveDataField = false;
			this.credentialsField = global::NPOI.OpenXmlFormats.ST_CredMethod.integrated;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000033CF File Offset: 0x000015CF
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000033D7 File Offset: 0x000015D7
		public global::NPOI.OpenXmlFormats.CT_DbPr dbPr
		{
			get
			{
				return this.dbPrField;
			}
			set
			{
				this.dbPrField = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000033E0 File Offset: 0x000015E0
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000033E8 File Offset: 0x000015E8
		public global::NPOI.OpenXmlFormats.CT_OlapPr olapPr
		{
			get
			{
				return this.olapPrField;
			}
			set
			{
				this.olapPrField = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000033F1 File Offset: 0x000015F1
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000033F9 File Offset: 0x000015F9
		public global::NPOI.OpenXmlFormats.CT_WebPr webPr
		{
			get
			{
				return this.webPrField;
			}
			set
			{
				this.webPrField = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00003402 File Offset: 0x00001602
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000340A File Offset: 0x0000160A
		public global::NPOI.OpenXmlFormats.CT_TextPr textPr
		{
			get
			{
				return this.textPrField;
			}
			set
			{
				this.textPrField = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003413 File Offset: 0x00001613
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000341B File Offset: 0x0000161B
		public global::NPOI.OpenXmlFormats.CT_Parameters parameters
		{
			get
			{
				return this.parametersField;
			}
			set
			{
				this.parametersField = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000342C File Offset: 0x0000162C
		public global::NPOI.OpenXmlFormats.CT_ExtensionList extLst
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00003435 File Offset: 0x00001635
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000343D File Offset: 0x0000163D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00003446 File Offset: 0x00001646
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000344E File Offset: 0x0000164E
		[global::System.Xml.Serialization.XmlAttribute]
		public string sourceFile
		{
			get
			{
				return this.sourceFileField;
			}
			set
			{
				this.sourceFileField = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00003457 File Offset: 0x00001657
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000345F File Offset: 0x0000165F
		[global::System.Xml.Serialization.XmlAttribute]
		public string odcFile
		{
			get
			{
				return this.odcFileField;
			}
			set
			{
				this.odcFileField = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00003470 File Offset: 0x00001670
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool keepAlive
		{
			get
			{
				return this.keepAliveField;
			}
			set
			{
				this.keepAliveField = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00003479 File Offset: 0x00001679
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00003481 File Offset: 0x00001681
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint interval
		{
			get
			{
				return this.intervalField;
			}
			set
			{
				this.intervalField = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000348A File Offset: 0x0000168A
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00003492 File Offset: 0x00001692
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000349B File Offset: 0x0000169B
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000034A3 File Offset: 0x000016A3
		[global::System.Xml.Serialization.XmlAttribute]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000034B4 File Offset: 0x000016B4
		[global::System.Xml.Serialization.XmlAttribute]
		public uint type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000034BD File Offset: 0x000016BD
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000034C5 File Offset: 0x000016C5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000034CE File Offset: 0x000016CE
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000034D6 File Offset: 0x000016D6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint reconnectionMethod
		{
			get
			{
				return this.reconnectionMethodField;
			}
			set
			{
				this.reconnectionMethodField = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000034DF File Offset: 0x000016DF
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000034E7 File Offset: 0x000016E7
		[global::System.Xml.Serialization.XmlAttribute]
		public byte refreshedVersion
		{
			get
			{
				return this.refreshedVersionField;
			}
			set
			{
				this.refreshedVersionField = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000034F0 File Offset: 0x000016F0
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000034F8 File Offset: 0x000016F8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		public byte minRefreshableVersion
		{
			get
			{
				return this.minRefreshableVersionField;
			}
			set
			{
				this.minRefreshableVersionField = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00003501 File Offset: 0x00001701
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00003509 File Offset: 0x00001709
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool savePassword
		{
			get
			{
				return this.savePasswordField;
			}
			set
			{
				this.savePasswordField = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00003512 File Offset: 0x00001712
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000351A File Offset: 0x0000171A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool @new
		{
			get
			{
				return this.newField;
			}
			set
			{
				this.newField = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00003523 File Offset: 0x00001723
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000352B File Offset: 0x0000172B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool deleted
		{
			get
			{
				return this.deletedField;
			}
			set
			{
				this.deletedField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003534 File Offset: 0x00001734
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000353C File Offset: 0x0000173C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool onlyUseConnectionFile
		{
			get
			{
				return this.onlyUseConnectionFileField;
			}
			set
			{
				this.onlyUseConnectionFileField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00003545 File Offset: 0x00001745
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000354D File Offset: 0x0000174D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool background
		{
			get
			{
				return this.backgroundField;
			}
			set
			{
				this.backgroundField = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00003556 File Offset: 0x00001756
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000355E File Offset: 0x0000175E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool refreshOnLoad
		{
			get
			{
				return this.refreshOnLoadField;
			}
			set
			{
				this.refreshOnLoadField = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00003567 File Offset: 0x00001767
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0000356F File Offset: 0x0000176F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool saveData
		{
			get
			{
				return this.saveDataField;
			}
			set
			{
				this.saveDataField = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00003578 File Offset: 0x00001778
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00003580 File Offset: 0x00001780
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_CredMethod.integrated)]
		public global::NPOI.OpenXmlFormats.ST_CredMethod credentials
		{
			get
			{
				return this.credentialsField;
			}
			set
			{
				this.credentialsField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00003589 File Offset: 0x00001789
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00003591 File Offset: 0x00001791
		[global::System.Xml.Serialization.XmlAttribute]
		public string singleSignOnId
		{
			get
			{
				return this.singleSignOnIdField;
			}
			set
			{
				this.singleSignOnIdField = value;
			}
		}

		// Token: 0x0400011C RID: 284
		private global::NPOI.OpenXmlFormats.CT_DbPr dbPrField;

		// Token: 0x0400011D RID: 285
		private global::NPOI.OpenXmlFormats.CT_OlapPr olapPrField;

		// Token: 0x0400011E RID: 286
		private global::NPOI.OpenXmlFormats.CT_WebPr webPrField;

		// Token: 0x0400011F RID: 287
		private global::NPOI.OpenXmlFormats.CT_TextPr textPrField;

		// Token: 0x04000120 RID: 288
		private global::NPOI.OpenXmlFormats.CT_Parameters parametersField;

		// Token: 0x04000121 RID: 289
		private global::NPOI.OpenXmlFormats.CT_ExtensionList extLstField;

		// Token: 0x04000122 RID: 290
		private uint idField;

		// Token: 0x04000123 RID: 291
		private string sourceFileField;

		// Token: 0x04000124 RID: 292
		private string odcFileField;

		// Token: 0x04000125 RID: 293
		private bool keepAliveField;

		// Token: 0x04000126 RID: 294
		private uint intervalField;

		// Token: 0x04000127 RID: 295
		private string nameField;

		// Token: 0x04000128 RID: 296
		private string descriptionField;

		// Token: 0x04000129 RID: 297
		private uint typeField;

		// Token: 0x0400012A RID: 298
		private bool typeFieldSpecified;

		// Token: 0x0400012B RID: 299
		private uint reconnectionMethodField;

		// Token: 0x0400012C RID: 300
		private byte refreshedVersionField;

		// Token: 0x0400012D RID: 301
		private byte minRefreshableVersionField;

		// Token: 0x0400012E RID: 302
		private bool savePasswordField;

		// Token: 0x0400012F RID: 303
		private bool newField;

		// Token: 0x04000130 RID: 304
		private bool deletedField;

		// Token: 0x04000131 RID: 305
		private bool onlyUseConnectionFileField;

		// Token: 0x04000132 RID: 306
		private bool backgroundField;

		// Token: 0x04000133 RID: 307
		private bool refreshOnLoadField;

		// Token: 0x04000134 RID: 308
		private bool saveDataField;

		// Token: 0x04000135 RID: 309
		private global::NPOI.OpenXmlFormats.ST_CredMethod credentialsField;

		// Token: 0x04000136 RID: 310
		private string singleSignOnIdField;
	}
}
