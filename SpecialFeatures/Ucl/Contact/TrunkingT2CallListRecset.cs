using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200020E RID: 526
	[global::System.Serializable]
	public class TrunkingT2CallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001A9D RID: 6813 RVA: 0x00003D98 File Offset: 0x00001F98
		public TrunkingT2CallListRecset() : base(global::CommonResources.AppResources.Type_II_Trunking_ID_List, true, false, null)
		{
			base.Id = 2206;
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_ID_List;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00229640 File Offset: 0x00227840
		protected TrunkingT2CallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲔ練ﾘ", a_));
			}
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_ID_List;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00229684 File Offset: 0x00227884
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)165353012;
			short num2 = num;
			num = (short)1242633780;
			switch (num2 == num)
			{
			}
			num = (short)684130304;
			short num3 = num;
			num = (short)2118189057;
			if (num != 0)
			{
			}
			num = (short)1455751168;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList(this);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00229738 File Offset: 0x00227938
		public override int MaxPool
		{
			get
			{
				short num = (short)1118627713;
				short num2 = num;
				num = (short)514582401;
				switch (num2 == num)
				{
				}
				num = (short)1308491776;
				short num3 = num;
				num = (short)756350976;
				if (num != 0)
				{
				}
				num = (short)133758977;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset._MaxPool;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x002297E8 File Offset: 0x002279E8
		public override int Max
		{
			get
			{
				short num = (short)1972569520;
				short num2 = num;
				num = (short)568133040;
				switch (num2 == num)
				{
				}
				num = (short)1069678592;
				short num3 = num;
				num = (short)820707329;
				if (num != 0)
				{
				}
				num = (short)399441920;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset._Max;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00229894 File Offset: 0x00227A94
		public bool HasDiffs
		{
			get
			{
				short num = (short)990722914;
				short num2 = num;
				num = (short)1506687842;
				switch (num2 == num)
				{
				}
				num = (short)993067008;
				short num3 = num;
				num = (short)1868693504;
				if (num != 0)
				{
				}
				num = (short)2086273025;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00229940 File Offset: 0x00227B40
		public override int CounterToMax
		{
			get
			{
				short num = (short)102694913;
				if (num != 0)
				{
				}
				num = (short)431620096;
				switch (num)
				{
				default:
				{
					int num2 = 0;
					global::AcpBusinessLayer.Recordset recordset = (global::SpecialFeatures.Ucl.Contact.UclContactRecset)base.ParentSection.ParentRecset;
					global::SpecialFeatures.Ucl.Contact.UclContact uclContact = (global::SpecialFeatures.Ucl.Contact.UclContact)base.ParentSection.Parent;
					int index = uclContact.Parent.IndexOf(uclContact);
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = recordset[index].EmbeddedRecordsets.GetEnumerator();
					try
					{
						num = (short)400031747;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)809959425;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
								num2 += acpRecordset.Count;
								num = (short)1577582596;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								for (;;)
								{
									num = (short)2083680677;
									short num4 = num;
									num = (short)660173221;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_159;
									}
								}
								IL_159:
								num = (short)993591296;
								if (num != 0)
								{
								}
								num = (short)676724738;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_187;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C4;
								}
								continue;
							}
							IL_EF:
							num = (short)737607680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C4:
							goto IL_EF;
						}
						IL_187:;
					}
					finally
					{
						num = (short)1683030018;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1010434049;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1F0;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1BB;
								}
								continue;
							}
							IL_1BB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2038431744;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1F0:;
					}
					num = (short)1391460352;
					short num5 = num;
					return this.Max - num2;
				}
				}
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00229B84 File Offset: 0x00227D84
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)179932117;
			short num2 = num;
			num = (short)759073749;
			switch (num2 == num)
			{
			}
			num = (short)241500160;
			short num3 = num;
			num = (short)1943076865;
			if (num != 0)
			{
			}
			num = (short)225378304;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00229C34 File Offset: 0x00227E34
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1709176091;
			short num2 = num;
			num = (short)708113691;
			switch (num2 == num)
			{
			}
			num = (short)124321792;
			short num3 = num;
			num = (short)348913664;
			if (num != 0)
			{
			}
			num = (short)508035073;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			(record[10412] as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection).UclT2Trk_CombinedID_A00020_Valid = true;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00229CF8 File Offset: 0x00227EF8
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingT2CallListRecset()
		{
			short num = (short)1128117889;
			short num2 = num;
			num = (short)662353537;
			switch (num2 == num)
			{
			}
			num = (short)1015218176;
			short num3 = num;
			num = (short)625213441;
			if (num != 0)
			{
			}
			num = (short)545587200;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000CC3 RID: 3267
		public static int _MaxPool;

		// Token: 0x04000CC4 RID: 3268
		public static int _Max;
	}
}
