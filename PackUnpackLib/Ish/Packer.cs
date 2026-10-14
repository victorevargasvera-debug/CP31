using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using Motorola.Acp.PackUnpack.Encodings;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.DataExchange;
using Motorola.Acp.PackUnpack.Ish.Exceptions;
using Motorola.Acp.PackUnpack.Ish.Fields;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.Acp.PackUnpack.Ish.Loggers;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000033 RID: 51
	public class Packer : global::System.IDisposable
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000255C0 File Offset: 0x000237C0
		static Packer()
		{
			short num = (short)1216837506;
			short num2 = num;
			num = (short)1679325058;
			switch (num2 == num)
			{
			}
			num = (short)1146028032;
			if (num != 0)
			{
			}
			num = (short)690552832;
			short num3 = num;
			num = (short)2136801281;
			if (num != 0)
			{
			}
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0002566C File Offset: 0x0002386C
		internal Packer() : this(new global::Motorola.Acp.PackUnpack.Ish.Crc16Generator(), new global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager())
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0002568C File Offset: 0x0002388C
		public Packer(global::Motorola.Acp.PackUnpack.Ish.Crc16Generator crcGenerator, global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager dataExchangeManager) : this(crcGenerator, dataExchangeManager, null)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000256A4 File Offset: 0x000238A4
		public Packer(global::Motorola.Acp.PackUnpack.Ish.Crc16Generator crcGenerator, global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager dataExchangeManager, global::System.Collections.Generic.IList<global::AcpCommonLib.IAcpField> packedFields)
		{
			int a_ = 13;
			base..ctor();
			this.a = crcGenerator;
			this.b = dataExchangeManager;
			this.v = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Packer.a, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b>>();
			global::Motorola.Acp.PackUnpack.Ish.Packer.c = new global::System.Diagnostics.BooleanSwitch(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즥쾧睊춫춭\udbaf\udbb1\udab3통", a_), global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좥즧좩삫쮭龯횱\uddb3억\ud9b7\ud8b9킻\udbbd껁ꯃꇅ꿇ꏉꋋ꧍뷑닓꣗믙뿛뗝샟跡釣鋥飧鿩飫", a_));
			this.u = packedFields;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00025708 File Offset: 0x00023908
		private void j()
		{
			short num = (short)1342247865;
			short num2 = num;
			num = (short)19796921;
			switch (num2 == num)
			{
			}
			num = (short)1045299201;
			if (num != 0)
			{
			}
			num = (short)992280576;
			short num3 = num;
			num = (short)1225981952;
			if (num != 0)
			{
			}
			this.p = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding, global::System.Text.Encoding>();
			this.p.Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii, global::System.Text.Encoding.ASCII);
			this.p.Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode, global::System.Text.Encoding.BigEndianUnicode);
			this.p.Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd, new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoding(false));
			this.p.Add(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch, new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoding(true));
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00025804 File Offset: 0x00023A04
		private void a(global::Motorola.Acp.PackUnpack.Ish.Codeplug A_0)
		{
			short num = (short)197656576;
			switch (num)
			{
			default:
			{
				num = (short)1941962753;
				if (num != 0)
				{
				}
				num = (short)770048000;
				short num2 = num;
				this.q = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.Partitions.GetEnumerator();
				try
				{
					num = (short)1706754048;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger a_;
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader a_3;
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter a_4;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 1:
							num = (short)271384584;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
							{
								num = (short)503316483;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_ = null;
							num = (short)322109444;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							string name;
							int a_2;
							a_ = this.a(name, a_2);
							num = (short)1985590545;
							short num4 = num;
							num = (short)794932497;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A1;
							default:
								num = (short)1829109760;
								if (num != 0)
								{
								}
								num = (short)386990085;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_227;
						case 5:
							goto IL_227;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)423559169;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							partition = enumerator.Current;
							string name = global::System.Enum.GetName(typeof(global::Motorola.Acp.PackUnpack.Ish.PartitionType), partition.PartitionType);
							int a_2 = (int)global::System.Enum.Parse(typeof(global::Motorola.Acp.PackUnpack.Ish.PartitionType), name);
							a_3 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader(partition.Image, true);
							a_4 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter(partition.Image, true);
							num = (short)943194114;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_2A1;
						}
						IL_14B:
						num = (short)1822818311;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_14B;
						IL_227:
						global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider = new global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider(partition.PartitionType, a_3, a_4, a_);
						this.q.Add(partitionIOProvider.PartitionType, partitionIOProvider);
						num = (short)644415494;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2A1:;
				}
				finally
				{
					num = (short)1796472833;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1757872130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2D5;
							}
							continue;
						case 2:
							goto IL_30F;
						}
						IL_2D5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1785790464;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_30F:;
				}
				return;
			}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00025B40 File Offset: 0x00023D40
		private void i()
		{
			short num = (short)1157063150;
			short num2 = num;
			num = (short)1523999214;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_8B:
				num = (short)151715840;
				short num3 = num;
				num = (short)2005401600;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1887895552;
				if (num != 0)
				{
				}
				num = (short)2128281601;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider>.ValueCollection.Enumerator enumerator;
				switch (num4)
				{
				case 0:
					goto IL_188;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 2:
					num = (short)877592577;
					if (num != 0)
					{
					}
					try
					{
						num = (short)989396993;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_104;
								}
								continue;
							case 2:
								num = (short)1391460356;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1138688002;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider a_ = enumerator.Current;
								this.b(a_);
								num = (short)777322496;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_178;
							}
							IL_106:
							num = (short)50790403;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_104:
							goto IL_106;
						}
						IL_178:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_188;
				}
				break;
				IL_188:
				enumerator = this.q.Values.GetEnumerator();
				num = (short)1576927234;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			if (global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
			{
				goto IL_8B;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00025D3C File Offset: 0x00023F3C
		private global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger a(string A_0, int A_1)
		{
			int a_ = 3;
			short num = (short)675536396;
			short num2 = num;
			num = (short)1549524492;
			string text;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_109:
				global::System.IO.File.Delete(text);
				num = (short)718077954;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1517158400;
				if (num != 0)
				{
				}
				num = (short)1972109313;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				break;
			}
			for (;;)
			{
				IL_87:
				switch (num3)
				{
				case 0:
					goto IL_107;
				case 1:
				{
					num = (short)2037710848;
					short num4 = num;
					if (global::System.IO.File.Exists(text))
					{
						num = (short)1246101504;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
				}
				case 2:
					goto IL_127;
				}
				goto IL_99;
			}
			IL_107:
			goto IL_109;
			IL_127:
			IL_129:
			global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger partitionLogger = new global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger(text);
			partitionLogger.a(A_0, 0L, A_1);
			return partitionLogger;
			IL_99:
			text = string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("뒙삛邟\udfa1ﮣ즧\ud8a9\ud8ab잭쒯\udbb1\udbb3\ud8b5\uddbb\uddbdꮿ鷁诃독볇뫉맋뫍ﻏ꫑맓뫕", a_), A_0);
			num = (short)1310851073;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_87;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00025E84 File Offset: 0x00024084
		private void b(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0)
		{
			short num = (short)1511829932;
			short num2 = num;
			num = (short)1061269932;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_84:
				num = (short)1296564224;
				short num3 = num;
				num = (short)652476416;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)824115200;
				if (num != 0)
				{
				}
				num = (short)1695023105;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					A_0.Logger.m();
					num = (short)1891500034;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 2:
					goto IL_E3;
				}
				break;
			}
			IL_7C:
			if (A_0.Logger != null)
			{
				goto IL_84;
			}
			IL_E3:
			num = (short)568786945;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00025F9C File Offset: 0x0002419C
		public void Pack(global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug)
		{
			int a_ = 8;
			short num = (short)1995046912;
			switch (num)
			{
			default:
			{
				num = (short)366346241;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_74;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
						try
						{
							global::AcpCommonLib.AppInfoManager.PackOperation = true;
							this.j();
							this.a(codeplug);
							this.t = codeplug;
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> enumerator = this.b.IshTypeExchanges.GetEnumerator();
							try
							{
								num = (short)725745675;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
									switch (num2)
									{
									case 0:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.UclConfigurationCompositeType)
										{
											num = (short)2141519879;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)585498632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										this.a(global::Motorola.Acp.PackUnpack.Ish.Packer.a.e, b);
										num = (short)1610481683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.UclHotListHeaderType)
										{
											num = (short)436797441;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)830799893;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										this.b((global::Motorola.Acp.PackUnpack.Ish.CompositeType)ishType, b);
										num = (short)956629008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										this.a(global::Motorola.Acp.PackUnpack.Ish.Packer.a.c, b);
										num = (short)42729502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_5BE;
									case 7:
										this.a(global::Motorola.Acp.PackUnpack.Ish.Packer.a.b, b);
										num = (short)1634861082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType.IsSingleInstance)
										{
											num = (short)920846339;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.a((global::Motorola.Acp.PackUnpack.Ish.CompositeType)ishType, b);
										num = (short)923926543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
										{
											num = (short)142802969;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1020002321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)565444635;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										b = enumerator.Current;
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType = b.a();
										num = (short)1343881225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_149;
										}
										continue;
									case 13:
										goto IL_19E;
									case 14:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType)
										{
											num = (short)1361772573;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1677393944;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
										{
											num = (short)96862231;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_14E;
									}
									case 18:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										this.b((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)ishType, b);
										num = (short)257014285;
										short num3 = num;
										num = (short)1091353101;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_19E;
										default:
											num = (short)1887436800;
											if (num != 0)
											{
											}
											num = (short)281411596;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 20:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.UclHotListAliasTextListHeaderType)
										{
											num = (short)980025357;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)46268418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 21:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType.IsSingleInstance)
										{
											num = (short)120324114;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.a((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)ishType, b);
										num = (short)1240072220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
										num = (short)421986318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
									{
										global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
										if (ishType is global::Motorola.Acp.PackUnpack.Ish.UclContactListHeaderType)
										{
											num = (short)866320389;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)445579284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 25:
										num = (short)1445068800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 27:
										num = (short)1200160774;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 29:
										this.a(global::Motorola.Acp.PackUnpack.Ish.Packer.a.a, b);
										num = (short)1767440388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_149;
									IL_19E:
									this.a(global::Motorola.Acp.PackUnpack.Ish.Packer.a.d, b);
									num = (short)1615200278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_23E:
									num = (short)672006154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_149:
									goto IL_23E;
								}
								IL_14E:
								throw new global::System.InvalidCastException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횞薤얦좨\ud8aa좬辮얰쪲어튶馸햺튼쮾냂냄럆마꓊뿌믎듐럒", a_));
								IL_5BE:;
							}
							finally
							{
								num = (short)2108620802;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_62A;
									case 1:
										enumerator.Dispose();
										num = (short)258867200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5F3;
										}
										continue;
									}
									IL_5F3:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1836056577;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_62A:;
							}
							this.h();
							return;
						}
						catch (global::System.Exception ex)
						{
							if (ex is global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException)
							{
								throw ex;
							}
							throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾞삠삢캤螦\ud9a8\ud9aa슬첮풰삲운鞶\ud8b8\ud9ba튼춾뗀ꛂꇄ", a_), ex);
						}
						finally
						{
							this.i();
							this.t = null;
							global::AcpCommonLib.AppInfoManager.PackOperation = false;
						}
						goto IL_66E;
					}
					IL_59:
					if (codeplug == null)
					{
						num = (short)2143944704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_66E:
					num = (short)1129250818;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_74:
				num = (short)1932984320;
				short num4 = num;
				num = (short)1681063937;
				if (num != 0)
				{
				}
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.PackUnpackException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾞삠삢캤螦\ud9a8\ud9aa슬첮풰삲운鞶\ud8b8\ud9ba튼춾뗀ꛂꇄ", a_), new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﲞ캠잢삤힦얨\udeaa쪬", a_)));
			}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000266FC File Offset: 0x000248FC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1994207244;
				short num2 = num;
				num = (short)1496920076;
				switch (num2 == num)
				{
				}
				num = (short)8257536;
				if (num != 0)
				{
				}
				num = (short)38141953;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1686110208;
			short num3 = num;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000267C8 File Offset: 0x000249C8
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout i(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)915385432;
			short num2 = num;
			num = (short)683781208;
			switch (num2 == num)
			{
			}
			num = (short)1829109760;
			short num3 = num;
			num = (short)858456065;
			if (num != 0)
			{
			}
			num = (short)570884096;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00026884 File Offset: 0x00024A84
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout a(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0)
		{
			short num = (short)910536472;
			short num2 = num;
			num = (short)1320726296;
			switch (num2 == num)
			{
			}
			num = (short)880541696;
			short num3 = num;
			num = (short)930545665;
			if (num != 0)
			{
			}
			num = (short)943390720;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00026940 File Offset: 0x00024B40
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0)
		{
			short num = (short)739519698;
			short num2 = num;
			num = (short)1130835154;
			switch (num2 == num)
			{
			}
			num = (short)2036989952;
			short num3 = num;
			num = (short)549453825;
			if (num != 0)
			{
			}
			num = (short)485752832;
			if (num != 0)
			{
			}
			return A_0.Partition.Layouts.Find(A_0);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000269FC File Offset: 0x00024BFC
		private global::Motorola.Acp.PackUnpack.Ish.Partition h(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)601379139;
			short num2 = num;
			num = (short)1700417859;
			switch (num2 == num)
			{
			}
			num = (short)2045313024;
			short num3 = num;
			num = (short)1045692417;
			if (num != 0)
			{
			}
			num = (short)778960896;
			if (num != 0)
			{
			}
			return A_0.Partition;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00026AAC File Offset: 0x00024CAC
		private int a(global::AcpCommonLib.IAcpFeatureNode A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num2;
			int result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E4;
				case 1:
				{
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType)
					{
						num2 = (short)884998149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num3;
					result = this.b(this.a(A_1)) + num3;
					num2 = (short)1749155841;
					if (num2 != 0)
					{
					}
					num2 = (short)773586947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_159;
				case 3:
					goto IL_134;
				case 4:
					if (A_0.Parent.IsEmbeddedRecset)
					{
						num2 = (short)432996358;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = this.b(A_1) + A_0.Parent.IndexOf(A_0);
					num2 = (short)596639744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					int num3;
					result = this.c(num3);
					num2 = (short)1707606018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					global::AcpCommonLib.IAcpFeatureNode parent = A_0.Parent.ParentSection.Parent;
					int num3 = parent.Parent.IndexOf(parent);
					num2 = (short)861077505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2C;
			}
			IL_134:
			IL_159:
			IL_1E4:
			return result;
			IL_2C:
			num2 = (short)1680001935;
			short num4 = num2;
			num2 = (short)701483919;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)739115008;
				if (num2 != 0)
				{
				}
				num2 = (short)560988160;
				short num5 = num2;
				result = 0;
				num2 = (short)274989060;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00026CA0 File Offset: 0x00024EA0
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName b(global::AcpBusinessLayer.AcpRecRefField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout A_1, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_2)
		{
			int a_ = 0;
			short num = (short)1095827456;
			switch (num)
			{
			default:
			{
				num = (short)1942093825;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
				global::AcpCommonLib.IAcpField acpField;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_25E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 2:
						if (A_1.Relationship != global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship.Selection)
						{
							num = (short)2063925262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1579876362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2A0;
					case 4:
						if (fieldExchange == null)
						{
							num = (short)1688469511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpField = this.a(A_0.Parent.Parent, fieldExchange);
						num = (short)931201029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (acpField == null)
						{
							num = (short)2141454336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1301807115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)859897861;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (fieldExchange != null)
									{
										num = (short)1402929158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									try
									{
										num = (short)826408964;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_4DE;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1300824069;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2 = enumerator.Current;
												num = (short)799997958;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_480;
											case 3:
											{
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
												fieldExchange = fieldExchange2;
												num = (short)1358823426;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_3CE;
												}
												continue;
											case 5:
												num = (short)1677262848;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
												if (fieldExchange2.Layout == A_1.SelectorLayout)
												{
													num = (short)1747124227;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_485;
											}
											}
											goto IL_3CE;
											IL_485:
											num = (short)376700929;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3CE:
											num = (short)1894154816;
											short num3 = num;
											num = (short)1633714752;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_4DE;
											default:
												num = (short)1705902080;
												if (num != 0)
												{
												}
												goto IL_485;
											}
										}
										IL_480:
										IL_4DE:
										goto IL_5DB;
									}
									finally
									{
										num = (short)1952710658;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_54F;
											case 1:
												enumerator.Dispose();
												num = (short)1232666624;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_516;
												}
												continue;
											}
											IL_516:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1577713665;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_54F:;
									}
									break;
									IL_5DB:
									num = (short)196345856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)858914823;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = enumerator2.Current.GetEnumerator();
									num = (short)575275009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_630;
								case 4:
									goto IL_5AA;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_385;
									}
									continue;
								case 6:
									num = (short)999358468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)284688387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_552:
								num = (short)1771569154;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_385:
								goto IL_552;
							}
							IL_5AA:
							IL_630:
							goto IL_139;
						}
						finally
						{
							num = (short)230948866;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_6A2;
								case 1:
									enumerator2.Dispose();
									num = (short)1643249664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_669;
									}
									continue;
								}
								IL_669:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)677773313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A2:;
						}
						goto IL_6A5;
						IL_139:
						num = (short)1341128708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_170;
					case 8:
						goto IL_212;
					case 9:
						goto IL_2E1;
					case 10:
					{
						if (A_0.ReferencedNode == null)
						{
							num = (short)1692336131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldExchange = null;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2 = A_2.GetEnumerator();
						num = (short)334888966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (!(acpField is global::AcpBusinessLayer.AcpListField))
						{
							num = (short)481755144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A5;
					case 12:
						num = (short)471859213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.a(A_0, A_1))
						{
							num = (short)126091273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF;
					case 14:
						goto IL_10B;
					}
					IL_88:
					if (this.a(A_1))
					{
						num = (short)665649164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					num = (short)1705508866;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10B:
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얖ﲘﲜ좠첢쮤풦솨슪\uddac辮쪰莲좴鞶킸좺鶼톾껀럂듆볈믊뷌ꃎꏐ꟒냔돖", a_), global::System.Enum.GetName(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship), A_1.Relationship)));
				IL_170:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.ExchangeNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슖漢ﾜ쒠莢톤좦覨춪쒬솮햰鎲킴쾶\udab8펺\udcbc톾ꛀꛂ껆ꟈ귊ꋌ뷎볐닒ꇔ뻖뛘뗚﷜맞軠釢엤鳦\ud9e8雪", a_), A_1.SelectorLayout.Name));
				IL_212:
				throw new global::System.InvalidCastException();
				IL_25E:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.FieldNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슖漢ﾜ쒠莢톤좦覨춪쒬솮햰鎲ힴ슶쪸튺펼\udabe닀냂ꯆ꣈닊꣌뷎뗒볔닖뗘뿚﷜ꓞ퇠黢", a_), fieldExchange.PropertyName));
				IL_2A0:
				num = (short)469172224;
				short num4 = num;
				return default(global::Motorola.Acp.PackUnpack.Ish.IshItemName);
				IL_2E1:
				num = (short)1847590913;
				if (num != 0)
				{
				}
				return this.a(A_0, A_1, A_2);
				IL_6A5:
				global::Motorola.Acp.PackUnpack.Ish.IshType ishType = A_1.ReferencedIshTypes[((global::AcpBusinessLayer.AcpListField)acpField).Value];
				int a_2 = A_0.ReferencedNode.Parent.IndexOf(A_0.ReferencedNode);
				return new global::Motorola.Acp.PackUnpack.Ish.IshItemName(ishType.Value, a_2);
			}
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000273C0 File Offset: 0x000255C0
		private bool a(global::AcpBusinessLayer.AcpRecRefField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout A_1)
		{
			short num = (short)1513881603;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12D;
				case 1:
					if (A_0.Parent.FeatureSectionId != 10501)
					{
						num = (short)1066926080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					goto IL_C0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					num = (short)1953234945;
					if (num != 0)
					{
					}
					if (A_0.Parent.FeatureSectionId != 10116)
					{
						num = (short)1942093826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)108789764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				num = (short)1636789249;
				short num3 = num;
				num = (short)547646465;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C0:
					num = (short)1055391744;
					short num4 = num;
					num = (short)1070333953;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)269221888;
					if (num != 0)
					{
					}
					if (A_1.Relationship != global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship.Synchronization)
					{
						return false;
					}
					num = (short)375652357;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12D:
			return A_0.Parent.FeatureSectionId == 10115;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00027570 File Offset: 0x00025770
		private bool a(global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout A_0)
		{
			int a_ = 14;
			short num = (short)1982005253;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.IshType ishType2;
			for (;;)
			{
				string text;
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)260177926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					text = null;
					goto IL_109;
				case 2:
					flag = false;
					goto IL_7D;
				case 3:
					goto IL_1C7;
				case 4:
				{
					global::Motorola.Acp.PackUnpack.Ish.IshType ishType = A_0.ReferencedIshTypes[0];
					if (ishType == null)
					{
						num = (short)490274817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = ishType.Name;
					goto IL_109;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					continue;
				case 6:
				{
					ishType2 = A_0.ReferencedIshTypes[1];
					if (ishType2 != null)
					{
						goto IL_1CA;
					}
					num = (short)1314551454;
					short num3 = num;
					num = (short)1612084894;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E5;
					default:
						num = (short)279642112;
						if (num != 0)
						{
						}
						num = (short)762839043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)1668087809;
					if (num != 0)
					{
					}
					num = (short)501874692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4F:
				global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.IshType> list = A_0.ReferencedIshTypes;
				if (list == null)
				{
					num = (short)1082458114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = (list.Count == 2);
				IL_7D:
				if (flag)
				{
					num = (short)1012531207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1E5;
				IL_109:
				if (!(text == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶲ﮴ﺼ諭賀蛂评鏆雈蟊蓌鳎藐", a_)))
				{
					goto IL_1E5;
				}
				num = (short)258932736;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C7:
			string text2 = null;
			goto IL_1D1;
			IL_1CA:
			text2 = ishType2.Name;
			IL_1D1:
			return text2 == global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾪ怜ﲮ闀", a_);
			IL_1E5:
			num = (short)311296000;
			short num4 = num;
			return false;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0002778C File Offset: 0x0002598C
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(global::AcpBusinessLayer.AcpRecRefField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout A_1, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_2)
		{
			int a_ = 16;
			short num = (short)1421213696;
			switch (num)
			{
			default:
			{
				num = (short)989462533;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
				int index;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpField acpField = this.a(A_0.Parent.Parent, fieldExchange);
						if (acpField == null)
						{
							goto Block_4;
						}
						if (!(acpField is global::AcpBusinessLayer.AcpListField))
						{
							goto Block_5;
						}
						index = 0;
						if (((global::AcpBusinessLayer.AcpListField)acpField).Value == 65535)
						{
							num = (short)1027473414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55B;
					}
					case 1:
						goto IL_438;
					case 2:
						goto IL_8B;
					case 3:
						goto IL_509;
					case 4:
						if (fieldExchange == null)
						{
							num = (short)1702363137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)66453504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 6:
						index = 1;
						num = (short)1227489283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)371064837;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)241106947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2111569920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2 = enumerator.Current.GetEnumerator();
									num = (short)1390149638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_11A;
								case 3:
									goto IL_342;
								case 4:
									num = (short)2020474882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_FF;
									}
									continue;
								case 6:
									try
									{
										num = (short)960888838;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_250;
											case 1:
												num = (short)985464832;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
												if (fieldExchange2.Layout == A_1.SelectorLayout)
												{
													num = (short)1240596485;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1578827777;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2 = enumerator2.Current;
												num = (short)1766719490;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_233;
											case 5:
											{
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
												fieldExchange = fieldExchange2;
												num = (short)1784545284;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												switch (0)
												{
												case 0:
													goto IL_193;
												}
												continue;
											}
											IL_1DB:
											num = (short)2103377923;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_193:
											goto IL_1DB;
										}
										IL_233:
										IL_250:
										goto IL_11F;
									}
									finally
									{
										num = (short)1565261826;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)132644865;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_2C0;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_287;
												}
												continue;
											}
											IL_287:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1218183168;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2C0:;
									}
									break;
									IL_11F:
									num = (short)547749895;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (fieldExchange != null)
									{
										num = (short)1434714116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_2C3:
								num = (short)124256257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FF:
								goto IL_2C3;
							}
							IL_11A:
							IL_342:;
						}
						finally
						{
							num = (short)185008130;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)605159425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)581819354;
									short num3 = num;
									num = (short)1677056986;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_35E;
									default:
										goto IL_3EA;
									}
									break;
								}
								case 2:
									goto IL_35E;
								}
								goto IL_37B;
								IL_35E:
								switch (0)
								{
								case 0:
									IL_37B:
									if (enumerator == null)
									{
										goto IL_401;
									}
									num = (short)366739456;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_3EA:
							num = (short)945291264;
							if (num != 0)
							{
							}
							IL_401:;
						}
						num = (short)862584836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6E:
					if (A_0.ReferencedNode == null)
					{
						num = (short)1724186626;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						fieldExchange = null;
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_2.GetEnumerator();
						num = (short)1393623047;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_8B:
				return default(global::Motorola.Acp.PackUnpack.Ish.IshItemName);
				IL_438:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.ExchangeNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잨쪪쾬쎮풰鎲솴\ud8b6馸\uddba풼톾ꗀꃄ뿆꫈ꏊ곌ꇎ뛐뛒뻖럘뷚닜귞賠苢釤軦蛨藪췬觮黰臲헴賶째蛺", a_), A_1.SelectorLayout.Name));
				Block_4:
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.FieldNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잨쪪쾬쎮풰鎲솴\ud8b6馸\uddba풼톾ꗀꟄ닆뫈ꋊꏌ꫎ꋐꃒ믖룘ꋚ룜귞쇠藢賤苦藨迪췬铮쇰軲", a_), fieldExchange.PropertyName));
				Block_5:
				throw new global::System.InvalidCastException();
				IL_509:
				num = (short)775946241;
				if (num != 0)
				{
				}
				num = (short)2022440960;
				short num4 = num;
				IL_55B:
				global::Motorola.Acp.PackUnpack.Ish.IshType ishType = A_1.ReferencedIshTypes[index];
				int a_2 = A_0.ReferencedNode.Parent.IndexOf(A_0.ReferencedNode);
				return new global::Motorola.Acp.PackUnpack.Ish.IshItemName(ishType.Value, a_2);
			}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00027D58 File Offset: 0x00025F58
		private global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField a(global::AcpBusinessLayer.AcpRecRefField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout A_1)
		{
			short num = (short)1846083584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				int type;
				global::AcpCommonLib.IAcpFeatureNode referencedNode;
				int id;
				ushort index;
				for (;;)
				{
					IL_29:
					num = (short)138719144;
					short num3 = num;
					num = (short)92254120;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1982529536;
						if (num != 0)
						{
						}
						num = (short)1613889537;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_16F;
						case 1:
							goto IL_132;
						case 2:
						{
							num = (short)1834287104;
							short num4 = num;
							type = A_1.ReferencedIshType.Value;
							id = this.a(referencedNode, A_1.ReferencedIshType);
							index = (ushort)A_0.ReferencedIndex;
							goto IL_156;
						}
						case 3:
							if (referencedNode != null)
							{
								num = (short)1372585986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							type = 0;
							id = 0;
							index = 0;
							num = (short)1172635649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0;
					}
					IL_156:
					num = (short)30277632;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_132:
				IL_16F:
				return new global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField(A_1, type, id, index);
				IL_B0:
				referencedNode = A_0.ReferencedNode;
				num = (short)364773379;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00027EE0 File Offset: 0x000260E0
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(global::AcpBusinessLayer.AcpRecRefField A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout A_1)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			int a_2;
			int a_3;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_206;
				case 1:
					a_2 = A_1.ReferencedIshType.Value;
					a_3 = this.a(A_0.ReferencedNode, A_1.ReferencedIshType);
					num2 = (short)1470562304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_0.ReferencedNode != null)
					{
						num2 = (short)1727725569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22F;
				case 3:
				{
					num2 = (short)473366528;
					short num3 = num2;
					num2 = (short)567989717;
					short num4 = num2;
					num2 = (short)943248853;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						num2 = (short)1144258560;
						if (num2 != 0)
						{
						}
						num2 = (short)662306818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					a_2 = A_1.ReferencedIshType.Value;
					a_3 = this.a(A_0.Parent.Parent, A_1.ReferencedIshType);
					num2 = (short)1347289094;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (A_1.Relationship == global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship.Synchronization)
					{
						num2 = (short)216727556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19D;
				case 6:
					goto IL_122;
				case 7:
					if (A_1.Relationship == global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship.Selection)
					{
						goto IL_5D;
					}
					num2 = (short)110100485;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_5D:
				num2 = (short)389283843;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_122:
			goto IL_22F;
			IL_19D:
			throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧첩즫\udcad햯\udcb1ힳ펵\udfb9킻\udfbd뒿ꯁꯃꣅ믇ꋉꗋ뻍ﻏ꧑ꯕ동꿛ﻝ軟跡郣웥鯧鿩鳫黭鿯胱胳鏵鳷", a_), global::System.Enum.GetName(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship), A_1.Relationship)));
			IL_206:
			num2 = (short)276692993;
			if (num2 != 0)
			{
			}
			IL_22F:
			return new global::Motorola.Acp.PackUnpack.Ish.IshItemName(a_2, a_3);
			IL_39:
			a_2 = 0;
			a_3 = 0;
			num2 = (short)643301383;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00028124 File Offset: 0x00026324
		protected virtual object GetFieldValue(global::AcpCommonLib.IAcpField acpField, global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange)
		{
			int a_ = 8;
			short num = (short)2119499776;
			switch (num)
			{
			default:
			{
				num = (short)1900871684;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)429785088;
						short num3 = num;
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
						{
							num = (short)357171205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1533476886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_14B;
					case 2:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)
						{
							num = (short)1375535118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A5;
					case 3:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)
						{
							num = (short)474415105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2056847362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 5:
						goto IL_1B7;
					case 6:
						if (acpField is global::AcpBusinessLayer.AcpField<string>)
						{
							num = (short)1612382227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)331218954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_23A;
					case 8:
						goto IL_4D0;
					case 9:
					{
						global::System.Type type;
						if (type.IsGenericType)
						{
							num = (short)480116753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1022558209;
						if (num != 0)
						{
						}
						property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즞삠쾢키슦", a_));
						num = (short)1453064200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (acpField is global::AcpBusinessLayer.AcpIPAddressField)
						{
							num = (short)1931083788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)995819536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						fieldLayout = fieldExchange.Layout;
						num = (short)483721216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_342;
					case 13:
						goto IL_509;
					case 14:
						goto IL_478;
					case 15:
						goto IL_10A;
					case 16:
					{
						if (acpField is global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter)
						{
							num = (short)52297748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type type = acpField.GetType();
						num = (short)1559494665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Type type;
						global::System.Type[] genericArguments = type.GetGenericArguments();
						property = type.GetProperty(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즞삠쾢키슦", a_), genericArguments[0]);
						num = (short)479854605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						num = (short)1061896375;
						short num4 = num;
						num = (short)1000226999;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_297;
						default:
							goto IL_3BE;
						}
						break;
					}
					case 19:
						goto IL_381;
					case 20:
						goto IL_297;
					case 21:
						if (acpField is global::AcpBusinessLayer.AcpField<int>)
						{
							num = (short)1754071058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2020081670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (fieldLayout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)
						{
							num = (short)1940979727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1700593667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AB:
					if (acpField is global::AcpBusinessLayer.AcpRecRefField)
					{
						num = (short)629342219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2133786645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_297:
					num = (short)2050293767;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10A:
				return this.a((global::AcpBusinessLayer.AcpRecRefField)acpField, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)fieldLayout);
				IL_14B:
				return this.b((global::AcpBusinessLayer.AcpRecRefField)acpField, (global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)fieldLayout, fieldExchange.Parent.Parent);
				IL_1B7:
				return this.a((global::AcpBusinessLayer.AcpRecRefField)acpField, (global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)fieldLayout);
				IL_23A:
				int num5 = ((global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter)acpField).VoiceFileField.VoiceData.ReadByte();
				if (num5 == -1)
				{
					throw new global::System.IO.IOException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\uda9e쾠잢薤좦쾨讪\udeac\udbae쎰횲풴\udab6馸즺\ud8bc\udebeꋀꯂꃄꏆ", a_));
				}
				return (byte)num5;
				IL_2A5:
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc9e삠춢쮤좦\udda8讪좬힮튰\udbb2풴\ud9b6\udeb8\udeba鶼즾ꃀ꿂냄ꋆ귊뿌ꃎ볐듔맖律髚뻜꿞돠蛢蛤뗦賨跪꯬蛮铰鿲釴ퟶ郸闺軼课怀洂昄戆⤈缊戌⼎瀐㌒猔縖簘眚礜㼞吠倢䰤䤦丨ପ䰬༮䨰̲䠴᜶唸娺䐼倾㑀㝂", a_), fieldLayout.GetType().Name));
				IL_342:
				return ((global::AcpBusinessLayer.AcpIPAddressField)acpField).AddressBytes;
				IL_381:
				return ((global::AcpBusinessLayer.AcpField<string>)acpField).Value;
				IL_3BE:
				num = (short)742785024;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
				IL_478:
				return ((global::AcpBusinessLayer.AcpRecRefField)acpField).Value;
				IL_4D0:
				IL_509:
				return property.GetValue(acpField, null);
			}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00028658 File Offset: 0x00026858
		private void a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1, long A_2, object A_3)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			global::System.TypeCode type;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)
					{
						num2 = (short)562036738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E6;
				case 1:
					goto IL_37F;
				case 2:
					goto IL_119;
				case 3:
					goto IL_2AE;
				case 4:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)
					{
						num2 = (short)413073421;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)380764169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					switch (type)
					{
					case global::System.TypeCode.Object:
						num2 = (short)372310026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.DBNull:
					case global::System.TypeCode.Single:
					case global::System.TypeCode.Double:
					case global::System.TypeCode.Decimal:
					case global::System.TypeCode.DateTime:
					case (global::System.TypeCode)17:
						goto IL_466;
					case global::System.TypeCode.Boolean:
						goto IL_2F1;
					case global::System.TypeCode.Char:
						goto IL_1C7;
					case global::System.TypeCode.SByte:
						goto IL_324;
					case global::System.TypeCode.Byte:
						goto IL_247;
					case global::System.TypeCode.Int16:
						goto IL_335;
					case global::System.TypeCode.UInt16:
						goto IL_1D8;
					case global::System.TypeCode.Int32:
						num2 = (short)386400257;
						if (num2 != 0)
						{
						}
						num2 = (short)975306756;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt32:
						goto IL_194;
					case global::System.TypeCode.Int64:
						goto IL_1FA;
					case global::System.TypeCode.UInt64:
						goto IL_302;
					case global::System.TypeCode.String:
						goto IL_20B;
					default:
						num2 = (short)1671823374;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 6:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout)
					{
						num2 = (short)1718812683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)703660044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_3E1;
				case 8:
					goto IL_270;
				case 9:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)
					{
						num2 = (short)1651834881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)412483584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)
					{
						num2 = (short)1422393351;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)829423622;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_2EC;
				case 12:
					if (A_1 is global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout)
					{
						num2 = (short)1575550979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_384;
				case 13:
					goto IL_17E;
				case 14:
					num2 = (short)2036269064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
			}
			IL_119:
			this.PackDynamicItemReferenceField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout)A_1, A_3, A_2);
			return;
			IL_17E:
			this.PackInt32Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_194:
			this.PackUInt32Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_1C7:
			this.PackCharField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout)A_1, A_3, A_2);
			return;
			IL_1D8:
			this.PackUInt16Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_1E9:
			this.PackByteArrayField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout)A_1, A_3, A_2);
			return;
			IL_1FA:
			this.PackInt64Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_20B:
			num2 = (short)781713408;
			short num3 = num2;
			this.PackStringField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout)A_1, A_3, A_2);
			return;
			IL_247:
			this.PackByteField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_270:
			goto IL_466;
			IL_2AE:
			goto IL_1E9;
			IL_2EC:
			this.PackIPAddressField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout)A_1, A_3, A_2);
			return;
			IL_2F1:
			this.PackBoolField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout)A_1, A_3, A_2);
			return;
			IL_302:
			this.PackUInt64Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_324:
			this.PackSByteField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_335:
			this.PackInt16Field(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout)A_1, A_3, A_2);
			return;
			IL_37F:
			this.PackItemReferenceField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout)A_1, A_3, A_2);
			return;
			IL_384:
			throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ꮚ뾞좠킢薤즦욨\udfaa趬캮醰삲살잶횸즺즼\udabeꗀ꧄ꛆ냈꓊료믎꟒곔Ꟗ볘", a_), A_1.GetType().Name));
			IL_3E1:
			this.PackIndexReferenceField(A_0, (global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout)A_1, A_3, A_2);
			return;
			IL_3E6:
			num2 = (short)1328300060;
			short num4 = num2;
			num2 = (short)653017116;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1E9;
			default:
				num2 = (short)882638848;
				if (num2 != 0)
				{
				}
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ꮚ뾞좠킢薤즦욨\udfaa趬캮醰삲살잶횸즺즼\udabeꗀ꧄ꛆ냈꓊료믎꟒곔Ꟗ볘", a_), A_1.GetType().Name));
			}
			IL_466:
			throw new global::System.NotSupportedException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ꮚ뾞좠킢薤즦욨\udfaa趬캮醰삲살잶횸즺즼\udabeꗀ꧄ꛆ냈꓊료믎꟒곔Ꟗ볘", a_), A_1.GetType().Name));
			IL_55:
			type = A_1.Type;
			num2 = (short)846659589;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00028AF0 File Offset: 0x00026CF0
		private bool d(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)548143104;
			switch (num)
			{
			default:
			{
				num = (short)355532809;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count > 0)
						{
							num = (short)1187381250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = ((global::AcpBusinessLayer.Recordset)feature).CreateDefaultRecord();
						num = (short)1691615237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return false;
					case 2:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[0];
						goto IL_E7;
					}
					case 3:
						return true;
					case 4:
					{
						num = (short)1996619777;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
						if (!(acpFeatureNode[sectionExchange.Key][fieldExchange.PropertyName] is global::AcpBusinessLayer.AcpVoiceFileField))
						{
							return false;
						}
						num = (short)609158386;
						short num3 = num;
						num = (short)1652032754;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)178520064;
							if (num != 0)
							{
							}
							num = (short)656801795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_153;
					case 6:
						return false;
					case 7:
					{
						if (sectionExchange.Count != 1)
						{
							num = (short)154927110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
						enumerator.MoveNext();
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
						num = (short)1129775104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_153;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					}
					IL_6B:
					num = (short)1346371584;
					short num4 = num;
					if (A_0.Count != 1)
					{
						num = (short)1505624065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					sectionExchange = this.a(A_0);
					num = (short)1068892167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					num = (short)2117599240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					num = (short)753205252;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00028D80 File Offset: 0x00026F80
		private bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, int A_1, out global::AcpCommonLib.IAcpRecordset A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.IAcpField acpField;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
				switch (num)
				{
				case 0:
					goto IL_1DA;
				case 1:
					if (A_2.RecsetId == 4228)
					{
						num2 = (short)2008612866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_85;
				case 2:
					num2 = (short)924385281;
					if (num2 != 0)
					{
					}
					num2 = (short)1213792263;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return false;
				case 4:
					num2 = (short)1581318152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (acpField is global::AcpBusinessLayer.AcpVoiceFileField)
					{
						num2 = (short)2016018445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_2 = null;
					goto IL_1C3;
				case 6:
					goto IL_18E;
				case 7:
					if (A_2.CanBeEmpty)
					{
						num2 = (short)1360134148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_85;
				case 8:
					if (A_2.Count == 0)
					{
						num2 = (short)1343225859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_85;
				case 9:
				{
					if (sectionExchange.Count != 1)
					{
						num2 = (short)1573191692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
					enumerator.MoveNext();
					fieldExchange = enumerator.Current;
					A_2 = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
					num2 = (short)193069057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (A_0.Count != 1)
					{
						num2 = (short)278200331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					sectionExchange = this.a(A_0);
					num2 = (short)1263337481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return false;
				case 12:
				{
					num2 = (short)1239698710;
					short num3 = num2;
					num2 = (short)948718870;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C3;
					default:
						goto IL_29F;
					}
					break;
				}
				case 13:
					A_2 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter((global::AcpBusinessLayer.AcpVoiceFileField)acpField);
					num2 = (short)1478295558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_48;
				IL_85:
				acpField = A_2[A_1][sectionExchange.Key][fieldExchange.PropertyName];
				num2 = (short)1349058565;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C3:
				num2 = (short)1423769600;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_18E:
			num2 = (short)177864704;
			short num4 = num2;
			IL_1DA:
			goto IL_2F8;
			IL_29F:
			num2 = (short)1006501888;
			if (num2 != 0)
			{
			}
			return false;
			IL_2F8:
			return A_2 != null;
			IL_48:
			A_2 = null;
			num2 = (short)1063059466;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0002908C File Offset: 0x0002728C
		private bool c(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)1441726464;
			switch (num)
			{
			default:
			{
				num = (short)427360266;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature;
					global::AcpCommonLib.IAcpField acpField;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
					switch (num2)
					{
					case 0:
						goto IL_1D3;
					case 1:
						if (feature.RecsetId == 4228)
						{
							num = (short)1452277762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 2:
						num = (short)1419509767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)441024324;
						short num3 = num;
						num = (short)1517387588;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
							goto IL_20B;
						}
						break;
					}
					case 4:
						num = (short)55443464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (acpField is global::AcpBusinessLayer.AcpSparseLOVField)
						{
							num = (short)1628176397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if (((global::AcpBusinessLayer.AcpSparseLOVField)acpField).SerializeItems)
						{
							num = (short)1378156544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						if (feature.CanBeEmpty)
						{
							num = (short)1051197444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 8:
						if (feature.Count == 0)
						{
							num = (short)70975491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 9:
					{
						if (sectionExchange.Count != 1)
						{
							num = (short)1679687692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
						enumerator.MoveNext();
						fieldExchange = enumerator.Current;
						feature = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
						num = (short)665518081;
						if (num != 0)
						{
						}
						num = (short)952696833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 11:
						return false;
					case 12:
						return false;
					case 13:
						num = (short)798294022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C;
					IL_88:
					num = (short)1520369675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C:
					if (A_0.Count != 1)
					{
						goto IL_88;
					}
					sectionExchange = this.a(A_0);
					num = (short)1050279945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4:
					acpField = feature[0][sectionExchange.Key][fieldExchange.PropertyName];
					num = (short)1669070853;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1D3:
				num = (short)594411520;
				short num4 = num;
				return true;
				IL_20B:
				num = (short)1309540352;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000293B8 File Offset: 0x000275B8
		private bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, out global::AcpCommonLib.IAcpRecordset A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
				global::AcpCommonLib.IAcpField acpField;
				switch (num)
				{
				case 0:
				{
					if (sectionExchange.Count != 1)
					{
						num2 = (short)1667235844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1161166848;
					short num3 = num2;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange.GetEnumerator();
					enumerator.MoveNext();
					fieldExchange = enumerator.Current;
					A_1 = global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
					num2 = (short)2003501067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)373620741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (acpField is global::AcpBusinessLayer.AcpSparseLOVField)
					{
						num2 = (short)1063190543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 3:
					if (A_1.CanBeEmpty)
					{
						num2 = (short)1719205889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8D;
				case 4:
					return false;
				case 5:
					if (A_1.Count == 0)
					{
						num2 = (short)734199818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8D;
				case 6:
					goto IL_26B;
				case 7:
					num2 = (short)1082982403;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					A_1 = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter((global::AcpBusinessLayer.AcpSparseLOVField)acpField);
					num2 = (short)1212809230;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (((global::AcpBusinessLayer.AcpSparseLOVField)acpField).SerializeItems)
					{
						num2 = (short)533594120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 10:
					return false;
				case 11:
					if (A_1.RecsetId == 4228)
					{
						num2 = (short)1867382791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8D;
				case 12:
					if (A_0.Count != 1)
					{
						num2 = (short)2007302157;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)957677569;
					if (num2 != 0)
					{
					}
					sectionExchange = this.a(A_0);
					goto IL_159;
				case 13:
					return false;
				case 14:
				{
					num2 = (short)2130814512;
					short num4 = num2;
					num2 = (short)587245104;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_159;
					default:
						goto IL_1F1;
					}
					break;
				}
				case 15:
					num2 = (short)298254345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
				IL_8D:
				acpField = A_1[0][sectionExchange.Key][fieldExchange.PropertyName];
				num2 = (short)1772486658;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_159:
				num2 = (short)1669332992;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_251:
				A_1 = null;
				num2 = (short)2122121222;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_1F1:
			num2 = (short)2060779520;
			if (num2 != 0)
			{
			}
			IL_26B:
			return A_1 != null;
			IL_50:
			A_1 = null;
			num2 = (short)823132172;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0002970C File Offset: 0x0002790C
		private global::AcpCommonLib.IAcpRecordset b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)948442369;
			short num2 = num;
			num = (short)1918702849;
			switch (num2 == num)
			{
			}
			num = (short)1815740416;
			if (num != 0)
			{
			}
			num = (short)117899265;
			if (num != 0)
			{
			}
			num = (short)1644494848;
			short num3 = num;
			return this.a(A_0, 0);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000297BC File Offset: 0x000279BC
		private global::AcpCommonLib.IAcpRecordset a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, int A_1)
		{
			short num = (short)1296695299;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a(A_0, out result))
					{
						num = (short)1005387777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1843986436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					goto IL_CA;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					if (this.a(A_0, A_1, out result))
					{
						num = (short)1062338562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				case 5:
					num = (short)2124349440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (A_0.Parent != null)
				{
					goto IL_192;
				}
				num = (short)1476984837;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)2126095806;
			short num3 = num;
			num = (short)530818494;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num = (short)1535180800;
				if (num != 0)
				{
				}
				num = (short)562495489;
				if (num != 0)
				{
				}
				num = (short)2101739520;
				short num4 = num;
				return result;
			}
			}
			IL_184:
			return global::AcpCommonLib.FeatureManager.GetFeature(A_0.Key);
			IL_192:
			return global::AcpCommonLib.FeatureManager.GetFeature(A_0.Parent.Parent.Key)[A_1][A_0.Parent.Key].EmbeddedRecset;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0002998C File Offset: 0x00027B8C
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			short num = (short)1484920155;
			short num2 = num;
			num = (short)315233627;
			switch (num2 == num)
			{
			}
			num = (short)991690752;
			short num3 = num;
			num = (short)383582208;
			if (num != 0)
			{
			}
			num = (short)1157234689;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00029A48 File Offset: 0x00027C48
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange d(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			int a_ = 6;
			short num = (short)892141573;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					a_2 = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite];
					num = (short)1896480770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)261095425;
					if (num != 0)
					{
					}
					if (A_0.a() is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						goto IL_156;
					}
					goto IL_194;
				case 2:
					goto IL_192;
				case 3:
					goto IL_106;
				case 4:
					a_2 = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader];
					num = (short)1672478723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (!(A_0.a() is global::Motorola.Acp.PackUnpack.Ish.CompositeType))
				{
					num = (short)1660813313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1835959989;
				short num3 = num;
				num = (short)544310965;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)138805248;
					short num4 = num;
					num = (short)2023489536;
					if (num != 0)
					{
					}
					num = (short)1215561728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_156:
				num = (short)1503985668;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_106:
			IL_192:
			goto IL_1BD;
			IL_194:
			throw new global::System.InvalidCastException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("꾞\udca0莢첤풦覨얪슬\udbae醰튲閴쒶첸쮺튼춾뗀ꛂꇄ胈飊藌ꗐ꫒ꗔ닖", a_), A_0.a().GetType().Name));
			IL_1BD:
			return this.a(a_2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00029C1C File Offset: 0x00027E1C
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			short num = (short)23643513;
			short num2 = num;
			num = (short)742966649;
			switch (num2 == num)
			{
			}
			num = (short)489291776;
			short num3 = num;
			num = (short)869400577;
			if (num != 0)
			{
			}
			num = (short)1928069120;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = A_0.GetEnumerator();
			enumerator.MoveNext();
			return enumerator.Current;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00029CD8 File Offset: 0x00027ED8
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange c(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			if (A_0.a(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader))
			{
				short num = (short)1348229520;
				short num2 = num;
				num = (short)847468944;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)899481601;
					if (num != 0)
					{
					}
					num = (short)921370624;
					if (num != 0)
					{
					}
					num = (short)1009319936;
					short num3 = num;
					return this.a(A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader]);
				}
				}
			}
			return null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00029D98 File Offset: 0x00027F98
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			short num = (short)1866203136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange result;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						result = recsetExchange;
						num = (short)1592393731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
					{
						num = (short)773607212;
						short num3 = num;
						num = (short)1134841644;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_102;
						default:
						{
							num = (short)863305728;
							short num4 = num;
							num = (short)1115422720;
							if (num != 0)
							{
							}
							num = (short)105709572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						return result;
					case 4:
						if (this.c(recsetExchange))
						{
							num = (short)1885208586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.a(recsetExchange).RecsetExchange;
						num = (short)343736331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)220397575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
						if (feature.SingleInstance)
						{
							num = (short)167903234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					case 8:
						return result;
					case 9:
						if (this.d(recsetExchange))
						{
							num = (short)1538195456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.a(recsetExchange).RecsetExchange;
						num = (short)767754246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)2141716481;
						if (num != 0)
						{
						}
						result = recsetExchange;
						num = (short)868220929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return result;
					case 12:
						if (A_0.a().IsSingleInstance)
						{
							num = (short)1038942213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1667366921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
					IL_102:
					result = recsetExchange;
					num = (short)1410072584;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_63:
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_ = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry];
				recsetExchange = this.a(a_);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
				num = (short)399573004;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0002A070 File Offset: 0x00028270
		private void b(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_0, int A_1, global::AcpCommonLib.IAcpFeatureNode A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3, global::AcpCommonLib.IAcpRecordset A_4, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_5)
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				num = (short)301137920;
				switch (num)
				{
				default:
				{
					num = (short)1339621385;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							goto IL_135;
						case 2:
							goto IL_24D;
						case 3:
							if (!A_0.AllowEmptyList)
							{
								num = (short)397869056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20A;
						case 4:
						{
							int num3;
							int num4;
							if (num3 >= num4)
							{
								num = (short)1245773831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num5;
							int num6;
							num5 += this.a(A_0, A_4, num6 + num5, A_5);
							num3++;
							num = (short)370343937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_135;
						case 6:
							num = (short)244514819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_16E;
						case 8:
						{
							if (A_4.Count > A_0.ListCapacity)
							{
								num = (short)224985090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num6 = this.a(A_0, A_1, A_2, A_3, A_4, A_5);
							int num4 = this.a(A_0, A_4.Count - num6);
							int num5 = 0;
							int num3 = 0;
							num = (short)458162181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_75;
							}
							continue;
						}
						IL_75:
						if (A_4.Count == 0)
						{
							num = (short)28966918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20A;
						IL_135:
						num = (short)70778884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20A:
						num = (short)440467464;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_16E:
					num = (short)1052770305;
					if (num != 0)
					{
					}
					num = (short)558270706;
					short num7 = num;
					num = (short)887654642;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_288;
					}
					break;
				}
				}
			}
			return;
			IL_24D:
			num = (short)2011168768;
			short num8 = num;
			throw new global::System.InvalidOperationException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풗肟송얣횥즧즩얫\udaad즯銱톳캵\udbb7\udfb9\ud9bb\udabdꖿꛁꃅꟇ룉蟍菏髑ꋕꇗ꫙맛ﻝ鯟틡駣웥샧釩\uddeb鏭\ud9ef", a_), A_0.HeaderType.Value, A_0.Name));
			IL_288:
			num = (short)1817247744;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0002A31C File Offset: 0x0002851C
		private int a(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_0, int A_1, global::AcpCommonLib.IAcpFeatureNode A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3, global::AcpCommonLib.IAcpRecordset A_4, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_5)
		{
			short num = (short)531038208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				int num3;
				global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider;
				global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderType headerType;
				for (;;)
				{
					IL_27:
					global::Motorola.Acp.PackUnpack.Ish.IshItemName a_;
					long num4;
					long num5;
					switch (num2)
					{
					case 0:
						if (A_4.Count - num3 > 0)
						{
							num = (short)728891411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null;
						num = (short)1526136846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						this.g(partitionIOProvider.Logger);
						num = (short)2003894278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_2 != null)
						{
							num = (short)698155011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_433;
					case 3:
						this.a(A_3, partitionIOProvider, A_2, num4);
						this.a(partitionIOProvider, A_0.HeaderDataAreaLayout, num4);
						num = (short)1991442437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						this.a(partitionIOProvider, A_0.HeaderDataAreaLayout, num4);
						num = (short)1953890314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)237699073;
						if (num != 0)
						{
						}
						goto IL_190;
					case 6:
						if (partitionIOProvider.Writer.BaseStream.Position - num5 != (long)(A_0.ListEntrySize * num3))
						{
							num = (short)1685454861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EA;
					case 7:
						goto IL_1ED;
					case 8:
						goto IL_1F2;
					case 9:
						if (A_0.HeaderDataAreaLayout != null)
						{
							num = (short)634322955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 10:
						goto IL_190;
					case 11:
						num = (short)1442512914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_270;
					case 13:
						goto IL_428;
					case 14:
						goto IL_1F2;
					case 15:
					{
						int num6;
						if (num6 >= num3)
						{
							num = (short)1545601025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode a_2 = A_4[num6];
						long num7;
						this.a(partitionIOProvider.Logger, num7);
						this.a(A_5, partitionIOProvider, a_2, num7);
						num7 = this.a(partitionIOProvider, A_0.ListEntryLayout, num7);
						this.c(partitionIOProvider.Logger);
						num6++;
						num = (short)940376081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						if (partitionIOProvider.Writer.BaseStream.Position != num5)
						{
							num = (short)765788167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						long num7 = num5;
						this.b(partitionIOProvider.Logger, num5);
						int num6 = 0;
						num = (short)196620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_270;
					case 18:
						if (A_0.HeaderDataAreaSize > 0)
						{
							num = (short)295305220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 19:
					{
						num = (short)193166298;
						short num8 = num;
						num = (short)143686618;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_433;
						default:
						{
							num = (short)1149566976;
							if (num != 0)
							{
							}
							num = (short)482017280;
							short num9 = num;
							a_ = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(listListletType.Value, this.f(listListletType));
							num = (short)2074673160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_7E;
					IL_190:
					this.h(partitionIOProvider.Logger);
					num5 = num4 + (long)A_0.HeaderDataAreaSize;
					num = (short)1925054480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F2:
					int a_3 = this.a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader, A_0, num3);
					long num10 = this.a(partitionIOProvider, headerType.Name, headerType, A_1, a_3);
					this.a(partitionIOProvider, A_0, A_4.Count, num3, a_);
					num4 = num10 + 18L;
					this.c(partitionIOProvider.Logger, num4);
					num = (short)431226882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_270:
					num = (short)341835791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_433:
					num = (short)1725956105;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1ED:
				throw new global::System.IO.IOException();
				IL_428:
				throw new global::System.IO.IOException();
				IL_4EA:
				this.a(partitionIOProvider);
				return num3;
				IL_7E:
				headerType = A_0.HeaderType;
				listListletType = A_0.ListletType;
				partitionIOProvider = this.c(headerType);
				num3 = this.b(A_0, A_4.Count);
				num = (short)1947926528;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0002A81C File Offset: 0x00028A1C
		private int a(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_0, global::AcpCommonLib.IAcpRecordset A_1, int A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_3)
		{
			short num = (short)1505820672;
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
				global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider;
				int num8;
				global::Motorola.Acp.PackUnpack.Ish.ListListletType listListletType;
				int num10;
				int a_4;
				for (;;)
				{
					IL_27:
					int num4;
					long num7;
					global::Motorola.Acp.PackUnpack.Ish.IshItemName a_2;
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 > num4)
						{
							num = (short)1083179015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1602486272;
						short num5 = num;
						global::AcpCommonLib.IAcpFeatureNode a_ = A_1[num3];
						long num6;
						this.a(partitionIOProvider.Logger, num6);
						this.a(A_3, partitionIOProvider, a_, num6);
						num6 = this.a(partitionIOProvider, A_0.ListEntryLayout, num6);
						this.c(partitionIOProvider.Logger);
						num3++;
						num = (short)2110783489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_BD;
					case 2:
						if (partitionIOProvider.Writer.BaseStream.Position - num7 != (long)(A_0.ListEntrySize * num8))
						{
							num = (short)1810563077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 3:
					{
						num = (short)404062280;
						short num9 = num;
						num = (short)93028424;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1787756544;
							if (num != 0)
							{
							}
							goto IL_2D3;
						}
						break;
					}
					case 4:
						goto IL_378;
					case 5:
						goto IL_1AC;
					case 6:
						goto IL_BD;
					case 7:
						this.g(partitionIOProvider.Logger);
						num = (short)1688403970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num8 = A_0.ListletCapacity;
						a_2 = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(listListletType.Value, this.f(listListletType));
						num = (short)670367747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2D3;
					case 10:
					{
						if (partitionIOProvider.Writer.BaseStream.Position != num7)
						{
							num = (short)665583620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b(partitionIOProvider.Logger, num7);
						long num6 = num7;
						int num3 = A_2;
						num = (short)992018438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (num10 > A_0.ListletCapacity)
						{
							num = (short)540475400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8 = num10;
						a_2 = global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null;
						num = (short)1021444105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E;
					IL_BD:
					num = (short)1723269120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D3:
					int a_3 = this.a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListListlet, A_0, num8);
					long num11 = this.a(partitionIOProvider, listListletType.Name, listListletType, a_4, a_3);
					this.a(partitionIOProvider, A_0, num8, a_2);
					num4 = A_2 + num8 - 1;
					num7 = num11 + 6L;
					num = (short)546701313;
					if (num != 0)
					{
					}
					num = (short)883687434;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AC:
				throw new global::System.IO.IOException();
				IL_378:
				throw new global::System.IO.IOException();
				IL_37D:
				this.a(partitionIOProvider);
				return num8;
				IL_5E:
				listListletType = A_0.ListletType;
				partitionIOProvider = this.c(listListletType);
				num10 = A_1.Count - A_2;
				a_4 = this.e(listListletType);
				num = (short)23003147;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		private int b(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_0, int A_1)
		{
			if (A_1 <= A_0.HeaderCapacity)
			{
				short num = (short)371980210;
				short num2 = num;
				num = (short)1577318322;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)728956929;
					if (num != 0)
					{
					}
					num = (short)1703411712;
					if (num != 0)
					{
					}
					num = (short)2047606784;
					short num3 = num;
					return A_1;
				}
				}
			}
			return A_0.HeaderCapacity;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0002AC68 File Offset: 0x00028E68
		private int a(global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_0, int A_1)
		{
			int a_ = 18;
			short num = (short)117820900;
			short num2 = num;
			num = (short)2115948004;
			int num3;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_185:
				num3++;
				num = (short)694026243;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)644153344;
				if (num != 0)
				{
				}
				num = (short)344195078;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)26411009;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_121;
				case 1:
				{
					num = (short)1636368384;
					short num5 = num;
					if (A_1 > 0)
					{
						num = (short)1341915141;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 0;
				}
				case 2:
					num = (short)1471283201;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return num3;
				case 4:
				{
					int num6;
					if (num6 > 0)
					{
						num = (short)606404608;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num3;
				}
				case 5:
					goto IL_183;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					continue;
				}
				IL_BC:
				if (A_0.ListletCapacity == 0)
				{
					num = (short)1520697346;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					int num6;
					num3 = global::System.Math.DivRem(A_1, A_0.ListletCapacity, out num6);
					num = (short)683933700;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_121:
			goto IL_185;
			IL_183:
			throw new global::System.InvalidOperationException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪪쎬솮\udeb0잲閴잶\ud8b8\ud8ba횼龾ꣀ럂ꃄ꫆뫈만ꃎ뿒볔ꓖ귘럚룜ꯞ쇠韢鳤韦賨쯪雬\udfee賰폲\uddf4賶죸蛺퓼엾℀瀂甄戆樈戊欌明琐眒㔔琖砘欚簜簞䠠圢尤ܦ䰨匪丬䨮吰圲倴匶", a_), A_0.ListletType.Value, A_0.ListletType.Name));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0002AE4C File Offset: 0x0002904C
		private global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker g(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)1806342871;
			short num2 = num;
			num = (short)38181591;
			switch (num2 == num)
			{
			}
			num = (short)1422786560;
			short num3 = num;
			num = (short)666238976;
			if (num != 0)
			{
			}
			num = (short)1254948865;
			if (num != 0)
			{
			}
			return this.h(A_0).IdTracker;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0002AF04 File Offset: 0x00029104
		private int f(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)1646376162;
			short num2 = num;
			num = (short)385725666;
			global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker ishTypeIdTracker;
			int num4;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AE:
				num = (short)1756168192;
				short num3 = num;
				if (ishTypeIdTracker.a(A_0))
				{
					num = (short)1268580355;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					ishTypeIdTracker.Add(A_0, 0);
					result = 0;
					num = (short)1570701313;
					num4 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			default:
				num = (short)591921152;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num4)
				{
				case 0:
					goto IL_AE;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					result = ishTypeIdTracker.e(A_0);
					num = (short)919011330;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6A;
			}
			return result;
			IL_6A:
			num = (short)1507328001;
			if (num != 0)
			{
			}
			ishTypeIdTracker = this.g(A_0);
			num = (short)1886912512;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0002B050 File Offset: 0x00029250
		private int e(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)495804400;
			short num2 = num;
			num = (short)1582587888;
			global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker ishTypeIdTracker;
			int num4;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_88:
				if (ishTypeIdTracker.a(A_0))
				{
					num = (short)2040332288;
					short num3 = num;
					num = (short)563347459;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					ishTypeIdTracker.Add(A_0, 0);
					result = 0;
					num = (short)1062928385;
					num4 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)38010880;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				break;
			}
			for (;;)
			{
				IL_56:
				switch (num4)
				{
				case 0:
					goto IL_88;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					num = (short)1193738241;
					if (num != 0)
					{
					}
					result = ishTypeIdTracker.d(A_0);
					num = (short)927596546;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6C;
			}
			return result;
			IL_6C:
			ishTypeIdTracker = this.g(A_0);
			num = (short)18350080;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0002B1A0 File Offset: 0x000293A0
		private void a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_1, global::AcpCommonLib.IAcpFeatureNode A_2, long A_3)
		{
			short num = (short)1163460608;
			short num2 = num;
			num = (short)916074667;
			short num3 = num;
			num = (short)1121005739;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)48627712;
				if (num != 0)
				{
				}
				num = (short)1589444608;
				switch (num)
				{
				default:
				{
					num = (short)328859649;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_0.GetEnumerator();
					try
					{
						num = (short)1443495936;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_FA;
								}
								continue;
							case 1:
								try
								{
									num = (short)2123759616;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1A7;
											}
											continue;
										case 1:
										{
											global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)341114884;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator2.Current;
											global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
											global::AcpCommonLib.IAcpField acpField = acpFeatureSection[fieldExchange.PropertyName];
											object fieldValue = this.GetFieldValue(acpField, fieldExchange);
											this.a(A_1, fieldExchange.Layout, A_3, fieldValue);
											this.a(acpField);
											num = (short)232194050;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_250;
										case 4:
											num = (short)1176240131;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1A9:
										num = (short)1472528385;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_1A7:
										goto IL_1A9;
									}
									IL_250:
									break;
								}
								finally
								{
									num = (short)1491861504;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_288;
											}
											continue;
										case 1:
											goto IL_2C1;
										case 2:
											enumerator2.Dispose();
											num = (short)537591809;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_288:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1729101826;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_2C1:;
								}
								goto IL_2C4;
							case 2:
								goto IL_2C4;
							case 3:
								goto IL_2DC;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)416808962;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = enumerator.Current;
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_2[sectionExchange.Key];
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2 = sectionExchange.GetEnumerator();
								num = (short)1829765121;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_133:
							num = (short)1742667780;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_FA:
							goto IL_133;
							IL_2C4:
							num = (short)812122115;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2DC:;
					}
					finally
					{
						num = (short)891748352;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_311;
								}
								continue;
							case 1:
								goto IL_347;
							case 2:
								enumerator.Dispose();
								num = (short)23592961;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_311:
							if (enumerator == null)
							{
								break;
							}
							num = (short)938409986;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_347:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0002B52C File Offset: 0x0002972C
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout A_1, long A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 > 0)
					{
						num3 = (short)840237057;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_AD;
				case 1:
				{
					num3 = (short)1399586817;
					if (num3 != 0)
					{
					}
					this.a(A_0.Logger, A_0.Writer.BaseStream.Position, num2, 0);
					num3 = (short)615120896;
					short num4 = num3;
					num3 = (short)1968308226;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					goto IL_AD;
				case 3:
					goto IL_1D5;
				case 4:
				{
					int num5;
					if (num5 >= num2)
					{
						goto IL_1BE;
					}
					A_0.Writer.Write(0);
					num5++;
					num3 = (short)977797126;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 5:
					goto IL_19F;
				case 6:
					goto IL_19F;
				}
				goto IL_2C;
				IL_AD:
				num3 = (short)508667164;
				short num6 = num3;
				num3 = (short)1068868892;
				switch ((num6 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1BE:
					num3 = (short)962985987;
					num = (int)((global::System.IntPtr)num3);
					continue;
				default:
				{
					num3 = (short)1970601984;
					if (num3 != 0)
					{
					}
					int num5 = 0;
					num3 = (short)544669701;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				IL_19F:
				num3 = (short)52690948;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_1D5:
			return A_0.Writer.BaseStream.Position;
			IL_2C:
			num2 = A_1.c();
			A_0.Writer.BaseStream.Position = A_2 + (long)A_1.Size - (long)num2;
			num3 = (short)2028732416;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0002B720 File Offset: 0x00029920
		private global::Motorola.Acp.PackUnpack.Ish.ItemStructureType d(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)494796801;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.ItemStructureType result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					result = global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.Composite;
					num = (short)1833107458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 2:
					goto IL_B6;
				case 3:
					goto IL_7D;
				case 4:
					result = global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader;
					num = (short)762707976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListListlet;
					num = (short)668663811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (A_0 is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num = (short)127860741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BB;
				case 7:
				{
					if (!(A_0 is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType))
					{
						num = (short)42205190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1623974921;
					short num3 = num;
					num = (short)1015211017;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num = (short)1272053760;
						short num4 = num;
						num = (short)147783681;
						if (num != 0)
						{
						}
						num = (short)1362362368;
						if (num != 0)
						{
						}
						num = (short)1126367236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
					goto IL_98;
				}
				IL_48:
				if (A_0 is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
				{
					num = (short)1625423872;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1413677063;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7D:
			IL_98:
			IL_B6:
			return result;
			IL_BB:
			throw new global::System.InvalidCastException();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0002B908 File Offset: 0x00029B08
		private int b(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout A_0)
		{
			short num = (short)885850112;
			short num2 = num;
			num = (short)605116235;
			short num3 = num;
			num = (short)27481931;
			switch (num3 == num)
			{
			}
			num = (short)62193665;
			if (num != 0)
			{
			}
			num = (short)1013448704;
			if (num != 0)
			{
			}
			return 6 + this.a(A_0);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0002B9BC File Offset: 0x00029BBC
		private int a(global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout A_0)
		{
			short num = (short)166723584;
			short num2 = num;
			num = (short)1527613919;
			short num3 = num;
			num = (short)1575913951;
			switch (num3 == num)
			{
			}
			num = (short)252968961;
			if (num != 0)
			{
			}
			num = (short)452329472;
			if (num != 0)
			{
			}
			return 1 + A_0.DataAreaLayout.Size + 2;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0002BA74 File Offset: 0x00029C74
		private int b(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2)
		{
			short num = (short)427819008;
			short num2 = num;
			num = (short)305003751;
			short num3 = num;
			num = (short)168819943;
			switch (num3 == num)
			{
			}
			num = (short)1588658177;
			if (num != 0)
			{
			}
			num = (short)561446912;
			if (num != 0)
			{
			}
			return 6 + this.a(A_0, A_1, A_2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0002BB2C File Offset: 0x00029D2C
		private int a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2)
		{
			short num = (short)1107929771;
			short num2 = num;
			num = (short)813214379;
			int num4;
			int num5;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_81:
				if (A_0 == global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader)
				{
					num = (short)1109983232;
					short num3 = num;
					num = (short)1818558467;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num5 += 6;
					num = (short)1605566465;
					num4 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)1637482496;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num4)
				{
				case 0:
					goto IL_81;
				case 1:
					goto IL_109;
				case 2:
					goto IL_130;
				case 3:
					num = (short)713818113;
					if (num != 0)
					{
					}
					num5 += 18 + A_1.HeaderDataAreaSize;
					num = (short)1606680578;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6B;
			}
			IL_109:
			IL_130:
			return num5 + A_1.ListEntrySize * A_2;
			IL_6B:
			num5 = 3;
			num = (short)442564608;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0002BC78 File Offset: 0x00029E78
		private string b(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_0)
		{
			short num = (short)1434320896;
			short num2 = num;
			num = (short)1803649903;
			short num3 = num;
			num = (short)1479639919;
			switch (num3 == num)
			{
			}
			num = (short)196608;
			if (num != 0)
			{
			}
			num = (short)1363410945;
			if (num != 0)
			{
			}
			return global::System.Enum.GetName(typeof(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType), A_0);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0002BD34 File Offset: 0x00029F34
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, string A_1, global::Motorola.Acp.PackUnpack.Ish.IshType A_2, int A_3, int A_4)
		{
			short num = (short)973144064;
			short num2 = num;
			num = (short)1791524511;
			short num3 = num;
			num = (short)1593802399;
			switch (num3 == num)
			{
			}
			num = (short)2059993089;
			if (num != 0)
			{
			}
			num = (short)1347878912;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, A_2.Value, A_3, A_4, this.d(A_2));
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0002BDF4 File Offset: 0x00029FF4
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, string A_1, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_2, int A_3, global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_4)
		{
			short num = (short)485425152;
			short num2 = num;
			num = (short)1110952512;
			short num3 = num;
			num = (short)1332857408;
			switch (num3 == num)
			{
			}
			num = (short)1639448577;
			if (num != 0)
			{
			}
			num = (short)1820459008;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, A_2.Type, A_2.Id, A_3, A_4);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, string A_1, int A_2, int A_3, int A_4, global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_5)
		{
			int a_ = 18;
			short num = (short)1187250176;
			short num2 = num;
			num = (short)62021387;
			short num3 = num;
			num = (short)1729191691;
			switch (num3 == num)
			{
			}
			num = (short)113836032;
			if (num != 0)
			{
			}
			num = (short)293535745;
			if (num != 0)
			{
			}
			this.j = A_0.Writer.BaseStream.Position;
			this.b(A_0.Logger, A_1, A_0.Writer.BaseStream.Position, 6 + A_4);
			this.b(A_0.Logger, A_0.Writer.BaseStream.Position, 6);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﶨ튪\uddac쪮", a_), A_0.Writer.BaseStream.Position, (ushort)A_2);
			A_0.Writer.Write((ushort)A_2);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾪", a_), A_0.Writer.BaseStream.Position, (ushort)A_3);
			A_0.Writer.Write((ushort)A_3);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("直슪힬쪮", a_), A_0.Writer.BaseStream.Position, (ushort)A_4);
			A_0.Writer.Write((ushort)A_4);
			this.f(A_0.Logger);
			this.a(A_0.Logger, A_0.Writer.BaseStream.Position, A_4);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udfaa좬슮醰솴얶첸\ud8ba즼쪾돀ꛂ軆ꟈ꿊꓌곎냐꟒뫔ꗖ", a_), A_0.Writer.BaseStream.Position, (byte)A_5);
			A_0.Writer.Write((byte)A_5);
			this.a(A_0.Logger, this.b(A_5), A_0.Writer.BaseStream.Position, A_4 - 1, this.a(A_5));
			return A_0.Writer.BaseStream.Position;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0002C124 File Offset: 0x0002A324
		private void a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0)
		{
			int a_ = 11;
			short num = (short)600113152;
			short num2 = num;
			num = (short)2046951425;
			if (num != 0)
			{
			}
			num = (short)2119923865;
			short num3 = num;
			num = (short)1392933017;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1654652928;
				if (num != 0)
				{
				}
				this.a(A_0.Logger);
				int num4 = (int)(A_0.Writer.BaseStream.Position - (this.j + 6L));
				A_0.Writer.BaseStream.Position = this.j + 6L;
				ushort num5 = (ushort)this.a.Compute((global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream)A_0.Writer.BaseStream, num4);
				this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("", a_), A_0.Writer.BaseStream.Position, num5);
				A_0.Writer.Write(num5);
				this.d(A_0.Logger);
				this.e(A_0.Logger);
				long position = A_0.Writer.BaseStream.Position;
				long position2 = this.j + 4L;
				A_0.Writer.BaseStream.Position = position2;
				int num6 = (int)A_0.Reader.ReadUInt16();
				num4 += 2;
				if (num4 == num6)
				{
					A_0.Writer.BaseStream.Position = position2;
					A_0.Writer.Write((ushort)num4);
					A_0.Writer.BaseStream.Position = position;
					A_0.Writer.BaseStream.SetLength(A_0.Writer.BaseStream.Position);
					return;
				}
				break;
			}
			}
			throw new global::System.IO.InvalidDataException();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002C324 File Offset: 0x0002A524
		private void b(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			short num = (short)115605504;
			short num2 = num;
			num = (short)716867083;
			short num3 = num;
			num = (short)747275787;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
			global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider;
			long a_;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)506593281;
				if (num != 0)
				{
				}
				num = (short)66912256;
				if (num != 0)
				{
				}
				num = (short)1481048064;
				switch (num)
				{
				default:
				{
					compositeLayout = this.a(A_0);
					partitionIOProvider = this.c(A_0);
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a = A_1[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite];
					a_ = this.a(partitionIOProvider, A_0.Name, A_0, 0, this.a(compositeLayout));
					this.d(partitionIOProvider.Logger, partitionIOProvider.Writer.BaseStream.Position);
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = a.GetEnumerator();
					try
					{
						num = (short)1737818112;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_146;
								}
								continue;
							case 1:
								try
								{
									num = (short)1245708288;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator3;
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1FD;
											}
											continue;
										case 1:
											if (!enumerator2.MoveNext())
											{
												num = (short)824180740;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_391;
										case 2:
											try
											{
												num = (short)2116550656;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num4)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_274;
														}
														continue;
													case 1:
													{
														if (!enumerator3.MoveNext())
														{
															num = (short)626655236;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator3.Current;
														global::AcpCommonLib.IAcpField acpField = acpFeatureSection[fieldExchange.PropertyName];
														object fieldValue = this.GetFieldValue(acpField, fieldExchange);
														this.a(partitionIOProvider, fieldExchange.Layout, a_, fieldValue);
														this.a(acpField);
														num = (short)69074946;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 3:
														goto IL_31F;
													case 4:
														num = (short)1674838019;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													IL_276:
													num = (short)1453785089;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_274:
													goto IL_276;
												}
												IL_31F:
												break;
											}
											finally
											{
												num = (short)680132608;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num4)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_356;
														}
														continue;
													case 1:
														goto IL_38E;
													case 2:
														enumerator3.Dispose();
														num = (short)1385234433;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													IL_356:
													if (enumerator3 == null)
													{
														break;
													}
													num = (short)1738932226;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_38E:;
											}
											goto IL_391;
										case 3:
											goto IL_3E8;
										case 4:
											num = (short)274923523;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1FF:
										num = (short)1795227649;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_1FD:
										goto IL_1FF;
										IL_391:
										global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = enumerator2.Current;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										acpFeatureSection = acpFeatureNode[sectionExchange.Key];
										enumerator3 = sectionExchange.GetEnumerator();
										num = (short)951320578;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_3E8:
									break;
								}
								finally
								{
									num = (short)1878458368;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2;
										switch (num4)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_41F;
											}
											continue;
										case 1:
											goto IL_458;
										case 2:
											enumerator2.Dispose();
											num = (short)2072444929;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_41F:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)484114434;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_458:;
								}
								goto IL_45B;
							case 2:
								goto IL_45B;
							case 3:
								goto IL_474;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)435879938;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = enumerator.Current;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key)[0];
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2 = recsetExchange.GetEnumerator();
								num = (short)1604321281;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_183:
							num = (short)560005124;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_146:
							goto IL_183;
							IL_45B:
							num = (short)1581645827;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_474:;
					}
					finally
					{
						num = (short)1076101120;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_4A8;
								}
								continue;
							case 1:
								goto IL_4E0;
							case 2:
								enumerator.Dispose();
								num = (short)2129723393;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_4A8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2038497282;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_4E0:;
					}
					break;
				}
				}
				break;
			}
			this.a(partitionIOProvider, compositeLayout.DataAreaLayout, a_);
			this.i(partitionIOProvider.Logger);
			this.a(partitionIOProvider);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0002C884 File Offset: 0x0002AA84
		private void a(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			short num = (short)1518403584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout;
				int num5;
				global::AcpCommonLib.IAcpRecordset feature;
				int num6;
				int a_2;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1416429568;
						short num3 = num;
						goto IL_196;
					}
					case 2:
					{
						long a_;
						try
						{
							num = (short)241238017;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								switch (num2)
								{
								case 0:
									goto IL_407;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_212;
									}
									continue;
								case 2:
									num = (short)1050869760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1013383170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3AD;
								case 4:
									try
									{
										num = (short)1273757697;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_33A;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_28A;
												}
												continue;
											case 2:
												num = (short)1703936;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)1505820674;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator2.Current;
												global::AcpCommonLib.IAcpField acpField = acpFeatureSection[fieldExchange.PropertyName];
												object fieldValue = this.GetFieldValue(acpField, fieldExchange);
												this.a(partitionIOProvider, fieldExchange.Layout, a_, fieldValue);
												this.a(acpField);
												num = (short)896663556;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_28C:
											num = (short)1381302275;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_28A:
											goto IL_28C;
										}
										IL_33A:
										break;
									}
									finally
									{
										num = (short)1448017921;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)954400770;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_372;
												}
												continue;
											case 2:
												goto IL_3AA;
											}
											IL_372:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)16318464;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3AA:;
									}
									goto IL_3AD;
								}
								IL_214:
								num = (short)526974979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_212:
								goto IL_214;
								IL_3AD:
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange = enumerator.Current;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								acpFeatureSection = acpFeatureNode[sectionExchange.Key];
								enumerator2 = sectionExchange.GetEnumerator();
								num = (short)1384644612;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_407:
							goto IL_F3;
						}
						finally
						{
							num = (short)1387986945;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)490733570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1146248153;
									short num4 = num;
									num = (short)1443978201;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_48E;
									default:
										num = (short)1712259072;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_48A;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_4C1;
								}
								goto IL_48A;
								IL_48E:
								num = (short)1072168960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48A:
								if (enumerator != null)
								{
									goto IL_48E;
								}
								break;
							}
							IL_4C1:;
						}
						return;
						IL_F3:
						this.a(partitionIOProvider, compositeLayout.DataAreaLayout, a_);
						this.i(partitionIOProvider.Logger);
						this.a(partitionIOProvider);
						num5++;
						num = (short)1084817411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_196;
					case 4:
					{
						if (num5 >= feature.Count)
						{
							num = (short)249364480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[num5];
						long a_ = this.a(partitionIOProvider, A_0.Name, A_0, num6 + num5, a_2);
						this.d(partitionIOProvider.Logger, partitionIOProvider.Writer.BaseStream.Position);
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = recsetExchange.GetEnumerator();
						num = (short)826540034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_43;
					IL_196:
					num = (short)725549060;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				num = (short)1589182465;
				if (num != 0)
				{
				}
				compositeLayout = this.a(A_0);
				partitionIOProvider = this.c(A_0);
				recsetExchange = this.d(A_1);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
				num6 = A_0.Partition.IdTracker.c(A_0);
				a_2 = this.a(compositeLayout);
				num5 = 0;
				num = (short)1654784001;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0002CD8C File Offset: 0x0002AF8C
		private void b(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			int a_ = 8;
			short num = (short)926875648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange2;
				global::AcpCommonLib.IAcpFeatureNode a_2;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (recsetExchange == null)
						{
							num = (short)479395847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1;
					case 1:
						if (recsetExchange2 != null)
						{
							num = (short)1859059714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_2 = null;
						num = (short)1483407371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						a_2 = this.a(recsetExchange2, 0)[0];
						num = (short)1832517641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (listLayout.HeaderDataAreaLayout != null)
						{
							num = (short)1611202573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B2;
					case 4:
						goto IL_1CF;
					case 5:
						if (listLayout.HeaderDataAreaLayout.FieldLayouts.Count > 0)
						{
							num = (short)836042756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B2;
					case 6:
						num = (short)1039335427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)85852172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_136;
					case 9:
						goto IL_226;
					case 10:
						if (recsetExchange2 == null)
						{
							num = (short)96075782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B2;
					case 11:
						goto IL_2B0;
					case 12:
						if (listLayout.ListCapacity > 0)
						{
							goto IL_11E;
						}
						goto IL_C1;
					case 13:
					{
						num = (short)1678127997;
						short num3 = num;
						num = (short)297546621;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11E;
						default:
							num = (short)2122973184;
							if (num != 0)
							{
							}
							num = (short)1212284933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_70;
					IL_C1:
					num = (short)218038273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E:
					num = (short)346226696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B2:
					num = (short)1872363520;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_136:
				throw new global::System.InvalidOperationException();
				IL_1CF:
				num = (short)999030784;
				short num4 = num;
				throw new global::System.InvalidOperationException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\uda9e펠톢쪤햦覨\udbaa첬첮\udab0\udab2\udbb4킶馸럂별럆곈뛌ￎ곐﷔곖ꛚ쇠", a_));
				IL_226:
				num = (short)1882980353;
				if (num != 0)
				{
				}
				IL_2B0:
				global::AcpCommonLib.IAcpRecordset a_3 = this.a(recsetExchange, 0);
				int a_4 = A_0.Partition.IdTracker.c(A_0);
				this.b(listLayout, a_4, a_2, recsetExchange2, a_3, recsetExchange);
				return;
				IL_70:
				listLayout = this.a(A_0);
				recsetExchange2 = this.c(A_1);
				recsetExchange = this.b(A_1);
				num = (short)434896906;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		private void a(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			int a_ = 0;
			short num = (short)2147221504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange2;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout listLayout;
				for (;;)
				{
					IL_32:
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					int id;
					int num4;
					int num5;
					global::AcpCommonLib.IAcpFeatureNode a_2;
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					switch (num2)
					{
					case 0:
						num = (short)499777537;
						if (num != 0)
						{
						}
						acpFeatureNode = acpFeatureNode2;
						goto IL_5A6;
					case 1:
						goto IL_2CF;
					case 2:
						if (recsetExchange == null)
						{
							num = (short)591724573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1911357440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_149;
					case 4:
					{
						if (recsetExchange2.Parent != null)
						{
							num = (short)1239613440;
							short num3 = num;
							num = (short)548470814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange2.Key);
						id = this.a(recsetExchange2).Key;
						num = (short)1858928641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)570425350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (listLayout.HeaderDataAreaLayout.FieldLayouts.Count > 0)
						{
							num = (short)1253376010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					case 7:
						goto IL_422;
					case 8:
						if (listLayout.HeaderDataAreaLayout != null)
						{
							num = (short)1562902533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					case 9:
						return;
					case 10:
						goto IL_420;
					case 11:
						goto IL_144;
					case 12:
						goto IL_422;
					case 13:
						goto IL_466;
					case 14:
						goto IL_2CF;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (acpRecordset.Count > listLayout.ListCapacity)
						{
							num = (short)157548567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b(listLayout, num4 + num5, a_2, recsetExchange, acpRecordset, recsetExchange2);
						num5++;
						num = (short)1401552903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1629028373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset = acpFeatureSection.EmbeddedRecset;
						num = (short)323420163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						if (recsetExchange2.Parent != null)
						{
							num = (short)1981677585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset acpRecordset = this.a(recsetExchange2, num5);
						num = (short)23461913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (num5 >= feature.Count)
						{
							num = (short)1704722441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode2 = feature[num5];
						num = (short)2133524482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
						num = (short)1414266893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (listLayout.ListCapacity > 0)
						{
							num = (short)1314258955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 22:
						if (recsetExchange != null)
						{
							num = (short)1364197396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_466;
					case 23:
						goto IL_18E;
					case 24:
						if (recsetExchange == null)
						{
							num = (short)122552347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					case 25:
						goto IL_149;
					case 26:
						if (recsetExchange2 == null)
						{
							num = (short)1673658384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 27:
					{
						num = (short)1640854160;
						short num6 = num;
						num = (short)1276474000;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)248315904;
							if (num != 0)
							{
							}
							num = (short)877592584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 28:
						acpFeatureNode = null;
						goto IL_5A6;
					case 29:
						num = (short)335544348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange2.Parent.Parent.Key);
						id = recsetExchange2.Parent.Key;
						num = (short)714801166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_B5;
					IL_149:
					num = (short)372965391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193:
					num = (short)230555670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF:
					num4 = A_0.Partition.IdTracker.c(A_0);
					num5 = 0;
					num = (short)1771634700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_422:
					num = (short)1102184467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_466:
					num = (short)1138622468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					num = (short)1137901594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A6:
					a_2 = acpFeatureNode;
					acpFeatureSection = acpFeatureNode2[id];
					num = (short)1174208530;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_144:
				throw new global::System.InvalidOperationException();
				IL_18E:
				throw new global::System.InvalidOperationException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udb96뾞슠슢햤욦쪨슪\ud9ac횮醰횲춴풶\udcb8\udeba\ud9bc\udabeꗀ", a_));
				IL_420:
				throw new global::System.InvalidOperationException();
				IL_B5:
				listLayout = this.a(A_0);
				recsetExchange = this.c(A_1);
				recsetExchange2 = this.b(A_1);
				num = (short)1468268568;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0002D6CC File Offset: 0x0002B8CC
		private global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider c(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)1995425443;
			short num2 = num;
			num = (short)2111620771;
			switch (num2 == num)
			{
			}
			num = (short)867303425;
			if (num != 0)
			{
			}
			num = (short)2071855104;
			if (num != 0)
			{
			}
			num = (short)1213136896;
			short num3 = num;
			return this.q[A_0.Partition.PartitionType];
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0002D78C File Offset: 0x0002B98C
		private int b(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 8;
			short num = (short)1794637825;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F7;
				case 1:
				{
					num = (short)1843869133;
					short num3 = num;
					num = (short)142751181;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DA;
					case 1:
						break;
					default:
					{
						num = (short)500301824;
						short num4 = num;
						break;
					}
					}
					num = (short)1382612993;
					if (num != 0)
					{
					}
					num = (short)1053425664;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_DA;
					}
					continue;
				}
				case 2:
					goto IL_120;
				}
				IL_DA:
				if (A_0.Partition != null)
				{
					num = (short)304152576;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)318439426;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F7:
			return A_0.Partition.IdTracker.c(A_0);
			IL_120:
			global::Motorola.Acp.PackUnpack.Ish.IshType ishType = this.t.a(A_0.Value);
			if (ishType == null)
			{
				throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.IshTypeNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪞쾠슢잤쮦첨讪\ud9ac삮醰햲\udcb4\ud9b6\uddb8鮺觀뇄뻆마껊ꛎ뿐ꃒꇔ뛖럘룚룜￞蟠賢韤쟦鷨鋪鷬諮퇰藲铴鯶賸黺\uddfc蓾㄀縂", a_), A_0.Value));
			}
			return ishType.Partition.IdTracker.c(A_0);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002D904 File Offset: 0x0002BB04
		private global::Motorola.Acp.PackUnpack.Ish.IshType a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)162249662;
			short num2 = num;
			num = (short)1830599614;
			switch (num2 == num)
			{
			}
			num = (short)1087963136;
			short num3 = num;
			num = (short)2076508160;
			if (num != 0)
			{
			}
			num = (short)72089601;
			if (num != 0)
			{
			}
			return this.b.ChildToParentRelationships[A_0.Value];
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_1)
		{
			short num = (short)737869824;
			switch (num)
			{
			default:
			{
				num = (short)50921472;
				short num2 = num;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = null;
				global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)403832832;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_9B;
							}
							continue;
						case 1:
							goto IL_334;
						case 2:
							try
							{
								num = (short)1987969027;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)570149131;
									short num4 = num;
									num = (short)237095179;
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1379860480;
										if (num != 0)
										{
										}
										switch (num3)
										{
										case 0:
											if (!enumerator2.MoveNext())
											{
												num = (short)1604190214;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_131;
										case 1:
											if (fieldExchange2.Layout == A_1)
											{
												num = (short)1905917956;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 2:
											goto IL_1CB;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_12F;
											}
											continue;
										case 4:
											fieldExchange = fieldExchange2;
											num = (short)1250689026;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											goto IL_1E9;
										case 6:
											num = (short)1048838149;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_173:
										num = (short)587137024;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_12F:
										goto IL_173;
									}
									IL_131:
									fieldExchange2 = enumerator2.Current;
									num = (short)2115371009;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1CB:
								IL_1E9:
								goto IL_2E1;
							}
							finally
							{
								num = (short)1174732800;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_222;
										}
										continue;
									case 1:
										goto IL_258;
									case 2:
										enumerator2.Dispose();
										num = (short)1505558529;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_222:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1931149314;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_258:;
							}
							break;
							IL_2E1:
							num = (short)21823494;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1379336199;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1004142597;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator2 = enumerator.Current.GetEnumerator();
							num = (short)1670774786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1255931905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (fieldExchange != null)
							{
								num = (short)1167196163;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							goto IL_2DC;
						}
						IL_25B:
						num = (short)781385732;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9B:
						goto IL_25B;
					}
					IL_2DC:
					IL_334:;
				}
				finally
				{
					num = (short)1297350656;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_368;
							}
							continue;
						case 1:
							goto IL_39D;
						case 2:
							enumerator.Dispose();
							num = (short)1928855553;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_368:
						if (enumerator == null)
						{
							break;
						}
						num = (short)89784322;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_39D:;
				}
				num = (short)1782317057;
				if (num != 0)
				{
				}
				return fieldExchange;
			}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		private global::AcpCommonLib.IAcpField a(global::AcpCommonLib.IAcpFeatureNode A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange A_1)
		{
			short num = (short)1186073582;
			short num2 = num;
			num = (short)237505518;
			switch (num2 == num)
			{
			}
			num = (short)976093184;
			short num3 = num;
			num = (short)1299709953;
			if (num != 0)
			{
			}
			num = (short)809435136;
			if (num != 0)
			{
			}
			return A_0[A_1.Parent.Key][A_1.PropertyName];
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0002DE88 File Offset: 0x0002C088
		internal long IshItemBeginPosition
		{
			get
			{
				short num = (short)1831052465;
				short num2 = num;
				num = (short)1643881649;
				switch (num2 == num)
				{
				}
				num = (short)885587968;
				short num3 = num;
				num = (short)1556742145;
				if (num != 0)
				{
				}
				num = (short)757530624;
				if (num != 0)
				{
				}
				return this.j;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0002DF38 File Offset: 0x0002C138
		private void a(global::Motorola.Acp.PackUnpack.Ish.Packer.a A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			short num;
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list;
			for (;;)
			{
				num = (short)194117632;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						goto IL_AD;
					case 2:
						list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b>();
						this.v[A_0] = list;
						num = (short)1557331969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)1207238657;
					if (num != 0)
					{
					}
					if (this.v.TryGetValue(A_0, out list))
					{
						goto IL_123;
					}
					num = (short)1342570498;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AD:
				num = (short)1338222935;
				short num3 = num;
				num = (short)564046167;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_10C;
				}
				break;
			}
			num = (short)1457586176;
			short num4 = num;
			IL_10C:
			num = (short)1142816768;
			if (num != 0)
			{
			}
			IL_123:
			list.Add(A_1);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0002E070 File Offset: 0x0002C270
		private void h()
		{
			short num = (short)1176495838;
			short num2 = num;
			num = (short)1244063454;
			switch (num2 == num)
			{
			}
			num = (short)1969094656;
			short num3 = num;
			num = (short)2055077888;
			if (num != 0)
			{
			}
			num = (short)1292566529;
			if (num != 0)
			{
			}
			this.b();
			this.g();
			this.f();
			this.e();
			this.d();
			global::Motorola.Acp.PackUnpack.Ish.IshItemName a_;
			global::Motorola.Acp.PackUnpack.Ish.IshItemName a_2;
			this.a(out a_, out a_2);
			this.a(a_, a_2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0002E148 File Offset: 0x0002C348
		private void g()
		{
			short num = (short)892796929;
			if (num != 0)
			{
			}
			num = (short)1667956736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A0;
				}
				int num3;
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list;
				for (;;)
				{
					IL_4D:
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange3;
					int num6;
					global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange4;
					int num7;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= list.Count)
						{
							num = (short)44695565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)452810119;
						short num4 = num;
						num = (short)1983468935;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_419;
						default:
						{
							num = (short)1019674624;
							if (num != 0)
							{
							}
							global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)list[num3].a();
							global::Motorola.Acp.PackUnpack.Ish.Layouts.UclHotListLayout uclHotListLayout = (global::Motorola.Acp.PackUnpack.Ish.Layouts.UclHotListLayout)this.a(listHeaderType);
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.b.IshTypeExchanges[listHeaderType];
							recsetExchange = this.a(b[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry]);
							sectionExchange = this.a(recsetExchange);
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_ = sectionExchange.RecsetExchange;
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2 = this.a(a_);
							global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> enumerator = sectionExchange2.GetEnumerator();
							enumerator.MoveNext();
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = enumerator.Current;
							enumerator.MoveNext();
							global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2 = enumerator.Current;
							num = (short)129957893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_1B8;
					case 2:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange2;
						fieldExchange3 = fieldExchange2;
						goto IL_270;
					}
					case 3:
						goto IL_2E5;
					case 4:
						num3++;
						num = (short)1635909633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
						if (!(fieldExchange.Layout is global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout))
						{
							num = (short)106758156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1530134543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1148977152;
						short num5 = num;
						goto IL_173;
					}
					case 7:
						goto IL_1B8;
					case 8:
						goto IL_173;
					case 9:
					{
						if (num6 >= acpFeatureSection.EmbeddedRecset.Count)
						{
							num = (short)325189648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange2;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)((global::AcpBusinessLayer.FeatureNode)acpFeatureSection.EmbeddedRecset[num6])[sectionExchange2.Key][fieldExchange4.PropertyName];
						num = (short)1682964494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_2A0;
					case 11:
						goto IL_2A0;
					case 12:
						num = (short)1203634178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return;
					case 14:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField.ReferencedNode != null)
						{
							num = (short)556728338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					}
					case 15:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
						fieldExchange3 = fieldExchange;
						goto IL_270;
					}
					case 16:
						num7++;
						num = (short)298188810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num7 >= feature.Count)
						{
							num = (short)654966788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 18:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						this.a(acpRecRefField);
						num = (short)971571203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A0;
					IL_173:
					num = (short)133038089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)2162688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_270:
					fieldExchange4 = fieldExchange3;
					feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
					num7 = 0;
					num = (short)592773131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A0:
					num = (short)1402994705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					num6++;
					num = (short)2035744776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					acpFeatureSection = ((global::AcpBusinessLayer.FeatureNode)feature[num7])[sectionExchange.Key];
					num6 = 0;
					num = (short)5373958;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A0:
				list = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.e];
				num3 = 0;
				num = (short)808058887;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4D;
			}
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		private void f()
		{
			short num = (short)1727594496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list;
				for (;;)
				{
					IL_28:
					global::Motorola.Acp.PackUnpack.Ish.IshItemName item;
					global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType;
					int num3;
					global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType2;
					int num6;
					int num7;
					switch (num2)
					{
					case 0:
						item = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(listHeaderType.Value, num3++);
						num = (short)1056702468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_18D;
					case 2:
					{
						num = (short)1919221760;
						short num4 = num;
						listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)list[0].a();
						listHeaderType2 = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)list[1].a();
						num = (short)838795275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (((global::Motorola.Acp.PackUnpack.Ish.Layouts.UclContactListLayout)this.i(list[0].a())).HasReferencedTypes)
						{
							num = (short)1317797890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)list[1].a();
						listHeaderType2 = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)list[0].a();
						num = (short)1330970633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_240;
					case 5:
						return;
					case 6:
					{
						num = (short)502586790;
						short num5 = num;
						num = (short)458677670;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26D;
						default:
							num = (short)594345984;
							if (num != 0)
							{
							}
							if (this.r[num6])
							{
								num = (short)533397504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							item = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(listHeaderType2.Value, num7++);
							num = (short)2130706440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						if (num6 >= this.r.Count)
						{
							num = (short)1464926213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)727121926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)75497473;
						if (num != 0)
						{
						}
						goto IL_240;
					case 9:
						goto IL_305;
					case 10:
						goto IL_26D;
					case 11:
						goto IL_305;
					}
					goto IL_5F;
					IL_18D:
					num = (short)1347616775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26D:
					goto IL_18D;
					IL_240:
					this.s.Add(item);
					num6++;
					num = (short)717881354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					num3 = this.b(listHeaderType);
					num7 = this.b(listHeaderType2);
					num6 = 0;
					num = (short)868941825;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5F:
				list = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.c];
				num = (short)1238827011;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002E918 File Offset: 0x0002CB18
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_1)
		{
			short num = (short)747044865;
			if (num != 0)
			{
			}
			num = (short)1519241296;
			short num2 = num;
			num = (short)1180026960;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2040463360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)317259776;
			if (num != 0)
			{
			}
			return default(global::Motorola.Acp.PackUnpack.Ish.IshItemName);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002E9CC File Offset: 0x0002CBCC
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName d(int A_0)
		{
			short num = (short)725110709;
			short num2 = num;
			num = (short)1613975477;
			switch (num2 == num)
			{
			}
			num = (short)382402560;
			short num3 = num;
			num = (short)112918528;
			if (num != 0)
			{
			}
			num = (short)1971912705;
			if (num != 0)
			{
			}
			return this.s[A_0];
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0002EA80 File Offset: 0x0002CC80
		private int c(int A_0)
		{
			short num = (short)604307457;
			if (num != 0)
			{
			}
			num = (short)141754872;
			short num2 = num;
			num = (short)1171522040;
			switch (num2 == num)
			{
			default:
			{
				num = (short)941490176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)275316736;
			if (num != 0)
			{
			}
			return this.s[A_0].Id;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0002EB40 File Offset: 0x0002CD40
		private int b(global::AcpBusinessLayer.AcpRecRefField A_0)
		{
			short num = (short)1880948737;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)671023104;
					short num3 = num;
					acpFeatureNode = A_0.ReferencedNode;
					num = (short)1037172738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1140195329;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					goto IL_13C;
				case 3:
					goto IL_F3;
				}
				IL_5A:
				num = (short)615609423;
				short num4 = num;
				num = (short)478180431;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F3;
				default:
					num = (short)1753939968;
					if (num != 0)
					{
					}
					if (A_0.ReferencedNode.Parent == null)
					{
						num = (short)797376512;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						acpFeatureNode = A_0.ReferencedNode.Parent.ParentSection.Parent;
						num = (short)1124139011;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_F3:
			IL_13C:
			return acpFeatureNode.Parent.IndexOf(acpFeatureNode);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0002EC98 File Offset: 0x0002CE98
		private void e()
		{
			short num = (short)610598913;
			if (num != 0)
			{
			}
			num = (short)2028382393;
			short num2 = num;
			num = (short)805480633;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)73728000;
				short num3 = num;
				break;
			}
			}
			num = (short)1359020032;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b>.Enumerator enumerator = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.e].GetEnumerator())
			{
				num = (short)722141185;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1267859460;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = enumerator.Current;
						this.a((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)b.a(), b);
						num = (short)2065629186;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						continue;
					case 3:
						goto IL_162;
					case 4:
						num = (short)1516437507;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_117:
					num = (short)1498415104;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E5:
					goto IL_117;
				}
				IL_162:;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0002EE28 File Offset: 0x0002D028
		private void d()
		{
			short num = (short)1581449217;
			if (num != 0)
			{
			}
			num = (short)754336003;
			short num2 = num;
			num = (short)1196310787;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1630470144;
				short num3 = num;
				break;
			}
			}
			num = (short)1063649280;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b>.Enumerator enumerator = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.d].GetEnumerator())
			{
				num = (short)1739456513;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2050949124;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = enumerator.Current;
						this.b((global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)b.a(), b);
						num = (short)573636610;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E4;
						}
						continue;
					case 3:
						goto IL_163;
					case 4:
						num = (short)12320771;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_116:
					num = (short)705888256;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E4:
					goto IL_116;
				}
				IL_163:;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.b c()
		{
			short num = (short)398326470;
			short num2 = num;
			num = (short)1606548166;
			switch (num2 == num)
			{
			}
			num = (short)1151008768;
			short num3 = num;
			num = (short)1419378688;
			if (num != 0)
			{
			}
			num = (short)926810113;
			if (num != 0)
			{
			}
			return this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.b][0];
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0002F078 File Offset: 0x0002D278
		private void a(out global::Motorola.Acp.PackUnpack.Ish.IshItemName A_0, out global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1)
		{
			short num = (short)135593984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::AcpBusinessLayer.Recordset recordset;
				global::Motorola.Acp.PackUnpack.Ish.IshItemName ishItemName;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (recordset.TemplateNode != null)
						{
							num = (short)892665861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E;
					case 1:
						goto IL_1CF;
					case 2:
					{
						int num3;
						if (num3 >= recordset.Count)
						{
							num = (short)1543110664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ishItemName = this.a(recordset, num3, ishItemName);
						num3++;
						num = (short)1320615939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_EA;
					case 4:
						goto IL_247;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(false);
						global::Motorola.Acp.PackUnpack.Ish.ListHeaderType listHeaderType = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)b.a();
						global::Motorola.Acp.PackUnpack.Ish.IshItemName a_ = new global::Motorola.Acp.PackUnpack.Ish.IshItemName(listHeaderType.Value, 0);
						this.a(recordset.TemplateNode, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null, a_, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null, listHeaderType, b);
						num = (short)1046806534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)538867172;
						short num4 = num;
						num = (short)629765604;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EA;
						default:
							num = (short)126287872;
							if (num != 0)
							{
							}
							goto IL_20E;
						}
						break;
					}
					case 7:
					{
						if (recordset.Count == 0)
						{
							num = (short)509739012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0 = this.a(recordset, 0, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null);
						ishItemName = A_0;
						int num3 = 1;
						num = (short)2144796673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_20C;
					}
					goto IL_52;
					IL_1CF:
					num = (short)2142437378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EA:
					num = (short)963510273;
					if (num != 0)
					{
					}
					goto IL_1CF;
					IL_20E:
					num = (short)1650327559;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20C:
				A_1 = ishItemName;
				return;
				IL_247:
				A_0 = global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null;
				A_1 = global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null;
				return;
				IL_52:
				recordset = (global::AcpBusinessLayer.Recordset)this.a();
				num = (short)1391591424;
				short num5 = num;
				num = (short)1909522432;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0002F314 File Offset: 0x0002D514
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(global::AcpCommonLib.IAcpRecordset A_0, int A_1, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_2)
		{
			short num = (short)692715520;
			short num2 = num;
			num = (short)1037504523;
			short num3 = num;
			num = (short)2092437515;
			switch (num3 == num)
			{
			}
			num = (short)830275585;
			if (num != 0)
			{
			}
			num = (short)1693122560;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.a(this.b(A_1));
			global::Motorola.Acp.PackUnpack.Ish.ListHeaderType a_ = (global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)b.a();
			global::Motorola.Acp.PackUnpack.Ish.IshItemName ishItemName = this.a(A_1);
			global::Motorola.Acp.PackUnpack.Ish.IshItemName a_2 = this.a(A_0, A_1);
			this.a(A_0[A_1], A_2, ishItemName, a_2, a_, b);
			return ishItemName;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0002F3FC File Offset: 0x0002D5FC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_2, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_3, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_4, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_5)
		{
			int a_ = 3;
			short num = (short)1791269632;
			short num2 = num;
			num = (short)638556928;
			global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider;
			long num3;
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType> list;
			global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>.Enumerator enumerator;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1D9:
				this.b(partitionIOProvider.Logger, num3);
				enumerator = list.GetEnumerator();
				num = (short)1470758913;
				if (num != 0)
				{
				}
				num = (short)650706947;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)703660032;
				if (num != 0)
				{
				}
				num = (short)935526400;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_96;
					}
					break;
				}
				break;
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType> enumerator2;
			global::Motorola.Acp.PackUnpack.Ish.Layouts.UclContactListLayout uclContactListLayout;
			for (;;)
			{
				IL_7B:
				switch (num4)
				{
				case 0:
				{
					try
					{
						num = (short)319356928;
						num4 = (int)((global::System.IntPtr)num);
						global::Motorola.Acp.PackUnpack.Ish.IshType ishType;
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2AA;
								}
								continue;
							case 1:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)2089811971;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								ishType = enumerator2.Current;
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a_2 = this.b.IshTypeExchanges[ishType];
								global::Motorola.Acp.PackUnpack.Ish.Layouts.UclCallIdListLayout uclCallIdListLayout = (global::Motorola.Acp.PackUnpack.Ish.Layouts.UclCallIdListLayout)this.i(ishType);
								num = (short)350683142;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_392;
							case 3:
								num = (short)395509768;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a_2;
								global::Motorola.Acp.PackUnpack.Ish.Layouts.UclCallIdListLayout uclCallIdListLayout;
								if (this.a(partitionIOProvider, A_0, uclCallIdListLayout, a_2, A_2.Id) > 0)
								{
									num = (short)1878327301;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								list.Add(ishType);
								num = (short)1644298247;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::Motorola.Acp.PackUnpack.Ish.Layouts.UclCallIdListLayout uclCallIdListLayout;
								if (uclCallIdListLayout == null)
								{
									num = (short)753598466;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1057751044;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_3FC;
							}
							IL_2AC:
							num = (short)1804599297;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_2AA:
							goto IL_2AC;
						}
						IL_392:
						throw new global::Motorola.Acp.PackUnpack.Ish.Exceptions.StructureLayoutNotFoundException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾙ﾝ슟캡솣蚥\udca7얩貫좭\ud9af\udcb1킳隵풷\udbb9얻톽떿뛁ꃅꟇ룉蟍菏髑ꋕꇗ꫙맛ﻝ鯟틡駣웥샧釩\uddeb鏭\ud9ef", a_), ishType.Value, ishType.Name));
						IL_3FC:;
					}
					finally
					{
						num = (short)466354177;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)1219690498;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_431;
								}
								continue;
							case 2:
								goto IL_46A;
							}
							IL_431:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)797966336;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_46A:;
					}
					int a_3 = this.a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader, uclContactListLayout, list.Count);
					this.a(partitionIOProvider, A_4.Name, A_2, a_3, global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader);
					long num5 = this.a(partitionIOProvider, uclContactListLayout, list.Count, list.Count, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null);
					this.c(partitionIOProvider.Logger, num5);
					this.a(partitionIOProvider, A_1, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪙ﮝ횟쮡쮣펥\udba7誩솭\udeaf욱햳햵첷骹\udfbd궿ꟁ", a_));
					this.a(partitionIOProvider, A_3, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풙鍊풟芡즥욧\udea9춫춭쒯銱荒ힵ햷\udfb9", a_));
					global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_4 = this.c(A_5);
					this.a(a_4, partitionIOProvider, A_0, num5);
					num3 = this.a(partitionIOProvider, uclContactListLayout.HeaderDataAreaLayout, num5);
					this.h(partitionIOProvider.Logger);
					num = (short)14483458;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_25A;
				case 2:
					if (list.Count > 0)
					{
						num = (short)841023492;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_585;
				case 3:
					try
					{
						num = (short)1415512064;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_116;
								}
								continue;
							case 1:
								num = (short)94830596;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1821704193;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Acp.PackUnpack.Ish.IshType ishType2 = enumerator.Current;
								this.a(partitionIOProvider.Logger, num3);
								this.a(partitionIOProvider, ishType2.Value, A_2.Id, "");
								num3 += 4L;
								this.c(partitionIOProvider.Logger);
								num = (short)484507650;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1C9;
							}
							IL_118:
							num = (short)1313472515;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_116:
							goto IL_118;
						}
						IL_1C9:
						goto IL_236;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D9;
					IL_236:
					this.g(partitionIOProvider.Logger);
					num = (short)1391132673;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_556;
				}
				goto IL_96;
			}
			IL_25A:
			goto IL_585;
			IL_556:
			num = (short)1342111744;
			short num6 = num;
			goto IL_1D9;
			IL_585:
			this.a(partitionIOProvider);
			return;
			IL_96:
			uclContactListLayout = (global::Motorola.Acp.PackUnpack.Ish.Layouts.UclContactListLayout)this.a(A_4);
			partitionIOProvider = this.c(A_4);
			list = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshType>();
			enumerator2 = uclContactListLayout.SignallingIshTypes.GetEnumerator();
			num = (short)1981808640;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0002F9CC File Offset: 0x0002DBCC
		private int a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::AcpCommonLib.IAcpFeatureNode A_1, global::Motorola.Acp.PackUnpack.Ish.Layouts.UclCallIdListLayout A_2, global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_3, int A_4)
		{
			short num = (short)1858142208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
				global::Motorola.Acp.PackUnpack.Ish.ListHeaderType headerType;
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange sectionExchange;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (acpFeatureSection.EmbeddedRecset.Count == 0)
						{
							num = (short)1060306945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)59047943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return 0;
					case 2:
						goto IL_381;
					case 3:
					{
						long num4;
						try
						{
							num = (short)1811685608;
							short num3 = num;
							num = (short)1267867880;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_23E:
								num = (short)1188298757;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1555562496;
								if (num != 0)
								{
								}
								num = (short)1543045120;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_21D;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
									if (!enumerator.MoveNext())
									{
										goto IL_23E;
									}
									global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout a_ = enumerator.Current;
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_2;
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange = this.a(a_2, a_);
									num = (short)2111569922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
									if (fieldExchange != null)
									{
										num = (short)2026373123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange fieldExchange;
									global::AcpBusinessLayer.FeatureNode a_3;
									global::AcpCommonLib.IAcpField acpField = this.a(a_3, fieldExchange);
									object fieldValue = this.GetFieldValue(acpField, fieldExchange);
									global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout a_;
									this.a(A_0, a_, num4, fieldValue);
									this.a(acpField);
									num = (short)1034813444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)554631174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_310;
								}
								IL_21F:
								num = (short)679673857;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21D:
								goto IL_21F;
							}
							IL_310:
							goto IL_151;
						}
						finally
						{
							num = (short)1523646465;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1233256450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_347;
									}
									continue;
								case 2:
									goto IL_37E;
								}
								IL_347:
								if (enumerator == null)
								{
									break;
								}
								num = (short)328597504;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_37E:;
						}
						goto IL_381;
						IL_151:
						num4 += (long)A_2.ListEntrySize;
						this.c(A_0.Logger);
						int num5;
						num5++;
						num = (short)706871298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num5;
						if (num5 >= acpFeatureSection.EmbeddedRecset.Count)
						{
							num = (short)1676083200;
							short num6 = num;
							num = (short)1433337861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode a_3 = (global::AcpBusinessLayer.FeatureNode)acpFeatureSection.EmbeddedRecset[num5];
						long num4;
						this.a(A_0.Logger, num4);
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout> enumerator = A_2.ListEntryLayout.FieldLayouts.GetEnumerator();
						num = (short)202768387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3ED;
					case 6:
						goto IL_14C;
					case 7:
					{
						if (acpFeatureSection.EmbeddedRecset.Count > A_2.ListCapacity)
						{
							num = (short)988938246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int a_4 = this.a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader, A_2, acpFeatureSection.EmbeddedRecset.Count);
						this.a(A_0, headerType.Name, headerType, A_4, a_4);
						long num7 = this.a(A_0, A_2, acpFeatureSection.EmbeddedRecset.Count, acpFeatureSection.EmbeddedRecset.Count, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null);
						global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange a_2 = sectionExchange.RecsetExchange;
						long num4 = num7;
						this.b(A_0.Logger, num4);
						int num5 = 0;
						num = (short)1043333128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)770768897;
						if (num != 0)
						{
						}
						goto IL_381;
					}
					goto IL_54;
					IL_381:
					num = (short)1576534020;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
				IL_14C:
				throw new global::System.InvalidOperationException();
				IL_3ED:
				this.g(A_0.Logger);
				this.a(A_0);
				return acpFeatureSection.EmbeddedRecset.Count;
				IL_54:
				headerType = A_2.HeaderType;
				sectionExchange = this.a(A_3);
				acpFeatureSection = A_1[sectionExchange.Key];
				num = (short)425394176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.b A_0)
		{
			short num = (short)1916600320;
			short num2 = num;
			num = (short)1145828810;
			short num3 = num;
			num = (short)493155786;
			switch (num3 == num)
			{
			}
			num = (short)1607467009;
			if (num != 0)
			{
			}
			num = (short)1319763968;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> enumerator = A_0[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry].GetEnumerator();
			enumerator.MoveNext();
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> enumerator2 = enumerator.Current.GetEnumerator();
			enumerator2.MoveNext();
			return enumerator2.Current;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0002FF8C File Offset: 0x0002E18C
		private void a(global::Motorola.Acp.PackUnpack.Ish.IshItemName A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1)
		{
			int a_ = 8;
			short num = (short)419627008;
			short num2 = num;
			num = (short)1981019492;
			short num3 = num;
			num = (short)652014948;
			switch (num3 == num)
			{
			}
			num = (short)2080309249;
			if (num != 0)
			{
			}
			num = (short)965017600;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b = this.c();
			global::Motorola.Acp.PackUnpack.Ish.CompositeType compositeType = (global::Motorola.Acp.PackUnpack.Ish.CompositeType)b.a();
			global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout compositeLayout = this.a(compositeType);
			global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider partitionIOProvider = this.c(compositeType);
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_2 = b[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite];
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange recsetExchange = this.a(a_2);
			global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(recsetExchange.Key);
			long num4 = this.a(partitionIOProvider, compositeType.Name, compositeType, 0, this.a(compositeLayout));
			this.d(partitionIOProvider.Logger, num4);
			this.a(partitionIOProvider, A_0, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("힞쒠슢솤螦\udfaa좬슮醰ﶲ풴\udab6\udcb8", a_));
			this.a(partitionIOProvider, A_1, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮞삠쪢즤螦\udfaa좬슮醰ﶲ풴\udab6\udcb8", a_));
			this.a(recsetExchange, partitionIOProvider, feature[0], num4);
			this.a(partitionIOProvider, compositeLayout.DataAreaLayout, num4);
			this.i(partitionIOProvider.Logger);
			this.a(partitionIOProvider);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00030108 File Offset: 0x0002E308
		private void a(global::AcpBusinessLayer.AcpRecRefField A_0)
		{
			short num = (short)1111490560;
			short num2 = num;
			num = (short)672442696;
			short num3 = num;
			num = (short)253405512;
			switch (num3 == num)
			{
			}
			num = (short)1968373760;
			if (num != 0)
			{
			}
			num = (short)383975425;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpFeatureNode parent = A_0.ReferencedNode.Parent.ParentSection.Parent;
			int index = parent.Parent.IndexOf(parent);
			this.r.Set(index, true);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000301E4 File Offset: 0x0002E3E4
		private bool a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)905314304;
			short num2 = num;
			num = (short)203385430;
			short num3 = num;
			num = (short)2030266966;
			switch (num3 == num)
			{
			}
			num = (short)1690370049;
			if (num != 0)
			{
			}
			num = (short)1602289664;
			if (num != 0)
			{
			}
			int a_ = A_0.Parent.IndexOf(A_0);
			return this.b(a_);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000302A0 File Offset: 0x0002E4A0
		private bool b(int A_0)
		{
			short num = (short)1983774720;
			short num2 = num;
			num = (short)757146190;
			short num3 = num;
			num = (short)401547854;
			switch (num3 == num)
			{
			}
			num = (short)2146172928;
			if (num != 0)
			{
			}
			num = (short)857931777;
			if (num != 0)
			{
			}
			return this.r.Get(A_0);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00030358 File Offset: 0x0002E558
		private void b()
		{
			short num = (short)1000341504;
			short num2 = num;
			num = (short)673355452;
			short num3 = num;
			num = (short)1957795516;
			switch (num3 == num)
			{
			}
			num = (short)543948801;
			if (num != 0)
			{
			}
			num = (short)185860096;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpRecordset acpRecordset = this.a();
			this.r = new global::System.Collections.BitArray(acpRecordset.Count);
			this.s = new global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshItemName>(acpRecordset.Count);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00030430 File Offset: 0x0002E630
		private global::AcpCommonLib.IAcpRecordset a()
		{
			short num = (short)1599799296;
			short num2 = num;
			num = (short)475380852;
			short num3 = num;
			num = (short)1462090868;
			switch (num3 == num)
			{
			}
			num = (short)1103888385;
			if (num != 0)
			{
			}
			num = (short)1745551360;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.a a_ = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.c][0][global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader];
			return global::AcpCommonLib.FeatureManager.GetFeature(this.a(a_).Key);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00030504 File Offset: 0x0002E704
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.b a(bool A_0)
		{
			short num2;
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.b b;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list;
						if (list.Count != 2)
						{
							num2 = (short)1193017346;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						b = list[0];
						num2 = (short)1214054403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_113;
					case 2:
						goto IL_BA;
					case 3:
					{
						if (((global::Motorola.Acp.PackUnpack.Ish.Layouts.IUclListLayout)this.i(b.a())).HasReferencedTypes == A_0)
						{
							num2 = (short)344195077;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list;
						b = list[1];
						num2 = (short)774963204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						if (((global::Motorola.Acp.PackUnpack.Ish.Layouts.IUclListLayout)this.i(b.a())).HasReferencedTypes != A_0)
						{
							num2 = (short)1301807105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return b;
					case 5:
						goto IL_1CA;
					}
					break;
				}
				IL_28:
				num2 = (short)1279420013;
				short num3 = num2;
				num2 = (short)300050029;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)477167616;
					if (num2 != 0)
					{
					}
					global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b> list = this.v[global::Motorola.Acp.PackUnpack.Ish.Packer.a.c];
					num2 = (short)170196992;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			IL_BA:
			num2 = (short)28377088;
			short num4 = num2;
			throw new global::System.InvalidOperationException();
			IL_113:
			throw new global::System.InvalidOperationException();
			IL_1CA:
			num2 = (short)238878721;
			if (num2 != 0)
			{
			}
			return b;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000306E4 File Offset: 0x0002E8E4
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(int A_0)
		{
			short num = (short)1300496384;
			short num2 = num;
			num = (short)1017766134;
			short num3 = num;
			num = (short)1684529398;
			switch (num3 == num)
			{
			}
			num = (short)668270593;
			if (num != 0)
			{
			}
			num = (short)1186463744;
			if (num != 0)
			{
			}
			return new global::Motorola.Acp.PackUnpack.Ish.IshItemName(this.s[A_0]);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000307A4 File Offset: 0x0002E9A4
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName a(global::AcpCommonLib.IAcpRecordset A_0, int A_1)
		{
			short num = (short)906887168;
			short num2 = num;
			num = (short)60279072;
			short num3 = num;
			num = (short)499894560;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1924595712;
				if (num != 0)
				{
				}
				if (A_1 != A_0.Count - 1)
				{
					return this.s[A_1 + 1];
				}
				num = (short)1009647617;
				if (num != 0)
				{
				}
				break;
			}
			return global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0003086C File Offset: 0x0002EA6C
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2, int A_3, int A_4, int A_5, int A_6)
		{
			int a_ = 15;
			short num = (short)1268121600;
			short num2 = num;
			num = (short)796536089;
			short num3 = num;
			num = (short)212675865;
			switch (num3 == num)
			{
			}
			num = (short)1068367873;
			if (num != 0)
			{
			}
			num = (short)159383552;
			if (num != 0)
			{
			}
			A_0.Writer.BaseStream.Position = this.j + 7L;
			this.b(A_0.Logger, A_0.Writer.BaseStream.Position, 18);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud9a9\ud8ab躭\udcb1삳쒵솷骹ힽ몿ꟁ", a_), A_0.Writer.BaseStream.Position, (ushort)A_1.ListEntrySize);
			A_0.Writer.Write((ushort)A_1.ListEntrySize);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud9a9\ud8ab躭펱쒳ힵ\udbb7펹좻잽", a_), A_0.Writer.BaseStream.Position, (ushort)A_1.ListCapacity);
			A_0.Writer.Write((ushort)A_1.ListCapacity);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud9a9\ud8ab躭\uddb1솳\ud8b5첷", a_), A_0.Writer.BaseStream.Position, (ushort)A_2);
			A_0.Writer.Write((ushort)A_2);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud9a9\ud8ab슭햯욱钳\ud9b7쪹\uddbb\uddbdꦿ뛁뷃", a_), A_0.Writer.BaseStream.Position, (ushort)A_1.ListletCapacity);
			A_0.Writer.Write((ushort)A_1.ListletCapacity);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧쮩좫쮭슯銱ힵ좷\udbb9\udfbbힽ뒿믁", a_), A_0.Writer.BaseStream.Position, (ushort)A_1.HeaderCapacity);
			A_0.Writer.Write((ushort)A_1.HeaderCapacity);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧쮩좫쮭슯銱\ud9b5춷풹좻", a_), A_0.Writer.BaseStream.Position, (ushort)A_3);
			A_0.Writer.Write((ushort)A_3);
			this.a(A_0, A_4, A_5, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud8a9\udfab\udaad邯ﺱ\uddb3억첷횹\ud9bb쪽賁ꗃꯅ귇", a_));
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧쮩좫쮭슯銱ힵ첷\udbb9鲻ﾽ늿ꟁꗃ鯇ꏉ뛋ꯍ", a_), A_0.Writer.BaseStream.Position, (ushort)A_6);
			A_0.Writer.Write((ushort)A_6);
			this.f(A_0.Logger);
			return A_0.Writer.BaseStream.Position;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00030B68 File Offset: 0x0002ED68
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2, int A_3, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_4)
		{
			short num = (short)1771241472;
			short num2 = num;
			num = (short)999358465;
			if (num != 0)
			{
			}
			num = (short)829769820;
			short num3 = num;
			num = (short)1225279580;
			switch (num3 == num)
			{
			}
			num = (short)725942272;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, A_2, A_3, A_4.Type, A_4.Id, A_1.HeaderDataAreaSize);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00030C30 File Offset: 0x0002EE30
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2, int A_3)
		{
			short num = (short)1269366784;
			short num2 = num;
			num = (short)238030263;
			short num3 = num;
			num = (short)1311575479;
			switch (num3 == num)
			{
			}
			num = (short)560660480;
			if (num != 0)
			{
			}
			num = (short)267976705;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, A_2, new global::Motorola.Acp.PackUnpack.Ish.IshItemName(A_1.ListletType.Value, A_3));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00030CF4 File Offset: 0x0002EEF4
		private long a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_1, int A_2, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_3)
		{
			int a_ = 13;
			short num = (short)1520304128;
			short num2 = num;
			num = (short)442773775;
			short num3 = num;
			num = (short)813773071;
			switch (num3 == num)
			{
			}
			num = (short)1089339393;
			if (num != 0)
			{
			}
			num = (short)1170079744;
			if (num != 0)
			{
			}
			A_0.Writer.BaseStream.Position = this.j + 7L;
			this.b(A_0.Logger, A_0.Writer.BaseStream.Position, 18);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쾥\udba7\udea9삫쮭쒯銱\ud9b5춷풹좻", a_), A_0.Writer.BaseStream.Position, (ushort)A_2);
			A_0.Writer.Write((ushort)A_2);
			this.a(A_0.Logger, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎥킧\udea9貫\ud9af솱삳\udab5\uddb7캹鲻ꆿ꿁ꇃ", a_), A_0.Writer.BaseStream.Position, (ushort)A_3.Type, (ushort)A_3.Id);
			this.a(A_0, A_3, global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎥킧\udea9貫\ud9af솱삳\udab5\uddb7캹鲻ꆿ꿁ꇃ", a_));
			this.f(A_0.Logger);
			return A_0.Writer.BaseStream.Position;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00030E94 File Offset: 0x0002F094
		private void a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_1, string A_2)
		{
			short num = (short)1858732032;
			short num2 = num;
			num = (short)886964225;
			if (num != 0)
			{
			}
			num = (short)1239652374;
			short num3 = num;
			num = (short)837523478;
			switch (num3 == num)
			{
			}
			num = (short)1726087168;
			if (num != 0)
			{
			}
			this.a(A_0.Logger, A_2, A_0.Writer.BaseStream.Position, (ushort)A_1.Type, (ushort)A_1.Id);
			A_0.Writer.Write((ushort)A_1.Type);
			A_0.Writer.Write((ushort)A_1.Id);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00030F9C File Offset: 0x0002F19C
		private void a(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider A_0, int A_1, int A_2, string A_3)
		{
			short num = (short)1737555968;
			short num2 = num;
			num = (short)183492377;
			short num3 = num;
			num = (short)1750589209;
			switch (num3 == num)
			{
			}
			num = (short)858521600;
			if (num != 0)
			{
			}
			num = (short)1472921601;
			if (num != 0)
			{
			}
			this.a(A_0.Logger, A_3, A_0.Writer.BaseStream.Position, (ushort)A_1, (ushort)A_2);
			A_0.Writer.Write((ushort)A_1);
			A_0.Writer.Write((ushort)A_2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0003108C File Offset: 0x0002F28C
		protected virtual void PackCharField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)332988416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				byte[] bytes;
				byte value2;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding encoding;
				global::System.Text.Encoding encoding2;
				char[] chars;
				for (;;)
				{
					IL_29:
					byte b;
					switch (num2)
					{
					case 0:
						goto IL_23B;
					case 1:
						if (layout.Encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Ascii)
						{
							num = (short)198967312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_290;
					case 2:
					{
						num = (short)1308950528;
						short num3 = num;
						num = (short)175374341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (layout.Nibble == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper)
						{
							num = (short)1046347795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value2 = (byte)(((int)b & 65280) | (int)(bytes[0] & byte.MaxValue));
						num = (short)340393990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_400;
					case 5:
						goto IL_482;
					case 6:
						goto IL_306;
					case 7:
						goto IL_184;
					case 8:
						goto IL_400;
					case 9:
						if (layout.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bch)
						{
							num = (short)446431243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57B;
					case 10:
						goto IL_400;
					case 11:
						goto IL_364;
					case 12:
						if (layout.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Unicode)
						{
							num = (short)834076694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)779616277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1360199689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)941943766;
						short num4 = num;
						num = (short)60681174;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1519190016;
							if (num != 0)
							{
							}
							switch (encoding)
							{
							case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Unicode:
								break;
							case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Ascii:
								num = (short)1608384513;
								if (num != 0)
								{
								}
								encoding2 = this.p[global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii];
								num = (short)857276424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bcd:
								encoding2 = this.p[global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd];
								num = (short)15466500;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bch:
								encoding2 = this.p[global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch];
								num = (short)1504116753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)2103115778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						encoding2 = this.p[global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Unicode];
						num = (short)104333322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)437452820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)349175820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_400;
					case 18:
						if (layout.Encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bcd)
						{
							num = (short)945684495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30B;
					case 19:
						value2 = (byte)((int)bytes[0] << 4 | (int)(b & byte.MaxValue));
						num = (short)61603840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (layout.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bch)
						{
							num = (short)1737818135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 21:
						if (layout.Encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bcd)
						{
							num = (short)503447565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_364;
					case 22:
						goto IL_576;
					case 23:
						goto IL_30B;
					}
					goto IL_90;
					IL_184:
					bytes = encoding2.GetBytes(chars);
					ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
					num = (short)1646198785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30B:
					((global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoding)encoding2).StartNibble = layout.Nibble;
					num = (short)905248775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_364:
					b = ioProvider.Reader.ReadByte();
					num = (short)1707409411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_400:
					num = (short)1134559250;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23B:
				goto IL_3B3;
				IL_290:
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, encoding2.EncodingName, (char)value, bytes, 0, bytes.Length);
				ioProvider.Writer.BaseStream.Write(bytes, 0, bytes.Length);
				return;
				IL_306:
				IL_3B3:
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, encoding2.EncodingName, (char)value, bytes[0], layout.Nibble == global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper);
				ioProvider.Writer.BaseStream.WriteByte(value2);
				return;
				IL_482:
				throw new global::System.NotSupportedException();
				IL_576:
				goto IL_290;
				IL_57B:
				throw new global::System.NotSupportedException();
				IL_90:
				chars = new char[]
				{
					(char)value
				};
				encoding = layout.Encoding;
				num = (short)950534158;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0003161C File Offset: 0x0002F81C
		protected virtual void PackStringField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			int a_ = 19;
			short num = (short)783482880;
			switch (num)
			{
			default:
			{
				string a_2;
				byte[] bytes;
				global::System.Text.Encoding encoding2;
				for (;;)
				{
					IL_27:
					num = (short)298713096;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						switch (num2)
						{
						case 0:
							if (layout.StringLength - text.Length > 0)
							{
								num = (short)938147859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = text;
							num = (short)1065549847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)936378382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1716671490;
							short num3 = num;
							num = (short)1104565250;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num = (short)131727360;
								if (num != 0)
								{
								}
								goto IL_19E;
							}
							break;
						}
						case 3:
							if (text.Length > layout.StringLength)
							{
								num = (short)1210187783;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1814036480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_232;
						case 5:
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding;
							if (encoding - global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd > 1)
							{
								num = (short)1160970251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = text.PadLeft(layout.StringLength, '0');
							num = (short)1730478093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (bytes.Length != layout.Size)
							{
								num = (short)913113092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50E;
						case 7:
							goto IL_1E0;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							continue;
						case 9:
							goto IL_1EB;
						case 10:
							goto IL_275;
						case 11:
							num = (short)502398986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_19E;
						case 13:
							goto IL_453;
						case 14:
							if (layout.Encoding == global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bch)
							{
								num = (short)263979026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EB;
						case 15:
							goto IL_453;
						case 16:
							text = (global::System.Convert.ChangeType(value, global::System.TypeCode.String) as string);
							num = (short)391708684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							a_2 = text.PadRight(layout.StringLength, layout.Terminator);
							num = (short)921960469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_2C4;
						case 19:
							num = (short)1093730324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							if (layout.Justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
							{
								num = (short)271515665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding = layout.Encoding;
							num = (short)1285226518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_453;
						case 22:
						{
							global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding encoding;
							if (encoding > global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Ascii)
							{
								num = (short)2138963993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = text.PadLeft(layout.StringLength, '\0');
							num = (short)200474639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							num = (short)1038155776;
							short num4 = num;
							goto IL_453;
						}
						case 24:
							if (layout.Encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding.Bcd)
							{
								num = (short)1703346177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C4;
						case 25:
							num = (short)114294789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B5:
						if (value != null)
						{
							num = (short)454098960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = string.Empty;
						num = (short)228720642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19E:
						num = (short)928579587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EB:
						bytes = encoding2.GetBytes(a_2);
						num = (short)837091334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C4:
						((global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoding)encoding2).StartNibble = global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper;
						num = (short)298975241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_453:
						encoding2 = this.p[layout.Encoding];
						num = (short)1482489880;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1E0:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca9춫슭얯ힱ", a_));
				IL_232:
				num = (short)367656961;
				if (num != 0)
				{
				}
				throw new global::System.IO.InvalidDataException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udca9춫슭얯ힱ", a_));
				IL_275:
				throw new global::System.NotSupportedException();
				IL_50E:
				ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, encoding2, layout, a_2);
				ioProvider.Writer.BaseStream.Write(bytes, 0, bytes.Length);
				return;
			}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00031B8C File Offset: 0x0002FD8C
		protected virtual void PackBoolField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			byte value2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_189;
				case 1:
					goto IL_118;
				case 2:
				{
					num2 = (short)1088064505;
					short num3 = num2;
					num2 = (short)1292995577;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
					{
						num2 = (short)284688384;
						if (num2 != 0)
						{
						}
						byte b = (byte)layout.Mask.Apply(((bool)value) ? 1 : 0, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
						num2 = (short)1838284803;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
				{
					if (ioProvider.Writer.BaseStream.Length - ioProvider.Writer.BaseStream.Position < 1L)
					{
						num2 = (short)961413124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte b2 = ioProvider.Reader.ReadByte();
					global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream = ioProvider.Reader.BaseStream;
					long position = baseStream.Position;
					baseStream.Position = position - 1L;
					byte b;
					value2 = (b2 | b);
					num2 = (short)686227456;
					short num4 = num2;
					num2 = (short)60817408;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					ioProvider.Writer.BaseStream.SetLength(ioProvider.Writer.BaseStream.Position + 1L);
					byte b;
					value2 = b;
					num2 = (short)380239873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			IL_118:
			IL_189:
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, (bool)value, layout.Mask.BitOffset, (byte)layout.Mask.Mask);
			ioProvider.Writer.Write(value2);
			return;
			IL_24:
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			num2 = (short)1677066241;
			if (num2 != 0)
			{
			}
			num2 = (short)1337131010;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00031DDC File Offset: 0x0002FFDC
		protected virtual void PackSByteField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1747319748;
			short num2 = num;
			num = (short)1135999940;
			switch (num2 == num)
			{
			}
			num = (short)493617152;
			short num3 = num;
			num = (short)141688833;
			if (num != 0)
			{
			}
			num = (short)1001914368;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			sbyte b = global::System.Convert.ToSByte(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, b);
			ioProvider.Writer.Write(b);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00031ED8 File Offset: 0x000300D8
		protected virtual void PackByteField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			byte b3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B2;
				case 1:
				{
					byte b = (byte)layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
					num2 = (short)208928772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_B2;
				case 3:
					goto IL_169;
				case 4:
				{
					if (ioProvider.Writer.BaseStream.Length - ioProvider.Writer.BaseStream.Position < 1L)
					{
						num2 = (short)13500422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte b2 = ioProvider.Reader.ReadByte();
					global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream baseStream = ioProvider.Reader.BaseStream;
					long position = baseStream.Position;
					baseStream.Position = position - 1L;
					byte b;
					b3 = (b2 | b);
					num2 = (short)1209663490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					IL_8A:
					if (layout.Mask != null)
					{
						num2 = (short)688324609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b3 = global::System.Convert.ToByte(value);
					this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, b3);
					num2 = (short)14417927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					ioProvider.Writer.BaseStream.SetLength(ioProvider.Writer.BaseStream.Position + 1L);
					byte b;
					b3 = b;
					num2 = (short)2039283712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_267;
				}
				goto IL_30;
				IL_B2:
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, global::System.Convert.ToByte(value), layout.Mask.BitOffset, layout.Mask.BitSize, (byte)layout.Mask.Mask);
				num2 = (short)2038103338;
				short num3 = num2;
				num2 = (short)491519274;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8A;
				default:
					num2 = (short)1089667072;
					if (num2 != 0)
					{
					}
					num2 = (short)366608387;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_169:
			goto IL_2D2;
			IL_267:
			num2 = (short)2079850497;
			if (num2 != 0)
			{
			}
			IL_2D2:
			ioProvider.Writer.Write(b3);
			return;
			IL_30:
			num2 = (short)1607925760;
			short num4 = num2;
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			num2 = (short)1316683781;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000321C4 File Offset: 0x000303C4
		protected virtual void PackInt16Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1460011459;
			short num2 = num;
			num = (short)1685520835;
			switch (num2 == num)
			{
			}
			num = (short)511901696;
			short num3 = num;
			num = (short)618856449;
			if (num != 0)
			{
			}
			num = (short)551026688;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			short num4 = global::System.Convert.ToInt16(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num4);
			ioProvider.Writer.Write(num4);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000322C4 File Offset: 0x000304C4
		protected virtual void PackUInt16Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				ushort num6;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_150;
					case 1:
					{
						num2 = (short)1112080384;
						short num3 = num2;
						num2 = (short)1062186041;
						short num4 = num2;
						num2 = (short)1562553401;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B;
						default:
						{
							num2 = (short)2046885888;
							if (num2 != 0)
							{
							}
							this.a((uint)((int)value), layout);
							ushort num5 = (ushort)layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
							num2 = (short)1097728005;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_10F;
					case 3:
						if (layout.Mask != null)
						{
							num2 = (short)541786113;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_28F;
					case 4:
					{
						ioProvider.Writer.BaseStream.SetLength(ioProvider.Writer.BaseStream.Position + 2L);
						ushort num5;
						num6 = num5;
						num2 = (short)1237385216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
					{
						if (ioProvider.Writer.BaseStream.Length - ioProvider.Writer.BaseStream.Position < 2L)
						{
							num2 = (short)1436352516;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						ushort num7 = ioProvider.Reader.ReadUInt16();
						ioProvider.Reader.BaseStream.Position -= 2L;
						ushort num5;
						num6 = (num7 | num5);
						num2 = (short)1163067394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_28;
				}
				IL_10F:
				IL_150:
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, global::System.Convert.ToUInt16(value), layout.Mask.BitOffset, layout.Mask.BitSize, (ushort)layout.Mask.Mask);
				ioProvider.Writer.Write(num6);
				this.a(ioProvider.Writer, layout.Mask);
				return;
				IL_28F:
				num6 = global::System.Convert.ToUInt16(value);
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num6);
				ioProvider.Writer.Write(num6);
				return;
			}
			}
			IL_28:
			num2 = (short)2091319297;
			if (num2 != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			IL_6B:
			num2 = (short)212533251;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0003259C File Offset: 0x0003079C
		protected virtual void PackInt32Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1760310423;
			short num2 = num;
			num = (short)634795159;
			switch (num2 == num)
			{
			}
			num = (short)280428544;
			short num3 = num;
			num = (short)1608122369;
			if (num != 0)
			{
			}
			num = (short)1698627584;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			int num4 = global::System.Convert.ToInt32(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num4);
			ioProvider.Writer.Write(num4);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000326A0 File Offset: 0x000308A0
		protected virtual void PackUInt32Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				uint num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_123;
					case 1:
					{
						num2 = (short)1531992821;
						short num3 = num2;
						num2 = (short)1137597173;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42;
						default:
						{
							num2 = (short)1741225984;
							if (num2 != 0)
							{
							}
							this.a((uint)((int)value), layout);
							uint num4 = (uint)layout.Mask.Apply((int)value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
							num2 = (short)1162215429;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_E0;
					case 3:
						if (layout.Mask != null)
						{
							num2 = (short)460783617;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_28A;
					case 4:
					{
						ioProvider.Writer.BaseStream.SetLength(ioProvider.Writer.BaseStream.Position + 4L);
						uint num4;
						num5 = num4;
						num2 = (short)1773404160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
					{
						num2 = (short)269484033;
						if (num2 != 0)
						{
						}
						if (ioProvider.Writer.BaseStream.Length - ioProvider.Writer.BaseStream.Position < 4L)
						{
							num2 = (short)584581124;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)269942784;
						short num6 = num2;
						uint num7 = ioProvider.Reader.ReadUInt32();
						ioProvider.Reader.BaseStream.Position -= 4L;
						uint num4;
						num5 = (num7 | num4);
						num2 = (short)1072431106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_28;
				}
				IL_E0:
				IL_123:
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, global::System.Convert.ToUInt32(value), layout.Mask.BitOffset, layout.Mask.BitSize, (uint)layout.Mask.Mask);
				ioProvider.Writer.Write(num5);
				this.a(ioProvider.Writer, layout.Mask);
				return;
				IL_28A:
				num5 = global::System.Convert.ToUInt32(value);
				this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num5);
				ioProvider.Writer.Write(num5);
				return;
			}
			}
			IL_28:
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			IL_42:
			num2 = (short)1385234435;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00032974 File Offset: 0x00030B74
		protected virtual void PackInt64Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)2041414007;
			short num2 = num;
			num = (short)75989367;
			switch (num2 == num)
			{
			}
			num = (short)210370560;
			short num3 = num;
			num = (short)1257046017;
			if (num != 0)
			{
			}
			num = (short)1011679232;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			long num4 = global::System.Convert.ToInt64(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num4);
			ioProvider.Writer.Write(num4);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00032A70 File Offset: 0x00030C70
		protected virtual void PackUInt64Field(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)271977040;
			short num2 = num;
			num = (short)1548683856;
			switch (num2 == num)
			{
			}
			num = (short)1499922432;
			short num3 = num;
			num = (short)106758145;
			if (num != 0)
			{
			}
			num = (short)814874624;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			ulong num4 = global::System.Convert.ToUInt64(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, num4);
			ioProvider.Writer.Write(num4);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00032B70 File Offset: 0x00030D70
		protected virtual void PackItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1161961862;
			short num2 = num;
			num = (short)912073094;
			switch (num2 == num)
			{
			}
			num = (short)1554644992;
			short num3 = num;
			num = (short)486539265;
			if (num != 0)
			{
			}
			num = (short)2075000832;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			global::Motorola.Acp.PackUnpack.Ish.IshItemName ishItemName = (global::Motorola.Acp.PackUnpack.Ish.IshItemName)value;
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, (ushort)ishItemName.Type, (ushort)ishItemName.Id);
			ioProvider.Writer.Write((ushort)ishItemName.Type);
			ioProvider.Writer.Write((ushort)ishItemName.Id);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00032C9C File Offset: 0x00030E9C
		protected virtual void PackDynamicItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1002118664;
			short num2 = num;
			num = (short)543235592;
			switch (num2 == num)
			{
			}
			num = (short)1735655424;
			short num3 = num;
			num = (short)1386020864;
			if (num != 0)
			{
			}
			num = (short)626130945;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			global::Motorola.Acp.PackUnpack.Ish.IshItemName ishItemName = (global::Motorola.Acp.PackUnpack.Ish.IshItemName)value;
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, (ushort)ishItemName.Type, (ushort)ishItemName.Id);
			ioProvider.Writer.Write((ushort)ishItemName.Type);
			ioProvider.Writer.Write((ushort)ishItemName.Id);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00032DCC File Offset: 0x00030FCC
		protected virtual void PackIndexReferenceField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)1894580225;
			if (num != 0)
			{
			}
			num = (short)1710358528;
			short num2 = num;
			num = (short)660962771;
			short num3 = num;
			num = (short)87784915;
			switch (num3 == num)
			{
			}
			num = (short)226885632;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField indexReferenceField = (global::Motorola.Acp.PackUnpack.Ish.Fields.IndexReferenceField)value;
			this.a(ioProvider, indexReferenceField.Name, layout.Name);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, indexReferenceField.Value);
			ioProvider.Writer.Write(indexReferenceField.Value);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00032EE8 File Offset: 0x000310E8
		protected virtual void PackByteArrayField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			short num = (short)529207335;
			short num2 = num;
			num = (short)924848167;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1630994432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1099300864;
			if (num != 0)
			{
			}
			num = (short)336855041;
			if (num != 0)
			{
			}
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			byte b = global::System.Convert.ToByte(value);
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, b);
			ioProvider.Writer.Write(b);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00032FE4 File Offset: 0x000311E4
		protected virtual void PackIPAddressField(global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider ioProvider, global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout layout, object value, long dataAreaBaseOffset)
		{
			int a_ = 0;
			short num = (short)2107310080;
			short num2 = num;
			ioProvider.Writer.BaseStream.Position = dataAreaBaseOffset + (long)layout.Offset;
			byte[] array = (byte[])value;
			if (array.Length != 16)
			{
				num = (short)548817869;
				short num3 = num;
				num = (short)2020821965;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)389611520;
					if (num != 0)
					{
					}
					throw new global::System.IO.InvalidDataException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ude96ﲜ좠잢薤솦삨캪솬쮮醰삲\udcb4춶\udcb8鮺\udbbc킾돀賄韆꫊꧌ꯎꏐ뛒ꛔꓖ律뷚드뫞跠蟢엤鳦\ud9e8雪", a_), layout.Name));
				}
			}
			num = (short)1049624577;
			if (num != 0)
			{
			}
			this.a(ioProvider.Logger, layout.Name, ioProvider.Writer.BaseStream.Position, global::System.Enum.GetName(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressType), layout.AddressType), array, 0, array.Length);
			ioProvider.Writer.Write(array, 0, array.Length);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00033130 File Offset: 0x00031330
		private void a(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask A_1)
		{
			short num = (short)162109564;
			short num2 = num;
			num = (short)1732024444;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2104360961;
				if (num != 0)
				{
				}
				num = (short)1064435712;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num3;
				int num4;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
						return;
					case 1:
						A_0.BaseStream.Position -= (long)num4;
						num = (short)1753546752;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1719861248;
						short num5 = num;
						if (num4 > 0)
						{
							num = (short)2094727169;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				IL_8F:
				num4 = (A_1.BitOffset - A_1.BitSize + 1) / 8;
				num = (short)1702690818;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00033268 File Offset: 0x00031468
		private void a(uint A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout A_1)
		{
			int a_ = 1;
			short num = (short)2075721728;
			short num2 = num;
			num = (short)1226440705;
			if (num != 0)
			{
			}
			int num3 = (1 << A_1.Mask.BitSize) - 1;
			if ((ulong)A_0 > (ulong)((long)num3))
			{
				num = (short)641290663;
				short num4 = num;
				num = (short)1323454887;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1217200128;
					if (num != 0)
					{
					}
					throw new global::System.OverflowException(string.Format(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udb97ﮙ쾟횡蒣횥즧즩잫躭횯\udbb1톳\udab5\udcb7骹잻躽붿뛅꧇꧉Ɤꛏ돑룓ꏕ뷗龎ꟛ鷟싡臣黥诧迩觫諭華틱鋳鿵鷷雹飻\udefd淿持簃★縇欉怋笍甏㈑笓瀕㠗愙⸛挝", a_), A_1.Name, A_0, num3));
				}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00033360 File Offset: 0x00031560
		public void Dispose()
		{
			short num = (short)1528287448;
			short num2 = num;
			num = (short)564777176;
			switch (num2 == num)
			{
			default:
			{
				num = (short)658833408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1023934464;
			if (num != 0)
			{
			}
			num = (short)1835925505;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00033418 File Offset: 0x00031618
		protected void Dispose(bool disposing)
		{
			short num = (short)466829416;
			short num2 = num;
			num = (short)1190936680;
			switch (num2 == num)
			{
			default:
			{
				num = (short)388431872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1904082944;
			if (num != 0)
			{
			}
			num = (short)132972545;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000334C4 File Offset: 0x000316C4
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, bool A_3, int A_4, byte A_5)
		{
			short num = (short)1634275957;
			short num2 = num;
			num = (short)1430262389;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F9:
				num = (short)2015625216;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)437583872;
				short num4 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_B6:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_E9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_C8;
					}
					continue;
				}
				IL_C8:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1184366593;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			A_0.a(A_1, A_2, A_3, A_4, A_5);
			goto IL_F9;
			IL_5D:
			num = (short)1320157185;
			if (num != 0)
			{
			}
			num = (short)2147352576;
			if (num != 0)
			{
			}
			num = (short)205258754;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B6;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000335E4 File Offset: 0x000317E4
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, string A_3, char A_4, byte[] A_5, int A_6, int A_7)
		{
			short num = (short)1403346613;
			short num2 = num;
			num = (short)1853054645;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FD:
				num = (short)1013841920;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)618004480;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_91:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_E9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				}
				IL_A3:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)182386689;
				if (num != 0)
				{
				}
				num = (short)618201089;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			A_0.a(A_1, A_2, A_3, A_4, A_5, A_6, A_7);
			goto IL_FD;
			IL_5E:
			num = (short)1237188608;
			if (num != 0)
			{
			}
			num = (short)1243873282;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_91;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00033704 File Offset: 0x00031904
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, string A_3, char A_4, byte A_5, bool A_6)
		{
			short num = (short)652405151;
			short num2 = num;
			num = (short)1550248351;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FD:
				num = (short)1764294656;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_60;
			default:
			{
				num = (short)1928069120;
				short num4 = num;
				goto IL_60;
			}
			}
			for (;;)
			{
				IL_B9:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CB;
					}
					continue;
				}
				IL_CB:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)791609345;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			A_0.a(A_1, A_2, A_3, A_4, A_5, A_6);
			goto IL_FD;
			IL_60:
			num = (short)447938561;
			if (num != 0)
			{
			}
			num = (short)1364262912;
			if (num != 0)
			{
			}
			num = (short)1534656514;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B9;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00033824 File Offset: 0x00031A24
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, object A_3)
		{
			short num = (short)1640631797;
			short num2 = num;
			num = (short)494079477;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FA:
				num = (short)14155776;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1083441152;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_BB:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				}
				IL_CD:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1930231809;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			A_0.a(A_1, A_2, A_3);
			goto IL_FA;
			IL_5F:
			num = (short)627507201;
			if (num != 0)
			{
			}
			num = (short)1334771712;
			if (num != 0)
			{
			}
			num = (short)1419837442;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BB;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00033944 File Offset: 0x00031B44
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, object A_3, int A_4, int A_5, object A_6)
		{
			short num = (short)477424866;
			short num2 = num;
			num = (short)490073314;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D7:
				num = (short)634191872;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1474953216;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num3)
				{
				case 0:
					goto IL_EC;
				case 1:
					goto IL_C5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				}
				IL_A5:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1156644865;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			A_0.a(A_1, A_2, A_3, A_4, A_5, A_6);
			goto IL_D7;
			IL_EC:
			num = (short)1691942913;
			if (num != 0)
			{
			}
			return;
			IL_5E:
			num = (short)1115095040;
			if (num != 0)
			{
			}
			num = (short)1728053250;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00033A68 File Offset: 0x00031C68
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, string A_3, byte[] A_4, int A_5, int A_6)
		{
			short num = (short)1134264433;
			short num2 = num;
			num = (short)628392049;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_100:
				num = (short)1885601792;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_61;
			default:
			{
				num = (short)912392192;
				short num4 = num;
				goto IL_61;
			}
			}
			for (;;)
			{
				IL_BC:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				}
				IL_CE:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)282656769;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			A_0.a(A_1, A_2, A_3, A_4, A_5, A_6);
			goto IL_100;
			IL_61:
			num = (short)1201602561;
			if (num != 0)
			{
			}
			num = (short)763559936;
			if (num != 0)
			{
			}
			num = (short)1652752386;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BC;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00033B8C File Offset: 0x00031D8C
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, object A_3, object A_4)
		{
			short num = (short)210728080;
			short num2 = num;
			num = (short)1771533456;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FB:
				num = (short)747962368;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1555955712;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_BA:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_ED;
				case 2:
					num = (short)2091712513;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CC;
					}
					continue;
				}
				IL_CC:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1218576385;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			A_0.a(A_1, A_2, A_3, A_4);
			goto IL_FB;
			IL_5F:
			num = (short)1400700928;
			if (num != 0)
			{
			}
			num = (short)473694210;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BA;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00033CAC File Offset: 0x00031EAC
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, global::System.Text.Encoding A_3, global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout A_4, string A_5)
		{
			short num = (short)2007171076;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2011627521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_4.Justification == global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left)
					{
						num = (short)343277570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_0.a(A_1, A_2, A_4.Size, A_3.EncodingName, A_5);
					num = (short)572063747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_186;
				case 3:
				{
					num = (short)1675433093;
					short num3 = num;
					num = (short)498996357;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_C3;
					}
					break;
				}
				case 4:
					goto IL_14;
				}
				goto IL_38;
				IL_14:
				switch (0)
				{
				case 0:
					IL_38:
					if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
					{
						return;
					}
					num = (short)901775360;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C3:
			num = (short)2129461249;
			if (num != 0)
			{
			}
			num = (short)572260352;
			short num4 = num;
			num = (short)73793536;
			if (num != 0)
			{
			}
			return;
			IL_186:
			A_0.a(A_1, A_2, A_4.Size, A_3.EncodingName, A_4.Terminator, A_5);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00033E44 File Offset: 0x00032044
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1, int A_2, byte A_3)
		{
			short num = (short)453417782;
			short num2 = num;
			num = (short)141597494;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				num = (short)601423872;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_60;
			default:
			{
				num = (short)1785462784;
				short num4 = num;
				goto IL_60;
			}
			}
			for (;;)
			{
				IL_95:
				switch (num3)
				{
				case 0:
					goto IL_E7;
				case 1:
					goto IL_C7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					continue;
				}
				IL_A7:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1722351617;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			A_0.a(A_1, A_2, A_3);
			goto IL_D3;
			IL_E7:
			num = (short)571604993;
			if (num != 0)
			{
			}
			return;
			IL_60:
			num = (short)958398464;
			if (num != 0)
			{
			}
			num = (short)1354629122;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_95;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00033F64 File Offset: 0x00032164
		private void d(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1)
		{
			int a_ = 3;
			short num = (short)24643416;
			short num2 = num;
			num = (short)931202904;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10B:
				num = (short)669057024;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_65;
			default:
			{
				num = (short)997457920;
				short num4 = num;
				goto IL_65;
			}
			}
			for (;;)
			{
				IL_99:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_CD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					continue;
				}
				IL_AB:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1882587137;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			num = (short)103022593;
			if (num != 0)
			{
			}
			A_0.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud999킟춡힣쾥\udca7쾩貫톯욱햳隵醴좹\ud9bb\udfbd", a_), A_1);
			goto IL_10B;
			IL_65:
			num = (short)1499267072;
			if (num != 0)
			{
			}
			num = (short)416743426;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_99;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00034098 File Offset: 0x00032298
		private void i(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1235481664;
			short num2 = num;
			num = (short)976155712;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F7:
				num = (short)2145517568;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1701642240;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_BC:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				}
				IL_CE:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)727187457;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			A_0.k();
			goto IL_F7;
			IL_5F:
			num = (short)1324810241;
			if (num != 0)
			{
			}
			num = (short)1298530304;
			if (num != 0)
			{
			}
			num = (short)2130378754;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BC;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000341B4 File Offset: 0x000323B4
		private void c(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1)
		{
			int a_ = 5;
			short num = (short)343425856;
			short num2 = num;
			num = (short)540099392;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E4:
				num = (short)592445441;
				if (num != 0)
				{
				}
				num = (short)20905984;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_68;
			default:
			{
				num = (short)1432879104;
				short num4 = num;
				goto IL_68;
			}
			}
			for (;;)
			{
				IL_9B:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_CD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				}
				IL_AD:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)500367361;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			A_0.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풛ﮝ솟욡솣풥袧춫\udaad톯銱쒵\uddb7\udbb9", a_), A_1);
			goto IL_E4;
			IL_68:
			num = (short)110297088;
			if (num != 0)
			{
			}
			num = (short)1554579458;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_9B;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000342E4 File Offset: 0x000324E4
		private void h(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1067389091;
			short num2 = num;
			num = (short)145887395;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CD:
				num = (short)1281032192;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)2010054656;
				short num4 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_92:
				switch (num3)
				{
				case 0:
					goto IL_E3;
				case 1:
					goto IL_C5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				IL_A4:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)181338113;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			A_0.k();
			goto IL_CD;
			IL_E3:
			num = (short)882376705;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)499843072;
			if (num != 0)
			{
			}
			num = (short)955449346;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_92;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000343FC File Offset: 0x000325FC
		private void b(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1)
		{
			int a_ = 9;
			short num = (short)523198954;
			short num2 = num;
			num = (short)1454137834;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10D:
				num = (short)1227620352;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_68;
			default:
			{
				num = (short)106889216;
				short num4 = num;
				goto IL_68;
			}
			}
			for (;;)
			{
				IL_C4:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_F6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D6;
					}
					continue;
				}
				IL_D6:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)2057895937;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			A_0.a(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮡힣튥袧슫\udaad슯\udbb1톳억颷ﺹ\uddbb쪽ꆿ藃듅귇ꯉ", a_), A_1);
			goto IL_10D;
			IL_68:
			num = (short)317915137;
			if (num != 0)
			{
			}
			num = (short)1211301888;
			if (num != 0)
			{
			}
			num = (short)1751908354;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_C4;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0003452C File Offset: 0x0003272C
		private void g(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)373559023;
			short num2 = num;
			num = (short)306908911;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F8:
				num = (short)10878976;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)803733504;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_F0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				}
				IL_A5:
				num = (short)2117074945;
				if (num != 0)
				{
				}
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1961295873;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			A_0.k();
			goto IL_F8;
			IL_5F:
			num = (short)2107441152;
			if (num != 0)
			{
			}
			num = (short)2021654530;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00034648 File Offset: 0x00032848
		private void b(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1, int A_2)
		{
			short num = (short)1853694434;
			short num2 = num;
			num = (short)1491608034;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CE:
				num = (short)1940062208;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)250085376;
				short num4 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_90:
				switch (num3)
				{
				case 0:
					goto IL_E4;
				case 1:
					goto IL_C4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				}
				IL_A2:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					goto IL_E6;
				}
				num = (short)1702952961;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			A_0.b(A_1, A_2);
			goto IL_CE;
			IL_E4:
			IL_E6:
			num = (short)1303379969;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)343080960;
			if (num != 0)
			{
			}
			num = (short)59703298;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_90;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00034764 File Offset: 0x00032964
		private void f(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)922125329;
			short num2 = num;
			num = (short)1216513041;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5:
				num = (short)579600384;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1650327552;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_BB:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_ED;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				}
				IL_CD:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1150222337;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			A_0.i();
			goto IL_F5;
			IL_5F:
			num = (short)1887567873;
			if (num != 0)
			{
			}
			num = (short)1866203136;
			if (num != 0)
			{
			}
			num = (short)757530626;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BB;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00034880 File Offset: 0x00032A80
		private void b(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, int A_3)
		{
			short num = (short)705535804;
			short num2 = num;
			num = (short)361602876;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F9:
				num = (short)1978073088;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_61;
			default:
			{
				num = (short)206503936;
				short num4 = num;
				goto IL_61;
			}
			}
			for (;;)
			{
				IL_BB:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_ED;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				}
				IL_CD:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1105592321;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			A_0.b(A_1, A_2, A_3);
			goto IL_F9;
			IL_61:
			num = (short)763625473;
			if (num != 0)
			{
			}
			num = (short)1272446976;
			if (num != 0)
			{
			}
			num = (short)373489666;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BB;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0003499C File Offset: 0x00032B9C
		private void e(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)940909502;
			short num2 = num;
			num = (short)1753883582;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F4:
				num = (short)1146945536;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)885456896;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_BA:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CC;
					}
					continue;
				}
				IL_CC:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)800653313;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EC:
			A_0.g();
			goto IL_F4;
			IL_5E:
			num = (short)1833304065;
			if (num != 0)
			{
			}
			num = (short)1916338176;
			if (num != 0)
			{
			}
			num = (short)965607426;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BA;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00034AB4 File Offset: 0x00032CB4
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1, int A_2)
		{
			short num = (short)1895101446;
			short num2 = num;
			num = (short)1885205510;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F8:
				num = (short)1794703360;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_60;
			default:
			{
				num = (short)978059264;
				short num4 = num;
				goto IL_60;
			}
			}
			for (;;)
			{
				IL_BB:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				}
				IL_CD:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1456930817;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			A_0.a(A_1, A_2);
			goto IL_F8;
			IL_60:
			num = (short)693501952;
			if (num != 0)
			{
			}
			num = (short)1445658625;
			if (num != 0)
			{
			}
			num = (short)208273410;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BB;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00034BD0 File Offset: 0x00032DD0
		private void d(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1941850411;
			short num2 = num;
			num = (short)1023691051;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F2:
				num = (short)1530331136;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5C;
			default:
			{
				num = (short)2108293120;
				short num4 = num;
				goto IL_5C;
			}
			}
			for (;;)
			{
				IL_B7:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				}
				IL_C9:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1480130561;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			A_0.h();
			goto IL_F2;
			IL_5C:
			num = (short)535298048;
			if (num != 0)
			{
			}
			num = (short)1630208001;
			if (num != 0)
			{
			}
			num = (short)1521876994;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B7;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00034CE8 File Offset: 0x00032EE8
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, long A_1)
		{
			short num = (short)374961329;
			short num2 = num;
			num = (short)1758164145;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F2:
				num = (short)1923022848;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)727711744;
				short num4 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_B7:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_E9;
				case 2:
					num = (short)1847721985;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				}
				IL_C9:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					return;
				}
				num = (short)1793130497;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			A_0.b(A_1);
			goto IL_F2;
			IL_5D:
			num = (short)851312640;
			if (num != 0)
			{
			}
			num = (short)1569914882;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B7;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00034E00 File Offset: 0x00033000
		private void c(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1374486529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_98;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					A_0.l();
					num = (short)82313217;
					if (num != 0)
					{
					}
					num = (short)1195900928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					goto IL_C2;
				}
				num = (short)150405122;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_98:
			num = (short)1669660672;
			short num3 = num;
			IL_C2:
			num = (short)903024480;
			short num4 = num;
			num = (short)1472860000;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_98;
			default:
				num = (short)655228928;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00034F1C File Offset: 0x0003311C
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, int A_3)
		{
			short num = (short)566099969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					A_0.a(A_1, A_2, A_3);
					num = (short)1625358336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)1055064065;
				if (num != 0)
				{
				}
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					goto IL_C8;
				}
				num = (short)677183490;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9D:
			num = (short)194248704;
			short num3 = num;
			IL_C8:
			num = (short)375365847;
			short num4 = num;
			num = (short)670212311;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9D;
			default:
				num = (short)876216320;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0003503C File Offset: 0x0003323C
		private void b(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1969225729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6E;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					A_0.f();
					num = (short)144703488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					break;
				}
				num = (short)1804664834;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6E:
			num = (short)888602624;
			short num3 = num;
			num = (short)680299627;
			short num4 = num;
			num = (short)1783270507;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6E;
			default:
				num = (short)1976303617;
				if (num != 0)
				{
				}
				num = (short)1157300224;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00035154 File Offset: 0x00033354
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0, string A_1, long A_2, int A_3, string A_4)
		{
			short num = (short)1229324289;
			if (num != 0)
			{
			}
			num = (short)1853816833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
					A_0.a(A_1, A_2, A_3, A_4);
					num = (short)1153695744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_57:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					goto IL_C8;
				}
				num = (short)1329856514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			num = (short)365821952;
			short num3 = num;
			IL_C8:
			num = (short)412392174;
			short num4 = num;
			num = (short)2003016430;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9B;
			default:
				num = (short)1139015680;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00035274 File Offset: 0x00033474
		private void a(global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_0)
		{
			short num = (short)1784348673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					A_0.j();
					num = (short)216924160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				if (!global::Motorola.Acp.PackUnpack.Ish.Packer.c.Enabled)
				{
					break;
				}
				num = (short)1080492034;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6F:
			num = (short)2039873536;
			short num3 = num;
			num = (short)2028292197;
			short num4 = num;
			num = (short)1044465765;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6F;
			default:
				num = (short)686489601;
				if (num != 0)
				{
				}
				num = (short)1836318720;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00035390 File Offset: 0x00033590
		private string a(global::Motorola.Acp.PackUnpack.Ish.ItemStructureType A_0)
		{
			int a_ = 2;
			short num = (short)1869964067;
			short num2 = num;
			num = (short)616522531;
			string result;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BD:
				num = (short)1569456128;
				short num3 = num;
				result = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc98爵쾠킢첤얦얨캪趬\ud8b0삲솴鞶튺캼쮾귀ꛂ뇄", a_);
				num = (short)1902444545;
				if (num != 0)
				{
				}
				num = (short)1153761282;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1911816192;
				if (num != 0)
				{
				}
				num = (short)411631617;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return result;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 2:
					goto IL_134;
				case 3:
					goto IL_177;
				case 4:
					num = (short)1370750979;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_15D;
				}
				IL_91:
				switch (A_0)
				{
				case global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.Composite:
					result = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\uda98캠킢첤펦첨", a_);
					num = (short)87425024;
					num4 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListHeader:
					result = global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc98爵쾠킢첤얦얨캪趬\ud8b0삲솴鞶\udeba\udcbc\udbbe꓀뇂", a_);
					num = (short)1765998597;
					num4 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Acp.PackUnpack.Ish.ItemStructureType.ListListlet:
					goto IL_BD;
				default:
					num = (short)794558468;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_134:
			IL_15D:
			return result;
			IL_177:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00035548 File Offset: 0x00033748
		private void a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)818264313;
			short num2 = num;
			num = (short)530364665;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_159:
				num = (short)1132265473;
				if (num != 0)
				{
				}
				if (A_0 is global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter)
				{
					return;
				}
				num = (short)1232273408;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1041104896;
				if (num != 0)
				{
				}
				num = (short)1918828546;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)188874758;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_159;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					continue;
				case 3:
				{
					this.u.Add(A_0);
					num = (short)1678573568;
					short num4 = num;
					num = (short)1613824004;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					num = (short)1559232513;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!(A_0 is global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter))
					{
						num = (short)848429059;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_8C:
				if (this.u == null)
				{
					break;
				}
				num = (short)318308357;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000095 RID: 149
		private global::Motorola.Acp.PackUnpack.Ish.Crc16Generator a;

		// Token: 0x04000096 RID: 150
		private global::Motorola.Acp.PackUnpack.Ish.DataExchangeManager b;

		// Token: 0x04000097 RID: 151
		private static global::System.Diagnostics.BooleanSwitch c;

		// Token: 0x04000098 RID: 152
		private const int d = 6;

		// Token: 0x04000099 RID: 153
		private const int e = 1;

		// Token: 0x0400009A RID: 154
		private const int f = 0;

		// Token: 0x0400009B RID: 155
		private const int g = 18;

		// Token: 0x0400009C RID: 156
		private const int h = 6;

		// Token: 0x0400009D RID: 157
		private const int i = 2;

		// Token: 0x0400009E RID: 158
		private long j;

		// Token: 0x0400009F RID: 159
		private const int k = 0;

		// Token: 0x040000A0 RID: 160
		private const int l = 2;

		// Token: 0x040000A1 RID: 161
		private const int m = 4;

		// Token: 0x040000A2 RID: 162
		private const int n = 6;

		// Token: 0x040000A3 RID: 163
		private const int o = 7;

		// Token: 0x040000A4 RID: 164
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Layouts.StringEncoding, global::System.Text.Encoding> p;

		// Token: 0x040000A5 RID: 165
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.PartitionType, global::Motorola.Acp.PackUnpack.Ish.PartitionIOProvider> q;

		// Token: 0x040000A6 RID: 166
		private global::System.Collections.BitArray r;

		// Token: 0x040000A7 RID: 167
		private global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.IshItemName> s;

		// Token: 0x040000A8 RID: 168
		private global::Motorola.Acp.PackUnpack.Ish.Codeplug t;

		// Token: 0x040000A9 RID: 169
		private global::System.Collections.Generic.IList<global::AcpCommonLib.IAcpField> u;

		// Token: 0x040000AA RID: 170
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Packer.a, global::System.Collections.Generic.List<global::Motorola.Acp.PackUnpack.Ish.DataExchange.b>> v;

		// Token: 0x02000034 RID: 52
		private enum a
		{
			// Token: 0x040000AC RID: 172
			a,
			// Token: 0x040000AD RID: 173
			b,
			// Token: 0x040000AE RID: 174
			c,
			// Token: 0x040000AF RID: 175
			d,
			// Token: 0x040000B0 RID: 176
			e,
			// Token: 0x040000B1 RID: 177
			f
		}
	}
}
