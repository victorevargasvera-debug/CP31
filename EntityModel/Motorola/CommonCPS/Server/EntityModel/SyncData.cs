using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000189 RID: 393
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SyncData
	{
		// Token: 0x06001529 RID: 5417 RVA: 0x000E1228 File Offset: 0x000DF428
		public SyncData()
		{
			this.ModifiedRecords = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_Record>();
			this.RecordsOfOneWholeConfiguration = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_Record>();
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x000E1254 File Offset: 0x000DF454
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x000E1304 File Offset: 0x000DF504
		[global::System.Runtime.Serialization.DataMember]
		public string ConfigUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)653852673;
				if (num != 0)
				{
				}
				num = (short)2036765006;
				short num2 = num;
				num = (short)280858958;
				switch (num2 == num)
				{
				}
				num = (short)659488768;
				short num3 = num;
				num = (short)569638912;
				if (num != 0)
				{
				}
				return this.<ConfigUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1841994099;
				short num2 = num;
				num = (short)1480694131;
				switch (num2 == num)
				{
				}
				num = (short)336134145;
				if (num != 0)
				{
				}
				num = (short)1283391488;
				short num3 = num;
				num = (short)1139474432;
				if (num != 0)
				{
				}
				this.<ConfigUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000E13B4 File Offset: 0x000DF5B4
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x000E1464 File Offset: 0x000DF664
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_Record> RecordsOfOneWholeConfiguration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1085014017;
				if (num != 0)
				{
				}
				num = (short)162729987;
				short num2 = num;
				num = (short)690163715;
				switch (num2 == num)
				{
				}
				num = (short)465895424;
				short num3 = num;
				num = (short)1914372096;
				if (num != 0)
				{
				}
				return this.<RecordsOfOneWholeConfiguration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1679328584;
				short num2 = num;
				num = (short)1912702280;
				switch (num2 == num)
				{
				}
				num = (short)863174656;
				if (num != 0)
				{
				}
				num = (short)1352990720;
				short num3 = num;
				num = (short)1954480129;
				if (num != 0)
				{
				}
				this.<RecordsOfOneWholeConfiguration>k__BackingField = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000E1514 File Offset: 0x000DF714
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000E15C4 File Offset: 0x000DF7C4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_Record> ModifiedRecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1277239408;
				short num2 = num;
				num = (short)149823600;
				switch (num2 == num)
				{
				}
				num = (short)470155265;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				short num3 = num;
				num = (short)448659456;
				if (num != 0)
				{
				}
				return this.<ModifiedRecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1838161574;
				short num2 = num;
				num = (short)1251876518;
				switch (num2 == num)
				{
				}
				num = (short)1362100225;
				if (num != 0)
				{
				}
				num = (short)1130627072;
				short num3 = num;
				num = (short)1850998784;
				if (num != 0)
				{
				}
				this.<ModifiedRecords>k__BackingField = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000E1678 File Offset: 0x000DF878
		public bool IsBLLDataNeedToSync
		{
			get
			{
				short num = (short)1884749828;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A2;
					case 1:
					{
						num = (short)1069350912;
						short num3 = num;
						if (this.RecordsOfOneWholeConfiguration.Count <= 0)
						{
							num = (short)1870069762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
					{
						num = (short)1739385430;
						short num4 = num;
						num = (short)1563552342;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)977797121;
							if (num != 0)
							{
							}
							num = (short)1229783040;
							if (num != 0)
							{
							}
							goto IL_69;
						}
						break;
					}
					case 3:
						if (this.ModifiedRecords != null)
						{
							num = (short)2068709376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						num = (short)508887041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					if (this.RecordsOfOneWholeConfiguration != null)
					{
						num = (short)1576075269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_69:
					num = (short)1718353923;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				return this.ModifiedRecords.Count > 0;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x000E180C File Offset: 0x000DFA0C
		public bool IsNeedSyncData
		{
			get
			{
				if (!this.IsBLLDataNeedToSync)
				{
					short num = (short)886030928;
					short num2 = num;
					num = (short)1019396688;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1485111296;
						short num3 = num;
						num = (short)692191232;
						if (num != 0)
						{
						}
						num = (short)1899167745;
						if (num != 0)
						{
						}
						return this.IsOptionListNeededToSync;
					}
					}
				}
				return true;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000E18CC File Offset: 0x000DFACC
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x000E197C File Offset: 0x000DFB7C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<int, int> OptionCountChanges
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1044761112;
				short num2 = num;
				num = (short)1835780632;
				switch (num2 == num)
				{
				}
				num = (short)598016001;
				if (num != 0)
				{
				}
				num = (short)933494784;
				short num3 = num;
				num = (short)881328128;
				if (num != 0)
				{
				}
				return this.<OptionCountChanges>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)152545765;
				short num2 = num;
				num = (short)1774627301;
				switch (num2 == num)
				{
				}
				num = (short)782368769;
				if (num != 0)
				{
				}
				num = (short)545718272;
				short num3 = num;
				num = (short)1291649024;
				if (num != 0)
				{
				}
				this.<OptionCountChanges>k__BackingField = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000E1A2C File Offset: 0x000DFC2C
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x000E1ADC File Offset: 0x000DFCDC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, int>> RecordCountChange
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)290062337;
				if (num != 0)
				{
				}
				num = (short)517592719;
				short num2 = num;
				num = (short)1915541135;
				switch (num2 == num)
				{
				}
				num = (short)1860042752;
				short num3 = num;
				num = (short)130678784;
				if (num != 0)
				{
				}
				return this.<RecordCountChange>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1024272517;
				short num2 = num;
				num = (short)1530341509;
				switch (num2 == num)
				{
				}
				num = (short)1363083265;
				if (num != 0)
				{
				}
				num = (short)1054932992;
				short num3 = num;
				num = (short)1525874688;
				if (num != 0)
				{
				}
				this.<RecordCountChange>k__BackingField = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000E1B8C File Offset: 0x000DFD8C
		public bool IsOptionListNeededToSync
		{
			get
			{
				short num = (short)1260257282;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_20:
					switch (num2)
					{
					case 0:
						while (this.RecordCountChange != null)
						{
							num = (short)269542003;
							short num3 = num;
							num = (short)1138090611;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1334509568;
								if (num != 0)
								{
								}
								num = (short)1608384513;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_20;
							}
						}
						return false;
					case 1:
						goto IL_E6;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					case 3:
						num = (short)1605435392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_36:
					if (this.OptionCountChanges != null)
					{
						return true;
					}
					num = (short)1135083523;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_E6:
				num = (short)728891392;
				short num4 = num;
				num = (short)865140737;
				if (num != 0)
				{
				}
				return this.RecordCountChange.Count > 0;
			}
		}
	}
}
