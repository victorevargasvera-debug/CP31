using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Fields;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x02000093 RID: 147
	public class FieldCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0005CE2C File Offset: 0x0005B02C
		internal FieldCollection()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0005CE4C File Offset: 0x0005B04C
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Fields.Field item)
		{
			int a_ = 10;
			short num = (short)167378945;
			if (num != 0)
			{
			}
			if (item == null)
			{
				num = (short)1624615960;
				short num2 = num;
				num = (short)1302572056;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)838336512;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠힢삤쪦", a_));
				}
			}
			num = (short)1862729728;
			short num3 = num;
			this.a.Add(item);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0005CF28 File Offset: 0x0005B128
		public void Clear()
		{
			short num = (short)344168547;
			short num2 = num;
			num = (short)1973983331;
			switch (num2 == num)
			{
			}
			num = (short)1956839424;
			short num3 = num;
			num = (short)1839202305;
			if (num != 0)
			{
			}
			num = (short)1597046784;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0005CFE0 File Offset: 0x0005B1E0
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Fields.Field item)
		{
			int a_ = 8;
			short num;
			if (item == null)
			{
				num = (short)621215745;
				if (num != 0)
				{
				}
				num = (short)1469500514;
				short num2 = num;
				num = (short)354274402;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)299565056;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠욢좤", a_));
				}
			}
			num = (short)266076160;
			short num3 = num;
			return this.a.Contains(item);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0005D0BC File Offset: 0x0005B2BC
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Fields.Field[] array, int arrayIndex)
		{
			short num = (short)822505294;
			short num2 = num;
			num = (short)1568239438;
			switch (num2 == num)
			{
			}
			num = (short)724369408;
			short num3 = num;
			num = (short)480706561;
			if (num != 0)
			{
			}
			num = (short)996605952;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0005D16C File Offset: 0x0005B36C
		public int Count
		{
			get
			{
				short num = (short)1289397907;
				short num2 = num;
				num = (short)1047176851;
				switch (num2 == num)
				{
				}
				num = (short)2056126464;
				short num3 = num;
				num = (short)1673330689;
				if (num != 0)
				{
				}
				num = (short)936312832;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0005D220 File Offset: 0x0005B420
		public bool IsReadOnly
		{
			get
			{
				short num = (short)372787956;
				short num2 = num;
				num = (short)148720372;
				switch (num2 == num)
				{
				}
				num = (short)2090074112;
				short num3 = num;
				num = (short)1235419137;
				if (num != 0)
				{
				}
				num = (short)900726784;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0005D2C8 File Offset: 0x0005B4C8
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Fields.Field item)
		{
			int a_ = 2;
			short num;
			if (item == null)
			{
				num = (short)1131628000;
				short num2 = num;
				num = (short)451102176;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)528941057;
					if (num != 0)
					{
					}
					num = (short)627900416;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
				}
			}
			num = (short)868679680;
			short num3 = num;
			return this.a.Remove(item);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		public global::Motorola.Acp.PackUnpack.Ish.Fields.Field Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Fields.Field> match)
		{
			int a_ = 3;
			short num = (short)312672258;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_20E;
				case 1:
					goto IL_54;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (match == null)
				{
					num = (short)1806893057;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>.Enumerator enumerator = this.a.GetEnumerator();
					num = (short)336527360;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			num = (short)1521287169;
			if (num != 0)
			{
			}
			IL_1D5:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶛ쎟쪡", a_));
			IL_20E:
			global::Motorola.Acp.PackUnpack.Ish.Fields.Field result;
			try
			{
				num = (short)1888616454;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
						result = field;
						num = (short)1528233987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1C5;
					case 2:
						goto IL_145;
					case 3:
						goto IL_161;
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1890975746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = enumerator.Current;
						num = (short)1783037957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
						if (match(field))
						{
							num = (short)509411328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					}
					goto IL_C0;
					IL_10C:
					num = (short)1736638468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0:
					num = (short)316423068;
					short num3 = num;
					num = (short)1122319260;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_145:
						num = (short)177733633;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1353908224;
						if (num != 0)
						{
						}
						goto IL_10C;
					}
				}
				IL_161:
				goto IL_213;
				IL_1C5:
				goto IL_1E9;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Fields.Field>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1D5;
			IL_1E9:
			return null;
			IL_213:
			num = (short)2009137152;
			short num4 = num;
			return result;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0005D60C File Offset: 0x0005B80C
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Fields.Field> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Fields.Field> match)
		{
			short num = (short)793072605;
			short num2 = num;
			num = (short)1174819805;
			switch (num2 == num)
			{
			}
			num = (short)1847263232;
			short num3 = num;
			num = (short)1221132289;
			if (num != 0)
			{
			}
			num = (short)291110912;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0005D6BC File Offset: 0x0005B8BC
		internal global::Motorola.Acp.PackUnpack.Ish.Fields.Field a(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_0)
		{
			short num = (short)1454071328;
			short num2 = num;
			num = (short)739794464;
			switch (num2 == num)
			{
			}
			num = (short)1189937152;
			short num3 = num;
			num = (short)598278145;
			if (num != 0)
			{
			}
			num = (short)114622464;
			if (num != 0)
			{
			}
			return this.a(A_0, 0, this.a.Count);
		}

		// Token: 0x170001A4 RID: 420
		internal global::Motorola.Acp.PackUnpack.Ish.Fields.Field this[int A_0]
		{
			get
			{
				short num = (short)636654684;
				short num2 = num;
				num = (short)916690012;
				switch (num2 == num)
				{
				}
				num = (short)673251328;
				short num3 = num;
				num = (short)1925578752;
				if (num != 0)
				{
				}
				num = (short)1781596161;
				if (num != 0)
				{
				}
				return this.a[A_0];
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0005D82C File Offset: 0x0005BA2C
		internal global::Motorola.Acp.PackUnpack.Ish.Fields.Field a(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_0, int A_1)
		{
			short num = (short)1018934198;
			short num2 = num;
			num = (short)747746230;
			switch (num2 == num)
			{
			}
			num = (short)1425604608;
			short num3 = num;
			num = (short)422510593;
			if (num != 0)
			{
			}
			num = (short)1364066304;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, this.a.Count);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
		internal global::Motorola.Acp.PackUnpack.Ish.Fields.Field a(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_0, int A_1, int A_2)
		{
			int a_ = 3;
			short num = (short)1731526669;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2F8;
				case 1:
					goto IL_179;
				case 2:
					if (A_2 < 0)
					{
						num = (short)1112473600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1784414220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
					if (field.Layout.Id == A_0.Id)
					{
						num = (short)1022951435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num3;
					num3++;
					num = (short)1391001601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_81;
				case 5:
					goto IL_154;
				case 6:
					if (A_1 < 0)
					{
						num = (short)13959173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)606666754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_179;
				case 8:
					goto IL_24A;
				case 9:
					goto IL_1D7;
				case 10:
				{
					num = (short)2059272193;
					if (num != 0)
					{
					}
					int num3;
					int num4;
					if (num3 > num4)
					{
						num = (short)589692937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Acp.PackUnpack.Ish.Fields.Field field = this.a[num3];
					num = (short)133365763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					global::Motorola.Acp.PackUnpack.Ish.Fields.Field field;
					return field;
				}
				case 12:
				{
					if (A_1 + A_2 > this.a.Count)
					{
						num = (short)740098056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4 = A_1 + A_2 - 1;
					int num3 = A_1;
					num = (short)390201351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				IL_65:
				if (A_0 == null)
				{
					num = (short)317718532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)445710342;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_179:
				num = (short)283901962;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_81:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﲙﮝ첟욡장톧얩\ud9ab\udaad", a_));
			IL_154:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ튟횡좥첧쾩풫", a_));
			IL_1D7:
			return null;
			IL_24A:
			num = (short)987584620;
			short num5 = num;
			num = (short)2023577708;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)821821440;
				if (num != 0)
				{
				}
				num = (short)1451163648;
				short num6 = num;
				break;
			}
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮캟횡", a_));
			IL_2F8:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮캟횡", a_));
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Fields.Field> GetEnumerator()
		{
			short num = (short)375983001;
			short num2 = num;
			num = (short)1204095897;
			switch (num2 == num)
			{
			}
			num = (short)903020544;
			short num3 = num;
			num = (short)408551425;
			if (num != 0)
			{
			}
			num = (short)1258881024;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1927245346;
			short num2 = num;
			num = (short)567307810;
			switch (num2 == num)
			{
			}
			num = (short)922746880;
			short num3 = num;
			num = (short)1564999681;
			if (num != 0)
			{
			}
			num = (short)1270546432;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x04000191 RID: 401
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Fields.Field> a;
	}
}
