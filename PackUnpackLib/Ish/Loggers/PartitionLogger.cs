using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Loggers
{
	// Token: 0x0200004C RID: 76
	public class PartitionLogger
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0003DD18 File Offset: 0x0003BF18
		internal PartitionLogger(string A_0) : this(A_0, null)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0003DD30 File Offset: 0x0003BF30
		internal PartitionLogger(string A_0, global::System.Xml.XmlWriterSettings A_1)
		{
			int a_ = 18;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾨슪솬쪮ﾰ튲\ud8b4튶", a_));
			}
			this.a(A_0, A_1);
			this.b();
			this.d();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		internal PartitionLogger(global::System.IO.Stream A_0) : this(A_0, null)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0003DD94 File Offset: 0x0003BF94
		internal PartitionLogger(global::System.IO.Stream A_0, global::System.Xml.XmlWriterSettings A_1)
		{
			int a_ = 14;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪤튦\udda8\udbaa\ud8ac\udbae", a_));
			}
			this.a(A_0, A_1);
			this.b();
			this.d();
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
		internal global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState WriteState
		{
			get
			{
				short num = (short)880214016;
				short num2 = num;
				num = (short)1420379136;
				short num3 = num;
				num = (short)2017870848;
				switch (num3 == num)
				{
				}
				num = (short)2009268225;
				if (num != 0)
				{
				}
				num = (short)2028142592;
				if (num != 0)
				{
				}
				return this.b.Peek().d();
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0003DE9C File Offset: 0x0003C09C
		internal void a(string A_0, long A_1, int A_2)
		{
			int a_ = 17;
			short num = (short)605945856;
			short num2 = num;
			num = (short)2021823973;
			short num3 = num;
			num = (short)524326373;
			switch (num3 == num)
			{
			}
			num = (short)1772617728;
			if (num != 0)
			{
			}
			num = (short)2114453505;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Start);
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮩\udeab\udaad\ud9af욱\uddb3\ud9b5횷", a_), A_0, A_1, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.f), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Partition, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[1]);
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧캩", a_));
			this.a.WriteValue(A_2);
			this.a.WriteEndAttribute();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		internal void f()
		{
			short num = (short)1641283584;
			short num2 = num;
			num = (short)322570642;
			short num3 = num;
			num = (short)606931346;
			switch (num3 == num)
			{
			}
			num = (short)1159528448;
			if (num != 0)
			{
			}
			num = (short)1364721665;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Partition, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[1]);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0003E068 File Offset: 0x0003C268
		internal void b(string A_0, long A_1, int A_2)
		{
			int a_ = 4;
			short num = (short)1139343360;
			short num2 = num;
			num = (short)1762317164;
			short num3 = num;
			num = (short)861786988;
			switch (num3 == num)
			{
			}
			num = (short)1173880833;
			if (num != 0)
			{
			}
			num = (short)1382678528;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튚爵철", a_), A_0, A_1, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.g), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Partition
			});
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠", a_));
			this.a.WriteValue(A_2);
			this.a.WriteEndAttribute();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0003E178 File Offset: 0x0003C378
		internal void g()
		{
			short num = (short)416874496;
			short num2 = num;
			num = (short)1877369431;
			short num3 = num;
			num = (short)1166697047;
			switch (num3 == num)
			{
			}
			num = (short)1674182656;
			if (num != 0)
			{
			}
			num = (short)1491992577;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Partition
			});
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0003E234 File Offset: 0x0003C434
		internal void a(long A_0, int A_1)
		{
			int a_ = 1;
			short num = (short)443219968;
			short num2 = num;
			num = (short)1882712845;
			short num3 = num;
			num = (short)2115627789;
			switch (num3 == num)
			{
			}
			num = (short)780533760;
			if (num != 0)
			{
			}
			num = (short)741670913;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc97ﮙﾝ", a_), null, A_0, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.h), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ItemData, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item
			});
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ", a_));
			this.a.WriteValue(A_1);
			this.a.WriteEndAttribute();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0003E344 File Offset: 0x0003C544
		internal void h()
		{
			short num = (short)2105475072;
			short num2 = num;
			num = (short)720860495;
			short num3 = num;
			num = (short)1960539471;
			switch (num3 == num)
			{
			}
			num = (short)1359872001;
			if (num != 0)
			{
			}
			num = (short)901644288;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ItemData, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item
			});
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0003E404 File Offset: 0x0003C604
		internal void b(long A_0, int A_1)
		{
			int a_ = 4;
			short num = (short)2031616;
			short num2 = num;
			num = (short)1022427137;
			if (num != 0)
			{
			}
			num = (short)2080963546;
			short num3 = num;
			num = (short)1288698842;
			switch (num3 == num)
			{
			}
			num = (short)1230700544;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펚ﺞ얠욢힤", a_), null, A_0, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.i), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Header, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure
			});
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠", a_));
			this.a.WriteValue(A_1);
			this.a.WriteEndAttribute();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0003E514 File Offset: 0x0003C714
		internal void i()
		{
			short num = (short)1865613312;
			short num2 = num;
			num = (short)1494548481;
			if (num != 0)
			{
			}
			num = (short)2106572704;
			short num3 = num;
			num = (short)289128352;
			switch (num3 == num)
			{
			}
			num = (short)421789696;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Header, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Item,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure
			});
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
		internal void a(string A_0, long A_1, int A_2, string A_3)
		{
			int a_ = 1;
			short num = (short)1100152832;
			short num2 = num;
			num = (short)2064301722;
			short num3 = num;
			num = (short)1631239834;
			switch (num3 == num)
			{
			}
			num = (short)166526976;
			if (num != 0)
			{
			}
			num = (short)1228865537;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮗쎟횡톣풥춧", a_), null, A_1, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.j), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ItemData
			});
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ", a_));
			this.a.WriteValue(A_2);
			this.a.WriteEndAttribute();
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ", a_), A_3);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0003E700 File Offset: 0x0003C900
		internal void j()
		{
			short num = (short)1381498880;
			short num2 = num;
			num = (short)331407701;
			short num3 = num;
			num = (short)617079125;
			switch (num3 == num)
			{
			}
			num = (short)754122752;
			if (num != 0)
			{
			}
			num = (short)1631125505;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ItemData
			});
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0003E7BC File Offset: 0x0003C9BC
		internal void a(string A_0, long A_1)
		{
			int a_ = 18;
			short num = (short)1348534272;
			short num2 = num;
			num = (short)1476538910;
			short num3 = num;
			num = (short)289223198;
			switch (num3 == num)
			{
			}
			num = (short)2145320960;
			if (num != 0)
			{
			}
			num = (short)1771110401;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud9aa좬캮", a_), A_0, A_1, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.k), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Area, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure
			});
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0003E89C File Offset: 0x0003CA9C
		internal void k()
		{
			short num = (short)384958464;
			short num2 = num;
			num = (short)326264177;
			short num3 = num;
			num = (short)1913152881;
			switch (num3 == num)
			{
			}
			num = (short)1809711104;
			if (num != 0)
			{
			}
			num = (short)2014117889;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Area, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Structure
			});
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0003E954 File Offset: 0x0003CB54
		internal void b(long A_0)
		{
			int a_ = 1;
			short num = (short)1110245376;
			short num2 = num;
			num = (short)581175081;
			short num3 = num;
			num = (short)310773545;
			switch (num3 == num)
			{
			}
			num = (short)853606400;
			if (num != 0)
			{
			}
			num = (short)1775894529;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풗첡킣풥톧", a_), null, A_0, new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a(this.k), global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ListEntry, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Area
			});
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0003EA34 File Offset: 0x0003CC34
		internal void l()
		{
			short num = (short)1222377472;
			short num2 = num;
			num = (short)1443402734;
			short num3 = num;
			num = (short)808031214;
			switch (num3 == num)
			{
			}
			num = (short)1330708481;
			if (num != 0)
			{
			}
			num = (short)597753856;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ListEntry, new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Area
			});
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0003EAF0 File Offset: 0x0003CCF0
		internal void a(string A_0, long A_1, bool A_2, int A_3, byte A_4)
		{
			int a_ = 18;
			short num = (short)309329920;
			short num2 = num;
			num = (short)736057314;
			short num3 = num;
			num = (short)1850759138;
			switch (num3 == num)
			{
			}
			num = (short)518127617;
			if (num != 0)
			{
			}
			num = (short)1987706880;
			if (num != 0)
			{
			}
			this.a(A_1);
			this.a(this.e);
			this.b.Peek();
			this.a(A_2.GetType().Name, A_0, A_1, 1);
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮨슪\ud9ac", a_));
			this.a.WriteValue(A_3);
			this.a.WriteEndAttribute();
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒨쪪\udeac쒮", a_));
			byte[] array = this.a(A_4, A_4.GetType());
			this.a.WriteBinHex(array, 0, array.Length);
			this.a.WriteEndAttribute();
			this.a.WriteValue(A_2);
			this.a();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0003EC6C File Offset: 0x0003CE6C
		internal void a(string A_0, long A_1, object A_2)
		{
			short num = (short)623116288;
			short num2 = num;
			global::System.Type type = A_2.GetType();
			if (!this.a(type))
			{
				num = (short)560090553;
				short num3 = num;
				num = (short)41110969;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)780795905;
					if (num != 0)
					{
					}
					num = (short)786956288;
					if (num != 0)
					{
					}
					throw new global::System.InvalidOperationException();
				}
			}
			this.a(type.Name, A_0, A_1, this.b(type));
			this.a.WriteValue(A_2);
			this.a();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0003ED58 File Offset: 0x0003CF58
		internal void a(string A_0, long A_1, object A_2, int A_3, int A_4, object A_5)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			global::System.Type type;
			short num2;
			global::System.Type type2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_61;
				case 1:
					while (!this.a(type))
					{
						num2 = (short)1339295554;
						short num3 = num2;
						num2 = (short)55183170;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1829044224;
							if (num2 != 0)
							{
							}
							num2 = (short)449118210;
							num = (int)((global::System.IntPtr)num2);
							goto IL_13;
						}
					}
					goto IL_157;
				case 2:
					goto IL_123;
				case 3:
					if (!this.a(type2))
					{
						num2 = (short)2130903040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					type = A_5.GetType();
					num2 = (short)883556353;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_61:
			num2 = (short)1382285313;
			if (num2 != 0)
			{
			}
			throw new global::System.InvalidOperationException();
			IL_123:
			num2 = (short)486277120;
			short num4 = num2;
			throw new global::System.InvalidOperationException();
			IL_157:
			this.a(type2.Name, A_0, A_1, this.b(type2));
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶛ쮟", a_));
			byte[] array = this.a(A_5, type);
			this.a.WriteBinHex(array, 0, array.Length);
			this.a.WriteEndAttribute();
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒡슣향춧\udea9", a_));
			this.a.WriteValue(A_3);
			this.a.WriteEndAttribute();
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟", a_));
			this.a.WriteValue(A_4);
			this.a.WriteEndAttribute();
			this.a.WriteValue(A_2);
			this.a();
			return;
			IL_29:
			type2 = A_2.GetType();
			num2 = (short)730529795;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0003EF84 File Offset: 0x0003D184
		internal void a(string A_0, long A_1, int A_2, string A_3, char A_4, string A_5)
		{
			int a_ = 13;
			short num = (short)2085945345;
			if (num != 0)
			{
			}
			num = (short)848235878;
			short num2 = num;
			num = (short)409603430;
			switch (num2 == num)
			{
			default:
			{
				num = (short)108134400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1285029888;
			if (num != 0)
			{
			}
			this.a(A_0, A_1, A_2, A_3, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좣쎥캧\udea9", a_), new char?(A_4), A_5);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003F05C File Offset: 0x0003D25C
		internal void a(string A_0, long A_1, int A_2, string A_3, string A_4)
		{
			int a_ = 3;
			short num = (short)840964777;
			short num2 = num;
			num = (short)442047145;
			switch (num2 == num)
			{
			}
			num = (short)33161216;
			short num3 = num;
			num = (short)1977090048;
			if (num != 0)
			{
			}
			num = (short)2146304001;
			if (num != 0)
			{
			}
			this.a(A_0, A_1, A_2, A_3, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("劣좟횡", a_), null, A_4);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0003F130 File Offset: 0x0003D330
		private void a(string A_0, long A_1, int A_2, string A_3, string A_4, char? A_5, string A_6)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (A_5.Value == '\0')
					{
						num2 = (short)792920068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1617783917;
					short num3 = num2;
					num2 = (short)695495789;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_208;
					case 1:
						break;
					default:
					{
						num2 = (short)1019805696;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)483000320;
					if (num2 != 0)
					{
					}
					this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얟킡즣쾥욧쮩\ud8ab솭슯", a_), string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("邟\udfa1", a_), A_5.Value));
					num2 = (short)1894711297;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1C5;
				case 2:
					goto IL_208;
				case 3:
					num2 = (short)1165361153;
					if (num2 != 0)
					{
					}
					num2 = (short)686555136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얟킡즣쾥욧쮩\ud8ab솭슯", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슝邟", a_));
					num2 = (short)523829250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (A_4 == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얟쒡킣", a_))
					{
						num2 = (short)728694787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_272;
				}
				goto IL_31;
			}
			IL_1C5:
			IL_208:
			IL_272:
			this.a.WriteString(A_6.Replace(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("麝", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슝邟", a_)));
			this.a();
			return;
			IL_31:
			this.a(A_6.GetType().Name, A_0, A_1, A_2);
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ캟송쮣슥솧쒩쮫", a_), A_3);
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶝ좟쎡횣향", a_));
			this.a.WriteValue(A_6.Length);
			this.a.WriteEndAttribute();
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햟톡킣쾥캧쎩쾫쾭쒯\udbb1\udbb3\ud8b5", a_), A_4);
			num2 = (short)1253441541;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0003F3E4 File Offset: 0x0003D5E4
		internal void a(string A_0, long A_1, string A_2, char A_3, byte[] A_4, int A_5, int A_6)
		{
			int a_ = 17;
			short num = (short)1839114812;
			short num2 = num;
			num = (short)1504684604;
			switch (num2 == num)
			{
			}
			num = (short)1247019008;
			short num3 = num;
			num = (short)1346699265;
			if (num != 0)
			{
			}
			num = (short)274792448;
			if (num != 0)
			{
			}
			this.a(A_3.GetType().Name, A_0, A_1, A_6);
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧쒩쾫솭풯\udbb1\udab3통", a_), A_2);
			this.a.WriteValue((int)A_3);
			this.a();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		internal void a(string A_0, long A_1, string A_2, char A_3, byte A_4, bool A_5)
		{
			int a_ = 8;
			short num = (short)699264114;
			short num2 = num;
			num = (short)2032856178;
			switch (num2 == num)
			{
			}
			num = (short)1707474944;
			short num3 = num;
			num = (short)71172097;
			if (num != 0)
			{
			}
			num = (short)285605888;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc9e즠슢힤", a_), A_0, A_1, 1);
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("爵쾠삢쪤쎦삨얪쪬", a_), A_2);
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠솢잤쮦첨", a_));
			this.a.WriteValue(A_5 ? global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("토펢삤햦", a_) : global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캠풢삤햦", a_));
			this.a.WriteEndAttribute();
			this.a.WriteValue((int)this.a(A_4, A_5));
			this.a();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0003F634 File Offset: 0x0003D834
		internal void a(string A_0, long A_1, object A_2, object A_3)
		{
			int a_ = 7;
			short num = (short)1143865344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Type type;
				global::System.Type type2;
				for (;;)
				{
					IL_27:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_84;
						case 1:
						{
							num = (short)1104756812;
							short num3 = num;
							num = (short)405880908;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num = (short)1548353536;
								if (num != 0)
								{
								}
								if (!this.a(type))
								{
									num = (short)1616576514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A;
							}
							break;
						}
						case 2:
							goto IL_16F;
						case 3:
							if (!this.a(type2))
							{
								num = (short)1723727872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							type = A_3.GetType();
							num = (short)913506305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_48:
					type2 = A_2.GetType();
					num = (short)1894580227;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				IL_84:
				num = (short)61997057;
				if (num != 0)
				{
				}
				throw new global::System.InvalidOperationException();
				IL_16F:
				num = (short)61800448;
				short num4 = num;
				throw new global::System.InvalidOperationException();
				IL_17A:
				int num5 = this.b(type2);
				int num6 = this.b(type);
				this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힝펟쪡튥춧잩쾭\uddafힱ", a_), A_0, A_1, null, global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.CompositeField, this.e);
				this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟\ud8a1솣", a_));
				this.a.WriteValue(num5 + num6);
				this.a.WriteEndAttribute();
				this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪝\ud99f튡솣", a_), A_1, A_2);
				this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힝쒟", a_), A_1 + (long)num5, A_3);
				this.a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.CompositeField, this.e);
				return;
			}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0003F85C File Offset: 0x0003DA5C
		internal void a(string A_0, long A_1, string A_2, byte[] A_3, int A_4, int A_5)
		{
			int a_ = 13;
			short num = (short)2075784454;
			short num2 = num;
			num = (short)133887238;
			switch (num2 == num)
			{
			}
			num = (short)1759313920;
			short num3 = num;
			num = (short)2106327040;
			if (num != 0)
			{
			}
			num = (short)544342017;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캩좫\udcad햯솱잳", a_), A_0, A_1, A_5);
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킣\udfa5\ud8a7쾩", a_), A_2);
			this.a.WriteBinHex(A_3, A_4, A_5);
			this.a();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0003F954 File Offset: 0x0003DB54
		internal void a(long A_0, int A_1, byte A_2)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			int num2;
			short num3;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 >= A_1)
					{
						num3 = (short)1958215681;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.a.WriteString(text);
					num2++;
					goto IL_1AA;
				case 1:
				{
					num3 = (short)1865455850;
					short num4 = num3;
					num3 = (short)678074602;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						goto IL_182;
					}
					break;
				}
				case 2:
					goto IL_F1;
				case 3:
					goto IL_F1;
				}
				goto IL_29;
				IL_F1:
				num3 = (short)815988736;
				short num5 = num3;
				num3 = (short)2064908288;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1AA:
				num3 = (short)1839398914;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_182:
			num3 = (short)1445462016;
			if (num3 != 0)
			{
			}
			this.a();
			return;
			IL_29:
			num3 = (short)1927020545;
			if (num3 != 0)
			{
			}
			this.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udeab\udcad톯쮱", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("睊춫쪭풯\udbb1\udab3통", a_), A_0, A_1);
			this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea9햫\udead햯", a_), A_2.GetType().Name);
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즩쎫\udbad\udeaf욱", a_));
			this.a.WriteValue(A_1);
			this.a.WriteEndAttribute();
			text = this.a(A_2);
			num2 = 0;
			num3 = (short)1462370307;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0003FB30 File Offset: 0x0003DD30
		private char a(byte A_0, bool A_1)
		{
			int a_ = 6;
			short num = (short)851969;
			if (num != 0)
			{
			}
			if (A_1)
			{
				num = (short)1178558104;
				short num2 = num;
				num = (short)315121304;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)199688192;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)395968512;
				short num3 = num;
				return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("궜꺞鎠邢醤銦龨鲪閬隮ﲸﶺ", a_)[A_0 >> 4];
			}
			return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("궜꺞鎠邢醤銦龨鲪閬隮ﲸﶺ", a_)[(int)(A_0 & 15)];
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0003FC18 File Offset: 0x0003DE18
		private string a(byte A_0)
		{
			int a_ = 17;
			short num = (short)1916862465;
			if (num != 0)
			{
			}
			num = (short)1680517967;
			short num2 = num;
			num = (short)1624681295;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1177223168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1782513664;
			if (num != 0)
			{
			}
			return string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펧骩톫햭膯쾱", a_), this.a(A_0, true), this.a(A_0, false));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0003FCF4 File Offset: 0x0003DEF4
		internal void m()
		{
			short num = (short)1801453569;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_203;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 2:
				{
					num = (short)1316372252;
					short num3 = num;
					num = (short)1625505564;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_229;
					default:
					{
						num = (short)522059776;
						if (num != 0)
						{
						}
						num = (short)559677441;
						if (num != 0)
						{
						}
						global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b b;
						b.f()();
						num = (short)244056072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_229;
				case 4:
				{
					num = (short)1310392320;
					short num4 = num;
					global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b b;
					if (b.f() != null)
					{
						num = (short)1206255618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				}
				case 5:
					goto IL_1BF;
				case 6:
				{
					if (this.b.Count <= 0)
					{
						num = (short)817561600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b b = this.b.Peek();
					num = (short)1656946692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (this.d)
					{
						num = (short)1352269829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.Flush();
					num = (short)1500774409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_206;
				case 9:
					goto IL_1C4;
				case 10:
					return;
				}
				IL_51:
				if (this.c)
				{
					num = (short)367788042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2114715655;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)1846149126;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_229:
				goto IL_1C4;
				IL_206:
				this.b.Pop();
				num = (short)1075445763;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1BF:
			throw new global::System.InvalidOperationException();
			IL_203:
			this.c = true;
			this.a.Close();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0003FF6C File Offset: 0x0003E16C
		private int a(global::System.TypeCode A_0)
		{
			short num = (short)283836422;
			int num2 = (int)((global::System.IntPtr)num);
			int result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					num = (short)764542984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					goto IL_157;
				case 6:
					num = (short)140443649;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					continue;
				case 7:
					goto IL_118;
				case 8:
				{
					num = (short)1418419018;
					short num3 = num;
					num = (short)1475566410;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num = (short)2042822656;
						if (num != 0)
						{
						}
						result = 0;
						num = (short)1135476748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					return result;
				case 10:
					return result;
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					goto IL_137;
				case 14:
					return result;
				case 15:
					goto IL_FA;
				}
				IL_8C:
				switch (A_0)
				{
				case global::System.TypeCode.Boolean:
					result = 1;
					num = (short)1506607104;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Char:
					result = 2;
					num = (short)423690255;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.SByte:
					result = 1;
					num = (short)867041293;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Byte:
					result = 1;
					num = (short)2147287044;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Int16:
					result = 2;
					num = (short)800391179;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.UInt16:
					result = 2;
					num = (short)1099956226;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Int32:
					result = 4;
					num = (short)1806368782;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.UInt32:
					result = 4;
					num = (short)1764163594;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Int64:
					result = 8;
					num = (short)1825636359;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.UInt64:
					result = 8;
					num = (short)650313731;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Single:
					result = 4;
					num = (short)1041170441;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::System.TypeCode.Double:
					IL_13C:
					result = 8;
					num = (short)212008965;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)389545985;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FA:
			IL_118:
			IL_137:
			return result;
			IL_157:
			num = (short)1355546624;
			short num4 = num;
			return result;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00040270 File Offset: 0x0003E470
		private int b(global::System.Type A_0)
		{
			short num = (short)664513277;
			short num2 = num;
			num = (short)632466173;
			switch (num2 == num)
			{
			}
			num = (short)1174142976;
			short num3 = num;
			num = (short)739180545;
			if (num != 0)
			{
			}
			num = (short)358678528;
			if (num != 0)
			{
			}
			return this.a(global::System.Type.GetTypeCode(A_0));
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00040328 File Offset: 0x0003E528
		private bool a(global::System.Type A_0)
		{
			short num = (short)647791713;
			short num2 = num;
			num = (short)1197966433;
			switch (num2 == num)
			{
			}
			num = (short)774045696;
			short num3 = num;
			num = (short)1571291136;
			if (num != 0)
			{
			}
			num = (short)2080636929;
			if (num != 0)
			{
			}
			global::System.TypeCode typeCode;
			return this.a(A_0, out typeCode);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000403DC File Offset: 0x0003E5DC
		private bool a(global::System.Type A_0, out global::System.TypeCode A_1)
		{
			A_1 = global::System.Type.GetTypeCode(A_0);
			global::System.TypeCode typeCode = A_1;
			if (typeCode - global::System.TypeCode.SByte <= 7)
			{
				short num = (short)1764884327;
				short num2 = num;
				num = (short)1587412839;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1104084992;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)2121203713;
				if (num != 0)
				{
				}
				num = (short)1422983168;
				short num3 = num;
				return true;
			}
			return false;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0004049C File Offset: 0x0003E69C
		private void a(object A_0, int A_1, int A_2)
		{
			int a_ = 8;
			global::System.Type type = A_0.GetType();
			if (!this.a(type))
			{
				short num = (short)566149232;
				short num2 = num;
				num = (short)260096112;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1889468417;
					if (num != 0)
					{
					}
					num = (short)2098921472;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)334168064;
				short num3 = num;
				throw new global::System.InvalidOperationException();
			}
			this.a.WriteStartElement(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튞삠킢캤", a_));
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶞ좠힢솦쾨\ud8aa좬\udbae", a_));
			this.a.WriteValue(A_1);
			this.a.WriteEndAttribute();
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶞ좠힢횤", a_));
			this.a.WriteValue(A_2);
			this.a.WriteEndAttribute();
			byte[] array = this.a(A_0, type);
			this.a.WriteBinHex(array, 0, array.Length);
			this.a.WriteFullEndElement();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00040604 File Offset: 0x0003E804
		private byte[] a(object A_0, global::System.Type A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::System.TypeCode typeCode;
			byte[] result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CC;
				case 1:
					goto IL_255;
				case 2:
					switch (typeCode)
					{
					case global::System.TypeCode.Boolean:
						result = global::System.BitConverter.GetBytes((bool)A_0);
						num2 = (short)1372454917;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Char:
						goto IL_200;
					case global::System.TypeCode.SByte:
						result = global::System.BitConverter.GetBytes((short)((sbyte)A_0));
						num2 = (short)491978762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Byte:
						result = global::System.BitConverter.GetBytes((short)((byte)A_0));
						num2 = (short)858521601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Int16:
						result = global::System.BitConverter.GetBytes((short)A_0);
						num2 = (short)459341827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt16:
						result = global::System.BitConverter.GetBytes((ushort)A_0);
						num2 = (short)1936195593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Int32:
						result = global::System.BitConverter.GetBytes((int)A_0);
						num2 = (short)952827908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt32:
						result = global::System.BitConverter.GetBytes((uint)A_0);
						num2 = (short)2028077056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Int64:
						result = global::System.BitConverter.GetBytes((long)A_0);
						num2 = (short)600899590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt64:
						result = global::System.BitConverter.GetBytes((ulong)A_0);
						num2 = (short)1616904200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)119537675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 3:
					goto IL_22D;
				case 4:
					goto IL_27B;
				case 5:
					goto IL_11D;
				case 6:
					goto IL_1FB;
				case 7:
					goto IL_1D6;
				case 8:
					goto IL_190;
				case 9:
					goto IL_F4;
				case 10:
					return result;
				case 11:
				{
					num2 = (short)478478336;
					short num3 = num2;
					num2 = (short)1534394375;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_40;
			}
			IL_CC:
			IL_F4:
			return result;
			IL_11D:
			num2 = (short)1535355157;
			short num4 = num2;
			num2 = (short)651798805;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1334312960;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_190:
			return result;
			IL_1D6:
			goto IL_200;
			IL_1FB:
			return result;
			IL_200:
			result = null;
			throw new global::System.NotSupportedException();
			IL_22D:
			IL_255:
			return result;
			IL_27B:
			num2 = (short)537460737;
			if (num2 != 0)
			{
			}
			return result;
			IL_40:
			typeCode = global::System.Type.GetTypeCode(A_1);
			num2 = (short)767361026;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000408DC File Offset: 0x0003EADC
		private void d()
		{
			short num = (short)496541919;
			short num2 = num;
			num = (short)209035487;
			switch (num2 == num)
			{
			}
			num = (short)2040725504;
			short num3 = num;
			num = (short)918814721;
			if (num != 0)
			{
			}
			num = (short)844955648;
			if (num != 0)
			{
			}
			this.e = new global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[]
			{
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Header,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ItemData,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Area,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.ListEntry,
				global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.CompositeField
			};
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0004099C File Offset: 0x0003EB9C
		private global::System.Xml.XmlWriterSettings c()
		{
			short num = (short)664188955;
			short num2 = num;
			num = (short)403683355;
			switch (num2 == num)
			{
			}
			num = (short)1213136897;
			if (num != 0)
			{
			}
			num = (short)1361510400;
			if (num != 0)
			{
			}
			num = (short)500170752;
			short num3 = num;
			return new global::System.Xml.XmlWriterSettings
			{
				Encoding = global::System.Text.Encoding.UTF8,
				OmitXmlDeclaration = false,
				Indent = true,
				CloseOutput = false
			};
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00040A70 File Offset: 0x0003EC70
		private void b()
		{
			short num = (short)1246860665;
			short num2 = num;
			num = (short)636654969;
			switch (num2 == num)
			{
			}
			num = (short)126943233;
			if (num != 0)
			{
			}
			num = (short)2107047936;
			if (num != 0)
			{
			}
			num = (short)1939537920;
			short num3 = num;
			this.b = new global::System.Collections.Generic.Stack<global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b>();
			global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b item = new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState.Start);
			this.b.Push(item);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00040B38 File Offset: 0x0003ED38
		private void a(global::System.IO.Stream A_0, global::System.Xml.XmlWriterSettings A_1)
		{
			short num = (short)1430791308;
			short num2 = num;
			num = (short)1146889356;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1648361472;
				if (num != 0)
				{
				}
				num = (short)800915457;
				if (num != 0)
				{
				}
				if (A_1 != null)
				{
					num = (short)1239941120;
					short num3 = num;
					this.a = global::System.Xml.XmlWriter.Create(A_0, A_1);
					return;
				}
				break;
			}
			this.a = global::System.Xml.XmlWriter.Create(A_0, this.c());
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00040C08 File Offset: 0x0003EE08
		private void a(string A_0, global::System.Xml.XmlWriterSettings A_1)
		{
			short num = (short)29294593;
			if (num != 0)
			{
			}
			num = (short)665946864;
			short num2 = num;
			num = (short)918850288;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)262995968;
				if (num != 0)
				{
				}
				if (A_1 != null)
				{
					num = (short)327286784;
					short num3 = num;
					this.a = global::System.Xml.XmlWriter.Create(A_0, A_1);
					return;
				}
				break;
			}
			this.a = global::System.Xml.XmlWriter.Create(A_0, this.c());
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00040CD4 File Offset: 0x0003EED4
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_0)
		{
			short num = (short)1863962742;
			short num2 = num;
			num = (short)1317916790;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)935591937;
				if (num != 0)
				{
				}
				num = (short)834863104;
				if (num != 0)
				{
				}
				if (this.WriteState != A_0)
				{
					num = (short)234422272;
					short num3 = num;
					this.d = true;
					throw new global::System.InvalidOperationException();
				}
				break;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00040D98 File Offset: 0x0003EF98
		private void a(params global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[] A_0)
		{
			short num = (short)1868955648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_115;
					case 1:
						return;
					case 2:
						goto IL_115;
					case 3:
						goto IL_14C;
					case 4:
					{
						int num3;
						if (num3 >= A_0.Length)
						{
							num = (short)856555523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState writeState = A_0[num3];
						num = (short)1546780677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState writeState;
						global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState writeState2;
						if (writeState2 == writeState)
						{
							num = (short)614662145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)215089153;
						if (num != 0)
						{
						}
						int num3;
						num3++;
						num = (short)1151205376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_46;
					IL_115:
					num = (short)1078788100;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_14C:
				num = (short)960480919;
				short num4 = num;
				num = (short)482526871;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_46:
					global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState writeState2 = this.WriteState;
					int num3 = 0;
					num = (short)989396992;
					short num5 = num;
					num = (short)1268776962;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)665649152;
					if (num != 0)
					{
					}
					this.d = true;
					throw new global::System.InvalidOperationException();
				}
				break;
			}
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00040F4C File Offset: 0x0003F14C
		private void a(long A_0)
		{
			short num = (short)232641520;
			short num2 = num;
			num = (short)1235997680;
			switch (num2 == num)
			{
			}
			num = (short)1200881665;
			if (num != 0)
			{
			}
			num = (short)293928960;
			if (num != 0)
			{
			}
			num = (short)1956118528;
			short num3 = num;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00040FF8 File Offset: 0x0003F1F8
		private void a(string A_0, string A_1, long A_2, global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a A_3, global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_4, params global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[] A_5)
		{
			int a_ = 19;
			int num;
			short num2;
			global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b b;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1640789645;
						short num3 = num2;
						num2 = (short)2054190733;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50;
						default:
							num2 = (short)211681280;
							if (num2 != 0)
							{
							}
							num2 = (short)1370816513;
							if (num2 != 0)
							{
							}
							if (A_1 != null)
							{
								num2 = (short)2003894272;
								short num4 = num2;
								num2 = (short)655949827;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩춫쎭햯", a_), string.Empty);
							num2 = (short)1246167042;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_184;
					case 2:
						goto IL_14F;
					case 3:
						this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒩춫쎭햯", a_), A_1);
						num2 = (short)1527971841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29;
				}
				IL_14F:
				IL_184:
				this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얩쪫좭쎯ힱ삳", a_));
				this.a.WriteValue(A_2 - b.e());
				this.a.WriteEndAttribute();
				global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b item = new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b(A_4, A_2, A_3);
				this.b.Push(item);
				return;
			}
			}
			IL_29:
			this.a(A_2);
			this.a(A_5);
			b = this.b.Peek();
			this.a.WriteStartElement(A_0);
			IL_50:
			num2 = (short)977403904;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000411DC File Offset: 0x0003F3DC
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_0, params global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[] A_1)
		{
			short num = (short)1100283905;
			if (num != 0)
			{
			}
			num = (short)1277221592;
			short num2 = num;
			num = (short)1614863064;
			switch (num2 == num)
			{
			}
			num = (short)40304640;
			if (num != 0)
			{
			}
			num = (short)359202816;
			short num3 = num;
			this.a(A_0);
			this.a.WriteFullEndElement();
			this.b.Pop();
			this.a(A_1);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000412AC File Offset: 0x0003F4AC
		private void a(string A_0, string A_1, long A_2, int A_3)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (A_1 != null)
					{
						num2 = (short)1272512514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12D;
				case 1:
					goto IL_12B;
				case 2:
					goto IL_F8;
				}
				goto IL_25;
			}
			IL_12B:
			IL_12D:
			num2 = (short)944963585;
			if (num2 != 0)
			{
			}
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좦쾨춪\udeac쪮얰", a_));
			global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b b;
			this.a.WriteValue(A_2 - b.e());
			this.a.WriteEndAttribute();
			this.a.WriteStartAttribute(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풦삨톪좬", a_));
			this.a.WriteValue(A_3);
			this.a.WriteEndAttribute();
			return;
			IL_25:
			num2 = (short)536843721;
			short num3 = num2;
			num2 = (short)2011010505;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F8:
				this.a.WriteAttributeString(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즦좨욪좬", a_), A_1);
				num2 = (short)1843068929;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)454688768;
				if (num2 != 0)
				{
				}
				num2 = (short)1816592384;
				short num4 = num2;
				this.a(A_2);
				this.a(this.e);
				b = this.b.Peek();
				this.a.WriteStartElement(A_0);
				num2 = (short)1779564544;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00041478 File Offset: 0x0003F678
		private void a()
		{
			short num = (short)826164817;
			short num2 = num;
			num = (short)692602449;
			switch (num2 == num)
			{
			}
			num = (short)1313538048;
			if (num != 0)
			{
			}
			num = (short)1515061249;
			if (num != 0)
			{
			}
			num = (short)347668480;
			short num3 = num;
			this.a(this.e);
			this.a.WriteFullEndElement();
		}

		// Token: 0x040000F8 RID: 248
		private global::System.Xml.XmlWriter a;

		// Token: 0x040000F9 RID: 249
		private global::System.Collections.Generic.Stack<global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b> b;

		// Token: 0x040000FA RID: 250
		private bool c;

		// Token: 0x040000FB RID: 251
		private bool d;

		// Token: 0x040000FC RID: 252
		private global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState[] e;

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060002F1 RID: 753
		private delegate void a();

		// Token: 0x0200004E RID: 78
		private struct b
		{
			// Token: 0x060002F4 RID: 756 RVA: 0x00041538 File Offset: 0x0003F738
			public b(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_0)
			{
				this = new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b(A_0, 0L, null);
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x00041550 File Offset: 0x0003F750
			public b(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_0, long A_1)
			{
				this = new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.b(A_0, A_1, null);
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x00041568 File Offset: 0x0003F768
			public b(global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState A_0, long A_1, global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0004158C File Offset: 0x0003F78C
			public global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState d()
			{
				short num = (short)1969225729;
				if (num != 0)
				{
				}
				num = (short)1263408644;
				short num2 = num;
				num = (short)1946490372;
				switch (num2 == num)
				{
				}
				num = (short)928579584;
				if (num != 0)
				{
				}
				num = (short)1852571648;
				short num3 = num;
				return this.a;
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00041640 File Offset: 0x0003F840
			public long e()
			{
				short num = (short)165608681;
				short num2 = num;
				num = (short)319290601;
				switch (num2 == num)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				num = (short)208666625;
				if (num != 0)
				{
				}
				num = (short)2145058816;
				short num3 = num;
				return this.b;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000416F0 File Offset: 0x0003F8F0
			public global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a f()
			{
				short num = (short)2130462838;
				short num2 = num;
				num = (short)1356548214;
				switch (num2 == num)
				{
				}
				num = (short)1276641281;
				if (num != 0)
				{
				}
				num = (short)170131456;
				if (num != 0)
				{
				}
				num = (short)1301479424;
				short num3 = num;
				return this.c;
			}

			// Token: 0x040000FD RID: 253
			private global::Motorola.Acp.PackUnpack.Ish.Loggers.WriteState a;

			// Token: 0x040000FE RID: 254
			private long b;

			// Token: 0x040000FF RID: 255
			private global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger.a c;
		}
	}
}
