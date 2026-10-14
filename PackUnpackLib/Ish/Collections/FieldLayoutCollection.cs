using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x02000097 RID: 151
	public class FieldLayoutCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout>
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x0005EA74 File Offset: 0x0005CC74
		internal FieldLayoutCollection(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout A_0)
		{
			int a_ = 0;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠", a_));
			}
			this.c = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutPositionComparer();
			this.a = new global::System.Collections.Generic.SortedList<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout>(this.c);
			this.b = A_0;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0005EACC File Offset: 0x0005CCCC
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout Parent
		{
			get
			{
				short num = (short)553899584;
				short num2 = num;
				num = (short)1091491392;
				switch (num2 == num)
				{
				}
				num = (short)1590951937;
				if (num != 0)
				{
				}
				num = (short)45285376;
				if (num != 0)
				{
				}
				num = (short)1011482624;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0005EB78 File Offset: 0x0005CD78
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout item)
		{
			int a_ = 2;
			short num = (short)1084948482;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A7;
				case 1:
					num = (short)927727617;
					if (num != 0)
					{
					}
					if (item.Parent != null)
					{
						num = (short)1273233412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)530972677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					goto IL_60;
				case 4:
					goto IL_191;
				case 5:
					if (item.Offset + item.Size > this.b.Size)
					{
						num = (short)434896896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				}
				IL_45:
				if (item == null)
				{
					num = (short)2023882755;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1939996673;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_60:
			num = (short)755317396;
			short num3 = num;
			num = (short)1239628436;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A7:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
			default:
				num = (short)815464448;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
			}
			IL_191:
			num = (short)1148452864;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
			IL_1C0:
			item.Parent = this.b;
			this.a.Add(item.Id, item);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0005ED64 File Offset: 0x0005CF64
		public void Clear()
		{
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator = this.a.Values.GetEnumerator();
			short num;
			try
			{
				num = (short)1423179777;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						continue;
					case 2:
						num = (short)925106176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1959788546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.Parent = null;
						num = (short)1991442435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_70:
					num = (short)203620356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B:
					goto IL_70;
				}
				IL_BB:;
			}
			finally
			{
				num = (short)1313210369;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_179;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_F1;
						}
						continue;
					case 2:
						for (;;)
						{
							enumerator.Dispose();
							num = (short)412531067;
							short num3 = num;
							num = (short)64076155;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_14A;
							}
						}
						IL_14A:
						num = (short)1593442304;
						if (num != 0)
						{
						}
						num = (short)34209792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F1:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1223360514;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179:;
			}
			num = (short)933822465;
			if (num != 0)
			{
			}
			num = (short)2061107200;
			short num4 = num;
			this.a.Clear();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0005EF5C File Offset: 0x0005D15C
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout item)
		{
			int a_ = 12;
			short num = (short)1048903681;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1425801216;
					short num3 = num;
					num = (short)1232076801;
					if (num != 0)
					{
					}
					if (item.Parent == this.b)
					{
						goto IL_14D;
					}
					num = (short)1864685347;
					short num4 = num;
					num = (short)1995691811;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num = (short)2127429632;
						if (num != 0)
						{
						}
						num = (short)45940738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					return false;
				case 3:
					goto IL_54;
				}
				IL_3D:
				if (item == null)
				{
					num = (short)957546499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				num = (short)267583488;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_54:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢톤슦쒨", a_));
			IL_14D:
			return this.a.ContainsKey(item.Id);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout[] array, int arrayIndex)
		{
			short num = (short)1217320508;
			short num2 = num;
			num = (short)498849340;
			switch (num2 == num)
			{
			}
			num = (short)341770240;
			if (num != 0)
			{
			}
			num = (short)328138753;
			if (num != 0)
			{
			}
			num = (short)1649541120;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0005F178 File Offset: 0x0005D378
		public int Count
		{
			get
			{
				short num = (short)1308098561;
				if (num != 0)
				{
				}
				num = (short)488992173;
				short num2 = num;
				num = (short)1079930285;
				switch (num2 == num)
				{
				}
				num = (short)746913792;
				if (num != 0)
				{
				}
				num = (short)597819392;
				short num3 = num;
				return this.a.Count;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0005F230 File Offset: 0x0005D430
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1442328668;
				short num2 = num;
				num = (short)1074737244;
				switch (num2 == num)
				{
				}
				num = (short)1915944960;
				if (num != 0)
				{
				}
				num = (short)1564540929;
				if (num != 0)
				{
				}
				num = (short)402391040;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0005F2DC File Offset: 0x0005D4DC
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout item)
		{
			int a_ = 14;
			short num = (short)911736833;
			if (num != 0)
			{
			}
			num = (short)2081161217;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (item.Parent == this.b)
					{
						goto IL_15F;
					}
					num = (short)1971110772;
					short num3 = num;
					num = (short)514507636;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					default:
						num = (short)1992491008;
						if (num != 0)
						{
						}
						num = (short)1317339138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					goto IL_146;
				case 3:
					goto IL_7C;
				}
				IL_65:
				if (item == null)
				{
					num = (short)1089470467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_95:
				num = (short)1787625472;
				short num4 = num;
				num = (short)765657088;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첤펦첨욪", a_));
			IL_146:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첤펦첨욪", a_));
			IL_15F:
			item.Parent = null;
			return this.a.Remove(item.Id);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0005F460 File Offset: 0x0005D660
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> GetEnumerator()
		{
			short num = (short)1721883755;
			short num2 = num;
			num = (short)799399019;
			switch (num2 == num)
			{
			}
			num = (short)1378680833;
			if (num != 0)
			{
			}
			num = (short)1245970432;
			if (num != 0)
			{
			}
			num = (short)1363345408;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0005F514 File Offset: 0x0005D714
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1705844050;
			short num2 = num;
			num = (short)17702226;
			switch (num2 == num)
			{
			}
			num = (short)926089216;
			if (num != 0)
			{
			}
			num = (short)760479745;
			if (num != 0)
			{
			}
			num = (short)1384841216;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection.b b = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection.b(0);
			b.c = this;
			return b;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> match)
		{
			int a_ = 11;
			short num = (short)1757609985;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_292;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					goto IL_55;
				}
				IL_3A:
				if (match == null)
				{
					num = (short)2049048578;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)8126464;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator = this.a.Values.GetEnumerator();
					num = (short)963182592;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_55:
			IL_203:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾡얣튥쮧슩", a_));
			IL_292:
			try
			{
				num = (short)1538654211;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1404239878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout = enumerator.Current;
						num = (short)335740929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout;
						if (match(fieldLayout))
						{
							num = (short)692912132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_E7;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 4:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout;
						result = fieldLayout;
						num = (short)7929858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_144;
					case 6:
						num = (short)1307181061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9C:
					num = (short)1973354496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_9C;
				}
				IL_E7:
				return result;
				IL_144:
				goto IL_217;
			}
			finally
			{
				num = (short)292159489;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_200;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_179;
						}
						continue;
					case 2:
						for (;;)
						{
							enumerator.Dispose();
							num = (short)1734820512;
							short num4 = num;
							num = (short)786907808;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1D3;
							}
						}
						IL_1D3:
						num = (short)1906442240;
						if (num != 0)
						{
						}
						num = (short)219807744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_179:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1355743234;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_200:;
			}
			goto IL_203;
			IL_217:
			num = (short)288555009;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0005F880 File Offset: 0x0005DA80
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> match)
		{
			short num = (short)1340142276;
			short num2 = num;
			num = (short)1261433540;
			switch (num2 == num)
			{
			}
			num = (short)2090532865;
			if (num != 0)
			{
			}
			num = (short)1069678592;
			if (num != 0)
			{
			}
			num = (short)381091840;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001A8 RID: 424
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout this[int A_0]
		{
			get
			{
				short num = (short)1998092704;
				short num2 = num;
				num = (short)925268384;
				switch (num2 == num)
				{
				}
				num = (short)1256456193;
				if (num != 0)
				{
				}
				num = (short)1806630912;
				if (num != 0)
				{
				}
				num = (short)879427584;
				short num3 = num;
				return this.a.Values[A_0];
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout b(int A_0)
		{
			short num = (short)1218530055;
			short num2 = num;
			num = (short)1197558535;
			switch (num2 == num)
			{
			}
			num = (short)1030225921;
			if (num != 0)
			{
			}
			num = (short)401670144;
			if (num != 0)
			{
			}
			num = (short)939655168;
			short num3 = num;
			return this.a(A_0, 7);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0005FAA4 File Offset: 0x0005DCA4
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout a(int A_0, int A_1)
		{
			global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout result;
			short num;
			for (;;)
			{
				int key = (this.b.Parent.IshTypes[0].Value & 65535) | (int)((int)this.b.AreaType << 16 & (global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType)536608768) | (A_0 << 18 & 536608768) | A_1 << 29;
				if (!this.a.TryGetValue(key, out result))
				{
					goto IL_F9;
				}
				num = (short)4431120;
				short num2 = num;
				num = (short)23108880;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_90;
				}
			}
			IL_90:
			num = (short)2127101952;
			if (num != 0)
			{
			}
			num = (short)972685312;
			short num3 = num;
			num = (short)2073690113;
			if (num != 0)
			{
			}
			return result;
			IL_F9:
			return null;
		}

		// Token: 0x04000197 RID: 407
		private global::System.Collections.Generic.SortedList<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> a;

		// Token: 0x04000198 RID: 408
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout b;

		// Token: 0x04000199 RID: 409
		private global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutPositionComparer c;
	}
}
