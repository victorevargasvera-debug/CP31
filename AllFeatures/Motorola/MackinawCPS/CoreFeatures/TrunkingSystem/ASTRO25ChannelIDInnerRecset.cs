using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000065 RID: 101
	[global::System.Serializable]
	public class ASTRO25ChannelIDInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x00080FB8 File Offset: 0x0007F1B8
		public ASTRO25ChannelIDInnerRecset() : base(global::CommonResources.AcgResources.ID_ASTRO25CHANNELID, global::CommonResources.AcgResources.ID_CHANNELID)
		{
			this.SetValues();
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00080FDC File Offset: 0x0007F1DC
		public ASTRO25ChannelIDInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00081008 File Offset: 0x0007F208
		public override int MaxPool
		{
			get
			{
				short num = (short)1354760193;
				if (num != 0)
				{
				}
				num = (short)230356714;
				short num2 = num;
				num = (short)358807274;
				switch (num2 == num)
				{
				}
				num = (short)190775296;
				short num3 = num;
				num = (short)505020416;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x000810B4 File Offset: 0x0007F2B4
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00081174 File Offset: 0x0007F374
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)939429353;
					short num2 = num;
					num = (short)880512489;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1177354241;
						if (num != 0)
						{
						}
						num = (short)1363279872;
						if (num != 0)
						{
						}
						num = (short)1024393216;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1663611984;
				short num2 = num;
				num = (short)2092414032;
				switch (num2 == num)
				{
				}
				num = (short)1013579777;
				if (num != 0)
				{
				}
				num = (short)2025390080;
				short num3 = num;
				num = (short)767623168;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00081228 File Offset: 0x0007F428
		public override int Min
		{
			get
			{
				short num = (short)105284213;
				short num2 = num;
				num = (short)1850311285;
				switch (num2 == num)
				{
				}
				num = (short)1349648384;
				if (num != 0)
				{
				}
				num = (short)1262813184;
				short num3 = num;
				num = (short)855179265;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._Min;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000812D8 File Offset: 0x0007F4D8
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00081384 File Offset: 0x0007F584
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1105280449;
				short num2 = num;
				num = (short)2063482305;
				switch (num2 == num)
				{
				}
				num = (short)686751744;
				if (num != 0)
				{
				}
				num = (short)534577152;
				short num3 = num;
				num = (short)678559745;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)940107910;
				short num2 = num;
				num = (short)967633030;
				switch (num2 == num)
				{
				}
				num = (short)1687486465;
				if (num != 0)
				{
				}
				num = (short)944504832;
				short num3 = num;
				num = (short)2081685504;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00081430 File Offset: 0x0007F630
		public bool HasDiffs
		{
			get
			{
				short num = (short)824621720;
				short num2 = num;
				num = (short)2060499608;
				switch (num2 == num)
				{
				}
				num = (short)456196097;
				if (num != 0)
				{
				}
				num = (short)652607488;
				short num3 = num;
				num = (short)148307968;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000814E0 File Offset: 0x0007F6E0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)910265288;
			short num2 = num;
			num = (short)251694024;
			switch (num2 == num)
			{
			}
			num = (short)483721217;
			if (num != 0)
			{
			}
			num = (short)31653888;
			short num3 = num;
			num = (short)370999296;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner(this);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00081590 File Offset: 0x0007F790
		internal void SetValues()
		{
			short num = (short)1041640809;
			short num2 = num;
			num = (short)1882533225;
			switch (num2 == num)
			{
			}
			num = (short)1429405696;
			if (num != 0)
			{
			}
			num = (short)887029760;
			short num3 = num;
			num = (short)1563885569;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			base.KeySeed = global::CommonResources.AcgResources.ID_CHANNELID;
			base.DataTransferOrder = 43;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00081664 File Offset: 0x0007F864
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1491486775;
			short num2 = num;
			num = (short)957958199;
			switch (num2 == num)
			{
			}
			num = (short)1122631681;
			if (num != 0)
			{
			}
			num = (short)872284160;
			short num3 = num;
			num = (short)2139750400;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.b(record);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0008171C File Offset: 0x0007F91C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2066265915;
			short num2 = num;
			num = (short)1321252667;
			switch (num2 == num)
			{
			}
			num = (short)662503425;
			if (num != 0)
			{
			}
			num = (short)406192128;
			short num3 = num;
			num = (short)1960837120;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000817D0 File Offset: 0x0007F9D0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)932446217;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
					if (astro25ChannelIDInnerSection.ParentRecset == null)
					{
						return;
					}
					num = (short)1316116639;
					short num3 = num;
					num = (short)1237407903;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num = (short)1995440129;
						if (num != 0)
						{
						}
						num = (short)479068160;
						if (num != 0)
						{
						}
						num = (short)1999503364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = A_0[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
					num = (short)1819017216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
					if (astro25ChannelIDInnerSection.ParentRecset.IndexOf(astro25ChannelIDInnerSection.Parent) == 0)
					{
						num = (short)273809418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					num = (short)1933443075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)2073886720;
					short num4 = num;
					num = (short)935329803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)1520435208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)175308805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1997733895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
					astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDIdentifierEnable_A8222_UIValue = true;
					goto IL_16C;
				}
				case 11:
					if (A_0.Parent != null)
					{
						num = (short)373227522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					num = (short)1624899590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
				{
					num = (short)412090380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16C:
				num = (short)1308950529;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00081A68 File Offset: 0x0007FC68
		// Note: this type is marked as 'beforefieldinit'.
		static ASTRO25ChannelIDInnerRecset()
		{
			short num = (short)682141529;
			short num2 = num;
			num = (short)1553377113;
			switch (num2 == num)
			{
			}
			num = (short)983040000;
			if (num != 0)
			{
			}
			num = (short)347144192;
			short num3 = num;
			num = (short)899022849;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset._Min = 1;
		}

		// Token: 0x04000326 RID: 806
		public static int _MaxPool;

		// Token: 0x04000327 RID: 807
		public static int _Max;

		// Token: 0x04000328 RID: 808
		public int _DynMax;

		// Token: 0x04000329 RID: 809
		public static int _Min;

		// Token: 0x0400032A RID: 810
		public static int _DefaultRecordCount;
	}
}
