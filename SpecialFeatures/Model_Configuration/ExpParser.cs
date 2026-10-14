using System;
using System.Text.RegularExpressions;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B6 RID: 182
	public class ExpParser : global::SpecialFeatures.Model_Configuration.IParser
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x000F4F98 File Offset: 0x000F3198
		public ExpParser()
		{
			int a_ = 18;
			base..ctor();
			this.a = new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮔쮖놚떜릞螠\udfa2捻\udba6힪톬鎮貰쾲讴誶언蚺肼쎾ﻂ맄鳆里﯐ﳒ诔ￖ﫚볠쫢", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			this.c = new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮔쮖놚떜쎞負鲢捻얦莨캮鲰즲骶隼黀ꋂ뷆裈韌ￎﳐ裔﷖", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			this.b = new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮔쮖놚떜쒞醠躢鲤益芨莪膮莲颴躶邺钼肾", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::SpecialFeatures.Model_Configuration.TreeStack treeStack = new global::SpecialFeatures.Model_Configuration.TreeStack(100);
			global::SpecialFeatures.Model_Configuration.TreeStack treeStack2 = new global::SpecialFeatures.Model_Configuration.TreeStack(100);
			this.j = treeStack;
			this.k = treeStack2;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000F5020 File Offset: 0x000F3220
		public string ReMakeExpression(global::SpecialFeatures.Model_Configuration.ExpTreeNode Tree)
		{
			short num = (short)592773121;
			if (num != 0)
			{
			}
			num = (short)999227392;
			short num2 = num;
			num = (short)352752944;
			short num3 = num;
			num = (short)2051708208;
			switch (num3 == num)
			{
			}
			num = (short)1178337280;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000F50CC File Offset: 0x000F32CC
		private void a()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			global::SpecialFeatures.Model_Configuration.ExpTreeNode expTreeNode;
			short num2;
			global::SpecialFeatures.Model_Configuration.ExpTreeNode expTreeNode2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (expTreeNode._right == null)
					{
						goto IL_22E;
					}
					goto IL_1BF;
				case 1:
				{
					expTreeNode = this.k.Pop();
					num2 = (short)1640230558;
					short num3 = num2;
					num2 = (short)227077790;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_22E;
					default:
						num2 = (short)1960640512;
						if (num2 != 0)
						{
						}
						num2 = (short)1738932226;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)356581376;
					short num4 = num2;
					if (expTreeNode._ndType != global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Symbol)
					{
						num2 = (short)1344864263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)175112196;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_245;
				case 4:
					if (expTreeNode._left != null)
					{
						num2 = (short)1072103430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A6;
				case 5:
					if (expTreeNode2._value.ToString() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꾑", a_))
					{
						num2 = (short)1053556737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 6:
					num2 = (short)1192493056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1BD;
				}
				goto IL_39;
				IL_22E:
				num2 = (short)1241579523;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A6:
			expTreeNode._value = -1;
			expTreeNode2._left = expTreeNode;
			this.k.Push(expTreeNode2);
			return;
			IL_1BD:
			num2 = (short)425197569;
			if (num2 != 0)
			{
			}
			throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91ﮙ튟芡馣蚥즧\udea9貫\udaad\ud8afힱ钳솵쪷햹튻\ud9bd鋁ꣃꟅꯇ꿉苍뗏듑ꃓ韗꫙맛곝臟賡胣웥藧鿩鿫髭탯郱釳훵铷賹鷻鋽痿朁␃", a_));
			IL_1BF:
			throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91ﮙ튟芡馣蚥즧\udea9貫\udaad\ud8afힱ钳쪷햹튻\ud9bd鋁ꣃꟅꯇ꿉苍뗏듑ꃓ韗꫙맛곝臟賡胣웥藧鿩鿫髭탯郱釳훵铷賹鷻鋽痿朁", a_));
			IL_245:
			goto IL_A6;
			IL_24A:
			expTreeNode2._left = this.k.Pop();
			this.k.Push(expTreeNode2);
			return;
			IL_39:
			expTreeNode2 = this.j.Pop();
			expTreeNode2._right = this.k.Pop();
			num2 = (short)532414469;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000F5340 File Offset: 0x000F3540
		public bool RegisterToken(string Token, global::SpecialFeatures.Model_Configuration.Token tk_type)
		{
			short num = (short)196798423;
			short num2 = num;
			num = (short)546105303;
			switch (num2 == num)
			{
			default:
			{
				num = (short)370409472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)328728577;
			if (num != 0)
			{
			}
			num = (short)1350434816;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000F53E8 File Offset: 0x000F35E8
		public int Priority(string Operator)
		{
			int a_ = 7;
			short num = (short)158138378;
			int num2 = (int)((global::System.IntPtr)num);
			int result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!(Operator == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖉ", a_)))
					{
						num = (short)2063400964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 1:
					num = (short)334299138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1061093377;
					if (num != 0)
					{
					}
					result = 0;
					num = (short)1924988931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_302;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					if (!(Operator == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂉ", a_)))
					{
						num = (short)570359819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 8:
					return result;
				case 9:
				{
					num = (short)1769603072;
					short num3 = num;
					num = (short)1552613383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 11:
					num = (short)1058799616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1378091021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!(Operator == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꞉", a_)))
					{
						num = (short)411959305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
				case 14:
				{
					if (!(Operator == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풉", a_)))
					{
						num = (short)767361025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = 3;
					num = (short)1518345714;
					short num4 = num;
					num = (short)1995251186;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_302;
					default:
						num = (short)1419509760;
						if (num != 0)
						{
						}
						num = (short)76480517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_6A:
				if (!(Operator == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆉ", a_)))
				{
					num = (short)2134704140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_22B;
				IL_9E:
				result = 2;
				num = (short)1150222342;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22B:
				result = 1;
				num = (short)348913672;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_302:
				num = (short)1800667150;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000F5700 File Offset: 0x000F3900
		public global::SpecialFeatures.Model_Configuration.ExpTreeNode ParseExpression(string exp)
		{
			int a_ = 6;
			short num = (short)168558592;
			switch (num)
			{
			default:
			{
				num = (short)346488838;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::SpecialFeatures.Model_Configuration.ExpTreeNode expTreeNode;
					global::SpecialFeatures.Model_Configuration.Token token;
					switch (num2)
					{
					case 0:
						goto IL_36A;
					case 1:
						goto IL_71E;
					case 2:
						goto IL_45F;
					case 3:
						goto IL_464;
					case 4:
						goto IL_5B5;
					case 5:
					{
						num = (short)1529986397;
						short num3 = num;
						num = (short)140229981;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_117;
						default:
							num = (short)498794496;
							if (num != 0)
							{
							}
							num = (short)785711115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_ED;
						}
						continue;
					case 7:
						if (this.f == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂈ", a_))
						{
							num = (short)851705882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2075721767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_36A;
					case 9:
						goto IL_36A;
					case 10:
						if (!(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆈ", a_) != (string)this.j.Top._value))
						{
							num = (short)219676696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a();
						num = (short)1130758161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3F7;
					case 12:
						if (this.Priority(this.j.Top._value.ToString()) < this.Priority(expTreeNode._value.ToString()))
						{
							num = (short)359530500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					case 13:
						switch (token)
						{
						case global::SpecialFeatures.Model_Configuration.Token.Literal:
						{
							global::SpecialFeatures.Model_Configuration.ExpTreeNode expTreeNode2 = new global::SpecialFeatures.Model_Configuration.ExpTreeNode();
							expTreeNode2._value = this.g;
							expTreeNode2._ndType = global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Literal;
							this.k.Push(expTreeNode2);
							num = (short)643891238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::SpecialFeatures.Model_Configuration.Token.Symbol:
						{
							global::SpecialFeatures.Model_Configuration.ExpTreeNode expTreeNode3 = new global::SpecialFeatures.Model_Configuration.ExpTreeNode();
							expTreeNode3._symbol = this.e;
							expTreeNode3._ndType = global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Symbol;
							this.k.Push(expTreeNode3);
							num = (short)1326841883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::SpecialFeatures.Model_Configuration.Token.Operator:
							expTreeNode = new global::SpecialFeatures.Model_Configuration.ExpTreeNode();
							expTreeNode._value = this.f;
							expTreeNode._ndType = global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Operator;
							num = (short)609288210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)975634452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						this.j.Push(expTreeNode);
						num = (short)742588447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_112;
					case 16:
						goto IL_36A;
					case 17:
						goto IL_464;
					case 18:
						if (this.f == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆈ", a_))
						{
							num = (short)743833619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)576913415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						this.j.Push(expTreeNode);
						num = (short)1202323465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1141768200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_3F7;
					case 22:
						num = (short)1131216908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if ((string)this.j.Top._value == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆈ", a_))
						{
							num = (short)2081751077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1540423709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						this.j.Pop();
						num = (short)783220770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_36A;
					case 26:
						num = (short)1775501315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_36A;
					case 28:
						num = (short)1630666782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (this.Priority(this.j.Top._value.ToString()) < this.Priority(expTreeNode._value.ToString()))
						{
							num = (short)941752353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					case 30:
						if (!((string)this.j.Top._value == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆈ", a_)))
						{
							num = (short)1433075734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B5;
					case 31:
						goto IL_36A;
					case 32:
						if (this.j.IsEmpty())
						{
							num = (short)1554841602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a();
						num = (short)352059413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						this.j.Push(expTreeNode);
						num = (short)696451072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_36A;
					case 35:
						if (!this.j.IsEmpty())
						{
							num = (short)166133788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B5;
					case 36:
						if (this.NextToken() == global::SpecialFeatures.Model_Configuration.Token.Eof)
						{
							num = (short)1280901125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71E;
					case 37:
						this.j.Push(expTreeNode);
						num = (short)670826512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1193279489;
						if (num != 0)
						{
						}
						goto IL_36A;
					case 39:
						if (this.j.IsEmpty())
						{
							num = (short)1884946446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)200343575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_ED:
					if (!this.a(exp))
					{
						num = (short)1323696143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.i = exp;
					this.NextToken();
					num = (short)39321601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_117:
					this.a();
					num = (short)877199395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36A:
					num = (short)1219362852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F7:
					num = (short)307101696;
					short num4 = num;
					num = (short)2144141344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_464:
					num = (short)1758330890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B5:
					this.j.Push(expTreeNode);
					num = (short)1128071193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71E:
					token = this.d;
					num = (short)1611923469;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_112:
				throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욈ﮊﶎ杖뮚떜뾞캠톢薤躦覨쪪\udfac쪮醰\uddb2\udab4쎶馸\udaba즼龾뗀ꯂꃄ믈ꋊ꫌꟎ꗐꗔ믖룘룚룜곞", a_));
				IL_45F:
				return this.k.Top;
			}
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000F5F4C File Offset: 0x000F414C
		public void Clear()
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.j.IsEmpty())
						{
							num2 = (short)496828419;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.j.Pop();
						num2 = (short)372899846;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_182;
					case 2:
					{
						if (this.k.IsEmpty())
						{
							num2 = (short)804126727;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.k.Pop();
						num2 = (short)1002526141;
						short num3 = num2;
						num2 = (short)283399613;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
						{
							num2 = (short)1484783616;
							short num4 = num2;
							num2 = (short)857997313;
							if (num2 != 0)
							{
							}
							num2 = (short)1030815744;
							if (num2 != 0)
							{
							}
							num2 = (short)659423233;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						num2 = (short)1068236804;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_182;
					case 5:
						goto IL_1C2;
					case 6:
						goto IL_1C2;
					case 7:
						return;
					}
					goto IL_30;
					IL_182:
					num2 = (short)1534590978;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1C2:
					num2 = (short)888537088;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
			}
			IL_30:
			this.d = global::SpecialFeatures.Model_Configuration.Token.InValid;
			this.e = null;
			this.f = null;
			this.g = 0.0;
			this.h = 0;
			this.i = null;
			IL_62:
			num2 = (short)243335173;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000F6160 File Offset: 0x000F4360
		private bool a(string A_0)
		{
			short num;
			for (;;)
			{
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
					break;
				}
				num = (short)1914204387;
				short num2 = num;
				num = (short)1668640995;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			return true;
			IL_66:
			num = (short)2027225089;
			if (num != 0)
			{
			}
			num = (short)1524432896;
			short num3 = num;
			num = (short)925892608;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000F623C File Offset: 0x000F443C
		protected global::SpecialFeatures.Model_Configuration.Token NextToken()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::System.Text.RegularExpressions.Match match;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (match.Length != 0)
					{
						num2 = (short)27394057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					match = this.b.Match(this.i);
					num2 = (short)713818116;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_200;
				case 2:
					this.g = (double)((float)double.Parse(match.Groups[1].Value));
					this.h += match.Length;
					this.i = this.i.Substring(match.Length);
					this.d = global::SpecialFeatures.Model_Configuration.Token.Literal;
					num2 = (short)1253507078;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_14F;
				case 4:
				{
					num2 = (short)1741324482;
					short num3 = num2;
					num2 = (short)1362329794;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					case 1:
						break;
					default:
					{
						num2 = (short)879755264;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)2081161216;
					if (num2 != 0)
					{
					}
					if (match.Length != 0)
					{
						num2 = (short)1512570882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d = global::SpecialFeatures.Model_Configuration.Token.Eof;
					num2 = (short)185204737;
					if (num2 != 0)
					{
					}
					num2 = (short)120848385;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_5E;
				case 6:
					goto IL_EB;
				case 7:
					this.f = match.Groups[1].Value;
					this.h += match.Length;
					this.i = this.i.Substring(match.Length);
					this.d = global::SpecialFeatures.Model_Configuration.Token.Operator;
					num2 = (short)823328776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1B3;
				case 9:
					this.e = match.Groups[1].Value;
					this.h += match.Length;
					this.i = this.i.Substring(match.Length);
					this.d = global::SpecialFeatures.Model_Configuration.Token.Symbol;
					num2 = (short)801308675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_5E:
				if (match.Length != 0)
				{
					num2 = (short)204800007;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					match = this.c.Match(this.i);
					num2 = (short)1752760320;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_EB:
			IL_14F:
			IL_1B3:
			IL_200:
			return this.d;
			IL_38:
			match = this.a.Match(this.i);
			num2 = (short)1793982469;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040005AD RID: 1453
		private global::System.Text.RegularExpressions.Regex a;

		// Token: 0x040005AE RID: 1454
		private global::System.Text.RegularExpressions.Regex b;

		// Token: 0x040005AF RID: 1455
		private global::System.Text.RegularExpressions.Regex c;

		// Token: 0x040005B0 RID: 1456
		private global::SpecialFeatures.Model_Configuration.Token d;

		// Token: 0x040005B1 RID: 1457
		private string e;

		// Token: 0x040005B2 RID: 1458
		private string f;

		// Token: 0x040005B3 RID: 1459
		private double g;

		// Token: 0x040005B4 RID: 1460
		private int h;

		// Token: 0x040005B5 RID: 1461
		private string i;

		// Token: 0x040005B6 RID: 1462
		private global::SpecialFeatures.Model_Configuration.TreeStack j;

		// Token: 0x040005B7 RID: 1463
		private global::SpecialFeatures.Model_Configuration.TreeStack k;
	}
}
