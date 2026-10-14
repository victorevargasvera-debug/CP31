using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C6 RID: 454
	[global::System.Serializable]
	public class PhoneCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060015CA RID: 5578 RVA: 0x00003957 File Offset: 0x00001B57
		public PhoneCallHotListRecset() : base(global::CommonResources.AppResources.Phone_Call_Hot_List)
		{
			base.Id = 2221;
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x001E81E8 File Offset: 0x001E63E8
		protected PhoneCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮑ望", a_));
			}
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x001E822C File Offset: 0x001E642C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)767162781;
			short num2 = num;
			num = (short)967178653;
			switch (num2 == num)
			{
			}
			num = (short)650182656;
			if (num != 0)
			{
			}
			num = (short)747896833;
			if (num != 0)
			{
			}
			num = (short)611123200;
			short num3 = num;
			return new global::SpecialFeatures.Ucl.HotList.PhoneCallHotList(this);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x001E82DC File Offset: 0x001E64DC
		public override int MaxPool
		{
			get
			{
				short num = (short)1097130331;
				short num2 = num;
				num = (short)1587929435;
				switch (num2 == num)
				{
				}
				num = (short)1613889537;
				if (num != 0)
				{
				}
				num = (short)1619394560;
				if (num != 0)
				{
				}
				num = (short)1677066240;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x001E8388 File Offset: 0x001E6588
		public override int Max
		{
			get
			{
				short num = (short)813860104;
				short num2 = num;
				num = (short)1267827976;
				switch (num2 == num)
				{
				}
				num = (short)898629632;
				if (num != 0)
				{
				}
				num = (short)1478492161;
				if (num != 0)
				{
				}
				num = (short)258015232;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset._Max;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x001E8438 File Offset: 0x001E6638
		public bool HasDiffs
		{
			get
			{
				short num = (short)239277015;
				short num2 = num;
				num = (short)1136661463;
				switch (num2 == num)
				{
				}
				num = (short)926154753;
				if (num != 0)
				{
				}
				num = (short)2115174400;
				if (num != 0)
				{
				}
				num = (short)989921280;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x001E84E8 File Offset: 0x001E66E8
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)2013921280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)763363334;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset oneTouchInnerRecset;
								switch (num2)
								{
								case 0:
									enumerator = oneTouchInnerRecset.GetEnumerator();
									num = (short)1573126146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3AB;
								case 2:
									try
									{
										num = (short)1010565124;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_269;
											case 1:
												num = (short)2136473600;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (!enumerator.MoveNext())
												{
													num = (short)489422849;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)enumerator.Current)[10166] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection).TrkSysOneTouchIndex_A8618.CalculateValidity();
												num = (short)1146093571;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_1DA;
												}
												continue;
											}
											IL_218:
											num = (short)265486338;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1DA:
											goto IL_218;
										}
										IL_269:
										break;
									}
									finally
									{
										num = (short)165347330;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)134086657;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_2DA;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_2A0;
												}
												continue;
											}
											IL_2A0:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1414397952;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2DA:;
									}
									goto IL_2DD;
								case 3:
									if (!enumerator2.MoveNext())
									{
										num = (short)2123694084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DD;
								case 4:
									num = (short)982581249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (oneTouchInnerRecset != null)
									{
										num = (short)1507131392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_19A;
									}
									continue;
								}
								goto IL_19A;
								IL_2DD:
								oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator2.Current)[10165].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset);
								num = (short)376504325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_333:
								num = (short)38010883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19A:
								goto IL_333;
							}
							IL_3AB:
							goto IL_E1;
						}
						finally
						{
							num = (short)1407713282;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)441974785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_41A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3E2;
									}
									continue;
								}
								IL_3E2:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1627258880;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_41A:;
						}
						goto IL_41D;
					case 1:
					{
						num = (short)292093952;
						short num3 = num;
						enumerator2 = conventionalPersonalityRecset.GetEnumerator();
						num = (short)400031746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_DC;
					case 3:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1529610241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)743440385;
						if (num != 0)
						{
						}
						goto IL_41D;
					case 5:
						if (trunkingSystemRecset != null)
						{
							num = (short)163840004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1;
					}
					goto IL_47;
					IL_E1:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)211812355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41D:
					enumerator2 = trunkingSystemRecset.GetEnumerator();
					num = (short)1978007552;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DC:
				try
				{
					num = (short)1695350790;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2;
							enumerator = oneTouchInnerRecset2.GetEnumerator();
							num = (short)553123843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_6DE;
						case 2:
							goto IL_6C6;
						case 3:
							try
							{
								num = (short)1631780866;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_654;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5C5;
										}
										continue;
									case 3:
										num = (short)762314753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = (short)1901133827;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
										num = (short)143261696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_603:
									num = (short)1074921476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5C5:
									goto IL_603;
								}
								IL_654:
								break;
							}
							finally
							{
								num = (short)17760256;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_68C;
										}
										continue;
									case 1:
										goto IL_6C3;
									case 2:
										enumerator.Dispose();
										num = (short)2056454145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_68C:
									if (enumerator == null)
									{
										break;
									}
									num = (short)620691458;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6C3:;
							}
							goto IL_6C6;
						case 4:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1178664962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2 = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset;
							num = (short)1251934213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2;
							if (oneTouchInnerRecset2 != null)
							{
								num = (short)745275392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_484;
							}
							continue;
						}
						IL_4FF:
						num = (short)1434838566;
						short num4 = num;
						num = (short)610592294;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6DE;
						default:
							num = (short)1337262080;
							if (num != 0)
							{
							}
							num = (short)1698758660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_484:
						goto IL_4FF;
						IL_6C6:
						num = (short)2026438657;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6DE:;
				}
				finally
				{
					num = (short)1185546240;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_712;
							}
							continue;
						case 1:
							goto IL_748;
						case 2:
							enumerator2.Dispose();
							num = (short)182452225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_712:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)1819541506;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_748:;
				}
				return;
				IL_47:
				base.OnFinishedAddRecord(record);
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)2022965253;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x001E8CA4 File Offset: 0x001E6EA4
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1414463488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)732954628;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset oneTouchInnerRecset;
								switch (num2)
								{
								case 0:
									if (oneTouchInnerRecset != null)
									{
										num = (short)1337655298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_3AD;
								case 2:
									enumerator = oneTouchInnerRecset.GetEnumerator();
									num = (short)511508485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1437663233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_197;
									}
									continue;
								case 5:
									try
									{
										num = (short)1675165698;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												goto IL_268;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1D6;
												}
												continue;
											case 3:
												num = (short)149422081;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												if (!enumerator.MoveNext())
												{
													num = (short)2006646787;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)enumerator.Current)[10166] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection).TrkSysOneTouchIndex_A8618.CalculateValidity();
												num = (short)1742929920;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_214:
											num = (short)960823300;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1D6:
											goto IL_214;
										}
										IL_268:
										break;
									}
									finally
									{
										num = (short)350158848;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_2A0;
												}
												continue;
											case 1:
												goto IL_2D9;
											case 2:
												enumerator.Dispose();
												num = (short)1435631617;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2A0:
											if (enumerator == null)
											{
												break;
											}
											num = (short)86507522;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2D9:;
									}
									goto IL_2DC;
								case 6:
									if (!enumerator2.MoveNext())
									{
										num = (short)829030403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DC;
								}
								goto IL_197;
								IL_2DC:
								oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator2.Current)[10165].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset);
								num = (short)649789440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_332:
								num = (short)1538523142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_197:
								goto IL_332;
							}
							IL_3AD:
							goto IL_E0;
						}
						finally
						{
							num = (short)1938948096;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3E4;
									}
									continue;
								case 1:
									goto IL_41A;
								case 2:
									enumerator2.Dispose();
									num = (short)282853377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3E4:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1892155394;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_41A:;
						}
						goto IL_41D;
					case 1:
						goto IL_41D;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1427111940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (trunkingSystemRecset != null)
						{
							num = (short)508362753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 4:
					{
						num = (short)2004615168;
						short num3 = num;
						enumerator2 = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1577254913;
						if (num != 0)
						{
						}
						num = (short)1055719429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_DB;
					}
					goto IL_47;
					IL_E0:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1053097986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41D:
					enumerator2 = trunkingSystemRecset.GetEnumerator();
					num = (short)127533056;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DB:
				try
				{
					num = (short)206700548;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2;
							if (oneTouchInnerRecset2 != null)
							{
								num = (short)541589506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_6DF;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2;
							enumerator = oneTouchInnerRecset2.GetEnumerator();
							num = (short)179109894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1040384005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset2 = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset;
							num = (short)343998464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_483;
							}
							continue;
						case 5:
							goto IL_6C7;
						case 6:
							try
							{
								num = (short)1100742658;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_654;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5C4;
										}
										continue;
									case 3:
										num = (short)1799421953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = (short)82903043;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
										num = (short)417136640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_602:
									num = (short)718864388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5C4:
									goto IL_602;
								}
								IL_654:
								break;
							}
							finally
							{
								num = (short)1451098112;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_68D;
										}
										continue;
									case 1:
										goto IL_6C4;
									case 2:
										enumerator.Dispose();
										num = (short)1622278145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_68D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)2017591298;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6C4:;
							}
							goto IL_6C7;
						}
						IL_4FD:
						num = (short)1566419113;
						short num4 = num;
						num = (short)818129065;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6DF;
						default:
							num = (short)1062862848;
							if (num != 0)
							{
							}
							num = (short)1784479747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_483:
						goto IL_4FD;
						IL_6C7:
						num = (short)573767681;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6DF:;
				}
				finally
				{
					num = (short)1556348928;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_713;
							}
							continue;
						case 1:
							goto IL_748;
						case 2:
							enumerator2.Dispose();
							num = (short)648347649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_713:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)1487339522;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_748:;
				}
				return;
				IL_47:
				base.OnFinishedRemoveRecord(record);
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)1574240259;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x001E9460 File Offset: 0x001E7660
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallHotListRecset()
		{
			short num = (short)934294774;
			short num2 = num;
			num = (short)1837315318;
			switch (num2 == num)
			{
			}
			num = (short)844824576;
			short num3 = num;
			num = (short)1048182785;
			if (num != 0)
			{
			}
			num = (short)1656553472;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000B89 RID: 2953
		public static int _MaxPool;

		// Token: 0x04000B8A RID: 2954
		public static int _Max;
	}
}
