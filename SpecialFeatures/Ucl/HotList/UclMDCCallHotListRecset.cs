using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001DC RID: 476
	[global::System.Serializable]
	public class UclMDCCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x00003A95 File Offset: 0x00001C95
		public UclMDCCallHotListRecset() : base(global::CommonResources.AppResources.MDC_Conventional_Hot_List, global::CommonResources.AppResources.List)
		{
			this.a();
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x001F82F8 File Offset: 0x001F64F8
		protected UclMDCCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ杖", a_));
			}
			this.a();
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x001F8338 File Offset: 0x001F6538
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1339650656;
			short num2 = num;
			num = (short)1102082656;
			switch (num2 == num)
			{
			}
			num = (short)1099825153;
			if (num != 0)
			{
			}
			num = (short)1468334080;
			if (num != 0)
			{
			}
			num = (short)184483840;
			short num3 = num;
			return new global::SpecialFeatures.Ucl.HotList.UclMDCCallHotList(this);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x001F83E8 File Offset: 0x001F65E8
		private void a()
		{
			int a_ = 13;
			short num = (short)557746195;
			short num2 = num;
			num = (short)1757513747;
			switch (num2 == num)
			{
			}
			num = (short)332136449;
			if (num != 0)
			{
			}
			num = (short)447873024;
			if (num != 0)
			{
			}
			num = (short)1338376192;
			short num3 = num;
			base.Id = 2212;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﮙ\ud89d얟쎡킣펥\udaa7쾩\udfab閭\uddb1\ud9b3욵ힷ풹\ud9bb킽뒿蟃Ʂ꓇ꛉ苍맏ꇑꃓ鯗뗙닛룝觟藡釣铥觧黩藫臭黯\uddf1볳駵賷뛹闻跽瓿ⴁ儃攅搇䜉䠋䴍匏猑砓稕倗甙栛初䤟儡倣爥䨧䘩稫䜭唯䔱ᨳ丵夷圹倻", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.DataTransferOrder = 104;
			base.KeySeed = global::CommonResources.AppResources.List;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x001F84D8 File Offset: 0x001F66D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)854545171;
				short num2 = num;
				num = (short)977621779;
				switch (num2 == num)
				{
				}
				num = (short)1550581761;
				if (num != 0)
				{
				}
				num = (short)1509752832;
				if (num != 0)
				{
				}
				num = (short)2063728640;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x001F8588 File Offset: 0x001F6788
		public override int MaxPool
		{
			get
			{
				short num = (short)1113215218;
				short num2 = num;
				num = (short)956715250;
				switch (num2 == num)
				{
				}
				num = (short)1522008064;
				if (num != 0)
				{
				}
				num = (short)516620289;
				if (num != 0)
				{
				}
				num = (short)1463287808;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x001F8638 File Offset: 0x001F6838
		public override int Max
		{
			get
			{
				short num = (short)2042880638;
				short num2 = num;
				num = (short)1319690878;
				switch (num2 == num)
				{
				}
				num = (short)1699348481;
				if (num != 0)
				{
				}
				num = (short)243138560;
				if (num != 0)
				{
				}
				num = (short)1947926528;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset._Max;
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x001F86E8 File Offset: 0x001F68E8
		// Note: this type is marked as 'beforefieldinit'.
		static UclMDCCallHotListRecset()
		{
			short num = (short)228390184;
			short num2 = num;
			num = (short)885388584;
			switch (num2 == num)
			{
			}
			num = (short)659685377;
			if (num != 0)
			{
			}
			num = (short)2041905152;
			if (num != 0)
			{
			}
			num = (short)1148518400;
			short num3 = num;
			global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset._Max = 5000;
		}

		// Token: 0x04000BCF RID: 3023
		public static int _MaxPool;

		// Token: 0x04000BD0 RID: 3024
		public static int _Max;
	}
}
