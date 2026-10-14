using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AcpModelTieringLib
{
	// Token: 0x0200000B RID: 11
	public class ExpParser : global::AcpModelTieringLib.IParser
	{
		// Token: 0x17000015 RID: 21
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000DE10 File Offset: 0x0000C010
		internal global::System.Collections.Generic.Dictionary<string, bool> AllOptions
		{
			set
			{
				short num = (short)560660480;
				short num2 = num;
				num = (short)1728220008;
				short num3 = num;
				num = (short)1308330856;
				switch (num3 == num)
				{
				}
				num = (short)1041498112;
				if (num != 0)
				{
				}
				num = (short)483590145;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000DF74 File Offset: 0x0000C174
		internal global::AcpModelTieringLib.TreeStack NodeStackExt
		{
			get
			{
				short num = (short)1374355456;
				short num2 = num;
				num = (short)901041780;
				short num3 = num;
				num = (short)1649593972;
				switch (num3 == num)
				{
				}
				num = (short)1355546625;
				if (num != 0)
				{
				}
				num = (short)1744371712;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1477378048;
				short num2 = num;
				num = (short)952778359;
				short num3 = num;
				num = (short)1514487415;
				switch (num3 == num)
				{
				}
				num = (short)1106771969;
				if (num != 0)
				{
				}
				num = (short)939589632;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000E024 File Offset: 0x0000C224
		internal ExpParser()
		{
			int a_ = 5;
			this.l = new global::System.Collections.Generic.Dictionary<string, bool>();
			base..ctor();
			this.a = new global::System.Text.RegularExpressions.Regex(global::AcpModelTieringLib.ErrorException.b("쮷邹钻颽뻁飃뫅铇뛉냋껑ꓗꋝ쇟\udfe1飣뷥헧쇩냫쏭\udaef\uddf1ꫳ\udef5퇷\udbf9샻샽巿⬁", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			this.c = new global::System.Text.RegularExpressions.Regex(global::AcpModelTieringLib.ErrorException.b("쮷邹钻ﷁ飃꓅釉鏋꿍﷏꣑闓ﯕ苗蟙藝뿟菡짣鳥ꧧ쟩뛫\udeed\uddef쯱꧳\udcf5퇷", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			this.b = new global::System.Text.RegularExpressions.Regex(global::AcpModelTieringLib.ErrorException.b("쮷邹钻ﷃ鯅郋诏陸藗짟", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::AcpModelTieringLib.TreeStack treeStack = new global::AcpModelTieringLib.TreeStack(100);
			global::AcpModelTieringLib.TreeStack treeStack2 = new global::AcpModelTieringLib.TreeStack(100);
			this.j = treeStack;
			this.k = treeStack2;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		public string ReMakeExpression(global::AcpModelTieringLib.ExpTreeNode Tree)
		{
			short num = (short)1571618816;
			short num2 = num;
			num = (short)1034306289;
			short num3 = num;
			num = (short)716391153;
			switch (num3 == num)
			{
			}
			num = (short)11337728;
			if (num != 0)
			{
			}
			num = (short)1479081985;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000E168 File Offset: 0x0000C368
		private void a()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			global::AcpModelTieringLib.ExpTreeNode expTreeNode;
			global::AcpModelTieringLib.ExpTreeNode expTreeNode2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_245;
				case 1:
				{
					num2 = (short)1544617984;
					short num3 = num2;
					num2 = (short)490209284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (expTreeNode._value.ToString() == global::AcpModelTieringLib.ErrorException.b("莽", a_))
					{
						num2 = (short)252248067;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 3:
				{
					num2 = (short)866123777;
					if (num2 != 0)
					{
					}
					num2 = (short)1840030459;
					short num4 = num2;
					num2 = (short)1961927419;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_245;
					default:
						num2 = (short)1649934336;
						if (num2 != 0)
						{
						}
						expTreeNode2 = this.k.b();
						num2 = (short)1448607750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (expTreeNode2._right == null)
					{
						num2 = (short)852819968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E6;
				case 5:
					if (expTreeNode2._left != null)
					{
						num2 = (short)100794369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CF;
				case 6:
					if (expTreeNode2._ndType != global::AcpModelTieringLib.ExpTreeNode.NodeType.Symbol)
					{
						num2 = (short)920649735;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1659437061;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1E4;
				}
				goto IL_39;
			}
			IL_CF:
			expTreeNode2._value = -1;
			expTreeNode._left = expTreeNode2;
			this.k.a(expTreeNode);
			return;
			IL_1E4:
			throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("낿ꟁ뛃Ʂ볇ꗉ뻋뗓ꋕ껙듛믝샟闡難觥蛧跩쳫뻭鳯鏱音鏵\ud8f7뛹駻飽瓿∁䬃瘅洇砉洋怍琏㈑礓挕欗渙㰛簝䔟ȡ䠣倥䤧䘩夫䬭ု", a_));
			IL_1E6:
			throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("낿ꟁ뛃Ʂ볇ꗉ뻋뗓ꋕ껙듛믝샟뗡難觥蛧跩쳫뻭鳯鏱音鏵\ud8f7뛹駻飽瓿∁䬃瘅洇砉洋怍琏㈑礓挕欗渙㰛簝䔟ȡ䠣倥䤧䘩夫䬭", a_));
			IL_245:
			goto IL_CF;
			IL_24A:
			expTreeNode._left = this.k.b();
			this.k.a(expTreeNode);
			return;
			IL_39:
			expTreeNode = this.j.b();
			expTreeNode._right = this.k.b();
			num2 = (short)193200130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		public bool RegisterToken(string Token, global::AcpModelTieringLib.Token tk_type)
		{
			short num = (short)517931008;
			short num2 = num;
			num = (short)1442605764;
			short num3 = num;
			num = (short)449866436;
			switch (num3 == num)
			{
			}
			num = (short)390332416;
			if (num != 0)
			{
			}
			num = (short)1231290369;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000E484 File Offset: 0x0000C684
		public int Priority(string Operator)
		{
			int a_ = 14;
			short num = (short)2019557389;
			int num2 = (int)((global::System.IntPtr)num);
			int result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2B4;
				case 1:
					num = (short)2089287694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					result = 0;
					num = (short)1335296000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(Operator == global::AcpModelTieringLib.ErrorException.b("鞼", a_)))
					{
						num = (short)1431240712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 4:
					num = (short)1649737738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2B4;
				case 6:
					goto IL_2B4;
				case 7:
					IL_187:
					num = (short)1887633411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1280835584;
					short num3 = num;
					num = (short)1189740555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_2B4;
				case 10:
					if (!(Operator == global::AcpModelTieringLib.ErrorException.b("", a_)))
					{
						num = (short)1931804684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = 3;
					num = (short)709427206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!(Operator == global::AcpModelTieringLib.ErrorException.b("銼", a_)))
					{
						num = (short)845479940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 12:
					num = (short)903938050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 14:
					if (!(Operator == global::AcpModelTieringLib.ErrorException.b("邼", a_)))
					{
						num = (short)340000775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				}
				IL_6B:
				if (!(Operator == global::AcpModelTieringLib.ErrorException.b("隼", a_)))
				{
					num = (short)246087681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_18C;
				IL_9D:
				result = 2;
				num = (short)158924809;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B4:
				num = (short)1637201660;
				short num4 = num;
				num = (short)1558689532;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_187;
				default:
					goto IL_2E9;
				}
				IL_18C:
				num = (short)604307457;
				if (num != 0)
				{
				}
				result = 1;
				num = (short)1772748805;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2E9:
			num = (short)1591410688;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000E790 File Offset: 0x0000C990
		public global::AcpModelTieringLib.ExpTreeNode ParseExpression(string exp)
		{
			int a_ = 18;
			short num = (short)285081600;
			switch (num)
			{
			default:
			{
				num = (short)878051365;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpModelTieringLib.ExpTreeNode expTreeNode;
					global::AcpModelTieringLib.Token token;
					switch (num2)
					{
					case 0:
						num = (short)2077294593;
						if (num != 0)
						{
						}
						this.j.b();
						num = (short)1517879311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						this.j.a(expTreeNode);
						num = (short)1590820878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2F6;
					case 3:
						goto IL_2F6;
					case 4:
						if (this.Priority(this.j.Top._value.ToString()) < this.Priority(expTreeNode._value.ToString()))
						{
							num = (short)1329266695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58A;
					case 5:
						num = (short)1564475427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.j.a())
						{
							num = (short)633208851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a();
						num = (short)129237026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_11C;
					case 8:
						if (!((string)this.j.Top._value == global::AcpModelTieringLib.ErrorException.b("", a_)))
						{
							num = (short)989003797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 9:
						this.j.a(expTreeNode);
						num = (short)427229209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)964689922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1907228688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.j.a(expTreeNode);
						num = (short)2049638418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpModelTieringLib.ExpTreeNode expTreeNode2;
						try
						{
							num = (short)547815426;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6E4;
								case 1:
								{
									num = (short)1351044376;
									short num3 = num;
									num = (short)958549272;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6AF;
									default:
										goto IL_732;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_67C;
									}
									continue;
								case 3:
									goto IL_6AF;
								}
								IL_67C:
								if (!expTreeNode2._symbol.Equals(global::AcpModelTieringLib.ErrorException.b("迀賂釄", a_)))
								{
									num = (short)1903558659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6E4;
								IL_6AF:
								expTreeNode2._value = this.l[expTreeNode2._symbol];
								num = (short)2072838144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6E4:
								num = (short)1174470657;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_732:
							num = (short)1768292352;
							if (num != 0)
							{
							}
							goto IL_493;
						}
						catch
						{
							throw new global::System.Exception(global::AcpModelTieringLib.ErrorException.b("铀귂껄꧆ꛈ볊ꏌꋐ꫒룔뗖뛘럚￞", a_) + expTreeNode2._symbol.ToString());
						}
						goto IL_771;
						IL_493:
						expTreeNode2._ndType = global::AcpModelTieringLib.ExpTreeNode.NodeType.Symbol;
						this.k.a(expTreeNode2);
						num = (short)1585840161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_2F6;
					case 15:
						goto IL_2F6;
					case 16:
						goto IL_771;
					case 17:
						if (this.f == global::AcpModelTieringLib.ErrorException.b("", a_))
						{
							num = (short)1995243531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2142306328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_2F6;
					case 19:
						goto IL_379;
					case 20:
						this.j.a(expTreeNode);
						num = (short)375717915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1502806020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if ((string)this.j.Top._value == global::AcpModelTieringLib.ErrorException.b("", a_))
						{
							num = (short)73793548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)294584356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_771;
					case 24:
						if (this.j.a())
						{
							num = (short)593494036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1090322454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2F6;
					case 26:
						if (!this.j.a())
						{
							num = (short)1333854240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 27:
						goto IL_2F6;
					case 28:
						if (!(global::AcpModelTieringLib.ErrorException.b("", a_) != (string)this.j.Top._value))
						{
							num = (short)2084241408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a();
						num = (short)12714007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						switch (token)
						{
						case global::AcpModelTieringLib.Token.Literal:
						{
							global::AcpModelTieringLib.ExpTreeNode expTreeNode3 = new global::AcpModelTieringLib.ExpTreeNode();
							expTreeNode3._value = this.g;
							expTreeNode3._ndType = global::AcpModelTieringLib.ExpTreeNode.NodeType.Literal;
							this.k.a(expTreeNode3);
							num = (short)739049512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::AcpModelTieringLib.Token.Symbol:
						{
							num = (short)1536950272;
							short num4 = num;
							global::AcpModelTieringLib.ExpTreeNode expTreeNode2 = new global::AcpModelTieringLib.ExpTreeNode();
							expTreeNode2._symbol = this.e;
							num = (short)1231486989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::AcpModelTieringLib.Token.Operator:
							expTreeNode = new global::AcpModelTieringLib.ExpTreeNode();
							expTreeNode._value = this.f;
							expTreeNode._ndType = global::AcpModelTieringLib.ExpTreeNode.NodeType.Operator;
							num = (short)1893466142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1599602698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 30:
						if (this.f == global::AcpModelTieringLib.ErrorException.b("", a_))
						{
							num = (short)462880769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)588578833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (this.NextToken() == global::AcpModelTieringLib.Token.Eof)
						{
							num = (short)578420741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 32:
						num = (short)1756889096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_2F6;
					case 34:
						goto IL_337;
					case 35:
						goto IL_337;
					case 36:
						if (this.Priority(this.j.Top._value.ToString()) < this.Priority(expTreeNode._value.ToString()))
						{
							num = (short)1977024521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58A;
					case 37:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 38:
						goto IL_5F5;
					case 39:
						goto IL_117;
					case 40:
						goto IL_2F6;
					}
					IL_F2:
					if (!this.a(exp))
					{
						num = (short)805109799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.i = exp;
					this.NextToken();
					num = (short)536543270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C:
					this.j.a(expTreeNode);
					num = (short)1450311683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					num = (short)2082340895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_337:
					num = (short)57344006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58A:
					this.a();
					num = (short)2022375450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F5:
					token = this.d;
					num = (short)1828257821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_771:
					num = (short)907214876;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("軀돂ꃄ뗆꣈뿊ꋌ뷎ꋐ﷔뛘꧚﷜쇠苢韤苦짨藪苬鯮퇰鋲致ퟶ跸鏺飼\udffe猀樂戄漆紈⬊紌挎瀐瀒瀔搖", a_));
				IL_379:
				return this.k.Top;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000F100 File Offset: 0x0000D300
		public void Clear()
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)322830336;
					short num2 = num;
					switch (num3)
					{
					case 0:
						goto IL_178;
					case 1:
						return;
					case 2:
						if (this.k.a())
						{
							num = (short)686948353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.k.b();
						num = (short)519045121;
						if (num != 0)
						{
						}
						num = (short)1819475975;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1239678981;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_178;
					case 5:
						goto IL_135;
					case 6:
					{
						num = (short)1779627912;
						short num4 = num;
						num = (short)1492187016;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						default:
							num = (short)1127677952;
							if (num != 0)
							{
							}
							if (this.j.a())
							{
								num = (short)756088835;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.j.b();
							num = (short)621215748;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_135;
					}
					goto IL_59;
					IL_135:
					num = (short)1782775810;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_178:
					num = (short)1226113030;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			IL_59:
			this.d = global::AcpModelTieringLib.Token.InValid;
			this.e = null;
			this.f = null;
			this.g = 0.0;
			this.h = 0;
			this.i = null;
			IL_8B:
			num = (short)1698824192;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000F314 File Offset: 0x0000D514
		private bool a(string A_0)
		{
			short num = (short)1137770496;
			short num2 = num;
			string[] array = A_0.Split(new char[]
			{
				'('
			});
			string[] array2 = A_0.Split(new char[]
			{
				')'
			});
			if (array.Length == array2.Length)
			{
				num = (short)1350974057;
				short num3 = num;
				num = (short)1051736681;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)440008705;
					if (num != 0)
					{
					}
					num = (short)1956577280;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		protected global::AcpModelTieringLib.Token NextToken()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			global::System.Text.RegularExpressions.Match match;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (match.Length != 0)
					{
						num2 = (short)159383557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					match = this.c.Match(this.i);
					num2 = (short)1265238019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_27B;
				case 2:
					this.e = match.Groups[1].Value;
					this.h += match.Length;
					this.i = this.i.Substring(match.Length);
					this.d = global::AcpModelTieringLib.Token.Symbol;
					num2 = (short)1863974919;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (match.Length != 0)
					{
						num2 = (short)184811522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					match = this.b.Match(this.i);
					num2 = (short)217055240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					this.g = (double)((float)double.Parse(match.Groups[1].Value));
					this.h += match.Length;
					this.i = this.i.Substring(match.Length);
					this.d = global::AcpModelTieringLib.Token.Literal;
					num2 = (short)1055653897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_F9;
				case 6:
					goto IL_258;
				case 7:
					goto IL_1CA;
				case 8:
					if (match.Length != 0)
					{
						num2 = (short)502857732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d = global::AcpModelTieringLib.Token.Eof;
					num2 = (short)1457979393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_166;
				}
				goto IL_38;
			}
			IL_F9:
			num2 = (short)1259995136;
			short num3 = num2;
			this.f = match.Groups[1].Value;
			this.h += match.Length;
			this.i = this.i.Substring(match.Length);
			this.d = global::AcpModelTieringLib.Token.Operator;
			goto IL_240;
			IL_166:
			IL_1CA:
			IL_258:
			IL_27B:
			return this.d;
			IL_38:
			num2 = (short)2083509492;
			short num4 = num2;
			num2 = (short)1646843124;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_240:
				num2 = (short)961675270;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2073165825;
				if (num2 != 0)
				{
				}
				num2 = (short)969211904;
				if (num2 != 0)
				{
				}
				match = this.a.Match(this.i);
				num2 = (short)2074345472;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000026 RID: 38
		private global::System.Text.RegularExpressions.Regex a;

		// Token: 0x04000027 RID: 39
		private global::System.Text.RegularExpressions.Regex b;

		// Token: 0x04000028 RID: 40
		private global::System.Text.RegularExpressions.Regex c;

		// Token: 0x04000029 RID: 41
		private global::AcpModelTieringLib.Token d;

		// Token: 0x0400002A RID: 42
		private string e;

		// Token: 0x0400002B RID: 43
		private string f;

		// Token: 0x0400002C RID: 44
		private double g;

		// Token: 0x0400002D RID: 45
		private int h;

		// Token: 0x0400002E RID: 46
		private string i;

		// Token: 0x0400002F RID: 47
		private global::AcpModelTieringLib.TreeStack j;

		// Token: 0x04000030 RID: 48
		private global::AcpModelTieringLib.TreeStack k;

		// Token: 0x04000031 RID: 49
		private global::System.Collections.Generic.Dictionary<string, bool> l;
	}
}
