using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001FF RID: 511
	[global::System.Serializable]
	public class MDCCallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x00003C8E File Offset: 0x00001E8E
		internal MDCCallListRecset() : base(global::CommonResources.AppResources.MDC_Conventional_ID_List, true, false, null)
		{
			base.Id = 2203;
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_ID_List;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00211E20 File Offset: 0x00210020
		protected MDCCallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ", a_));
			}
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_ID_List;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00211E64 File Offset: 0x00210064
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2145386496;
			short num2 = num;
			num = (short)457740350;
			short num3 = num;
			num = (short)835751998;
			switch (num3 == num)
			{
			}
			num = (short)2034368512;
			if (num != 0)
			{
			}
			num = (short)1563623425;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.MDCCallList(this);
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x00211F14 File Offset: 0x00210114
		public override int MaxPool
		{
			get
			{
				short num = (short)488177664;
				short num2 = num;
				num = (short)1853371777;
				short num3 = num;
				num = (short)595342721;
				switch (num3 == num)
				{
				}
				num = (short)15597569;
				if (num != 0)
				{
				}
				num = (short)1619525632;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.MDCCallListRecset._MaxPool;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00211FC4 File Offset: 0x002101C4
		public override int Max
		{
			get
			{
				short num = (short)17563648;
				short num2 = num;
				num = (short)23189572;
				short num3 = num;
				num = (short)977459268;
				switch (num3 == num)
				{
				}
				num = (short)1124401153;
				if (num != 0)
				{
				}
				num = (short)1200291840;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.MDCCallListRecset._Max;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00212070 File Offset: 0x00210270
		public bool HasDiffs
		{
			get
			{
				short num = (short)1494548480;
				short num2 = num;
				num = (short)88891612;
				short num3 = num;
				num = (short)1945723100;
				switch (num3 == num)
				{
				}
				num = (short)1051918337;
				if (num != 0)
				{
				}
				num = (short)869662720;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00212120 File Offset: 0x00210320
		public override int CounterToMax
		{
			get
			{
				short num = (short)482881211;
				short num2 = num;
				num = (short)2027499195;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1346174977;
					if (num != 0)
					{
					}
					num = (short)1383727104;
					if (num != 0)
					{
					}
					num = (short)2141913088;
					switch (num)
					{
					default:
					{
						num3 = 0;
						global::AcpBusinessLayer.Recordset recordset = (global::SpecialFeatures.Ucl.Contact.UclContactRecset)base.ParentSection.ParentRecset;
						global::SpecialFeatures.Ucl.Contact.UclContact uclContact = (global::SpecialFeatures.Ucl.Contact.UclContact)base.ParentSection.Parent;
						int index = uclContact.Parent.IndexOf(uclContact);
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = recordset[index].EmbeddedRecordsets.GetEnumerator();
						try
						{
							num = (short)435945472;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_10E;
									}
									continue;
								case 1:
									num = (short)1208090626;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_18A;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)638713857;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									num3 += acpRecordset.Count;
									num = (short)1720975364;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_13A:
								num = (short)1658126339;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_10E:
								goto IL_13A;
							}
							IL_18A:;
						}
						finally
						{
							num = (short)867434496;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1BE;
									}
									continue;
								case 1:
									goto IL_1F6;
								case 2:
									enumerator.Dispose();
									num = (short)639696897;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1BE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1997930498;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_1F6:;
						}
						break;
					}
					}
					break;
				}
				num = (short)598999040;
				short num5 = num;
				return this.Max - num3;
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00212368 File Offset: 0x00210568
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)16056320;
			short num2 = num;
			num = (short)1761287503;
			short num3 = num;
			num = (short)1933385039;
			switch (num3 == num)
			{
			}
			num = (short)579403777;
			if (num != 0)
			{
			}
			num = (short)800980992;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00212418 File Offset: 0x00210618
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1353973760;
			short num2 = num;
			num = (short)1553404381;
			short num3 = num;
			num = (short)383848925;
			switch (num3 == num)
			{
			}
			num = (short)506003456;
			if (num != 0)
			{
			}
			num = (short)661389313;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			(record[10406] as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection).UclMDCCnv_CallID_A00031_Valid = true;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x002124E0 File Offset: 0x002106E0
		// Note: this type is marked as 'beforefieldinit'.
		static MDCCallListRecset()
		{
			short num = (short)1973747712;
			short num2 = num;
			num = (short)87752705;
			if (num != 0)
			{
			}
			num = (short)1292122556;
			short num3 = num;
			num = (short)136001980;
			switch (num3 == num)
			{
			}
			num = (short)169345024;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.MDCCallListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.MDCCallListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000C9F RID: 3231
		public static int _MaxPool;

		// Token: 0x04000CA0 RID: 3232
		public static int _Max;
	}
}
