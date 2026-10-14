using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B2 RID: 178
	public class ExpEvaluator : global::SpecialFeatures.Model_Configuration.IOperatorImp
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002DCD File Offset: 0x00000FCD
		internal ExpEvaluator(global::SpecialFeatures.Model_Configuration.IParser _parser)
		{
			this.a = _parser;
		}

		// Token: 0x1700044E RID: 1102
		internal bool this[string sym]
		{
			set
			{
				int a_ = 10;
				short num = (short)179830785;
				if (num != 0)
				{
				}
				num = (short)1652609603;
				short num2 = num;
				num = (short)1863307843;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1353973760;
					if (num != 0)
					{
					}
					num = (short)1044774912;
					short num3 = num;
					if (this.b != null)
					{
						this.b[sym] = value;
						return;
					}
					break;
				}
				}
				throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좌膠쪢횤螦얪\udbac캮\uddb0\udab2톴", a_));
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000F4A14 File Offset: 0x000F2C14
		internal bool SetExpression(string _exp)
		{
			short num = (short)684706420;
			short num2 = num;
			num = (short)1831783028;
			switch (num2 == num)
			{
			}
			num = (short)224985089;
			if (num != 0)
			{
			}
			num = (short)1833893888;
			if (num != 0)
			{
			}
			num = (short)1064960000;
			short num3 = num;
			this.a.Clear();
			this.b = this.a.ParseExpression(_exp);
			return true;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000F4ADC File Offset: 0x000F2CDC
		internal bool Evaluate()
		{
			short num = (short)1092644635;
			short num2 = num;
			num = (short)1295019803;
			switch (num2 == num)
			{
			}
			num = (short)912785409;
			if (num != 0)
			{
			}
			num = (short)709820416;
			if (num != 0)
			{
			}
			num = (short)158203904;
			short num3 = num;
			this.b.ValidateExpTree();
			return this.a(this.b);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000F4B9C File Offset: 0x000F2D9C
		private bool a(global::SpecialFeatures.Model_Configuration.ExpTreeNode A_0)
		{
			int a_ = 19;
			short num = (short)1620770816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					continue;
				case 1:
					goto IL_15C;
				case 2:
				{
					if (A_0._ndType != global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Operator)
					{
						goto IL_175;
					}
					num = (short)1124952713;
					short num3 = num;
					num = (short)2122476169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1187643392;
						short num4 = num;
						num = (short)663552001;
						if (num != 0)
						{
						}
						num = (short)363790336;
						if (num != 0)
						{
						}
						num = (short)1776877569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_56;
				}
				IL_3F:
				if (A_0 == null)
				{
					num = (short)373489667;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1271463938;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_56:
			throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud895몙\ud99b킟킡솣향\udba7쎩쎫삭邯욳펵\uddb7骹좻톽蟁닃Ʂ꓇뿉귋뫍뗏", a_));
			IL_15C:
			bool operand = this.a(A_0._left);
			bool operand2 = this.a(A_0._right);
			return this.ApplyOp(A_0._value.ToString(), operand, operand2);
			IL_175:
			return global::System.Convert.ToBoolean(A_0._value);
		}

		// Token: 0x040005A5 RID: 1445
		private global::SpecialFeatures.Model_Configuration.IParser a;

		// Token: 0x040005A6 RID: 1446
		private global::SpecialFeatures.Model_Configuration.ExpTreeNode b;
	}
}
