using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000A0 RID: 160
	public class ListItemCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IListNode>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.IListNode>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.IListNode>
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x00068BB4 File Offset: 0x00066DB4
		internal ListItemCollection()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IListNode>();
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00068BD4 File Offset: 0x00066DD4
		public void Add(global::Motorola.Acp.PackUnpack.Ish.IListNode item)
		{
			int a_ = 0;
			short num = (short)840302593;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletItem)
					{
						num = (short)799342599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)584064129;
					short num3 = num;
					num = (short)796859521;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						goto IL_1EB;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 2:
					num = (short)998965253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.a.Count == 0)
					{
						num = (short)388956162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)702873600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_66;
				case 5:
					goto IL_18E;
				case 6:
					goto IL_1B0;
				case 7:
					goto IL_171;
				}
				IL_4E:
				if (item == null)
				{
					num = (short)1600782340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1981612035;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18E:
				if (!(item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem))
				{
					goto IL_91;
				}
				num = (short)205979654;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_66:
			num = (short)533331968;
			short num4 = num;
			num = (short)346095617;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺖﺚ", a_));
			IL_91:
			throw new global::System.InvalidOperationException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슖漢ﾜ쒠莢톤좦覨쪪즬쮮醰\udbb2킴횶\uddb8\udeba쾼龾ꣀ럂ꃄ꫆臌ꛎꋐ꟒뛖뗘꧚룜뻞藠髢엤蓦蛨藪駬軮飰鷲蛴ퟶ飸\udbfa闼髾怀朂怄甆⤈戊礌樎簐㴒", a_));
			IL_171:
			this.a.Add(item);
			return;
			IL_1B0:
			this.a.Add(item);
			return;
			IL_1EB:
			num = (short)1142751232;
			if (num != 0)
			{
			}
			throw new global::System.InvalidOperationException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풖햠莢쒤쎦춨讪쒬\udbae풰\udeb2운鞶횸\uddba鶼쮾룀돂ꃄ﯊ꗐ볒ꏖ뇘닚껜￞跠諢雤鏦쟨", a_), item.GetType().Name));
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00068E08 File Offset: 0x00067008
		public void Clear()
		{
			short num = (short)529621824;
			short num2 = num;
			num = (short)1385063232;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1144193024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1072103425;
			if (num != 0)
			{
			}
			num = (short)40894464;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00068EBC File Offset: 0x000670BC
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.IListNode item)
		{
			int a_ = 3;
			short num = (short)741623750;
			short num2 = num;
			num = (short)1219708870;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1388969985;
				if (num != 0)
				{
				}
				num = (short)1399783424;
				if (num != 0)
				{
				}
				num = (short)258408448;
				short num3 = num;
				if (item != null)
				{
					return this.a.IndexOf(item) != -1;
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ춟", a_));
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00068F9C File Offset: 0x0006719C
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.IListNode[] array, int arrayIndex)
		{
			short num = (short)306249729;
			if (num != 0)
			{
			}
			num = (short)677969920;
			short num2 = num;
			num = (short)125071395;
			short num3 = num;
			num = (short)836268067;
			switch (num3 == num)
			{
			}
			num = (short)37224448;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0006904C File Offset: 0x0006724C
		public int Count
		{
			get
			{
				short num = (short)418709505;
				if (num != 0)
				{
				}
				num = (short)256835584;
				short num2 = num;
				num = (short)995268751;
				short num3 = num;
				num = (short)1828296847;
				switch (num3 == num)
				{
				}
				num = (short)486277120;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00069100 File Offset: 0x00067300
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1997986351;
				short num2 = num;
				num = (short)920967727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842989568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)189333504;
				if (num != 0)
				{
				}
				num = (short)1710948353;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000691AC File Offset: 0x000673AC
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.IListNode item)
		{
			int a_ = 11;
			short num = (short)1196425217;
			if (num != 0)
			{
			}
			num = (short)719161765;
			short num2 = num;
			num = (short)841451941;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)803995648;
				if (num != 0)
				{
				}
				num = (short)454688768;
				short num3 = num;
				if (item != null)
				{
					return this.a.Remove(item);
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡킣쎥얧", a_));
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00069288 File Offset: 0x00067488
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.IListNode> GetEnumerator()
		{
			short num = (short)1142264920;
			short num2 = num;
			num = (short)1876661336;
			switch (num2 == num)
			{
			default:
			{
				num = (short)790560768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1979973633;
			if (num != 0)
			{
			}
			num = (short)141361152;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00069340 File Offset: 0x00067540
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1526665284;
			short num2 = num;
			num = (short)675090500;
			switch (num2 == num)
			{
			default:
			{
				num = (short)421986304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)528154624;
			if (num != 0)
			{
			}
			num = (short)1076690945;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000693F0 File Offset: 0x000675F0
		internal global::Motorola.Acp.PackUnpack.Ish.IListNode a(int A_0)
		{
			short num = (short)288686083;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					int num3;
					if (num3 >= this.a.Count)
					{
						num = (short)605028356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)905052161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					if (((global::Motorola.Acp.PackUnpack.Ish.ListListletItem)this.a[0]).Name == A_0)
					{
						num = (short)954597381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num3;
					num3++;
					num = (short)373161991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_212;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 4:
					goto IL_195;
				case 5:
					goto IL_147;
				case 6:
				{
					num = (short)559166095;
					short num4 = num;
					num = (short)75707023;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_233;
					default:
						num = (short)1419509761;
						if (num != 0)
						{
						}
						num = (short)1714094080;
						if (num != 0)
						{
						}
						num = (short)1870135305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_233;
				case 8:
					goto IL_156;
				case 9:
				{
					if (((global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)this.a[0]).Name == A_0)
					{
						num = (short)691732482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num3 = 1;
					num = (short)699203592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4C:
				if (this.a.Count > 0)
				{
					num = (short)623181830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_257;
				IL_156:
				num = (short)1800339456;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_233:
				goto IL_156;
			}
			IL_147:
			return this.a[0];
			IL_195:
			num = (short)882638848;
			short num5 = num;
			goto IL_257;
			IL_212:
			return this.a[0];
			IL_257:
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00069658 File Offset: 0x00067858
		internal global::Motorola.Acp.PackUnpack.Ish.IListNode a(global::Motorola.Acp.PackUnpack.Ish.IshItemName A_0)
		{
			short num = (short)1260856828;
			short num2 = num;
			num = (short)640034300;
			switch (num2 == num)
			{
			default:
			{
				num = (short)767885312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)503775233;
			if (num != 0)
			{
			}
			num = (short)285147136;
			if (num != 0)
			{
			}
			return this.a(A_0);
		}

		// Token: 0x170001BB RID: 443
		internal global::Motorola.Acp.PackUnpack.Ish.IListNode this[int A_0]
		{
			get
			{
				short num = (short)1831106488;
				short num2 = num;
				num = (short)1532065720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)772800512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1002831872;
				if (num != 0)
				{
				}
				num = (short)1659699201;
				if (num != 0)
				{
				}
				return this.a[A_0];
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000697C8 File Offset: 0x000679C8
		public global::Motorola.Acp.PackUnpack.Ish.IListNode Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IListNode> match)
		{
			int a_ = 15;
			short num;
			for (;;)
			{
				num = (short)1973157889;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B7;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					case 2:
						goto IL_7C;
					}
					IL_3A:
					num = (short)1943273473;
					if (num != 0)
					{
					}
					if (match == null)
					{
						num = (short)2049966082;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IListNode>.Enumerator enumerator = this.a.GetEnumerator();
						num = (short)587923456;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1B7:
				num = (short)613679104;
				short num3 = num;
				num = (short)612827943;
				short num4 = num;
				num = (short)1748828967;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_215;
				}
			}
			IL_7C:
			IL_17E:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮥즧\udea9쾫욭", a_));
			IL_215:
			num = (short)931594240;
			if (num != 0)
			{
			}
			try
			{
				num = (short)220790789;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.IListNode result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1675886593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_16E;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						result = listNode;
						num = (short)1094582278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode;
						if (match(listNode))
						{
							num = (short)2070675458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IListNode>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)2008154112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.IListNode listNode = enumerator.Current;
						num = (short)442302467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C1;
						}
						continue;
					case 6:
						goto IL_10E;
					}
					IL_C3:
					num = (short)1012334596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1:
					goto IL_C3;
				}
				IL_10E:
				return result;
				IL_16E:
				goto IL_192;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IListNode>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_17E;
			IL_192:
			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00069A18 File Offset: 0x00067C18
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.IListNode> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.IListNode> match)
		{
			short num = (short)228990034;
			short num2 = num;
			num = (short)723262546;
			switch (num2 == num)
			{
			default:
			{
				num = (short)389873664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1949696000;
			if (num != 0)
			{
			}
			num = (short)215220225;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040001B8 RID: 440
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IListNode> a;
	}
}
