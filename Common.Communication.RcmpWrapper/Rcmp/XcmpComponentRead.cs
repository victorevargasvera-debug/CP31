using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000065 RID: 101
	public class XcmpComponentRead : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00016AD4 File Offset: 0x00014CD4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00016B84 File Offset: 0x00014D84
		public ushort NumberOfFiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)814091551;
				short num2 = num;
				num = (short)1701448991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)461242368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395785729;
				if (num != 0)
				{
				}
				num = (short)1448148992;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1800275772;
				short num2 = num;
				num = (short)816252732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258342912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573060609;
				if (num != 0)
				{
				}
				num = (short)196214784;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00016C38 File Offset: 0x00014E38
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00016CE8 File Offset: 0x00014EE8
		public byte[] Information
		{
			get
			{
				short num = (short)1394727631;
				short num2 = num;
				num = (short)1975900879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012610560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026831873;
				if (num != 0)
				{
				}
				num = (short)2065891328;
				if (num != 0)
				{
				}
				return this.h;
			}
			private set
			{
				short num = (short)449439256;
				short num2 = num;
				num = (short)476964376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494417408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338886656;
				if (num != 0)
				{
				}
				num = (short)137035777;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00016D9C File Offset: 0x00014F9C
		public XcmpComponentRead(ushort componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, byte listType, byte[] list)
		{
			base.Opcode = 270;
			this.a = componentType;
			this.b = componentInstance;
			this.c = (byte)level;
			this.d = listType;
			this.f = (ushort)((list == null) ? 0 : list.Length);
			this.e = list;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00016DF8 File Offset: 0x00014FF8
		public XcmpComponentRead(ushort componentType, ushort componentInstance, global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.Level level, byte listType)
		{
			base.Opcode = 270;
			this.a = componentType;
			this.b = componentInstance;
			this.c = (byte)level;
			this.d = listType;
			this.f = 0;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00016E3C File Offset: 0x0001503C
		public static int RequestHeaderLength
		{
			get
			{
				short num = (short)1780798507;
				short num2 = num;
				num = (short)302502955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)237568000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807206912;
				if (num != 0)
				{
				}
				num = (short)128319489;
				if (num != 0)
				{
				}
				return 10;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00016EE4 File Offset: 0x000150E4
		public static uint GetListItemLength(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStruct)
		{
			short num = (short)1299054593;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num2;
			uint result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
				{
					num = (short)1542015229;
					short num3 = num;
					num = (short)1813203197;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1156382720;
						if (num != 0)
						{
						}
						num = (short)477036548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					result = 0U;
					num = (short)956497922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1413480448;
					short num4 = num;
					switch (listStruct)
					{
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes:
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions:
						result = 2U;
						num = (short)2016018435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshStartEndPairs:
					case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds:
						result = 4U;
						num = (short)1521025025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)215351296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_50;
			}
			return result;
			IL_50:
			result = 0U;
			num = (short)1211039749;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00017074 File Offset: 0x00015274
		public static byte[] ConvertListItemToBytes(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure listStruct, global::System.Collections.IEnumerable listItems)
		{
			short num = (short)1023059193;
			short num2 = num;
			num = (short)477013241;
			global::System.Collections.Generic.List<byte> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1041170432;
				if (num != 0)
				{
				}
				num = (short)1093533696;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)188416001;
					if (num != 0)
					{
					}
					num = (short)567869440;
					short num4 = num;
					list = new global::System.Collections.Generic.List<byte>();
					byte[] array = null;
					try
					{
						global::System.Collections.IEnumerator enumerator = listItems.GetEnumerator();
						try
						{
							num = (short)455344131;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 1:
									if (global::System.BitConverter.IsLittleEndian)
									{
										num = (short)115408908;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_250;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_13A;
									}
									continue;
								case 4:
									num = (short)1240530955;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									global::System.Array.Reverse(array);
									num = (short)1409810439;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1534853136;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)1173487630;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1EE;
								case 8:
								{
									object obj;
									global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair xcmpComponentTypeIdPair = (global::Motorola.Common.Communication.Rcmp.XcmpComponentTypeIdPair)obj;
									array = global::System.BitConverter.GetBytes(xcmpComponentTypeIdPair.Type);
									if (global::System.BitConverter.IsLittleEndian)
									{
										global::System.Array.Reverse(array);
									}
									list.AddRange(array);
									array = global::System.BitConverter.GetBytes(xcmpComponentTypeIdPair.ID);
									num = (short)287309834;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_3A4;
								case 10:
									if (global::System.BitConverter.IsLittleEndian)
									{
										num = (short)759234565;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EE;
								case 11:
									array = null;
									num = (short)2081947648;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									global::System.Array.Reverse(array);
									num = (short)827523085;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_250;
								case 14:
									switch (listStruct)
									{
									case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypes:
									case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshPartitions:
									{
										object obj;
										array = global::System.BitConverter.GetBytes((ushort)obj);
										num = (short)805306369;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshStartEndPairs:
										array = null;
										num = (short)1667694607;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ListStructure.ListofIshTypeIds:
										num = (short)570294280;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)622002180;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 16:
									num = (short)1733492745;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_13A;
								IL_1EE:
								list.AddRange(array);
								num = (short)1222508546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_210:
								num = (short)114556934;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_13A:
								goto IL_210;
								IL_250:
								list.AddRange(array);
								num = (short)103743505;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3A4:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3C3;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3B0:
								switch (num3)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)608501762;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_41B;
								case 1:
									goto IL_419;
								case 2:
									disposable.Dispose();
									num = (short)725549057;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3C3;
							}
							IL_419:
							IL_41B:
							break;
							IL_3C3:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)88539136;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_3B0;
						}
					}
					catch (global::System.InvalidCastException systemException)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument, systemException);
					}
					break;
				}
				}
				break;
			}
			}
			return list.ToArray();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000174E4 File Offset: 0x000156E4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1973111303;
			short num2 = num;
			num = (short)2031700487;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1940848640;
				short num3 = num;
				num = (short)126091265;
				if (num != 0)
				{
				}
				num = (short)841809920;
				if (num != 0)
				{
				}
				if (this.e == null)
				{
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						this.a,
						this.b,
						this.c,
						this.d,
						this.f
					});
				}
				break;
			}
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d,
				this.f,
				this.e
			});
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00017664 File Offset: 0x00015864
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				int num4;
				switch (num)
				{
				case 0:
					if (this.h == null)
					{
						num2 = (short)1710882822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)495058945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_116;
				case 2:
					num2 = (short)1590362113;
					if (num2 != 0)
					{
					}
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1693581315;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1743519744;
					short num3 = num2;
					this.NumberOfFiles = (ushort)((int)replyBuffer[offset + 4] | (int)replyBuffer[offset + 3] << 8);
					num4 = length - 5;
					num2 = (short)792788992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_18C;
				case 5:
					return;
				case 6:
				{
					this.h = new byte[num4];
					num2 = (short)1419394520;
					short num5 = num2;
					num2 = (short)1011170776;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
						num2 = (short)1632108544;
						if (num2 != 0)
						{
						}
						num2 = (short)1204289543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					goto IL_18C;
				case 8:
					global::System.Array.Resize<byte>(ref this.h, num4);
					num2 = (short)831324164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_116:
				if (num4 != this.h.Length)
				{
					num2 = (short)956563464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_18C:
				global::System.Array.Copy(replyBuffer, offset + 5, this.h, 0, num4);
				num2 = (short)20447237;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1098186754;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001D2 RID: 466
		public const int InactiveComponentInstance = 2;

		// Token: 0x040001D3 RID: 467
		private ushort a;

		// Token: 0x040001D4 RID: 468
		private ushort b;

		// Token: 0x040001D5 RID: 469
		private byte c;

		// Token: 0x040001D6 RID: 470
		private byte d;

		// Token: 0x040001D7 RID: 471
		private byte[] e;

		// Token: 0x040001D8 RID: 472
		private ushort f;

		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort g;

		// Token: 0x040001DA RID: 474
		private byte[] h;

		// Token: 0x02000066 RID: 102
		public enum Level : byte
		{
			// Token: 0x040001DC RID: 476
			GetVersion,
			// Token: 0x040001DD RID: 477
			GetGlobalChange,
			// Token: 0x040001DE RID: 478
			GetTypeChanges,
			// Token: 0x040001DF RID: 479
			GetItemChanges,
			// Token: 0x040001E0 RID: 480
			ReadComponentData,
			// Token: 0x040001E1 RID: 481
			ReadDifferentialData
		}

		// Token: 0x02000067 RID: 103
		[global::System.Flags]
		public enum ComponentType : ushort
		{
			// Token: 0x040001E3 RID: 483
			None = 0,
			// Token: 0x040001E4 RID: 484
			IshCodeplug = 1,
			// Token: 0x040001E5 RID: 485
			NonIshCodeplug = 2,
			// Token: 0x040001E6 RID: 486
			Arm = 3,
			// Token: 0x040001E7 RID: 487
			Dsp = 4,
			// Token: 0x040001E8 RID: 488
			Mace = 5,
			// Token: 0x040001E9 RID: 489
			CouP = 6,
			// Token: 0x040001EA RID: 490
			LanguagePack = 7,
			// Token: 0x040001EB RID: 491
			LocalLangPack = 8,
			// Token: 0x040001EC RID: 492
			LangSetupInfo = 9,
			// Token: 0x040001ED RID: 493
			ToneFile = 10,
			// Token: 0x040001EE RID: 494
			RoamingLog = 11,
			// Token: 0x040001EF RID: 495
			ErrorLog = 12,
			// Token: 0x040001F0 RID: 496
			ControlHeadFW = 14,
			// Token: 0x040001F1 RID: 497
			ControlHeadCplg = 15,
			// Token: 0x040001F2 RID: 498
			EncryptionKey = 16,
			// Token: 0x040001F3 RID: 499
			CurrentConfig = 17,
			// Token: 0x040001F4 RID: 500
			PossibleConfig = 18,
			// Token: 0x040001F5 RID: 501
			Pictures = 19
		}

		// Token: 0x02000068 RID: 104
		[global::System.Flags]
		public enum ListMode : byte
		{
			// Token: 0x040001F7 RID: 503
			CompleteList = 0,
			// Token: 0x040001F8 RID: 504
			NewList = 64,
			// Token: 0x040001F9 RID: 505
			ListContinue = 128,
			// Token: 0x040001FA RID: 506
			ListEnds = 192
		}

		// Token: 0x02000069 RID: 105
		public enum ListStructure : byte
		{
			// Token: 0x040001FC RID: 508
			NoList,
			// Token: 0x040001FD RID: 509
			ListofIshTypes,
			// Token: 0x040001FE RID: 510
			ListofIshStartEndPairs,
			// Token: 0x040001FF RID: 511
			ListofIshTypeIds,
			// Token: 0x04000200 RID: 512
			ListofIshPartitions
		}
	}
}
