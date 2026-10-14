using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AB RID: 427
	[global::System.Serializable]
	public sealed class SystemCertificateGeneralSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x00002650 File Offset: 0x00000850
		internal SystemCertificateGeneralSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000265F File Offset: 0x0000085F
		internal SystemCertificateGeneralSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1092616192;
			short num2 = num;
			num = (short)1530250374;
			short num3 = num;
			num = (short)1730397318;
			switch (num3 == num)
			{
			}
			num = (short)89653248;
			if (num != 0)
			{
			}
			num = (short)642646017;
			if (num != 0)
			{
			}
			this.secSysCertGeneralKeyofSystemCertificates_A43633 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ蓮쾛펟솣풥\udca7즫삭햯삱햳\udab5\udfb9얻톽ꚿ釁뷃뗅볇꿉ꇋ跍뗏ꃑꃓ뿕뻗동뿛뿝铟蟡韣맥ꧧ\udee9\udfeb\ud8ed쏯쇱", a_), global::CommonResources.AppResources.System_Certificate_Name_ID, 50);
			this.secSysCertGeneralKeyofSystemCertificates_A43633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secSysCertGeneralKeyofSystemCertificates_A43633.DataTransferOrder = 1;
			this.secSysCertGeneralCertificateFilename_A43634 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ蓮쾛펟솣풥\udca7즫삭햯삱햳\udab5﮷\udfb9캻쪽ꦿ꓁귃ꗅ꧇뻉꧋裍맏뻑뇓룕맗럙맛臝ꇟ훡ퟣ탥\udbe7\udee9", a_), global::CommonResources.AppResources.System_Certificate_Filename_ID, 255);
			this.secSysCertGeneralCertificateFilename_A43634.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secSysCertGeneralCertificateFilename_A43634.DataTransferOrder = 3;
			this.secSysCertGeneralCertificateFileData_A43635 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﮝ춟솣풥\udca7쎩쪫잭펯펱삳펵ﺷ펹킻\udbbd", a_), global::CommonResources.AppResources.System_Certificate_Data_ID);
			this.secSysCertGeneralCertificateFileData_A43635.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.secSysCertGeneralCertificateFileData_A43635.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톕ﶗ鍊솟캡", a_);
			base.Id = 10885;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x001D0D38 File Offset: 0x001CEF38
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)2023489536;
			short num2 = num;
			num = (short)1781334017;
			if (num != 0)
			{
			}
			num = (short)123878;
			short num3 = num;
			num = (short)1680860134;
			switch (num3 == num)
			{
			}
			num = (short)664993792;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x001D0DEC File Offset: 0x001CEFEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)362938372;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_221;
				case 1:
					goto IL_287;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요滛좚욢힤펦캪쎬쪮쎰튲\ud9b4\udcb8즺즼횾Ꟁꫂꛄꛆ뷈껊诌ꛎ뷐뛒믔뛖듘뻚苜點헠탢폤퓦\udde8", a_)))
					{
						num = (short)1683226627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_287;
				case 3:
					this.secSysCertGeneralCertificateFilename_A43634 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요滛좚욢힤펦캪쎬쪮쎰튲\ud9b4\udcb8즺즼횾Ꟁꫂꛄꛆ뷈껊诌ꛎ뷐뛒믔뛖듘뻚苜點헠탢폤퓦\udde8", a_), global::CommonResources.AppResources.System_Certificate_Filename_ID, 255);
					this.secSysCertGeneralCertificateFilename_A43634.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secSysCertGeneralCertificateFilename_A43634.DataTransferOrder = 3;
					this.secSysCertGeneralCertificateFilename_A43634.EvaluateRecRefs = true;
					num = (short)229113857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 5:
					num = (short)83361798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)2036269056;
						short num3 = num;
						num = (short)548470796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_328;
				case 7:
					for (;;)
					{
						num = (short)511399860;
						short num4 = num;
						num = (short)1993693108;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1BC;
						}
					}
					IL_1BC:
					num = (short)512229376;
					if (num != 0)
					{
					}
					this.secSysCertGeneralCertificateFileData_A43635 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요욢힤펦삨춪쒬첮킰잲킴킸ힺ\ud8bc", a_), global::CommonResources.AppResources.System_Certificate_Data_ID);
					this.secSysCertGeneralCertificateFileData_A43635.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.secSysCertGeneralCertificateFileData_A43635.DataTransferOrder = 2;
					num = (short)702545920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요욢힤펦삨춪쒬첮킰잲킴킸ힺ\ud8bc", a_)))
					{
						num = (short)1771962375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_328;
				case 9:
					this.secSysCertGeneralKeyofSystemCertificates_A43633 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요滛좚욢힤펦캪쎬쪮쎰튲\ud9b4ﲶ\udcb8슺튼\ud9be鋀뫂뛄돆곈ꛊ軌꫎ꏐ꟒볔뇖냘룚볜ꯞ蓠郢뫤ꛦ\udde8\ud8ea\udbec\udcee싰", a_), global::CommonResources.AppResources.System_Certificate_Name_ID, 50);
					this.secSysCertGeneralKeyofSystemCertificates_A43633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secSysCertGeneralKeyofSystemCertificates_A43633.DataTransferOrder = 1;
					num = (short)261750794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_EF;
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요滛좚욢힤펦캪쎬쪮쎰튲\ud9b4ﲶ\udcb8슺튼\ud9be鋀뫂뛄돆곈ꛊ軌꫎ꏐ꟒볔뇖냘룚볜ꯞ蓠郢뫤ꛦ\udde8\ud8ea\udbec\udcee싰", a_)))
					{
						num = (short)1711931401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				case 12:
					num = (short)881459211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1169489925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EF:
				num = (short)308412418;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_287:
				num = (short)1038745608;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_221:
			IL_328:
			num = (short)892731393;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튔ﺚﺞ춠", a_);
			base.Id = 10885;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x001D117C File Offset: 0x001CF37C
		public override void PopulateReferences()
		{
			short num = (short)753205249;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1857617921;
					if (num != 0)
					{
					}
					global::AcpCommonLib.Document containerDoc = base.ParentRecset.ContainerDoc;
					num = (short)765591554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)789400880;
					short num3 = num;
					num = (short)1708084528;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)1220280320;
						short num4 = num;
						break;
					}
					}
					num = (short)763428864;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				}
				case 2:
					return;
				}
				IL_A3:
				if (base.ParentRecset == null)
				{
					break;
				}
				num = (short)919076864;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x001D1298 File Offset: 0x001CF498
		public override void DropReferences()
		{
			short num = (short)425328640;
			short num2 = num;
			num = (short)99090433;
			if (num != 0)
			{
			}
			num = (short)1889955924;
			short num3 = num;
			num = (short)1658417236;
			switch (num3 == num)
			{
			}
			num = (short)1294991360;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x001D1344 File Offset: 0x001CF544
		public override void SetConstraints()
		{
			short num = (short)1447165952;
			short num2 = num;
			num = (short)196003565;
			short num3 = num;
			num = (short)398378733;
			switch (num3 == num)
			{
			}
			num = (short)1565655041;
			if (num != 0)
			{
			}
			num = (short)1664745472;
			if (num != 0)
			{
			}
			this.secSysCertGeneralCertificateFilename_A43634.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.SystemCertificates.List.SystemCertificateConstraints.conSetSystemCertificateFieldsValue);
			this.secSysCertGeneralCertificateFilename_A43634.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.SystemCertificates.List.SystemCertificateConstraints.conSetSystemCertificateFieldValidation);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x001D1418 File Offset: 0x001CF618
		public override void SetupDependencies()
		{
			short num = (short)585236480;
			short num2 = num;
			num = (short)578968175;
			short num3 = num;
			num = (short)1356225135;
			switch (num3 == num)
			{
			}
			num = (short)1137836032;
			if (num != 0)
			{
			}
			num = (short)835190785;
			if (num != 0)
			{
			}
			this.secSysCertGeneralCertificateFilename_A43634.AddDependentObject(this.secSysCertGeneralCertificateFileData_A43635);
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x001D14D8 File Offset: 0x001CF6D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1784807424;
				short num2 = num;
				num = (short)1686892192;
				short num3 = num;
				num = (short)4714144;
				switch (num3 == num)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				num = (short)2117599233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x001D1588 File Offset: 0x001CF788
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x001D163C File Offset: 0x001CF83C
		public string SecSysCertGeneralKeyofSystemCertificates_A43633Value
		{
			get
			{
				short num = (short)1062404096;
				short num2 = num;
				num = (short)347791624;
				short num3 = num;
				num = (short)211935496;
				switch (num3 == num)
				{
				}
				num = (short)305790977;
				if (num != 0)
				{
				}
				num = (short)1816199168;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.Value;
			}
			set
			{
				short num = (short)1231880192;
				short num2 = num;
				num = (short)570519697;
				short num3 = num;
				num = (short)1895002257;
				switch (num3 == num)
				{
				}
				num = (short)1042546689;
				if (num != 0)
				{
				}
				num = (short)1428553728;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.Value = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x001D16F4 File Offset: 0x001CF8F4
		public global::AcpBusinessLayer.AcpKeyField SecSysCertGeneralKeyofSystemCertificates_A43633Object
		{
			get
			{
				short num = (short)1871314944;
				short num2 = num;
				num = (short)94351809;
				short num3 = num;
				num = (short)2071048641;
				switch (num3 == num)
				{
				}
				num = (short)753991681;
				if (num != 0)
				{
				}
				num = (short)299237376;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x001D17A0 File Offset: 0x001CF9A0
		internal string SecSysCertGeneralKeyofSystemCertificates_A43633Name_UILabel
		{
			get
			{
				short num = (short)1878261760;
				short num2 = num;
				num = (short)1340195403;
				short num3 = num;
				num = (short)1265222219;
				switch (num3 == num)
				{
				}
				num = (short)1784217601;
				if (num != 0)
				{
				}
				num = (short)2017198080;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.UIName;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x001D1854 File Offset: 0x001CFA54
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x001D1904 File Offset: 0x001CFB04
		public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Applicable
		{
			get
			{
				short num = (short)595132416;
				short num2 = num;
				num = (short)676024725;
				short num3 = num;
				num = (short)40259989;
				switch (num3 == num)
				{
				}
				num = (short)901382145;
				if (num != 0)
				{
				}
				num = (short)426115072;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.Applicable;
			}
			set
			{
				short num = (short)2108162048;
				short num2 = num;
				num = (short)186777601;
				if (num != 0)
				{
				}
				num = (short)580048367;
				short num3 = num;
				num = (short)1355011567;
				switch (num3 == num)
				{
				}
				num = (short)2007105536;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.Applicable = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x001D19BC File Offset: 0x001CFBBC
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x001D1A6C File Offset: 0x001CFC6C
		public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Editable
		{
			get
			{
				short num = (short)2045771776;
				short num2 = num;
				num = (short)1488258495;
				short num3 = num;
				num = (short)639894975;
				switch (num3 == num)
				{
				}
				num = (short)527368193;
				if (num != 0)
				{
				}
				num = (short)263913472;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.Editable;
			}
			set
			{
				short num = (short)27656192;
				short num2 = num;
				num = (short)850666231;
				short num3 = num;
				num = (short)1709384439;
				switch (num3 == num)
				{
				}
				num = (short)1682243585;
				if (num != 0)
				{
				}
				num = (short)711655424;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.Editable = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x001D1B20 File Offset: 0x001CFD20
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x001D1BD4 File Offset: 0x001CFDD4
		public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Visible
		{
			get
			{
				short num = (short)965804032;
				short num2 = num;
				num = (short)332981211;
				short num3 = num;
				num = (short)1936188379;
				switch (num3 == num)
				{
				}
				num = (short)1600126977;
				if (num != 0)
				{
				}
				num = (short)1971716096;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.Visible;
			}
			set
			{
				short num = (short)1354301440;
				short num2 = num;
				num = (short)723959128;
				short num3 = num;
				num = (short)1845083480;
				switch (num3 == num)
				{
				}
				num = (short)1051131905;
				if (num != 0)
				{
				}
				num = (short)1924136960;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.Visible = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x001D1C88 File Offset: 0x001CFE88
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x001D1D3C File Offset: 0x001CFF3C
		internal bool SecSysCertGeneralKeyofSystemCertificates_A43633_HiddenStatic
		{
			get
			{
				short num = (short)940441600;
				short num2 = num;
				num = (short)1648313969;
				short num3 = num;
				num = (short)1611417201;
				switch (num3 == num)
				{
				}
				num = (short)1631584257;
				if (num != 0)
				{
				}
				num = (short)1644560384;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.HiddenStatic;
			}
			set
			{
				short num = (short)1276379136;
				short num2 = num;
				num = (short)339542017;
				if (num != 0)
				{
				}
				num = (short)547594562;
				short num3 = num;
				num = (short)180068674;
				switch (num3 == num)
				{
				}
				num = (short)628686848;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.HiddenStatic = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x001D1DF0 File Offset: 0x001CFFF0
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x001D1EA4 File Offset: 0x001D00A4
		public bool SecSysCertGeneralKeyofSystemCertificates_A43633_Valid
		{
			get
			{
				short num = (short)820707328;
				short num2 = num;
				num = (short)1642135553;
				if (num != 0)
				{
				}
				num = (short)423352685;
				short num3 = num;
				num = (short)1264507245;
				switch (num3 == num)
				{
				}
				num = (short)1532493824;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633.Valid;
			}
			set
			{
				short num = (short)1272971264;
				short num2 = num;
				num = (short)958284771;
				short num3 = num;
				num = (short)694502371;
				switch (num3 == num)
				{
				}
				num = (short)1312358400;
				if (num != 0)
				{
				}
				num = (short)982319105;
				if (num != 0)
				{
				}
				this.secSysCertGeneralKeyofSystemCertificates_A43633.Valid = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x001D1F5C File Offset: 0x001D015C
		public bool SecSysCertGeneralKeyofSystemCertificates_A43633_HasDiffs
		{
			get
			{
				short num = (short)1170472960;
				short num2 = num;
				num = (short)2053484513;
				short num3 = num;
				num = (short)897101793;
				switch (num3 == num)
				{
				}
				num = (short)866910209;
				if (num != 0)
				{
				}
				num = (short)1090846720;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralKeyofSystemCertificates_A43633._HasDiffs;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x001D2010 File Offset: 0x001D0210
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x001D20C4 File Offset: 0x001D02C4
		public string SecSysCertGeneralCertificateFilename_A43634Value
		{
			get
			{
				short num = (short)2062614528;
				short num2 = num;
				num = (short)1043958474;
				short num3 = num;
				num = (short)1967229642;
				switch (num3 == num)
				{
				}
				num = (short)1688600576;
				if (num != 0)
				{
				}
				num = (short)464388097;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.Value;
			}
			set
			{
				short num = (short)1864761344;
				short num2 = num;
				num = (short)1915963513;
				short num3 = num;
				num = (short)595609721;
				switch (num3 == num)
				{
				}
				num = (short)938606592;
				if (num != 0)
				{
				}
				num = (short)1134952449;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.Value = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x001D217C File Offset: 0x001D037C
		public global::AcpBusinessLayer.AcpStringField SecSysCertGeneralCertificateFilename_A43634Object
		{
			get
			{
				short num = (short)1958346752;
				short num2 = num;
				num = (short)1454488442;
				short num3 = num;
				num = (short)1614396282;
				switch (num3 == num)
				{
				}
				num = (short)1135280129;
				if (num != 0)
				{
				}
				num = (short)986710016;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x001D222C File Offset: 0x001D042C
		internal string SecSysCertGeneralCertificateFilename_A43634_UILabel
		{
			get
			{
				short num = (short)25296896;
				short num2 = num;
				num = (short)1744504402;
				short num3 = num;
				num = (short)1911686738;
				switch (num3 == num)
				{
				}
				num = (short)667680769;
				if (num != 0)
				{
				}
				num = (short)1996554240;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.UIName;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x001D22E4 File Offset: 0x001D04E4
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x001D2398 File Offset: 0x001D0598
		public bool SecSysCertGeneralCertificateFilename_A43634_Applicable
		{
			get
			{
				short num = (short)112066560;
				short num2 = num;
				num = (short)190513153;
				if (num != 0)
				{
				}
				num = (short)432072208;
				short num3 = num;
				num = (short)936371728;
				switch (num3 == num)
				{
				}
				num = (short)1760952320;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.Applicable;
			}
			set
			{
				short num = (short)289341440;
				short num2 = num;
				num = (short)1985750545;
				short num3 = num;
				num = (short)1657742865;
				switch (num3 == num)
				{
				}
				num = (short)1081933825;
				if (num != 0)
				{
				}
				num = (short)1520238592;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.Applicable = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x001D244C File Offset: 0x001D064C
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x001D2500 File Offset: 0x001D0700
		public bool SecSysCertGeneralCertificateFilename_A43634_Editable
		{
			get
			{
				short num = (short)1952002616;
				short num2 = num;
				num = (short)1586508344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081278464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1810432000;
				if (num != 0)
				{
				}
				num = (short)244842497;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.Editable;
			}
			set
			{
				short num = (short)324787305;
				short num2 = num;
				num = (short)295099497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220528640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476395009;
				if (num != 0)
				{
				}
				num = (short)2087583744;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.Editable = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x001D25B8 File Offset: 0x001D07B8
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x001D2670 File Offset: 0x001D0870
		public bool SecSysCertGeneralCertificateFilename_A43634_Visible
		{
			get
			{
				short num = (short)436994049;
				if (num != 0)
				{
				}
				num = (short)1399783424;
				short num2 = num;
				num = (short)234228841;
				short num3 = num;
				num = (short)1100745833;
				switch (num3 == num)
				{
				}
				num = (short)1318256640;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.Visible;
			}
			set
			{
				short num = (short)1086105714;
				short num2 = num;
				num = (short)1966844018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1140129792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138898433;
				if (num != 0)
				{
				}
				num = (short)1508704256;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.Visible = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x001D2724 File Offset: 0x001D0924
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x001D27DC File Offset: 0x001D09DC
		public bool SecSysCertGeneralCertificateFilename_A43634_Valid
		{
			get
			{
				short num = (short)1582628865;
				if (num != 0)
				{
				}
				num = (short)1072234496;
				short num2 = num;
				num = (short)425390758;
				short num3 = num;
				num = (short)904983206;
				switch (num3 == num)
				{
				}
				num = (short)305725440;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.Valid;
			}
			set
			{
				short num = (short)1002914506;
				short num2 = num;
				num = (short)1933263562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792278528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365639169;
				if (num != 0)
				{
				}
				num = (short)1171128320;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.Valid = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x001D2890 File Offset: 0x001D0A90
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x001D2944 File Offset: 0x001D0B44
		internal bool SecSysCertGeneralCertificateFilename_A43634_HiddenStatic
		{
			get
			{
				short num = (short)1723024434;
				short num2 = num;
				num = (short)1993425970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185480704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)587530241;
				if (num != 0)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.HiddenStatic;
			}
			set
			{
				short num = (short)894828545;
				if (num != 0)
				{
				}
				num = (short)1666318336;
				short num2 = num;
				num = (short)1615015971;
				short num3 = num;
				num = (short)1595879459;
				switch (num3 == num)
				{
				}
				num = (short)533790720;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.HiddenStatic = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x001D29FC File Offset: 0x001D0BFC
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x001D2AB0 File Offset: 0x001D0CB0
		internal bool SecSysCertGeneralCertificateFilename_A43634_HiddenDynamic
		{
			get
			{
				short num = (short)2140284864;
				short num2 = num;
				num = (short)209332160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278134784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265289728;
				if (num != 0)
				{
				}
				num = (short)1913978881;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634.HiddenDynamic;
			}
			set
			{
				short num = (short)421724161;
				if (num != 0)
				{
				}
				num = (short)653721600;
				short num2 = num;
				num = (short)445152504;
				short num3 = num;
				num = (short)1712880888;
				switch (num3 == num)
				{
				}
				num = (short)792068096;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFilename_A43634.HiddenDynamic = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x001D2B64 File Offset: 0x001D0D64
		public bool SecSysCertGeneralCertificateFilename_A43634_HasDiffs
		{
			get
			{
				short num = (short)94380638;
				short num2 = num;
				num = (short)1995121246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128988672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748486657;
				if (num != 0)
				{
				}
				num = (short)1112997888;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFilename_A43634._HasDiffs;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x001D2C18 File Offset: 0x001D0E18
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x001D2CC8 File Offset: 0x001D0EC8
		public global::AcpBusinessLayer.AcpVoiceFileStruct SecSysCertGeneralCertificateFileData_A43635Value
		{
			get
			{
				short num = (short)1743880045;
				short num2 = num;
				num = (short)229080941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)682950656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576323584;
				if (num != 0)
				{
				}
				num = (short)456720385;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.Value;
			}
			set
			{
				short num = (short)1782103325;
				short num2 = num;
				num = (short)1014545693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1524563968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053963776;
				if (num != 0)
				{
				}
				num = (short)710475777;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.Value = value;
				this.secSysCertGeneralCertificateFileData_A43635.SetUITimer();
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x001D2D8C File Offset: 0x001D0F8C
		public global::AcpBusinessLayer.AcpVoiceFileField SecSysCertGeneralCertificateFileData_A43635
		{
			get
			{
				short num = (short)942997505;
				if (num != 0)
				{
				}
				num = (short)2075918336;
				short num2 = num;
				num = (short)1010441720;
				short num3 = num;
				num = (short)942022136;
				switch (num3 == num)
				{
				}
				num = (short)872349696;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x001D2E38 File Offset: 0x001D1038
		internal string SecSysCertGeneralCertificateFileData_A43635_UILabel
		{
			get
			{
				short num = (short)1157634733;
				short num2 = num;
				num = (short)1477778093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420478976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)669974529;
				if (num != 0)
				{
				}
				num = (short)1122566144;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.UIName;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x001D2EEC File Offset: 0x001D10EC
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x001D2FA4 File Offset: 0x001D11A4
		public bool SecSysCertGeneralCertificateFileData_A43635_Applicable
		{
			get
			{
				short num = (short)721157538;
				short num2 = num;
				num = (short)770178466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119472128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495597057;
				if (num != 0)
				{
				}
				num = (short)1657077760;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.Applicable;
			}
			set
			{
				short num = (short)1368453842;
				short num2 = num;
				num = (short)941945554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119472128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337327617;
				if (num != 0)
				{
				}
				num = (short)397869056;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.Applicable = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x001D305C File Offset: 0x001D125C
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x001D3110 File Offset: 0x001D1310
		public bool SecSysCertGeneralCertificateFileData_A43635_Editable
		{
			get
			{
				short num = (short)1170271256;
				short num2 = num;
				num = (short)2092493848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768475136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788594688;
				if (num != 0)
				{
				}
				num = (short)334823425;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.Editable;
			}
			set
			{
				short num = (short)734053548;
				short num2 = num;
				num = (short)577291436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835794432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571146240;
				if (num != 0)
				{
				}
				num = (short)1418592257;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.Editable = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x001D31C4 File Offset: 0x001D13C4
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x001D3278 File Offset: 0x001D1478
		public bool SecSysCertGeneralCertificateFileData_A43635_Visible
		{
			get
			{
				short num = (short)336366439;
				short num2 = num;
				num = (short)1281657703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)91357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)556859392;
				if (num != 0)
				{
				}
				num = (short)1537933313;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.Visible;
			}
			set
			{
				short num = (short)1934854573;
				short num2 = num;
				num = (short)341739949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164364288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333657601;
				if (num != 0)
				{
				}
				num = (short)1965686784;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.Visible = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x001D332C File Offset: 0x001D152C
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x001D33E0 File Offset: 0x001D15E0
		internal bool SecSysCertGeneralCertificateFileData_A43635_HiddenStatic
		{
			get
			{
				short num = (short)409484336;
				short num2 = num;
				num = (short)1144732720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)883294208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)309985281;
				if (num != 0)
				{
				}
				num = (short)1656881152;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.HiddenStatic;
			}
			set
			{
				short num = (short)2113355334;
				short num2 = num;
				num = (short)1547714118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1289879552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)737542144;
				if (num != 0)
				{
				}
				num = (short)1704722433;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.HiddenStatic = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x001D3498 File Offset: 0x001D1698
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x001D354C File Offset: 0x001D174C
		public bool SecSysCertGeneralCertificateFileData_A43635_Valid
		{
			get
			{
				short num = (short)1991304140;
				short num2 = num;
				num = (short)1601037260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100728832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980156417;
				if (num != 0)
				{
				}
				num = (short)243728384;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635.Valid;
			}
			set
			{
				short num = (short)1399171975;
				short num2 = num;
				num = (short)1586211719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591803904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2119565313;
				if (num != 0)
				{
				}
				num = (short)734003200;
				if (num != 0)
				{
				}
				this.secSysCertGeneralCertificateFileData_A43635.Valid = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x001D3600 File Offset: 0x001D1800
		public bool SecSysCertGeneralCertificateFileData_A43635_HasDiffs
		{
			get
			{
				short num = (short)1284706145;
				short num2 = num;
				num = (short)1939345249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1823866880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1812004865;
				if (num != 0)
				{
				}
				num = (short)213843968;
				if (num != 0)
				{
				}
				return this.secSysCertGeneralCertificateFileData_A43635._HasDiffs;
			}
		}

		// Token: 0x04000B0B RID: 2827
		private global::AcpBusinessLayer.AcpKeyField secSysCertGeneralKeyofSystemCertificates_A43633;

		// Token: 0x04000B0C RID: 2828
		private global::AcpBusinessLayer.AcpStringField secSysCertGeneralCertificateFilename_A43634;

		// Token: 0x04000B0D RID: 2829
		private global::AcpBusinessLayer.AcpVoiceFileField secSysCertGeneralCertificateFileData_A43635;
	}
}
