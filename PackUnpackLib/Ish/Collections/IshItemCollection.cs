using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x0200009C RID: 156
	public class IshItemCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IshItem>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.IshItem>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.IshItem, global::Motorola.Acp.PackUnpack.Ish.IshType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.IshItem>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x00060CF4 File Offset: 0x0005EEF4
		internal IshItemCollection(global::Motorola.Acp.PackUnpack.Ish.Partition A_0)
		{
			int a_ = 5;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ튟잡쪣튥", a_));
			}
			this.a = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeItem>();
			this.b = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>>();
			this.c = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>();
			this.d = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>>();
			this.e = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>>();
			this.g = A_0;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00060D68 File Offset: 0x0005EF68
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00060E18 File Offset: 0x0005F018
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection ListItems
		{
			get
			{
				short num = (short)1584934124;
				short num2 = num;
				num = (short)999894252;
				switch (num2 == num)
				{
				}
				num = (short)967639040;
				if (num != 0)
				{
				}
				num = (short)2088828929;
				if (num != 0)
				{
				}
				num = (short)1116012544;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)722134657;
				short num2 = num;
				num = (short)957539969;
				switch (num2 == num)
				{
				}
				num = (short)1316421633;
				if (num != 0)
				{
				}
				num = (short)1124401152;
				if (num != 0)
				{
				}
				num = (short)1191444480;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> Composites
		{
			get
			{
				short num = (short)698762960;
				short num2 = num;
				num = (short)742999760;
				switch (num2 == num)
				{
				}
				num = (short)1742798849;
				if (num != 0)
				{
				}
				num = (short)1871183872;
				if (num != 0)
				{
				}
				num = (short)1236860928;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00060F74 File Offset: 0x0005F174
		internal global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> SingleInstanceComposites
		{
			get
			{
				short num = (short)294443759;
				short num2 = num;
				num = (short)1004460783;
				switch (num2 == num)
				{
				}
				num = (short)742326273;
				if (num != 0)
				{
				}
				num = (short)1013776384;
				if (num != 0)
				{
				}
				num = (short)1619001344;
				short num3 = num;
				global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.a(-2);
				a.d = this;
				return a;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0006102C File Offset: 0x0005F22C
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>> MultiInstanceComposites
		{
			get
			{
				short num = (short)1232326606;
				short num2 = num;
				num = (short)1000394702;
				switch (num2 == num)
				{
				}
				num = (short)2098659328;
				if (num != 0)
				{
				}
				num = (short)1078198273;
				if (num != 0)
				{
				}
				num = (short)1652359168;
				short num3 = num;
				global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.b b = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000610E4 File Offset: 0x0005F2E4
		internal global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> SingleInstanceLists
		{
			get
			{
				short num = (short)1927015810;
				short num2 = num;
				num = (short)1283583362;
				switch (num2 == num)
				{
				}
				num = (short)2059993089;
				if (num != 0)
				{
				}
				num = (short)544145408;
				if (num != 0)
				{
				}
				num = (short)1723269120;
				short num3 = num;
				global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.c c = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.c(-2);
				c.d = this;
				return c;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0006119C File Offset: 0x0005F39C
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>> MultiInstanceLists
		{
			get
			{
				short num = (short)248213408;
				short num2 = num;
				num = (short)1147891616;
				switch (num2 == num)
				{
				}
				num = (short)511705089;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				if (num != 0)
				{
				}
				num = (short)2074345472;
				short num3 = num;
				global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.d d = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.d(-2);
				d.d = this;
				return d;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00061254 File Offset: 0x0005F454
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> ListHeaders
		{
			get
			{
				short num = (short)1762132232;
				short num2 = num;
				num = (short)137625864;
				switch (num2 == num)
				{
				}
				num = (short)75825153;
				if (num != 0)
				{
				}
				num = (short)12779520;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000612FC File Offset: 0x0005F4FC
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> ListListlets
		{
			get
			{
				short num = (short)729979490;
				short num2 = num;
				num = (short)1944296034;
				switch (num2 == num)
				{
				}
				num = (short)501940225;
				if (num != 0)
				{
				}
				num = (short)775159808;
				if (num != 0)
				{
				}
				num = (short)1273430016;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x000613A8 File Offset: 0x0005F5A8
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType> CompositeFinder
		{
			get
			{
				short num = (short)102598396;
				short num2 = num;
				num = (short)461407996;
				switch (num2 == num)
				{
				}
				num = (short)1136394241;
				if (num != 0)
				{
				}
				num = (short)385089536;
				if (num != 0)
				{
				}
				num = (short)85655552;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00061450 File Offset: 0x0005F650
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> ListHeaderFinder
		{
			get
			{
				short num = (short)47496736;
				short num2 = num;
				num = (short)19185184;
				switch (num2 == num)
				{
				}
				num = (short)446758912;
				if (num != 0)
				{
				}
				num = (short)979959809;
				if (num != 0)
				{
				}
				num = (short)1155661824;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00061500 File Offset: 0x0005F700
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType> ListListletFinder
		{
			get
			{
				short num = (short)634603017;
				short num2 = num;
				num = (short)478561801;
				switch (num2 == num)
				{
				}
				num = (short)1682440193;
				if (num != 0)
				{
				}
				num = (short)333185024;
				if (num != 0)
				{
				}
				num = (short)1896873984;
				short num3 = num;
				return this;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000615A8 File Offset: 0x0005F7A8
		public void Add(global::Motorola.Acp.PackUnpack.Ish.IshItem item)
		{
			int a_ = 17;
			short num = (short)1306591237;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)
					{
						num = (short)489095168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2359300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_8E;
				case 3:
					goto IL_113;
				case 4:
				{
					num = (short)2016880656;
					short num3 = num;
					num = (short)386672656;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)395116544;
						if (num != 0)
						{
						}
						if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletItem)
						{
							num = (short)1093271558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					}
					break;
				}
				case 5:
					goto IL_1D;
				case 6:
					goto IL_1E2;
				case 7:
					if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeItem)
					{
						num = (short)1252720643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)799539201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_1D:
				switch (0)
				{
				case 0:
				{
					IL_4D:
					num = (short)1631125504;
					short num4 = num;
					if (item == null)
					{
						num = (short)623116290;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1060241415;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_8E:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\udea9즫쎭", a_));
			IL_D9:
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem);
			return;
			IL_113:
			num = (short)1619656705;
			if (num != 0)
			{
			}
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.CompositeItem);
			return;
			IL_1E2:
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.ListListletItem);
			return;
			IL_1F4:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000617B0 File Offset: 0x0005F9B0
		public void Clear()
		{
			short num = (short)781535269;
			short num2 = num;
			num = (short)1323190309;
			switch (num2 == num)
			{
			}
			num = (short)2007629824;
			if (num != 0)
			{
			}
			num = (short)576061441;
			if (num != 0)
			{
			}
			num = (short)1927872512;
			short num3 = num;
			this.a.Clear();
			this.b.Clear();
			this.c.Clear();
			this.d.Clear();
			this.e.Clear();
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00061894 File Offset: 0x0005FA94
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.IshItem item)
		{
			int a_ = 19;
			short num = (short)1286799365;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)
					{
						num = (short)1988952064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)683081729;
					if (num != 0)
					{
					}
					num = (short)225837060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_90;
				case 3:
					goto IL_112;
				case 4:
				{
					num = (short)1878954422;
					short num3 = num;
					num = (short)598380982;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
						num = (short)1306787840;
						if (num != 0)
						{
						}
						if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletItem)
						{
							num = (short)82444294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					}
					break;
				}
				case 5:
					goto IL_1F;
				case 6:
					goto IL_1E2;
				case 7:
					if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeItem)
					{
						num = (short)1803812867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1205469185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4F;
				IL_1F:
				switch (0)
				{
				case 0:
				{
					IL_4F:
					num = (short)496631808;
					short num4 = num;
					if (item == null)
					{
						num = (short)1467940866;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1662058503;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_90:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎩\ud8ab쮭\uddaf", a_));
			IL_D9:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem);
			IL_112:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.CompositeItem);
			IL_1E2:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.ListListletItem);
			IL_1F4:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00061A9C File Offset: 0x0005FC9C
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.IshItem[] array, int arrayIndex)
		{
			short num = (short)1402213175;
			short num2 = num;
			num = (short)1027871543;
			switch (num2 == num)
			{
			}
			num = (short)1393688577;
			if (num != 0)
			{
			}
			num = (short)1615265792;
			if (num != 0)
			{
			}
			num = (short)565444608;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00061B4C File Offset: 0x0005FD4C
		public int Count
		{
			get
			{
				short num = (short)1532941673;
				short num2 = num;
				num = (short)536532329;
				switch (num2 == num)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				num = (short)1374420992;
				if (num != 0)
				{
				}
				num = (short)293732352;
				short num3 = num;
				return this.a.Count + this.b.Count + this.c.Count + this.d.Count + this.e.Count;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00061C30 File Offset: 0x0005FE30
		public bool IsReadOnly
		{
			get
			{
				short num = (short)2008606489;
				short num2 = num;
				num = (short)782427929;
				switch (num2 == num)
				{
				}
				num = (short)1112276993;
				if (num != 0)
				{
				}
				num = (short)1236729856;
				if (num != 0)
				{
				}
				num = (short)935657472;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00061CDC File Offset: 0x0005FEDC
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.IshItem item)
		{
			int a_ = 18;
			short num = (short)103809029;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)
					{
						num = (short)254083072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1147535364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_94;
				case 3:
					goto IL_13E;
				case 4:
				{
					num = (short)1144591869;
					short num3 = num;
					num = (short)463607293;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)694157312;
						if (num != 0)
						{
						}
						if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletItem)
						{
							num = (short)810876934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					}
					break;
				}
				case 5:
					goto IL_1D;
				case 6:
					goto IL_1E7;
				case 7:
					if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeItem)
					{
						num = (short)2099380227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)734396417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_1D:
				switch (0)
				{
				case 0:
				{
					IL_4D:
					num = (short)199360512;
					short num4 = num;
					if (item == null)
					{
						num = (short)634650626;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2136145927;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_94:
			num = (short)794886145;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삨\udfaa좬슮", a_));
			IL_105:
			return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem);
			IL_13E:
			return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.CompositeItem);
			IL_1E7:
			return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.ListListletItem);
			IL_1F9:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00061EE8 File Offset: 0x000600E8
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshItem> GetEnumerator()
		{
			short num = (short)40452098;
			short num2 = num;
			num = (short)932855810;
			switch (num2 == num)
			{
			}
			num = (short)782434304;
			if (num != 0)
			{
			}
			num = (short)585236481;
			if (num != 0)
			{
			}
			num = (short)964558848;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.e e = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.e(0);
			e.c = this;
			return e;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00061FA0 File Offset: 0x000601A0
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)947440871;
			short num2 = num;
			num = (short)532139239;
			switch (num2 == num)
			{
			}
			num = (short)447283201;
			if (num != 0)
			{
			}
			num = (short)936050688;
			if (num != 0)
			{
			}
			num = (short)230621184;
			short num3 = num;
			return this.GetEnumerator();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00062050 File Offset: 0x00060250
		public void Add(global::Motorola.Acp.PackUnpack.Ish.CompositeItem item)
		{
			int a_ = 18;
			short num = (short)1367146497;
			if (num != 0)
			{
			}
			num = (short)1337720832;
			short num2 = num;
			num = (short)1161232388;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
					if (!this.b.TryGetValue(item.Name.Type, out list))
					{
						num = (short)72482821;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B1;
				}
				case 1:
					goto IL_B3;
				case 2:
					goto IL_1AC;
				case 3:
					if (item.Type.IsSingleInstance)
					{
						num = (short)1873477634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1480392704;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_99;
					}
					continue;
				case 5:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>();
					this.b.Add(item.Name.Type, list);
					num = (short)2015952902;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_16B;
				}
				IL_99:
				if (item == null)
				{
					num = (short)1235222529;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)545521667;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B3:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삨\udfaa좬슮", a_));
			IL_16B:
			goto IL_1B1;
			IL_1AC:
			this.a.Add(item.Name.Type, item);
			return;
			IL_1B1:
			num = (short)1712586684;
			short num4 = num;
			num = (short)436797372;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1AC;
			default:
			{
				num = (short)1381761024;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
				list.Add(item);
				return;
			}
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00062260 File Offset: 0x00060460
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.CompositeItem item)
		{
			int a_ = 7;
			short num = (short)709099523;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8A;
				case 1:
					goto IL_1BD;
				case 2:
					if (item.Type.IsSingleInstance)
					{
						num = (short)1676279809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)408682500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)703594496;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				}
				case 4:
				{
					if (this.b.TryGetValue(item.Name.Type, out list))
					{
						goto IL_1BF;
					}
					num = (short)834163487;
					short num4 = num;
					num = (short)1828868895;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BF;
					default:
						num = (short)312934400;
						if (num != 0)
						{
						}
						num = (short)1698103301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					return false;
				}
				IL_6F:
				if (item == null)
				{
					num = (short)1807089664;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1232011266;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8A:
			num = (short)1392181249;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풟잡즣", a_));
			IL_1BD:
			return this.a.ContainsKey(item.Name.Type);
			IL_1BF:
			return list.Contains(item);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00062434 File Offset: 0x00060634
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.CompositeItem[] array, int arrayIndex)
		{
			short num = (short)802733854;
			short num2 = num;
			num = (short)1586020126;
			switch (num2 == num)
			{
			}
			num = (short)1247084545;
			if (num != 0)
			{
			}
			num = (short)1227882496;
			if (num != 0)
			{
			}
			num = (short)519503872;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000624E0 File Offset: 0x000606E0
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.CompositeItem item)
		{
			int a_ = 10;
			short num = (short)590020610;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_D4;
				case 2:
				{
					num = (short)321191936;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				}
				case 3:
					goto IL_1BF;
				case 4:
					if (item.Type.IsSingleInstance)
					{
						num = (short)399769601;
						if (num != 0)
						{
						}
						num = (short)1271463939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1841954821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.b.TryGetValue(item.Name.Type, out list))
					{
						num = (short)554762240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				}
				IL_6D:
				if (item == null)
				{
					num = (short)617545809;
					short num4 = num;
					num = (short)1421475921;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num = (short)172556288;
						if (num != 0)
						{
						}
						num = (short)1270546433;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1872363524;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D4:
			IL_141:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠힢삤쪦", a_));
			IL_1BF:
			return this.a.Remove(item.Name.Type);
			IL_1C4:
			return list.Remove(item);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000626B8 File Offset: 0x000608B8
		void global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Clear()
		{
			short num = (short)27005428;
			short num2 = num;
			num = (short)1264456180;
			switch (num2 == num)
			{
			}
			num = (short)2104426497;
			if (num != 0)
			{
			}
			num = (short)1210908672;
			if (num != 0)
			{
			}
			num = (short)535298048;
			short num3 = num;
			this.a.Clear();
			this.b.Clear();
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0006277C File Offset: 0x0006097C
		int global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Count
		{
			get
			{
				short num = (short)304612346;
				short num2 = num;
				num = (short)898630650;
				switch (num2 == num)
				{
				}
				num = (short)843251713;
				if (num != 0)
				{
				}
				num = (short)1269497856;
				if (num != 0)
				{
				}
				num = (short)1990787072;
				short num3 = num;
				return this.a.Count + this.b.Count;
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0006283C File Offset: 0x00060A3C
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.GetEnumerator()
		{
			short num = (short)1064241406;
			short num2 = num;
			num = (short)1893140734;
			switch (num2 == num)
			{
			}
			num = (short)286851073;
			if (num != 0)
			{
			}
			num = (short)935002112;
			if (num != 0)
			{
			}
			num = (short)2055929856;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.f f = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.f(0);
			f.c = this;
			return f;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000628F8 File Offset: 0x00060AF8
		public void Add(global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem item)
		{
			int a_ = 3;
			short num = (short)1929838595;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1BF;
				case 1:
					goto IL_63;
				case 2:
				{
					num = (short)1524140450;
					short num3 = num;
					num = (short)499747234;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)356122624;
						if (num != 0)
						{
						}
						if (!this.d.TryGetValue(item.Name.Type, out list))
						{
							num = (short)1719861254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					break;
				}
				case 3:
					goto IL_1D;
				case 4:
					goto IL_200;
				case 5:
					if (item.Type.IsSingleInstance)
					{
						num = (short)421265412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2085093378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>();
					this.d.Add(item.Name.Type, list);
					num = (short)1572208640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_49;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_49:
					if (item == null)
					{
						num = (short)160235521;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)314703877;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_63:
			num = (short)677773312;
			short num4 = num;
			num = (short)1606615041;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ춟", a_));
			IL_1BF:
			goto IL_205;
			IL_200:
			this.c.Add(item.Name.Type, item);
			return;
			IL_205:
			list.Add(item);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00062B14 File Offset: 0x00060D14
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem item)
		{
			int a_ = 4;
			short num = (short)324796418;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_DB;
				case 2:
				{
					num = (short)931201024;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				}
				case 3:
					goto IL_1C6;
				case 4:
					if (item.Type.IsSingleInstance)
					{
						num = (short)1110573059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1927806981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.d.TryGetValue(item.Name.Type, out list))
					{
						num = (short)1421410304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				}
				IL_70:
				if (item == null)
				{
					num = (short)670694779;
					short num4 = num;
					num = (short)504692091;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_172;
					default:
						num = (short)1559363584;
						if (num != 0)
						{
						}
						num = (short)1359216641;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)263127044;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_DB:
			IL_172:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("爵철", a_));
			IL_1C6:
			num = (short)1739259905;
			if (num != 0)
			{
			}
			return this.c.ContainsKey(item.Name.Type);
			IL_1CB:
			return list.Contains(item);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00062CF4 File Offset: 0x00060EF4
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem[] array, int arrayIndex)
		{
			short num = (short)138865941;
			short num2 = num;
			num = (short)1183968533;
			switch (num2 == num)
			{
			}
			num = (short)338100225;
			if (num != 0)
			{
			}
			num = (short)322961408;
			if (num != 0)
			{
			}
			num = (short)1168441344;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00062DA4 File Offset: 0x00060FA4
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem item)
		{
			int a_ = 12;
			short num = (short)987234306;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_DA;
				case 2:
				{
					num = (short)794820608;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				}
				case 3:
					goto IL_1C5;
				case 4:
					if (item.Type.IsSingleInstance)
					{
						num = (short)874905603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)230490117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.d.TryGetValue(item.Name.Type, out list))
					{
						num = (short)638582784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA;
				}
				IL_70:
				if (item == null)
				{
					num = (short)608686835;
					short num4 = num;
					num = (short)1557385971;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16F;
					default:
						num = (short)1939931136;
						if (num != 0)
						{
						}
						num = (short)1996292097;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1421934596;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_DA:
			IL_16F:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢톤슦쒨", a_));
			IL_1C5:
			num = (short)973930497;
			if (num != 0)
			{
			}
			return this.c.Remove(item.Name.Type);
			IL_1CA:
			return list.Remove(item);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00062F84 File Offset: 0x00061184
		void global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Clear()
		{
			short num = (short)2078001726;
			short num2 = num;
			num = (short)1475004990;
			switch (num2 == num)
			{
			}
			num = (short)1556283393;
			if (num != 0)
			{
			}
			num = (short)158597120;
			if (num != 0)
			{
			}
			num = (short)1518927872;
			short num3 = num;
			this.c.Clear();
			this.d.Clear();
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00063044 File Offset: 0x00061244
		int global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Count
		{
			get
			{
				short num = (short)2082435352;
				short num2 = num;
				num = (short)494891288;
				switch (num2 == num)
				{
				}
				num = (short)1691746305;
				if (num != 0)
				{
				}
				num = (short)673972224;
				if (num != 0)
				{
				}
				num = (short)1849360384;
				short num3 = num;
				return this.c.Count + this.d.Count;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00063100 File Offset: 0x00061300
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.GetEnumerator()
		{
			short num = (short)1585512449;
			if (num != 0)
			{
			}
			num = (short)1244173959;
			short num2 = num;
			num = (short)509908615;
			switch (num2 == num)
			{
			}
			num = (short)1210974208;
			if (num != 0)
			{
			}
			num = (short)1055260672;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.g g = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.g(0);
			g.c = this;
			return g;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000631B4 File Offset: 0x000613B4
		public void Add(global::Motorola.Acp.PackUnpack.Ish.ListListletItem item)
		{
			int a_ = 15;
			short num = (short)1024131076;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)28308970;
					short num3 = num;
					num = (short)1162081770;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						goto IL_F1;
					}
					break;
				}
				case 1:
					goto IL_83;
				case 2:
				{
					num = (short)1489436672;
					short num4 = num;
					list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>();
					this.e.Add(item.Name.Type, list);
					num = (short)432144384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!this.e.TryGetValue(item.Name.Type, out list))
					{
						num = (short)855441410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 4:
					num = (short)1724317697;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				}
				goto IL_68;
				IL_6E:
				num = (short)632029185;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68:
				if (item == null)
				{
					goto IL_6E;
				}
				num = (short)2071592963;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_83:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾥\udca7쾩솫", a_));
			IL_F1:
			num = (short)358940672;
			if (num != 0)
			{
			}
			IL_19B:
			list.Add(item);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00063364 File Offset: 0x00061564
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.ListListletItem item)
		{
			int a_ = 16;
			short num = (short)234029058;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1419302530;
					short num3 = num;
					num = (short)1256511106;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						num = (short)504299520;
						if (num != 0)
						{
						}
						if (!this.e.TryGetValue(item.Name.Type, out list))
						{
							num = (short)73400323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					}
					break;
				}
				case 1:
					goto IL_54;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					return false;
				}
				goto IL_3D;
				IL_40:
				num = (short)677052417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (item == null)
				{
					goto IL_40;
				}
				num = (short)1818296320;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_54:
			num = (short)893779969;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캦\udda8캪사", a_));
			IL_131:
			num = (short)1638924288;
			short num4 = num;
			return list.Contains(item);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000634D4 File Offset: 0x000616D4
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.ListListletItem[] array, int arrayIndex)
		{
			short num = (short)1536163840;
			short num2 = num;
			num = (short)1787717553;
			short num3 = num;
			num = (short)2107729841;
			switch (num3 == num)
			{
			}
			num = (short)890961921;
			if (num != 0)
			{
			}
			num = (short)1748631552;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00063584 File Offset: 0x00061784
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.ListListletItem item)
		{
			int a_ = 10;
			short num = (short)661454850;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)175579893;
					short num3 = num;
					num = (short)1925391093;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						num = (short)1509556224;
						if (num != 0)
						{
						}
						if (!this.e.TryGetValue(item.Name.Type, out list))
						{
							num = (short)1668874243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					}
					break;
				}
				case 1:
					goto IL_56;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					return false;
				}
				goto IL_3E;
				IL_41:
				num = (short)428015617;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E:
				if (item == null)
				{
					goto IL_41;
				}
				num = (short)850001920;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_56:
			num = (short)1365639169;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠힢삤쪦", a_));
			IL_132:
			num = (short)1983119360;
			short num4 = num;
			return list.Remove(item);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000636F4 File Offset: 0x000618F4
		void global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Clear()
		{
			short num = (short)1209270272;
			short num2 = num;
			num = (short)214630401;
			if (num != 0)
			{
			}
			num = (short)1530694685;
			short num3 = num;
			num = (short)1914145821;
			switch (num3 == num)
			{
			}
			num = (short)818413568;
			if (num != 0)
			{
			}
			this.e.Clear();
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000637A8 File Offset: 0x000619A8
		int global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Count
		{
			get
			{
				short num = (short)1711931392;
				short num2 = num;
				num = (short)1035066215;
				short num3 = num;
				num = (short)1198644071;
				switch (num3 == num)
				{
				}
				num = (short)386465793;
				if (num != 0)
				{
				}
				num = (short)45744128;
				if (num != 0)
				{
				}
				return this.e.Count;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0006385C File Offset: 0x00061A5C
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.GetEnumerator()
		{
			short num = (short)2073624576;
			short num2 = num;
			num = (short)764411905;
			if (num != 0)
			{
			}
			num = (short)704355336;
			short num3 = num;
			num = (short)1013619720;
			switch (num3 == num)
			{
			}
			num = (short)1390215168;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.h h = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection.h(0);
			h.c = this;
			return h;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00063914 File Offset: 0x00061B14
		public global::Motorola.Acp.PackUnpack.Ish.IshItem Find(int type, int id)
		{
			short num = (short)775815168;
			short num2 = num;
			num = (short)1436083470;
			short num3 = num;
			num = (short)1482155278;
			switch (num3 == num)
			{
			}
			num = (short)892076033;
			if (num != 0)
			{
			}
			num = (short)222691328;
			if (num != 0)
			{
			}
			return this.Find(new global::Motorola.Acp.PackUnpack.Ish.IshItemName(type, id));
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000639CC File Offset: 0x00061BCC
		public global::Motorola.Acp.PackUnpack.Ish.IshItem Find(global::Motorola.Acp.PackUnpack.Ish.IshItemName name)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (ishItem != null)
					{
						num2 = (short)1313013764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					ishItem = ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>)this).Find(name);
					num2 = (short)1763835909;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_C3;
				case 2:
					return ishItem;
				case 3:
					if (ishItem != null)
					{
						num2 = (short)1567227905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				case 4:
					goto IL_5E;
				case 5:
				{
					if (ishItem == null)
					{
						ishItem = ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>)this).Find(name);
						num2 = (short)939851779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1998968773;
					short num3 = num2;
					num2 = (short)1797052357;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return ishItem;
					default:
						num2 = (short)858062848;
						if (num2 != 0)
						{
						}
						num2 = (short)70909954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			IL_5E:
			num2 = (short)210894849;
			if (num2 != 0)
			{
			}
			return ishItem;
			IL_C3:
			num2 = (short)1881604096;
			short num4 = num2;
			return ishItem;
			IL_182:
			return null;
			IL_28:
			ishItem = ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>)this).Find(name);
			num2 = (short)310181888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00063B5C File Offset: 0x00061D5C
		public global::Motorola.Acp.PackUnpack.Ish.IshItem Find(global::Motorola.Acp.PackUnpack.Ish.IshType ishType, int id)
		{
			short num = (short)1109000192;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_B8;
				case 2:
					goto IL_11B;
				case 3:
				{
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num = (short)980680705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2071332947;
					short num3 = num;
					num = (short)381421651;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_153;
					}
					break;
				}
				case 4:
					goto IL_83;
				case 5:
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num = (short)850001922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1515192323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				num = (short)2071330816;
				short num4 = num;
				if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)1895235588;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1470824453;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_83:
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>)this).Find(ishType as global::Motorola.Acp.PackUnpack.Ish.CompositeType, id);
			IL_B8:
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>)this).Find(ishType as global::Motorola.Acp.PackUnpack.Ish.ListListletType, id);
			IL_11B:
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>)this).Find(ishType as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType, id);
			IL_153:
			num = (short)984743936;
			if (num != 0)
			{
			}
			num = (short)829489153;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00063CF8 File Offset: 0x00061EF8
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IshItem> FindAll(global::Motorola.Acp.PackUnpack.Ish.IshType ishType)
		{
			short num = (short)1487097348;
			short num2 = num;
			num = (short)652430852;
			switch (num2 == num)
			{
			}
			num = (short)761724929;
			if (num != 0)
			{
			}
			num = (short)543162368;
			if (num != 0)
			{
			}
			num = (short)1401421824;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00063DA4 File Offset: 0x00061FA4
		public global::Motorola.Acp.PackUnpack.Ish.IshItem Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IshItem> match)
		{
			int a_ = 15;
			short num = (short)716570624;
			switch (num)
			{
			default:
			{
				num = (short)1617231874;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator3;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)596901892;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.IshItem result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1259929605;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem;
									result = ishItem;
									num = (short)1992228866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_102;
								case 3:
								{
									global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem;
									if (match(ishItem))
									{
										num = (short)1209597953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								case 5:
									goto IL_1A0;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1490157568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem = enumerator.Current;
									num = (short)270532611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_14B:
								num = (short)1860501510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8:
								goto IL_14B;
							}
							IL_102:
							return result;
							IL_1A0:
							goto IL_82;
						}
						finally
						{
							num = (short)582483968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 1:
									goto IL_232;
								case 2:
									num = (short)560201729;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)585170945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1145896962;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_232:;
						}
						goto IL_235;
						IL_82:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator2 = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>)this).GetEnumerator();
						num = (short)729350147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_7D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 3:
						goto IL_A1;
					case 4:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshItem result;
						try
						{
							num = (short)765198340;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1685626047;
								short num3 = num;
								num = (short)1467194559;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_54B;
								default:
									num = (short)247660544;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_54B;
									case 1:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem2;
										if (match(ishItem2))
										{
											num = (short)423100422;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										if (!enumerator3.MoveNext())
										{
											num = (short)1077149699;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem2 = enumerator3.Current;
										num = (short)404553729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)804454405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_4B1;
										}
										continue;
									case 5:
										goto IL_568;
									case 6:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem2;
										result = ishItem2;
										num = (short)395706368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_4B3:
									num = (short)990969858;
									num2 = (int)((global::System.IntPtr)num);
									break;
									IL_4B1:
									goto IL_4B3;
								}
							}
							IL_54B:
							return result;
							IL_568:
							goto IL_3D7;
						}
						finally
						{
							num = (short)260046848;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5A0;
									}
									continue;
								case 1:
									goto IL_5D7;
								case 2:
									enumerator3.Dispose();
									num = (short)1171914753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5A0:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)712572930;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5D7:;
						}
						return result;
						IL_3D7:
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>)this).GetEnumerator();
						num = (short)358547456;
						short num4 = num;
						num = (short)2015166464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_62:
					if (match == null)
					{
						num = (short)1810104321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_235:
					enumerator3 = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>)this).GetEnumerator();
					num = (short)382468100;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7D:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮥즧\udea9쾫욭", a_));
				IL_A1:
				try
				{
					num = (short)1970339844;
					num2 = (int)((global::System.IntPtr)num);
					global::Motorola.Acp.PackUnpack.Ish.IshItem result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1072300037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_309;
						case 2:
						{
							global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem3;
							if (match(ishItem3))
							{
								num = (short)1364262915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem3;
							result = ishItem3;
							num = (short)1146224641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_2AF;
							}
							continue;
						case 5:
							goto IL_365;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)984350720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.IshItem ishItem3 = enumerator2.Current;
							num = (short)962527234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_30E:
						num = (short)1718222854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AF:
						goto IL_30E;
					}
					IL_309:
					return result;
					IL_365:;
				}
				finally
				{
					num = (short)462553088;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator2;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_39A;
							}
							continue;
						case 1:
							goto IL_3D2;
						case 2:
							enumerator2.Dispose();
							num = (short)1631322113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_39A:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)1719140354;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3D2:;
				}
				return null;
			}
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000643D8 File Offset: 0x000625D8
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IshItem> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IshItem> match)
		{
			short num = (short)1817448786;
			short num2 = num;
			num = (short)469242194;
			switch (num2 == num)
			{
			}
			num = (short)117374977;
			if (num != 0)
			{
			}
			num = (short)597950464;
			if (num != 0)
			{
			}
			num = (short)2142044160;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00064484 File Offset: 0x00062684
		global::Motorola.Acp.PackUnpack.Ish.CompositeItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.Find(int type, int id)
		{
			short num = (short)1451965322;
			short num2 = num;
			num = (short)1581595530;
			switch (num2 == num)
			{
			}
			num = (short)1578434561;
			if (num != 0)
			{
			}
			num = (short)1832910848;
			if (num != 0)
			{
			}
			num = (short)325976064;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.IshItemName name = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(type, id);
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>)this).Find(name);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0006453C File Offset: 0x0006273C
		global::Motorola.Acp.PackUnpack.Ish.CompositeItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.Find(global::Motorola.Acp.PackUnpack.Ish.IshItemName name)
		{
			short num = (short)1554841600;
			switch (num)
			{
			default:
			{
				num = (short)620625922;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.CompositeItem result;
						return result;
					}
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator = list.GetEnumerator();
						num = (short)2138701827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_32;
					case 3:
						try
						{
							num = (short)519307268;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.CompositeItem result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
									result2 = compositeItem;
									num = (short)70909953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_140;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1933049859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = enumerator.Current;
									num = (short)1995636742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)621936645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_EE;
									}
									continue;
								case 5:
									goto IL_1AC;
								case 6:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
									if (compositeItem.Id == name.Id)
									{
										num = (short)492830720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F0:
								num = (short)1821507586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EE:
								goto IL_F0;
							}
							IL_140:
							return result2;
							IL_1AC:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1BC;
					case 4:
					{
						num = (short)2029453313;
						if (num != 0)
						{
						}
						global::Motorola.Acp.PackUnpack.Ish.CompositeItem result;
						if (!this.a.TryGetValue(name, out result))
						{
							goto IL_A9;
						}
						num = (short)1752473017;
						short num3 = num;
						num = (short)1014668729;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
						{
							num = (short)1267793920;
							if (num != 0)
							{
							}
							num = (short)1067646976;
							short num4 = num;
							num = (short)1395326976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_57;
					IL_32:
					switch (0)
					{
					case 0:
					{
						IL_57:
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
						if (!this.b.TryGetValue(name.Type, out list))
						{
							goto IL_1BC;
						}
						num = (short)862715905;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					continue;
					IL_1BC:
					num = (short)1721630724;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A9:
				return null;
			}
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0006480C File Offset: 0x00062A0C
		public global::Motorola.Acp.PackUnpack.Ish.CompositeItem Find(global::Motorola.Acp.PackUnpack.Ish.CompositeType ishType, int id)
		{
			int a_ = 14;
			short num = (short)1005715456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)475784853;
				short num3 = num;
				num = (short)1035724437;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1984626688;
					if (num != 0)
					{
					}
					num = (short)1235156997;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					global::Motorola.Acp.PackUnpack.Ish.CompositeItem result;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						num = (short)1804271617;
						if (num != 0)
						{
						}
						goto IL_2ED;
					case 2:
						goto IL_FE;
					case 3:
						try
						{
							num = (short)1876361220;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)339935237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
									result = compositeItem;
									num = (short)154992642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_245;
								case 3:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
									if (compositeItem.Id == id)
									{
										num = (short)186908673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_22C;
									}
									continue;
								case 5:
									goto IL_2DD;
								case 6:
								{
									global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1088094208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = enumerator.Current;
									num = (short)210829315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_288:
								num = (short)2136080390;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22C:
								goto IL_288;
							}
							IL_245:
							IL_2DD:
							return result;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2ED;
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
						if (this.b.TryGetValue(ishType.Value, out list))
						{
							num = (short)183042054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
					{
						num = (short)722599936;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_E2;
						}
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>.Enumerator enumerator = list.GetEnumerator();
						num = (short)690487299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (ishType.IsSingleInstance)
						{
							num = (short)1023737857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1707999236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E2:
					if (ishType == null)
					{
						num = (short)1279197186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = null;
					num = (short)832503815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2ED:
					this.a.TryGetValue(ishType.Value, out result);
					num = (short)1958871040;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FE:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첤풦솨ﾪ풬\udfae풰", a_));
			}
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00064B48 File Offset: 0x00062D48
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> FindAll(global::Motorola.Acp.PackUnpack.Ish.CompositeType ishType)
		{
			int a_ = 14;
			short num = (short)719323143;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1150354163;
					short num3 = num;
					num = (short)1584333555;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AE;
					default:
						num = (short)721289216;
						if (num != 0)
						{
						}
						if (this.a.ContainsKey(ishType.Value))
						{
							num = (short)198246402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					}
					break;
				}
				case 1:
					if (ishType.IsSingleInstance)
					{
						goto IL_1AE;
					}
					num = (short)1351155718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_148;
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> result;
					return result;
				}
				case 4:
					num = (short)1322778625;
					if (num != 0)
					{
					}
					num = (short)1748238336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_6A;
				case 6:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> result;
					if (this.b.TryGetValue(ishType.Value, out result))
					{
						num = (short)1630732291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				}
				IL_4E:
				if (ishType == null)
				{
					num = (short)1081737221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)430899200;
				short num4 = num;
				num = (short)2017787905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AE:
				num = (short)1306460164;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6A:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첤풦솨ﾪ풬\udfae풰", a_));
			IL_148:
			return this.a.Values;
			IL_1FC:
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00064D54 File Offset: 0x00062F54
		public global::Motorola.Acp.PackUnpack.Ish.CompositeItem Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> match)
		{
			int a_ = 8;
			short num = (short)1269104642;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)601489408;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_80;
				case 1:
					goto IL_28D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				}
				IL_64:
				if (match == null)
				{
					num = (short)342556672;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>)this).GetEnumerator();
					num = (short)1317076993;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_80:
			num = (short)1356398593;
			if (num != 0)
			{
			}
			IL_259:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삠힢욤쾦", a_));
			IL_28D:
			try
			{
				num = (short)1809973254;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.CompositeItem result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_140;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
						if (match(compositeItem))
						{
							num = (short)1763634507;
							short num4 = num;
							num = (short)176024907;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D7;
							default:
								num = (short)650575872;
								if (num != 0)
								{
								}
								num = (short)1677590530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					}
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
						result = compositeItem;
						num = (short)480837632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1EE;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)54263813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = enumerator.Current;
						num = (short)397672449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1D7;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_EE;
						}
						continue;
					}
					IL_F0:
					num = (short)1826881540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE:
					goto IL_F0;
					IL_1D7:
					num = (short)772210691;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_140:
				return result;
				IL_1EE:
				goto IL_26D;
			}
			finally
			{
				num = (short)132251650;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1817706497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_256;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_222;
						}
						continue;
					}
					IL_222:
					if (enumerator == null)
					{
						break;
					}
					num = (short)853737472;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_256:;
			}
			goto IL_259;
			IL_26D:
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00065010 File Offset: 0x00063210
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> match)
		{
			int a_ = 8;
			short num = (short)1330446338;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator;
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> list;
				switch (num2)
				{
				case 0:
					goto IL_53;
				case 1:
				{
					num = (short)1929969664;
					short num3 = num;
					try
					{
						num = (short)1113063430;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1176240129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem = enumerator.Current;
								num = (short)1749549060;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_17D;
							case 3:
								goto IL_195;
							case 4:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
								if (match(compositeItem))
								{
									num = (short)1532035077;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
								list.Add(compositeItem);
								num = (short)329671532;
								short num4 = num;
								num = (short)796484460;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_17D;
								default:
									num = (short)1462632448;
									if (num != 0)
									{
									}
									num = (short)1061683202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								continue;
							}
							IL_D4:
							num = (short)1775370240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_98:
							goto IL_D4;
							IL_17D:
							num = (short)907870211;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_195:
						return list;
					}
					finally
					{
						num = (short)1659043842;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1680277505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1FD;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1CA;
								}
								continue;
							}
							IL_1CA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)501809152;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1FD:;
					}
					goto IL_200;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (match == null)
				{
					num = (short)1038614528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_200:
				num = (short)367984641;
				if (num != 0)
				{
				}
				list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>();
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>)this).GetEnumerator();
				num = (short)1754202113;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삠힢욤쾦", a_));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000652C8 File Offset: 0x000634C8
		global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.Find(int type, int id)
		{
			short num = (short)788525660;
			short num2 = num;
			num = (short)127791708;
			switch (num2 == num)
			{
			}
			num = (short)1325793280;
			if (num != 0)
			{
			}
			num = (short)29949952;
			short num3 = num;
			num = (short)771031041;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.IshItemName name = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(type, id);
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>)this).Find(name);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00065388 File Offset: 0x00063588
		global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.Find(global::Motorola.Acp.PackUnpack.Ish.IshItemName name)
		{
			short num = (short)1328349184;
			switch (num)
			{
			default:
			{
				num = (short)2032533508;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
					switch (num2)
					{
					case 0:
					{
						num = (short)1135542272;
						short num3 = num;
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result;
						if (this.c.TryGetValue(name, out result))
						{
							num = (short)1492058114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 1:
						try
						{
							num = (short)680329222;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_16B;
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
									if (listHeaderItem.Id == name.Id)
									{
										num = (short)1901538608;
										short num4 = num;
										num = (short)98184496;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_20C;
										default:
											num = (short)1871642624;
											if (num != 0)
											{
											}
											num = (short)196149250;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 2:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
									result2 = listHeaderItem;
									num = (short)1678704640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_224;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)496304133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = enumerator.Current;
									num = (short)219873281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_20C;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_119;
									}
									continue;
								}
								IL_11B:
								num = (short)1839398916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_119:
								goto IL_11B;
								IL_20C:
								num = (short)1573978115;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16B:
							return result2;
							IL_224:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_234;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result;
						return result;
					}
					case 3:
					{
						num = (short)592379905;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1658257409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (this.d.TryGetValue(name.Type, out list))
					{
						num = (short)1467219971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_234:
					num = (short)1278017536;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				return null;
			}
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00065660 File Offset: 0x00063860
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType, int id)
		{
			int a_ = 5;
			short num = (short)1493630976;
			switch (num)
			{
			default:
			{
				num = (short)1266024449;
				if (num != 0)
				{
				}
				num = (short)993918984;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshItemName name = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(ishType.Value, id);
						num = (short)752156674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)341573638;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_153;
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
									if (listHeaderItem.Id == id)
									{
										num = (short)76190561;
										short num3 = num;
										num = (short)30118753;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1EC;
										default:
											num = (short)2079129600;
											if (num != 0)
											{
											}
											num = (short)1523384322;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 2:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
									result = listHeaderItem;
									num = (short)2078146560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_204;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1864695813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = enumerator.Current;
									num = (short)1703936001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1EC;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_FE;
									}
									continue;
								}
								IL_100:
								num = (short)161415172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FE:
								goto IL_100;
								IL_1EC:
								num = (short)304873475;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_153:
							return result;
							IL_204:
							goto IL_301;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_217;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshItemName name;
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result2;
						if (this.c.TryGetValue(name, out result2))
						{
							num = (short)482148357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					}
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
						if (this.d.TryGetValue(ishType.Value, out list))
						{
							num = (short)758906887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					}
					case 4:
						if (ishType.IsSingleInstance)
						{
							num = (short)310640640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result2;
						return result2;
					}
					case 6:
						goto IL_B6;
					case 7:
					{
						num = (short)815071232;
						short num4 = num;
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>.Enumerator enumerator = list.GetEnumerator();
						num = (short)543490049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					}
					IL_9A:
					if (ishType == null)
					{
						num = (short)988348422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)493420548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217:
					num = (short)1831141379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B6:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좟\udda3횥춧", a_));
				IL_301:
				return null;
			}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000659E8 File Offset: 0x00063BE8
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> FindAll(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType)
		{
			int a_ = 12;
			short num = (short)1425014791;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1863288753;
					short num3 = num;
					num = (short)1700759473;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D2;
					default:
						num = (short)1278607360;
						if (num != 0)
						{
						}
						if (this.c.ContainsKey(ishType.Value))
						{
							num = (short)317587458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					}
					break;
				}
				case 1:
					num = (short)547553281;
					if (num != 0)
					{
					}
					if (ishType.IsSingleInstance)
					{
						goto IL_1D2;
					}
					num = (short)663355398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_146;
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> result;
					return result;
				}
				case 4:
					num = (short)1535770624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_69;
				case 6:
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> result;
					if (this.d.TryGetValue(ishType.Value, out result))
					{
						num = (short)714670083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					continue;
				}
				IL_4F:
				if (ishType == null)
				{
					num = (short)1996619781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1807613952;
				short num4 = num;
				num = (short)91750401;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D2:
				num = (short)571211780;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_69:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢횤쾦ﶨ튪\uddac쪮", a_));
			IL_146:
			return this.c.Values;
			IL_1FA:
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00065BF0 File Offset: 0x00063DF0
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> match)
		{
			int a_ = 10;
			short num = (short)603914242;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_55;
				case 1:
					goto IL_28A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (match == null)
				{
					num = (short)1429995520;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>)this).GetEnumerator();
					num = (short)2126577664;
					short num3 = num;
					num = (short)346816513;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_55:
			IL_22D:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("철슢톤쒦솨", a_));
			IL_28A:
			try
			{
				num = (short)1667432454;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_113;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
						if (match(listHeaderItem))
						{
							num = (short)1415961246;
							short num4 = num;
							num = (short)1149426334;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1AB;
							default:
								num = (short)1934032896;
								if (num != 0)
								{
								}
								num = (short)1883963394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					}
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
						result = listHeaderItem;
						num = (short)1874657280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1C3;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1203961857;
							if (num != 0)
							{
							}
							num = (short)694747141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = enumerator.Current;
						num = (short)1389953025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1AB;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					}
					IL_9C:
					num = (short)1847918596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_9C;
					IL_1AB:
					num = (short)392232963;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_113:
				return result;
				IL_1C3:
				goto IL_241;
			}
			finally
			{
				num = (short)1707016194;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)615645185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_22A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1F7;
						}
						continue;
					}
					IL_1F7:
					if (enumerator == null)
					{
						break;
					}
					num = (short)690028544;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_22A:;
			}
			goto IL_22D;
			IL_241:
			return null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00065EAC File Offset: 0x000640AC
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> match)
		{
			int a_ = 2;
			short num = (short)1527054338;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> list;
			for (;;)
			{
				num = (short)928841728;
				short num3 = num;
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_7C;
				case 1:
					try
					{
						num = (short)1285685254;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1981612033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = enumerator.Current;
								num = (short)533987332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1A4;
							case 3:
								goto IL_1BB;
							case 4:
							{
								global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
								if (match(listHeaderItem))
								{
									num = (short)577503237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
								list.Add(listHeaderItem);
								num = (short)421903833;
								short num4 = num;
								num = (short)883342809;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1A4;
								default:
									num = (short)1866989568;
									if (num != 0)
									{
									}
									num = (short)519372802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C2;
								}
								continue;
							}
							IL_FF:
							num = (short)1849229312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C2:
							goto IL_FF;
							IL_1A4:
							num = (short)2069299203;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1BB:
						goto IL_266;
					}
					finally
					{
						num = (short)1005060098;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)146472961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_225;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1F0;
								}
								continue;
							}
							IL_1F0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1640628224;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_225:;
					}
					goto IL_228;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (match == null)
				{
					num = (short)890634240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_228:
				list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>();
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>)this).GetEnumerator();
				num = (short)1096089601;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢ﲞ즠", a_));
			IL_266:
			num = (short)1342570497;
			if (num != 0)
			{
			}
			return list;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00066164 File Offset: 0x00064364
		global::Motorola.Acp.PackUnpack.Ish.ListListletItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.Find(int type, int id)
		{
			short num = (short)1429465480;
			short num2 = num;
			num = (short)1113385352;
			switch (num2 == num)
			{
			}
			num = (short)89063425;
			if (num != 0)
			{
			}
			num = (short)914751488;
			short num3 = num;
			num = (short)1239941120;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.IshItemName name = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(type, id);
			return ((global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>)this).Find(name);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0006621C File Offset: 0x0006441C
		global::Motorola.Acp.PackUnpack.Ish.ListListletItem global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.Find(global::Motorola.Acp.PackUnpack.Ish.IshItemName name)
		{
			short num = (short)1523908608;
			switch (num)
			{
			default:
			{
				num = (short)620953601;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)563085313;
						if (num != 0)
						{
						}
						try
						{
							num = (short)99680261;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.ListListletItem result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)306341537;
									short num3 = num;
									num = (short)248342177;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1F8;
									default:
									{
										num = (short)656080896;
										if (num != 0)
										{
										}
										if (!enumerator.MoveNext())
										{
											num = (short)154075139;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = enumerator.Current;
										num = (short)1988296705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
									if (listListletItem.Id == name.Id)
									{
										num = (short)1409744902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1DD;
								case 3:
									num = (short)2099511300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1F8;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_EE;
									}
									continue;
								case 6:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
									result = listListletItem;
									num = (short)1204355074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_13A:
								num = (short)615383040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EE:
								goto IL_13A;
							}
							IL_1DD:
							return result;
							IL_1F8:
							goto IL_256;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_208;
					case 1:
					{
						num = (short)1519255552;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					}
					case 2:
						goto IL_208;
					}
					IL_78:
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
					if (this.e.TryGetValue(name.Type, out list))
					{
						num = (short)407764994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_208:
					enumerator = list.GetEnumerator();
					num = (short)827523072;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_256:
				return null;
			}
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000664A0 File Offset: 0x000646A0
		public global::Motorola.Acp.PackUnpack.Ish.ListListletItem Find(global::Motorola.Acp.PackUnpack.Ish.ListListletType ishType, int id)
		{
			int a_ = 6;
			short num = (short)443940864;
			switch (num)
			{
			default:
			{
				num = (short)488964099;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
						if (this.e.TryGetValue(ishType.Value, out list))
						{
							num = (short)1929773058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					}
					case 1:
						goto IL_98;
					case 2:
					{
						num = (short)1488650241;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Enumerator enumerator = list.GetEnumerator();
						num = (short)305790977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 4:
						goto IL_79;
					}
					IL_61:
					if (ishType == null)
					{
						num = (short)3538948;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)937492480;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_79:
				num = (short)2046033920;
				short num3 = num;
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즠\udca4힦첨", a_));
				IL_98:
				global::Motorola.Acp.PackUnpack.Ish.ListListletItem result;
				try
				{
					num = (short)969211909;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E9;
						case 1:
						{
							global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1077149702;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = enumerator.Current;
							num = (short)1663434755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
							result = listListletItem;
							num = (short)1660813312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
							if (listListletItem.Id == id)
							{
								num = (short)462159874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_298;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_193;
							}
							continue;
						case 6:
							num = (short)84934660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_195:
						num = (short)715522049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_193:
						goto IL_195;
					}
					IL_1E9:
					num = (short)1992914789;
					short num4 = num;
					num = (short)978941797;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_298:
						goto IL_DB;
					default:
						num = (short)834600960;
						if (num != 0)
						{
						}
						break;
					}
				}
				finally
				{
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				return result;
				IL_DB:
				return null;
			}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00066778 File Offset: 0x00064978
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> FindAll(global::Motorola.Acp.PackUnpack.Ish.ListListletType ishType)
		{
			int a_ = 9;
			short num = (short)514129922;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
			for (;;)
			{
				num = (short)1091476710;
				short num3 = num;
				num = (short)1828297958;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1737162752;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_13D;
					case 1:
						if (this.e.TryGetValue(ishType.Value, out list))
						{
							num = (short)1146617856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					case 2:
						num = (short)1802240001;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 3:
						goto IL_C8;
					}
					break;
				}
				IL_B0:
				if (ishType == null)
				{
					num = (short)1378287619;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)782368769;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C8:
			num = (short)1711407104;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟톡첣톧\udaa9즫", a_));
			IL_13D:
			return list.AsReadOnly();
			IL_153:
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000668DC File Offset: 0x00064ADC
		public global::Motorola.Acp.PackUnpack.Ish.ListListletItem Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> match)
		{
			int a_ = 10;
			short num = (short)1554317313;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)286326784;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_283;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
					goto IL_7D;
				}
				IL_63:
				if (match == null)
				{
					num = (short)369885186;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>)this).GetEnumerator();
					num = (short)689438720;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7D:
			IL_228:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("철슢톤쒦솨", a_));
			IL_283:
			try
			{
				num = (short)2113994757;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.ListListletItem result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10E;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)494796806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = enumerator.Current;
						num = (short)1408630787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
						result = listListletItem;
						num = (short)1374683136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
						if (match(listListletItem))
						{
							num = (short)1474297858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_16D;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C3;
						}
						continue;
					case 6:
						num = (short)905117700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C5:
					num = (short)1604648961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3:
					goto IL_C5;
				}
				IL_10E:
				return result;
				IL_16D:
				goto IL_23C;
			}
			finally
			{
				num = (short)335282177;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_225;
					case 1:
					{
						num = (short)228301287;
						short num4 = num;
						num = (short)722770407;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20F;
						default:
							num = (short)1254621184;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_1EE;
							}
							continue;
						}
						break;
					}
					case 2:
						enumerator.Dispose();
						goto IL_20F;
					}
					IL_1EE:
					if (enumerator != null)
					{
						num = (short)1694892034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_20F:
					num = (short)1360658432;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_225:;
			}
			goto IL_228;
			IL_23C:
			num = (short)792592385;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00066B84 File Offset: 0x00064D84
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> match)
		{
			int a_ = 7;
			short num = (short)1688469505;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)251133952;
				short num3 = num;
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> enumerator;
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> list;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1922170885;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)559022083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = enumerator.Current;
								num = (short)223477761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
								if (match(listListletItem))
								{
									num = (short)1094582278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)62259204;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_193;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_E8;
								}
								continue;
							case 6:
							{
								global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
								list.Add(listListletItem);
								num = (short)1580466178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_124:
							num = (short)421265408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E8:
							goto IL_124;
						}
						IL_193:
						return list;
					}
					finally
					{
						num = (short)1454833665;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_248;
							case 1:
							{
								num = (short)173009708;
								short num4 = num;
								num = (short)546040620;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_234;
								default:
									num = (short)1105264640;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_214;
									}
									continue;
								}
								break;
							}
							case 2:
								enumerator.Dispose();
								goto IL_234;
							}
							IL_214:
							if (enumerator != null)
							{
								num = (short)1323040770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
							IL_234:
							num = (short)646316032;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_248:;
					}
					goto IL_24B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
					goto IL_A3;
				}
				IL_62:
				num = (short)36175873;
				if (num != 0)
				{
				}
				if (match == null)
				{
					num = (short)1047461890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_24B:
				list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>();
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>)this).GetEnumerator();
				num = (short)1845035008;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟횡잣캥", a_));
		}

		// Token: 0x040001A2 RID: 418
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeItem> a;

		// Token: 0x040001A3 RID: 419
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.CompositeItem>> b;

		// Token: 0x040001A4 RID: 420
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> c;

		// Token: 0x040001A5 RID: 421
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem>> d;

		// Token: 0x040001A6 RID: 422
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.ListListletItem>> e;

		// Token: 0x040001A7 RID: 423
		private global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection f;

		// Token: 0x040001A8 RID: 424
		private global::Motorola.Acp.PackUnpack.Ish.Partition g;
	}
}
