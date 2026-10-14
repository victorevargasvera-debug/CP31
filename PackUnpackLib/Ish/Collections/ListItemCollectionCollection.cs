using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000AE RID: 174
	public class ListItemCollectionCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.IListItemCollectionCollectionFind, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00073678 File Offset: 0x00071878
		internal ListItemCollectionCollection()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>();
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>();
			this.c = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>>();
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000736AC File Offset: 0x000718AC
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection item)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> list;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!this.c.TryGetValue(listHeaderType.Value, out list))
					{
						num2 = (short)21102592;
						short num3 = num2;
						num2 = (short)15269893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_208;
				case 1:
					while (listHeaderType.IsSingleInstance)
					{
						num2 = (short)395949372;
						short num4 = num2;
						num2 = (short)1665119548;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)646316032;
							if (num2 != 0)
							{
							}
							num2 = (short)610598914;
							num = (int)((global::System.IntPtr)num2);
							goto IL_13;
						}
					}
					num2 = (short)1799684096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_203;
				case 3:
					goto IL_99;
				case 4:
					goto IL_168;
				case 5:
					list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>();
					this.c.Add(listHeaderType.Value, list);
					num2 = (short)1564999684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)636157953;
					if (num2 != 0)
					{
					}
					if (item == null)
					{
						num2 = (short)1057357827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					listHeaderType = ((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)item[0]).Type;
					num2 = (short)668598273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_99:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡킣쎥얧", a_));
			IL_168:
			goto IL_208;
			IL_203:
			this.b.Add(listHeaderType.Value, item);
			return;
			IL_208:
			list.Add(item);
			return;
			IL_35:
			this.a.Add(item);
			num2 = (short)1616969734;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000738C8 File Offset: 0x00071AC8
		public void Clear()
		{
			short num = (short)1163470188;
			short num2 = num;
			num = (short)1234511212;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2034696192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1660092416;
			if (num != 0)
			{
			}
			num = (short)1381564417;
			if (num != 0)
			{
			}
			this.a.Clear();
			this.b.Clear();
			this.c.Clear();
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00073994 File Offset: 0x00071B94
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection item)
		{
			int a_ = 11;
			short num = (short)356712451;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_128;
				case 1:
				{
					if (!listHeaderType.IsSingleInstance)
					{
						goto IL_16B;
					}
					num = (short)1567872853;
					short num3 = num;
					num = (short)1800918869;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						num = (short)893124608;
						if (num != 0)
						{
						}
						num = (short)1759838209;
						if (num != 0)
						{
						}
						num = (short)856424448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_55;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				goto IL_3E;
				IL_41:
				num = (short)1273036802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E:
				if (item == null)
				{
					goto IL_41;
				}
				listHeaderType = ((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)item[0]).Type;
				num = (short)1204289537;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_55:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡킣쎥얧", a_));
			IL_128:
			num = (short)1651769344;
			short num4 = num;
			return this.b.ContainsKey(listHeaderType.Value);
			IL_16B:
			return this.c.ContainsKey(listHeaderType.Value);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00073B20 File Offset: 0x00071D20
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection[] array, int arrayIndex)
		{
			short num = (short)1467213928;
			short num2 = num;
			num = (short)2124277864;
			switch (num2 == num)
			{
			default:
			{
				num = (short)697434112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1632501760;
			if (num != 0)
			{
			}
			num = (short)675282945;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00073BD4 File Offset: 0x00071DD4
		public int Count
		{
			get
			{
				short num = (short)1428857913;
				short num2 = num;
				num = (short)403481657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1896153088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424673281;
				if (num != 0)
				{
				}
				num = (short)787415040;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00073C8C File Offset: 0x00071E8C
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1431824593;
				short num2 = num;
				num = (short)1879107793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57606144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445855233;
				if (num != 0)
				{
				}
				num = (short)178651136;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00073D3C File Offset: 0x00071F3C
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection item)
		{
			int a_ = 7;
			if (item == null)
			{
				short num = (short)625606657;
				if (num != 0)
				{
				}
				num = (short)48955392;
				short num2 = num;
			}
			else
			{
				short num = (short)295100967;
				short num3 = num;
				num = (short)773710375;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)475463680;
					if (num != 0)
					{
					}
					return this.a.Remove(item);
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풟잡즣", a_));
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00073E14 File Offset: 0x00072014
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> GetEnumerator()
		{
			short num = (short)1510815977;
			short num2 = num;
			num = (short)1693333737;
			switch (num2 == num)
			{
			default:
			{
				num = (short)13303808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1787101185;
			if (num != 0)
			{
			}
			num = (short)1666908160;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00073EC8 File Offset: 0x000720C8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)554893313;
			if (num != 0)
			{
			}
			num = (short)1943666688;
			short num2 = num;
			num = (short)1745190189;
			short num3 = num;
			num = (short)613580077;
			switch (num3 == num)
			{
			}
			num = (short)695730176;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.b b = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.b(0);
			b.c = this;
			return b;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00073F7C File Offset: 0x0007217C
		internal global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> SingleInstanceLists
		{
			get
			{
				short num = (short)1983665146;
				short num2 = num;
				num = (short)1184977914;
				switch (num2 == num)
				{
				}
				num = (short)2112225280;
				short num3 = num;
				num = (short)861863937;
				if (num != 0)
				{
				}
				num = (short)1063059456;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.c c = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.c(-2);
				c.d = this;
				return c;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00074034 File Offset: 0x00072234
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>> MultiInstanceLists
		{
			get
			{
				short num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)1561490174;
				short num2 = num;
				num = (short)318796542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1125908480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1413677056;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.d d = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection.d(-2);
				d.d = this;
				return d;
			}
		}

		// Token: 0x170001C9 RID: 457
		public global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection this[int index]
		{
			get
			{
				short num = (short)544594585;
				short num2 = num;
				num = (short)233888409;
				switch (num2 == num)
				{
				}
				num = (short)1072037888;
				short num3 = num;
				num = (short)842072064;
				if (num != 0)
				{
				}
				num = (short)86048769;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0007419C File Offset: 0x0007239C
		public global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType, int id)
		{
			int a_ = 9;
			short num = (short)1342504960;
			short num2 = num;
			num = (short)948895744;
			switch (num)
			{
			default:
			{
				num = (short)116162249;
				short num3 = num;
				num = (short)368148169;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_272:
					num = (short)383451138;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1802960896;
					if (num != 0)
					{
					}
					num = (short)1489567744;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					case 1:
						goto IL_EA;
					case 2:
						goto IL_28B;
					}
					IL_CE:
					if (ishType != null)
					{
						goto IL_266;
					}
					num = (short)1393164289;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_EA:
				IL_250:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟톡첣톧\udaa9즫", a_));
				IL_266:
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>.Enumerator enumerator = this.a.GetEnumerator();
				goto IL_272;
				IL_28B:
				global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection result;
				try
				{
					num = (short)1720909824;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_139;
							}
							continue;
						case 1:
							goto IL_153;
						case 2:
						{
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
							result = listItemCollection;
							num = (short)1959919617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
							if (listHeaderItem.Type == ishType)
							{
								num = (short)1067188231;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
							if (listHeaderItem.Id == id)
							{
								num = (short)1293484034;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)18874376;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)162201605;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = listItemCollection[0] as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem;
							num = (short)850591747;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)1722810372;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_240;
						}
						IL_158:
						num = (short)688455686;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_139:
						goto IL_158;
					}
					IL_153:
					goto IL_290;
					IL_240:
					goto IL_264;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_250;
				IL_264:
				return null;
				IL_290:
				num = (short)1462894593;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00074480 File Offset: 0x00072680
		public global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType)
		{
			int a_ = 12;
			short num = (short)1700921344;
			short num2 = num;
			num = (short)1912809804;
			short num3 = num;
			num = (short)318974284;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BA:
				switch (0)
				{
				case 0:
					goto IL_D6;
				}
				break;
			default:
				num = (short)1720909825;
				if (num != 0)
				{
				}
				num = (short)1448804352;
				if (num != 0)
				{
				}
				num = (short)1790902272;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			IL_C4:
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>.Enumerator enumerator;
			global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection listItemCollectionCollection;
			switch (num4)
			{
			case 0:
				goto IL_BA;
			case 1:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢횤쾦ﶨ튪\uddac쪮", a_));
			case 2:
				try
				{
					num = (short)594411520;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_137;
							}
							continue;
						case 1:
							num = (short)1720254470;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)262145;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
							num = (short)899350532;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
							listItemCollectionCollection.Add(listItemCollection);
							num = (short)208404485;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
							if ((listItemCollection[0] as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem).Type == ishType)
							{
								num = (short)1390346243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_1F6;
						}
						IL_182:
						num = (short)1274609666;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_137:
						goto IL_182;
					}
					IL_1F6:
					return listItemCollectionCollection;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_206;
			}
			IL_D6:
			if (ishType == null)
			{
				num = (short)1140260865;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C4;
			}
			IL_206:
			listItemCollectionCollection = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection();
			enumerator = this.a.GetEnumerator();
			num = (short)888995842;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_C4;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000746F4 File Offset: 0x000728F4
		public global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> match)
		{
			int a_ = 11;
			for (;;)
			{
				IL_09:
				short num = (short)1326383104;
				short num2 = num;
				num = (short)1444741120;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 1:
						goto IL_7B;
					case 2:
						goto IL_226;
					}
					IL_61:
					if (match == null)
					{
						num = (short)1348009985;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>.Enumerator enumerator = this.a.GetEnumerator();
						num = (short)465133412;
						short num4 = num;
						num = (short)1313759076;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)863961088;
							if (num != 0)
							{
							}
							num = (short)1348599809;
							if (num != 0)
							{
							}
							num = (short)979894274;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
			IL_7B:
			IL_17A:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾡얣튥쮧슩", a_));
			IL_226:
			try
			{
				short num = (short)1052835840;
				int num3 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection result;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
						if (match(listItemCollection))
						{
							num = (short)1120600069;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_10B;
					case 3:
						num = (short)2052784134;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)909377539;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
						num = (short)1107361793;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
						result = listItemCollection;
						num = (short)1450639362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_16A;
					}
					IL_C2:
					num = (short)1701380100;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0:
					goto IL_C2;
				}
				IL_10B:
				return result;
				IL_16A:
				goto IL_18E;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_17A;
			IL_18E:
			return null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00074940 File Offset: 0x00072B40
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> match)
		{
			short num = (short)1551097679;
			short num2 = num;
			num = (short)1970200399;
			switch (num2 == num)
			{
			}
			num = (short)1720844288;
			short num3 = num;
			num = (short)1742405632;
			if (num != 0)
			{
			}
			num = (short)1628569601;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040001F4 RID: 500
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> a;

		// Token: 0x040001F5 RID: 501
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> b;

		// Token: 0x040001F6 RID: 502
		private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>> c;
	}
}
