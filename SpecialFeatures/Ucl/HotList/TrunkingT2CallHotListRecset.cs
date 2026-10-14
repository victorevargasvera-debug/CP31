using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001CF RID: 463
	[global::System.Serializable]
	public class TrunkingT2CallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001666 RID: 5734 RVA: 0x000039DB File Offset: 0x00001BDB
		public TrunkingT2CallHotListRecset() : base(global::CommonResources.AppResources.Type_II_Trunking_Hot_List)
		{
			base.Id = 2215;
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x001F0140 File Offset: 0x001EE340
		protected TrunkingT2CallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲔ練ﾘ", a_));
			}
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x001F0184 File Offset: 0x001EE384
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1688566661;
			short num2 = num;
			num = (short)2097183621;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1194328064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1563557889;
			if (num != 0)
			{
			}
			num = (short)92733440;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotList(this);
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x001F0234 File Offset: 0x001EE434
		public override int MaxPool
		{
			get
			{
				short num = (short)1403499266;
				short num2 = num;
				num = (short)612479746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970470912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570439168;
				if (num != 0)
				{
				}
				num = (short)1110310913;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset._MaxPool;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x001F02E0 File Offset: 0x001EE4E0
		public override int Max
		{
			get
			{
				short num = (short)158209417;
				short num2 = num;
				num = (short)771757449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014759424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329252865;
				if (num != 0)
				{
				}
				num = (short)713490432;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset._Max;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x001F0390 File Offset: 0x001EE590
		public bool HasDiffs
		{
			get
			{
				short num = (short)1334231507;
				short num2 = num;
				num = (short)104251859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1001914368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2051014657;
				if (num != 0)
				{
				}
				num = (short)1338441728;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x001F0440 File Offset: 0x001EE640
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingT2CallHotListRecset()
		{
			short num = (short)920130404;
			short num2 = num;
			num = (short)893588324;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1750663168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1497628672;
			if (num != 0)
			{
			}
			num = (short)1175715841;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000B93 RID: 2963
		public static int _MaxPool;

		// Token: 0x04000B94 RID: 2964
		public static int _Max;
	}
}
