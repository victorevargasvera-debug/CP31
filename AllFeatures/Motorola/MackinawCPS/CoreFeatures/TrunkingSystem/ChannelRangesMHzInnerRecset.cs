using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006A RID: 106
	[global::System.Serializable]
	public class ChannelRangesMHzInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x0009B610 File Offset: 0x00099810
		public ChannelRangesMHzInnerRecset() : base(global::CommonResources.AcgResources.ID_CHANNELRANGESMHZ, global::CommonResources.AcgResources.ID_RANGE)
		{
			this.SetValues();
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0009B634 File Offset: 0x00099834
		public ChannelRangesMHzInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0009B660 File Offset: 0x00099860
		public override int MaxPool
		{
			get
			{
				short num = (short)438388093;
				short num2 = num;
				num = (short)2117485949;
				switch (num2 == num)
				{
				}
				num = (short)2092040193;
				if (num != 0)
				{
				}
				num = (short)236453888;
				short num3 = num;
				num = (short)311558144;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0009B710 File Offset: 0x00099910
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0009B7D0 File Offset: 0x000999D0
		public override int Max
		{
			get
			{
				short num = (short)2144206848;
				short num2 = num;
				if (this._DynMax == -1)
				{
					num = (short)37813050;
					short num3 = num;
					num = (short)904985402;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1444413441;
						if (num != 0)
						{
						}
						num = (short)799014912;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)875167745;
				if (num != 0)
				{
				}
				num = (short)1637858712;
				short num2 = num;
				num = (short)1763425688;
				switch (num2 == num)
				{
				}
				num = (short)1999634432;
				short num3 = num;
				num = (short)1743388672;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0009B884 File Offset: 0x00099A84
		public override int Min
		{
			get
			{
				short num = (short)662951208;
				short num2 = num;
				num = (short)196597032;
				switch (num2 == num)
				{
				}
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)1691090944;
				short num3 = num;
				num = (short)1075314688;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._Min;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0009B934 File Offset: 0x00099B34
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0009B9E4 File Offset: 0x00099BE4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)383611848;
				short num2 = num;
				num = (short)1413510088;
				switch (num2 == num)
				{
				}
				num = (short)1185546241;
				if (num != 0)
				{
				}
				num = (short)872611840;
				short num3 = num;
				num = (short)1669791744;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)381249600;
				short num2 = num;
				num = (short)1875208256;
				switch (num2 == num)
				{
				}
				num = (short)661979137;
				if (num != 0)
				{
				}
				num = (short)1974206464;
				short num3 = num;
				num = (short)1560936448;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0009BA94 File Offset: 0x00099C94
		public bool HasDiffs
		{
			get
			{
				short num = (short)1063319684;
				short num2 = num;
				num = (short)480049284;
				switch (num2 == num)
				{
				}
				num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)679804928;
				short num3 = num;
				num = (short)121962496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0009BB44 File Offset: 0x00099D44
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)835533325;
			short num2 = num;
			num = (short)794507789;
			switch (num2 == num)
			{
			}
			num = (short)1279655937;
			if (num != 0)
			{
			}
			num = (short)1575550976;
			short num3 = num;
			num = (short)793706496;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner(this);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0009BBF4 File Offset: 0x00099DF4
		internal void SetValues()
		{
			short num = (short)1137237026;
			short num2 = num;
			num = (short)1980423202;
			switch (num2 == num)
			{
			}
			num = (short)1458765825;
			if (num != 0)
			{
			}
			num = (short)1438711808;
			short num3 = num;
			num = (short)1346699264;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELRANGESMHZ;
			base.KeySeed = global::CommonResources.AcgResources.ID_RANGE;
			base.DataTransferOrder = 43;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0009BCC8 File Offset: 0x00099EC8
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1357681568;
			short num2 = num;
			num = (short)834442144;
			switch (num2 == num)
			{
			}
			num = (short)830734337;
			if (num != 0)
			{
			}
			num = (short)1907163136;
			short num3 = num;
			num = (short)259129344;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.b(record);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0009BD7C File Offset: 0x00099F7C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)637468673;
			if (num != 0)
			{
			}
			num = (short)35688403;
			short num2 = num;
			num = (short)1445892051;
			switch (num2 == num)
			{
			}
			num = (short)314376192;
			short num3 = num;
			num = (short)158400512;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0009BE30 File Offset: 0x0009A030
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1383998116;
			short num2 = num;
			num = (short)247145124;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_16C:
				channelRangesMHzInnerSection = (A_0[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection);
				num = (short)153223170;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)158662656;
				if (num != 0)
				{
				}
				num = (short)1555300355;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_1D0;
				case 1:
					num = (short)1150746635;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (channelRangesMHzInnerSection.ParentRecset != null)
					{
						num = (short)1638858753;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 4:
					num = (short)499908609;
					if (num != 0)
					{
					}
					num = (short)1447297029;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)542179337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				case 6:
					num = (short)927596556;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_16C;
				case 8:
					channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEnable_A9001_UIValue = true;
					channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517_UIValue = true;
					num = (short)1045889024;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1517748234;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1172504582;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				case 11:
					if (channelRangesMHzInnerSection.ParentRecset.IndexOf(channelRangesMHzInnerSection.Parent) == 0)
					{
						num = (short)1120796680;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				case 12:
					if (A_0.Parent != null)
					{
						num = (short)670498823;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_260;
				}
				IL_A2:
				if (global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
				{
					break;
				}
				num = (short)293994500;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1D0:
			IL_260:
			num = (short)1715994624;
			short num4 = num;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0009C0C8 File Offset: 0x0009A2C8
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelRangesMHzInnerRecset()
		{
			short num = (short)1528063573;
			short num2 = num;
			num = (short)920872533;
			switch (num2 == num)
			{
			}
			num = (short)739770369;
			if (num != 0)
			{
			}
			num = (short)757727232;
			short num3 = num;
			num = (short)1621295104;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset._Min = 1;
		}

		// Token: 0x04000342 RID: 834
		public static int _MaxPool;

		// Token: 0x04000343 RID: 835
		public static int _Max;

		// Token: 0x04000344 RID: 836
		public int _DynMax;

		// Token: 0x04000345 RID: 837
		public static int _Min;

		// Token: 0x04000346 RID: 838
		public static int _DefaultRecordCount;
	}
}
