using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AcpCommonLib;
using AcpUtility;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Exceptions;
using Motorola.Acp.PackUnpack.Ish.Fields;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000049 RID: 73
	public class Unpacker
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00039230 File Offset: 0x00037430
		static Unpacker()
		{
			short num = (short)374472705;
			if (num != 0)
			{
			}
			num = (short)1046877088;
			short num2 = num;
			num = (short)54137760;
			switch (num2 == num)
			{
			}
			num = (short)302514176;
			if (num != 0)
			{
			}
			num = (short)985399296;
			short num3 = num;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000392E0 File Offset: 0x000374E0
		internal Unpacker() : this(new global::Motorola.Acp.PackUnpack.Ish.Crc16Generator(), new global::Motorola.Acp.PackUnpack.Ish.IshItemFactory(), new global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager())
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00039304 File Offset: 0x00037504
		public Unpacker(global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager dataExchangeManager) : this(new global::Motorola.Acp.PackUnpack.Ish.Crc16Generator(), new global::Motorola.Acp.PackUnpack.Ish.IshItemFactory(), dataExchangeManager)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00039324 File Offset: 0x00037524
		internal Unpacker(global::Motorola.Acp.PackUnpack.Ish.Crc16Generator A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemFactory A_1)
		{
			int a_ = 2;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("滛ﺜ\ud89e쒠춢삤햦좨\udfaa슬\uddae", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슢욤펦욨\ud9aa풬", a_));
			}
			this.a = A_0;
			this.b = A_1;
			this.c = null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00039388 File Offset: 0x00037588
		internal Unpacker(global::Motorola.Acp.PackUnpack.Ish.Crc16Generator A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemFactory A_1, global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager A_2)
		{
			int a_ = 8;
			this..ctor(A_0, A_1);
			if (A_2 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udb9e삠힢쒤톨좪얬캮\udfb0풲킴襁\ud8b8햺\udcbc\ud8be꓀뇂", a_));
			}
			this.c = A_2;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000393C8 File Offset: 0x000375C8
		internal global::Motorola.Acp.PackUnpack.Ish.Crc16Generator CrcGenerator
		{
			get
			{
				short num = (short)35374427;
				short num2 = num;
				num = (short)2041234779;
				switch (num2 == num)
				{
				}
				num = (short)386072577;
				if (num != 0)
				{
				}
				num = (short)1131806720;
				if (num != 0)
				{
				}
				num = (short)421724160;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00039478 File Offset: 0x00037678
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager ExchangeManager
		{
			get
			{
				short num = (short)612993547;
				short num2 = num;
				num = (short)507152907;
				switch (num2 == num)
				{
				}
				num = (short)687800321;
				if (num != 0)
				{
				}
				num = (short)1353187328;
				if (num != 0)
				{
				}
				num = (short)733347840;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0003952C File Offset: 0x0003772C
		internal global::Motorola.Acp.PackUnpack.Ish.IshItemFactory ItemFactory
		{
			get
			{
				short num = (short)761826376;
				short num2 = num;
				num = (short)378375240;
				switch (num2 == num)
				{
				}
				num = (short)1269497856;
				if (num != 0)
				{
				}
				num = (short)63045633;
				if (num != 0)
				{
				}
				num = (short)1459879936;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000395DC File Offset: 0x000377DC
		public virtual void Unpack(global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug)
		{
			int a_ = 11;
			short num = (short)1303314434;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2BC;
				case 1:
					if (codeplug.Partitions.Count == 0)
					{
						num = (short)1043005444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1210843136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					goto IL_5D;
				case 4:
					goto IL_29F;
				}
				IL_41:
				if (codeplug == null)
				{
					num = (short)1124859907;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1071775745;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5D:
			throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얣얥쎧誩\udcab\udcad\udfaf톱톳억쮷骹\uddbb\udcbd꾿냁냃ꏅ곇", a_), new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("송쮣슥춧\udaa9삫\udbad힯", a_)));
			IL_213:
			throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얣얥쎧誩\udcab\udcad\udfaf톱톳억쮷骹\uddbb\udcbd꾿냁냃ꏅ곇", a_), new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮣슥춧\udaa9삫\udbad힯銱\ud9b3쎵쮷캹鲻\uddbd꾿곁냃Ʂꇇ꓉꿍꓏룓돕맗꧙꣛ﻝ퇟싡铣蟥髧黩藫髭駯鷱髳", a_)));
			IL_29F:
			goto IL_213;
			IL_2BC:
			try
			{
				global::AcpCommonLib.AppInfoManager.UnpackOperation = true;
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = codeplug.Partitions.GetEnumerator();
				try
				{
					num = (short)1444085762;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_11E;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)174784516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
							this.UnpackPartition(partition);
							num = (short)1228341251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_AE;
							}
							continue;
						case 4:
							num = (short)1858273280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D4:
						num = (short)193462273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AE:
						goto IL_D4;
					}
					IL_11E:;
				}
				finally
				{
					num = (short)186777601;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)129302530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_150;
							}
							continue;
						case 2:
							goto IL_185;
						}
						IL_150:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1720057856;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_185:;
				}
				this.DoDataExchange(codeplug.Partitions);
				goto IL_2C1;
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException)
				{
					for (;;)
					{
						num = (short)1982985279;
						short num3 = num;
						num = (short)210170943;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1D9;
						}
					}
					IL_1D9:
					num = (short)822018048;
					if (num != 0)
					{
					}
					throw ex;
				}
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얣얥쎧誩\udcab\udcad\udfaf톱톳억쮷骹\uddbb\udcbd꾿냁냃ꏅ곇", a_), ex);
			}
			finally
			{
				this.ClearAllPartitionItems(codeplug);
				global::AcpCommonLib.AppInfoManager.UnpackOperation = false;
			}
			goto IL_213;
			IL_2C1:
			num = (short)651296769;
			if (num != 0)
			{
			}
			num = (short)1085341696;
			short num4 = num;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0003994C File Offset: 0x00037B4C
		protected virtual void UnpackCharField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding encoding;
			char value;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_BD;
				case 1:
					goto IL_12B;
				case 2:
					goto IL_155;
				case 3:
					goto IL_96;
				case 4:
				{
					num2 = (short)1181155328;
					short num3 = num2;
					num2 = (short)616235009;
					if (num2 != 0)
					{
					}
					num2 = (short)1440350209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_1C5;
				case 6:
					switch (encoding)
					{
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Unicode:
						value = this.UnpackUnicodeCharacter(reader, layout, offset);
						num2 = (short)2124218370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Ascii:
						value = this.UnpackAciiCharacter(reader, layout, offset);
						num2 = (short)249233408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bcd:
						value = this.UnpackBcdCharacter(reader, layout, offset);
						num2 = (short)1319370757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bch:
						value = this.UnpackBchCharacter(reader, layout, offset);
						num2 = (short)387055619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)477888516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_2C;
			}
			IL_96:
			IL_BD:
			goto IL_1C7;
			IL_12B:
			throw new global::System.NotSupportedException();
			IL_155:
			num2 = (short)621988532;
			short num4 = num2;
			num2 = (short)1410714292;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)539033600;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_1C5:
			IL_1C7:
			global::Motorola.Acp.PackUnpack.Ish.Fields.CharField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.CharField(layout, value);
			unpackedFields.Add(item);
			return;
			IL_2C:
			encoding = layout.Encoding;
			num2 = (short)1968832518;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00039B30 File Offset: 0x00037D30
		protected virtual char UnpackAciiCharacter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, int offset)
		{
			short num = (short)661330320;
			short num2 = num;
			num = (short)1083906448;
			switch (num2 == num)
			{
			}
			num = (short)1450573824;
			if (num != 0)
			{
			}
			num = (short)1125122048;
			short num3 = num;
			num = (short)1914830849;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			return global::System.Convert.ToChar(reader.ReadByte());
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00039BF4 File Offset: 0x00037DF4
		protected virtual char UnpackUnicodeCharacter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, int offset)
		{
			short num = (short)1740636161;
			if (num != 0)
			{
			}
			num = (short)1281144479;
			short num2 = num;
			num = (short)1143584415;
			switch (num2 == num)
			{
			}
			num = (short)1383071744;
			short num3 = num;
			num = (short)1487077376;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			byte[] array = reader.ReadBytes(2);
			char[] array2 = new char[1];
			global::System.Text.Encoding.Unicode.GetDecoder().GetChars(array, 0, array.Length, array2, 0);
			return array2[0];
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00039CD4 File Offset: 0x00037ED4
		protected virtual char UnpackBcdCharacter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, int offset)
		{
			reader.BaseStream.Position = (long)offset;
			byte b = reader.ReadByte();
			b = (byte)layout.Mask.Apply((int)b, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
			if (b > 9)
			{
				short num = (short)1619955238;
				short num2 = num;
				num = (short)1238339110;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1191837697;
					if (num != 0)
					{
					}
					num = (short)1721892864;
					short num3 = num;
					num = (short)2139684864;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.IO.InvalidDataException();
			}
			return global::System.Convert.ToChar(b);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00039DB8 File Offset: 0x00037FB8
		protected virtual char UnpackBchCharacter(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, int offset)
		{
			int a_ = 13;
			reader.BaseStream.Position = (long)offset;
			byte b = reader.ReadByte();
			b = (byte)layout.Mask.Apply((int)b, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
			short num;
			if (b > 15)
			{
				num = (short)988906340;
				short num2 = num;
				num = (short)1802928996;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1699807232;
					if (num != 0)
					{
					}
					num = (short)2069889024;
					short num3 = num;
					break;
				}
				}
				throw new global::System.IO.InvalidDataException();
			}
			num = (short)1154678785;
			if (num != 0)
			{
			}
			return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("钣鞥骧馩颫鮭蚯薱貳辵醴ﾻ諾薿蓁", a_)[(int)b];
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00039EB0 File Offset: 0x000380B0
		protected virtual void UnpackStringField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			short num;
			int num2;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding;
			string value;
			for (;;)
			{
				IL_0A:
				num = (short)2139226113;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_132;
				case 1:
					goto IL_14B;
				case 2:
					goto IL_10A;
				case 3:
					num = (short)1848049665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_19F;
				case 5:
					switch (encoding)
					{
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode:
						value = this.UnpackUnicodeString(reader, layout, offset);
						num = (short)759889924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii:
						value = this.UnpackAsciiString(reader, layout, offset);
						num = (short)357040128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd:
					case global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch:
					{
						num = (short)1656512624;
						short num3 = num;
						num = (short)1354457200;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_177;
						default:
							num = (short)698941440;
							if (num != 0)
							{
							}
							value = this.UnpackBinaryCodedCharString(reader, layout, offset);
							num = (short)976355330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					default:
						num = (short)2010972163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				goto IL_50;
			}
			IL_10A:
			IL_132:
			goto IL_1A1;
			IL_14B:
			num = (short)829685760;
			short num4 = num;
			IL_177:
			throw new global::System.NotSupportedException();
			IL_19F:
			IL_1A1:
			global::Motorola.Acp.PackUnpack.Ish.Fields.StringField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.StringField(layout, value);
			unpackedFields.Add(item);
			return;
			IL_50:
			encoding = layout.Encoding;
			num = (short)56295429;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0003A070 File Offset: 0x00038270
		protected virtual string UnpackAsciiString(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, int offset)
		{
			short num = (short)14560992;
			short num2 = num;
			num = (short)1015885536;
			switch (num2 == num)
			{
			}
			num = (short)359202817;
			if (num != 0)
			{
			}
			num = (short)1172176896;
			short num3 = num;
			num = (short)1711472640;
			if (num != 0)
			{
			}
			return this.a(reader, layout, global::System.Text.Encoding.ASCII, offset);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0003A128 File Offset: 0x00038328
		protected virtual string UnpackUnicodeString(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, int offset)
		{
			if (reader.BigEndian)
			{
				short num = (short)2078605313;
				if (num != 0)
				{
				}
				num = (short)25050573;
				short num2 = num;
				num = (short)454770125;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)568918016;
					short num3 = num;
					num = (short)621543424;
					if (num != 0)
					{
					}
					break;
				}
				}
				return this.a(reader, layout, global::System.Text.Encoding.BigEndianUnicode, offset);
			}
			return this.a(reader, layout, global::System.Text.Encoding.Unicode, offset);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0003A1FC File Offset: 0x000383FC
		protected virtual string UnpackBinaryCodedCharString(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, int offset)
		{
			int a_ = 11;
			short num = (short)883097600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				byte[] array;
				byte b2;
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					IL_31:
					int num4;
					char c;
					switch (num2)
					{
					case 0:
						goto IL_1B0;
					case 1:
					{
						int num3;
						if (num3 >= layout.Size)
						{
							num = (short)877527047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = array[num3];
						num4 = 2;
						num = (short)152371214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (num4 == 2)
						{
							num = (short)872742932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b;
						b2 = (b & 15);
						num = (short)2143158289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)99745792;
						short num5 = num;
						goto IL_3AF;
					}
					case 4:
					{
						bool flag = true;
						num = (short)245366784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num3;
						num3++;
						num = (short)1795489793;
						if (num != 0)
						{
						}
						num = (short)977076234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)15204368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3EC;
					case 8:
					{
						num = (short)1551376794;
						short num6 = num;
						num = (short)1901535642;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_259;
						default:
							num = (short)195231744;
							if (num != 0)
							{
							}
							goto IL_371;
						}
						break;
					}
					case 9:
						if (layout.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd)
						{
							num = (short)71368710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 10:
						goto IL_3AF;
					case 11:
						num = (short)761593874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_43C;
					case 13:
						goto IL_347;
					case 14:
						goto IL_371;
					case 15:
						if (layout.Justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
						{
							num = (short)343474187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 16:
						if (b2 > 9)
						{
							num = (short)844169229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 17:
						goto IL_43C;
					case 18:
						if (c == layout.Terminator)
						{
							num = (short)1844641796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 19:
						goto IL_1B0;
					case 20:
					{
						byte b;
						b2 = (byte)(b >> 4 & 15);
						num = (short)334692364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (num4 <= 0)
						{
							num = (short)1575354387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1749155842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1925775365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					}
					case 23:
					{
						if (array.Length != layout.Size)
						{
							num = (short)624885784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						stringBuilder = new global::System.Text.StringBuilder(layout.Size);
						int num3 = 0;
						num = (short)19464195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_F4;
					}
					goto IL_9C;
					IL_11A:
					c = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("銡閣钥鮧麩馫颭螯誱足覆惡﮽蚿", a_)[(int)b2];
					num = (short)1405353999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B0:
					num = (short)1737424918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_259:
					num = (short)654180360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24B:
					stringBuilder.Append(c);
					num4--;
					goto IL_259;
					IL_371:
					num = (short)343474197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AF:
					num = (short)1419706369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43C:
					num = (short)1426718729;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F4:
				throw new global::System.IO.IOException();
				IL_347:
				throw new global::System.IO.InvalidDataException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪣킥즧용얫쪭邯颷\ud9b9풻\udfbd늿ꏁꟃ닅귇룉뗍꿑냕럗꣙ﳛ룝觟蟡裣若죧釩\uddeb鏭", a_), b2, layout.Name));
				IL_3EC:
				IL_4E5:
				return stringBuilder.ToString();
				IL_9C:
				reader.BaseStream.Position = (long)offset;
				array = reader.ReadBytes(layout.Size);
				num = (short)1714683927;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0003A6F8 File Offset: 0x000388F8
		private string a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout A_1, global::System.Text.Encoding A_2, int A_3)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			string @string;
			byte[] array;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_D7;
				case 1:
					if (!(A_1.Name == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캜쮞寧者﮴ﺾ闀诂髄臆藈諊黌蟎軐郒體鏖鳘蓚軜诞돠", a_)))
					{
						num2 = (short)1329594370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				case 2:
					goto IL_20E;
				case 3:
					if (!(A_1.Name == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캜쮞ﺬﮮﲲ胀韂跄飆髈蓊诌鯎軐髒釔裖賘裚飜跞뻠귢ꓤꫦ골", a_)))
					{
						num2 = (short)1273233416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				case 4:
					if (A_1.Justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
					{
						num2 = (short)615710726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27E;
				case 5:
					num2 = (short)1118765059;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)946012161;
					if (num2 != 0)
					{
					}
					num2 = (short)1103757319;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (@string.IndexOf(A_1.Terminator) >= 0)
					{
						num2 = (short)1441005568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return @string;
				case 8:
					num2 = (short)1450508289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (array.Length != A_1.Size)
					{
						num2 = (short)1473511429;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				}
				goto IL_41;
				for (;;)
				{
					IL_DC:
					@string = A_2.GetString(array);
					num2 = (short)2024799354;
					short num3 = num2;
					num2 = (short)568458362;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_119;
					}
				}
				IL_119:
				num2 = (short)516096000;
				if (num2 != 0)
				{
				}
				num2 = (short)166985728;
				short num4 = num2;
				num2 = (short)333774852;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D7:
			return @string.Substring(0, @string.IndexOf(A_1.Terminator));
			IL_20E:
			throw new global::System.IO.IOException();
			IL_27E:
			return @string.TrimStart(new char[]
			{
				A_1.Terminator
			});
			IL_41:
			A_0.BaseStream.Position = (long)A_3;
			array = A_0.ReadBytes(A_1.Size);
			num2 = (short)1842413577;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0003A998 File Offset: 0x00038B98
		protected virtual void UnpackBoolField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)731364590;
			short num2 = num;
			num = (short)1509670126;
			switch (num2 == num)
			{
			}
			num = (short)130416641;
			if (num != 0)
			{
			}
			num = (short)1717436416;
			short num3 = num;
			num = (short)1892614144;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			byte value = reader.ReadByte();
			bool value2 = layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) > 0;
			global::Motorola.Acp.PackUnpack.Ish.Fields.BoolField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.BoolField(layout, value2);
			unpackedFields.Add(item);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0003AA78 File Offset: 0x00038C78
		protected virtual void UnpackSByteField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)867976365;
			short num2 = num;
			num = (short)1433683117;
			switch (num2 == num)
			{
			}
			num = (short)2082406400;
			if (num != 0)
			{
			}
			num = (short)1734148096;
			short num3 = num;
			num = (short)1924333569;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			sbyte value = reader.ReadSByte();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<sbyte> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<sbyte>(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0003AB48 File Offset: 0x00038D48
		protected virtual void UnpackByteField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			byte value;
			for (;;)
			{
				IL_0A:
				num = (short)1262386117;
				short num2 = num;
				num = (short)2014084037;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1138622464;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_BB;
					case 1:
						goto IL_130;
					case 2:
						if (layout.Mask != null)
						{
							num = (short)1297285120;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					}
					goto IL_69;
				}
				IL_BB:
				value = (byte)layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
				num = (short)1187577857;
				if (num != 0)
				{
				}
				num = (short)98238464;
				short num4 = num;
				num = (short)920387585;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_130:
			IL_132:
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<byte> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<byte>(layout, value);
			unpackedFields.Add(item);
			return;
			IL_69:
			reader.BaseStream.Position = (long)offset;
			value = reader.ReadByte();
			num = (short)1214644226;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0003AC98 File Offset: 0x00038E98
		protected virtual void UnpackInt16Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)615579649;
			if (num != 0)
			{
			}
			num = (short)608255015;
			short num2 = num;
			num = (short)3882023;
			switch (num2 == num)
			{
			}
			num = (short)1131479040;
			short num3 = num;
			num = (short)398262272;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			short value = reader.ReadInt16();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<short> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<short>(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0003AD64 File Offset: 0x00038F64
		protected virtual void UnpackUInt16Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			ushort value;
			for (;;)
			{
				IL_0A:
				int num4;
				switch (num)
				{
				case 0:
					goto IL_181;
				case 1:
					goto IL_13B;
				case 2:
				{
					num2 = (short)627638272;
					short num3 = num2;
					value = (ushort)layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
					num4 = (layout.Mask.BitOffset - layout.Mask.BitSize + 1) / 8;
					num2 = (short)1298333696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1527308150;
					short num5 = num2;
					num2 = (short)600432502;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_181;
					default:
						num2 = (short)316669952;
						if (num2 != 0)
						{
						}
						reader.BaseStream.Position -= (long)num4;
						num2 = (short)1877278721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)139264001;
					if (num2 != 0)
					{
					}
					if (layout.Mask != null)
					{
						num2 = (short)1472528386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A2;
				}
				goto IL_24;
				IL_181:
				if (num4 <= 0)
				{
					break;
				}
				num2 = (short)527826947;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13B:
			IL_1A2:
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<ushort> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<ushort>(layout, value);
			unpackedFields.Add(item);
			return;
			IL_24:
			reader.BaseStream.Position = (long)offset;
			value = reader.ReadUInt16();
			num2 = (short)617218052;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0003AF24 File Offset: 0x00039124
		protected virtual void UnpackIndexReferenceField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)1010498595;
			short num2 = num;
			num = (short)630062115;
			switch (num2 == num)
			{
			}
			num = (short)627965953;
			if (num != 0)
			{
			}
			num = (short)760741888;
			short num3 = num;
			num = (short)2008547328;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			int type = (int)reader.ReadInt16();
			int id = (int)reader.ReadInt16();
			ushort index = reader.ReadUInt16();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField(layout, type, id, index);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0003B004 File Offset: 0x00039204
		protected virtual void UnpackInt32Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)1389821953;
			if (num != 0)
			{
			}
			num = (short)1352160518;
			short num2 = num;
			num = (short)1352488198;
			switch (num2 == num)
			{
			}
			num = (short)1306198016;
			short num3 = num;
			num = (short)1587150848;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			int value = reader.ReadInt32();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<int> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<int>(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0003B0D0 File Offset: 0x000392D0
		protected virtual void UnpackUInt32Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)111542272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				uint num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						int num3 = (layout.Mask.BitOffset - layout.Mask.BitSize + 1) / 8;
						num = (short)1574305800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num4;
						if (num4-- <= 0)
						{
							num = (short)787415045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						num5 |= (uint)((uint)reader.ReadByte() << num6);
						num6 -= 8;
						num = (short)136904714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_251;
					case 3:
					{
						int num3;
						int num4 = 4 - num3;
						int num6 = 24;
						num5 = 0U;
						goto IL_F3;
					}
					case 4:
						goto IL_1E3;
					case 5:
						num = (short)1629552649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_251;
					case 7:
						goto IL_1B9;
					case 8:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)31850499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = reader.ReadUInt32();
						num = (short)1564803079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1B9;
					case 10:
						goto IL_1E3;
					case 11:
					{
						if (layout.Mask != null)
						{
							num = (short)315752448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)540213248;
						short num7 = num;
						num5 = reader.ReadUInt32();
						num = (short)20381702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5E;
					IL_F3:
					num = (short)198901764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_251:
					num = (short)61203462;
					short num8 = num;
					num = (short)1719985158;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						goto IL_286;
					}
					IL_1B9:
					num5 = layout.Mask.Apply(num5, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
					num = (short)322764802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3:
					num = (short)2054684673;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_286:
				num = (short)2085421057;
				if (num != 0)
				{
				}
				num = (short)1872297984;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<uint> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<uint>(layout, num5);
				unpackedFields.Add(item);
				return;
				IL_5E:
				reader.BaseStream.Position = (long)offset;
				num = (short)696778763;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0003B3B0 File Offset: 0x000395B0
		protected virtual void UnpackInt64Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)245258221;
			short num2 = num;
			num = (short)1650350061;
			switch (num2 == num)
			{
			}
			num = (short)1191247873;
			if (num != 0)
			{
			}
			num = (short)918683648;
			short num3 = num;
			num = (short)427229184;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			long value = reader.ReadInt64();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<long> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<long>(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0003B47C File Offset: 0x0003967C
		protected virtual void UnpackUInt64Field(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)2019108566;
			short num2 = num;
			num = (short)276834006;
			switch (num2 == num)
			{
			}
			num = (short)967835648;
			if (num != 0)
			{
			}
			num = (short)626851840;
			short num3 = num;
			num = (short)1642266625;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			ulong value = reader.ReadUInt64();
			global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<ulong> item = new global::Motorola.Acp.PackUnpack.Ish.Fields.IntField<ulong>(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0003B548 File Offset: 0x00039748
		protected virtual void UnpackIshItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)968622081;
			if (num != 0)
			{
			}
			num = (short)1424813334;
			short num2 = num;
			num = (short)161803542;
			switch (num2 == num)
			{
			}
			num = (short)46530560;
			short num3 = num;
			num = (short)1958543360;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			int a_ = reader.ReadInt32();
			global::Motorola.Acp.PackUnpack.Ish.IshItemName value = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(a_);
			global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0003B61C File Offset: 0x0003981C
		protected virtual void UnpackIshItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)273102533;
			short num2 = num;
			num = (short)1850422981;
			switch (num2 == num)
			{
			}
			num = (short)379322369;
			if (num != 0)
			{
			}
			num = (short)1196818432;
			short num3 = num;
			num = (short)251985920;
			if (num != 0)
			{
			}
			reader.BaseStream.Position = (long)offset;
			int a_ = reader.ReadInt32();
			global::Motorola.Acp.PackUnpack.Ish.IshItemName value = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(a_);
			global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField item = new global::Motorola.Acp.PackUnpack.Ish.Fields.ItemReferenceField(layout, value);
			unpackedFields.Add(item);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0003B6F0 File Offset: 0x000398F0
		protected virtual void UnpackByteArrayField(global::Motorola.Acp.PackUnpack.Ish.IshItem item, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			short num = (short)53018624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				int count;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (item is global::Motorola.Acp.PackUnpack.Ish.ListListletItem)
						{
							num = (short)362348545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD;
					case 1:
					{
						num = (short)1597112320;
						short num3 = num;
						global::Motorola.Acp.PackUnpack.Ish.ListListletItem listListletItem = (global::Motorola.Acp.PackUnpack.Ish.ListListletItem)item;
						count = listListletItem.Layout.ListEntrySize * listListletItem.Count;
						num = (short)317587458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_140;
					case 3:
					{
						num = (short)1878770094;
						short num4 = num;
						num = (short)1016316334;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1212940288;
							if (num != 0)
							{
							}
							num = (short)1175257089;
							if (num != 0)
							{
							}
							break;
						}
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)item;
						count = listHeaderItem.ListEntrySize * listHeaderItem.Count;
						num = (short)1085865988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1DB;
					case 5:
						if (item is global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem)
						{
							num = (short)344522755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1328283648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48;
				}
				IL_140:
				IL_1DB:
				goto IL_1E3;
				IL_1DD:
				throw new global::System.NotSupportedException();
				IL_1E3:
				global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream;
				global::System.IO.MemoryStream value = new global::System.IO.MemoryStream(baseStream.a(), baseStream.b(), count);
				unpackedFields.Add(new global::Motorola.Acp.PackUnpack.Ish.Fields.ByteArrayField(layout, value));
				return;
				IL_48:
				reader.BaseStream.Position = (long)offset;
				baseStream = reader.BaseStream;
				count = 0;
				num = (short)1945567237;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0003B904 File Offset: 0x00039B04
		protected virtual void UnpackIPAddressField(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader, global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int offset)
		{
			reader.BaseStream.Position = (long)offset;
			global::Motorola.Acp.PackUnpack.Ish.Fields.IPAddressField ipaddressField = new global::Motorola.Acp.PackUnpack.Ish.Fields.IPAddressField(layout);
			if (reader.Read(ipaddressField.Value, 0, ipaddressField.Value.Length) != ipaddressField.Value.Length)
			{
				short num = (short)1363831014;
				short num2 = num;
				num = (short)1153394918;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1071906817;
					if (num != 0)
					{
					}
					num = (short)1365770240;
					short num3 = num;
					num = (short)1273626624;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.IO.IOException();
			}
			unpackedFields.Add(ipaddressField);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0003B9F4 File Offset: 0x00039BF4
		protected virtual void UnpackPartition(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			short num = (short)1222280932;
			short num2 = num;
			num = (short)252872420;
			switch (num2 == num)
			{
			}
			num = (short)1452605441;
			if (num != 0)
			{
			}
			num = (short)1582825472;
			short num3 = num;
			num = (short)575340544;
			if (num != 0)
			{
			}
			this.ParsePartitionImage(partition);
			this.AssembleListFragments(partition);
			this.UnpackPartitionItems(partition);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		protected virtual void DoDataExchange(global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection partitions)
		{
			short num = (short)1449293309;
			short num2 = num;
			num = (short)1099003389;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)899284992;
				if (num != 0)
				{
				}
				num = (short)1832779777;
				if (num != 0)
				{
				}
				if (this.c != null)
				{
					this.c.a(partitions, global::Motorola.Acp.PackUnpack.Ish.DataExchangeDirection.Unpack);
					return;
				}
				break;
			}
			num = (short)619773952;
			short num3 = num;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0003BB70 File Offset: 0x00039D70
		protected virtual void AssembleListFragments(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			for (;;)
			{
				IL_00:
				short num = (short)432340994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1720993222;
					short num3 = num;
					num = (short)1194345926;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)689831936;
						short num4 = num;
						num = (short)1040908288;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_E4;
						case 1:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListItemReader listItemReader = new global::Motorola.Acp.PackUnpack.Ish.ListItemReader(partition.Items);
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection listItemCollectionCollection = new global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection();
							num = (short)883884032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 3:
						{
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection listItemCollectionCollection;
							partition.Items.ListItems = listItemCollectionCollection;
							num = (short)1963327489;
							if (num != 0)
							{
							}
							num = (short)1111293958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_E4;
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.ListItemReader listItemReader;
							if (!listItemReader.e())
							{
								num = (short)85917699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection listItemCollectionCollection;
							listItemCollectionCollection.Add(listItemReader.List);
							num = (short)966852612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							return;
						}
						IL_B4:
						if (partition.Items.ListHeaders.Count > 0)
						{
							num = (short)2038431745;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						return;
						IL_E4:
						num = (short)1675886597;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0003BD3C File Offset: 0x00039F3C
		protected virtual void ParsePartitionImage(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			short num = (short)237174785;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1419051008;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 2:
					goto IL_17D;
				case 3:
					goto IL_165;
				case 4:
					goto IL_165;
				case 5:
					return;
				}
				IL_66:
				if (partition.Image.Length == 0L)
				{
					num = (short)877461504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1906885234;
				short num4 = num;
				num = (short)874627698;
				global::Motorola.Acp.PackUnpack.Ish.PartitionImageReader partitionImageReader;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)352124928;
					if (num != 0)
					{
					}
					partition.Items.Clear();
					partitionImageReader = new global::Motorola.Acp.PackUnpack.Ish.PartitionImageReader(partition, this.a, this.b);
					num = (short)102694913;
					if (num != 0)
					{
					}
					num = (short)1038614531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_17D:
				if (!partitionImageReader.j())
				{
					num = (short)2066350085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				partition.Items.Add(partitionImageReader.Item);
				num = (short)749993988;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165:
				num = (short)228065282;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0003BEEC File Offset: 0x0003A0EC
		protected virtual void ClearAllPartitionItems(global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug)
		{
			short num = (short)905183232;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = codeplug.Partitions.GetEnumerator();
			try
			{
				num = (short)1312817152;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 1:
						num = (short)1159331844;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)283153296;
						short num4 = num;
						num = (short)1438290832;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)940965888;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1965359105;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.Items.Clear();
							num = (short)857669633;
							if (num != 0)
							{
							}
							num = (short)620888067;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_15E;
					}
					IL_C0:
					num = (short)554762242;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_71:
					goto IL_C0;
				}
				IL_15E:;
			}
			finally
			{
				num = (short)1180041217;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)2012938242;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_191;
						}
						continue;
					case 2:
						goto IL_1C4;
					}
					IL_191:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1531117568;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C4:;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0003C0DC File Offset: 0x0003A2DC
		protected virtual void UnpackPartitionItems(global::Motorola.Acp.PackUnpack.Ish.Partition partition)
		{
			short num = (short)1550843904;
			short num2 = num;
			num = (short)876229927;
			short num3 = num;
			num = (short)1930769703;
			switch (num3 == num)
			{
			}
			num = (short)1265958913;
			if (num != 0)
			{
			}
			num = (short)1632370688;
			if (num != 0)
			{
			}
			this.b(partition);
			this.a(partition);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0003C194 File Offset: 0x0003A394
		private void b(global::Motorola.Acp.PackUnpack.Ish.Partition A_0)
		{
			int a_ = 18;
			short num = (short)250871808;
			short num2 = num;
			num = (short)1430454273;
			if (num != 0)
			{
			}
			num = (short)906231808;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				global::System.Collections.Generic.ICollection<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> collection;
				for (;;)
				{
					IL_82:
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.CompositeItem> enumerator;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						if (collection == null)
						{
							num = (short)1164640256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD;
					case 2:
						try
						{
							num = (short)1889533954;
							num3 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.CompositeItem compositeItem;
							for (;;)
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
								switch (num3)
								{
								case 0:
								{
									num = (short)1005042733;
									short num4 = num;
									num = (short)1963637805;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_17B;
									default:
										num = (short)1686503424;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 1:
									if (compositeLayout == null)
									{
										num = (short)752877573;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.UnpackItem(compositeItem, compositeLayout);
									num = (short)40960000;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_113;
									}
									continue;
								case 3:
									goto IL_17B;
								case 4:
									num = (short)728694790;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_15E;
								case 6:
									goto IL_25E;
								}
								goto IL_113;
								IL_17B:
								if (!enumerator.MoveNext())
								{
									num = (short)276758532;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								compositeItem = enumerator.Current;
								compositeLayout = A_0.Layouts.Find(compositeItem.Type);
								num = (short)12910593;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_163:
								num = (short)2048655363;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_113:
								goto IL_163;
							}
							IL_15E:
							string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪪쎬솮\udeb0잲閴톶킸햺\ud9bc龾귀ꋂ별꣆볈뿊꧎뻐ꇒ黖諘鏚﷜ꯞ飠鏢胤쟦鋨\udbea郬쿮\ud9f0裲쓴諶탸", a_), compositeItem.Type.Value, compositeItem.Type.Name);
							throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.StructureLayoutNotFoundException();
							IL_25E:
							return;
						}
						finally
						{
							num = (short)787808257;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1274609666;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_295;
									}
									continue;
								case 2:
									goto IL_2CA;
								}
								IL_295:
								if (enumerator == null)
								{
									break;
								}
								num = (short)250806272;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2CA:;
						}
						goto IL_2CD;
					}
					goto IL_95;
					IL_2CD:
					enumerator = collection.GetEnumerator();
					num = (short)1723793410;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_95:
				collection = A_0.Items;
				num = (short)1668874241;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_82;
			}
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		private void a(global::Motorola.Acp.PackUnpack.Ish.Partition A_0)
		{
			int a_ = 7;
			short num = (short)845873152;
			switch (num)
			{
			default:
			{
				num = (short)1933377537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection> enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						try
						{
							num = (short)98369543;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem listHeaderItem;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
									if (listLayout == null)
									{
										goto IL_121;
									}
									this.UnpackItem(listHeaderItem, listLayout);
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									int count = listItemCollection.Count;
									num = (short)2021851144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_13E;
								case 2:
								{
									int count;
									int num3;
									if (num3 >= count)
									{
										num = (short)2030370826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection;
									global::Motorola.Acp.PackUnpack.Ish.ListListletItem item = listItemCollection[num3] as global::Motorola.Acp.PackUnpack.Ish.ListListletItem;
									global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
									this.UnpackItem(item, listLayout, listHeaderItem.ListEntrySize);
									num3++;
									num = (short)490864649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1171980294;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection listItemCollection = enumerator.Current;
									listHeaderItem = (listItemCollection[0] as global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem);
									global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout = A_0.Layouts.Find(listHeaderItem.Type);
									num = (short)872611840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_139;
								case 5:
									goto IL_303;
								case 6:
									num = (short)1809383429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								case 8:
								{
									int count;
									if (count != 1)
									{
										num = (short)203751435;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_13E;
								case 11:
								{
									num = (short)1257293799;
									short num4 = num;
									num = (short)635619303;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_121;
									default:
									{
										num = (short)1736114176;
										if (num != 0)
										{
										}
										int num3 = 1;
										num = (short)1401552897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								}
								goto IL_DA;
								IL_121:
								num = (short)671088644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13E:
								num = (short)759693314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17C:
								num = (short)1245708291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA:
								goto IL_17C;
							}
							IL_139:
							string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udd9d솟첡쪣즥\udca7誩쪫잭\udeaf횱钳\udab5\ud9b7쎹펻쮽뒿ꋃ꧅뫇藋鷍飏ꃓ꿕꣗뿙ﳛꗝ탟鿡쓣컥鏧\udbe9釫쟭", a_), listHeaderItem.Type.Value, listHeaderItem.Type.Name);
							throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.StructureLayoutNotFoundException();
							IL_303:
							goto IL_3CB;
						}
						finally
						{
							num = (short)1386807297;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1937440770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_33A;
									}
									continue;
								case 2:
									goto IL_370;
								}
								IL_33A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1270022144;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_370:;
						}
						goto IL_373;
					}
					IL_58:
					if (A_0.Items.ListItems == null)
					{
						num = (short)1509883904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_373:
					enumerator = A_0.Items.ListItems.GetEnumerator();
					num = (short)80805888;
					short num5 = num;
					num = (short)672333826;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3CB:
				num = (short)624623617;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0003C8CC File Offset: 0x0003AACC
		protected virtual void UnpackDataArea(global::Motorola.Acp.PackUnpack.Ish.IshItem item, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream packedData, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection layouts, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int dataAreaSize)
		{
			short num = (short)1225981952;
			short num2 = num;
			num = (short)1338878915;
			short num3 = num;
			num = (short)1411689411;
			switch (num3 == num)
			{
			}
			num = (short)1202061313;
			if (num != 0)
			{
			}
			num = (short)385875968;
			if (num != 0)
			{
			}
			this.a(item, new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader(packedData, true), layouts, unpackedFields, 1, dataAreaSize);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0003C988 File Offset: 0x0003AB88
		protected virtual void UnpackDataArea(global::Motorola.Acp.PackUnpack.Ish.IshItem item, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream packedData, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection layouts, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection unpackedFields, int count, int dataAreaSize)
		{
			short num = (short)1035927552;
			short num2 = num;
			num = (short)1821310977;
			if (num != 0)
			{
			}
			num = (short)1915559213;
			short num3 = num;
			num = (short)203496749;
			switch (num3 == num)
			{
			}
			num = (short)423821312;
			if (num != 0)
			{
			}
			this.a(item, new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader(packedData, true), layouts, unpackedFields, count, dataAreaSize);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0003CA48 File Offset: 0x0003AC48
		protected virtual void UnpackItem(global::Motorola.Acp.PackUnpack.Ish.CompositeItem item, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout layout)
		{
			short num = (short)646905856;
			short num2 = num;
			num = (short)1697579009;
			if (num != 0)
			{
			}
			num = (short)1812173015;
			short num3 = num;
			num = (short)211325143;
			switch (num3 == num)
			{
			}
			num = (short)564330496;
			if (num != 0)
			{
			}
			this.UnpackDataArea(item, item.DataArea.PackedData, layout.DataAreaLayout.FieldLayouts, item.DataArea.UnpackedData, layout.Size);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0003CB20 File Offset: 0x0003AD20
		protected virtual void UnpackItem(global::Motorola.Acp.PackUnpack.Ish.ListHeaderItem item, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout)
		{
			short num = (short)970194951;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1168179203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					this.UnpackDataArea(item, item.HeaderListEntries.PackedData, layout.ListEntryLayout.FieldLayouts, item.HeaderListEntries.UnpackedData, item.Count, item.ListEntrySize);
					num = (short)1435435009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (layout.HeaderDataAreaLayout.FieldLayouts.Count > 0)
					{
						num = (short)1372323846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26D;
				case 4:
					if (item.HeaderListEntries != null)
					{
						num = (short)1156775936;
						short num3 = num;
						num = (short)1466236930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)1262157828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)2102435929;
					short num4 = num;
					num = (short)1968939097;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1724317696;
						if (num != 0)
						{
						}
						num = (short)838074377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_14;
				case 8:
					this.UnpackDataArea(item, item.HeaderDataArea.PackedData, layout.HeaderDataAreaLayout.FieldLayouts, item.HeaderDataArea.UnpackedData, item.HeaderDataAreaSize);
					num = (short)1560215562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (item.HeaderDataArea != null)
					{
						num = (short)2122252296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26D;
				case 10:
					goto IL_26D;
				case 11:
					if (layout.ListEntryLayout != null)
					{
						num = (short)1436090373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_7C;
				IL_14:
				num = (short)1808269313;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_7C:
					if (layout.HeaderDataAreaLayout == null)
					{
						goto IL_26D;
					}
					num = (short)50921472;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_26D:
				num = (short)195624971;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		protected virtual void UnpackItem(global::Motorola.Acp.PackUnpack.Ish.ListListletItem item, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout layout, int listEntrySize)
		{
			short num;
			for (;;)
			{
				num = (short)11010049;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_81;
					case 1:
						num = (short)966524929;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 2:
						num = (short)1379270660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!(layout.ListEntryLayout.FieldLayouts[0] is global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout))
						{
							num = (short)1594621954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)336265221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_97;
					case 5:
						goto IL_176;
					}
					IL_64:
					if (layout.ListEntryLayout == null)
					{
						num = (short)234684416;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1432158211;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_81:
				num = (short)1649844441;
				short num3 = num;
				num = (short)598384857;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_11F;
				}
			}
			IL_97:
			int num4 = item.Count;
			goto IL_179;
			IL_11F:
			num = (short)1244856320;
			short num5 = num;
			num = (short)694288384;
			if (num != 0)
			{
			}
			return;
			IL_176:
			num4 = 1;
			IL_179:
			int count = num4;
			this.UnpackDataArea(item, item.DataArea.PackedData, layout.ListEntryLayout.FieldLayouts, item.DataArea.UnpackedData, count, listEntrySize);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0003CF90 File Offset: 0x0003B190
		private bool b(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, int A_2, int A_3)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1349189634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!(A_1.Name == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒖춘즚풜톞ﲢﶨ寧諸黀郂諄臆鷈铊蓌诎軐蛒蛔鋖诘蓚鏜點고ꛢ", a_)))
					{
						num2 = (short)577568768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_164;
				case 2:
					if (A_1.Name == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒖춘즚풜톞ﲢﲲ蟀迂蓄铆臈铊軌胎闐雒諔蓖跘觚", a_))
					{
						goto IL_1A2;
					}
					num2 = (short)1332674564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_162;
				case 4:
				{
					if (num3 > A_3)
					{
						return false;
					}
					num2 = (short)693414409;
					short num4 = num2;
					num2 = (short)201501193;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A2;
					default:
						num2 = (short)168165377;
						if (num2 != 0)
						{
						}
						num2 = (short)1858142208;
						if (num2 != 0)
						{
						}
						num2 = (short)1849622531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_1B9;
				}
				goto IL_31;
				IL_1A2:
				num2 = (short)756285445;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_162:
			return (long)num3 <= A_0.BaseStream.Length;
			IL_164:
			return num3 <= A_3;
			IL_1B9:
			goto IL_164;
			IL_31:
			num2 = (short)1750204416;
			short num5 = num2;
			num3 = A_1.Offset + A_1.Size;
			num2 = (short)399245313;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0003D16C File Offset: 0x0003B36C
		private bool a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, int A_2, int A_3)
		{
			short num = (short)1828020133;
			short num2 = num;
			num = (short)190930853;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)610009089;
				if (num != 0)
				{
				}
				num = (short)176029696;
				if (num != 0)
				{
				}
				if (A_1.Offset + A_1.Size > A_3)
				{
					return false;
				}
				break;
			}
			num = (short)2063990784;
			short num3 = num;
			return (long)(A_2 * A_3) <= A_0.BaseStream.Length;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0003D244 File Offset: 0x0003B444
		private global::Motorola.Acp.PackUnpack.Ish.Unpacker.a a(global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection A_0)
		{
			short num2;
			global::Motorola.Acp.PackUnpack.Ish.Unpacker.a result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						num2 = (short)1881800710;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)362217476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType dataAreaType;
						if (dataAreaType > global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader)
						{
							num2 = (short)1853292545;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = new global::Motorola.Acp.PackUnpack.Ish.Unpacker.a(this.b);
						num2 = (short)1051787267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_12F;
					case 4:
					{
						global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType dataAreaType;
						if (dataAreaType != global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry)
						{
							num2 = (short)379912192;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = new global::Motorola.Acp.PackUnpack.Ish.Unpacker.a(this.a);
						num2 = (short)1719599109;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_105;
					case 6:
						goto IL_183;
					}
					break;
				}
				IL_2C:
				num2 = (short)1265762305;
				if (num2 != 0)
				{
				}
				num2 = (short)910055557;
				short num3 = num2;
				num2 = (short)1885689989;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1873805312;
					if (num2 != 0)
					{
					}
					global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType dataAreaType = A_0.Parent.AreaType;
					num2 = (short)1815937026;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			IL_105:
			IL_12F:
			return result;
			IL_183:
			num2 = (short)434176000;
			short num4 = num2;
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0003D400 File Offset: 0x0003B600
		private void a(global::Motorola.Acp.PackUnpack.Ish.IshItem A_0, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_1, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection A_2, global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection A_3, int A_4, int A_5)
		{
			short num = (short)1703280640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num3;
				global::Motorola.Acp.PackUnpack.Ish.Unpacker.a a;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						try
						{
							num = (short)25821217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout;
								switch (num2)
								{
								case 3:
									this.UnpackIndexReferenceField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
									num = (short)948699149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)2078933012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)898236426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_87D;
								case 11:
									if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)
									{
										num = (short)1189150723;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1009516562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout)
									{
										num = (short)878444565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)188809227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1950875657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									fieldLayout = enumerator.Current;
									num = (short)372703264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)
									{
										num = (short)1136394269;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.UnpackInt32Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
									num = (short)1606942744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout)
									{
										num = (short)1045626905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23C;
								case 19:
									goto IL_616;
								case 20:
									goto IL_7A9;
								case 21:
									goto IL_4A0;
								case 25:
									this.UnpackByteArrayField(A_0, A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
									num = (short)478216219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
								{
									global::System.TypeCode type;
									switch (type)
									{
									case global::System.TypeCode.Object:
										num = (short)1336410124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.DBNull:
									case global::System.TypeCode.Single:
									case global::System.TypeCode.Double:
									case global::System.TypeCode.Decimal:
									case global::System.TypeCode.DateTime:
									case (global::System.TypeCode)17:
										goto IL_81C;
									case global::System.TypeCode.Boolean:
										this.UnpackBoolField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1445986338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.Char:
										this.UnpackCharField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1186725894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.SByte:
										this.UnpackSByteField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)548208648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.Byte:
										this.UnpackByteField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)652738564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.Int16:
										this.UnpackInt16Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1915289601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.UInt16:
										this.UnpackUInt16Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)801964034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.Int32:
										num = (short)584319011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.UInt32:
										this.UnpackUInt32Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1675624470;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.Int64:
									{
										this.UnpackInt64Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)67987046;
										short num4 = num;
										num = (short)1940219494;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_4A0;
										default:
											num = (short)825360384;
											if (num != 0)
											{
											}
											num = (short)483983367;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case global::System.TypeCode.UInt64:
										this.UnpackUInt64Field(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1999765521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::System.TypeCode.String:
										this.UnpackStringField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
										num = (short)1739718684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)762642462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 29:
									this.UnpackIshItemReferenceField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
									num = (short)923271184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									num = (short)122421267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									this.UnpackIshItemReferenceField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
									num = (short)1751777303;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									if (!a(A_1, fieldLayout, num5, A_5))
									{
										num = (short)90439685;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.TypeCode type = fieldLayout.Type;
									num = (short)1435893786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									switch (0)
									{
									case 0:
										goto IL_1F3;
									}
									continue;
								case 35:
									if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
									{
										num = (short)385024031;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1798832143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2F2:
								num = (short)1595408398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F3:
								goto IL_2F2;
								IL_4A0:
								this.UnpackIPAddressField(A_1, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout)fieldLayout, A_3, num3 + fieldLayout.Offset);
								num = (short)320667648;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_23C:
							throw new global::System.NotSupportedException();
							IL_616:
							goto IL_81C;
							IL_7A9:
							goto IL_68;
							IL_81C:
							throw new global::System.NotSupportedException();
							IL_87D:
							goto IL_68;
						}
						finally
						{
							num = (short)1859649538;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1455685633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_8EB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_8B4;
									}
									continue;
								}
								IL_8B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)687407104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8EB:;
						}
						return;
						IL_68:
						num = (short)756547584;
						short num6 = num;
						num3 += A_5;
						num5++;
						num = (short)932708356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)2042232833;
						if (num != 0)
						{
						}
						if (num5 > A_4)
						{
							num = (short)672989184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator = A_2.GetEnumerator();
						num = (short)1736245249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_D6;
					case 4:
						goto IL_D6;
					}
					goto IL_42;
					IL_D6:
					num = (short)289931266;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				num3 = 0;
				a = this.a(A_2);
				num5 = 1;
				num = (short)1184759811;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x040000E8 RID: 232
		private global::Motorola.Acp.PackUnpack.Ish.Crc16Generator a;

		// Token: 0x040000E9 RID: 233
		private global::Motorola.Acp.PackUnpack.Ish.IshItemFactory b;

		// Token: 0x040000EA RID: 234
		private global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager c;

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060002BA RID: 698
		private delegate bool a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, int A_2, int A_3);
	}
}
