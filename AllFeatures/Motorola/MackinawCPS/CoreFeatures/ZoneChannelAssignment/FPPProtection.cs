using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000048 RID: 72
	[global::System.Serializable]
	public class FPPProtection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0002BE7C File Offset: 0x0002A07C
		public FPPProtection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0002BE98 File Offset: 0x0002A098
		protected FPPProtection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1697302019;
			short num2 = num;
			num = (short)1236256259;
			switch (num2 == num)
			{
			}
			num = (short)1059979265;
			if (num != 0)
			{
			}
			num = (short)1876426752;
			if (num != 0)
			{
			}
			num = (short)830275584;
			short num3 = num;
			this.znChanCfgFPPProtectionProtectedZone_A8765 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闎뿐郒뷔뛖럘飚믜룞꟠돢뗤럦鯨蓪駬諮鋰蟲鳴飶韸꯺迼郾甀昂昄猆氈漊圌怎缐瘒䨔嘖℘Ⱊ⬜⨞", a_), global::CommonResources.AcgResources.ID_PROTECTEDZONE);
			this.znChanCfgFPPProtectionProtectedZone_A8765.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgFPPProtectionProtectedZone_A8765.DataTransferOrder = 3;
			this.znChanCfgFPPProtectionFPPEnable_A19562 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闎뿐郒뷔뛖럘飚믜룞꟠돢뗤럦鯨蓪駬諮鋰蟲鳴飶韸뷺근꿾䐀洂搄攆攈渊刌与‐⨒—№⬘", a_), global::CommonResources.AcgResources.ID_FPPENABLE);
			this.znChanCfgFPPProtectionFPPEnable_A19562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgFPPProtectionFPPEnable_A19562.DataTransferOrder = 14;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觎臐菒䀹蟖ꯘ듚꧜뫞苠韢賤裦蟨", a_);
			base.Id = 10117;
			base.UIName = global::CommonResources.AcgResources.ID_FPPPROTECTION;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002C00C File Offset: 0x0002A20C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)461635589;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.znChanCfgFPPProtectionProtectedZone_A8765 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷆ꟈ裊ꗌ껎뿐郒돔냖鿘诚跜连鏠賢釤苦諨鿪蓬胮鿰ꏲ蟴飶跸黺黼课搀朂弄栆月渊刌与⤐␒⌔∖", a_), global::CommonResources.AcgResources.ID_PROTECTEDZONE);
					this.znChanCfgFPPProtectionProtectedZone_A8765.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgFPPProtectionProtectedZone_A8765.DataTransferOrder = 3;
					num = (short)96927745;
					if (num != 0)
					{
					}
					num = (short)1640759302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)1756364808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 2:
					this.znChanCfgFPPProtectionFPPEnable_A19562 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷆ꟈ裊ꗌ껎뿐郒돔냖鿘诚跜连鏠賢釤苦諨鿪蓬胮鿰뗲ꗴꟶ본闺鳼鷾洀昂娄䘆㠈㈊㠌㤎⌐", a_), global::CommonResources.AcgResources.ID_FPPENABLE);
					this.znChanCfgFPPProtectionFPPEnable_A19562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgFPPProtectionFPPEnable_A19562.DataTransferOrder = 14;
					num = (short)1585840135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷆ꟈ裊ꗌ껎뿐郒돔냖鿘诚跜连鏠賢釤苦諨鿪蓬胮鿰뗲ꗴꟶ본闺鳼鷾洀昂娄䘆㠈㈊㠌㤎⌐", a_)))
					{
						num = (short)1934098434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 4:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷆ꟈ裊ꗌ껎뿐郒돔냖鿘诚跜连鏠賢釤苦諨鿪蓬胮鿰ꏲ蟴飶跸黺黼课搀朂弄栆月渊刌与⤐␒⌔∖", a_)))
					{
						goto IL_79;
					}
					num = (short)500229828;
					short num3 = num;
					num = (short)471131844;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)64421888;
						if (num != 0)
						{
						}
						num = (short)1067646976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_1E;
				case 6:
				{
					num = (short)1498808320;
					short num4 = num;
					goto IL_79;
				}
				case 7:
					goto IL_1F0;
				case 8:
					num = (short)2113601540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)518914049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_56;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_56:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_28E;
					}
					num = (short)771227657;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_79:
				num = (short)1860370435;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F0:
			IL_28E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臆駈鯊鿎ꏐ볒ꇔ닖뫘꿚드냞迠", a_);
			base.Id = 10117;
			base.UIName = global::CommonResources.AcgResources.ID_FPPPROTECTION;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002C2D8 File Offset: 0x0002A4D8
		public override void PopulateReferences()
		{
			short num = (short)885785026;
			short num2 = num;
			num = (short)1283523010;
			switch (num2 == num)
			{
			}
			num = (short)1186332672;
			if (num != 0)
			{
			}
			num = (short)744226817;
			if (num != 0)
			{
			}
			num = (short)994705408;
			short num3 = num;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0002C384 File Offset: 0x0002A584
		public override void DropReferences()
		{
			short num = (short)1722058481;
			short num2 = num;
			num = (short)1428784881;
			switch (num2 == num)
			{
			}
			num = (short)1364131841;
			if (num != 0)
			{
			}
			num = (short)639041536;
			if (num != 0)
			{
			}
			num = (short)1383727104;
			short num3 = num;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0002C430 File Offset: 0x0002A630
		public override void SetConstraints()
		{
			short num = (short)1142473124;
			short num2 = num;
			num = (short)721994148;
			switch (num2 == num)
			{
			}
			num = (short)940310529;
			if (num != 0)
			{
			}
			num = (short)530907136;
			if (num != 0)
			{
			}
			num = (short)934739968;
			short num3 = num;
			this.znChanCfgFPPProtectionProtectedZone_A8765.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.conChannelTypeIsCnvORProtectedZoneIsDisabled);
			this.znChanCfgFPPProtectionProtectedZone_A8765.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgFPPProtectionFPPEnable_A19562.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConChannelTypeIsTrkAndFppEnabled);
			this.znChanCfgFPPProtectionFPPEnable_A19562.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0002C534 File Offset: 0x0002A734
		public override void SetupDependencies()
		{
			short num = (short)2103505726;
			short num2 = num;
			num = (short)1974399806;
			switch (num2 == num)
			{
			}
			num = (short)936574977;
			if (num != 0)
			{
			}
			num = (short)815464448;
			if (num != 0)
			{
			}
			num = (short)330891264;
			short num3 = num;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1615380581;
				short num2 = num;
				num = (short)1069793381;
				switch (num2 == num)
				{
				}
				num = (short)1602486273;
				if (num != 0)
				{
				}
				num = (short)2034565120;
				if (num != 0)
				{
				}
				num = (short)532742144;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0002C68C File Offset: 0x0002A88C
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0002C740 File Offset: 0x0002A940
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765Value
		{
			get
			{
				short num = (short)1567031297;
				if (num != 0)
				{
				}
				num = (short)528692652;
				short num2 = num;
				num = (short)1772828076;
				switch (num2 == num)
				{
				}
				num = (short)1116143616;
				if (num != 0)
				{
				}
				num = (short)300613632;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Value;
			}
			set
			{
				short num = (short)1325659068;
				short num2 = num;
				num = (short)1679160252;
				switch (num2 == num)
				{
				}
				num = (short)1665335296;
				if (num != 0)
				{
				}
				num = (short)169738241;
				if (num != 0)
				{
				}
				num = (short)1164836864;
				short num3 = num;
				this.znChanCfgFPPProtectionProtectedZone_A8765.Value = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		public global::AcpBusinessLayer.AcpField<bool> ZnChanCfgFPPProtectionProtectedZone_A8765
		{
			get
			{
				short num = (short)1259151080;
				short num2 = num;
				num = (short)192159464;
				switch (num2 == num)
				{
				}
				num = (short)699858945;
				if (num != 0)
				{
				}
				num = (short)1628700672;
				if (num != 0)
				{
				}
				num = (short)1572470784;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0002C960 File Offset: 0x0002AB60
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_UIValue
		{
			get
			{
				short num = (short)1990857461;
				short num2 = num;
				num = (short)1105335029;
				switch (num2 == num)
				{
				}
				num = (short)1100873728;
				if (num != 0)
				{
				}
				num = (short)336396289;
				if (num != 0)
				{
				}
				num = (short)135462912;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Value;
			}
			set
			{
				short num = (short)1657304355;
				short num2 = num;
				num = (short)1656648995;
				switch (num2 == num)
				{
				}
				num = (short)464125953;
				if (num != 0)
				{
				}
				num = (short)2106785792;
				if (num != 0)
				{
				}
				num = (short)145620992;
				short num3 = num;
				this.znChanCfgFPPProtectionProtectedZone_A8765.Value = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0002CA14 File Offset: 0x0002AC14
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0002CACC File Offset: 0x0002ACCC
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_Applicable
		{
			get
			{
				short num = (short)1270633879;
				short num2 = num;
				num = (short)46814615;
				switch (num2 == num)
				{
				}
				num = (short)1869217792;
				if (num != 0)
				{
				}
				num = (short)2031026177;
				if (num != 0)
				{
				}
				num = (short)332529664;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Applicable;
			}
			set
			{
				short num = (short)1163898191;
				short num2 = num;
				num = (short)536653135;
				switch (num2 == num)
				{
				}
				num = (short)1946877953;
				if (num != 0)
				{
				}
				num = (short)763297792;
				if (num != 0)
				{
				}
				num = (short)1583349760;
				short num3 = num;
				this.znChanCfgFPPProtectionProtectedZone_A8765.Applicable = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0002CB84 File Offset: 0x0002AD84
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_Valid
		{
			get
			{
				short num = (short)1111221360;
				short num2 = num;
				num = (short)1175118960;
				switch (num2 == num)
				{
				}
				num = (short)425263104;
				if (num != 0)
				{
				}
				num = (short)1617428481;
				if (num != 0)
				{
				}
				num = (short)1401159680;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Valid;
			}
			set
			{
				short num = (short)1980664941;
				short num2 = num;
				num = (short)2104200301;
				switch (num2 == num)
				{
				}
				num = (short)1172832257;
				if (num != 0)
				{
				}
				num = (short)1769078784;
				if (num != 0)
				{
				}
				num = (short)920780800;
				short num3 = num;
				this.znChanCfgFPPProtectionProtectedZone_A8765.Valid = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_Visible
		{
			get
			{
				short num = (short)1832353820;
				short num2 = num;
				num = (short)2084995100;
				switch (num2 == num)
				{
				}
				num = (short)1249574913;
				if (num != 0)
				{
				}
				num = (short)540606464;
				if (num != 0)
				{
				}
				num = (short)201195520;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Visible;
			}
			set
			{
				short num = (short)927774474;
				short num2 = num;
				num = (short)1591195402;
				switch (num2 == num)
				{
				}
				num = (short)1351352321;
				if (num != 0)
				{
				}
				num = (short)1283850240;
				if (num != 0)
				{
				}
				num = (short)246874112;
				short num3 = num;
				this.znChanCfgFPPProtectionProtectedZone_A8765.Visible = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0002CE58 File Offset: 0x0002B058
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0002CF0C File Offset: 0x0002B10C
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_Editable
		{
			get
			{
				short num = (short)1153441927;
				short num2 = num;
				num = (short)1517232263;
				switch (num2 == num)
				{
				}
				num = (short)471138305;
				if (num != 0)
				{
				}
				num = (short)231735296;
				if (num != 0)
				{
				}
				num = (short)1913323520;
				short num3 = num;
				return this.znChanCfgFPPProtectionProtectedZone_A8765.Editable;
			}
			set
			{
				short num = (short)990730095;
				short num2 = num;
				num = (short)730683247;
				switch (num2 == num)
				{
				}
				num = (short)990904320;
				if (num != 0)
				{
				}
				num = (short)1048379392;
				short num3 = num;
				num = (short)844824577;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionProtectedZone_A8765.Editable = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		internal string ZnChanCfgFPPProtectionProtectedZone_A8765_UILabel
		{
			get
			{
				short num = (short)822242468;
				short num2 = num;
				num = (short)1383754916;
				switch (num2 == num)
				{
				}
				num = (short)1295777793;
				if (num != 0)
				{
				}
				num = (short)1487208448;
				short num3 = num;
				num = (short)1524695040;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionProtectedZone_A8765.UIName;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0002D078 File Offset: 0x0002B278
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0002D12C File Offset: 0x0002B32C
		internal bool ZnChanCfgFPPProtectionProtectedZone_A8765_HiddenStatic
		{
			get
			{
				short num = (short)99168651;
				short num2 = num;
				num = (short)2078749067;
				switch (num2 == num)
				{
				}
				num = (short)1868365825;
				if (num != 0)
				{
				}
				num = (short)1326710784;
				short num3 = num;
				num = (short)478478336;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionProtectedZone_A8765.HiddenStatic;
			}
			set
			{
				short num = (short)1832830160;
				short num2 = num;
				num = (short)1183499472;
				switch (num2 == num)
				{
				}
				num = (short)1538850817;
				if (num != 0)
				{
				}
				num = (short)37552128;
				short num3 = num;
				num = (short)292814848;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionProtectedZone_A8765.HiddenStatic = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0002D1E0 File Offset: 0x0002B3E0
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0002D298 File Offset: 0x0002B498
		internal bool ZnChanCfgFPPProtectionProtectedZone_A8765_HiddenDynamic
		{
			get
			{
				short num = (short)502587770;
				short num2 = num;
				num = (short)1898439034;
				switch (num2 == num)
				{
				}
				num = (short)1901920256;
				if (num != 0)
				{
				}
				num = (short)1238761472;
				short num3 = num;
				num = (short)784531457;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionProtectedZone_A8765.HiddenDynamic;
			}
			set
			{
				short num = (short)877750741;
				short num2 = num;
				num = (short)712600021;
				switch (num2 == num)
				{
				}
				num = (short)1596522497;
				if (num != 0)
				{
				}
				num = (short)265945088;
				short num3 = num;
				num = (short)135462912;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionProtectedZone_A8765.HiddenDynamic = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0002D34C File Offset: 0x0002B54C
		public bool ZnChanCfgFPPProtectionProtectedZone_A8765_HasDiffs
		{
			get
			{
				short num = (short)1330070308;
				short num2 = num;
				num = (short)1004028708;
				switch (num2 == num)
				{
				}
				num = (short)1037828096;
				if (num != 0)
				{
				}
				num = (short)1263075328;
				short num3 = num;
				num = (short)844234753;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionProtectedZone_A8765._HasDiffs;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0002D3FC File Offset: 0x0002B5FC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562Value
		{
			get
			{
				short num = (short)1127097016;
				short num2 = num;
				num = (short)1584276152;
				switch (num2 == num)
				{
				}
				num = (short)1065746433;
				if (num != 0)
				{
				}
				num = (short)688783360;
				short num3 = num;
				num = (short)1354825728;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Value;
			}
			set
			{
				short num = (short)693424327;
				short num2 = num;
				num = (short)2101792967;
				switch (num2 == num)
				{
				}
				num = (short)1431371777;
				if (num != 0)
				{
				}
				num = (short)1530134528;
				short num3 = num;
				num = (short)1545994240;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Value = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0002D568 File Offset: 0x0002B768
		public global::AcpBusinessLayer.AcpField<bool> ZnChanCfgFPPProtectionFPPEnable_A19562
		{
			get
			{
				short num = (short)2016280577;
				if (num != 0)
				{
				}
				num = (short)793816603;
				short num2 = num;
				num = (short)1273540123;
				switch (num2 == num)
				{
				}
				num = (short)1192427520;
				short num3 = num;
				num = (short)1885863936;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0002D618 File Offset: 0x0002B818
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_UIValue
		{
			get
			{
				short num = (short)1258799707;
				short num2 = num;
				num = (short)2051654235;
				switch (num2 == num)
				{
				}
				num = (short)133103617;
				if (num != 0)
				{
				}
				num = (short)926941184;
				short num3 = num;
				num = (short)946405376;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Value;
			}
			set
			{
				short num = (short)629836719;
				short num2 = num;
				num = (short)316181423;
				switch (num2 == num)
				{
				}
				num = (short)438632449;
				if (num != 0)
				{
				}
				num = (short)380174336;
				short num3 = num;
				num = (short)1886388224;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Value = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0002D788 File Offset: 0x0002B988
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0002D83C File Offset: 0x0002BA3C
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_Applicable
		{
			get
			{
				short num = (short)217457224;
				short num2 = num;
				num = (short)1468080712;
				switch (num2 == num)
				{
				}
				num = (short)640614401;
				if (num != 0)
				{
				}
				num = (short)748421120;
				short num3 = num;
				num = (short)61145088;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Applicable;
			}
			set
			{
				short num = (short)765779363;
				short num2 = num;
				num = (short)1929829795;
				switch (num2 == num)
				{
				}
				num = (short)1839988737;
				if (num != 0)
				{
				}
				num = (short)1534656512;
				short num3 = num;
				num = (short)53870592;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Applicable = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0002D9A4 File Offset: 0x0002BBA4
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_Valid
		{
			get
			{
				short num = (short)1412033830;
				short num2 = num;
				num = (short)1675947302;
				switch (num2 == num)
				{
				}
				num = (short)936181760;
				if (num != 0)
				{
				}
				num = (short)1027670016;
				short num3 = num;
				num = (short)1880096769;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Valid;
			}
			set
			{
				short num = (short)41004296;
				short num2 = num;
				num = (short)194227464;
				switch (num2 == num)
				{
				}
				num = (short)664862720;
				if (num != 0)
				{
				}
				num = (short)104333312;
				short num3 = num;
				num = (short)935854081;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Valid = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0002DA58 File Offset: 0x0002BC58
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_Visible
		{
			get
			{
				short num = (short)982166249;
				short num2 = num;
				num = (short)394767081;
				switch (num2 == num)
				{
				}
				num = (short)649723904;
				if (num != 0)
				{
				}
				num = (short)1527447552;
				short num3 = num;
				num = (short)1797783553;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Visible;
			}
			set
			{
				short num = (short)1290314780;
				short num2 = num;
				num = (short)844538908;
				switch (num2 == num)
				{
				}
				num = (short)1853423616;
				if (num != 0)
				{
				}
				num = (short)1311965184;
				short num3 = num;
				num = (short)1823539201;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Visible = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0002DC78 File Offset: 0x0002BE78
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_Editable
		{
			get
			{
				short num = (short)740044782;
				short num2 = num;
				num = (short)1549086702;
				switch (num2 == num)
				{
				}
				num = (short)1677983745;
				if (num != 0)
				{
				}
				num = (short)598474752;
				short num3 = num;
				num = (short)1519321088;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.Editable;
			}
			set
			{
				short num = (short)673118162;
				short num2 = num;
				num = (short)200931282;
				switch (num2 == num)
				{
				}
				num = (short)160432129;
				if (num != 0)
				{
				}
				num = (short)1896415232;
				short num3 = num;
				num = (short)1351745536;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.Editable = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0002DD30 File Offset: 0x0002BF30
		internal string ZnChanCfgFPPProtectionFPPEnable_A19562_UILabel
		{
			get
			{
				short num = (short)2013103953;
				short num2 = num;
				num = (short)993494865;
				switch (num2 == num)
				{
				}
				num = (short)727449601;
				if (num != 0)
				{
				}
				num = (short)2141913088;
				short num3 = num;
				num = (short)1551499264;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.UIName;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0002DE9C File Offset: 0x0002C09C
		internal bool ZnChanCfgFPPProtectionFPPEnable_A19562_HiddenStatic
		{
			get
			{
				short num = (short)1573590855;
				short num2 = num;
				num = (short)273028935;
				switch (num2 == num)
				{
				}
				num = (short)408616961;
				if (num != 0)
				{
				}
				num = (short)1381629952;
				short num3 = num;
				num = (short)1807351808;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.HiddenStatic;
			}
			set
			{
				short num = (short)1752948883;
				short num2 = num;
				num = (short)901636243;
				switch (num2 == num)
				{
				}
				num = (short)470941696;
				if (num != 0)
				{
				}
				num = (short)1527840768;
				short num3 = num;
				num = (short)1058734081;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.HiddenStatic = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0002DF50 File Offset: 0x0002C150
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0002E004 File Offset: 0x0002C204
		internal bool ZnChanCfgFPPProtectionFPPEnable_A19562_HiddenDynamic
		{
			get
			{
				short num = (short)1797511216;
				short num2 = num;
				num = (short)1987303472;
				switch (num2 == num)
				{
				}
				num = (short)1868890113;
				if (num != 0)
				{
				}
				num = (short)120389632;
				short num3 = num;
				num = (short)1640103936;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562.HiddenDynamic;
			}
			set
			{
				short num = (short)1904012137;
				short num2 = num;
				num = (short)1551297385;
				switch (num2 == num)
				{
				}
				num = (short)1890123777;
				if (num != 0)
				{
				}
				num = (short)318177280;
				short num3 = num;
				num = (short)1449263104;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A19562.HiddenDynamic = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		public bool ZnChanCfgFPPProtectionFPPEnable_A19562_HasDiffs
		{
			get
			{
				short num = (short)1253509696;
				short num2 = num;
				num = (short)2108361280;
				switch (num2 == num)
				{
				}
				num = (short)982319105;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				short num3 = num;
				num = (short)177471488;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A19562._HasDiffs;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0002E174 File Offset: 0x0002C374
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2130182145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1247412225;
					if (num2 != 0)
					{
					}
					num2 = (short)1763639296;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1394016260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)349228510;
					short num4 = num2;
					num2 = (short)1397870046;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)456130560;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset == null)
						{
							return result;
						}
						break;
					}
					num2 = (short)122748931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)772997120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)417988610;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000B4 RID: 180
		private global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x040000B5 RID: 181
		private global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionFPPEnable_A19562;
	}
}
