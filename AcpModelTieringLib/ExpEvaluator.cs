using System;

namespace AcpModelTieringLib
{
	// Token: 0x02000007 RID: 7
	public class ExpEvaluator : global::AcpModelTieringLib.IOperatorImp
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000D77C File Offset: 0x0000B97C
		internal ExpEvaluator(global::AcpModelTieringLib.IParser A_0)
		{
			this._exp_parser = A_0;
		}

		// Token: 0x17000014 RID: 20
		public bool this[string sym]
		{
			set
			{
				int a_ = 18;
				while (this.a == null)
				{
					short num = (short)2040266753;
					if (num != 0)
					{
					}
					num = (short)1333080068;
					short num2 = num;
					num = (short)864235524;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)56360960;
						if (num != 0)
						{
						}
						num = (short)1536294912;
						short num3 = num;
						throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("蓀믂뗄뗆곈룊뻌ꛎ뻐뷒뻖꫘ﯚ铜뇞韠苢觤軦跨", a_));
					}
					}
				}
				this.a[sym] = value;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000D878 File Offset: 0x0000BA78
		internal bool a(string A_0)
		{
			short num = (short)243924992;
			short num2 = num;
			num = (short)1435794296;
			short num3 = num;
			num = (short)986413944;
			switch (num3 == num)
			{
			}
			num = (short)1637220353;
			if (num != 0)
			{
			}
			num = (short)729677824;
			if (num != 0)
			{
			}
			this._exp_parser.Clear();
			this.a = this._exp_parser.ParseExpression(A_0);
			return true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000D940 File Offset: 0x0000BB40
		internal bool a()
		{
			short num = (short)1240072192;
			short num2 = num;
			num = (short)2085942254;
			short num3 = num;
			num = (short)1292170222;
			switch (num3 == num)
			{
			}
			num = (short)584646657;
			if (num != 0)
			{
			}
			num = (short)1224015872;
			if (num != 0)
			{
			}
			this.a.a();
			return this.a(this.a);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000DA00 File Offset: 0x0000BC00
		private bool a(global::AcpModelTieringLib.ExpTreeNode A_0)
		{
			int a_ = 4;
			short num = (short)1309671425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_162;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_A4;
				case 3:
				{
					num = (short)429522944;
					short num3 = num;
					if (A_0._ndType == global::AcpModelTieringLib.ExpTreeNode.NodeType.Operator)
					{
						goto IL_14A;
					}
					goto IL_17B;
				}
				}
				IL_3D:
				if (A_0 != null)
				{
					num = (short)239206403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)667732778;
				short num4 = num;
				num = (short)988793642;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)662765568;
					if (num != 0)
					{
					}
					num = (short)870055938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14A:
				num = (short)1794244608;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A4:
			throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("ﶲ\udab4鞶ﲸ쎺춼춾꓀냂뛄껆ꛈꗊ鯎ꏐ뛒냔귘듚﷜髞韠苢觤鋦裨鿪裬쿮", a_));
			IL_162:
			num = (short)838205441;
			if (num != 0)
			{
			}
			bool operand = this.a(A_0._left);
			bool operand2 = this.a(A_0._right);
			return this.ApplyOp(A_0._value.ToString(), operand, operand2);
			IL_17B:
			return global::System.Convert.ToBoolean(A_0._value);
		}

		// Token: 0x0400001E RID: 30
		public global::AcpModelTieringLib.IParser _exp_parser;

		// Token: 0x0400001F RID: 31
		private global::AcpModelTieringLib.ExpTreeNode a;
	}
}
