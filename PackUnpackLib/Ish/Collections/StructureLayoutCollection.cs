using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000B7 RID: 183
	public class StructureLayoutCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout, global::Motorola.Acp.PackUnpack.Ish.IshType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>, global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout, global::Motorola.Acp.PackUnpack.Ish.CompositeType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>, global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>, global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>, global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.ListListletType>
	{
		// Token: 0x0600071C RID: 1820 RVA: 0x00077E8C File Offset: 0x0007608C
		internal StructureLayoutCollection(global::Motorola.Acp.PackUnpack.Ish.Partition A_0)
		{
			int a_ = 11;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튡얣풥\udca7쎩\ud8ab잭\udfaf\udcb1", a_));
			}
			this.a = A_0;
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>();
			this.c = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>();
			this.d = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>();
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00077EEC File Offset: 0x000760EC
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> Composites
		{
			get
			{
				short num = (short)939440028;
				short num2 = num;
				num = (short)1012774812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)779157504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576796160;
				if (num != 0)
				{
				}
				num = (short)692191233;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00077F94 File Offset: 0x00076194
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> Lists
		{
			get
			{
				short num = (short)228259262;
				short num2 = num;
				num = (short)1454831038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326120960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583349760;
				if (num != 0)
				{
				}
				num = (short)1394868225;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00078040 File Offset: 0x00076240
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout)
		{
			int a_ = 9;
			short num = (short)652607492;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!(layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout))
					{
						goto IL_1AA;
					}
					num = (short)805219627;
					short num3 = num;
					num = (short)2013637931;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						num = (short)897974272;
						if (num != 0)
						{
						}
						num = (short)638386179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1A5;
				case 2:
					if (layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout)
					{
						num = (short)1105920001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1068957696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_E9;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					continue;
				case 5:
					goto IL_61;
				}
				IL_47:
				if (layout == null)
				{
					num = (short)96862213;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1542586369;
					if (num != 0)
					{
					}
					num = (short)1489174530;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_61:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첟쎡\udda3즥\udda7\udea9", a_));
			IL_E9:
			num = (short)344064000;
			short num4 = num;
			this.Add(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout);
			return;
			IL_1A5:
			this.Add(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout);
			return;
			IL_1AA:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000781FC File Offset: 0x000763FC
		public void Clear()
		{
			short num = (short)1101722461;
			short num2 = num;
			num = (short)1251603293;
			switch (num2 == num)
			{
			default:
			{
				num = (short)63373312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)204013568;
			if (num != 0)
			{
			}
			num = (short)1572339713;
			if (num != 0)
			{
			}
			this.b.Clear();
			this.c.Clear();
			this.d.Clear();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000782C8 File Offset: 0x000764C8
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout)
		{
			int a_ = 7;
			short num = (short)1573584900;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1774059521;
					if (num != 0)
					{
					}
					if (!(layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout))
					{
						goto IL_1B0;
					}
					num = (short)340015608;
					short num3 = num;
					num = (short)1603025400;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B0;
					default:
						num = (short)1713176576;
						if (num != 0)
						{
						}
						num = (short)1725956099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1AB;
				case 2:
					if (layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout)
					{
						num = (short)245104641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1325531136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_10D;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					goto IL_5F;
				}
				IL_45:
				if (layout == null)
				{
					num = (short)1468334085;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)889061378;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5F:
			num = (short)487325696;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟\udba1쮣펥\udca7", a_));
			IL_10D:
			return this.c.ContainsValue(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout);
			IL_1AB:
			return this.b.ContainsValue(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout);
			IL_1B0:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0007848C File Offset: 0x0007668C
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout[] array, int arrayIndex)
		{
			short num = (short)794820609;
			if (num != 0)
			{
			}
			num = (short)1919221760;
			short num2 = num;
			num = (short)2111870942;
			short num3 = num;
			num = (short)1951897566;
			switch (num3 == num)
			{
			}
			num = (short)1274871808;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0007853C File Offset: 0x0007673C
		public int Count
		{
			get
			{
				short num = (short)2042456143;
				short num2 = num;
				num = (short)1685547087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989214208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977745408;
				if (num != 0)
				{
				}
				num = (short)1249312769;
				if (num != 0)
				{
				}
				return this.b.Count + this.c.Count;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000785FC File Offset: 0x000767FC
		public bool IsReadOnly
		{
			get
			{
				short num = (short)2081706852;
				short num2 = num;
				num = (short)1851282276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876557824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113339392;
				if (num != 0)
				{
				}
				num = (short)1375731713;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000786A8 File Offset: 0x000768A8
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout)
		{
			int a_ = 10;
			short num = (short)1026949124;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)985071617;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					if (!(layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout))
					{
						goto IL_1A5;
					}
					num = (short)255825009;
					short num3 = num;
					num = (short)682529905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A5;
					default:
						num = (short)1285554176;
						if (num != 0)
						{
						}
						num = (short)720240643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1A0;
				case 2:
					if (layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout)
					{
						num = (short)1569128449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1744961536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_10D;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 5:
					goto IL_86;
				}
				IL_6C:
				if (layout == null)
				{
					num = (short)530710533;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)900530178;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_86:
			num = (short)1414201344;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춠슢\udca4좦\udca8\udfaa", a_));
			IL_10D:
			return this.Remove(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout);
			IL_1A0:
			return this.Remove(layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout);
			IL_1A5:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00078860 File Offset: 0x00076A60
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout> GetEnumerator()
		{
			short num = (short)1071306796;
			short num2 = num;
			num = (short)412801068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1900740608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1796734977;
			if (num != 0)
			{
			}
			num = (short)1875443712;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00078914 File Offset: 0x00076B14
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1758276297;
			short num2 = num;
			num = (short)459221705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1773404160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1998913537;
			if (num != 0)
			{
			}
			num = (short)1895890944;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000789C4 File Offset: 0x00076BC4
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Find(int type)
		{
			short num = (short)1228800004;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
					if (!this.d.TryGetValue(type, out result))
					{
						goto IL_18E;
					}
					num = (short)74071591;
					short num3 = num;
					num = (short)1249132071;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						num = (short)1842544640;
						if (num != 0)
						{
						}
						num = (short)1577844739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
					return result;
				}
				case 2:
				{
					global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
					if (this.c.TryGetValue(type, out result))
					{
						num = (short)1931280385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)412549120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
					return result;
				}
				case 4:
					num = (short)1490812929;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 5:
					goto IL_8C;
				}
				IL_65:
				if (this.b.TryGetValue(type, out result2))
				{
					num = (short)568590341;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)543752194;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8C:
			num = (short)879362048;
			short num4 = num;
			return result2;
			IL_18E:
			return null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00078B60 File Offset: 0x00076D60
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Find(int type, out global::Motorola.Acp.PackUnpack.Ish.IshType ishType)
		{
			short num = (short)2099445764;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!this.d.TryGetValue(type, out listLayout))
					{
						goto IL_1AF;
					}
					num = (short)1114363137;
					short num3 = num;
					num = (short)979948801;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AF;
					default:
						num = (short)616955904;
						if (num != 0)
						{
						}
						num = (short)1809055747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1AA;
				case 2:
					if (this.c.TryGetValue(type, out listLayout))
					{
						num = (short)1569783809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1553268736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_11E;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_63;
				}
				IL_3C:
				if (this.b.TryGetValue(type, out compositeLayout))
				{
					num = (short)678363141;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)63635456;
					short num4 = num;
					num = (short)1768161282;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_63:
			num = (short)1122631681;
			if (num != 0)
			{
			}
			ishType = compositeLayout.CompositeType;
			return compositeLayout;
			IL_11E:
			ishType = listLayout.ListletType;
			return listLayout;
			IL_1AA:
			ishType = listLayout.HeaderType;
			return listLayout;
			IL_1AF:
			ishType = null;
			return null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00078D20 File Offset: 0x00076F20
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Find(global::Motorola.Acp.PackUnpack.Ish.IshType ishType)
		{
			short num = (short)2004615175;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_144;
				case 1:
					if (this.c.TryGetValue(ishType.Value, out result))
					{
						num = (short)1406009352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 2:
					num = (short)84082699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num = (short)1117192194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				case 4:
				{
					global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result2;
					return result2;
				}
				case 5:
					goto IL_B2;
				case 6:
				{
					num = (short)1252513408;
					short num3 = num;
					num = (short)1507120768;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					default:
						num = (short)493879296;
						if (num != 0)
						{
						}
						if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
						{
							num = (short)1552023557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79;
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 8:
					return result;
				case 9:
					num = (short)1320091658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)132710400;
					short num4 = num;
					global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result2;
					if (this.b.TryGetValue(ishType.Value, out result2))
					{
						num = (short)171311108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_270;
				}
				case 11:
					if (this.d.TryGetValue(ishType.Value, out result3))
					{
						num = (short)1757282304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				}
				IL_54:
				if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)1603928073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1813905414;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_79:
				num = (short)841023491;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B2:
				num = (short)436731905;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_144:
			num = (short)927924225;
			if (num != 0)
			{
			}
			return result3;
			IL_270:
			return null;
			IL_272:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00078FA4 File Offset: 0x000771A4
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 11;
			short num = (short)1922433027;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.c.ContainsKey(A_0.Value))
					{
						num = (short)2111700997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (!this.b.ContainsKey(A_0.Value))
					{
						num = (short)250216448;
						short num3 = num;
						num = (short)400556036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					goto IL_CE;
				case 3:
				{
					num = (short)2081117764;
					short num4 = num;
					num = (short)754275908;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						num = (short)766246912;
						if (num != 0)
						{
						}
						num = (short)395575297;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					}
					break;
				}
				case 4:
					num = (short)120127488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_112;
				}
				goto IL_B7;
				IL_BA:
				num = (short)852688898;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B7:
				if (A_0 == null)
				{
					goto IL_BA;
				}
				num = (short)995491841;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CE:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡힣캥ﲧ펩\udcab쮭", a_));
			IL_112:
			return this.d.ContainsKey(A_0.Value);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00079164 File Offset: 0x00077364
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout> match)
		{
			int a_ = 13;
			short num = (short)1372848128;
			switch (num)
			{
			default:
			{
				for (;;)
				{
					IL_27:
					num = (short)566362113;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1841754049;
						short num3 = num;
						num = (short)77328321;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
						{
							num = (short)1234370560;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>.ValueCollection.Enumerator enumerator;
							global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.ValueCollection.Enumerator enumerator2;
							switch (num2)
							{
							case 0:
								goto IL_CA;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_AA;
								}
								continue;
							case 2:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout result;
								try
								{
									num = (short)788267012;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_38F;
										case 1:
											goto IL_2F8;
										case 2:
											num = (short)2045509632;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
										{
											global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
											if (match(compositeLayout))
											{
												num = (short)1413677062;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_2DF;
											}
											continue;
										case 5:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)395313154;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout = enumerator.Current;
											num = (short)1989804035;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
										{
											global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
											result = compositeLayout;
											num = (short)651231233;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_33B:
										num = (short)405340165;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_2DF:
										goto IL_33B;
									}
									IL_2F8:
									return result;
									IL_38F:
									goto IL_1DB;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								return result;
							}
							case 3:
								try
								{
									num = (short)2019229700;
									num2 = (int)((global::System.IntPtr)num);
									global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout result;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_1C8;
										case 1:
										{
											global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
											if (match(listLayout))
											{
												num = (short)537985027;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 2:
											goto IL_1AB;
										case 3:
										{
											global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
											result = listLayout;
											num = (short)703332354;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_112;
											}
											continue;
										case 5:
											num = (short)1932525568;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)1184694277;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout = enumerator2.Current;
											num = (short)1245577217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_156:
										num = (short)1348468742;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_112:
										goto IL_156;
									}
									IL_1AB:
									return result;
									IL_1C8:
									goto IL_25E;
								}
								finally
								{
									((global::System.IDisposable)enumerator2).Dispose();
								}
								goto IL_1DB;
							}
							IL_AA:
							if (match == null)
							{
								num = (short)1547698176;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							enumerator = this.b.Values.GetEnumerator();
							num = (short)593100802;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_1DB:
							num = (short)1028456449;
							if (num != 0)
							{
							}
							enumerator2 = this.c.Values.GetEnumerator();
							num = (short)1795489795;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_CA:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즣장\udca7즩쒫", a_));
				IL_25E:
				num = (short)1344208896;
				short num4 = num;
				return null;
			}
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00079530 File Offset: 0x00077730
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout> match)
		{
			short num = (short)467927041;
			if (num != 0)
			{
			}
			num = (short)1998653989;
			short num2 = num;
			num = (short)1332152869;
			switch (num2 == num)
			{
			}
			num = (short)736690176;
			if (num != 0)
			{
			}
			num = (short)1695023104;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000795E0 File Offset: 0x000777E0
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout layout)
		{
			int a_ = 17;
			short num = (short)1917976576;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 1:
				{
					num = (short)1479278592;
					short num3 = num;
					try
					{
						num = (short)620167171;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)860422149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1238958082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								global::Motorola.Acp.PackUnpack.Ish.IshType ishType = enumerator.Current;
								if (ishType.Partition != null)
								{
									goto Block_3;
								}
								ishType.Partition = this.a;
								num = (short)882442241;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_95;
								}
								continue;
							case 4:
								goto IL_13F;
							case 5:
								num = (short)572850180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BC:
							num = (short)554041344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_95:
							goto IL_BC;
						}
						Block_3:
						throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒧쮩햫솭얯욱", a_));
						IL_13F:
						goto IL_285;
					}
					finally
					{
						num = (short)123338752;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_175;
								}
								continue;
							case 1:
								goto IL_1AB;
							case 2:
								enumerator.Dispose();
								num = (short)1656160257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_175:
							if (enumerator == null)
							{
								break;
							}
							num = (short)533856258;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AB:;
					}
					goto IL_1AE;
				}
				case 2:
					goto IL_54;
				}
				IL_3A:
				if (layout == null)
				{
					num = (short)283639810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1AE:
				num = (short)906253973;
				short num4 = num;
				num = (short)1733580437;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3A;
				default:
				{
					num = (short)2146172929;
					if (num != 0)
					{
					}
					num = (short)889126912;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = layout.IshTypes.GetEnumerator();
					num = (short)1751646209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_54:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒧쮩햫솭얯욱", a_));
			IL_285:
			this.b.Add(layout.CompositeType.Value, layout);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0007989C File Offset: 0x00077A9C
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout layout)
		{
			int a_ = 19;
			while (layout == null)
			{
				short num = (short)1858419396;
				short num2 = num;
				num = (short)2104179396;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1646919680;
					short num3 = num;
					num = (short)1866399745;
					if (num != 0)
					{
					}
					num = (short)740950016;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("용춫힭\udfaf잱삳", a_));
				}
				}
			}
			return this.b.ContainsKey(layout.CompositeType.Value);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00079984 File Offset: 0x00077B84
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout[] array, int arrayIndex)
		{
			short num = (short)2102013071;
			short num2 = num;
			num = (short)800009359;
			switch (num2 == num)
			{
			}
			num = (short)1504116736;
			if (num != 0)
			{
			}
			num = (short)61341697;
			if (num != 0)
			{
			}
			num = (short)1439170560;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00079A30 File Offset: 0x00077C30
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout layout)
		{
			int a_ = 9;
			short num = (short)1264320514;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_293;
				case 1:
					goto IL_A6;
				case 2:
					goto IL_1D;
				case 3:
					goto IL_21D;
				case 4:
				{
					if (!this.b.Remove(layout.CompositeType.Value))
					{
						num = (short)2045968387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = layout.IshTypes.GetEnumerator();
					num = (short)1572143105;
					if (num != 0)
					{
					}
					num = (short)1922957312;
					short num3 = num;
					num = (short)2074476544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_41;
				IL_1D:
				switch (0)
				{
				case 0:
				{
					IL_41:
					num = (short)1084256360;
					short num4 = num;
					num = (short)1149792360;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)898957312;
						if (num != 0)
						{
						}
						if (layout == null)
						{
							num = (short)1214840833;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1730805764;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					break;
				}
				}
			}
			IL_A6:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첟쎡\udda3즥\udda7\udea9", a_));
			IL_21D:
			return false;
			IL_293:
			try
			{
				num = (short)307822594;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_154;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)29949956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.Partition = null;
						num = (short)1285947395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						continue;
					case 4:
						num = (short)2017591296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E7:
					num = (short)1691222017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E5:
					goto IL_E7;
				}
				IL_154:
				return true;
			}
			finally
			{
				num = (short)876150784;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_189;
						}
						continue;
					case 1:
						goto IL_1BC;
					case 2:
						enumerator.Dispose();
						num = (short)1825177601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_189:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1664090114;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BC:;
			}
			return false;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00079CE8 File Offset: 0x00077EE8
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>.GetEnumerator()
		{
			short num = (short)287209685;
			short num2 = num;
			num = (short)1430026453;
			switch (num2 == num)
			{
			}
			num = (short)1293156353;
			if (num != 0)
			{
			}
			num = (short)2073165824;
			if (num != 0)
			{
			}
			num = (short)1715077120;
			short num3 = num;
			global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.b b = new global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.b(0);
			b.c = this;
			return b;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00079DA0 File Offset: 0x00077FA0
		global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout, global::Motorola.Acp.PackUnpack.Ish.CompositeType>.Find(int type)
		{
			short num;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result;
			for (;;)
			{
				num = (short)1914961921;
				if (num != 0)
				{
				}
				if (this.b.TryGetValue(type, out result))
				{
					num = (short)1680279438;
					short num2 = num;
					num = (short)1177683854;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_96;
					}
					break;
				}
				goto IL_AF;
			}
			num = (short)1332150272;
			short num3 = num;
			IL_96:
			num = (short)431095808;
			if (num != 0)
			{
			}
			return result;
			IL_AF:
			return null;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00079E60 File Offset: 0x00078060
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout Find(global::Motorola.Acp.PackUnpack.Ish.CompositeType ishType)
		{
			int a_ = 13;
			short num = (short)1649672193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result;
				switch (num2)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num = (short)1354432512;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				case 2:
					return result;
				case 3:
					goto IL_10C;
				}
				IL_65:
				if (ishType == null)
				{
					num = (short)1848246272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1297809409;
				if (num != 0)
				{
				}
				num = (short)2141281839;
				short num4 = num;
				num = (short)919363119;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1893269504;
					if (num != 0)
					{
					}
					num = (short)110034947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10C:
				if (!this.b.TryGetValue(ishType.Value, out result))
				{
					goto IL_151;
				}
				num = (short)1615003650;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춣향삧ﺩ햫\udead햯", a_));
			IL_151:
			return null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00079FC0 File Offset: 0x000781C0
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> match)
		{
			int a_ = 13;
			short num = (short)879165440;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>.ValueCollection.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
				{
					try
					{
						num = (short)772538372;
						num2 = (int)((global::System.IntPtr)num);
						global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_170;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)607453187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout = enumerator.Current;
								num = (short)1575813125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
								result = compositeLayout;
								num = (short)480968710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)613351424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_C2;
								}
								continue;
							case 5:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
								if (match(compositeLayout))
								{
									num = (short)144441346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_10F;
							}
							IL_C4:
							num = (short)714473473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C2:
							goto IL_C4;
						}
						IL_10F:
						return result;
						IL_170:
						goto IL_194;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_180;
					IL_194:
					num = (short)1529867725;
					short num3 = num;
					num = (short)1978789325;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						goto IL_1CB;
					}
					break;
				}
				case 2:
					goto IL_7D;
				}
				goto IL_39;
				IL_69:
				num = (short)1386610690;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39:
				num = (short)2108882944;
				short num4 = num;
				if (match == null)
				{
					goto IL_69;
				}
				enumerator = this.b.Values.GetEnumerator();
				num = (short)1029636097;
				if (num != 0)
				{
				}
				num = (short)1401028609;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			IL_180:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즣장\udca7즩쒫", a_));
			IL_1CB:
			num = (short)185073664;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0007A218 File Offset: 0x00078418
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> match)
		{
			short num = (short)470171495;
			short num2 = num;
			num = (short)1230585703;
			switch (num2 == num)
			{
			}
			num = (short)1514405889;
			if (num != 0)
			{
			}
			num = (short)472121344;
			if (num != 0)
			{
			}
			num = (short)887160832;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0007A2CC File Offset: 0x000784CC
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout)
		{
			int a_ = 0;
			short num = (short)1538981889;
			if (num != 0)
			{
			}
			num = (short)455081987;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1240727552;
					short num3 = num;
					try
					{
						num = (short)953024515;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1C9;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)626655237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)920387588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_11D;
								}
								continue;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
								global::Motorola.Acp.PackUnpack.Ish.IshType ishType = enumerator.Current;
								if (ishType.Partition != null)
								{
									goto Block_4;
								}
								ishType.Partition = this.a;
								num = (short)1954545665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)1666121728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_157:
							num = (short)714473474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11D:
							goto IL_157;
						}
						Block_4:
						throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮖ햠", a_));
						IL_1C9:
						goto IL_8E;
					}
					finally
					{
						num = (short)638910465;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
							switch (num2)
							{
							case 0:
							{
								num = (short)1720961501;
								short num4 = num;
								num = (short)223857117;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1E3;
								default:
									goto IL_26C;
								}
								break;
							}
							case 1:
								goto IL_1E3;
							case 2:
								enumerator.Dispose();
								num = (short)2051014656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FF;
							IL_1E3:
							switch (0)
							{
							case 0:
								IL_1FF:
								if (enumerator == null)
								{
									goto IL_283;
								}
								num = (short)281608194;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_26C:
						num = (short)1830879232;
						if (num != 0)
						{
						}
						IL_283:;
					}
					goto IL_284;
					IL_8E:
					this.c.Add(layout.HeaderType.Value, layout);
					num = (short)120127490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					if (layout.ListletType != null)
					{
						num = (short)424214533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 4:
					goto IL_89;
				case 5:
					this.d.Add(layout.ListletType.Value, layout);
					num = (short)1484849153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (layout == null)
				{
					num = (short)673251332;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = layout.IshTypes.GetEnumerator();
					num = (short)11337728;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_89:
			IL_284:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮖ햠", a_));
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0007A604 File Offset: 0x00078804
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout)
		{
			int a_ = 18;
			if (layout == null)
			{
				short num = (short)453502006;
				short num2 = num;
				num = (short)939713590;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2051407872;
					short num3 = num;
					num = (short)1397686272;
					if (num != 0)
					{
					}
					num = (short)1300561921;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얨쪪풬삮쒰잲", a_));
				}
				}
			}
			return this.c.ContainsKey(layout.HeaderType.Value);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0007A6E8 File Offset: 0x000788E8
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout[] array, int arrayIndex)
		{
			short num = (short)906231808;
			short num2 = num;
			num = (short)364012519;
			short num3 = num;
			num = (short)490431463;
			switch (num3 == num)
			{
			}
			num = (short)62324737;
			if (num != 0)
			{
			}
			num = (short)92405760;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0007A798 File Offset: 0x00078998
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout)
		{
			int a_ = 2;
			short num = (short)276299776;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 1:
					goto IL_272;
				case 2:
					goto IL_2B1;
				case 3:
				{
					if (!this.c.Remove(layout.HeaderType.Value))
					{
						num = (short)986710017;
						if (num != 0)
						{
						}
						num = (short)1242759169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d.Remove(layout.ListletType.Value);
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator = layout.IshTypes.GetEnumerator();
					num = (short)2100232194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_5D;
				}
				IL_41:
				if (layout == null)
				{
					num = (short)148570116;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)238223363;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5D:
			num = (short)228917248;
			short num3 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢풠힢", a_));
			IL_272:
			return false;
			IL_2B1:
			try
			{
				num = (short)673710080;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 2:
						goto IL_108;
					case 3:
						num = (short)983042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1387134979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.Partition = null;
						num = (short)1495597057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9C:
					num = (short)1429078020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_9C;
				}
				IL_108:
				return true;
			}
			finally
			{
				num = (short)758972418;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IshType> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_1C1;
					case 1:
					{
						enumerator.Dispose();
						num = (short)1373293693;
						short num4 = num;
						num = (short)1030474877;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)807469056;
							if (num != 0)
							{
							}
							num = (short)513933312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_13E;
						}
						continue;
					}
					IL_13E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2091450369;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C1:;
			}
			return false;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0007AA6C File Offset: 0x00078C6C
		global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.GetEnumerator()
		{
			short num = (short)618528768;
			short num2 = num;
			num = (short)332756788;
			short num3 = num;
			num = (short)956790580;
			switch (num3 == num)
			{
			}
			num = (short)752287745;
			if (num != 0)
			{
			}
			num = (short)738066432;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c c = new global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c(0);
			c.c = this;
			return c;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0007AB24 File Offset: 0x00078D24
		global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType>.Find(int type)
		{
			short num = (short)1349189633;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
			if (!this.c.TryGetValue(type, out result))
			{
				num = (short)1696324490;
				short num2 = num;
				num = (short)734518154;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)889847808;
					if (num != 0)
					{
					}
					return null;
				}
			}
			num = (short)1826160640;
			short num3 = num;
			return result;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0007ABE0 File Offset: 0x00078DE0
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType)
		{
			int a_ = 0;
			short num = (short)315424769;
			if (num != 0)
			{
			}
			num = (short)1289879555;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2102329181;
					short num3 = num;
					num = (short)1216872285;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						goto IL_126;
					}
					break;
				}
				case 1:
					goto IL_7D;
				case 2:
					if (this.c.TryGetValue(ishType.Value, out result))
					{
						num = (short)1246101504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				}
				IL_66:
				if (ishType == null)
				{
					num = (short)2086404097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AE:
				num = (short)1230569474;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺖ즜토욢", a_));
			IL_126:
			num = (short)655228928;
			if (num != 0)
			{
			}
			num = (short)777912320;
			short num4 = num;
			return result;
			IL_154:
			return null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0007AD44 File Offset: 0x00078F44
		global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout global::Motorola.Acp.PackUnpack.Ish.Collections.IStructureLayoutCollectionFind<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.ListListletType>.Find(int type)
		{
			short num = (short)1873412099;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return listLayout;
				case 1:
					num = (short)1452867586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (listLayout.ListletType.Value == type)
					{
						goto IL_120;
					}
					goto IL_139;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				num = (short)927745571;
				short num3 = num;
				num = (short)783566371;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_120:
					num = (short)1175977984;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1079246848;
					if (num != 0)
					{
					}
					num = (short)460980224;
					short num4 = num;
					if (!this.d.TryGetValue(type, out listLayout))
					{
						goto IL_139;
					}
					num = (short)1036189697;
					if (num != 0)
					{
					}
					num = (short)1032781825;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return listLayout;
			IL_139:
			return null;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0007AE8C File Offset: 0x0007908C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout Find(global::Motorola.Acp.PackUnpack.Ish.ListListletType ishType)
		{
			int a_ = 5;
			short num = (short)1559560195;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)72286209;
					if (num != 0)
					{
					}
					num = (short)1637572494;
					short num3 = num;
					num = (short)1937006478;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						goto IL_125;
					}
					break;
				}
				case 1:
					goto IL_56;
				case 2:
					if (this.d.TryGetValue(ishType.Value, out result))
					{
						num = (short)1607532544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					continue;
				}
				IL_3F:
				if (ishType == null)
				{
					num = (short)978583553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				num = (short)1623392256;
				short num4 = num;
				num = (short)2006450178;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_56:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좟\udda3횥춧", a_));
			IL_125:
			num = (short)1291649024;
			if (num != 0)
			{
			}
			return result;
			IL_154:
			return null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0007AFF0 File Offset: 0x000791F0
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> match)
		{
			int a_ = 10;
			short num = (short)153812994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_23D;
				case 1:
					goto IL_7C;
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
					num = (short)1759969281;
					if (num != 0)
					{
					}
					num = (short)1693908993;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.ValueCollection.Enumerator enumerator = this.c.Values.GetEnumerator();
					num = (short)1536819200;
					short num3 = num;
					num = (short)85196800;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7C:
			IL_1D4:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("철슢톤쒦솨", a_));
			IL_23D:
			try
			{
				num = (short)800129025;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
						result = listLayout;
						num = (short)1277427715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					case 2:
						goto IL_1C4;
					case 3:
						goto IL_164;
					case 4:
						num = (short)732299266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
						if (match(listLayout))
						{
							num = (short)1775108096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.ValueCollection.Enumerator enumerator;
						if (enumerator.MoveNext())
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout = enumerator.Current;
							num = (short)1310130181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1549649547;
						short num4 = num;
						num = (short)667469451;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1100742656;
							if (num != 0)
							{
							}
							num = (short)1711276036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_C4:
					num = (short)659685382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2:
					goto IL_C4;
				}
				IL_164:
				return result;
				IL_1C4:
				goto IL_1E8;
			}
			finally
			{
				global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.ValueCollection.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1D4;
			IL_1E8:
			return null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0007B25C File Offset: 0x0007945C
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> match)
		{
			int a_ = 17;
			short num = (short)1072562178;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> list;
				global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>.ValueCollection.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_55;
				case 1:
					try
					{
						num = (short)95092742;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
								if (match(listLayout))
								{
									num = (short)999292929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
								list.Add(listLayout);
								num = (short)1830420484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1314979843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout = enumerator.Current;
								goto IL_F5;
							}
							case 3:
							{
								num = (short)1094980197;
								short num3 = num;
								num = (short)257299045;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_F5;
								default:
									num = (short)1117388800;
									if (num != 0)
									{
									}
									num = (short)1915879429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_1E8;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_EB;
								}
								continue;
							}
							goto IL_EB;
							IL_F5:
							num = (short)1158217728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12C:
							num = (short)768344066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_EB:
							goto IL_12C;
						}
						IL_1E8:
						return list;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1F8;
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
					num = (short)1372520448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1F8:
				list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>();
				enumerator = this.c.Values.GetEnumerator();
				num = (short)2094071809;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_55:
			num = (short)289144832;
			short num4 = num;
			num = (short)789577729;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얧쮩\ud8ab춭\ud8af", a_));
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0007B4C8 File Offset: 0x000796C8
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1427106178 + A_1) + (global::System.IntPtr)3 + (global::System.IntPtr)17);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x0400020F RID: 527
		private global::Motorola.Acp.PackUnpack.Ish.Partition a;

		// Token: 0x04000210 RID: 528
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout> b;

		// Token: 0x04000211 RID: 529
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> c;

		// Token: 0x04000212 RID: 530
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout> d;
	}
}
