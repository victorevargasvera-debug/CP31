using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E9 RID: 489
	[global::System.Serializable]
	public class UclTrunkingCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x00003B76 File Offset: 0x00001D76
		public UclTrunkingCallHotListRecset() : base(global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List, global::CommonResources.AppResources.List)
		{
			this.a();
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x001FF638 File Offset: 0x001FD838
		protected UclTrunkingCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ杖", a_));
			}
			this.a();
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x001FF678 File Offset: 0x001FD878
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1830748160;
			short num2 = num;
			num = (short)876020652;
			short num3 = num;
			num = (short)1930822572;
			switch (num3 == num)
			{
			}
			num = (short)1707737089;
			if (num != 0)
			{
			}
			num = (short)1061355520;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotList(this);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x001FF728 File Offset: 0x001FD928
		private void a()
		{
			int a_ = 0;
			short num = (short)1648033792;
			short num2 = num;
			num = (short)156509011;
			short num3 = num;
			num = (short)884417363;
			switch (num3 == num)
			{
			}
			num = (short)1669136384;
			if (num != 0)
			{
			}
			num = (short)1705115649;
			if (num != 0)
			{
			}
			base.Id = 2208;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킂힐骠쪤쪦\ud9a8쒪쎬쪮\udfb0잲骴\ud8b8ힺ톼龾跀ꫂ뛄돆裊ꋌꇎ럐뫒닔ꋖꯘ뫚꧜뛞軠跢쫤꿦蛨鿪ꇬ蛮苰蟲\udaf4ꋶ髸韺ꧼ跾琀洂渄渆月氊丌渎紐缒崔砖洘圚琜氞唠眢䜤䬦缨䈪䠬堮ἰ䬲吴娶唸", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
			base.DataTransferOrder = 101;
			base.KeySeed = global::CommonResources.AppResources.List;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x001FF818 File Offset: 0x001FDA18
		public override int MaxPool
		{
			get
			{
				short num = (short)1113456640;
				short num2 = num;
				num = (short)1020799058;
				short num3 = num;
				num = (short)1369712722;
				switch (num3 == num)
				{
				}
				num = (short)353566721;
				if (num != 0)
				{
				}
				num = (short)1583742976;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x001FF8C4 File Offset: 0x001FDAC4
		public override int Max
		{
			get
			{
				short num = (short)1973774545;
				short num2 = num;
				num = (short)388131025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746468864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692860417;
				if (num != 0)
				{
				}
				num = (short)656474112;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset._Max;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x001FF970 File Offset: 0x001FDB70
		public bool HasDiffs
		{
			get
			{
				short num = (short)897250233;
				short num2 = num;
				num = (short)1767109561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469565440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1162084352;
				if (num != 0)
				{
				}
				num = (short)1118175233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x001FFA24 File Offset: 0x001FDC24
		// Note: this type is marked as 'beforefieldinit'.
		static UclTrunkingCallHotListRecset()
		{
			short num = (short)390949950;
			short num2 = num;
			num = (short)2063297598;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2130444288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)448266240;
			if (num != 0)
			{
			}
			num = (short)253427713;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset._Max = 5000;
		}

		// Token: 0x04000C24 RID: 3108
		public static int _MaxPool;

		// Token: 0x04000C25 RID: 3109
		public static int _Max;
	}
}
