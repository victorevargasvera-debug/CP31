using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001BC RID: 444
	[global::System.Serializable]
	public class AstroCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x000038D3 File Offset: 0x00001AD3
		public AstroCallHotListRecset() : base(global::CommonResources.AppResources.ASTRO_Conventional_Hot_List)
		{
			base.Id = 2211;
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x001E00AC File Offset: 0x001DE2AC
		protected AstroCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("憐ﲑ秊", a_));
			}
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x001E00F0 File Offset: 0x001DE2F0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)785784686;
			short num2 = num;
			num = (short)2120818542;
			switch (num2 == num)
			{
			}
			num = (short)864747521;
			if (num != 0)
			{
			}
			num = (short)498597888;
			if (num != 0)
			{
			}
			num = (short)494993408;
			short num3 = num;
			return new global::SpecialFeatures.Ucl.HotList.AstroCallHotList(this);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x001E01A0 File Offset: 0x001DE3A0
		public override int MaxPool
		{
			get
			{
				short num = (short)1681215715;
				short num2 = num;
				num = (short)1682395363;
				switch (num2 == num)
				{
				}
				num = (short)368771073;
				if (num != 0)
				{
				}
				num = (short)2059010048;
				if (num != 0)
				{
				}
				num = (short)788267008;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x001E024C File Offset: 0x001DE44C
		public override int Max
		{
			get
			{
				short num = (short)237599153;
				short num2 = num;
				num = (short)63797681;
				switch (num2 == num)
				{
				}
				num = (short)1362952192;
				if (num != 0)
				{
				}
				num = (short)696844289;
				if (num != 0)
				{
				}
				num = (short)1388118016;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset._Max;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x001E02FC File Offset: 0x001DE4FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1380122625;
				if (num != 0)
				{
				}
				num = (short)1002260371;
				short num2 = num;
				num = (short)1992771475;
				switch (num2 == num)
				{
				}
				num = (short)753860608;
				if (num != 0)
				{
				}
				num = (short)1968046080;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x001E03AC File Offset: 0x001DE5AC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)564854784;
			short num2 = num;
			num = (short)15794176;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_50:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num3)
					{
					case 0:
						goto IL_3E9;
					case 1:
						num = (short)162398209;
						if (num != 0)
						{
						}
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1238695936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)382402565;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset;
								switch (num3)
								{
								case 0:
									goto IL_378;
								case 1:
									try
									{
										num = (short)1432092675;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												goto IL_27B;
											case 1:
												if (!enumerator.MoveNext())
												{
													num = (short)1602682884;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
												num = (short)800587778;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_1EA;
												}
												continue;
											case 4:
												num = (short)300154880;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_228:
											num = (short)1920991233;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_1EA:
											goto IL_228;
										}
										IL_27B:
										break;
									}
									finally
									{
										num = (short)223805441;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												goto IL_2CF;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_2B2;
												}
												continue;
											case 2:
											{
												num = (short)1336860259;
												short num4 = num;
												num = (short)955506275;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2CF;
												default:
													goto IL_322;
												}
												break;
											}
											}
											IL_2B2:
											if (enumerator != null)
											{
												num = (short)777781248;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_339;
											IL_2CF:
											enumerator.Dispose();
											num = (short)1989214210;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_322:
										num = (short)1391656960;
										if (num != 0)
										{
										}
										IL_339:;
									}
									goto IL_33A;
								case 2:
									if (!enumerator2.MoveNext())
									{
										num = (short)1601437699;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset);
									num = (short)1744240644;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)708444160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (oneTouchInnerRecset != null)
									{
										num = (short)1927217158;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 6:
									goto IL_33A;
								}
								IL_11E:
								num = (short)309198850;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C:
								goto IL_11E;
								IL_33A:
								enumerator = oneTouchInnerRecset.GetEnumerator();
								num = (short)1322057729;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_378:
							return;
						}
						finally
						{
							num = (short)177799169;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)836173826;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3AF;
									}
									continue;
								case 2:
									goto IL_3E6;
								}
								IL_3AF:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1502281728;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3E6:;
						}
						goto IL_3E9;
					}
					goto IL_63;
					IL_3E9:
					enumerator2 = conventionalPersonalityRecset.GetEnumerator();
					num = (short)1027276802;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_63:
				base.OnFinishedAddRecord(record);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1358036993;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x001E07FC File Offset: 0x001DE9FC
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)217513984;
			short num2 = num;
			num = (short)587661312;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)1955397633;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_78:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num3)
					{
					case 0:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1985347586;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)727384068;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset;
								switch (num3)
								{
								case 0:
									try
									{
										num = (short)39780354;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												num = (short)42598403;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1EA;
												}
												continue;
											case 3:
												goto IL_27A;
											case 4:
												if (!enumerator.MoveNext())
												{
													num = (short)2060058624;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
												num = (short)104529921;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_228:
											num = (short)1006174212;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_1EA:
											goto IL_228;
										}
										IL_27A:
										break;
									}
									finally
									{
										num = (short)1382809600;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_2B2;
												}
												continue;
											case 1:
											{
												num = (short)985897429;
												short num4 = num;
												num = (short)1408932309;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_2D1;
												default:
													goto IL_323;
												}
												break;
											}
											case 2:
												goto IL_2D1;
											}
											IL_2B2:
											if (enumerator != null)
											{
												num = (short)1043333122;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_33A;
											IL_2D1:
											enumerator.Dispose();
											num = (short)2097741825;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_323:
										num = (short)1889796096;
										if (num != 0)
										{
										}
										IL_33A:;
									}
									goto IL_33B;
								case 1:
									goto IL_33B;
								case 2:
									if (!enumerator2.MoveNext())
									{
										num = (short)1898905603;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset);
									num = (short)459669510;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)195231749;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 5:
									goto IL_378;
								case 6:
									if (oneTouchInnerRecset != null)
									{
										num = (short)1086783489;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_11E:
								num = (short)205651970;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C:
								goto IL_11E;
								IL_33B:
								enumerator = oneTouchInnerRecset.GetEnumerator();
								num = (short)1112276992;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_378:
							return;
						}
						finally
						{
							num = (short)354353152;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3AF;
									}
									continue;
								case 1:
									goto IL_3E6;
								case 2:
									enumerator2.Dispose();
									num = (short)167903233;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3AF:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2005925890;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3E6:;
						}
						goto IL_3E9;
					case 2:
						goto IL_3E9;
					}
					goto IL_8B;
					IL_3E9:
					enumerator2 = conventionalPersonalityRecset.GetEnumerator();
					num = (short)819986433;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8B:
				base.OnFinishedRemoveRecord(record);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1631584256;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_78;
			}
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x001E0C4C File Offset: 0x001DEE4C
		// Note: this type is marked as 'beforefieldinit'.
		static AstroCallHotListRecset()
		{
			short num = (short)490844763;
			short num2 = num;
			num = (short)1717416539;
			switch (num2 == num)
			{
			}
			num = (short)312147969;
			if (num != 0)
			{
			}
			num = (short)1703739392;
			short num3 = num;
			num = (short)2144403456;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000B7E RID: 2942
		public static int _MaxPool;

		// Token: 0x04000B7F RID: 2943
		public static int _Max;
	}
}
