using System;
using System.IO;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000022 RID: 34
	public class IshItemFactory : global::Motorola.Acp.PackUnpack.Ish.IIshItemFactory<global::Motorola.Acp.PackUnpack.Ish.IshItem, global::Motorola.Acp.PackUnpack.Ish.IshType, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout>, global::Motorola.Acp.PackUnpack.Ish.IIshItemFactory<global::Motorola.Acp.PackUnpack.Ish.CompositeItem, global::Motorola.Acp.PackUnpack.Ish.CompositeType, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout>, global::Motorola.Acp.PackUnpack.Ish.IIshItemFactory<global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>, global::Motorola.Acp.PackUnpack.Ish.IIshItemFactory<global::Motorola.Acp.PackUnpack.Ish.ListListletItem, global::Motorola.Acp.PackUnpack.Ish.ListListletType, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout>
	{
		// Token: 0x06000142 RID: 322 RVA: 0x0001FE70 File Offset: 0x0001E070
		internal IshItemFactory()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001FE84 File Offset: 0x0001E084
		public global::Motorola.Acp.PackUnpack.Ish.IshItem CreateItem(global::Motorola.Acp.PackUnpack.Ish.IshType ishType, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader)
		{
			int a_ = 5;
			short num = (short)256704524;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.IshItem result;
			for (;;)
			{
				num = (short)1678966785;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_160;
				case 1:
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num = (short)1135280137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 2:
					result = this.CreateItem(ishType as global::Motorola.Acp.PackUnpack.Ish.ListListletType, id, layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, length, reader);
					num = (short)73596939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num = (short)359792642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2143617025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_303;
				case 5:
					if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num = (short)837812231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2036989955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_AD;
				case 7:
					result = this.CreateItem(ishType as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType, id, layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, length, reader);
					num = (short)2129395722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (reader == null)
					{
						num = (short)1871511556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = null;
					num = (short)1204879365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_130;
				case 10:
					goto IL_117;
				case 11:
					goto IL_E1;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					continue;
				case 13:
					goto IL_1E4;
				case 14:
					if (layout == null)
					{
						num = (short)1549533197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)371064840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_90:
				if (ishType == null)
				{
					num = (short)591986694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2021911939;
				short num3 = num;
				num = (short)1477176707;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)246939648;
					if (num != 0)
					{
					}
					num = (short)635502606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_130:
				result = this.CreateItem(ishType as global::Motorola.Acp.PackUnpack.Ish.CompositeType, id, layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout, length, reader);
				num = (short)830668800;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좟\udda3횥춧", a_));
			IL_E1:
			IL_117:
			IL_160:
			goto IL_308;
			IL_1E4:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ\ud99f춡톣튥", a_));
			IL_225:
			throw new global::System.InvalidCastException();
			IL_303:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ솟욡솣풥", a_));
			IL_308:
			num = (short)1189806080;
			short num4 = num;
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000201C4 File Offset: 0x0001E3C4
		public global::Motorola.Acp.PackUnpack.Ish.CompositeItem CreateItem(global::Motorola.Acp.PackUnpack.Ish.CompositeType ishType, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader)
		{
			int a_ = 17;
			while (reader == null)
			{
				short num = (short)288061524;
				short num2 = num;
				num = (short)675248212;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1972568064;
					short num3 = num;
					num = (short)1381564417;
					if (num != 0)
					{
					}
					num = (short)59506688;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa7쾩춫쪭햯삱", a_));
				}
				}
			}
			global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream = reader.BaseStream;
			byte[] a_2 = baseStream.a();
			int a_3 = baseStream.b();
			global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a_4 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(a_2, a_3, length, false, false);
			baseStream.b(length);
			return new global::Motorola.Acp.PackUnpack.Ish.CompositeItem(ishType, id, a_4, layout);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000202C4 File Offset: 0x0001E4C4
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem CreateItem(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader)
		{
			int a_ = 11;
			short num = (short)1788870656;
			switch (num)
			{
			default:
			{
				num = (short)2046033932;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a_2;
				int num6;
				int a_4;
				int a_5;
				int a_6;
				global::Motorola.Acp.PackUnpack.Ish.IshItemName a_9;
				global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a_10;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_33E;
					case 1:
						goto IL_39B;
					case 2:
						goto IL_2F6;
					case 3:
						goto IL_1AF;
					case 4:
						goto IL_C0;
					case 5:
						goto IL_2A6;
					case 6:
						goto IL_C0;
					case 7:
						num = (short)2062221313;
						if (num != 0)
						{
						}
						num = (short)1930166285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num3 > 0)
						{
							num = (short)1589837840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_2 = null;
						num = (short)188743698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num4;
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream;
						if ((long)num4 > this.a(baseStream))
						{
							goto IL_326;
						}
						byte[] a_3;
						long num5;
						a_2 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(a_3, (int)num5, num4, false, false);
						num5 += (long)baseStream.b(num4);
						num = (short)1453588482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						if (num6 > layout.ListEntryLayout.Size)
						{
							num = (short)686227457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_4 = (int)reader.ReadUInt16();
						reader.ReadUInt16();
						a_5 = (int)reader.ReadUInt16();
						a_6 = (int)reader.ReadUInt16();
						num3 = (int)reader.ReadUInt16();
						int a_7 = (int)reader.ReadUInt16();
						int a_8 = (int)reader.ReadUInt16();
						a_9 = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(a_7, a_8);
						int num7 = (int)reader.ReadUInt16();
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream = reader.BaseStream;
						byte[] a_3 = baseStream.a();
						int num8;
						int num9;
						baseStream.a(out num8, out num9);
						long num5 = (long)num8 + baseStream.Position;
						num = (short)421396491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num7;
						if (num7 > 0)
						{
							num = (short)1806761991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_10 = null;
						num = (short)1776943110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 13:
					{
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream;
						int num7;
						if ((long)num7 > this.a(baseStream))
						{
							num = (short)1244987397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] a_3;
						long num5;
						a_10 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(a_3, (int)num5, num7, false, false);
						num5 += (long)baseStream.b(num7);
						num = (short)943063044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1481113610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num6 != 0)
						{
							num = (short)1796014094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					case 16:
					{
						int num4 = num3 * num6;
						num = (short)449445897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_BB;
					case 18:
					{
						num = (short)1050608801;
						short num10 = num;
						num = (short)348652705;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_326;
						default:
							goto IL_224;
						}
						break;
					}
					case 19:
						if (reader == null)
						{
							num = (short)1175126019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = (int)reader.ReadUInt16();
						num = (short)741212175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9D:
					if (length <= 0)
					{
						num = (short)819855377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1802633235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0:
					num = (short)540737536;
					short num11 = num;
					num = (short)178782216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_326:
					num = (short)644087808;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BB:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캡솣좥쾧\udea9쒫", a_));
				IL_1AF:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("킡솣장첧쾩\udeab", a_));
				IL_224:
				num = (short)1616838656;
				if (num != 0)
				{
				}
				goto IL_48F;
				IL_2A6:
				throw new global::System.IO.InvalidDataException();
				IL_2F6:
				goto IL_48F;
				IL_33E:
				throw new global::System.IO.InvalidDataException();
				IL_343:
				throw new global::System.IO.InvalidDataException();
				IL_39B:
				goto IL_343;
				IL_48F:
				return new global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem(ishType, id, a_4, a_6, a_5, a_10, num3, a_2, num6, a_9, layout);
			}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00020774 File Offset: 0x0001E974
		public global::Motorola.Acp.PackUnpack.Ish.ListListletItem CreateItem(global::Motorola.Acp.PackUnpack.Ish.ListListletType ishType, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader)
		{
			int a_ = 8;
			short num = (short)1638793216;
			switch (num)
			{
			default:
			{
				num = (short)622395393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)596115456;
						short num3 = num;
						if (reader == null)
						{
							num = (short)1649344514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1097757342;
						short num4 = num;
						num = (short)255226526;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B6;
						default:
							goto IL_162;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 2:
						goto IL_116;
					case 3:
						goto IL_78;
					}
					IL_5D:
					if (length <= 0)
					{
						num = (short)1637679107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B6:
					num = (short)62849024;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_78:
				num = (short)1704525825;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠춢스펦솨", a_));
				IL_116:
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠슢솤슦\udba8", a_));
				IL_162:
				num = (short)1525809152;
				if (num != 0)
				{
				}
				int a_2 = (int)reader.ReadUInt16();
				int a_3 = (int)reader.ReadUInt16();
				int a_4 = (int)reader.ReadUInt16();
				global::Motorola.Acp.PackUnpack.Ish.IshItemName a_5 = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(a_3, a_4);
				int num5 = length - 6;
				global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream = reader.BaseStream;
				byte[] a_6 = baseStream.a();
				int a_7 = baseStream.b();
				global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a_8 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(a_6, a_7, num5, false, false);
				baseStream.b(num5);
				return new global::Motorola.Acp.PackUnpack.Ish.ListListletItem(ishType, id, a_2, a_8, a_5, layout);
			}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0002095C File Offset: 0x0001EB5C
		private long a(global::System.IO.Stream A_0)
		{
			long num;
			short num2;
			for (;;)
			{
				num = A_0.Length - A_0.Position;
				if (num < 0L)
				{
					goto IL_B6;
				}
				num2 = (short)467430909;
				short num3 = num2;
				num2 = (short)1506897405;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4C;
				}
			}
			IL_4C:
			num2 = (short)248840192;
			short num4 = num2;
			num2 = (short)907476993;
			if (num2 != 0)
			{
			}
			num2 = (short)879689728;
			if (num2 != 0)
			{
			}
			return num;
			IL_B6:
			return 0L;
		}
	}
}
