using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000212 RID: 530
	[global::System.Serializable]
	public class UclContactRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001B14 RID: 6932 RVA: 0x00003DDE File Offset: 0x00001FDE
		public UclContactRecset() : base(global::CommonResources.AppResources.Unified_Call_List, false, true, true, global::CommonResources.AppResources.Contact_Id)
		{
			this.a();
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0022F598 File Offset: 0x0022D798
		protected UclContactRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺏﮓ", a_));
			}
			this.a();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0022F5D8 File Offset: 0x0022D7D8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)409007804;
			short num2 = num;
			num = (short)1976563388;
			switch (num2 == num)
			{
			default:
			{
				num = (short)809566208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2022834177;
			if (num != 0)
			{
			}
			num = (short)650903552;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.UclContact(this);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0022F688 File Offset: 0x0022D888
		private void a()
		{
			int a_ = 2;
			short num = (short)1549699182;
			short num2 = num;
			num = (short)626886766;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1482620928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)805699585;
			if (num != 0)
			{
			}
			num = (short)706215936;
			if (num != 0)
			{
			}
			base.Id = 2200;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄﶐햒爵튠颢좦쒨\udbaa슬솮풰\uddb2솴颶視\udaba톼펾迂계듆뷈軌ꃎ뿐뗒볔냖곘꧚볜ꯞ裠賢诤죦ꫨ蓪菬鯮郰郲致\ud8f6곸飺釼볾渀洂焄昆樈缊崌渎瘐瘒䄔甖甘䴚琜稞嘠ഢ崤䘦䐨䜪", a_);
			base.UIName = global::CommonResources.AppResources.Unified_Call_List;
			base.DataTransferOrder = 100;
			base.HideRecordsFromTree = true;
			base.KeySeed = global::CommonResources.AppResources.Contact_Id;
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0022F780 File Offset: 0x0022D980
		public override int MaxPool
		{
			get
			{
				short num = (short)297171235;
				short num2 = num;
				num = (short)1157462307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958084608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970798593;
				if (num != 0)
				{
				}
				num = (short)1061093376;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.UclContactRecset._MaxPool;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0022F82C File Offset: 0x0022DA2C
		public override int Max
		{
			get
			{
				short num = (short)223254527;
				short num2 = num;
				num = (short)1064409087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96403456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1639907328;
				if (num != 0)
				{
				}
				num = (short)1089732609;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.UclContactRecset._Max;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0022F8DC File Offset: 0x0022DADC
		public override int CounterToMax
		{
			get
			{
				short num = (short)882900993;
				if (num != 0)
				{
				}
				num = (short)839516160;
				short num2 = num;
				num = (short)1746316151;
				short num3 = num;
				num = (short)2141105015;
				switch (num3 == num)
				{
				}
				num = (short)861601792;
				if (num != 0)
				{
				}
				return this.Max - base.Count;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0022F994 File Offset: 0x0022DB94
		public bool HasDiffs
		{
			get
			{
				short num = (short)1909998187;
				short num2 = num;
				num = (short)2076263019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399769600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651703809;
				if (num != 0)
				{
				}
				num = (short)755302400;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0022FA48 File Offset: 0x0022DC48
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)375073248;
			short num2 = num;
			num = (short)1470638560;
			switch (num2 == num)
			{
			default:
			{
				num = (short)768802816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1570308096;
			if (num != 0)
			{
			}
			num = (short)1591607297;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0022FAF8 File Offset: 0x0022DCF8
		public override string GenerateKeyValue(global::AcpBusinessLayer.FeatureNode node)
		{
			int a_ = 2;
			short num = (short)443351702;
			short num2 = num;
			num = (short)555287190;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1218641920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1034027009;
			if (num != 0)
			{
			}
			num = (short)343539712;
			if (num != 0)
			{
			}
			string keySeed = base.KeySeed;
			string str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖄ", a_);
			int lastId = this.lastId + 1;
			this.lastId = lastId;
			return keySeed + str + lastId.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솄늆", a_));
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0022FBE8 File Offset: 0x0022DDE8
		internal bool ReachedMaxContactsHotlisted
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				int num2;
				short num3;
				int num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_CE;
					case 1:
						goto IL_147;
					case 2:
						if (num2 >= base.Count)
						{
							num3 = (short)283574275;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)406126599;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 3:
						return false;
					case 4:
					{
						num3 = (short)1781792768;
						short num4 = num3;
						if (num5 == 2000)
						{
							num3 = (short)702676992;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num2++;
						num3 = (short)829882369;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 5:
					{
						num3 = (short)1485448397;
						short num6 = num3;
						num3 = (short)728900813;
						switch ((num6 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_184;
						default:
							num3 = (short)1832255488;
							if (num3 != 0)
							{
							}
							goto IL_6F;
						}
						break;
					}
					case 6:
						num5++;
						goto IL_184;
					case 7:
						if (((global::AcpBusinessLayer.FeatureNode)base[num2]).KeyField.IsReferenced)
						{
							num3 = (short)1094254598;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_6F;
					case 8:
						goto IL_147;
					}
					goto IL_34;
					IL_6F:
					num3 = (short)1973813252;
					num = (int)((global::System.IntPtr)num3);
					continue;
					IL_147:
					num3 = (short)1769799682;
					num = (int)((global::System.IntPtr)num3);
					continue;
					IL_184:
					num3 = (short)727908357;
					num = (int)((global::System.IntPtr)num3);
				}
				IL_CE:
				num3 = (short)1218183169;
				if (num3 != 0)
				{
				}
				return true;
				IL_34:
				num5 = 0;
				num2 = 0;
				num3 = (short)1907032072;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0022FDE4 File Offset: 0x0022DFE4
		protected override void Dispose(bool disposing)
		{
			short num = (short)893598356;
			short num2 = num;
			num = (short)2036873876;
			switch (num2 == num)
			{
			default:
			{
				num = (short)25034752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)589234177;
			if (num != 0)
			{
			}
			num = (short)1780350976;
			if (num != 0)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0022FE94 File Offset: 0x0022E094
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)98815097;
				short num2 = num;
				num = (short)1675480185;
				switch (num2 == num)
				{
				}
				num = (short)1986265088;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1981218817;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1180958720;
			short num3 = num;
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0022FF60 File Offset: 0x0022E160
		// Note: this type is marked as 'beforefieldinit'.
		static UclContactRecset()
		{
			short num = (short)309767510;
			short num2 = num;
			num = (short)1580510550;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1648099328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1132331009;
			if (num != 0)
			{
			}
			num = (short)1090060288;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.UclContactRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset._Max = int.MaxValue;
		}

		// Token: 0x04000CCA RID: 3274
		public static int _MaxPool;

		// Token: 0x04000CCB RID: 3275
		public static int _Max;
	}
}
