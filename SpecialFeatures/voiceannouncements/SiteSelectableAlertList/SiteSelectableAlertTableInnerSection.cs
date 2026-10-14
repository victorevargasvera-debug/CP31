using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x0200003C RID: 60
	[global::System.Serializable]
	public class SiteSelectableAlertTableInnerSection : global::AcpBusinessLayer.FeatureSection, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x00002650 File Offset: 0x00000850
		public SiteSelectableAlertTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000265F File Offset: 0x0000085F
		protected SiteSelectableAlertTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000677D4 File Offset: 0x000659D4
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)349700096;
			short num2 = num;
			num = (short)942894918;
			short num3 = num;
			num = (short)413495110;
			switch (num3 == num)
			{
			}
			num = (short)1852309504;
			if (num != 0)
			{
			}
			num = (short)874708993;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00067884 File Offset: 0x00065A84
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1833238528;
			short num2 = num;
			num = (short)1187470146;
			short num3 = num;
			num = (short)1915706178;
			switch (num3 == num)
			{
			}
			num = (short)625803264;
			if (num != 0)
			{
			}
			num = (short)982908929;
			if (num != 0)
			{
			}
			this.sSAFrontDisplayAlertAlias_A41987 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e슐튒펔\udb9e좠킢햤쮦좨튪쎮풰솲솴햸튺\udcbc첾黀苂頻", a_), global::CommonResources.AppResources.ID_ALERTALIAS, 14);
			this.sSAFrontDisplayAlertAlias_A41987.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.sSAFrontDisplayAlertAlias_A41987.DataTransferOrder = 1;
			this.sSAAlertFile_A41990 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e슐튒풔ﮖﲘ\ud99e좠쾢삤龪鲬隮袰莲", a_), global::CommonResources.AppResources.ID_ALERTFILE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.sSAAlertFile_A41990.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.sSAAlertFile_A41990.DataTransferOrder = 2;
			this.vASSAAlertPeriodSec_A41991 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98e킐삒요횖\ud898햠삤햦삨쒪즬ﲮ풰킲趸誺蒼蚾", a_), global::CommonResources.AppResources.ID_ALERTPERIODSEC, 5, 255, null, null, 0, 1);
			this.vASSAAlertPeriodSec_A41991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.vASSAAlertPeriodSec_A41991.DataTransferOrder = 3;
			this.vASSAAlertPeriodSec_A41991.ShowHexValue = false;
			this.vASSASubscriberEncodable_A41992 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98e킐삒요횖쪘ﾜ슠톢첤얦첨\ud9aa솮튰\udcb2톴횶\udbb8ힺ\ud8bc胀ﻆ流", a_), global::CommonResources.AppResources.ID_SUBSCRIBERENCODABLE);
			this.vASSASubscriberEncodable_A41992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.vASSASubscriberEncodable_A41992.DataTransferOrder = 4;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e랖쪘ﺚ爵슠힢쒤얦얨캪趬\uddb0횲잴쎶馸\udcbc\uddbe귀ꛂ", a_);
			base.Id = 10766;
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00067A74 File Offset: 0x00065C74
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)299499527;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_34E;
				case 1:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a\ude8c캎힐杖練\udf9a토쾢쒤\udea6잪좬\uddae얰\ud9b4\udeb6\ud8b8좺ﺾﳄￆﻈ", a_)))
					{
						num = (short)671416334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 2:
					goto IL_353;
				case 3:
					if (producerFields != null)
					{
						num = (short)1819738125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41F;
				case 4:
				{
					num = (short)1856613544;
					short num3 = num;
					num = (short)351186088;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_276;
					default:
						num = (short)423231488;
						if (num != 0)
						{
						}
						goto IL_2B1;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a첌\udc8e슐튒요ﮘﺜ좠솢삤햦얪캬삮햰튲ힴ\udbb6\udcb8ﲼ设輸ﳄ", a_)))
					{
						num = (short)2066743311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41F;
				case 6:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a첌\udc8e슐튒풔ﮖﲘ쾞쒠톢첤좦춨좬첮膴蚶肸芺貼", a_)))
					{
						num = (short)698089481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 7:
					num = (short)188088321;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_97;
					}
					continue;
				case 8:
					goto IL_22A;
				case 9:
					this.vASSAAlertPeriodSec_A41991 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a첌\udc8e슐튒풔ﮖﲘ쾞쒠톢첤좦춨좬첮膴蚶肸芺貼", a_), global::CommonResources.AppResources.ID_ALERTPERIODSEC, 5, 255, null, null, 0, 1);
					this.vASSAAlertPeriodSec_A41991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.vASSAAlertPeriodSec_A41991.DataTransferOrder = 3;
					this.vASSAAlertPeriodSec_A41991.ShowHexValue = false;
					num = (short)996933640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1847590912;
					short num4 = num;
					this.sSAAlertFile_A41990 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a\ude8c캎킐ﾒ\udd9a쒠ﲢ鎦風銪钬龮", a_), global::CommonResources.AppResources.ID_ALERTFILE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.sSAAlertFile_A41990.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.sSAAlertFile_A41990.DataTransferOrder = 2;
					num = (short)216137732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_276;
				case 12:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a\ude8c캎킐ﾒ\udd9a쒠ﲢ鎦風銪钬龮", a_)))
					{
						num = (short)1400176650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				case 13:
					num = (short)1703936001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.sSAFrontDisplayAlertAlias_A41987 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a\ude8c캎힐杖練\udf9a토쾢쒤\udea6잪좬\uddae얰\ud9b4\udeb6\ud8b8좺ﺾﳄￆﻈ", a_), global::CommonResources.AppResources.ID_ALERTALIAS, 14);
					this.sSAFrontDisplayAlertAlias_A41987.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.sSAFrontDisplayAlertAlias_A41987.DataTransferOrder = 1;
					num = (short)277807106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.vASSASubscriberEncodable_A41992 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8a첌\udc8e슐튒요ﮘﺜ좠솢삤햦얪캬삮햰튲ힴ\udbb6\udcb8ﲼ设輸ﳄ", a_), global::CommonResources.AppResources.ID_SUBSCRIBERENCODABLE);
					this.vASSASubscriberEncodable_A41992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.vASSASubscriberEncodable_A41992.DataTransferOrder = 4;
					num = (short)169148416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_97:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2047803403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_22A:
				num = (short)1348599813;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_276:
				num = (short)397279235;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				num = (short)2022572038;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_353:
				num = (short)212205580;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_34E:
			IL_41F:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﮎ뎒요ﺚﺜ삠솢즤슦覨솬쪮쎰잲閴\ud8b8\ud9ba톼\udabe", a_);
			base.Id = 10766;
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00067ED4 File Offset: 0x000660D4
		public override void PopulateReferences()
		{
			short num = (short)1916207104;
			short num2 = num;
			num = (short)175485584;
			short num3 = num;
			num = (short)129086096;
			switch (num3 == num)
			{
			}
			num = (short)662044672;
			if (num != 0)
			{
			}
			num = (short)1455226881;
			if (num != 0)
			{
			}
			this.sSAAlertFile_A41990.SetRecset(this.a(2300));
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00067F98 File Offset: 0x00066198
		public override void DropReferences()
		{
			short num = (short)1645281280;
			short num2 = num;
			num = (short)925195679;
			short num3 = num;
			num = (short)1360354719;
			switch (num3 == num)
			{
			}
			num = (short)1756954624;
			if (num != 0)
			{
			}
			num = (short)1686044673;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00068040 File Offset: 0x00066240
		public override void SetConstraints()
		{
			short num = (short)719257600;
			short num2 = num;
			num = (short)1968470101;
			short num3 = num;
			num = (short)460093525;
			switch (num3 == num)
			{
			}
			num = (short)1896808449;
			if (num != 0)
			{
			}
			num = (short)260898816;
			if (num != 0)
			{
			}
			this.vASSASubscriberEncodable_A41992.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SSAConstraints.ConUpdateSSAConfigType);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00068100 File Offset: 0x00066300
		public override void SetupDependencies()
		{
			short num = (short)1602879488;
			short num2 = num;
			num = (short)559959964;
			short num3 = num;
			num = (short)2117947292;
			switch (num3 == num)
			{
			}
			num = (short)778567681;
			if (num != 0)
			{
			}
			num = (short)1286144000;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x000681AC File Offset: 0x000663AC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1377566720;
				short num2 = num;
				num = (short)1100875885;
				short num3 = num;
				num = (short)1819805805;
				switch (num3 == num)
				{
				}
				num = (short)1103101952;
				if (num != 0)
				{
				}
				num = (short)2039545857;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0006825C File Offset: 0x0006645C
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00068314 File Offset: 0x00066514
		public string SSAFrontDisplayAlertAlias_A41987Value
		{
			get
			{
				short num = (short)577568768;
				short num2 = num;
				num = (short)1178664961;
				if (num != 0)
				{
				}
				num = (short)1071443267;
				short num3 = num;
				num = (short)1331621187;
				switch (num3 == num)
				{
				}
				num = (short)815333376;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Value;
			}
			set
			{
				short num = (short)1642266625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1353383936;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)141537083;
						short num4 = num;
						num = (short)1436921659;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F3;
						default:
							num = (short)187236352;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_F3;
					}
					IL_A5:
					num = (short)120848385;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)585302018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F3:
					this.sSAFrontDisplayAlertAlias_A41987.Value = value;
					num = (short)1445003264;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0006843C File Offset: 0x0006663C
		public global::AcpBusinessLayer.AcpKeyField SSAFrontDisplayAlertAlias_A41987
		{
			get
			{
				short num = (short)1949499392;
				short num2 = num;
				num = (short)1187252173;
				short num3 = num;
				num = (short)1444612045;
				switch (num3 == num)
				{
				}
				num = (short)1307967489;
				if (num != 0)
				{
				}
				num = (short)1403322368;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000684EC File Offset: 0x000666EC
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0006859C File Offset: 0x0006679C
		public string SSAFrontDisplayAlertAlias_A41987_UIValue
		{
			get
			{
				short num = (short)1198391296;
				short num2 = num;
				num = (short)1115374257;
				short num3 = num;
				num = (short)516440753;
				switch (num3 == num)
				{
				}
				num = (short)740098049;
				if (num != 0)
				{
				}
				num = (short)522715136;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Value;
			}
			set
			{
				short num = (short)154927104;
				short num2 = num;
				num = (short)192542899;
				short num3 = num;
				num = (short)768604339;
				switch (num3 == num)
				{
				}
				num = (short)2949121;
				if (num != 0)
				{
				}
				num = (short)1997537280;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.Value = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00068650 File Offset: 0x00066850
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00068704 File Offset: 0x00066904
		public bool SSAFrontDisplayAlertAlias_A41987_Applicable
		{
			get
			{
				short num = (short)1990262784;
				short num2 = num;
				num = (short)960757761;
				if (num != 0)
				{
				}
				num = (short)104104638;
				short num3 = num;
				num = (short)1822851774;
				switch (num3 == num)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Applicable;
			}
			set
			{
				short num = (short)1546256384;
				short num2 = num;
				num = (short)1352383601;
				short num3 = num;
				num = (short)1463991409;
				switch (num3 == num)
				{
				}
				num = (short)496435201;
				if (num != 0)
				{
				}
				num = (short)278396928;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.Applicable = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000687B8 File Offset: 0x000669B8
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0006886C File Offset: 0x00066A6C
		public bool SSAFrontDisplayAlertAlias_A41987_Valid
		{
			get
			{
				short num = (short)1933901824;
				short num2 = num;
				num = (short)358740280;
				short num3 = num;
				num = (short)1334702392;
				switch (num3 == num)
				{
				}
				num = (short)1043070976;
				if (num != 0)
				{
				}
				num = (short)258342913;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Valid;
			}
			set
			{
				short num = (short)1558839296;
				short num2 = num;
				num = (short)956144530;
				short num3 = num;
				num = (short)2076023698;
				switch (num3 == num)
				{
				}
				num = (short)1752104960;
				if (num != 0)
				{
				}
				num = (short)1761017857;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.Valid = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00068924 File Offset: 0x00066B24
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x000689D8 File Offset: 0x00066BD8
		public bool SSAFrontDisplayAlertAlias_A41987_Visible
		{
			get
			{
				short num = (short)1144193024;
				short num2 = num;
				num = (short)892138332;
				short num3 = num;
				num = (short)836432732;
				switch (num3 == num)
				{
				}
				num = (short)755564545;
				if (num != 0)
				{
				}
				num = (short)135987200;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Visible;
			}
			set
			{
				short num = (short)93585408;
				short num2 = num;
				num = (short)1688455259;
				short num3 = num;
				num = (short)838060123;
				switch (num3 == num)
				{
				}
				num = (short)1329135617;
				if (num != 0)
				{
				}
				num = (short)1218117632;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.Visible = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00068A8C File Offset: 0x00066C8C
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00068B40 File Offset: 0x00066D40
		public bool SSAFrontDisplayAlertAlias_A41987_Editable
		{
			get
			{
				short num = (short)953024512;
				short num2 = num;
				num = (short)1061688782;
				short num3 = num;
				num = (short)929568206;
				switch (num3 == num)
				{
				}
				num = (short)1800011776;
				if (num != 0)
				{
				}
				num = (short)606928897;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.Editable;
			}
			set
			{
				short num = (short)1559494656;
				short num2 = num;
				num = (short)1212690489;
				short num3 = num;
				num = (short)1819029561;
				switch (num3 == num)
				{
				}
				num = (short)988938240;
				if (num != 0)
				{
				}
				num = (short)1884553217;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.Editable = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00068BF4 File Offset: 0x00066DF4
		internal string SSAFrontDisplayAlertAlias_A41987_UILabel
		{
			get
			{
				short num = (short)1795902078;
				short num2 = num;
				num = (short)518998654;
				switch (num2 == num)
				{
				}
				num = (short)221249536;
				short num3 = num;
				num = (short)65011713;
				if (num != 0)
				{
				}
				num = (short)1819672576;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.UIName;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00068CA8 File Offset: 0x00066EA8
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00068D58 File Offset: 0x00066F58
		internal bool SSAFrontDisplayAlertAlias_A41987_HiddenStatic
		{
			get
			{
				short num = (short)777675547;
				short num2 = num;
				num = (short)2120573723;
				switch (num2 == num)
				{
				}
				num = (short)2134835200;
				short num3 = num;
				num = (short)1481834497;
				if (num != 0)
				{
				}
				num = (short)448528384;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.HiddenStatic;
			}
			set
			{
				short num = (short)530589997;
				short num2 = num;
				num = (short)819079469;
				switch (num2 == num)
				{
				}
				num = (short)1260781568;
				short num3 = num;
				num = (short)1612251137;
				if (num != 0)
				{
				}
				num = (short)843251712;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.HiddenStatic = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00068E10 File Offset: 0x00067010
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00068EC8 File Offset: 0x000670C8
		internal bool SSAFrontDisplayAlertAlias_A41987_HiddenDynamic
		{
			get
			{
				short num = (short)2008428014;
				short num2 = num;
				num = (short)392179182;
				switch (num2 == num)
				{
				}
				num = (short)139001856;
				short num3 = num;
				num = (short)1516175361;
				if (num != 0)
				{
				}
				num = (short)25624576;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987.HiddenDynamic;
			}
			set
			{
				short num = (short)1848617101;
				short num2 = num;
				num = (short)1558489229;
				switch (num2 == num)
				{
				}
				num = (short)505544704;
				short num3 = num;
				num = (short)2003042305;
				if (num != 0)
				{
				}
				num = (short)159318016;
				if (num != 0)
				{
				}
				this.sSAFrontDisplayAlertAlias_A41987.HiddenDynamic = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00068F80 File Offset: 0x00067180
		public bool SSAFrontDisplayAlertAlias_A41987_HasDiffs
		{
			get
			{
				short num = (short)1297097147;
				short num2 = num;
				num = (short)541335995;
				switch (num2 == num)
				{
				}
				num = (short)384630784;
				short num3 = num;
				num = (short)2085814273;
				if (num != 0)
				{
				}
				num = (short)1709703168;
				if (num != 0)
				{
				}
				return this.sSAFrontDisplayAlertAlias_A41987._HasDiffs;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00069034 File Offset: 0x00067234
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000690E8 File Offset: 0x000672E8
		public int SSAAlertFile_A41990Value
		{
			get
			{
				short num = (short)2098698375;
				short num2 = num;
				num = (short)1473550471;
				switch (num2 == num)
				{
				}
				num = (short)900530176;
				short num3 = num;
				num = (short)700383233;
				if (num != 0)
				{
				}
				num = (short)1657929728;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.Value;
			}
			set
			{
				short num = (short)980758525;
				short num2 = num;
				num = (short)1449406461;
				switch (num2 == num)
				{
				}
				num = (short)190447616;
				short num3 = num;
				num = (short)154468352;
				if (num != 0)
				{
				}
				num = (short)1139605505;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.Value = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0006919C File Offset: 0x0006739C
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00069250 File Offset: 0x00067450
		public string SSAAlertFile_A41990_UIValue
		{
			get
			{
				short num = (short)490178486;
				short num2 = num;
				num = (short)1545963446;
				switch (num2 == num)
				{
				}
				num = (short)306315264;
				short num3 = num;
				num = (short)2044264448;
				if (num != 0)
				{
				}
				num = (short)478347265;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.UIValue;
			}
			set
			{
				short num = (short)1259489756;
				short num2 = num;
				num = (short)1100958172;
				switch (num2 == num)
				{
				}
				num = (short)1102774272;
				short num3 = num;
				num = (short)1459355649;
				if (num != 0)
				{
				}
				num = (short)1487798272;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.UIValue = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00069304 File Offset: 0x00067504
		public global::AcpBusinessLayer.AcpRecRefField SSAAlertFile_A41990
		{
			get
			{
				short num = (short)1488388097;
				if (num != 0)
				{
				}
				num = (short)1975864487;
				short num2 = num;
				num = (short)433147047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326893568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036793344;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000693B0 File Offset: 0x000675B0
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00069464 File Offset: 0x00067664
		public bool SSAAlertFile_A41990_Applicable
		{
			get
			{
				short num = (short)1188092949;
				short num2 = num;
				num = (short)1543756821;
				switch (num2 == num)
				{
				}
				num = (short)258277376;
				short num3 = num;
				num = (short)1976369152;
				if (num != 0)
				{
				}
				num = (short)1642397697;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.Applicable;
			}
			set
			{
				short num = (short)853209619;
				short num2 = num;
				num = (short)236515859;
				switch (num2 == num)
				{
				}
				num = (short)1544290304;
				short num3 = num;
				num = (short)365035521;
				if (num != 0)
				{
				}
				num = (short)1566179328;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.Applicable = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00069518 File Offset: 0x00067718
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x000695CC File Offset: 0x000677CC
		public bool SSAAlertFile_A41990_Valid
		{
			get
			{
				short num = (short)1155796265;
				short num2 = num;
				num = (short)1038945577;
				switch (num2 == num)
				{
				}
				num = (short)308477952;
				short num3 = num;
				num = (short)1440612353;
				if (num != 0)
				{
				}
				num = (short)372113408;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.Valid;
			}
			set
			{
				short num = (short)651034625;
				if (num != 0)
				{
				}
				num = (short)1563949637;
				short num2 = num;
				num = (short)987888197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15335424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795883008;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.Valid = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00069680 File Offset: 0x00067880
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00069738 File Offset: 0x00067938
		public bool SSAAlertFile_A41990_Visible
		{
			get
			{
				short num = (short)1190181371;
				short num2 = num;
				num = (short)1289468411;
				switch (num2 == num)
				{
				}
				num = (short)1956773888;
				short num3 = num;
				num = (short)2079260673;
				if (num != 0)
				{
				}
				num = (short)1007157248;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.Visible;
			}
			set
			{
				short num = (short)1552068713;
				short num2 = num;
				num = (short)1028894825;
				switch (num2 == num)
				{
				}
				num = (short)734003200;
				short num3 = num;
				num = (short)212860929;
				if (num != 0)
				{
				}
				num = (short)1867448320;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.Visible = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000697F0 File Offset: 0x000679F0
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x000698A4 File Offset: 0x00067AA4
		public bool SSAAlertFile_A41990_Editable
		{
			get
			{
				short num = (short)1743838107;
				short num2 = num;
				num = (short)15326107;
				switch (num2 == num)
				{
				}
				num = (short)7077888;
				short num3 = num;
				num = (short)178782208;
				if (num != 0)
				{
				}
				num = (short)1364656129;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.Editable;
			}
			set
			{
				short num = (short)1503583139;
				short num2 = num;
				num = (short)1599003555;
				switch (num2 == num)
				{
				}
				num = (short)1507196928;
				short num3 = num;
				num = (short)574554113;
				if (num != 0)
				{
				}
				num = (short)1952972800;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.Editable = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x0006995C File Offset: 0x00067B5C
		internal string SSAAlertFile_A41990_UILabel
		{
			get
			{
				short num = (short)144532489;
				short num2 = num;
				num = (short)126968841;
				switch (num2 == num)
				{
				}
				num = (short)1821179904;
				short num3 = num;
				num = (short)851050497;
				if (num != 0)
				{
				}
				num = (short)655294464;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.UIName;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00069A10 File Offset: 0x00067C10
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00069AC8 File Offset: 0x00067CC8
		internal bool SSAAlertFile_A41990_HiddenStatic
		{
			get
			{
				short num = (short)644666025;
				short num2 = num;
				num = (short)2077151913;
				switch (num2 == num)
				{
				}
				num = (short)227016704;
				short num3 = num;
				num = (short)348848129;
				if (num != 0)
				{
				}
				num = (short)1731526656;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.HiddenStatic;
			}
			set
			{
				short num = (short)1721048394;
				short num2 = num;
				num = (short)1257119050;
				switch (num2 == num)
				{
				}
				num = (short)2002124800;
				short num3 = num;
				num = (short)1352466433;
				if (num != 0)
				{
				}
				num = (short)126418944;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.HiddenStatic = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00069B7C File Offset: 0x00067D7C
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00069C34 File Offset: 0x00067E34
		internal bool SSAAlertFile_A41990_HiddenDynamic
		{
			get
			{
				short num = (short)1680702686;
				short num2 = num;
				num = (short)1076919518;
				switch (num2 == num)
				{
				}
				num = (short)710934528;
				short num3 = num;
				num = (short)650706945;
				if (num != 0)
				{
				}
				num = (short)719781888;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990.HiddenDynamic;
			}
			set
			{
				short num = (short)236562789;
				short num2 = num;
				num = (short)1238542693;
				switch (num2 == num)
				{
				}
				num = (short)1222377472;
				short num3 = num;
				num = (short)1446641665;
				if (num != 0)
				{
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				this.sSAAlertFile_A41990.HiddenDynamic = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00069CEC File Offset: 0x00067EEC
		public bool SSAAlertFile_A41990_HasDiffs
		{
			get
			{
				short num = (short)1778703871;
				short num2 = num;
				num = (short)1260969471;
				switch (num2 == num)
				{
				}
				num = (short)266928128;
				short num3 = num;
				num = (short)710672384;
				if (num != 0)
				{
				}
				num = (short)1476591617;
				if (num != 0)
				{
				}
				return this.sSAAlertFile_A41990._HasDiffs;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00069DA0 File Offset: 0x00067FA0
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00069E54 File Offset: 0x00068054
		public int VASSAAlertPeriodSec_A41991Value
		{
			get
			{
				short num = (short)304159314;
				short num2 = num;
				num = (short)69605970;
				switch (num2 == num)
				{
				}
				num = (short)1309933568;
				short num3 = num;
				num = (short)571211776;
				if (num != 0)
				{
				}
				num = (short)581566465;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Value;
			}
			set
			{
				short num = (short)1904367387;
				short num2 = num;
				num = (short)1142314779;
				switch (num2 == num)
				{
				}
				num = (short)163184640;
				short num3 = num;
				num = (short)73007105;
				if (num != 0)
				{
				}
				num = (short)933167104;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Value = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00069F08 File Offset: 0x00068108
		public global::AcpBusinessLayer.AcpSimpleRangeField VASSAAlertPeriodSec_A41991
		{
			get
			{
				short num = (short)94371841;
				if (num != 0)
				{
				}
				num = (short)1191935492;
				short num2 = num;
				num = (short)814120452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1758593024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721223680;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00069FB8 File Offset: 0x000681B8
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0006A06C File Offset: 0x0006826C
		public string VASSAAlertPeriodSec_A41991_UIValue
		{
			get
			{
				short num = (short)385319226;
				short num2 = num;
				num = (short)1913749818;
				switch (num2 == num)
				{
				}
				num = (short)572653568;
				short num3 = num;
				num = (short)209780737;
				if (num != 0)
				{
				}
				num = (short)862519296;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.UIValue;
			}
			set
			{
				short num = (short)1959539888;
				short num2 = num;
				num = (short)889402544;
				switch (num2 == num)
				{
				}
				num = (short)1394671616;
				short num3 = num;
				num = (short)1600585728;
				if (num != 0)
				{
				}
				num = (short)66125825;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.UIValue = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0006A120 File Offset: 0x00068320
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0006A1D4 File Offset: 0x000683D4
		internal int VASSAAlertPeriodSec_A41991Min
		{
			get
			{
				short num = (short)1541326450;
				short num2 = num;
				num = (short)1339999858;
				switch (num2 == num)
				{
				}
				num = (short)1074200576;
				short num3 = num;
				num = (short)1042153473;
				if (num != 0)
				{
				}
				num = (short)1160380416;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Min;
			}
			set
			{
				short num = (short)588204339;
				short num2 = num;
				num = (short)345393459;
				switch (num2 == num)
				{
				}
				num = (short)721289216;
				short num3 = num;
				num = (short)96993280;
				if (num != 0)
				{
				}
				num = (short)1216217089;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Min = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0006A28C File Offset: 0x0006848C
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0006A340 File Offset: 0x00068540
		internal int VASSAAlertPeriodSec_A41991Max
		{
			get
			{
				short num = (short)177078273;
				if (num != 0)
				{
				}
				num = (short)1442364797;
				short num2 = num;
				num = (short)1776336253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481703424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915144704;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Max;
			}
			set
			{
				short num = (short)1633641642;
				short num2 = num;
				num = (short)1593468074;
				switch (num2 == num)
				{
				}
				num = (short)1479409664;
				short num3 = num;
				num = (short)350420993;
				if (num != 0)
				{
				}
				num = (short)1307181056;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Max = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0006A3F8 File Offset: 0x000685F8
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0006A4B0 File Offset: 0x000686B0
		internal int VASSAAlertPeriodSec_A41991Step
		{
			get
			{
				short num = (short)694363335;
				short num2 = num;
				num = (short)519578823;
				switch (num2 == num)
				{
				}
				num = (short)1927413760;
				short num3 = num;
				num = (short)1231945729;
				if (num != 0)
				{
				}
				num = (short)39190528;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.StepSize;
			}
			set
			{
				short num = (short)1545795622;
				short num2 = num;
				num = (short)1530853414;
				switch (num2 == num)
				{
				}
				num = (short)87490560;
				short num3 = num;
				num = (short)612630529;
				if (num != 0)
				{
				}
				num = (short)950272000;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.StepSize = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0006A564 File Offset: 0x00068764
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0006A618 File Offset: 0x00068818
		public bool VASSAAlertPeriodSec_A41991_Applicable
		{
			get
			{
				short num = (short)1806730107;
				short num2 = num;
				num = (short)969376635;
				switch (num2 == num)
				{
				}
				num = (short)2109931520;
				short num3 = num;
				num = (short)570818560;
				if (num != 0)
				{
				}
				num = (short)353042433;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Applicable;
			}
			set
			{
				short num = (short)543065250;
				short num2 = num;
				num = (short)256869538;
				switch (num2 == num)
				{
				}
				num = (short)2041380864;
				short num3 = num;
				num = (short)1798242305;
				if (num != 0)
				{
				}
				num = (short)933298176;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Applicable = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0006A6CC File Offset: 0x000688CC
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0006A784 File Offset: 0x00068984
		public bool VASSAAlertPeriodSec_A41991_Valid
		{
			get
			{
				short num = (short)1574614290;
				short num2 = num;
				num = (short)814724370;
				switch (num2 == num)
				{
				}
				num = (short)1928724480;
				short num3 = num;
				num = (short)1373241345;
				if (num != 0)
				{
				}
				num = (short)935067648;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Valid;
			}
			set
			{
				short num = (short)1301567130;
				short num2 = num;
				num = (short)1242977946;
				switch (num2 == num)
				{
				}
				num = (short)1400438784;
				short num3 = num;
				num = (short)137691137;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Valid = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0006A83C File Offset: 0x00068A3C
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0006A8F0 File Offset: 0x00068AF0
		public bool VASSAAlertPeriodSec_A41991_Visible
		{
			get
			{
				short num = (short)369557505;
				if (num != 0)
				{
				}
				num = (short)2103424789;
				short num2 = num;
				num = (short)1165080341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465305600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818558464;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Visible;
			}
			set
			{
				short num = (short)70244463;
				short num2 = num;
				num = (short)462215279;
				switch (num2 == num)
				{
				}
				num = (short)1090977792;
				short num3 = num;
				num = (short)2124546048;
				if (num != 0)
				{
				}
				num = (short)1038221313;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Visible = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0006A9A8 File Offset: 0x00068BA8
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0006AA60 File Offset: 0x00068C60
		public bool VASSAAlertPeriodSec_A41991_Editable
		{
			get
			{
				short num = (short)1710908812;
				short num2 = num;
				num = (short)319972748;
				switch (num2 == num)
				{
				}
				num = (short)975306752;
				short num3 = num;
				num = (short)1068498945;
				if (num != 0)
				{
				}
				num = (short)1206779904;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.Editable;
			}
			set
			{
				short num = (short)137127263;
				short num2 = num;
				num = (short)1436837215;
				switch (num2 == num)
				{
				}
				num = (short)1560018944;
				short num3 = num;
				num = (short)1205796864;
				if (num != 0)
				{
				}
				num = (short)379518977;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.Editable = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0006AB14 File Offset: 0x00068D14
		internal string VASSAAlertPeriodSec_A41991_UILabel
		{
			get
			{
				short num = (short)1342487334;
				short num2 = num;
				num = (short)971029286;
				switch (num2 == num)
				{
				}
				num = (short)245956608;
				short num3 = num;
				num = (short)1186725889;
				if (num != 0)
				{
				}
				num = (short)1720123392;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.UIName;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0006ABCC File Offset: 0x00068DCC
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x0006AC84 File Offset: 0x00068E84
		internal bool VASSAAlertPeriodSec_A41991_HiddenStatic
		{
			get
			{
				short num = (short)1048536731;
				short num2 = num;
				num = (short)276981403;
				switch (num2 == num)
				{
				}
				num = (short)1854865408;
				short num3 = num;
				num = (short)866385920;
				if (num != 0)
				{
				}
				num = (short)432799745;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.HiddenStatic;
			}
			set
			{
				short num = (short)634193568;
				short num2 = num;
				num = (short)2012546720;
				switch (num2 == num)
				{
				}
				num = (short)1531052032;
				short num3 = num;
				num = (short)1606156288;
				if (num != 0)
				{
				}
				num = (short)1230176257;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.HiddenStatic = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0006AD38 File Offset: 0x00068F38
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x0006ADE8 File Offset: 0x00068FE8
		internal bool VASSAAlertPeriodSec_A41991_HiddenDynamic
		{
			get
			{
				short num = (short)1607824788;
				short num2 = num;
				num = (short)1570141588;
				switch (num2 == num)
				{
				}
				num = (short)859242496;
				short num3 = num;
				num = (short)1655504897;
				if (num != 0)
				{
				}
				num = (short)428736512;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991.HiddenDynamic;
			}
			set
			{
				short num = (short)428130859;
				short num2 = num;
				num = (short)1314636331;
				switch (num2 == num)
				{
				}
				num = (short)663945216;
				short num3 = num;
				num = (short)1314324481;
				if (num != 0)
				{
				}
				num = (short)99942400;
				if (num != 0)
				{
				}
				this.vASSAAlertPeriodSec_A41991.HiddenDynamic = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0006AEA0 File Offset: 0x000690A0
		public bool VASSAAlertPeriodSec_A41991_HasDiffs
		{
			get
			{
				short num = (short)934491964;
				short num2 = num;
				num = (short)624965436;
				switch (num2 == num)
				{
				}
				num = (short)1868496896;
				short num3 = num;
				num = (short)623443969;
				if (num != 0)
				{
				}
				num = (short)1176764416;
				if (num != 0)
				{
				}
				return this.vASSAAlertPeriodSec_A41991._HasDiffs;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0006AF58 File Offset: 0x00069158
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0006B00C File Offset: 0x0006920C
		public bool VASSASubscriberEncodable_A41992Value
		{
			get
			{
				short num = (short)461368104;
				short num2 = num;
				num = (short)291433256;
				switch (num2 == num)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				num = (short)1016791041;
				if (num != 0)
				{
				}
				num = (short)1246232576;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Value;
			}
			set
			{
				short num = (short)1255610304;
				short num2 = num;
				num = (short)1315575744;
				switch (num2 == num)
				{
				}
				num = (short)537526272;
				short num3 = num;
				num = (short)189857793;
				if (num != 0)
				{
				}
				num = (short)1016594432;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Value = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0006B0C4 File Offset: 0x000692C4
		public global::AcpBusinessLayer.AcpField<bool> VASSASubscriberEncodable_A41992
		{
			get
			{
				short num = (short)1037757624;
				short num2 = num;
				num = (short)1691282616;
				switch (num2 == num)
				{
				}
				num = (short)805961728;
				short num3 = num;
				num = (short)2104754177;
				if (num != 0)
				{
				}
				num = (short)1282670592;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0006B174 File Offset: 0x00069374
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x0006B22C File Offset: 0x0006942C
		public bool VASSASubscriberEncodable_A41992_UIValue
		{
			get
			{
				short num = (short)1351725508;
				short num2 = num;
				num = (short)763277764;
				switch (num2 == num)
				{
				}
				num = (short)163250176;
				short num3 = num;
				num = (short)1933836289;
				if (num != 0)
				{
				}
				num = (short)1710489600;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Value;
			}
			set
			{
				short num = (short)19553680;
				short num2 = num;
				num = (short)786062736;
				switch (num2 == num)
				{
				}
				num = (short)282984448;
				short num3 = num;
				num = (short)550699009;
				if (num != 0)
				{
				}
				num = (short)1329266688;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Value = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0006B2E4 File Offset: 0x000694E4
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x0006B398 File Offset: 0x00069598
		public bool VASSASubscriberEncodable_A41992_Applicable
		{
			get
			{
				short num = (short)107621684;
				short num2 = num;
				num = (short)1928473908;
				switch (num2 == num)
				{
				}
				num = (short)1768292352;
				short num3 = num;
				num = (short)1084751872;
				if (num != 0)
				{
				}
				num = (short)874905601;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Applicable;
			}
			set
			{
				short num = (short)1812129341;
				short num2 = num;
				num = (short)11134525;
				switch (num2 == num)
				{
				}
				num = (short)1398407168;
				short num3 = num;
				num = (short)2101411841;
				if (num != 0)
				{
				}
				num = (short)483524608;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Applicable = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0006B44C File Offset: 0x0006964C
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0006B504 File Offset: 0x00069704
		public bool VASSASubscriberEncodable_A41992_Valid
		{
			get
			{
				short num = (short)1615036359;
				short num2 = num;
				num = (short)1364950983;
				switch (num2 == num)
				{
				}
				num = (short)265814016;
				short num3 = num;
				num = (short)909049856;
				if (num != 0)
				{
				}
				num = (short)108396545;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Valid;
			}
			set
			{
				short num = (short)100159470;
				short num2 = num;
				num = (short)1596477422;
				switch (num2 == num)
				{
				}
				num = (short)2127822848;
				short num3 = num;
				num = (short)601751553;
				if (num != 0)
				{
				}
				num = (short)1713766400;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Valid = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0006B5B8 File Offset: 0x000697B8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0006B66C File Offset: 0x0006986C
		public bool VASSASubscriberEncodable_A41992_Visible
		{
			get
			{
				short num = (short)1659866682;
				short num2 = num;
				num = (short)27758138;
				switch (num2 == num)
				{
				}
				num = (short)640090112;
				short num3 = num;
				num = (short)1439105024;
				if (num != 0)
				{
				}
				num = (short)1509490689;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Visible;
			}
			set
			{
				short num = (short)335923872;
				short num2 = num;
				num = (short)345426592;
				switch (num2 == num)
				{
				}
				num = (short)839385088;
				short num3 = num;
				num = (short)335937537;
				if (num != 0)
				{
				}
				num = (short)489684992;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Visible = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0006B724 File Offset: 0x00069924
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0006B7D8 File Offset: 0x000699D8
		public bool VASSASubscriberEncodable_A41992_Editable
		{
			get
			{
				short num = (short)1927879299;
				short num2 = num;
				num = (short)2096634499;
				switch (num2 == num)
				{
				}
				num = (short)586219520;
				short num3 = num;
				num = (short)1734934529;
				if (num != 0)
				{
				}
				num = (short)1896087552;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.Editable;
			}
			set
			{
				short num = (short)1943645890;
				short num2 = num;
				num = (short)253341378;
				switch (num2 == num)
				{
				}
				num = (short)1670447104;
				short num3 = num;
				num = (short)1819869185;
				if (num != 0)
				{
				}
				num = (short)557645824;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.Editable = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0006B890 File Offset: 0x00069A90
		internal string VASSASubscriberEncodable_A41992_UILabel
		{
			get
			{
				short num = (short)142606337;
				if (num != 0)
				{
				}
				num = (short)73945862;
				short num2 = num;
				num = (short)1600803590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)269877248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008154112;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.UIName;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0006B944 File Offset: 0x00069B44
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0006B9F8 File Offset: 0x00069BF8
		internal bool VASSASubscriberEncodable_A41992_HiddenStatic
		{
			get
			{
				short num = (short)1777632105;
				short num2 = num;
				num = (short)1441039209;
				switch (num2 == num)
				{
				}
				num = (short)921894912;
				short num3 = num;
				num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)1653080064;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.HiddenStatic;
			}
			set
			{
				short num = (short)1860239361;
				if (num != 0)
				{
				}
				num = (short)1869808499;
				short num2 = num;
				num = (short)689570675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785856000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1731526656;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.HiddenStatic = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0006BAAC File Offset: 0x00069CAC
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0006BB60 File Offset: 0x00069D60
		internal bool VASSASubscriberEncodable_A41992_HiddenDynamic
		{
			get
			{
				short num = (short)1211440792;
				short num2 = num;
				num = (short)333389464;
				switch (num2 == num)
				{
				}
				num = (short)1636499456;
				short num3 = num;
				num = (short)1756954624;
				if (num != 0)
				{
				}
				num = (short)311296001;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992.HiddenDynamic;
			}
			set
			{
				short num = (short)1714225153;
				if (num != 0)
				{
				}
				num = (short)1966509416;
				short num2 = num;
				num = (short)894799208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)754122752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519831552;
				if (num != 0)
				{
				}
				this.vASSASubscriberEncodable_A41992.HiddenDynamic = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0006BC18 File Offset: 0x00069E18
		public bool VASSASubscriberEncodable_A41992_HasDiffs
		{
			get
			{
				short num = (short)168159330;
				short num2 = num;
				num = (short)1849878626;
				switch (num2 == num)
				{
				}
				num = (short)1497300992;
				short num3 = num;
				num = (short)847970305;
				if (num != 0)
				{
				}
				num = (short)1656553472;
				if (num != 0)
				{
				}
				return this.vASSASubscriberEncodable_A41992._HasDiffs;
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0006BCCC File Offset: 0x00069ECC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_81;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1278541827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1279983616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)7733252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1895170049;
					if (num2 != 0)
					{
					}
					num2 = (short)602275840;
					short num3 = num2;
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1057882114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
			}
			IL_81:
			num2 = (short)219480606;
			short num4 = num2;
			num2 = (short)810549790;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_24:
				result = null;
				num2 = (short)258670593;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1638727680;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x040002DE RID: 734
		private global::AcpBusinessLayer.AcpKeyField sSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002DF RID: 735
		private global::AcpBusinessLayer.AcpRecRefField sSAAlertFile_A41990;

		// Token: 0x040002E0 RID: 736
		private global::AcpBusinessLayer.AcpSimpleRangeField vASSAAlertPeriodSec_A41991;

		// Token: 0x040002E1 RID: 737
		private global::AcpBusinessLayer.AcpField<bool> vASSASubscriberEncodable_A41992;
	}
}
