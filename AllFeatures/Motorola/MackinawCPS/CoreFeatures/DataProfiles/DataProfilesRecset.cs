using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F6 RID: 1270
	[global::System.Serializable]
	public class DataProfilesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600AA7A RID: 43642 RVA: 0x009EF658 File Offset: 0x009ED858
		public DataProfilesRecset() : base(global::CommonResources.AcgResources.ID_DATAPROFILES, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x009EF67C File Offset: 0x009ED87C
		public DataProfilesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x009EF6A8 File Offset: 0x009ED8A8
		public override int MaxPool
		{
			get
			{
				short num = (short)1506110878;
				short num2 = num;
				num = (short)1065184670;
				switch (num2 == num)
				{
				}
				num = (short)1257111553;
				if (num != 0)
				{
				}
				num = (short)1902837760;
				if (num != 0)
				{
				}
				num = (short)1891500032;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._MaxPool;
			}
		}

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x0600AA7D RID: 43645 RVA: 0x009EF754 File Offset: 0x009ED954
		// (set) Token: 0x0600AA7E RID: 43646 RVA: 0x009EF818 File Offset: 0x009EDA18
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)64225089;
					short num2 = num;
					num = (short)522977089;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)949420032;
						short num3 = num;
						num = (short)1111949313;
						if (num != 0)
						{
						}
						num = (short)1120796672;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)613548033;
				if (num != 0)
				{
				}
				num = (short)775502419;
				short num2 = num;
				num = (short)1598634579;
				switch (num2 == num)
				{
				}
				num = (short)1652293632;
				if (num != 0)
				{
				}
				num = (short)1776615424;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x0600AA7F RID: 43647 RVA: 0x009EF8CC File Offset: 0x009EDACC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1189732514;
				short num2 = num;
				num = (short)1511383202;
				switch (num2 == num)
				{
				}
				num = (short)558891009;
				if (num != 0)
				{
				}
				num = (short)1426980864;
				if (num != 0)
				{
				}
				num = (short)49741824;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x0600AA80 RID: 43648 RVA: 0x009EF97C File Offset: 0x009EDB7C
		// (set) Token: 0x0600AA81 RID: 43649 RVA: 0x009EFA28 File Offset: 0x009EDC28
		public override int Min
		{
			get
			{
				short num = (short)46169046;
				short num2 = num;
				num = (short)940407766;
				switch (num2 == num)
				{
				}
				num = (short)1684471809;
				if (num != 0)
				{
				}
				num = (short)965279744;
				if (num != 0)
				{
				}
				num = (short)1889665024;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._Min;
			}
			set
			{
				short num = (short)568266200;
				short num2 = num;
				num = (short)2042498520;
				switch (num2 == num)
				{
				}
				num = (short)1680998401;
				if (num != 0)
				{
				}
				num = (short)679280640;
				if (num != 0)
				{
				}
				num = (short)914096128;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._Min = value;
			}
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x009EFAD8 File Offset: 0x009EDCD8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1673487768;
			short num2 = num;
			num = (short)548365720;
			switch (num2 == num)
			{
			}
			num = (short)1455751168;
			if (num != 0)
			{
			}
			num = (short)1379926017;
			if (num != 0)
			{
			}
			num = (short)43122688;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles(this);
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x009EFB88 File Offset: 0x009EDD88
		internal void SetValues()
		{
			int a_ = 12;
			short num = (short)2029677697;
			short num2 = num;
			num = (short)1702653057;
			switch (num2 == num)
			{
			}
			num = (short)1935802369;
			if (num != 0)
			{
			}
			num = (short)998703104;
			if (num != 0)
			{
			}
			num = (short)99483648;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 2054;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶뷸髺觼黾℀䀂樄椆漈戊樌税挐爒愔縖瘘甚䄜嬞䀠圢䐤ܦ礨太䈬䤮堰弲倴䐶攸缺尼䬾⁀ፂ㝄⡆⽈≊⅌⩎≐ݒ㝔㭖睘⍚㱜㉞ൠ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAPROFILES;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 28;
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x009EFC88 File Offset: 0x009EDE88
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)2033693218;
			short num2 = num;
			num = (short)1370993186;
			switch (num2 == num)
			{
			}
			num = (short)174981121;
			if (num != 0)
			{
			}
			num = (short)775618560;
			if (num != 0)
			{
			}
			num = (short)1644363776;
			short num3 = num;
			base.OnFinishedAddRecord(record);
			this.c(record);
			this.d(record);
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x009EFD48 File Offset: 0x009EDF48
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1051789635;
			short num2 = num;
			num = (short)1053821251;
			switch (num2 == num)
			{
			}
			num = (short)1035403265;
			if (num != 0)
			{
			}
			num = (short)46858240;
			if (num != 0)
			{
			}
			num = (short)1117323264;
			short num3 = num;
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.d(record);
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x009EFE04 File Offset: 0x009EE004
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						(dataWideRecset[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222.CalculateValidity();
						num2 = (short)101908483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)420019514;
						short num3 = num2;
						num2 = (short)1442446650;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
							num2 = (short)2020409344;
							if (num2 != 0)
							{
							}
							if (dataWideRecset.Count > 0)
							{
								num2 = (short)1925971968;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
					{
						num2 = (short)1407254529;
						if (num2 != 0)
						{
						}
						num2 = (short)1698299904;
						short num4 = num2;
						if (dataWideRecset != null)
						{
							num2 = (short)527761412;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 3:
						return;
					case 4:
						num2 = (short)51380225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				return;
			}
			IL_24:
			dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
			IL_34:
			num2 = (short)1698562050;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x009EFF90 File Offset: 0x009EE190
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1058481235;
			short num2 = num;
			num = (short)68494419;
			switch (num2 == num)
			{
			}
			num = (short)1891434496;
			if (num != 0)
			{
			}
			num = (short)682950657;
			if (num != 0)
			{
			}
			num = (short)1013710848;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x009F0040 File Offset: 0x009EE240
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)362014865;
			short num2 = num;
			num = (short)330164369;
			switch (num2 == num)
			{
			}
			num = (short)1198391297;
			if (num != 0)
			{
			}
			num = (short)1329004544;
			if (num != 0)
			{
			}
			num = (short)1950154752;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x009F00F0 File Offset: 0x009EE2F0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)384499712;
			switch (num)
			{
			default:
			{
				num = (short)1825243159;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					switch (num2)
					{
					case 0:
					{
						if (radioWide == null)
						{
							num = (short)1937899526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1971978241;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset;
						num = (short)560791556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_C06;
					case 2:
					{
						bool flag;
						if (flag != radioWide.LTE.RadWideLabtoolLTEUsed_A42064.Value)
						{
							num = (short)868876293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C06;
					}
					case 3:
						return;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
						if (dataProfilesRecset == null)
						{
							num = (short)97386509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)801570830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						bool flag;
						radioWide.LTE.RadWideLabtoolLTEUsed_A42064.SetValue(flag);
						num = (short)1194418490;
						short num3 = num;
						num = (short)1313628474;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_72E;
						default:
							num = (short)1636368384;
							if (num != 0)
							{
							}
							num = (short)830537729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						return;
					case 7:
						try
						{
							num = (short)857276421;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1167523841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)100728840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1384841220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									conventionalSystem.Features.CnvSysFeaturesSendLocationToPeer_42427.CalculateApplicability();
									conventionalSystem.Features.CnvSysFeaturesSendLocationToPeer_42427.CalculateValidity();
									num = (short)1036451842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_4A1;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_37F;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
									{
										num = (short)479461379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)813301766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)885194759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_40F:
								num = (short)1272840192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_37F:
								goto IL_40F;
							}
							IL_4A1:
							goto IL_810;
						}
						finally
						{
							num = (short)812449792;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4D8;
									}
									continue;
								case 1:
									goto IL_50F;
								case 2:
									enumerator.Dispose();
									num = (short)1201799169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)453902338;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_50F:;
						}
						goto IL_512;
					case 8:
						num = (short)2021392410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)141099019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_BDB;
					case 11:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)909836298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
						num = (short)1698496537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							num = (short)2098003973;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1309343745;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
									num = (short)967573512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1226309636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									trunkingSystem.Features.TrkSysFeatureLocationOnPTT_43026.CalculateApplicability();
									trunkingSystem.Features.TrkSysFeatureLocationOnPTT_43026.CalculateValidity();
									num = (short)1896480770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2BE;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_19B;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
									{
										num = (short)2021851139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1286471686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem != null)
									{
										num = (short)913965063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_22B:
								num = (short)1747779584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19B:
								goto IL_22B;
							}
							IL_2BE:
							goto IL_7C3;
						}
						finally
						{
							num = (short)603848704;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2F6;
									}
									continue;
								case 1:
									goto IL_32F;
								case 2:
									enumerator.Dispose();
									num = (short)600506369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2F6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1972699138;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32F:;
						}
						return;
					case 13:
						return;
					case 14:
						try
						{
							num = (short)1703215113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
									{
										num = (short)1001390092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A29;
								}
								case 1:
									num = (short)896532485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
									{
										num = (short)2026897411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_A29;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfBroadbandSource_A42858.Value == 1)
									{
										num = (short)1109852168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_A90;
								case 6:
									goto IL_9D7;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3)
									{
										num = (short)1619329035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A29;
								}
								case 8:
								{
									bool flag = true;
									num = (short)321912838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_8E0;
									}
									continue;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1165426689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)906625024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)406978562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)797245447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_8E2:
								num = (short)1552875530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8E0:
								goto IL_8E2;
								IL_A29:
								num = (short)1762066436;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9D7:
							IL_A90:
							goto IL_553;
						}
						finally
						{
							num = (short)164691969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)948895746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_AC8;
									}
									continue;
								case 2:
									goto IL_B00;
								}
								IL_AC8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)740950016;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B00:;
						}
						goto IL_B03;
						IL_553:
						num = (short)608436226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_B03;
					case 16:
						enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)1373831180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateValidity();
						(dataWideRecset[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).SensorMeasurementReporting_A43021.CalculateApplicability();
						(dataWideRecset[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).SensorMeasurementReporting_A43021.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateValidity();
						num = (short)857079826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_6C3;
					case 19:
						if (conventionalSystemRecset != null)
						{
							num = (short)787349519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_810;
					case 20:
						if (dataWideRecset != null)
						{
							num = (short)199032853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_512;
					case 22:
						if (trunkingSystemRecset != null)
						{
							num = (short)241696784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C3;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					case 24:
						if (dataWideRecset.Count > 0)
						{
							num = (short)1117716497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
						if (radioWideRecset == null)
						{
							num = (short)1465843715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					case 26:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1356660745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_AF:
					if (!global::AcpCommonLib.AppInfoManager.UnpackOperation)
					{
						num = (short)1676541960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_512:
					num = (short)1052180504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72E:
					radioWide = (radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1127874560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C3:
					dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
					num = (short)1990656020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_810:
					num = (short)2026635264;
					short num4 = num;
					trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
					num = (short)959184918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B03:
					enumerator = conventionalSystemRecset.GetEnumerator();
					num = (short)798162951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C06:
					radioWide.Location.RadWideLocationSystemManagedGeofence_43042.CalculateValidity();
					conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					num = (short)1851719699;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6C3:
				return;
				IL_BDB:
				return;
			}
			}
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x009F0DAC File Offset: 0x009EEFAC
		// Note: this type is marked as 'beforefieldinit'.
		static DataProfilesRecset()
		{
			short num = (short)1752137746;
			short num2 = num;
			num = (short)1563852818;
			switch (num2 == num)
			{
			}
			num = (short)149356544;
			short num3 = num;
			num = (short)8257537;
			if (num != 0)
			{
			}
			num = (short)982319104;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset._Min = 1;
		}

		// Token: 0x04005359 RID: 21337
		public static int _MaxPool;

		// Token: 0x0400535A RID: 21338
		public static int _Max;

		// Token: 0x0400535B RID: 21339
		public int _DynMax;

		// Token: 0x0400535C RID: 21340
		public static int _Min;
	}
}
