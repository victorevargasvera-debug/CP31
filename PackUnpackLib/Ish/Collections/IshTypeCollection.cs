using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000A7 RID: 167
	public class IshTypeCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IshType>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.IshType>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.IshType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.IshType>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletType>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletType>, global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletType>
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x0006DBE0 File Offset: 0x0006BDE0
		internal IshTypeCollection()
		{
			this.a = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType>();
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>();
			this.c = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>();
			this.d = null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0006DC1C File Offset: 0x0006BE1C
		internal IshTypeCollection(global::Motorola.Acp.PackUnpack.Ish.Partition A_0)
		{
			int a_ = 15;
			this..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횥즧\ud8a9즫삭쒯", a_));
			}
			this.d = A_0;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0006DC58 File Offset: 0x0006BE58
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeType> Composites
		{
			get
			{
				short num = (short)1419501586;
				short num2 = num;
				num = (short)845668370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292369920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240975873;
				if (num != 0)
				{
				}
				num = (short)1975844864;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0006DD00 File Offset: 0x0006BF00
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> ListHeaders
		{
			get
			{
				short num = (short)328503149;
				short num2 = num;
				num = (short)319524717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1490812928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266076161;
				if (num != 0)
				{
				}
				num = (short)919273472;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0006DDAC File Offset: 0x0006BFAC
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletType> ListListlets
		{
			get
			{
				short num = (short)1327403762;
				short num2 = num;
				num = (short)847352562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)400949248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950351361;
				if (num != 0)
				{
				}
				num = (short)826998784;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0006DE54 File Offset: 0x0006C054
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeType> CompositeFinder
		{
			get
			{
				short num = (short)680209846;
				short num2 = num;
				num = (short)1672687030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)544800768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)936771585;
				if (num != 0)
				{
				}
				num = (short)635961344;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0006DF00 File Offset: 0x0006C100
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> ListHeaderFinder
		{
			get
			{
				short num = (short)1941736165;
				short num2 = num;
				num = (short)1941670629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578565632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788149761;
				if (num != 0)
				{
				}
				num = (short)209321984;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0006DFAC File Offset: 0x0006C1AC
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletType> ListListletFinder
		{
			get
			{
				short num = (short)321953288;
				short num2 = num;
				num = (short)1556848136;
				switch (num2 == num)
				{
				default:
				{
					num = (short)440270848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)80871425;
				if (num != 0)
				{
				}
				num = (short)2140209152;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0006E058 File Offset: 0x0006C258
		public void Add(global::Motorola.Acp.PackUnpack.Ish.IshType item)
		{
			short num = (short)637009925;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1485373441;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_84;
				case 1:
				{
					if (!(item is global::Motorola.Acp.PackUnpack.Ish.ListListletType))
					{
						goto IL_19E;
					}
					num = (short)17935185;
					short num3 = num;
					num = (short)788245329;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						num = (short)1744371712;
						if (num != 0)
						{
						}
						num = (short)100990979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_199;
				case 3:
					goto IL_10A;
				case 4:
					goto IL_14C;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				}
				IL_64:
				if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)993787904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)311492612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14C:
				num = (short)673316864;
				short num4 = num;
				if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
				{
					num = (short)336789506;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)781844481;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_84:
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.CompositeType);
			return;
			IL_10A:
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.ListListletType);
			return;
			IL_199:
			this.Add(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType);
			return;
			IL_19E:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0006E208 File Offset: 0x0006C408
		public void Clear()
		{
			short num = (short)1588888124;
			short num2 = num;
			num = (short)1293124156;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1957822464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2083717121;
			if (num != 0)
			{
			}
			num = (short)1183645696;
			if (num != 0)
			{
			}
			this.a.Clear();
			this.b.Clear();
			this.c.Clear();
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0006E2D8 File Offset: 0x0006C4D8
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.IshType item)
		{
			short num = (short)207421445;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5C;
				case 1:
				{
					if (!(item is global::Motorola.Acp.PackUnpack.Ish.ListListletType))
					{
						goto IL_19B;
					}
					num = (short)1434413054;
					short num3 = num;
					num = (short)2132305918;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14B;
					default:
						num = (short)892731393;
						if (num != 0)
						{
						}
						num = (short)1853227008;
						if (num != 0)
						{
						}
						num = (short)1483997187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_196;
				case 3:
					goto IL_10B;
				case 4:
					goto IL_14B;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)1889271808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1394212868;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14B:
				num = (short)1663041536;
				short num4 = num;
				if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
				{
					num = (short)659095554;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1116405761;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5C:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.CompositeType);
			IL_10B:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.ListListletType);
			IL_196:
			return this.Contains(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType);
			IL_19B:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0006E488 File Offset: 0x0006C688
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.IshType[] array, int arrayIndex)
		{
			short num = (short)974568767;
			short num2 = num;
			num = (short)893697343;
			switch (num2 == num)
			{
			default:
			{
				num = (short)525664256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1398341632;
			if (num != 0)
			{
			}
			num = (short)239599617;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0006E534 File Offset: 0x0006C734
		public int Count
		{
			get
			{
				short num = (short)101275348;
				short num2 = num;
				num = (short)1393710804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)148045824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586940417;
				if (num != 0)
				{
				}
				num = (short)540147712;
				if (num != 0)
				{
				}
				return this.a.Count + this.b.Count + this.c.Count;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0006E600 File Offset: 0x0006C800
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1348684418;
				short num2 = num;
				num = (short)2051820162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14942208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127809025;
				if (num != 0)
				{
				}
				num = (short)1638268928;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0006E6AC File Offset: 0x0006C8AC
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.IshType item)
		{
			int a_ = 17;
			short num = (short)951844871;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B3;
				case 1:
					goto IL_1E8;
				case 2:
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num = (short)1282277376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1241841670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (item is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num = (short)1690501125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)59113474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_68;
				case 5:
					goto IL_162;
				case 6:
				{
					num = (short)1300692992;
					short num3 = num;
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num = (short)1515192321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
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
				if (item == null)
				{
					num = (short)1005191172;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1031995395;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_68:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욧\udfa9삫슭", a_));
			IL_B3:
			num = (short)170131457;
			if (num != 0)
			{
			}
			num = (short)2048425451;
			short num4 = num;
			num = (short)1208253931;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1FA:
				throw new global::System.InvalidCastException();
			default:
				num = (short)97320960;
				if (num != 0)
				{
				}
				return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType);
			}
			IL_162:
			return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.CompositeType);
			IL_1E8:
			return this.Remove(item as global::Motorola.Acp.PackUnpack.Ish.ListListletType);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> GetEnumerator()
		{
			short num = (short)1407411392;
			short num2 = num;
			num = (short)1693803712;
			switch (num2 == num)
			{
			default:
			{
				num = (short)403243008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)505675777;
			if (num != 0)
			{
			}
			num = (short)1862729728;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0006E96C File Offset: 0x0006CB6C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1404640375;
			short num2 = num;
			num = (short)1275731063;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1975975936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)352845824;
			if (num != 0)
			{
			}
			num = (short)1938751489;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0006EA1C File Offset: 0x0006CC1C
		public void Add(global::Motorola.Acp.PackUnpack.Ish.CompositeType item)
		{
			int a_ = 6;
			short num = (short)330039302;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (item.Partition != null)
					{
						num = (short)902430722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					item.Partition = this.d;
					num = (short)1257308164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_8E;
				case 2:
					goto IL_DA;
				case 3:
					num = (short)1334968320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_13D;
				case 5:
					if (this.d != null)
					{
						num = (short)603455491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				num = (short)1725169665;
				if (num != 0)
				{
				}
				if (item == null)
				{
					num = (short)517734401;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1185415173;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8E:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춠쾢", a_));
			IL_DA:
			num = (short)402718720;
			short num3 = num;
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠캢", a_));
			IL_13D:
			num = (short)799845300;
			short num4 = num;
			num = (short)1764338612;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1051721728;
				if (num != 0)
				{
				}
				break;
			}
			IL_1C5:
			this.a.Add(item.Value, item);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0006EC00 File Offset: 0x0006CE00
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.CompositeType item)
		{
			int a_ = 5;
			if (item != null)
			{
				short num = (short)1110376448;
				short num2 = num;
				num = (short)2071845785;
				short num3 = num;
				num = (short)401005465;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1970470912;
					if (num != 0)
					{
					}
					num = (short)1301151745;
					if (num != 0)
					{
					}
					return this.a.ContainsKey(item.Value);
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첟캡", a_));
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0006ECE0 File Offset: 0x0006CEE0
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.CompositeType[] array, int arrayIndex)
		{
			short num = (short)1551079718;
			short num2 = num;
			num = (short)300980518;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1357381632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)229113856;
			if (num != 0)
			{
			}
			num = (short)2075131905;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0006ED90 File Offset: 0x0006CF90
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.CompositeType item)
		{
			int a_ = 2;
			short num = (short)2137260038;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AE;
				case 1:
					goto IL_65;
				case 2:
				{
					num = (short)16121856;
					short num3 = num;
					if (this.d != null)
					{
						num = (short)973209604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
				}
				case 3:
					num = (short)1211105282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					item.Partition = null;
					num = (short)1388576768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.a.Remove(item.Value))
					{
						num = (short)1148911619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (item == null)
				{
					num = (short)573308929;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)558694405;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_65:
			num = (short)418906113;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
			IL_AE:
			IL_129:
			num = (short)2011087399;
			short num4 = num;
			num = (short)1565311527;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num = (short)1863909376;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0006EF5C File Offset: 0x0006D15C
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeType> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.CompositeType>.GetEnumerator()
		{
			short num = (short)1622707737;
			short num2 = num;
			num = (short)248679961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1342046208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1977221121;
			if (num != 0)
			{
			}
			num = (short)879951872;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.b b = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.b(0);
			b.c = this;
			return b;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0006F014 File Offset: 0x0006D214
		public void Add(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType item)
		{
			int a_ = 1;
			short num = (short)232849414;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (item.Partition != null)
					{
						num = (short)1160445954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					item.Partition = this.d;
					num = (short)270794756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_8A;
				case 2:
					goto IL_D6;
				case 3:
					num = (short)1210056704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_13A;
				case 5:
					if (this.d != null)
					{
						num = (short)170328067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (item == null)
				{
					num = (short)2079522817;
					if (num != 0)
					{
					}
					num = (short)1949302785;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1175715845;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8A:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
			IL_D6:
			num = (short)238813184;
			short num3 = num;
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("鍊", a_));
			IL_13A:
			num = (short)887953313;
			short num4 = num;
			num = (short)152311713;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1651310592;
				if (num != 0)
				{
				}
				break;
			}
			IL_1C3:
			this.b.Add(item.Value, item);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType item)
		{
			int a_ = 3;
			short num;
			for (;;)
			{
				num = (short)858980353;
				if (num != 0)
				{
				}
				if (item != null)
				{
					goto IL_BD;
				}
				num = (short)313917440;
				short num2 = num;
				num = (short)242531647;
				short num3 = num;
				num = (short)1584774463;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_94;
				}
			}
			IL_94:
			num = (short)966918144;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첟", a_));
			IL_BD:
			return this.b.ContainsKey(item.Value);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType[] array, int arrayIndex)
		{
			short num = (short)1565437323;
			short num2 = num;
			num = (short)855682443;
			switch (num2 == num)
			{
			}
			num = (short)1309802496;
			short num3 = num;
			num = (short)1528758272;
			if (num != 0)
			{
			}
			num = (short)1744633857;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0006F380 File Offset: 0x0006D580
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType item)
		{
			int a_ = 9;
			short num = (short)1727987714;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					item.Partition = null;
					num = (short)1576599557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.d != null)
					{
						num = (short)1294336000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					goto IL_65;
				case 4:
					if (this.b.Remove(item.Value))
					{
						num = (short)183566342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					return true;
				case 6:
				{
					num = (short)1338900481;
					if (num != 0)
					{
					}
					num = (short)2056847360;
					short num3 = num;
					num = (short)551425901;
					short num4 = num;
					num = (short)1481447277;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						num = (short)251527168;
						if (num != 0)
						{
						}
						num = (short)1595736065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_49;
				IL_4F:
				num = (short)1600126979;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49:
				if (item == null)
				{
					goto IL_4F;
				}
				num = (short)1519583236;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_65:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캟힡좣쪥", a_));
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0006F540 File Offset: 0x0006D740
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.GetEnumerator()
		{
			short num = (short)1913546362;
			short num2 = num;
			num = (short)34498170;
			switch (num2 == num)
			{
			}
			num = (short)2137063424;
			short num3 = num;
			num = (short)1107623937;
			if (num != 0)
			{
			}
			num = (short)349765632;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.c c = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.c(0);
			c.c = this;
			return c;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0006F5F8 File Offset: 0x0006D7F8
		public void Add(global::Motorola.Acp.PackUnpack.Ish.ListListletType item)
		{
			int a_ = 17;
			short num = (short)1588264962;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					goto IL_B0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 3:
					goto IL_65;
				case 4:
					if (this.d != null)
					{
						num = (short)516947974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				case 5:
					if (item.Partition != null)
					{
						num = (short)2095775745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					item.Partition = this.d;
					num = (short)747700224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)487849985;
					if (num != 0)
					{
					}
					num = (short)1503526912;
					short num3 = num;
					num = (short)663647007;
					short num4 = num;
					num = (short)1127117599;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						num = (short)1263927296;
						if (num != 0)
						{
						}
						num = (short)1971650565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4B;
				IL_51:
				num = (short)122421251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B:
				if (item == null)
				{
					goto IL_51;
				}
				num = (short)1114308612;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_65:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욧\udfa9삫슭", a_));
			IL_B0:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\udea9즫쎭", a_));
			IL_EA:
			IL_1CB:
			this.c.Add(item.Value, item);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0006F7E4 File Offset: 0x0006D9E4
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.ListListletType item)
		{
			int a_ = 11;
			short num;
			while (item == null)
			{
				num = (short)1483774007;
				short num2 = num;
				num = (short)280336439;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)71761920;
					short num3 = num;
					break;
				}
				}
				num = (short)517931008;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첡톣쪥쒧", a_));
			}
			num = (short)1233059841;
			if (num != 0)
			{
			}
			return this.c.ContainsKey(item.Value);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.ListListletType[] array, int arrayIndex)
		{
			short num = (short)334888961;
			if (num != 0)
			{
			}
			num = (short)1597562824;
			short num2 = num;
			num = (short)305586120;
			switch (num2 == num)
			{
			default:
			{
				num = (short)145031168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1070333952;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0006F978 File Offset: 0x0006DB78
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.ListListletType item)
		{
			int a_ = 14;
			short num = (short)1358692354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					item.Partition = null;
					num = (short)1054605317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1542258689;
					if (num != 0)
					{
					}
					if (this.d != null)
					{
						num = (short)1373569024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					goto IL_63;
				case 4:
					if (this.c.Remove(item.Value))
					{
						num = (short)533266438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					return true;
				case 6:
				{
					num = (short)1260519424;
					short num3 = num;
					num = (short)707886112;
					short num4 = num;
					num = (short)45317152;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						num = (short)1827602432;
						if (num != 0)
						{
						}
						num = (short)2073886721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_49;
				IL_4F:
				num = (short)348454915;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49:
				if (item == null)
				{
					goto IL_4F;
				}
				num = (short)418250756;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_63:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮤튦얨잪", a_));
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0006FB3C File Offset: 0x0006DD3C
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListListletType> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.ListListletType>.GetEnumerator()
		{
			short num = (short)1334644478;
			short num2 = num;
			num = (short)1041370878;
			switch (num2 == num)
			{
			}
			num = (short)1207500800;
			short num3 = num;
			num = (short)156631041;
			if (num != 0)
			{
			}
			num = (short)927531008;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.d d = new global::Motorola.Acp.PackUnpack.Ish.Collections.IshTypeCollection.d(0);
			d.c = this;
			return d;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
		public global::Motorola.Acp.PackUnpack.Ish.IshType Find(int value)
		{
			short num = (short)300548097;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.ListListletType result;
			global::Motorola.Acp.PackUnpack.Ish.CompositeType result3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c.TryGetValue(value, out result))
					{
						num = (short)1966800898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_193;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
				{
					num = (short)1086193665;
					if (num != 0)
					{
					}
					num = (short)736474432;
					short num3 = num;
					num = (short)955561280;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						goto IL_109;
					}
					break;
				}
				case 3:
				{
					global::Motorola.Acp.PackUnpack.Ish.ListHeaderType result2;
					if (this.b.TryGetValue(value, out result2))
					{
						num = (short)1239810053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1018494976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return result3;
				case 5:
				{
					global::Motorola.Acp.PackUnpack.Ish.ListHeaderType result2;
					return result2;
				}
				}
				IL_3C:
				if (this.a.TryGetValue(value, out result3))
				{
					num = (short)772079620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14C:
				num = (short)696516611;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result3;
			IL_109:
			num = (short)1711931392;
			if (num != 0)
			{
			}
			num = (short)425459712;
			short num4 = num;
			return result;
			IL_193:
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0006FD98 File Offset: 0x0006DF98
		public global::Motorola.Acp.PackUnpack.Ish.IshType Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IshType> match)
		{
			int a_ = 2;
			short num = (short)147587072;
			switch (num)
			{
			default:
			{
				num = (short)2073427969;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.ValueCollection.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_AB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.IshType result;
						try
						{
							num = (short)678100994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType;
									result = compositeType;
									num = (short)1779433476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType;
									if (match(compositeType))
									{
										num = (short)294322176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_415;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)792920069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType = enumerator.Current;
									num = (short)1728249857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_4A9;
								case 5:
									num = (short)1808400390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_4C6;
								}
								IL_417:
								num = (short)1797783555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_415:
								goto IL_417;
							}
							IL_4A9:
							return result;
							IL_4C6:
							goto IL_37A;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						return result;
						IL_37A:
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator2 = this.b.Values.GetEnumerator();
						num = (short)573767684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_7E;
					case 4:
					{
						num = (short)617152512;
						short num3 = num;
						try
						{
							num = (short)97910786;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.IshType result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)485818372;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = enumerator2.Current;
									num = (short)982515717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									result = listHeaderType;
									num = (short)1793654787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F4;
									}
									continue;
								case 3:
									goto IL_10E;
								case 4:
									num = (short)826212358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
									if (match(listHeaderType))
									{
										num = (short)1083441153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_1A7;
								}
								IL_153:
								num = (short)1353515008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4:
								goto IL_153;
							}
							IL_10E:
							return result;
							IL_1A7:
							goto IL_83;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_1BA;
						IL_83:
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator3 = this.c.Values.GetEnumerator();
						num = (short)923533312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_63:
					if (match == null)
					{
						num = (short)700973059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1BA:
					enumerator = this.a.Values.GetEnumerator();
					num = (short)1075707905;
					if (num != 0)
					{
					}
					num = (short)191627266;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7E:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢ﲞ즠", a_));
				IL_AB:
				try
				{
					num = (short)376766466;
					num2 = (int)((global::System.IntPtr)num);
					global::Motorola.Acp.PackUnpack.Ish.IshType result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							IL_329:
							global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator3;
							if (!enumerator3.MoveNext())
							{
								num = (short)2097414148;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType = enumerator3.Current;
							num = (short)1385431043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2C0;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_266;
							}
							continue;
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
							if (match(listListletType))
							{
								num = (short)7274501;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)160563206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
							result = listListletType;
							num = (short)2078343169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_368;
						}
						IL_2C5:
						num = (short)820723708;
						short num4 = num;
						num = (short)740179964;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_329;
						default:
							num = (short)240254976;
							if (num != 0)
							{
							}
							num = (short)1352859648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_266:
						goto IL_2C5;
					}
					IL_2C0:
					return result;
					IL_368:;
				}
				finally
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator3;
					((global::System.IDisposable)enumerator3).Dispose();
				}
				return null;
			}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000702CC File Offset: 0x0006E4CC
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IshType> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IshType> match)
		{
			short num = (short)1056496266;
			short num2 = num;
			num = (short)27712138;
			switch (num2 == num)
			{
			}
			num = (short)923271168;
			short num3 = num;
			num = (short)1831600129;
			if (num != 0)
			{
			}
			num = (short)2038824960;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0007037C File Offset: 0x0006E57C
		global::Motorola.Acp.PackUnpack.Ish.CompositeType global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.CompositeType>.Find(int value)
		{
			global::Motorola.Acp.PackUnpack.Ish.CompositeType result;
			while (this.a.TryGetValue(value, out result))
			{
				short num = (short)1893269505;
				if (num != 0)
				{
				}
				num = (short)155254784;
				short num2 = num;
				num = (short)1576220480;
				short num3 = num;
				num = (short)655308608;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1865547776;
					if (num != 0)
					{
					}
					return result;
				}
			}
			return null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0007043C File Offset: 0x0006E63C
		public global::Motorola.Acp.PackUnpack.Ish.CompositeType Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.CompositeType> match)
		{
			int a_ = 18;
			short num = (short)1871904769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1054670848;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_7D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
				{
					try
					{
						num = (short)893583362;
						num2 = (int)((global::System.IntPtr)num);
						global::Motorola.Acp.PackUnpack.Ish.CompositeType result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType;
								if (match(compositeType))
								{
									num = (short)1560281092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_10F;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C2;
								}
								continue;
							case 3:
							{
								global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.ValueCollection.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)134021125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType = enumerator.Current;
								num = (short)1945042944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType;
								result = compositeType;
								num = (short)1294073857;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)1841233926;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_16E;
							}
							IL_C4:
							num = (short)1718157315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C2:
							goto IL_C4;
						}
						IL_10F:
						return result;
						IL_16E:
						num = (short)1110507521;
						if (num != 0)
						{
						}
						goto IL_1BA;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.ValueCollection.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1A6;
					IL_1BA:
					num = (short)164120639;
					short num4 = num;
					num = (short)1547847743;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1EF;
					}
					break;
				}
				}
				IL_62:
				if (match == null)
				{
					num = (short)625082368;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.ValueCollection.Enumerator enumerator = this.a.Values.GetEnumerator();
					num = (short)1489043458;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7D:
			IL_1A6:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒨쪪\ud9ac첮\ud9b0", a_));
			IL_1EF:
			num = (short)1765081088;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0007069C File Offset: 0x0006E89C
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeType> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.CompositeType> match)
		{
			short num = (short)580499767;
			short num2 = num;
			num = (short)1401796919;
			switch (num2 == num)
			{
			}
			num = (short)1443823616;
			short num3 = num;
			num = (short)860618753;
			if (num != 0)
			{
			}
			num = (short)949813248;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00070748 File Offset: 0x0006E948
		global::Motorola.Acp.PackUnpack.Ish.ListHeaderType global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.Find(int value)
		{
			global::Motorola.Acp.PackUnpack.Ish.ListHeaderType result;
			while (this.b.TryGetValue(value, out result))
			{
				short num = (short)1242457069;
				short num2 = num;
				num = (short)1527079917;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1633288192;
					short num3 = num;
					break;
				}
				}
				num = (short)216596480;
				if (num != 0)
				{
				}
				num = (short)1968898049;
				if (num != 0)
				{
				}
				return result;
			}
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0007080C File Offset: 0x0006EA0C
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderType Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> match)
		{
			int a_ = 8;
			short num = (short)177864706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_54;
				case 1:
					goto IL_207;
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
					num = (short)1971322880;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator();
					num = (short)158924801;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			num = (short)774307841;
			if (num != 0)
			{
			}
			IL_1C8:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삠힢욤쾦", a_));
			IL_207:
			num = (short)1182662656;
			short num3 = num;
			try
			{
				num = (short)1186004997;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderType result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B8;
					case 1:
					{
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)905183238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = enumerator.Current;
						num = (short)1953824771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
						result = listHeaderType;
						num = (short)820051972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
						if (match(listHeaderType))
						{
							num = (short)297926658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_10D;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					case 6:
					{
						num = (short)554134390;
						short num4 = num;
						num = (short)369781622;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)831717376;
							if (num != 0)
							{
							}
							num = (short)299106304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C4:
					num = (short)1050738689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2:
					goto IL_C4;
				}
				IL_10D:
				return result;
				IL_1B8:
				goto IL_1DC;
			}
			finally
			{
				global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.ValueCollection.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1C8;
			IL_1DC:
			return null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00070A6C File Offset: 0x0006EC6C
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> match)
		{
			short num = (short)876675223;
			short num2 = num;
			num = (short)2026766487;
			switch (num2 == num)
			{
			}
			num = (short)271646721;
			if (num != 0)
			{
			}
			num = (short)1889861632;
			short num3 = num;
			num = (short)102694912;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00070B18 File Offset: 0x0006ED18
		global::Motorola.Acp.PackUnpack.Ish.ListListletType global::Motorola.Acp.PackUnpack.Ish.Collections.IIshTypeCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletType>.Find(int value)
		{
			global::Motorola.Acp.PackUnpack.Ish.ListListletType result;
			if (this.c.TryGetValue(value, out result))
			{
				short num = (short)1296171009;
				if (num != 0)
				{
				}
				num = (short)144566264;
				short num2 = num;
				num = (short)1746397176;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2128609280;
					if (num != 0)
					{
					}
					num = (short)1631911936;
					short num3 = num;
					return result;
				}
				}
			}
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00070BDC File Offset: 0x0006EDDC
		public global::Motorola.Acp.PackUnpack.Ish.ListListletType Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListListletType> match)
		{
			int a_ = 0;
			short num = (short)577241090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_53;
				case 1:
					goto IL_202;
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
					num = (short)815398912;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator = this.c.Values.GetEnumerator();
					num = (short)690683905;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_53:
			num = (short)302055425;
			if (num != 0)
			{
			}
			IL_1C4:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("殺ﺜ", a_));
			IL_202:
			num = (short)306708480;
			short num3 = num;
			try
			{
				num = (short)1070727173;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.ListListletType result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B4;
					case 1:
					{
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)824967174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType = enumerator.Current;
						num = (short)718929923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
						result = listListletType;
						num = (short)479920132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
						if (match(listListletType))
						{
							num = (short)349503490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_10D;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					case 6:
					{
						num = (short)1005388915;
						short num4 = num;
						num = (short)187892851;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1021706240;
							if (num != 0)
							{
							}
							num = (short)579272704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C2:
					num = (short)1056636929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0:
					goto IL_C2;
				}
				IL_10D:
				return result;
				IL_1B4:
				goto IL_1D8;
			}
			finally
			{
				global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.ValueCollection.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1C4;
			IL_1D8:
			return null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00070E38 File Offset: 0x0006F038
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletType> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.ListListletType> match)
		{
			short num = (short)846496584;
			short num2 = num;
			num = (short)1310884680;
			switch (num2 == num)
			{
			}
			num = (short)1094582272;
			if (num != 0)
			{
			}
			num = (short)1134559232;
			short num3 = num;
			num = (short)1808203777;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040001DA RID: 474
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.CompositeType> a;

		// Token: 0x040001DB RID: 475
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType> b;

		// Token: 0x040001DC RID: 476
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.ListListletType> c;

		// Token: 0x040001DD RID: 477
		private global::Motorola.Acp.PackUnpack.Ish.Partition d;
	}
}
