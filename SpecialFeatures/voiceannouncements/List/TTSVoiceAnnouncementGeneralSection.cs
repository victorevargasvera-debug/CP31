using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000029 RID: 41
	[global::System.Serializable]
	public sealed class TTSVoiceAnnouncementGeneralSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060005AA RID: 1450 RVA: 0x00002650 File Offset: 0x00000850
		internal TTSVoiceAnnouncementGeneralSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000265F File Offset: 0x0000085F
		internal TTSVoiceAnnouncementGeneralSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000536A0 File Offset: 0x000518A0
		public override void Init()
		{
			int a_ = 11;
			short num = (short)1146421248;
			short num2 = num;
			num = (short)362684727;
			short num3 = num;
			num = (short)2130714935;
			switch (num3 == num)
			{
			}
			num = (short)1567424513;
			if (num != 0)
			{
			}
			num = (short)795279360;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88dﾏﮑ\ude97ﮝ쎡즣쎥麫龭芯肱蒳", a_), global::CommonResources.AppResources.Voice_Filename, 36);
			this.voiceFileName_A21220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.voiceFileName_A21220.DataTransferOrder = 4;
			this.voiceFileName_A21220.EvaluateRecRefs = true;
			this.voiceAnnouncementFileHashcode_A24563 = new global::AcpBusinessLayer.AcpField<uint>(0U, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88dﾏﮑ\ud997햟첡잣쎥얧쾩슫\udaad펱잳\udeb5\udbb7햹\ud8bb\udbbd", a_), global::CommonResources.AppResources.Voice_Hashcode);
			this.voiceAnnouncementFileHashcode_A24563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceAnnouncementFileHashcode_A24563.DataTransferOrder = 2;
			this.voiceAnnouncementEncodeType_A22264 = new global::AcpBusinessLayer.AcpListField(1, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88dﾏﮑ\ud997햟첡잣쎥얧쾩슫\udaad\udcb1ힳ\ud9b5\udcb7\udfb9잽낿ꟁ", a_), global::CommonResources.AppResources.Encode_Type, global::SpecialFeatures.VoiceAnnouncements.List.LOVs.VoiceAnnouncementEncodeType_A22264LovStrs);
			this.voiceAnnouncementEncodeType_A22264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceAnnouncementEncodeType_A22264.DataTransferOrder = 3;
			this.voiceFileDataInfo_A21213 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88dﾏﮑ\ud997햟첡잣쎥얧쾩슫\udaad\udbb1\ud8b3펵", a_), global::CommonResources.AppResources.Voice_Data);
			this.voiceFileDataInfo_A21213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceFileDataInfo_A21213.DataTransferOrder = 1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍ﲑ聯", a_);
			base.Id = 10502;
			base.UIName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾏﲑ릓톕춗펙벛쪝蒣잧쎩쾫쮭邯\udab3\ud8b5ힷ쾹튻\uddbdꖿ꿁ꇃꣅ볇胋ꟍꏏꛑ", a_);
			base.DataTransferOrder = 1;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0005387C File Offset: 0x00051A7C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1128923136;
			short num2 = num;
			num = (short)624427009;
			if (num != 0)
			{
			}
			num = (short)392711845;
			short num3 = num;
			num = (short)1031360165;
			switch (num3 == num)
			{
			}
			num = (short)311099392;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0005392C File Offset: 0x00051B2C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)184090629;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1680932873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1A4;
				case 2:
					this.voiceFileDataInfo_A21213 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲\udeb6햸\udeba", a_), global::CommonResources.AppResources.Voice_Data);
					this.voiceFileDataInfo_A21213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.voiceFileDataInfo_A21213.DataTransferOrder = 1;
					num = (short)1414529028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1DA;
				case 4:
					goto IL_2FF;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					goto IL_304;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲\udeb6햸\udeba", a_)))
					{
						num = (short)846004226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 8:
					goto IL_262;
				case 9:
					if (producerFields != null)
					{
						num = (short)1002373135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 10:
					this.voiceFileName_A21220 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udb9c춠욢욦쒨캪莰芲螴薶覸", a_), global::CommonResources.AppResources.Voice_Filename, 36);
					this.voiceFileName_A21220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.voiceFileName_A21220.DataTransferOrder = 4;
					this.voiceFileName_A21220.EvaluateRecRefs = true;
					num = (short)298254342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲ﶴ횶쪸펺\udebc킾ꗀꛂ", a_)))
					{
						num = (short)1338507276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_262;
				case 12:
					this.voiceAnnouncementFileHashcode_A24563 = new global::AcpBusinessLayer.AcpField<uint>(0U, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲ﶴ횶쪸펺\udebc킾ꗀꛂ", a_), global::CommonResources.AppResources.Voice_Hashcode);
					this.voiceAnnouncementFileHashcode_A24563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.voiceAnnouncementFileHashcode_A24563.DataTransferOrder = 2;
					num = (short)680329224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)816121599;
					short num3 = num;
					num = (short)686360319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A4;
					default:
						num = (short)1044971520;
						if (num != 0)
						{
						}
						this.voiceAnnouncementEncodeType_A22264 = new global::AcpBusinessLayer.AcpListField(1, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲\ud9b6\udab8풺\ud9bc\udabe闀뫂뗄ꋆ", a_), global::CommonResources.AppResources.Encode_Type, global::SpecialFeatures.VoiceAnnouncements.List.LOVs.VoiceAnnouncementEncodeType_A22264LovStrs);
						this.voiceAnnouncementEncodeType_A22264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.voiceAnnouncementEncodeType_A22264.DataTransferOrder = 3;
						num = (short)1011351555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udc9c쾠첢키즦쪨캪사쪮\udfb0잲\ud9b6\udab8풺\ud9bc\udabe闀뫂뗄ꋆ", a_)))
					{
						num = (short)1108869133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				case 15:
					num = (short)170000385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1516699648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A4:
				if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얒杖ﺖ滛ﺚ\udb9c춠욢욦쒨캪莰芲螴薶覸", a_)))
				{
					num = (short)456261642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_304;
				IL_1DA:
				num = (short)516161543;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_262:
				num = (short)1186529294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_304:
				num = (short)1187971073;
				if (num != 0)
				{
				}
				num = (short)1665007616;
				short num4 = num;
				num = (short)1541144587;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2FF:
			IL_400:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풒練ﲘﲜ", a_);
			base.Id = 10502;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00053D6C File Offset: 0x00051F6C
		public override void PopulateReferences()
		{
			short num = (short)17684042;
			short num2 = num;
			num = (short)1640617546;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AA:
				num = (short)588840962;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)128647168;
				if (num != 0)
				{
				}
				num = (short)1451294720;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)1275658240;
				short num4 = num;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1500250113;
					if (num != 0)
					{
					}
					global::AcpCommonLib.Document containerDoc = base.ParentRecset.ContainerDoc;
					num = (short)121241601;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			IL_A2:
			if (base.ParentRecset != null)
			{
				goto IL_AA;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00053E8C File Offset: 0x0005208C
		public override void DropReferences()
		{
			short num = (short)2122842112;
			short num2 = num;
			num = (short)980626816;
			short num3 = num;
			num = (short)1543122304;
			switch (num3 == num)
			{
			}
			num = (short)2078081024;
			if (num != 0)
			{
			}
			num = (short)1549467649;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00053F34 File Offset: 0x00052134
		public override void SetConstraints()
		{
			short num = (short)1217855488;
			short num2 = num;
			num = (short)1942691046;
			short num3 = num;
			num = (short)1499798758;
			switch (num3 == num)
			{
			}
			num = (short)1379860481;
			if (num != 0)
			{
			}
			num = (short)1434910720;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220.ValidateAcrossRecset = true;
			this.voiceFileName_A21220.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementsConstraints.conTTSVoiceAnnouncementFileValidity);
			this.voiceFileName_A21220.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementsConstraints.conSetTTSVAFieldsValue);
			this.voiceFileName_A21220.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementsConstraints.conSetTTSVoiceAnnouncementFileEditability);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00054030 File Offset: 0x00052230
		public override void SetupDependencies()
		{
			short num = (short)532685563;
			short num2 = num;
			num = (short)123871995;
			switch (num2 == num)
			{
			}
			num = (short)292225024;
			if (num != 0)
			{
			}
			num = (short)329121792;
			short num3 = num;
			num = (short)1004929025;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220.AddDependentObject(this.voiceAnnouncementEncodeType_A22264);
			this.voiceFileName_A21220.AddDependentObject(this.voiceFileDataInfo_A21213);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000540FC File Offset: 0x000522FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)400044950;
				short num2 = num;
				num = (short)115028886;
				switch (num2 == num)
				{
				}
				num = (short)1966931968;
				if (num != 0)
				{
				}
				num = (short)293732352;
				short num3 = num;
				num = (short)781582337;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000541AC File Offset: 0x000523AC
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00054260 File Offset: 0x00052460
		public string VoiceFileName_A21220Value
		{
			get
			{
				short num = (short)1791502935;
				short num2 = num;
				num = (short)1773152855;
				switch (num2 == num)
				{
				}
				num = (short)1049100289;
				if (num != 0)
				{
				}
				num = (short)561381376;
				short num3 = num;
				num = (short)1495597056;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Value;
			}
			set
			{
				short num = (short)1082315018;
				short num2 = num;
				num = (short)2077937930;
				switch (num2 == num)
				{
				}
				num = (short)1948975105;
				if (num != 0)
				{
				}
				num = (short)374407168;
				short num3 = num;
				num = (short)380764160;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Value = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00054314 File Offset: 0x00052514
		public global::AcpBusinessLayer.AcpKeyField VoiceFileName_A21220Object
		{
			get
			{
				short num = (short)232469798;
				short num2 = num;
				num = (short)620442918;
				switch (num2 == num)
				{
				}
				num = (short)1918500865;
				if (num != 0)
				{
				}
				num = (short)817430528;
				short num3 = num;
				num = (short)1315635200;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000543C4 File Offset: 0x000525C4
		internal string VoiceFileName_A21220_UILabel
		{
			get
			{
				short num = (short)1253284313;
				short num2 = num;
				num = (short)682072537;
				switch (num2 == num)
				{
				}
				num = (short)1015939073;
				if (num != 0)
				{
				}
				num = (short)1431371776;
				short num3 = num;
				num = (short)1122435072;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.UIName;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00054474 File Offset: 0x00052674
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00054528 File Offset: 0x00052728
		public bool VoiceFileName_A21220_Applicable
		{
			get
			{
				short num = (short)68591997;
				short num2 = num;
				num = (short)371827069;
				switch (num2 == num)
				{
				}
				num = (short)1754267649;
				if (num != 0)
				{
				}
				num = (short)1690501120;
				short num3 = num;
				num = (short)1056505856;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Applicable;
			}
			set
			{
				short num = (short)1980472419;
				short num2 = num;
				num = (short)1309187171;
				switch (num2 == num)
				{
				}
				num = (short)185663489;
				if (num != 0)
				{
				}
				num = (short)1971519488;
				short num3 = num;
				num = (short)1315241984;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Applicable = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x000545E0 File Offset: 0x000527E0
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00054694 File Offset: 0x00052894
		public bool VoiceFileName_A21220_Editable
		{
			get
			{
				short num = (short)1894338003;
				short num2 = num;
				num = (short)436948435;
				switch (num2 == num)
				{
				}
				num = (short)1945305089;
				if (num != 0)
				{
				}
				num = (short)2101542912;
				short num3 = num;
				num = (short)48955392;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Editable;
			}
			set
			{
				short num = (short)810270671;
				short num2 = num;
				num = (short)741654479;
				switch (num2 == num)
				{
				}
				num = (short)1729363969;
				if (num != 0)
				{
				}
				num = (short)1016791040;
				short num3 = num;
				num = (short)1909587968;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Editable = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00054748 File Offset: 0x00052948
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000547FC File Offset: 0x000529FC
		public bool VoiceFileName_A21220_Visible
		{
			get
			{
				short num = (short)1373420506;
				short num2 = num;
				num = (short)2056436698;
				switch (num2 == num)
				{
				}
				num = (short)1777139713;
				if (num != 0)
				{
				}
				num = (short)1636630528;
				short num3 = num;
				num = (short)1247739904;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Visible;
			}
			set
			{
				short num = (short)1939072176;
				short num2 = num;
				num = (short)1209132208;
				switch (num2 == num)
				{
				}
				num = (short)261292033;
				if (num != 0)
				{
				}
				num = (short)1817444352;
				short num3 = num;
				num = (short)762839040;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Visible = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000548B0 File Offset: 0x00052AB0
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00054964 File Offset: 0x00052B64
		public bool VoiceFileName_A21220_Valid
		{
			get
			{
				short num = (short)1893350331;
				short num2 = num;
				num = (short)1902590907;
				switch (num2 == num)
				{
				}
				num = (short)1719074817;
				if (num != 0)
				{
				}
				num = (short)257228800;
				short num3 = num;
				num = (short)676790272;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Valid;
			}
			set
			{
				short num = (short)1279673493;
				short num2 = num;
				num = (short)1934640277;
				switch (num2 == num)
				{
				}
				num = (short)596246528;
				if (num != 0)
				{
				}
				num = (short)1904017408;
				short num3 = num;
				num = (short)1602551809;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Valid = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00054A18 File Offset: 0x00052C18
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00054AD0 File Offset: 0x00052CD0
		internal bool VoiceFileName_A21220_HiddenStatic
		{
			get
			{
				short num = (short)323650243;
				short num2 = num;
				num = (short)395084483;
				switch (num2 == num)
				{
				}
				num = (short)398655489;
				if (num != 0)
				{
				}
				num = (short)1575813120;
				short num3 = num;
				num = (short)693043200;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.HiddenStatic;
			}
			set
			{
				short num = (short)1617595298;
				short num2 = num;
				num = (short)226200482;
				switch (num2 == num)
				{
				}
				num = (short)1434320896;
				if (num != 0)
				{
				}
				num = (short)1314979840;
				short num3 = num;
				num = (short)252706817;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.HiddenStatic = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00054B88 File Offset: 0x00052D88
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00054C3C File Offset: 0x00052E3C
		internal bool VoiceFileName_A21220_HiddenDynamic
		{
			get
			{
				short num = (short)1829956372;
				short num2 = num;
				num = (short)1617816340;
				switch (num2 == num)
				{
				}
				num = (short)320077825;
				if (num != 0)
				{
				}
				num = (short)1472200704;
				short num3 = num;
				num = (short)655360000;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.HiddenDynamic;
			}
			set
			{
				short num = (short)161866024;
				short num2 = num;
				num = (short)1137893672;
				switch (num2 == num)
				{
				}
				num = (short)910295041;
				if (num != 0)
				{
				}
				num = (short)30736384;
				short num3 = num;
				num = (short)1993670656;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.HiddenDynamic = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00054CF0 File Offset: 0x00052EF0
		public bool VoiceFileName_A21220_HasDiffs
		{
			get
			{
				short num = (short)1608721386;
				short num2 = num;
				num = (short)1558193130;
				switch (num2 == num)
				{
				}
				num = (short)1160773633;
				if (num != 0)
				{
				}
				num = (short)1405878272;
				short num3 = num;
				num = (short)1508311040;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220._HasDiffs;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00054DA4 File Offset: 0x00052FA4
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00054E58 File Offset: 0x00053058
		public uint VoiceAnnouncementFileHashcode_A24563Value
		{
			get
			{
				short num = (short)1095163014;
				short num2 = num;
				num = (short)74570886;
				switch (num2 == num)
				{
				}
				num = (short)1026228225;
				if (num != 0)
				{
				}
				num = (short)23855104;
				short num3 = num;
				num = (short)1226375168;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Value;
			}
			set
			{
				short num = (short)1729005242;
				short num2 = num;
				num = (short)68781754;
				switch (num2 == num)
				{
				}
				num = (short)1585381377;
				if (num != 0)
				{
				}
				num = (short)457441280;
				short num3 = num;
				num = (short)622854144;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Value = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00054F0C File Offset: 0x0005310C
		public global::AcpBusinessLayer.AcpField<uint> VoiceAnnouncementFileHashcode_A24563
		{
			get
			{
				short num = (short)2089658686;
				short num2 = num;
				num = (short)1060612414;
				switch (num2 == num)
				{
				}
				num = (short)1268187137;
				if (num != 0)
				{
				}
				num = (short)1762263040;
				short num3 = num;
				num = (short)1917648896;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00054FC0 File Offset: 0x000531C0
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00055074 File Offset: 0x00053274
		public uint VoiceAnnouncementFileHashcode_A24563_UIValue
		{
			get
			{
				short num = (short)331554856;
				short num2 = num;
				num = (short)55124008;
				switch (num2 == num)
				{
				}
				num = (short)896532481;
				if (num != 0)
				{
				}
				num = (short)1470234624;
				short num3 = num;
				num = (short)1426456576;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Value;
			}
			set
			{
				short num = (short)235846646;
				short num2 = num;
				num = (short)229358582;
				switch (num2 == num)
				{
				}
				num = (short)182386689;
				if (num != 0)
				{
				}
				num = (short)1423638528;
				short num3 = num;
				num = (short)216137728;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Value = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00055128 File Offset: 0x00053328
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x000551E0 File Offset: 0x000533E0
		public bool VoiceAnnouncementFileHashcode_A24563_Applicable
		{
			get
			{
				short num = (short)298248753;
				short num2 = num;
				num = (short)1439689265;
				switch (num2 == num)
				{
				}
				num = (short)1593049089;
				if (num != 0)
				{
				}
				num = (short)513933312;
				short num3 = num;
				num = (short)372506624;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Applicable;
			}
			set
			{
				short num = (short)589951878;
				short num2 = num;
				num = (short)381481862;
				switch (num2 == num)
				{
				}
				num = (short)1386348545;
				if (num != 0)
				{
				}
				num = (short)1439039488;
				short num3 = num;
				num = (short)1990131712;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Applicable = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00055294 File Offset: 0x00053494
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00055348 File Offset: 0x00053548
		public bool VoiceAnnouncementFileHashcode_A24563_Valid
		{
			get
			{
				short num = (short)1946492907;
				short num2 = num;
				num = (short)652681195;
				switch (num2 == num)
				{
				}
				num = (short)644808704;
				if (num != 0)
				{
				}
				num = (short)1903886336;
				short num3 = num;
				num = (short)695140353;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Valid;
			}
			set
			{
				short num = (short)1456505631;
				short num2 = num;
				num = (short)697795359;
				switch (num2 == num)
				{
				}
				num = (short)1294794753;
				if (num != 0)
				{
				}
				num = (short)1001848832;
				short num3 = num;
				num = (short)936968192;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Valid = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00055400 File Offset: 0x00053600
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x000554B8 File Offset: 0x000536B8
		public bool VoiceAnnouncementFileHashcode_A24563_Visible
		{
			get
			{
				short num = (short)87097345;
				if (num != 0)
				{
				}
				num = (short)2077895473;
				short num2 = num;
				num = (short)1299983153;
				switch (num2 == num)
				{
				}
				num = (short)1519058944;
				short num3 = num;
				num = (short)1216020480;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Visible;
			}
			set
			{
				short num = (short)177499073;
				short num2 = num;
				num = (short)793865153;
				switch (num2 == num)
				{
				}
				num = (short)2018836480;
				if (num != 0)
				{
				}
				num = (short)30081024;
				short num3 = num;
				num = (short)442761217;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Visible = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00055570 File Offset: 0x00053770
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00055624 File Offset: 0x00053824
		public bool VoiceAnnouncementFileHashcode_A24563_Editable
		{
			get
			{
				short num = (short)932316408;
				short num2 = num;
				num = (short)1531512056;
				switch (num2 == num)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				num = (short)1232142336;
				short num3 = num;
				num = (short)1606746113;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Editable;
			}
			set
			{
				short num = (short)879059588;
				short num2 = num;
				num = (short)791175812;
				switch (num2 == num)
				{
				}
				num = (short)584187905;
				if (num != 0)
				{
				}
				num = (short)990707712;
				short num3 = num;
				num = (short)2061828096;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Editable = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000556DC File Offset: 0x000538DC
		internal string VoiceAnnouncementFileHashcode_A24563_UILabel
		{
			get
			{
				short num = (short)224884624;
				short num2 = num;
				num = (short)267220880;
				switch (num2 == num)
				{
				}
				num = (short)702414849;
				if (num != 0)
				{
				}
				num = (short)1404960768;
				short num3 = num;
				num = (short)1861812224;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.UIName;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00055794 File Offset: 0x00053994
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0005584C File Offset: 0x00053A4C
		internal bool VoiceAnnouncementFileHashcode_A24563_HiddenStatic
		{
			get
			{
				short num = (short)645660673;
				if (num != 0)
				{
				}
				num = (short)1862393059;
				short num2 = num;
				num = (short)1416682723;
				switch (num2 == num)
				{
				}
				num = (short)2104885248;
				short num3 = num;
				num = (short)710868992;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.HiddenStatic;
			}
			set
			{
				short num = (short)375670339;
				short num2 = num;
				num = (short)1499612739;
				switch (num2 == num)
				{
				}
				num = (short)1205731328;
				if (num != 0)
				{
				}
				num = (short)1497759744;
				short num3 = num;
				num = (short)540409857;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.HiddenStatic = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00055900 File Offset: 0x00053B00
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x000559B4 File Offset: 0x00053BB4
		internal bool VoiceAnnouncementFileHashcode_A24563_HiddenDynamic
		{
			get
			{
				short num = (short)1172212488;
				short num2 = num;
				num = (short)116165384;
				switch (num2 == num)
				{
				}
				num = (short)962789377;
				if (num != 0)
				{
				}
				num = (short)1761280000;
				short num3 = num;
				num = (short)666697728;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.HiddenDynamic;
			}
			set
			{
				short num = (short)1615677634;
				short num2 = num;
				num = (short)1259882690;
				switch (num2 == num)
				{
				}
				num = (short)1326186497;
				if (num != 0)
				{
				}
				num = (short)308412416;
				short num3 = num;
				num = (short)548012032;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.HiddenDynamic = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00055A68 File Offset: 0x00053C68
		internal bool VoiceAnnouncementFileHashcode_A24563_HasDiffs
		{
			get
			{
				short num = (short)1678114817;
				if (num != 0)
				{
				}
				num = (short)758783008;
				short num2 = num;
				num = (short)1384061984;
				switch (num2 == num)
				{
				}
				num = (short)1644756992;
				short num3 = num;
				num = (short)1667039232;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563._HasDiffs;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00055B20 File Offset: 0x00053D20
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00055BD4 File Offset: 0x00053DD4
		public int VoiceAnnouncementEncodeType_A22264Value
		{
			get
			{
				short num = (short)1838022657;
				if (num != 0)
				{
				}
				num = (short)2135262589;
				short num2 = num;
				num = (short)1414825341;
				switch (num2 == num)
				{
				}
				num = (short)501350400;
				short num3 = num;
				num = (short)964231168;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Value;
			}
			set
			{
				short num = (short)41025537;
				if (num != 0)
				{
				}
				num = (short)1913664103;
				short num2 = num;
				num = (short)334901863;
				switch (num2 == num)
				{
				}
				num = (short)302972928;
				short num3 = num;
				num = (short)1104412672;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Value = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00055C88 File Offset: 0x00053E88
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00055D3C File Offset: 0x00053F3C
		public string VoiceAnnouncementEncodeType_A22264_UIValue
		{
			get
			{
				short num = (short)1356102659;
				short num2 = num;
				num = (short)802388995;
				switch (num2 == num)
				{
				}
				num = (short)993984513;
				if (num != 0)
				{
				}
				num = (short)1926758400;
				short num3 = num;
				num = (short)416874496;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.UIValue;
			}
			set
			{
				short num = (short)612317039;
				short num2 = num;
				num = (short)68892527;
				switch (num2 == num)
				{
				}
				num = (short)205783041;
				if (num != 0)
				{
				}
				num = (short)2030698496;
				short num3 = num;
				num = (short)1724841984;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.UIValue = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00055DF0 File Offset: 0x00053FF0
		public global::AcpBusinessLayer.AcpListField VoiceAnnouncementEncodeType_A22264
		{
			get
			{
				short num = (short)1551394766;
				short num2 = num;
				num = (short)409167822;
				switch (num2 == num)
				{
				}
				num = (short)985530369;
				if (num != 0)
				{
				}
				num = (short)1021902848;
				short num3 = num;
				num = (short)374210560;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00055EA0 File Offset: 0x000540A0
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00055F58 File Offset: 0x00054158
		public bool VoiceAnnouncementEncodeType_A22264_Applicable
		{
			get
			{
				short num = (short)567525377;
				short num2 = num;
				num = (short)249872385;
				switch (num2 == num)
				{
				}
				num = (short)1732313089;
				if (num != 0)
				{
				}
				num = (short)260571136;
				short num3 = num;
				num = (short)1613496320;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Applicable;
			}
			set
			{
				short num = (short)1797259265;
				if (num != 0)
				{
				}
				num = (short)732248951;
				short num2 = num;
				num = (short)728841079;
				switch (num2 == num)
				{
				}
				num = (short)4390912;
				short num3 = num;
				num = (short)1859584000;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Applicable = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0005600C File Offset: 0x0005420C
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000560C0 File Offset: 0x000542C0
		public bool VoiceAnnouncementEncodeType_A22264_Valid
		{
			get
			{
				short num = (short)2016192586;
				short num2 = num;
				num = (short)625584202;
				switch (num2 == num)
				{
				}
				num = (short)990248961;
				if (num != 0)
				{
				}
				num = (short)1842151424;
				short num3 = num;
				num = (short)1665794048;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Valid;
			}
			set
			{
				short num = (short)1755524853;
				short num2 = num;
				num = (short)1975201525;
				switch (num2 == num)
				{
				}
				num = (short)1703870465;
				if (num != 0)
				{
				}
				num = (short)1108869120;
				short num3 = num;
				num = (short)1877868544;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Valid = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00056178 File Offset: 0x00054378
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00056230 File Offset: 0x00054430
		public bool VoiceAnnouncementEncodeType_A22264_Visible
		{
			get
			{
				short num = (short)923950837;
				short num2 = num;
				num = (short)386096885;
				switch (num2 == num)
				{
				}
				num = (short)1473183745;
				if (num != 0)
				{
				}
				num = (short)1758724096;
				short num3 = num;
				num = (short)1722351616;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Visible;
			}
			set
			{
				short num = (short)442302465;
				if (num != 0)
				{
				}
				num = (short)1899092100;
				short num2 = num;
				num = (short)853203076;
				switch (num2 == num)
				{
				}
				num = (short)1507065856;
				short num3 = num;
				num = (short)1946419200;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Visible = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x000562E8 File Offset: 0x000544E8
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0005639C File Offset: 0x0005459C
		public bool VoiceAnnouncementEncodeType_A22264_Editable
		{
			get
			{
				short num = (short)1290507669;
				short num2 = num;
				num = (short)507352469;
				switch (num2 == num)
				{
				}
				num = (short)418447361;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)2005598208;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Editable;
			}
			set
			{
				short num = (short)2079286161;
				short num2 = num;
				num = (short)314467217;
				switch (num2 == num)
				{
				}
				num = (short)1109458945;
				if (num != 0)
				{
				}
				num = (short)1793720320;
				short num3 = num;
				num = (short)1010171904;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Editable = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00056454 File Offset: 0x00054654
		internal string VoiceAnnouncementEncodeType_A22264_UILabel
		{
			get
			{
				short num = (short)1735927254;
				short num2 = num;
				num = (short)1154557398;
				switch (num2 == num)
				{
				}
				num = (short)1926365185;
				if (num != 0)
				{
				}
				num = (short)2092433408;
				short num3 = num;
				num = (short)1584070656;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.UIName;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00056508 File Offset: 0x00054708
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000565BC File Offset: 0x000547BC
		internal bool VoiceAnnouncementEncodeType_A22264_HiddenStatic
		{
			get
			{
				short num = (short)1183691359;
				short num2 = num;
				num = (short)962376287;
				switch (num2 == num)
				{
				}
				num = (short)672792577;
				if (num != 0)
				{
				}
				num = (short)173277184;
				short num3 = num;
				num = (short)1770586112;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.HiddenStatic;
			}
			set
			{
				short num = (short)1592742138;
				short num2 = num;
				num = (short)151933178;
				switch (num2 == num)
				{
				}
				num = (short)1578041345;
				if (num != 0)
				{
				}
				num = (short)320143360;
				short num3 = num;
				num = (short)722403328;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.HiddenStatic = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00056674 File Offset: 0x00054874
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0005672C File Offset: 0x0005492C
		internal bool VoiceAnnouncementEncodeType_A22264_HiddenDynamic
		{
			get
			{
				short num = (short)1792671745;
				if (num != 0)
				{
				}
				num = (short)483694123;
				short num2 = num;
				num = (short)1948948011;
				switch (num2 == num)
				{
				}
				num = (short)1885274112;
				short num3 = num;
				num = (short)1293352960;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.HiddenDynamic;
			}
			set
			{
				short num = (short)1226340797;
				short num2 = num;
				num = (short)852720061;
				switch (num2 == num)
				{
				}
				num = (short)168427521;
				if (num != 0)
				{
				}
				num = (short)145948672;
				short num3 = num;
				num = (short)1599930368;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.HiddenDynamic = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x000567E0 File Offset: 0x000549E0
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00056894 File Offset: 0x00054A94
		public global::AcpBusinessLayer.AcpVoiceFileStruct VoiceFileDataInfo_A21213Value
		{
			get
			{
				short num = (short)219157358;
				short num2 = num;
				num = (short)53744494;
				switch (num2 == num)
				{
				}
				num = (short)744947713;
				if (num != 0)
				{
				}
				num = (short)2098593792;
				short num3 = num;
				num = (short)980353024;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Value;
			}
			set
			{
				short num = (short)1956052993;
				if (num != 0)
				{
				}
				num = (short)1464364640;
				short num2 = num;
				num = (short)29781600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087504384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814036480;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Value = value;
				this.voiceFileDataInfo_A21213.SetUITimer();
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00056954 File Offset: 0x00054B54
		public global::AcpBusinessLayer.AcpVoiceFileField VoiceFileDataInfo_A21213
		{
			get
			{
				short num = (short)1432938200;
				short num2 = num;
				num = (short)2115954392;
				switch (num2 == num)
				{
				}
				num = (short)208863232;
				short num3 = num;
				num = (short)1363083264;
				if (num != 0)
				{
				}
				num = (short)276037633;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00056A04 File Offset: 0x00054C04
		internal string VoiceFileDataInfo_A21213_UILabel
		{
			get
			{
				short num = (short)101269919;
				short num2 = num;
				num = (short)1508000159;
				switch (num2 == num)
				{
				}
				num = (short)1252392960;
				short num3 = num;
				num = (short)829554688;
				if (num != 0)
				{
				}
				num = (short)1574961153;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.UIName;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00056ABC File Offset: 0x00054CBC
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00056B70 File Offset: 0x00054D70
		public bool VoiceFileDataInfo_A21213_Applicable
		{
			get
			{
				short num = (short)1691908590;
				short num2 = num;
				num = (short)1531673070;
				switch (num2 == num)
				{
				}
				num = (short)559480832;
				short num3 = num;
				num = (short)1200029697;
				if (num != 0)
				{
				}
				num = (short)1415970816;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Applicable;
			}
			set
			{
				short num = (short)1382817374;
				short num2 = num;
				num = (short)720903774;
				switch (num2 == num)
				{
				}
				num = (short)159776768;
				short num3 = num;
				num = (short)1188036609;
				if (num != 0)
				{
				}
				num = (short)1035730944;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Applicable = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00056C28 File Offset: 0x00054E28
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00056CDC File Offset: 0x00054EDC
		public bool VoiceFileDataInfo_A21213_Editable
		{
			get
			{
				short num = (short)1338405170;
				short num2 = num;
				num = (short)936407346;
				switch (num2 == num)
				{
				}
				num = (short)397869056;
				short num3 = num;
				num = (short)2079064065;
				if (num != 0)
				{
				}
				num = (short)74776576;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Editable;
			}
			set
			{
				short num = (short)1761468946;
				short num2 = num;
				num = (short)746709522;
				switch (num2 == num)
				{
				}
				num = (short)930152448;
				short num3 = num;
				num = (short)1137180672;
				if (num != 0)
				{
				}
				num = (short)581828609;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Editable = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00056D90 File Offset: 0x00054F90
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00056E44 File Offset: 0x00055044
		public bool VoiceFileDataInfo_A21213_Visible
		{
			get
			{
				short num = (short)1265613526;
				short num2 = num;
				num = (short)1538046678;
				switch (num2 == num)
				{
				}
				num = (short)38731776;
				short num3 = num;
				num = (short)834666497;
				if (num != 0)
				{
				}
				num = (short)2047148032;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Visible;
			}
			set
			{
				short num = (short)1556633942;
				short num2 = num;
				num = (short)901732694;
				switch (num2 == num)
				{
				}
				num = (short)1614544896;
				short num3 = num;
				num = (short)1867448320;
				if (num != 0)
				{
				}
				num = (short)880803841;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Visible = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00056EF8 File Offset: 0x000550F8
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00056FAC File Offset: 0x000551AC
		internal bool VoiceFileDataInfo_A21213_HiddenStatic
		{
			get
			{
				short num = (short)1839792129;
				if (num != 0)
				{
				}
				num = (short)1880583455;
				short num2 = num;
				num = (short)2075749663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1141964800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)211943424;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.HiddenStatic;
			}
			set
			{
				short num = (short)1947557591;
				short num2 = num;
				num = (short)497049303;
				switch (num2 == num)
				{
				}
				num = (short)33751040;
				short num3 = num;
				num = (short)539426817;
				if (num != 0)
				{
				}
				num = (short)122552320;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.HiddenStatic = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00057064 File Offset: 0x00055264
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x0005711C File Offset: 0x0005531C
		public bool VoiceFileDataInfo_A21213_Valid
		{
			get
			{
				short num = (short)1537867777;
				if (num != 0)
				{
				}
				num = (short)1194131025;
				short num2 = num;
				num = (short)1549663825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121924608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860291072;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Valid;
			}
			set
			{
				short num = (short)763033531;
				short num2 = num;
				num = (short)875886523;
				switch (num2 == num)
				{
				}
				num = (short)1406009344;
				short num3 = num;
				num = (short)771358721;
				if (num != 0)
				{
				}
				num = (short)779681792;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Valid = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000571D0 File Offset: 0x000553D0
		public bool VoiceFileDataInfo_A21213_HasDiffs
		{
			get
			{
				short num = (short)1928807135;
				short num2 = num;
				num = (short)1098728159;
				switch (num2 == num)
				{
				}
				num = (short)1354891264;
				short num3 = num;
				num = (short)99549185;
				if (num != 0)
				{
				}
				num = (short)1953693696;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213._HasDiffs;
			}
		}

		// Token: 0x0400026A RID: 618
		private global::AcpBusinessLayer.AcpKeyField voiceFileName_A21220;

		// Token: 0x0400026B RID: 619
		private global::AcpBusinessLayer.AcpField<uint> voiceAnnouncementFileHashcode_A24563;

		// Token: 0x0400026C RID: 620
		private global::AcpBusinessLayer.AcpListField voiceAnnouncementEncodeType_A22264;

		// Token: 0x0400026D RID: 621
		private global::AcpBusinessLayer.AcpVoiceFileField voiceFileDataInfo_A21213;
	}
}
