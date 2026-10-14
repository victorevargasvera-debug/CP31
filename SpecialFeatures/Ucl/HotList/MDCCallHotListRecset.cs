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
	// Token: 0x020001C3 RID: 451
	[global::System.Serializable]
	public class MDCCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001592 RID: 5522 RVA: 0x0000392B File Offset: 0x00001B2B
		public MDCCallHotListRecset() : base(global::CommonResources.AppResources.MDC_Conventional_Hot_List)
		{
			base.Id = 2213;
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x001E50A4 File Offset: 0x001E32A4
		protected MDCCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x001E50E8 File Offset: 0x001E32E8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2037252096;
			short num2 = num;
			num = (short)1306186494;
			short num3 = num;
			num = (short)15913726;
			switch (num3 == num)
			{
			}
			num = (short)1719336960;
			if (num != 0)
			{
			}
			num = (short)59834369;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.MDCCallHotList(this);
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x001E5198 File Offset: 0x001E3398
		public override int MaxPool
		{
			get
			{
				short num = (short)1738211328;
				short num2 = num;
				num = (short)218831237;
				short num3 = num;
				num = (short)1863260549;
				switch (num3 == num)
				{
				}
				num = (short)1851064320;
				if (num != 0)
				{
				}
				num = (short)760807425;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.MDCCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x001E5244 File Offset: 0x001E3444
		public override int Max
		{
			get
			{
				short num = (short)1732247552;
				short num2 = num;
				num = (short)390241541;
				short num3 = num;
				num = (short)552180997;
				switch (num3 == num)
				{
				}
				num = (short)1257963521;
				if (num != 0)
				{
				}
				num = (short)1894318080;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.MDCCallHotListRecset._Max;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x001E52F4 File Offset: 0x001E34F4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1124466688;
				short num2 = num;
				num = (short)1207843835;
				short num3 = num;
				num = (short)811875323;
				switch (num3 == num)
				{
				}
				num = (short)343539713;
				if (num != 0)
				{
				}
				num = (short)391315456;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x001E53A0 File Offset: 0x001E35A0
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1156644864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)314179585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2D5;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CB;
									}
									continue;
								case 2:
									if (oneTouchInnerRecset != null)
									{
										num = (short)642973699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_298;
								case 4:
									num = (short)608370688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)2128412672;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_198;
												}
												continue;
											case 1:
												if (!enumerator.MoveNext())
												{
													num = (short)1803812867;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
												num = (short)1786576900;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_226;
											case 3:
												num = (short)1957363714;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1D7:
											num = (short)320798721;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_198:
											goto IL_1D7;
										}
										IL_226:
										break;
									}
									finally
									{
										num = (short)1944453122;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_295;
											case 1:
												enumerator.Dispose();
												num = (short)2001534976;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_25F;
												}
												continue;
											}
											IL_25F:
											if (enumerator == null)
											{
												break;
											}
											num = (short)2073100289;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_295:;
									}
									goto IL_298;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)805044228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset);
									num = (short)823394306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_CD:
								num = (short)296550406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CB:
								goto IL_CD;
								IL_298:
								enumerator = oneTouchInnerRecset.GetEnumerator();
								num = (short)1771962373;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D5:
							goto IL_3DD;
						}
						finally
						{
							num = (short)1454899202;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_343;
								case 1:
									enumerator2.Dispose();
									num = (short)848691200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_30D;
									}
									continue;
								}
								IL_30D:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1223294977;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_343:;
						}
						goto IL_346;
					case 1:
						IL_84:
						goto IL_346;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1248264193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DD;
					}
					goto IL_3B;
					IL_346:
					num = (short)1776812033;
					if (num != 0)
					{
					}
					num = (short)278642829;
					short num3 = num;
					num = (short)1332396173;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
					{
						num = (short)340918272;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1904738304;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_3DD:
				num = (short)1506279424;
				short num4 = num;
				return;
				IL_3B:
				base.OnFinishedAddRecord(record);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)2063400962;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x001E57E8 File Offset: 0x001E39E8
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)751763456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1568931841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset oneTouchInnerRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2D3;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CA;
									}
									continue;
								case 2:
									if (oneTouchInnerRecset != null)
									{
										num = (short)2109145091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_295;
								case 4:
									num = (short)225181696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)1280507904;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_199;
												}
												continue;
											case 1:
												if (!enumerator.MoveNext())
												{
													num = (short)1909260291;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
												num = (short)2092105732;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_225;
											case 3:
												num = (short)1268318210;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1D6:
											num = (short)355729409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_199:
											goto IL_1D6;
										}
										IL_225:
										break;
									}
									finally
									{
										num = (short)1336016898;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_292;
											case 1:
												enumerator.Dispose();
												num = (short)922222592;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_25C;
												}
												continue;
											}
											IL_25C:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1310916609;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_292:;
									}
									goto IL_295;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1057292292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									oneTouchInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset);
									num = (short)164429826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_CC:
								num = (short)998899718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CA:
								goto IL_CC;
								IL_295:
								enumerator = oneTouchInnerRecset.GetEnumerator();
								num = (short)216399877;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D3:
							goto IL_3D9;
						}
						finally
						{
							num = (short)634847234;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_341;
								case 1:
									enumerator2.Dispose();
									num = (short)945553408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_30A;
									}
									continue;
								}
								IL_30A:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1654587393;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_341:;
						}
						goto IL_344;
					case 1:
						IL_83:
						goto IL_344;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)76611585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D9;
					}
					goto IL_3A;
					IL_344:
					num = (short)1002307585;
					if (num != 0)
					{
					}
					num = (short)1458840561;
					short num3 = num;
					num = (short)244392945;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
					{
						num = (short)1138884608;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = conventionalPersonalityRecset.GetEnumerator();
						num = (short)411500544;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_3D9:
				num = (short)1110704128;
				short num4 = num;
				return;
				IL_3A:
				base.OnFinishedRemoveRecord(record);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1810366466;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x001E5C2C File Offset: 0x001E3E2C
		// Note: this type is marked as 'beforefieldinit'.
		static MDCCallHotListRecset()
		{
			short num = (short)380764160;
			short num2 = num;
			num = (short)1689485367;
			short num3 = num;
			num = (short)1320976439;
			switch (num3 == num)
			{
			}
			num = (short)712769536;
			if (num != 0)
			{
			}
			num = (short)603127809;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.MDCCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.MDCCallHotListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000B85 RID: 2949
		public static int _MaxPool;

		// Token: 0x04000B86 RID: 2950
		public static int _Max;
	}
}
