using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001F3 RID: 499
	[global::System.Serializable]
	public class AstroCallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x00003C13 File Offset: 0x00001E13
		internal AstroCallListRecset() : base(global::CommonResources.AppResources.Astro_Conventional_ID_List, true, false, null)
		{
			base.Id = 2202;
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_ID_List;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00207538 File Offset: 0x00205738
		protected AstroCallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_ID_List;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0020757C File Offset: 0x0020577C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)13622651;
			short num2 = num;
			num = (short)1280761211;
			switch (num2 == num)
			{
			}
			num = (short)602144768;
			short num3 = num;
			num = (short)1171914753;
			if (num != 0)
			{
			}
			num = (short)1756758016;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.AstroCallList(this);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0020762C File Offset: 0x0020582C
		public override int MaxPool
		{
			get
			{
				short num = (short)28007973;
				short num2 = num;
				num = (short)1342004773;
				switch (num2 == num)
				{
				}
				num = (short)265158656;
				short num3 = num;
				num = (short)1933049856;
				if (num != 0)
				{
				}
				num = (short)1306722305;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.AstroCallListRecset._MaxPool;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x002076E0 File Offset: 0x002058E0
		public override int Max
		{
			get
			{
				short num = (short)1395531519;
				short num2 = num;
				num = (short)475864831;
				switch (num2 == num)
				{
				}
				num = (short)1392771072;
				short num3 = num;
				num = (short)1564999681;
				if (num != 0)
				{
				}
				num = (short)285278208;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.Contact.AstroCallListRecset._Max;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00207790 File Offset: 0x00205990
		public bool HasDiffs
		{
			get
			{
				short num = (short)1891434497;
				if (num != 0)
				{
				}
				num = (short)1925094444;
				short num2 = num;
				num = (short)35494956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916272640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)53215232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00207840 File Offset: 0x00205A40
		public override int CounterToMax
		{
			get
			{
				short num = (short)1822228480;
				switch (num)
				{
				default:
				{
					num = (short)186712065;
					if (num != 0)
					{
					}
					num = (short)1607794688;
					short num2 = num;
					int num3 = 0;
					global::AcpBusinessLayer.Recordset recordset = (global::SpecialFeatures.Ucl.Contact.UclContactRecset)base.ParentSection.ParentRecset;
					global::SpecialFeatures.Ucl.Contact.UclContact uclContact = (global::SpecialFeatures.Ucl.Contact.UclContact)base.ParentSection.Parent;
					int index = uclContact.Parent.IndexOf(uclContact);
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = recordset[index].EmbeddedRecordsets.GetEnumerator();
					try
					{
						num = (short)1295122434;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (enumerator.MoveNext())
								{
									global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
									num3 += acpRecordset.Count;
									num = (short)1190002691;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)476164639;
								short num5 = num;
								num = (short)350007839;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)2062090240;
									if (num != 0)
									{
									}
									num = (short)1612120065;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)513802244;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_F0;
								}
								continue;
							case 4:
								goto IL_1B8;
							}
							IL_11D:
							num = (short)563478528;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_F0:
							goto IL_11D;
						}
						IL_1B8:;
					}
					finally
					{
						num = (short)147521537;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1343553538;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1EE;
								}
								continue;
							case 2:
								goto IL_224;
							}
							IL_1EE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1436876800;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_224:;
					}
					return this.Max - num3;
				}
				}
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00207A98 File Offset: 0x00205C98
		public override int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)1557932789;
			short num2 = num;
			num = (short)91892469;
			switch (num2 == num)
			{
			}
			num = (short)523042816;
			short num3 = num;
			num = (short)1770913792;
			if (num != 0)
			{
			}
			num = (short)1136459777;
			if (num != 0)
			{
			}
			return this.CounterToMax;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00207B48 File Offset: 0x00205D48
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)465121751;
			short num2 = num;
			num = (short)384709079;
			switch (num2 == num)
			{
			}
			num = (short)818741248;
			short num3 = num;
			num = (short)125763585;
			if (num != 0)
			{
			}
			num = (short)541065216;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			(record[10404] as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection).UclAstroCnv_CallID_A00026_Valid = true;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00207C10 File Offset: 0x00205E10
		// Note: this type is marked as 'beforefieldinit'.
		static AstroCallListRecset()
		{
			short num = (short)1271684996;
			short num2 = num;
			num = (short)2117033860;
			switch (num2 == num)
			{
			}
			num = (short)656932864;
			short num3 = num;
			num = (short)933036033;
			if (num != 0)
			{
			}
			num = (short)1526595584;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.AstroCallListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.Contact.AstroCallListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000C80 RID: 3200
		public static int _MaxPool;

		// Token: 0x04000C81 RID: 3201
		public static int _Max;
	}
}
