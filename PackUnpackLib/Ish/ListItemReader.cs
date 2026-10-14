using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Exceptions;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000032 RID: 50
	public class ListItemReader : global::System.IDisposable
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x000248F4 File Offset: 0x00022AF4
		internal ListItemReader(global::Motorola.Acp.PackUnpack.Ish.Collections.IshItemCollection A_0)
		{
			int a_ = 9;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟횡솣쮥\udba7", a_));
			}
			this.b = A_0.ListHeaders;
			if (this.b.Count == 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟횡솣쮥\udba7", a_));
			}
			this.c = A_0.ListListlets;
			this.e = A_0.ListListletFinder;
			this.d = this.b.GetEnumerator();
			this.g = 0;
			this.f = null;
			this.a = false;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00024998 File Offset: 0x00022B98
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1554773963;
				short num2 = num;
				num = (short)647821259;
				switch (num2 == num)
				{
				}
				num = (short)992739328;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1350500353;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1216479232;
			short num3 = num;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00024A60 File Offset: 0x00022C60
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection List
		{
			get
			{
				int a_ = 1;
				short num = (short)1971322880;
				short num2 = num;
				num = (short)1853033323;
				short num3 = num;
				num = (short)1823476587;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1406664705;
					if (num != 0)
					{
					}
					num = (short)1209073664;
					if (num != 0)
					{
					}
					if (this.f == null)
					{
						throw new global::System.InvalidOperationException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첗鍊얟芡얣풥춧誩슫솭邯\udeb1\uddb3억첷骹햻쪽ꖿ꿁럃볇ꗉ뻍ꋏ뷑럓돕ꯗ꧙", a_));
					}
					break;
				}
				return this.f;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00024B34 File Offset: 0x00022D34
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> Headers
		{
			get
			{
				short num = (short)480378880;
				short num2 = num;
				num = (short)1440350209;
				if (num != 0)
				{
				}
				num = (short)1174569717;
				short num3 = num;
				num = (short)1050378997;
				switch (num3 == num)
				{
				}
				num = (short)703791104;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00024BE4 File Offset: 0x00022DE4
		internal global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> Listlets
		{
			get
			{
				short num = (short)40239104;
				short num2 = num;
				num = (short)235011269;
				short num3 = num;
				num = (short)1848114373;
				switch (num3 == num)
				{
				}
				num = (short)1389035521;
				if (num != 0)
				{
				}
				num = (short)1642987520;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00024C94 File Offset: 0x00022E94
		internal bool EOS
		{
			get
			{
				short num = (short)1640955904;
				short num2 = num;
				num = (short)1031377646;
				short num3 = num;
				num = (short)1322160878;
				switch (num3 == num)
				{
				}
				num = (short)371458049;
				if (num != 0)
				{
				}
				num = (short)1690763264;
				if (num != 0)
				{
				}
				return this.h == global::Motorola.Acp.PackUnpack.Ish.ReadState.EndOfStream;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00024D48 File Offset: 0x00022F48
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00024DF8 File Offset: 0x00022FF8
		public global::Motorola.Acp.PackUnpack.Ish.ReadState ReadState
		{
			get
			{
				short num = (short)1357840384;
				short num2 = num;
				num = (short)1310396829;
				short num3 = num;
				num = (short)586224029;
				switch (num3 == num)
				{
				}
				num = (short)930742273;
				if (num != 0)
				{
				}
				num = (short)378994688;
				if (num != 0)
				{
				}
				return this.h;
			}
			protected set
			{
				short num = (short)1864368128;
				short num2 = num;
				num = (short)2054220472;
				short num3 = num;
				num = (short)1590291128;
				switch (num3 == num)
				{
				}
				num = (short)1529675777;
				if (num != 0)
				{
				}
				num = (short)1869807616;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00024EA8 File Offset: 0x000230A8
		internal bool e()
		{
			int a_ = 10;
			short num = (short)618201088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 1:
				{
					try
					{
						num = (short)1726808064;
						num2 = (int)((global::System.IntPtr)num);
						global::Motorola.Acp.PackUnpack.Ish.IshItemName next;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_18B;
								}
								continue;
							case 1:
								goto IL_2ED;
							case 2:
								goto IL_2ED;
							case 3:
								this.h = global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive;
								num = (short)1169031172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_32E;
							case 5:
								goto IL_32E;
							case 6:
							{
								this.f = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection();
								global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = this.d.Current;
								this.f.Add(listHeaderItem);
								next = listHeaderItem.Next;
								num = (short)1951334402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								if (next.IsNull)
								{
									num = (short)1068826627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = this.e.Find(next);
								num = (short)618397706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_2AE;
							case 9:
								goto IL_346;
							case 10:
							{
								global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem;
								if (listListletItem == null)
								{
									num = (short)1426063368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								this.f.Add(listListletItem);
								this.g++;
								next = listListletItem.Next;
								num = (short)490012673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_18B:
							if (this.d.MoveNext())
							{
								num = (short)540213254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.h = global::Motorola.Acp.PackUnpack.Ish.ReadState.EndOfStream;
							num = (short)2062221317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2ED:
							num = (short)1622474759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_32E:
							num = (short)828375049;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2AE:
						throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshItemNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춢쒤얦얨캪趬\udbae\udeb0鎲펴\udeb6ힸ\udfba鶼鋀诂껆뷈껊ꃌꗐ꫒ꗔ닖律ꃚꋞ췠쏢賤菦짨郪\udcec鋮", a_), next.Type, next.Id));
						IL_346:
						goto IL_92;
					}
					catch (global::System.Exception ex)
					{
						if (this.f != null)
						{
							this.f.Clear();
							this.f = null;
						}
						this.h = global::Motorola.Acp.PackUnpack.Ish.ReadState.Error;
						throw ex;
					}
					return true;
					IL_92:
					num = (short)1359085568;
					short num3 = num;
					num = (short)143982594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (this.h == global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						num = (short)286130184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					return false;
				case 4:
					num = (short)1724645382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.EOS)
					{
						num = (short)1781399559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77;
				case 6:
					if (this.h != global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
					{
						num = (short)1903820803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BF;
				case 7:
				{
					num = (short)1613955073;
					if (num != 0)
					{
					}
					num = (short)2138428712;
					short num4 = num;
					num = (short)583193896;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						goto IL_3A8;
					}
					break;
				}
				case 8:
					goto IL_F6;
				}
				IL_52:
				if (this.h != global::Motorola.Acp.PackUnpack.Ish.ReadState.Initial)
				{
					num = (short)1194065924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3BF;
				IL_77:
				num = (short)581238785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BF:
				num = (short)1589182469;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			return true;
			IL_3A8:
			num = (short)409010176;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000252F8 File Offset: 0x000234F8
		internal void f()
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)136183810;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.h != global::Motorola.Acp.PackUnpack.Ish.ReadState.Interactive)
						{
							num = (short)131006467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12C;
					case 1:
						num = (short)1849950208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)419364864;
						short num3 = num;
						num = (short)1577619553;
						short num4 = num;
						num = (short)1118605409;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)124256256;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AD;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_12A;
					}
					IL_AD:
					if (this.h == global::Motorola.Acp.PackUnpack.Ish.ReadState.Initial)
					{
						goto IL_12C;
					}
					num = (short)876544001;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_12A:
			num = (short)1559822337;
			if (num != 0)
			{
			}
			return;
			IL_12C:
			((global::System.IDisposable)this).Dispose();
			this.h = global::Motorola.Acp.PackUnpack.Ish.ReadState.Closed;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00025440 File Offset: 0x00023640
		void global::System.IDisposable.Dispose()
		{
			short num = (short)848691200;
			short num2 = num;
			num = (short)2094530561;
			if (num != 0)
			{
			}
			if (this.a)
			{
				for (;;)
				{
					num = (short)2080638563;
					short num3 = num;
					num = (short)586548835;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8F;
					}
				}
				IL_8F:
				num = (short)515375104;
				if (num != 0)
				{
				}
				return;
			}
			this.Dispose(true);
			this.b = null;
			this.c = null;
			this.a = true;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00025518 File Offset: 0x00023718
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1788262065;
			short num2 = num;
			num = (short)329037489;
			switch (num2 == num)
			{
			}
			num = (short)1235025920;
			if (num != 0)
			{
			}
			num = (short)1062404096;
			short num3 = num;
			num = (short)1019281409;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400008D RID: 141
		private bool a;

		// Token: 0x0400008E RID: 142
		private global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> b;

		// Token: 0x0400008F RID: 143
		private global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.ListListletItem> c;

		// Token: 0x04000090 RID: 144
		private global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem> d;

		// Token: 0x04000091 RID: 145
		private global::Motorola.Acp.PackUnpack.Ish.Collections.IIshItemCollectionFind<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType> e;

		// Token: 0x04000092 RID: 146
		private global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection f;

		// Token: 0x04000093 RID: 147
		private int g;

		// Token: 0x04000094 RID: 148
		private global::Motorola.Acp.PackUnpack.Ish.ReadState h;
	}
}
