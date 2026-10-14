using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200020A RID: 522
	[global::System.Serializable]
	public class TrunkingCallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060019F4 RID: 6644 RVA: 0x00003D38 File Offset: 0x00001F38
		internal TrunkingCallListRecset() : base(global::CommonResources.AppResources.Astro_25_Trunking_ID_List_lowcase, true, false, null)
		{
			base.Id = 2201;
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_ID_List_lowcase;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00220C14 File Offset: 0x0021EE14
		protected TrunkingCallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_ID_List_lowcase;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00220C58 File Offset: 0x0021EE58
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)651880636;
			short num2 = num;
			num = (short)767158460;
			switch (num2 == num)
			{
			}
			num = (short)1392574464;
			short num3 = num;
			num = (short)242679809;
			if (num != 0)
			{
			}
			num = (short)1900478464;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.TrunkingCallList(this);
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00220D08 File Offset: 0x0021EF08
		public override int MaxPool
		{
			get
			{
				short num = (short)1931092146;
				short num2 = num;
				num = (short)517873842;
				switch (num2 == num)
				{
				}
				num = (short)451674112;
				short num3 = num;
				num = (short)287309825;
				if (num != 0)
				{
				}
				num = (short)272695296;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset._MaxPool;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00220DB8 File Offset: 0x0021EFB8
		public override int Max
		{
			get
			{
				short num = (short)1140739772;
				short num2 = num;
				num = (short)2045005500;
				switch (num2 == num)
				{
				}
				num = (short)1901789184;
				short num3 = num;
				num = (short)453181441;
				if (num != 0)
				{
				}
				num = (short)947781632;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset._Max;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00220E68 File Offset: 0x0021F068
		public override int CounterToMax
		{
			get
			{
				short num = (short)2016206746;
				short num2 = num;
				num = (short)872275866;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1665531905;
					if (num != 0)
					{
					}
					num = (short)2122121216;
					if (num != 0)
					{
					}
					num = (short)1140719616;
					short num3 = num;
					num = (short)547291136;
					switch (num)
					{
					}
					break;
				}
				}
				int num4 = 0;
				global::AcpBusinessLayer.Recordset recordset = (global::SpecialFeatures.Ucl.Contact.UclContactRecset)base.ParentSection.ParentRecset;
				global::SpecialFeatures.Ucl.Contact.UclContact uclContact = (global::SpecialFeatures.Ucl.Contact.UclContact)base.ParentSection.Parent;
				int index = uclContact.Parent.IndexOf(uclContact);
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = recordset[index].EmbeddedRecordsets.GetEnumerator();
				try
				{
					num = (short)396492802;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1400111107;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
							num4 += acpRecordset.Count;
							num = (short)391643137;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_137;
							}
							continue;
						case 3:
							num = (short)1669988356;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1B2;
						}
						IL_163:
						num = (short)515112960;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_137:
						goto IL_163;
					}
					IL_1B2:;
				}
				finally
				{
					num = (short)1574961152;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1E6;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)982843394;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_21D;
						}
						IL_1E6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2113732609;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_21D:;
				}
				return this.Max - num4;
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x002210B0 File Offset: 0x0021F2B0
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)675569893;
			short num2 = num;
			num = (short)926769381;
			switch (num2 == num)
			{
			}
			num = (short)1143799808;
			short num3 = num;
			num = (short)680001537;
			if (num != 0)
			{
			}
			num = (short)1398210560;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00221160 File Offset: 0x0021F360
		public bool HasDiffs
		{
			get
			{
				short num = (short)2105729353;
				short num2 = num;
				num = (short)23454025;
				switch (num2 == num)
				{
				}
				num = (short)1868562432;
				short num3 = num;
				num = (short)1376976897;
				if (num != 0)
				{
				}
				num = (short)1518862336;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0022120C File Offset: 0x0021F40C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)524412697;
			short num2 = num;
			num = (short)464774937;
			switch (num2 == num)
			{
			}
			num = (short)803536896;
			short num3 = num;
			num = (short)1408761856;
			if (num != 0)
			{
			}
			num = (short)1791229953;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			(record[10402] as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection).UclAstro25Trk_CombinedID_A00014_Valid = true;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x002212D0 File Offset: 0x0021F4D0
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingCallListRecset()
		{
			short num = (short)1105002497;
			if (num != 0)
			{
			}
			num = (short)1626265739;
			short num2 = num;
			num = (short)298965131;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1373896704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1497825280;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000CB9 RID: 3257
		public static int _MaxPool;

		// Token: 0x04000CBA RID: 3258
		public static int _Max;
	}
}
