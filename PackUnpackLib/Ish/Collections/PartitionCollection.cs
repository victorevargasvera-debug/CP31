using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000B4 RID: 180
	public class PartitionCollection : global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Partition>, global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.Partition>, global::System.Collections.IEnumerable, global::Motorola.Acp.PackUnpack.Ish.Collections.IPartitionCollectionFind, global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Partition>
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x00076B14 File Offset: 0x00074D14
		internal PartitionCollection(global::Motorola.Acp.PackUnpack.Ish.Codeplug A_0)
		{
			int a_ = 13;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풣장\udaa7쾩슫\udaad", a_));
			}
			this.a = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.Partition>();
			this.b = A_0;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00076B5C File Offset: 0x00074D5C
		internal global::Motorola.Acp.PackUnpack.Ish.Codeplug Parent
		{
			get
			{
				short num = (short)50593792;
				short num2 = num;
				num = (short)2131623937;
				if (num != 0)
				{
				}
				num = (short)277004176;
				short num3 = num;
				num = (short)2028060560;
				switch (num3 == num)
				{
				}
				num = (short)1555890176;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00076C0C File Offset: 0x00074E0C
		public void Add(global::Motorola.Acp.PackUnpack.Ish.Partition item)
		{
			int a_ = 6;
			short num = (short)143196161;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_141;
				case 1:
					goto IL_1E;
				case 2:
					if (item.Parent != null)
					{
						num = (short)686882816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 3:
					goto IL_F3;
				}
				goto IL_3E;
				IL_1E:
				switch (0)
				{
				case 0:
				{
					IL_3E:
					num = (short)2085571427;
					short num3 = num;
					num = (short)167856995;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)1974337537;
						if (num != 0)
						{
						}
						num = (short)1603010560;
						if (num != 0)
						{
						}
						if (item == null)
						{
							num = (short)1664679936;
							short num4 = num;
							num = (short)324534275;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1493237762;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					break;
				}
				}
			}
			IL_F3:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠캢", a_));
			IL_141:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("출ﺞ펠힢첤펦삨쒪쎬辮킰\udfb2잴튶\ud8b8\udfba쒼龾꧀ꋂ뛄꣈뷌껎ꏐ뛒믔ꏖ", a_));
			IL_157:
			item.Parent = this.b;
			this.a.Add(item.PartitionType, item);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00076D90 File Offset: 0x00074F90
		public void Clear()
		{
			short num = (short)1447559168;
			short num2 = num;
			num = (short)1449261295;
			short num3 = num;
			num = (short)1690564847;
			switch (num3 == num)
			{
			}
			num = (short)2096300032;
			if (num != 0)
			{
			}
			num = (short)1990787073;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00076E44 File Offset: 0x00075044
		public bool Contains(global::Motorola.Acp.PackUnpack.Ish.Partition item)
		{
			int a_ = 2;
			while (item != null)
			{
				short num = (short)1642977754;
				short num2 = num;
				num = (short)1211816410;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1357971456;
					short num3 = num;
					num = (short)1051656193;
					if (num != 0)
					{
					}
					num = (short)373096448;
					if (num != 0)
					{
					}
					return this.a.ContainsKey(item.PartitionType);
				}
				}
			}
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_));
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00076F20 File Offset: 0x00075120
		public void CopyTo(global::Motorola.Acp.PackUnpack.Ish.Partition[] array, int arrayIndex)
		{
			short num = (short)511508480;
			short num2 = num;
			num = (short)750107886;
			short num3 = num;
			num = (short)1858583790;
			switch (num3 == num)
			{
			}
			num = (short)1053491201;
			if (num != 0)
			{
			}
			num = (short)1642856448;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00076FD4 File Offset: 0x000751D4
		public int Count
		{
			get
			{
				short num = (short)199688192;
				short num2 = num;
				num = (short)662683112;
				short num3 = num;
				num = (short)252362216;
				switch (num3 == num)
				{
				}
				num = (short)473563137;
				if (num != 0)
				{
				}
				num = (short)1155858432;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00077088 File Offset: 0x00075288
		public bool IsReadOnly
		{
			get
			{
				short num = (short)916540603;
				short num2 = num;
				num = (short)1880706235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849805312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804992512;
				if (num != 0)
				{
				}
				num = (short)1261764609;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00077134 File Offset: 0x00075334
		public bool Remove(global::Motorola.Acp.PackUnpack.Ish.Partition item)
		{
			int a_ = 1;
			if (item == null)
			{
				short num;
				for (;;)
				{
					num = (short)859264685;
					short num2 = num;
					num = (short)426989229;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_48;
					}
				}
				IL_48:
				num = (short)18546688;
				short num3 = num;
				num = (short)1136459776;
				if (num != 0)
				{
				}
				num = (short)1575026689;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("鍊", a_));
			}
			item.Parent = null;
			return this.a.Remove(item.PartitionType);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0007721C File Offset: 0x0007541C
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> GetEnumerator()
		{
			short num = (short)290783233;
			if (num != 0)
			{
			}
			num = (short)1454309376;
			short num2 = num;
			num = (short)1170040739;
			short num3 = num;
			num = (short)547317667;
			switch (num3 == num)
			{
			}
			num = (short)1629421568;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection.a a = new global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000772D4 File Offset: 0x000754D4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)870119790;
			short num2 = num;
			num = (short)361167214;
			switch (num2 == num)
			{
			default:
			{
				num = (short)211353600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1628176384;
			if (num != 0)
			{
			}
			num = (short)1673134081;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00077384 File Offset: 0x00075584
		public global::Motorola.Acp.PackUnpack.Ish.Partition Find(global::Motorola.Acp.PackUnpack.Ish.PartitionType type)
		{
			global::Motorola.Acp.PackUnpack.Ish.Partition result;
			if (this.a.TryGetValue(type, out result))
			{
				short num;
				for (;;)
				{
					num = (short)386401641;
					short num2 = num;
					num = (short)1302267241;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4A;
					}
				}
				IL_4A:
				num = (short)1456078848;
				short num3 = num;
				num = (short)1147928577;
				if (num != 0)
				{
				}
				num = (short)544538624;
				if (num != 0)
				{
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00077444 File Offset: 0x00075644
		public global::Motorola.Acp.PackUnpack.Ish.Partition Find(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Partition> match)
		{
			int a_ = 3;
			short num = (short)1618083842;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_54;
				case 1:
					goto IL_1EC;
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
					num = (short)1572995072;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.Partition>.ValueCollection.Enumerator enumerator = this.a.Values.GetEnumerator();
					num = (short)658178049;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			IL_1AE:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶛ쎟쪡", a_));
			IL_1EC:
			global::Motorola.Acp.PackUnpack.Ish.Partition result;
			try
			{
				num = (short)937623557;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_139;
					case 1:
						goto IL_19E;
					case 2:
						num = (short)1017774081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1202898833;
						short num3 = num;
						num = (short)1634584465;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19E;
						default:
						{
							num = (short)1740898304;
							if (num != 0)
							{
							}
							global::Motorola.Acp.PackUnpack.Ish.Partition partition;
							result = partition;
							num = (short)380174336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						if (match(partition))
						{
							num = (short)728694787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 6:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.Partition>.ValueCollection.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)663355394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
						num = (short)751632388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9C:
					num = (short)340656134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					goto IL_9C;
				}
				IL_139:
				goto IL_1F1;
				IL_19E:
				goto IL_1C2;
			}
			finally
			{
				global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.Partition>.ValueCollection.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1AE;
			IL_1C2:
			return null;
			IL_1F1:
			num = (short)57671681;
			if (num != 0)
			{
			}
			num = (short)905641984;
			short num4 = num;
			return result;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000776B0 File Offset: 0x000758B0
		public global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.Partition> FindAll(global::System.Predicate<global::Motorola.Acp.PackUnpack.Ish.Partition> match)
		{
			short num = (short)1175392989;
			short num2 = num;
			num = (short)2069631709;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1748762624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)31391745;
			if (num != 0)
			{
			}
			num = (short)194838528;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000209 RID: 521
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.Partition> a;

		// Token: 0x0400020A RID: 522
		private global::Motorola.Acp.PackUnpack.Ish.Codeplug b;
	}
}
