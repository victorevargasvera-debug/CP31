using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005DA RID: 1498
	[global::System.Serializable]
	public class StatusAliasTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600CED7 RID: 52951 RVA: 0x00C06D9C File Offset: 0x00C04F9C
		public StatusAliasTableInnerRecset() : base(global::CommonResources.AcgResources.ID_STATUSALIASTABLE, global::CommonResources.AcgResources.ID_STATUS_1)
		{
			this.SetValues();
		}

		// Token: 0x0600CED8 RID: 52952 RVA: 0x00C06DC0 File Offset: 0x00C04FC0
		public StatusAliasTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170067FE RID: 26622
		// (get) Token: 0x0600CED9 RID: 52953 RVA: 0x00C06DEC File Offset: 0x00C04FEC
		public override int MaxPool
		{
			get
			{
				short num = (short)930021376;
				short num2 = num;
				num = (short)1548607080;
				short num3 = num;
				num = (short)750706280;
				switch (num3 == num)
				{
				}
				num = (short)1317470209;
				if (num != 0)
				{
				}
				num = (short)2001862656;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x0600CEDA RID: 52954 RVA: 0x00C06E9C File Offset: 0x00C0509C
		// (set) Token: 0x0600CEDB RID: 52955 RVA: 0x00C06F60 File Offset: 0x00C05160
		public override int Max
		{
			get
			{
				short num = (short)1646452502;
				short num2 = num;
				num = (short)743825174;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A8;
				case 1:
					break;
				default:
				{
					num = (short)809238528;
					short num3 = num;
					break;
				}
				}
				num = (short)2077753344;
				if (num != 0)
				{
				}
				num = (short)486998017;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_A8:
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._Max;
			}
			set
			{
				short num = (short)1294663680;
				short num2 = num;
				num = (short)1932739233;
				short num3 = num;
				num = (short)797655713;
				switch (num3 == num)
				{
				}
				num = (short)1997537281;
				if (num != 0)
				{
				}
				num = (short)130220032;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x0600CEDC RID: 52956 RVA: 0x00C07010 File Offset: 0x00C05210
		public override int Min
		{
			get
			{
				short num = (short)1570635776;
				short num2 = num;
				num = (short)55420862;
				short num3 = num;
				num = (short)1606330302;
				switch (num3 == num)
				{
				}
				num = (short)262471680;
				if (num != 0)
				{
				}
				num = (short)1116733441;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._Min;
			}
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x0600CEDD RID: 52957 RVA: 0x00C070C0 File Offset: 0x00C052C0
		// (set) Token: 0x0600CEDE RID: 52958 RVA: 0x00C0716C File Offset: 0x00C0536C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)896663552;
				short num2 = num;
				num = (short)275054593;
				if (num != 0)
				{
				}
				num = (short)79302207;
				short num3 = num;
				num = (short)1819348543;
				switch (num3 == num)
				{
				}
				num = (short)919535616;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1325596672;
				short num2 = num;
				num = (short)1200187547;
				short num3 = num;
				num = (short)1104767131;
				switch (num3 == num)
				{
				}
				num = (short)1558183937;
				if (num != 0)
				{
				}
				num = (short)231276544;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x0600CEDF RID: 52959 RVA: 0x00C07218 File Offset: 0x00C05418
		public bool HasDiffs
		{
			get
			{
				short num = (short)1226047488;
				short num2 = num;
				num = (short)536729447;
				short num3 = num;
				num = (short)1175508839;
				switch (num3 == num)
				{
				}
				num = (short)2029387776;
				if (num != 0)
				{
				}
				num = (short)129433601;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x00C072C8 File Offset: 0x00C054C8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1462173696;
			short num2 = num;
			num = (short)178312497;
			short num3 = num;
			num = (short)647812401;
			switch (num3 == num)
			{
			}
			num = (short)1255079937;
			if (num != 0)
			{
			}
			num = (short)681377792;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner(this);
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x00C07378 File Offset: 0x00C05578
		internal void SetValues()
		{
			short num = (short)1557331968;
			short num2 = num;
			num = (short)1778344804;
			short num3 = num;
			num = (short)460022628;
			switch (num3 == num)
			{
			}
			num = (short)1729822721;
			if (num != 0)
			{
			}
			num = (short)721223680;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_STATUS_1;
			base.DataTransferOrder = 32;
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x00C07450 File Offset: 0x00C05650
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)288423936;
			short num2 = num;
			num = (short)1242754265;
			short num3 = num;
			num = (short)336587993;
			switch (num3 == num)
			{
			}
			num = (short)2035286017;
			if (num != 0)
			{
			}
			num = (short)1828782080;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x00C07508 File Offset: 0x00C05708
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)798359552;
			short num2 = num;
			num = (short)1241448449;
			if (num != 0)
			{
			}
			num = (short)772115003;
			short num3 = num;
			num = (short)944802363;
			switch (num3 == num)
			{
			}
			num = (short)1091960832;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x00C075BC File Offset: 0x00C057BC
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					IL_40:
					if (conventionalPersonalityRecset != null)
					{
						num2 = (short)1382285313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E8;
				case 1:
					goto IL_2C3;
				case 2:
					try
					{
						num2 = (short)1802371072;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								continue;
							case 1:
								goto IL_23F;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)2085027841;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current)[10145].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset).GetEnumerator();
								num2 = (short)685244419;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								try
								{
									num2 = (short)314376192;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_146;
											}
											continue;
										case 1:
											num2 = (short)875888644;
											num = (int)((global::System.IntPtr)num2);
											continue;
										case 2:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num2 = (short)1300234241;
												num = (int)((global::System.IntPtr)num2);
												continue;
											}
											(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator2.Current)[10146] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection).CnvPerOneTouchIndex_A19663.CalculateValidity();
											num2 = (short)589824003;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										case 4:
											goto IL_1D2;
										}
										IL_148:
										num2 = (short)1805778946;
										num = (int)((global::System.IntPtr)num2);
										continue;
										IL_146:
										goto IL_148;
									}
									IL_1D2:
									break;
								}
								finally
								{
									num2 = (short)948371456;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										switch (num)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_208;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num2 = (short)474808322;
											num = (int)((global::System.IntPtr)num2);
											continue;
										case 2:
											goto IL_23C;
										}
										IL_208:
										if (enumerator2 == null)
										{
											break;
										}
										num2 = (short)759365633;
										num = (int)((global::System.IntPtr)num2);
									}
									IL_23C:;
								}
								goto IL_23F;
							case 4:
								goto IL_257;
							}
							IL_9A:
							num2 = (short)1832255490;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_98:
							goto IL_9A;
							IL_23F:
							num2 = (short)1410400260;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_257:
						goto IL_2E8;
					}
					finally
					{
						num2 = (short)1732444160;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_28C;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num2 = (short)1257897986;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_2C0;
							}
							IL_28C:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1531379713;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2C0:;
					}
					goto IL_2C3;
				}
				goto IL_1C;
				IL_2C3:
				enumerator = conventionalPersonalityRecset.GetEnumerator();
				num2 = (short)1547108354;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E8:
				num2 = (short)1360031554;
				short num3 = num2;
				num2 = (short)895774530;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_40;
				case 1:
					goto IL_345;
				}
				break;
			}
			num2 = (short)1503920128;
			short num4 = num2;
			IL_345:
			num2 = (short)926941184;
			if (num2 != 0)
			{
			}
			num2 = (short)1041432577;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
			num2 = (short)1248133120;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600CEE5 RID: 52965 RVA: 0x00C07980 File Offset: 0x00C05B80
		// Note: this type is marked as 'beforefieldinit'.
		static StatusAliasTableInnerRecset()
		{
			short num = (short)236584960;
			short num2 = num;
			num = (short)1841316911;
			short num3 = num;
			num = (short)1438532655;
			switch (num3 == num)
			{
			}
			num = (short)1876164608;
			if (num != 0)
			{
			}
			num = (short)400097281;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset._Min = 1;
		}

		// Token: 0x04006543 RID: 25923
		public static int _MaxPool;

		// Token: 0x04006544 RID: 25924
		public static int _Max;

		// Token: 0x04006545 RID: 25925
		public int _DynMax;

		// Token: 0x04006546 RID: 25926
		public static int _Min;

		// Token: 0x04006547 RID: 25927
		public static int _DefaultRecordCount;
	}
}
