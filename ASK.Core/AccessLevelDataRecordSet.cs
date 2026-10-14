using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ASK.Core
{
	// Token: 0x02000010 RID: 16
	[global::System.Serializable]
	public class AccessLevelDataRecordSet : global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.AccessRecord>
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00010454 File Offset: 0x0000E654
		protected AccessLevelDataRecordSet()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00010470 File Offset: 0x0000E670
		public AccessLevelDataRecordSet(string name)
		{
			this.name = name;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00010494 File Offset: 0x0000E694
		public void AddNewRecord(global::ASK.Core.AccessRecord newRec)
		{
			short num = (short)1336410112;
			short num2 = num;
			num = (short)472849589;
			short num3 = num;
			num = (short)1759845557;
			switch (num3 == num)
			{
			}
			num = (short)1698430976;
			if (num != 0)
			{
			}
			num = (short)1917517825;
			if (num != 0)
			{
			}
			int count = base.Count;
			newRec.ID = count + 1;
			byte uNextPrimaryKeyValue = this.m_uNextPrimaryKeyValue;
			this.m_uNextPrimaryKeyValue = uNextPrimaryKeyValue + 1;
			newRec.PrimaryKey = (int)uNextPrimaryKeyValue;
			base.Add(newRec);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0001056C File Offset: 0x0000E76C
		public global::ASK.Core.AccessRecord GetRecordByData(global::ASK.Core.AccessRecord inputAccessRec)
		{
			global::ASK.Core.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)1186856961;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::ASK.Core.AccessRecord accessRecord;
						if (accessRecord.IsEqual(inputAccessRec))
						{
							num = (short)733347845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 2:
						num = (short)806420483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_FA;
					case 4:
						goto IL_DE;
					case 5:
					{
						global::ASK.Core.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)1107755012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)739573762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Core.AccessRecord accessRecord = enumerator.Current;
						num = (short)1957625856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8E:
					num = (short)1792737286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51:
					goto IL_8E;
				}
				IL_DE:
				IL_FA:;
			}
			finally
			{
				num = (short)1330839553;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B7;
					case 1:
						goto IL_115;
					case 2:
					{
						enumerator.Dispose();
						num = (short)715553811;
						short num3 = num;
						num = (short)1291877395;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_115;
						default:
							num = (short)2130378752;
							if (num != 0)
							{
							}
							num = (short)459210752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_131;
					IL_115:
					switch (0)
					{
					case 0:
						IL_131:
						if (enumerator == null)
						{
							goto IL_1B9;
						}
						num = (short)173604866;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1B7:
				IL_1B9:;
			}
			num = (short)504758273;
			if (num != 0)
			{
			}
			num = (short)1794244608;
			short num4 = num;
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00010798 File Offset: 0x0000E998
		public global::ASK.Core.AccessRecord GetRecordByAccessName(string strName)
		{
			short num = (short)1968832513;
			if (num != 0)
			{
			}
			global::ASK.Core.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = base.Items.GetEnumerator();
			try
			{
				num = (short)1568014337;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::ASK.Core.AccessRecord accessRecord;
						if (accessRecord.Name == strName)
						{
							num = (short)61800453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 2:
						num = (short)1794834435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_125;
					case 4:
						goto IL_108;
					case 5:
					{
						global::ASK.Core.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)642121732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2133917698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Core.AccessRecord accessRecord = enumerator.Current;
						num = (short)1942290432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_BA:
					num = (short)967901190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77:
					goto IL_BA;
				}
				IL_108:
				IL_125:;
			}
			finally
			{
				num = (short)1085276161;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1DF;
					case 1:
						goto IL_13E;
					case 2:
					{
						enumerator.Dispose();
						num = (short)488665148;
						short num3 = num;
						num = (short)1222733884;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13E;
						default:
							num = (short)1131675648;
							if (num != 0)
							{
							}
							num = (short)301334528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_15A;
					IL_13E:
					switch (0)
					{
					case 0:
						IL_15A:
						if (enumerator == null)
						{
							goto IL_1E1;
						}
						num = (short)1288634370;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1DF:
				IL_1E1:;
			}
			num = (short)576716800;
			short num4 = num;
			return result;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000109C0 File Offset: 0x0000EBC0
		internal string Name
		{
			get
			{
				short num = (short)876281856;
				short num2 = num;
				num = (short)153520091;
				short num3 = num;
				num = (short)724928475;
				switch (num3 == num)
				{
				}
				num = (short)1005584384;
				if (num != 0)
				{
				}
				num = (short)231931905;
				if (num != 0)
				{
				}
				return this.name;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00010A70 File Offset: 0x0000EC70
		internal bool a(string A_0, int A_1)
		{
			bool result = true;
			int num = 0;
			global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecord> enumerator = base.Items.GetEnumerator();
			short num2;
			try
			{
				num2 = (short)1082916868;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 1:
						if (A_1 != num)
						{
							num2 = (short)1126105091;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_113;
					case 2:
						num2 = (short)743047169;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						result = false;
						num2 = (short)772210695;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 5:
						goto IL_168;
					case 6:
						if (enumerator.Current.Name == A_0)
						{
							num2 = (short)2095841282;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_113;
					case 7:
						goto IL_113;
					case 8:
						if (!enumerator.MoveNext())
						{
							num2 = (short)1960574985;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1660223494;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						num2 = (short)629800965;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_94:
					num2 = (short)154009608;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_5E:
					goto IL_94;
					IL_113:
					num++;
					num2 = (short)898957312;
					num3 = (int)((global::System.IntPtr)num2);
				}
				IL_168:;
			}
			finally
			{
				num2 = (short)766509057;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_222;
					case 1:
						goto IL_182;
					case 2:
					{
						enumerator.Dispose();
						num2 = (short)175511983;
						short num4 = num2;
						num2 = (short)545200559;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_182;
						default:
							num2 = (short)657260544;
							if (num2 != 0)
							{
							}
							num2 = (short)1576206336;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_19E;
					IL_182:
					switch (0)
					{
					case 0:
						IL_19E:
						if (enumerator == null)
						{
							goto IL_224;
						}
						num2 = (short)491061250;
						num3 = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_222:
				IL_224:;
			}
			num2 = (short)1102970881;
			if (num2 != 0)
			{
			}
			num2 = (short)283443200;
			short num5 = num2;
			return result;
		}

		// Token: 0x0400002F RID: 47
		private string name;

		// Token: 0x04000030 RID: 48
		private byte m_uNextPrimaryKeyValue = 4;
	}
}
