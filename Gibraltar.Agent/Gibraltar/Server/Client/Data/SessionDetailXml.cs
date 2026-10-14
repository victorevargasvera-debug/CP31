using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000142 RID: 322
	[global::System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.33440")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd")]
	[global::System.Serializable]
	internal class SessionDetailXml : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00022D34 File Offset: 0x00020F34
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00022D3C File Offset: 0x00020F3C
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml startDt
		{
			get
			{
				return this.startDtField;
			}
			set
			{
				this.startDtField = value;
				this.RaisePropertyChanged("startDt");
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00022D50 File Offset: 0x00020F50
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00022D58 File Offset: 0x00020F58
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml endDt
		{
			get
			{
				return this.endDtField;
			}
			set
			{
				this.endDtField = value;
				this.RaisePropertyChanged("endDt");
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00022D6C File Offset: 0x00020F6C
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00022D74 File Offset: 0x00020F74
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDt
		{
			get
			{
				return this.addedDtField;
			}
			set
			{
				this.addedDtField = value;
				this.RaisePropertyChanged("addedDt");
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00022D88 File Offset: 0x00020F88
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00022D90 File Offset: 0x00020F90
		public global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDt
		{
			get
			{
				return this.updatedDtField;
			}
			set
			{
				this.updatedDtField = value;
				this.RaisePropertyChanged("updatedDt");
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00022DA4 File Offset: 0x00020FA4
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00022DAC File Offset: 0x00020FAC
		[global::System.Xml.Serialization.XmlArrayItem("property", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.SessionPropertyXml[] properties
		{
			get
			{
				return this.propertiesField;
			}
			set
			{
				this.propertiesField = value;
				this.RaisePropertyChanged("properties");
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00022DC0 File Offset: 0x00020FC0
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00022DC8 File Offset: 0x00020FC8
		[global::System.Xml.Serialization.XmlArrayItem("logMessageCategory", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.LogMessageCategoryXml[] logMessageCategories
		{
			get
			{
				return this.logMessageCategoriesField;
			}
			set
			{
				this.logMessageCategoriesField = value;
				this.RaisePropertyChanged("logMessageCategories");
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00022DDC File Offset: 0x00020FDC
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00022DE4 File Offset: 0x00020FE4
		[global::System.Xml.Serialization.XmlArrayItem("logMessageClass", IsNullable = false)]
		public global::Gibraltar.Server.Client.Data.LogMessageClassXml[] logMessageClasses
		{
			get
			{
				return this.logMessageClassesField;
			}
			set
			{
				this.logMessageClassesField = value;
				this.RaisePropertyChanged("logMessageClasses");
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00022DF8 File Offset: 0x00020FF8
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00022E00 File Offset: 0x00021000
		[global::System.Xml.Serialization.XmlAttribute]
		public string productName
		{
			get
			{
				return this.productNameField;
			}
			set
			{
				this.productNameField = value;
				this.RaisePropertyChanged("productName");
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00022E14 File Offset: 0x00021014
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00022E1C File Offset: 0x0002101C
		[global::System.Xml.Serialization.XmlAttribute]
		public string applicationName
		{
			get
			{
				return this.applicationNameField;
			}
			set
			{
				this.applicationNameField = value;
				this.RaisePropertyChanged("applicationName");
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00022E30 File Offset: 0x00021030
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00022E38 File Offset: 0x00021038
		[global::System.Xml.Serialization.XmlAttribute]
		public string environmentName
		{
			get
			{
				return this.environmentNameField;
			}
			set
			{
				this.environmentNameField = value;
				this.RaisePropertyChanged("environmentName");
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00022E4C File Offset: 0x0002104C
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00022E54 File Offset: 0x00021054
		[global::System.Xml.Serialization.XmlAttribute]
		public string promotionLevelName
		{
			get
			{
				return this.promotionLevelNameField;
			}
			set
			{
				this.promotionLevelNameField = value;
				this.RaisePropertyChanged("promotionLevelName");
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00022E68 File Offset: 0x00021068
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00022E70 File Offset: 0x00021070
		[global::System.Xml.Serialization.XmlAttribute]
		public string applicationVersion
		{
			get
			{
				return this.applicationVersionField;
			}
			set
			{
				this.applicationVersionField = value;
				this.RaisePropertyChanged("applicationVersion");
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00022E84 File Offset: 0x00021084
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00022E8C File Offset: 0x0002108C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.ApplicationTypeXml applicationType
		{
			get
			{
				return this.applicationTypeField;
			}
			set
			{
				this.applicationTypeField = value;
				this.RaisePropertyChanged("applicationType");
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00022EA0 File Offset: 0x000210A0
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00022EA8 File Offset: 0x000210A8
		[global::System.Xml.Serialization.XmlAttribute]
		public string applicationDescription
		{
			get
			{
				return this.applicationDescriptionField;
			}
			set
			{
				this.applicationDescriptionField = value;
				this.RaisePropertyChanged("applicationDescription");
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00022EBC File Offset: 0x000210BC
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00022EC4 File Offset: 0x000210C4
		[global::System.Xml.Serialization.XmlAttribute]
		public string caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
				this.RaisePropertyChanged("caption");
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00022ED8 File Offset: 0x000210D8
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00022EE0 File Offset: 0x000210E0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.SessionStatusXml status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("status");
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00022EF4 File Offset: 0x000210F4
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00022EFC File Offset: 0x000210FC
		[global::System.Xml.Serialization.XmlAttribute]
		public string timeZoneCaption
		{
			get
			{
				return this.timeZoneCaptionField;
			}
			set
			{
				this.timeZoneCaptionField = value;
				this.RaisePropertyChanged("timeZoneCaption");
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00022F10 File Offset: 0x00021110
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00022F18 File Offset: 0x00021118
		[global::System.Xml.Serialization.XmlAttribute]
		public int durationSec
		{
			get
			{
				return this.durationSecField;
			}
			set
			{
				this.durationSecField = value;
				this.RaisePropertyChanged("durationSec");
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00022F2C File Offset: 0x0002112C
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00022F34 File Offset: 0x00021134
		[global::System.Xml.Serialization.XmlAttribute]
		public string agentVersion
		{
			get
			{
				return this.agentVersionField;
			}
			set
			{
				this.agentVersionField = value;
				this.RaisePropertyChanged("agentVersion");
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00022F48 File Offset: 0x00021148
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00022F50 File Offset: 0x00021150
		[global::System.Xml.Serialization.XmlAttribute]
		public string userName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
				this.RaisePropertyChanged("userName");
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00022F64 File Offset: 0x00021164
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00022F6C File Offset: 0x0002116C
		[global::System.Xml.Serialization.XmlAttribute]
		public string userDomainName
		{
			get
			{
				return this.userDomainNameField;
			}
			set
			{
				this.userDomainNameField = value;
				this.RaisePropertyChanged("userDomainName");
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00022F80 File Offset: 0x00021180
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00022F88 File Offset: 0x00021188
		[global::System.Xml.Serialization.XmlAttribute]
		public string hostName
		{
			get
			{
				return this.hostNameField;
			}
			set
			{
				this.hostNameField = value;
				this.RaisePropertyChanged("hostName");
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00022F9C File Offset: 0x0002119C
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00022FA4 File Offset: 0x000211A4
		[global::System.Xml.Serialization.XmlAttribute]
		public string dnsDomainName
		{
			get
			{
				return this.dnsDomainNameField;
			}
			set
			{
				this.dnsDomainNameField = value;
				this.RaisePropertyChanged("dnsDomainName");
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00022FB8 File Offset: 0x000211B8
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00022FC0 File Offset: 0x000211C0
		[global::System.Xml.Serialization.XmlAttribute]
		public bool isNew
		{
			get
			{
				return this.isNewField;
			}
			set
			{
				this.isNewField = value;
				this.RaisePropertyChanged("isNew");
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00022FD4 File Offset: 0x000211D4
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00022FDC File Offset: 0x000211DC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool isComplete
		{
			get
			{
				return this.isCompleteField;
			}
			set
			{
				this.isCompleteField = value;
				this.RaisePropertyChanged("isComplete");
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00022FF0 File Offset: 0x000211F0
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00022FF8 File Offset: 0x000211F8
		[global::System.Xml.Serialization.XmlAttribute]
		public int messageCount
		{
			get
			{
				return this.messageCountField;
			}
			set
			{
				this.messageCountField = value;
				this.RaisePropertyChanged("messageCount");
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0002300C File Offset: 0x0002120C
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00023014 File Offset: 0x00021214
		[global::System.Xml.Serialization.XmlAttribute]
		public int criticalMessageCount
		{
			get
			{
				return this.criticalMessageCountField;
			}
			set
			{
				this.criticalMessageCountField = value;
				this.RaisePropertyChanged("criticalMessageCount");
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00023028 File Offset: 0x00021228
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00023030 File Offset: 0x00021230
		[global::System.Xml.Serialization.XmlAttribute]
		public int errorMessageCount
		{
			get
			{
				return this.errorMessageCountField;
			}
			set
			{
				this.errorMessageCountField = value;
				this.RaisePropertyChanged("errorMessageCount");
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00023044 File Offset: 0x00021244
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0002304C File Offset: 0x0002124C
		[global::System.Xml.Serialization.XmlAttribute]
		public int warningMessageCount
		{
			get
			{
				return this.warningMessageCountField;
			}
			set
			{
				this.warningMessageCountField = value;
				this.RaisePropertyChanged("warningMessageCount");
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00023060 File Offset: 0x00021260
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00023068 File Offset: 0x00021268
		[global::System.Xml.Serialization.XmlAttribute]
		public string updateUser
		{
			get
			{
				return this.updateUserField;
			}
			set
			{
				this.updateUserField = value;
				this.RaisePropertyChanged("updateUser");
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002307C File Offset: 0x0002127C
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00023084 File Offset: 0x00021284
		[global::System.Xml.Serialization.XmlAttribute]
		public int osPlatformCode
		{
			get
			{
				return this.osPlatformCodeField;
			}
			set
			{
				this.osPlatformCodeField = value;
				this.RaisePropertyChanged("osPlatformCode");
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00023098 File Offset: 0x00021298
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x000230A0 File Offset: 0x000212A0
		[global::System.Xml.Serialization.XmlAttribute]
		public string osVersion
		{
			get
			{
				return this.osVersionField;
			}
			set
			{
				this.osVersionField = value;
				this.RaisePropertyChanged("osVersion");
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000230B4 File Offset: 0x000212B4
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x000230BC File Offset: 0x000212BC
		[global::System.Xml.Serialization.XmlAttribute]
		public string osServicePack
		{
			get
			{
				return this.osServicePackField;
			}
			set
			{
				this.osServicePackField = value;
				this.RaisePropertyChanged("osServicePack");
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000230D0 File Offset: 0x000212D0
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x000230D8 File Offset: 0x000212D8
		[global::System.Xml.Serialization.XmlAttribute]
		public string osCultureName
		{
			get
			{
				return this.osCultureNameField;
			}
			set
			{
				this.osCultureNameField = value;
				this.RaisePropertyChanged("osCultureName");
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000230EC File Offset: 0x000212EC
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x000230F4 File Offset: 0x000212F4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml osArchitecture
		{
			get
			{
				return this.osArchitectureField;
			}
			set
			{
				this.osArchitectureField = value;
				this.RaisePropertyChanged("osArchitecture");
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00023108 File Offset: 0x00021308
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00023110 File Offset: 0x00021310
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.BootModeXml osBootMode
		{
			get
			{
				return this.osBootModeField;
			}
			set
			{
				this.osBootModeField = value;
				this.RaisePropertyChanged("osBootMode");
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00023124 File Offset: 0x00021324
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0002312C File Offset: 0x0002132C
		[global::System.Xml.Serialization.XmlAttribute]
		public int osSuiteMaskCode
		{
			get
			{
				return this.osSuiteMaskCodeField;
			}
			set
			{
				this.osSuiteMaskCodeField = value;
				this.RaisePropertyChanged("osSuiteMaskCode");
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00023140 File Offset: 0x00021340
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00023148 File Offset: 0x00021348
		[global::System.Xml.Serialization.XmlAttribute]
		public int osProductTypeCode
		{
			get
			{
				return this.osProductTypeCodeField;
			}
			set
			{
				this.osProductTypeCodeField = value;
				this.RaisePropertyChanged("osProductTypeCode");
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0002315C File Offset: 0x0002135C
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00023164 File Offset: 0x00021364
		[global::System.Xml.Serialization.XmlAttribute]
		public string runtimeVersion
		{
			get
			{
				return this.runtimeVersionField;
			}
			set
			{
				this.runtimeVersionField = value;
				this.RaisePropertyChanged("runtimeVersion");
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00023178 File Offset: 0x00021378
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00023180 File Offset: 0x00021380
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml runtimeArchitecture
		{
			get
			{
				return this.runtimeArchitectureField;
			}
			set
			{
				this.runtimeArchitectureField = value;
				this.RaisePropertyChanged("runtimeArchitecture");
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00023194 File Offset: 0x00021394
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0002319C File Offset: 0x0002139C
		[global::System.Xml.Serialization.XmlAttribute]
		public string currentCultureName
		{
			get
			{
				return this.currentCultureNameField;
			}
			set
			{
				this.currentCultureNameField = value;
				this.RaisePropertyChanged("currentCultureName");
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000231B0 File Offset: 0x000213B0
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x000231B8 File Offset: 0x000213B8
		[global::System.Xml.Serialization.XmlAttribute]
		public string currentUiCultureName
		{
			get
			{
				return this.currentUiCultureNameField;
			}
			set
			{
				this.currentUiCultureNameField = value;
				this.RaisePropertyChanged("currentUiCultureName");
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000231CC File Offset: 0x000213CC
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000231D4 File Offset: 0x000213D4
		[global::System.Xml.Serialization.XmlAttribute]
		public int memoryMb
		{
			get
			{
				return this.memoryMbField;
			}
			set
			{
				this.memoryMbField = value;
				this.RaisePropertyChanged("memoryMb");
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x000231E8 File Offset: 0x000213E8
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x000231F0 File Offset: 0x000213F0
		[global::System.Xml.Serialization.XmlAttribute]
		public int processors
		{
			get
			{
				return this.processorsField;
			}
			set
			{
				this.processorsField = value;
				this.RaisePropertyChanged("processors");
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00023204 File Offset: 0x00021404
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x0002320C File Offset: 0x0002140C
		[global::System.Xml.Serialization.XmlAttribute]
		public int processorCores
		{
			get
			{
				return this.processorCoresField;
			}
			set
			{
				this.processorCoresField = value;
				this.RaisePropertyChanged("processorCores");
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00023220 File Offset: 0x00021420
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00023228 File Offset: 0x00021428
		[global::System.Xml.Serialization.XmlAttribute]
		public bool userInteractive
		{
			get
			{
				return this.userInteractiveField;
			}
			set
			{
				this.userInteractiveField = value;
				this.RaisePropertyChanged("userInteractive");
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0002323C File Offset: 0x0002143C
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00023244 File Offset: 0x00021444
		[global::System.Xml.Serialization.XmlAttribute]
		public bool terminalServer
		{
			get
			{
				return this.terminalServerField;
			}
			set
			{
				this.terminalServerField = value;
				this.RaisePropertyChanged("terminalServer");
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00023258 File Offset: 0x00021458
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00023260 File Offset: 0x00021460
		[global::System.Xml.Serialization.XmlAttribute]
		public int screenWidth
		{
			get
			{
				return this.screenWidthField;
			}
			set
			{
				this.screenWidthField = value;
				this.RaisePropertyChanged("screenWidth");
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00023274 File Offset: 0x00021474
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0002327C File Offset: 0x0002147C
		[global::System.Xml.Serialization.XmlAttribute]
		public int screenHeight
		{
			get
			{
				return this.screenHeightField;
			}
			set
			{
				this.screenHeightField = value;
				this.RaisePropertyChanged("screenHeight");
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00023290 File Offset: 0x00021490
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00023298 File Offset: 0x00021498
		[global::System.Xml.Serialization.XmlAttribute]
		public int colorDepth
		{
			get
			{
				return this.colorDepthField;
			}
			set
			{
				this.colorDepthField = value;
				this.RaisePropertyChanged("colorDepth");
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000232AC File Offset: 0x000214AC
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x000232B4 File Offset: 0x000214B4
		[global::System.Xml.Serialization.XmlAttribute]
		public string commandLine
		{
			get
			{
				return this.commandLineField;
			}
			set
			{
				this.commandLineField = value;
				this.RaisePropertyChanged("commandLine");
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x000232C8 File Offset: 0x000214C8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000232D0 File Offset: 0x000214D0
		[global::System.Xml.Serialization.XmlAttribute]
		public long fileSize
		{
			get
			{
				return this.fileSizeField;
			}
			set
			{
				this.fileSizeField = value;
				this.RaisePropertyChanged("fileSize");
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000232E4 File Offset: 0x000214E4
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x000232EC File Offset: 0x000214EC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fileAvailable
		{
			get
			{
				return this.fileAvailableField;
			}
			set
			{
				this.fileAvailableField = value;
				this.RaisePropertyChanged("fileAvailable");
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00023300 File Offset: 0x00021500
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00023308 File Offset: 0x00021508
		[global::System.Xml.Serialization.XmlAttribute]
		public string computerId
		{
			get
			{
				return this.computerIdField;
			}
			set
			{
				this.computerIdField = value;
				this.RaisePropertyChanged("computerId");
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000DA1 RID: 3489 RVA: 0x0002331C File Offset: 0x0002151C
		// (remove) Token: 0x06000DA2 RID: 3490 RVA: 0x00023358 File Offset: 0x00021558
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00023394 File Offset: 0x00021594
		protected void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000412 RID: 1042
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml startDtField;

		// Token: 0x04000413 RID: 1043
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml endDtField;

		// Token: 0x04000414 RID: 1044
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml addedDtField;

		// Token: 0x04000415 RID: 1045
		private global::Gibraltar.Server.Client.Data.DateTimeOffsetXml updatedDtField;

		// Token: 0x04000416 RID: 1046
		private global::Gibraltar.Server.Client.Data.SessionPropertyXml[] propertiesField;

		// Token: 0x04000417 RID: 1047
		private global::Gibraltar.Server.Client.Data.LogMessageCategoryXml[] logMessageCategoriesField;

		// Token: 0x04000418 RID: 1048
		private global::Gibraltar.Server.Client.Data.LogMessageClassXml[] logMessageClassesField;

		// Token: 0x04000419 RID: 1049
		private string productNameField;

		// Token: 0x0400041A RID: 1050
		private string applicationNameField;

		// Token: 0x0400041B RID: 1051
		private string environmentNameField;

		// Token: 0x0400041C RID: 1052
		private string promotionLevelNameField;

		// Token: 0x0400041D RID: 1053
		private string applicationVersionField;

		// Token: 0x0400041E RID: 1054
		private global::Gibraltar.Server.Client.Data.ApplicationTypeXml applicationTypeField;

		// Token: 0x0400041F RID: 1055
		private string applicationDescriptionField;

		// Token: 0x04000420 RID: 1056
		private string captionField;

		// Token: 0x04000421 RID: 1057
		private global::Gibraltar.Server.Client.Data.SessionStatusXml statusField;

		// Token: 0x04000422 RID: 1058
		private string timeZoneCaptionField;

		// Token: 0x04000423 RID: 1059
		private int durationSecField;

		// Token: 0x04000424 RID: 1060
		private string agentVersionField;

		// Token: 0x04000425 RID: 1061
		private string userNameField;

		// Token: 0x04000426 RID: 1062
		private string userDomainNameField;

		// Token: 0x04000427 RID: 1063
		private string hostNameField;

		// Token: 0x04000428 RID: 1064
		private string dnsDomainNameField;

		// Token: 0x04000429 RID: 1065
		private bool isNewField;

		// Token: 0x0400042A RID: 1066
		private bool isCompleteField;

		// Token: 0x0400042B RID: 1067
		private int messageCountField;

		// Token: 0x0400042C RID: 1068
		private int criticalMessageCountField;

		// Token: 0x0400042D RID: 1069
		private int errorMessageCountField;

		// Token: 0x0400042E RID: 1070
		private int warningMessageCountField;

		// Token: 0x0400042F RID: 1071
		private string updateUserField;

		// Token: 0x04000430 RID: 1072
		private int osPlatformCodeField;

		// Token: 0x04000431 RID: 1073
		private string osVersionField;

		// Token: 0x04000432 RID: 1074
		private string osServicePackField;

		// Token: 0x04000433 RID: 1075
		private string osCultureNameField;

		// Token: 0x04000434 RID: 1076
		private global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml osArchitectureField;

		// Token: 0x04000435 RID: 1077
		private global::Gibraltar.Server.Client.Data.BootModeXml osBootModeField;

		// Token: 0x04000436 RID: 1078
		private int osSuiteMaskCodeField;

		// Token: 0x04000437 RID: 1079
		private int osProductTypeCodeField;

		// Token: 0x04000438 RID: 1080
		private string runtimeVersionField;

		// Token: 0x04000439 RID: 1081
		private global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml runtimeArchitectureField;

		// Token: 0x0400043A RID: 1082
		private string currentCultureNameField;

		// Token: 0x0400043B RID: 1083
		private string currentUiCultureNameField;

		// Token: 0x0400043C RID: 1084
		private int memoryMbField;

		// Token: 0x0400043D RID: 1085
		private int processorsField;

		// Token: 0x0400043E RID: 1086
		private int processorCoresField;

		// Token: 0x0400043F RID: 1087
		private bool userInteractiveField;

		// Token: 0x04000440 RID: 1088
		private bool terminalServerField;

		// Token: 0x04000441 RID: 1089
		private int screenWidthField;

		// Token: 0x04000442 RID: 1090
		private int screenHeightField;

		// Token: 0x04000443 RID: 1091
		private int colorDepthField;

		// Token: 0x04000444 RID: 1092
		private string commandLineField;

		// Token: 0x04000445 RID: 1093
		private long fileSizeField;

		// Token: 0x04000446 RID: 1094
		private bool fileAvailableField;

		// Token: 0x04000447 RID: 1095
		private string computerIdField;
	}
}
