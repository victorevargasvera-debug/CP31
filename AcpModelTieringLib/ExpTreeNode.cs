using System;

namespace AcpModelTieringLib
{
	// Token: 0x0200000D RID: 13
	public class ExpTreeNode
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000FD28 File Offset: 0x0000DF28
		internal ExpTreeNode()
		{
			this._value = null;
			this._symbol = null;
			this._ndType = global::AcpModelTieringLib.ExpTreeNode.NodeType.InValid;
			this._left = null;
			this._right = null;
		}

		// Token: 0x17000019 RID: 25
		public bool this[string sym]
		{
			set
			{
				short num = (short)1250427759;
				short num2 = num;
				num = (short)1891697519;
				switch (num2 == num)
				{
				}
				num = (short)765591552;
				if (num != 0)
				{
				}
				num = (short)1242693632;
				short num3 = num;
				num = (short)1955004417;
				if (num != 0)
				{
				}
				this.a(sym, value);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000FE10 File Offset: 0x0000E010
		private void a(string A_0, bool A_1)
		{
			short num = (short)1842282505;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_75;
				case 1:
					goto IL_1CC;
				case 2:
					if (this._right != null)
					{
						num = (short)1671168004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 3:
					goto IL_DE;
				case 4:
					this._right.a(A_0, A_1);
					num = (short)1876623361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this._left != null)
					{
						num = (short)500695050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 6:
					num = (short)869138439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (A_0 == this._symbol)
					{
						num = (short)1696071688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DE;
				case 8:
				{
					num = (short)307635508;
					short num3 = num;
					num = (short)2075206964;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						num = (short)501219328;
						if (num != 0)
						{
						}
						this._value = A_1;
						num = (short)77070339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 10:
					this._left.a(A_0, A_1);
					num = (short)2121662464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				if (this._ndType == global::AcpModelTieringLib.ExpTreeNode.NodeType.Symbol)
				{
					num = (short)1290469382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_DE;
				IL_75:
				num = (short)1074921473;
				if (num != 0)
				{
				}
				num = (short)984154114;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DE:
				num = (short)639434757;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1CC:
			IL_221:
			num = (short)936509440;
			short num4 = num;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00010068 File Offset: 0x0000E268
		internal bool a()
		{
			int a_ = 19;
			short num = (short)1253834752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				bool flag;
				global::AcpModelTieringLib.ExpTreeNode.NodeType ndType;
				bool flag2;
				bool flag3;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (this._symbol.ToLower().Equals(global::AcpModelTieringLib.ErrorException.b("곁ꯃ닅", a_)))
						{
							num = (short)402325510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C7;
					case 1:
						goto IL_3C7;
					case 2:
						goto IL_3DF;
					case 3:
						if (this._left != null)
						{
							num = (short)953548807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					case 4:
						goto IL_35E;
					case 5:
						goto IL_513;
					case 6:
						this._value = false;
						num = (short)759365633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)489095177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)164888576;
						short num3 = num;
						goto IL_35E;
					}
					case 9:
						if (this._right == null)
						{
							num = (short)1984757765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)2062221316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1667563521;
						if (num != 0)
						{
						}
						num = (short)1685782547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_35E;
					case 12:
						goto IL_3C2;
					case 13:
						switch (ndType)
						{
						case global::AcpModelTieringLib.ExpTreeNode.NodeType.Literal:
							num = (short)21430292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::AcpModelTieringLib.ExpTreeNode.NodeType.Symbol:
							num = (short)941228032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::AcpModelTieringLib.ExpTreeNode.NodeType.Operator:
							num = (short)1079640067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::AcpModelTieringLib.ExpTreeNode.NodeType.Function:
							goto IL_35E;
						case global::AcpModelTieringLib.ExpTreeNode.NodeType.InValid:
							goto IL_4A2;
						default:
							num = (short)668467210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						flag2 = this._left.a();
						num = (short)1912995862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this._right != null)
						{
							num = (short)1162870805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_518;
					case 16:
						goto IL_225;
					case 17:
						if (this._left != null)
						{
							num = (short)1608908814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 18:
						goto IL_403;
					case 19:
						goto IL_35E;
					case 20:
						if (this._value == null)
						{
							num = (short)1975975952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)422510600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						num = (short)2129489492;
						short num4 = num;
						num = (short)1537044052;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3DF;
						default:
							num = (short)58195968;
							if (num != 0)
							{
							}
							flag3 = this._right.a();
							num = (short)1036386316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						goto IL_25E;
					}
					goto IL_94;
					IL_25E:
					num = (short)1671430159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DF:
					if (this._value == null)
					{
						num = (short)1190920210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = true;
					num = (short)980090891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35E:
					num = (short)108331025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C7:
					num = (short)1789394946;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_225:
				global::AcpModelTieringLib.ErrorException ex = new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("軁귃닅귇룉귋ꋍ", a_) + this._value.ToString() + global::AcpModelTieringLib.ErrorException.b("귃뗅ꯉ룋맏병ꋓ럕듗동룛ﻝ郟軡藣藥跧", a_));
				flag = false;
				throw ex;
				IL_22A:
				global::AcpModelTieringLib.ErrorException ex2 = new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("跁듃ꏅ뫇ꯉ룋ꇍꋏ", a_) + this._value.ToString() + global::AcpModelTieringLib.ErrorException.b("꫃꧅볇귋뫍ꋑꛓ맕꣗뿙껛ﻝ냟軡藣藥跧", a_));
				flag = false;
				throw ex2;
				IL_3C2:
				goto IL_518;
				IL_403:
				global::AcpModelTieringLib.ErrorException ex3 = new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("韁꫃귅ꛇꗉ믋ꃍ臑귓믕뫗뗙냛ﻝ", a_) + this._symbol);
				flag = false;
				throw ex3;
				IL_4A2:
				global::AcpModelTieringLib.ErrorException ex4 = new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("跁듃ꏅ뫇ꯉ룋ꇍꋏ", a_) + this._value.ToString() + global::AcpModelTieringLib.ErrorException.b("꫃꧅볇귋뫍ꋑꛓ맕꣗뿙껛ﻝ냟軡藣藥跧", a_));
				flag = false;
				throw ex4;
				IL_513:
				goto IL_22A;
				IL_518:
				return flag2 && flag3 && flag;
				IL_94:
				flag = false;
				flag2 = false;
				flag3 = false;
				ndType = this._ndType;
				num = (short)1997799437;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x04000034 RID: 52
		public const object INVALID = null;

		// Token: 0x04000035 RID: 53
		public object _value;

		// Token: 0x04000036 RID: 54
		public string _symbol;

		// Token: 0x04000037 RID: 55
		public global::AcpModelTieringLib.ExpTreeNode.NodeType _ndType;

		// Token: 0x04000038 RID: 56
		public global::AcpModelTieringLib.ExpTreeNode _left;

		// Token: 0x04000039 RID: 57
		public global::AcpModelTieringLib.ExpTreeNode _right;

		// Token: 0x0200000E RID: 14
		public enum NodeType
		{
			// Token: 0x0400003B RID: 59
			Literal,
			// Token: 0x0400003C RID: 60
			Symbol,
			// Token: 0x0400003D RID: 61
			Operator,
			// Token: 0x0400003E RID: 62
			Function,
			// Token: 0x0400003F RID: 63
			InValid
		}
	}
}
