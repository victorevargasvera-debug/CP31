using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AcpASKLib
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	public class AccessLevelDataRecordSet : global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.AccessRecord>
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		protected AccessLevelDataRecordSet()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public AccessLevelDataRecordSet(string name)
		{
			this.name = name;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000F020 File Offset: 0x0000D220
		public void AddNewRecord(global::AcpASKLib.AccessRecord newRec)
		{
			short num = (short)358628987;
			short num2 = num;
			num = (short)2072657531;
			switch (num2 == num)
			{
			}
			num = (short)1334837248;
			short num3 = num;
			num = (short)36110336;
			if (num != 0)
			{
			}
			num = (short)1470300161;
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

		// Token: 0x06000090 RID: 144 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
		internal global::AcpASKLib.AccessRecord a(global::AcpASKLib.AccessRecord A_0)
		{
			short num = (short)689700407;
			short num2 = num;
			num = (short)1975057975;
			global::AcpASKLib.AccessRecord result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1633484801;
				if (num != 0)
				{
				}
				num = (short)1367080960;
				short num3 = num;
				num = (short)1347420160;
				if (num != 0)
				{
				}
				result = null;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)1188823044;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::AcpASKLib.AccessRecord accessRecord;
							if (accessRecord.IsEqual(A_0))
							{
								num = (short)706740226;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_196;
						case 2:
						{
							global::AcpASKLib.AccessRecord accessRecord;
							result = accessRecord;
							num = (short)542048262;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)316997637;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessRecord accessRecord = enumerator.Current;
							num = (short)373686272;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 5:
							num = (short)2085486593;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_179;
						}
						IL_12B:
						num = (short)477364227;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_ED:
						goto IL_12B;
					}
					IL_179:
					IL_196:;
				}
				finally
				{
					num = (short)56623104;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1CA;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1861484546;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1FE;
						}
						IL_1CA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)741146625;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1FE:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000F318 File Offset: 0x0000D518
		internal global::AcpASKLib.AccessRecord a(string A_0)
		{
			global::AcpASKLib.AccessRecord result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)1697382403;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)510984196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						result = accessRecord;
						num = (short)236650498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_E2;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 4:
						goto IL_FF;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)714997760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessRecord accessRecord = enumerator.Current;
						num = (short)1886781446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::AcpASKLib.AccessRecord accessRecord;
						if (accessRecord.Name == A_0)
						{
							num = (short)1261240321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_93:
					num = (short)644153349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50:
					goto IL_93;
				}
				IL_E2:
				IL_FF:;
			}
			finally
			{
				num = (short)2102263810;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_169;
					case 1:
						enumerator.Dispose();
						num = (short)1965359104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_134;
						}
						continue;
					}
					IL_134:
					if (enumerator == null)
					{
						goto IL_1B4;
					}
					num = (short)662568961;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_169:
				num = (short)1768324116;
				short num3 = num;
				num = (short)1499102228;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)859963392;
					if (num != 0)
					{
					}
					break;
				}
				IL_1B4:;
			}
			num = (short)98435073;
			if (num != 0)
			{
			}
			num = (short)1645281280;
			short num4 = num;
			return result;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000F53C File Offset: 0x0000D73C
		internal string Name
		{
			get
			{
				short num = (short)1899787364;
				short num2 = num;
				num = (short)38237284;
				switch (num2 == num)
				{
				}
				num = (short)28180480;
				if (num != 0)
				{
				}
				num = (short)1059454977;
				if (num != 0)
				{
				}
				num = (short)189267968;
				short num3 = num;
				return this.name;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		internal bool a(string A_0, int A_1)
		{
			short num = (short)1449394177;
			if (num != 0)
			{
			}
			bool result = true;
			int num2 = 0;
			global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = base.Items.GetEnumerator();
			try
			{
				num = (short)1479737349;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_13B;
					case 1:
						goto IL_18E;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)378601480;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)282198019;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (enumerator.Current.Name == A_0)
						{
							num = (short)681377796;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 4:
						num = (short)2143289351;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 7:
						if (A_1 != num2)
						{
							num = (short)2039152649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 8:
						num = (short)65537;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						result = false;
						num = (short)1371602944;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BC:
					num = (short)1982070786;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_86:
					goto IL_BC;
					IL_13B:
					num2++;
					num = (short)42270726;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_18E:;
			}
			finally
			{
				num = (short)1499004930;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1FB;
					case 1:
						enumerator.Dispose();
						num = (short)1080819712;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1C3;
						}
						continue;
					}
					IL_1C3:
					if (enumerator == null)
					{
						goto IL_24A;
					}
					num = (short)385613825;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1FB:
				num = (short)1005979518;
				short num4 = num;
				num = (short)2132477822;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)992804864;
					if (num != 0)
					{
					}
					break;
				}
				IL_24A:;
			}
			num = (short)759496704;
			short num5 = num;
			return result;
		}

		// Token: 0x040000EC RID: 236
		private string name;

		// Token: 0x040000ED RID: 237
		private byte m_uNextPrimaryKeyValue = 4;
	}
}
