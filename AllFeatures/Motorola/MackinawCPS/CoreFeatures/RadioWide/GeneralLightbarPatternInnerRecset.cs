using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000175 RID: 373
	[global::System.Serializable]
	public class GeneralLightbarPatternInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06003581 RID: 13697 RVA: 0x00332538 File Offset: 0x00330738
		public GeneralLightbarPatternInnerRecset() : base(global::CommonResources.AcgResources.ID_RELAYPATTERN, global::CommonResources.AcgResources.ID_PATTERN)
		{
			this.SetValues();
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0033255C File Offset: 0x0033075C
		public GeneralLightbarPatternInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x00332588 File Offset: 0x00330788
		public override int MaxPool
		{
			get
			{
				short num = (short)70451200;
				short num2 = num;
				num = (short)1196346027;
				short num3 = num;
				num = (short)889637547;
				switch (num3 == num)
				{
				}
				num = (short)1676935168;
				if (num != 0)
				{
				}
				num = (short)14745601;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._MaxPool;
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x00332634 File Offset: 0x00330834
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x003326F4 File Offset: 0x003308F4
		public override int Max
		{
			get
			{
				short num = (short)882995379;
				short num2 = num;
				num = (short)1064267955;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AD;
				case 1:
					break;
				default:
				{
					num = (short)375652352;
					short num3 = num;
					break;
				}
				}
				num = (short)1020526592;
				if (num != 0)
				{
				}
				num = (short)1956249601;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._Max;
				}
				IL_AD:
				return this._DynMax;
			}
			set
			{
				short num = (short)2114387968;
				short num2 = num;
				num = (short)1586994278;
				short num3 = num;
				num = (short)67738726;
				switch (num3 == num)
				{
				}
				num = (short)749535232;
				if (num != 0)
				{
				}
				num = (short)1598226433;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x003327A4 File Offset: 0x003309A4
		public override int Min
		{
			get
			{
				short num = (short)1466564608;
				short num2 = num;
				num = (short)141892395;
				short num3 = num;
				num = (short)1731992363;
				switch (num3 == num)
				{
				}
				num = (short)1481375745;
				if (num != 0)
				{
				}
				num = (short)1944846336;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._Min;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x00332854 File Offset: 0x00330A54
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x00332904 File Offset: 0x00330B04
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1526202368;
				short num2 = num;
				num = (short)2015821825;
				if (num != 0)
				{
				}
				num = (short)1325113087;
				short num3 = num;
				num = (short)5283583;
				switch (num3 == num)
				{
				}
				num = (short)677969920;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1510342656;
				short num2 = num;
				num = (short)2075398673;
				short num3 = num;
				num = (short)1795625489;
				switch (num3 == num)
				{
				}
				num = (short)684851200;
				if (num != 0)
				{
				}
				num = (short)1683161089;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x003329B8 File Offset: 0x00330BB8
		public bool HasDiffs
		{
			get
			{
				short num = (short)325779456;
				short num2 = num;
				num = (short)1562586308;
				short num3 = num;
				num = (short)1011559620;
				switch (num3 == num)
				{
				}
				num = (short)1368457216;
				if (num != 0)
				{
				}
				num = (short)1593311233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00332A68 File Offset: 0x00330C68
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2101460543;
			short num2 = num;
			num = (short)127778367;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1469513728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1496383489;
			if (num != 0)
			{
			}
			num = (short)18743296;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner(this);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00332B18 File Offset: 0x00330D18
		internal void SetValues()
		{
			short num = (short)1089732609;
			if (num != 0)
			{
			}
			num = (short)812384256;
			short num2 = num;
			num = (short)262251111;
			short num3 = num;
			num = (short)1705222759;
			switch (num3 == num)
			{
			}
			num = (short)1068367872;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERN;
			base.KeySeed = global::CommonResources.AcgResources.ID_PATTERN;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00332BEC File Offset: 0x00330DEC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)202113025;
			if (num != 0)
			{
			}
			num = (short)1311899648;
			short num2 = num;
			num = (short)53549250;
			short num3 = num;
			num = (short)985012418;
			switch (num3 == num)
			{
			}
			num = (short)570556416;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00332CA0 File Offset: 0x00330EA0
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1557925171;
			short num2 = num;
			num = (short)1364004147;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2119434240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1219428353;
			if (num != 0)
			{
			}
			num = (short)2113601536;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00332D58 File Offset: 0x00330F58
		private void a()
		{
			short num = (short)1367670784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset8;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset4;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset5;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset6;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset7;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset9;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset10;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1553924097;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)54984707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay6_A36511.CalculateValidity();
									num = (short)1590820866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_17A;
									}
									continue;
								case 3:
									num = (short)233766916;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_207;
								}
								IL_17C:
								num = (short)1427046400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17A:
								goto IL_17C;
							}
							IL_207:
							goto IL_D38;
						}
						finally
						{
							num = (short)1723531265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)890896386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_23E;
									}
									continue;
								case 2:
									goto IL_276;
								}
								IL_23E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1030553600;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_276:;
						}
						goto IL_279;
					case 1:
						num = (short)789643265;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1615462404;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_125B;
								case 1:
									num = (short)2015363072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)845545473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay7_A36512.CalculateValidity();
									num = (short)1964310530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_11CE;
									}
									continue;
								}
								IL_120B:
								num = (short)1415184387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11CE:
								goto IL_120B;
							}
							IL_125B:
							goto IL_F1;
						}
						finally
						{
							num = (short)861995010;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_12CA;
								case 1:
									enumerator.Dispose();
									num = (short)1663631360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1293;
									}
									continue;
								}
								IL_1293:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1358823425;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12CA:;
						}
						goto IL_12CD;
					case 2:
						enumerator = (radioWideRecset[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)1617494044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						enumerator = (radioWideRecset2[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)163708929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_12CD;
					case 5:
						try
						{
							num = (short)1281425411;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E53;
								case 1:
									num = (short)1862074368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)2029518849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay1_A36506.CalculateValidity();
									num = (short)995295236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_DC4;
									}
									continue;
								}
								IL_DC6:
								num = (short)1029177346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DC4:
								goto IL_DC6;
							}
							IL_E53:
							goto IL_1106;
						}
						finally
						{
							num = (short)2066415618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_EC2;
								case 1:
									enumerator.Dispose();
									num = (short)1856700416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E8C;
									}
									continue;
								}
								IL_E8C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1774125057;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EC2:;
						}
						goto IL_EC5;
					case 6:
						if (radioWideRecset3 != null)
						{
							num = (short)158072847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F04;
					case 7:
						if (radioWideRecset4 != null)
						{
							num = (short)47054874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						enumerator = (radioWideRecset5[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)484573193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)1912537091;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6AE;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)221970436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay9_A36515.CalculateValidity();
									num = (short)2066546690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_61F;
									}
									continue;
								case 4:
									num = (short)1463877632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_65D:
								num = (short)765657089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_61F:
								goto IL_65D;
							}
							IL_6AE:
							goto IL_343;
						}
						finally
						{
							num = (short)1641021441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)62586882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6E6;
									}
									continue;
								case 2:
									goto IL_71C;
								}
								IL_6E6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)834338816;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_71C:;
						}
						goto Block_10;
					case 10:
						if (radioWideRecset != null)
						{
							num = (short)1761411074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 11:
						goto IL_71F;
					case 12:
						if (radioWideRecset5 != null)
						{
							num = (short)1035599880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					case 13:
						goto IL_C03;
					case 14:
						if (radioWideRecset2 != null)
						{
							num = (short)1203175427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					case 15:
						goto IL_858;
					case 16:
						if (radioWideRecset6 != null)
						{
							num = (short)87097348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A78;
					case 17:
						if (radioWideRecset7 != null)
						{
							num = (short)2080374808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_597;
					case 18:
						try
						{
							num = (short)589827;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_459;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1425211396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay3_A36508.CalculateValidity();
									num = (short)1539768322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3CB;
									}
									continue;
								case 4:
									num = (short)958267392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_409:
								num = (short)1647509505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3CB:
								goto IL_409;
							}
							IL_459:
							goto IL_597;
						}
						finally
						{
							num = (short)1510735873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2061500418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_491;
									}
									continue;
								case 2:
									goto IL_4C6;
								}
								IL_491:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1716256768;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4C6:;
						}
						goto IL_4C9;
					case 19:
						try
						{
							num = (short)393478147;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_A06;
								case 1:
									num = (short)1933049856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)474152961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay2_A36507.CalculateValidity();
									num = (short)1650393092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_979;
									}
									continue;
								}
								IL_97B:
								num = (short)560922626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_979:
								goto IL_97B;
							}
							IL_A06:
							goto IL_279;
						}
						finally
						{
							num = (short)1595604993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)344850434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A3D;
									}
									continue;
								case 2:
									goto IL_A75;
								}
								IL_A3D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1150091264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A75:;
						}
						goto IL_A78;
					case 20:
						if (radioWideRecset8 != null)
						{
							num = (short)1990393881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1106;
					case 21:
					{
						num = (short)1552089088;
						short num3 = num;
						if (radioWideRecset9 != null)
						{
							num = (short)1332215837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D38;
					}
					case 22:
						try
						{
							num = (short)1358692356;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1044;
								case 1:
									num = (short)1434189824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)730529793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay10_A36516.CalculateValidity();
									num = (short)811466754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_FB7;
									}
									continue;
								}
								IL_FF4:
								num = (short)490143747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FB7:
								goto IL_FF4;
							}
							IL_1044:
							return;
						}
						finally
						{
							num = (short)1912406018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)2125195324;
								short num4 = num;
								num = (short)344057916;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)657915904;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_1103;
									case 1:
										goto IL_10E3;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_10CA;
										}
										continue;
									}
									IL_10CA:
									if (enumerator != null)
									{
										num = (short)200867841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1105;
								}
								IL_10E3:
								enumerator.Dispose();
								num = (short)2134114304;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1103:
							IL_1105:;
						}
						goto IL_1106;
					case 23:
						enumerator = (radioWideRecset10[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)1151402003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						enumerator = (radioWideRecset7[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)1835925522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						enumerator = (radioWideRecset8[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)1149370373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						enumerator = (radioWideRecset4[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
						num = (short)734855190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (radioWideRecset10 != null)
						{
							num = (short)851050519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 28:
						try
						{
							num = (short)1877868547;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B91;
								case 1:
									num = (short)1919418368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1633091585;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay4_A36509.CalculateValidity();
									num = (short)231997444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_B03;
									}
									continue;
								}
								IL_B05:
								num = (short)546242562;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B03:
								goto IL_B05;
							}
							IL_B91:
							goto IL_4C9;
						}
						finally
						{
							num = (short)1631584257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)32374786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BC9;
									}
									continue;
								case 2:
									goto IL_C00;
								}
								IL_BC9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1639579648;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C00:;
						}
						goto Block_14;
					case 29:
						goto IL_EC5;
					}
					goto IL_A6;
					IL_F1:
					radioWideRecset6 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)158597136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					radioWideRecset7 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)220266513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					radioWideRecset4 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)1763377159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C9:
					radioWideRecset3 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)626262022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_597:
					radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)995819530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_858:
					enumerator = (radioWideRecset3[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
					num = (short)81920013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_10:
					try
					{
						IL_71F:
						num = (short)1153040387;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_7E9;
							case 1:
								num = (short)22609920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1941831681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay8_A36513.CalculateValidity();
								num = (short)479330308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_75A;
								}
								continue;
							}
							IL_75C:
							num = (short)1552875522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_75A:
							goto IL_75C;
						}
						IL_7E9:
						goto IL_A78;
					}
					finally
					{
						num = (short)508166145;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)2125856770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_820;
								}
								continue;
							case 2:
								goto IL_855;
							}
							IL_820:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1837498368;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_855:;
					}
					goto IL_858;
					IL_A78:
					radioWideRecset5 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)534577164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D38:
					radioWideRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)460718094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_14:
					try
					{
						IL_C03:
						num = (short)746717187;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_CC9;
							case 1:
								num = (short)38535168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1314652161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)enumerator.Current)[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay5_A36510.CalculateValidity();
								num = (short)1456734212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C3D;
								}
								continue;
							}
							IL_C3F:
							num = (short)1873870850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C3D:
							goto IL_C3F;
						}
						IL_CC9:
						goto IL_F04;
					}
					finally
					{
						num = (short)1586298881;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)428605442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D00;
								}
								continue;
							case 2:
								goto IL_D35;
							}
							IL_D00:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2090467328;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_D35:;
					}
					goto IL_D38;
					IL_EC5:
					enumerator = (radioWideRecset9[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
					num = (short)1582104576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F04:
					radioWideRecset9 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)1246035989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1106:
					radioWideRecset10 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)2359323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12CD:
					enumerator = (radioWideRecset6[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset).GetEnumerator();
					num = (short)829554699;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A6:
				radioWideRecset8 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				num = (short)829620244;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x003340F0 File Offset: 0x003322F0
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralLightbarPatternInnerRecset()
		{
			short num = (short)1180512775;
			short num2 = num;
			num = (short)95891975;
			switch (num2 == num)
			{
			}
			num = (short)319619072;
			if (num != 0)
			{
			}
			num = (short)1834876929;
			if (num != 0)
			{
			}
			num = (short)707526656;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset._Min = 1;
		}

		// Token: 0x040011AD RID: 4525
		public static int _MaxPool;

		// Token: 0x040011AE RID: 4526
		public static int _Max;

		// Token: 0x040011AF RID: 4527
		public int _DynMax;

		// Token: 0x040011B0 RID: 4528
		public static int _Min;

		// Token: 0x040011B1 RID: 4529
		public static int _DefaultRecordCount;
	}
}
