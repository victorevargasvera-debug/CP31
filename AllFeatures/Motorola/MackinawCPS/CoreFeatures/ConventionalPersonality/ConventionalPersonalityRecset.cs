using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x0200057D RID: 1405
	[global::System.Serializable]
	public class ConventionalPersonalityRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600C219 RID: 49689 RVA: 0x00B5DE34 File Offset: 0x00B5C034
		public ConventionalPersonalityRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITY, global::CommonResources.AcgResources.ID_CNVPER)
		{
			this.SetValues();
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x00B5DE58 File Offset: 0x00B5C058
		public ConventionalPersonalityRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x0600C21B RID: 49691 RVA: 0x00B5DE84 File Offset: 0x00B5C084
		public override int MaxPool
		{
			get
			{
				short num = (short)1483735041;
				if (num != 0)
				{
				}
				num = (short)1579550153;
				short num2 = num;
				num = (short)728565193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303693824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382219776;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._MaxPool;
			}
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x0600C21C RID: 49692 RVA: 0x00B5DF34 File Offset: 0x00B5C134
		// (set) Token: 0x0600C21D RID: 49693 RVA: 0x00B5DFF4 File Offset: 0x00B5C1F4
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)1114221744;
					short num2 = num;
					num = (short)1048423600;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1501560832;
						if (num != 0)
						{
						}
						break;
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Max;
				}
				num = (short)34930688;
				short num3 = num;
				num = (short)1515061249;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)623020816;
				short num2 = num;
				num = (short)1757448976;
				switch (num2 == num)
				{
				}
				num = (short)1924136960;
				short num3 = num;
				num = (short)1243152385;
				if (num != 0)
				{
				}
				num = (short)1051066368;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x0600C21E RID: 49694 RVA: 0x00B5E0A4 File Offset: 0x00B5C2A4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1645321040;
				short num2 = num;
				num = (short)1806474064;
				switch (num2 == num)
				{
				}
				num = (short)258932736;
				short num3 = num;
				num = (short)1756758017;
				if (num != 0)
				{
				}
				num = (short)976748544;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x0600C21F RID: 49695 RVA: 0x00B5E150 File Offset: 0x00B5C350
		// (set) Token: 0x0600C220 RID: 49696 RVA: 0x00B5E200 File Offset: 0x00B5C400
		public override int Min
		{
			get
			{
				short num = (short)1085074949;
				short num2 = num;
				num = (short)95284741;
				switch (num2 == num)
				{
				}
				num = (short)45678592;
				short num3 = num;
				num = (short)1597898753;
				if (num != 0)
				{
				}
				num = (short)1593114624;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Min;
			}
			set
			{
				short num = (short)1747320833;
				if (num != 0)
				{
				}
				num = (short)1324343397;
				short num2 = num;
				num = (short)2085806181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135149056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561001984;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Min = value;
			}
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x00B5E2B0 File Offset: 0x00B5C4B0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)148056285;
			short num2 = num;
			num = (short)390867165;
			switch (num2 == num)
			{
			}
			num = (short)1598685184;
			short num3 = num;
			num = (short)1418395649;
			if (num != 0)
			{
			}
			num = (short)593362944;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality(this);
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x00B5E360 File Offset: 0x00B5C560
		internal void SetValues()
		{
			int a_ = 13;
			short num = (short)959343742;
			short num2 = num;
			num = (short)638610558;
			switch (num2 == num)
			{
			}
			num = (short)364118016;
			short num3 = num;
			num = (short)482541569;
			if (num != 0)
			{
			}
			num = (short)1534459904;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2059;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ맹鏻都盿朁樃爅愇攉戋漍簏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭猯崱娳䀵崷吹䠻圽⼿ⱁ╃⩅桇ᩉ⥋㱍⍏㵑㩓㝕㑗㍙⡛❝㱟Ⅱୣࡥṧཀྵɫᩭ᥯ᵱᩳ᝵ᑷ⩹᥻౽쒏뢕ﮙ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITY;
			base.KeySeed = global::CommonResources.AcgResources.ID_CNVPER;
			base.DataTransferOrder = 44;
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x00B5E460 File Offset: 0x00B5C660
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)362180484;
			short num2 = num;
			num = (short)1248620420;
			switch (num2 == num)
			{
			}
			num = (short)2087256064;
			short num3 = num;
			num = (short)1213530112;
			if (num != 0)
			{
			}
			num = (short)1640693761;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.c(record);
			this.d(record);
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x00B5E51C File Offset: 0x00B5C71C
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)146992696;
			short num2 = num;
			num = (short)443280952;
			switch (num2 == num)
			{
			}
			num = (short)1914437632;
			short num3 = num;
			num = (short)481427457;
			if (num != 0)
			{
			}
			num = (short)585695232;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.d(record);
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x00B5E5DC File Offset: 0x00B5C7DC
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1425801216;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
			for (;;)
			{
				IL_33:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					goto IL_20C;
				case 1:
					num = (short)802160641;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1793851396;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								num = (short)2096347691;
								short num4 = num;
								num = (short)1519565355;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_19D;
								default:
									num = (short)2075000832;
									if (num != 0)
									{
									}
									num = (short)2121990146;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_19D;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)762904576;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current)[10119] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features).CnvSysFeaturesSelectCallInCallReset_A9102.CalculateValidity();
								num = (short)1151336449;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_C4;
								}
								continue;
							}
							IL_C6:
							num = (short)666435587;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C4:
							goto IL_C6;
						}
						IL_19D:
						return;
					}
					finally
					{
						num = (short)786169858;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)801898497;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_209;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1D3;
								}
								continue;
							}
							IL_1D3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2030501888;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_209:;
					}
					goto IL_20C;
				case 2:
					if (conventionalSystemRecset != null)
					{
						num = (short)165609472;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_45;
				IL_20C:
				enumerator = conventionalSystemRecset.GetEnumerator();
				num = (short)1513160705;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_45:
			conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
			num = (short)470417410;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x00B5E85C File Offset: 0x00B5CA5C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)244205004;
			short num2 = num;
			num = (short)1416447436;
			switch (num2 == num)
			{
			default:
			{
				num = (short)842334208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1683357697;
			if (num != 0)
			{
			}
			num = (short)731250688;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x00B5E90C File Offset: 0x00B5CB0C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)86179841;
			if (num != 0)
			{
			}
			num = (short)1948385280;
			short num2 = num;
			num = (short)90810018;
			short num3 = num;
			num = (short)1550821026;
			switch (num3 == num)
			{
			}
			num = (short)1389690880;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x00B5E9C0 File Offset: 0x00B5CBC0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)508362752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::AcpCommonLib.IAcpRecordset feature2;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)280297473;
						if (num != 0)
						{
						}
						num = (short)1906245632;
						short num3 = num;
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1773928465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_101;
					case 2:
						goto IL_435;
					case 3:
					{
						bool flag;
						if (!flag)
						{
							num = (short)354549769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						zoneChannelAssignmentRecset = null;
						zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
						num = (short)401211407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						feature2.CalculateValidity();
						num = (short)1867776001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (feature2 != null)
						{
							num = (short)1086914564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 6:
					{
						bool flag = true;
						num = (short)881262594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)298975246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						num = (short)870121490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)1458044944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Features.RadWideFeaturesZoneCloneEnable_43130)
						{
							num = (short)671875078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					}
					case 11:
						num = (short)1028718602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count <= 0)
						{
							goto IL_435;
						}
						num = (short)1657196134;
						short num4 = num;
						num = (short)40685158;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16C;
						default:
							num = (short)1094057984;
							if (num != 0)
							{
							}
							num = (short)1469513728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						num = (short)1954021388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return;
					case 15:
						goto IL_16C;
					case 16:
						try
						{
							num = (short)1815543808;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_276;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode != null)
									{
										num = (short)158334984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_3C4;
								case 4:
									num = (short)39845890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1172832262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119 != null)
									{
										num = (short)614465545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone != null)
									{
										num = (short)694419461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)943390727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CallConstraints();
									num = (short)1202192387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)602603524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1599995905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2F4:
								num = (short)673906698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_276:
								goto IL_2F4;
							}
							IL_3C4:
							return;
						}
						finally
						{
							num = (short)896598016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3FB;
									}
									continue;
								case 1:
									goto IL_432;
								case 2:
									enumerator.Dispose();
									num = (short)1053163521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3FB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)93388802;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_432:;
						}
						goto IL_435;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)632684555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					}
					case 18:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1622540301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					}
					}
					goto IL_7B;
					IL_101:
					num = (short)477102087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C:
					if (zoneChannelAssignmentRecset != null)
					{
						num = (short)866779144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_435:
					num = (short)545521667;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2075);
				num = (short)1571618821;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x00B5EFA4 File Offset: 0x00B5D1A4
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalPersonalityRecset()
		{
			short num = (short)1798963201;
			if (num != 0)
			{
			}
			num = (short)629669888;
			short num2 = num;
			num = (short)1311725781;
			short num3 = num;
			num = (short)207640789;
			switch (num3 == num)
			{
			}
			num = (short)354942976;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Min = 1;
		}

		// Token: 0x040060A6 RID: 24742
		public static int _MaxPool;

		// Token: 0x040060A7 RID: 24743
		public static int _Max;

		// Token: 0x040060A8 RID: 24744
		public int _DynMax;

		// Token: 0x040060A9 RID: 24745
		public static int _Min;
	}
}
