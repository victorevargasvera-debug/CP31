using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000083 RID: 131
	public class XcmpSuperBundle : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001C60C File Offset: 0x0001A80C
		private int NumberOfReplies
		{
			get
			{
				short num = (short)915679637;
				short num2 = num;
				num = (short)924068245;
				switch (num2 == num)
				{
				}
				num = (short)1565130752;
				if (num != 0)
				{
				}
				num = (short)1503985665;
				if (num != 0)
				{
				}
				num = (short)20840448;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		private bool ContinueIfFail
		{
			get
			{
				short num = (short)457244673;
				if (num != 0)
				{
				}
				num = (short)181034485;
				short num2 = num;
				num = (short)940334581;
				switch (num2 == num)
				{
				}
				num = (short)1680146432;
				if (num != 0)
				{
				}
				num = (short)270073856;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001C770 File Offset: 0x0001A970
		public XcmpSuperBundle(bool continueIfFail)
		{
			this.a = continueIfFail;
			base.Opcode = 46;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		public bool AddRcmpMessage(global::Motorola.Common.Communication.RcmpBaseMessage rcmpMessage)
		{
			short num = (short)21299200;
			short num2 = num;
			num = (short)1879597289;
			short num3 = num;
			num = (short)1012752617;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)368836608;
				if (num != 0)
				{
				}
				if (rcmpMessage == null)
				{
					num = (short)2022899713;
					if (num != 0)
					{
					}
					return false;
				}
				break;
			}
			this.c.Add(rcmpMessage);
			return true;
		}

		// Token: 0x17000099 RID: 153
		public global::Motorola.Common.Communication.RcmpBaseMessage this[int index]
		{
			get
			{
				short num = (short)325702892;
				short num2 = num;
				num = (short)349099244;
				switch (num2 == num)
				{
				}
				num = (short)1103233024;
				if (num != 0)
				{
				}
				num = (short)1140588545;
				if (num != 0)
				{
				}
				num = (short)1301872640;
				short num3 = num;
				return this.c[index];
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001C910 File Offset: 0x0001AB10
		public int ChildCount
		{
			get
			{
				short num = (short)1796997121;
				if (num != 0)
				{
				}
				num = (short)969491842;
				short num2 = num;
				num = (short)1883522434;
				switch (num2 == num)
				{
				}
				num = (short)147324928;
				if (num != 0)
				{
				}
				num = (short)1309802496;
				short num3 = num;
				return this.c.Count;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0001CA70 File Offset: 0x0001AC70
		private global::Motorola.Common.Communication.RcmpReplyResult mReplyResult
		{
			get
			{
				short num = (short)257567423;
				short num2 = num;
				num = (short)1033644735;
				switch (num2 == num)
				{
				}
				num = (short)770506753;
				if (num != 0)
				{
				}
				num = (short)281280512;
				if (num != 0)
				{
				}
				num = (short)1879965696;
				short num3 = num;
				return base.ReplyResult;
			}
			set
			{
				short num = (short)1786129934;
				short num2 = num;
				num = (short)970534414;
				switch (num2 == num)
				{
				}
				num = (short)287440897;
				if (num != 0)
				{
				}
				num = (short)152371200;
				if (num != 0)
				{
				}
				num = (short)1298661376;
				short num3 = num;
				base.ReplyResult = value;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001CB24 File Offset: 0x0001AD24
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 19;
			short num = (short)604176384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1782382593;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				for (;;)
				{
					IL_57:
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (buffer.Length < offset + num3)
						{
							num = (short)2076180483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buffer[offset] = (byte)(base.Opcode >> 8);
						buffer[offset + 1] = (byte)(base.Opcode & 255);
						buffer[offset + 2] = (byte)this.c.Count;
						num = (short)1267007489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						buffer[offset + 3] = (this.a ? 1 : 0);
						int num4 = offset + 4;
						int num5 = 0;
						num = (short)2015559680;
						short num6 = num;
						num = (short)1200750596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1A6;
					case 3:
						goto IL_102;
					case 4:
						goto IL_166;
					case 5:
					{
						int num5;
						if (num5 >= this.c.Count)
						{
							num = (short)1119158274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						int num7 = this.c[num5].BuildCommandMessage(buffer, num4 + 2);
						buffer[num4] = (byte)(num7 / 256 & 255);
						buffer[num4 + 1] = (byte)(num7 & 255);
						num4 += 2 + num7;
						int num3;
						num3 += 2 + num7;
						num5++;
						num = (short)1618477062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_166;
					}
					goto IL_7A;
					IL_166:
					num = (short)166526981;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_102:
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﶞ풠얢쎤슦\udba8薪쪮\udfb0풲솴\udfb6馸좺햼킾듀꿂ꇄꯈ껊껎ꗐ맔닖룘꣚꧜￞跠苢韤胦賨駪췬鯮駰鋲鯴ퟶ雸鷺鯼賾搀眂┄Ⰶ⤈㼊", a_));
				IL_7A:
				num = (short)1077403676;
				short num8 = num;
				num = (short)579330076;
				switch ((num8 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1A6:
					base._myCommandBuffer = buffer;
					int num3;
					return num3;
				}
				default:
				{
					num = (short)175177728;
					if (num != 0)
					{
					}
					int num3 = 4;
					num = (short)440205312;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 2;
			short num = (short)1865678848;
			switch (num)
			{
			default:
			{
				num = (short)1495072780;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_23C;
					case 1:
						try
						{
							byte a_2;
							this.mReplyResult = (global::Motorola.Common.Communication.RcmpReplyResult)a_2;
							goto IL_B1;
						}
						catch (global::System.ArgumentException)
						{
							this.mReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Undefined;
							goto IL_B1;
						}
						goto IL_2DB;
						IL_B1:
						num = (short)365690882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)834797568;
						short num3 = num;
						if (this.mReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.OpcodeNotSupported)
						{
							num = (short)1218379787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					}
					case 3:
						if (num4 >= this.b)
						{
							num = (short)1740505092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 4:
						return;
					case 5:
						goto IL_27D;
					case 6:
						goto IL_A4;
					case 7:
						goto IL_27D;
					case 8:
					{
						num = (short)40894465;
						if (num != 0)
						{
						}
						ushort num5 = (ushort)((int)replyBuffer[offset] * 256 + (int)replyBuffer[offset + 1]);
						ushort num6 = base.Opcode | global::Motorola.Common.Communication.r.a();
						if (num5 == num6)
						{
							byte a_2 = replyBuffer[offset + 2];
							num = (short)165543937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)646137291;
						short num7 = num;
						num = (short)1594049995;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_125;
						default:
							num = (short)655097856;
							if (num != 0)
							{
							}
							num = (short)1817444352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						if (length == 3)
						{
							num = (short)1462501386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 10:
						goto IL_278;
					case 11:
						num = (short)1854406665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					IL_82:
					if (replyBuffer.Length < offset + length)
					{
						num = (short)1436155910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)354680840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_125:
					int num9;
					int num8 = (int)replyBuffer[num9] * 256 + (int)replyBuffer[num9 + 1];
					this.c[num4].DecodeReplyMessage(replyBuffer, num9 + 2, num8);
					num9 += 2 + num8;
					num4++;
					num = (short)1537540103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27D:
					num = (short)559022083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FD:
					this.b = (int)replyBuffer[offset + 3];
					num9 = offset + 4;
					num4 = 0;
					num = (short)1198587909;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A4:
				goto IL_2DB;
				IL_23C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidReplyOpcode);
				IL_278:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SuperBundleNotSupported);
				IL_2DB:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("몙\uda9f잡蒣쾥\udba7誩\udfab쎭톯\udeb1\ud8b3펵쪷骹좻횽ꆿ곁Ꟈ곉꫋뷍뗏ꛑ﷕뛙맛냝蟟雡賣쿥", a_));
			}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0001D11C File Offset: 0x0001B31C
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1423179777;
				if (num != 0)
				{
				}
				num = (short)995426304;
				short num2 = num;
				int num3 = global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = this.c.GetEnumerator())
				{
					num = (short)2039939076;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_16E;
						case 1:
							num = (short)748158976;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1344733185;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage = enumerator.Current;
							num3 += 2 + ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage).MaxMessageSize;
							num = (short)42467331;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							num = (short)548686141;
							short num5 = num;
							num = (short)702236989;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_16E;
							default:
								num = (short)1869414400;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_9E;
							}
							continue;
						}
						IL_11A:
						num = (short)1354039298;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E:
						goto IL_11A;
					}
					IL_16E:;
				}
				return num3;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
		public static int HeaderSize
		{
			get
			{
				short num = (short)285640985;
				short num2 = num;
				num = (short)725846297;
				switch (num2 == num)
				{
				}
				num = (short)2143813633;
				if (num != 0)
				{
				}
				num = (short)728629248;
				if (num != 0)
				{
				}
				num = (short)553254912;
				short num3 = num;
				return 4;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001D370 File Offset: 0x0001B570
		public override string ToString()
		{
			int a_ = 18;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("邟\udfa1貣잧쒩\ud8ab잭\udeaf잱톳ﾵ\udeb7ﲹ\uddbbힽ겿￁뿃뗇迋ꛍ맏뻑냓闕럗꿙닛ꫝ\udddf駡훣鯥쓧ꓩ駫菭鋯韱蛳맵黷꣹駻軽泿欁愃甅㔇焉㼋猍㰏䀑焓昕琗挙丛笝匟圡䠣別ᔧ儩ᠫ匭᤯㠱", a_), new object[]
			{
				base.GetType().Name,
				this.ContinueIfFail,
				this.ChildCount,
				this.NumberOfReplies,
				this.mReplyResult
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>.Enumerator enumerator = this.c.GetEnumerator();
			short num;
			try
			{
				num = (short)1871118340;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_195;
					case 1:
						num = (short)1192427520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1462304769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage = enumerator.Current;
						stringBuilder.Append('\t');
						stringBuilder.AppendLine(rcmpBaseMessage.ToString());
						num = (short)1611071491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1711483540;
						short num3 = num;
						num = (short)1414408852;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_195;
						default:
							num = (short)1831993344;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_BC;
						}
						continue;
					}
					IL_141:
					num = (short)1247150082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC:
					goto IL_141;
				}
				IL_195:;
			}
			finally
			{
				num = (short)1449525249;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)1111949312;
			short num4 = num;
			return stringBuilder.ToString();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001D594 File Offset: 0x0001B794
		public override ushort CalculateMessageCRC16(ref uint checksum, byte[] inputData, int start, int length)
		{
			short num = (short)209584128;
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
				int num4;
				int num5;
				int num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_19A;
					case 1:
					{
						num = (short)1073427985;
						short num3 = num;
						num = (short)1554593297;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)611188736;
							if (num != 0)
							{
							}
							if (num4 >= num5)
							{
								num = (short)1966080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num6 = (int)inputData[num7] * 256 + (int)inputData[num7 + 1];
							base.CalculateMessageCRC16(ref checksum, inputData, num7 + 2, num6);
							num7 += 2 + num6;
							num = (short)1225392130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						if (num7 > start + length)
						{
							num = (short)13238275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)882769924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_115;
					case 4:
						goto IL_117;
					case 5:
					{
						num = (short)538050560;
						short num8 = num;
						goto IL_117;
					}
					}
					goto IL_46;
					IL_117:
					num = (short)1689387009;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_115:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.MessageCRC16CalculateOverflow);
				IL_19A:
				num = (short)896270337;
				if (num != 0)
				{
				}
				return (ushort)checksum;
				IL_46:
				num5 = (int)inputData[2];
				num7 = start + 4;
				num4 = 0;
				num = (short)551026693;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000293 RID: 659
		private bool a;

		// Token: 0x04000294 RID: 660
		private int b;

		// Token: 0x04000295 RID: 661
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> c = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
	}
}
