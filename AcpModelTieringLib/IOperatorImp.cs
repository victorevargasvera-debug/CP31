using System;

namespace AcpModelTieringLib
{
	// Token: 0x02000008 RID: 8
	public abstract class IOperatorImp
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public virtual bool ApplyOp(string Op, bool operand1, bool operand2)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_229;
				case 1:
					goto IL_A3;
				case 2:
					goto IL_157;
				case 3:
					num2 = (short)218628097;
					if (num2 != 0)
					{
					}
					num2 = (short)158662658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!(Op == global::AcpModelTieringLib.ErrorException.b("", a_)))
					{
						num2 = (short)1974075397;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = (operand1 && operand2);
					num2 = (short)1005977607;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1517289481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_210;
				case 7:
				{
					num2 = (short)832029105;
					short num3 = num2;
					num2 = (short)107135409;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						goto IL_FB;
					}
					break;
				}
				case 8:
					num2 = (short)1611202560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!(Op == global::AcpModelTieringLib.ErrorException.b("벿뻁", a_)))
					{
						num2 = (short)2104426499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = (operand1 || operand2);
					num2 = (short)941555713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_157:
				if (!(Op == global::AcpModelTieringLib.ErrorException.b("", a_)))
				{
					num2 = (short)1599078408;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					result = !operand2;
					num2 = (short)965804038;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_A3:
			return result;
			IL_FB:
			num2 = (short)619708416;
			if (num2 != 0)
			{
			}
			IL_210:
			return result;
			IL_229:
			num2 = (short)1514602496;
			short num4 = num2;
			throw new global::AcpModelTieringLib.ErrorException(global::AcpModelTieringLib.ErrorException.b("閿곁꿃ꣅꟇ뷉ꋋ鿏ꋑ뇓ꓕ맗껙돛곝샟", a_) + Op);
			IL_41:
			result = false;
			num2 = (short)1792737284;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
