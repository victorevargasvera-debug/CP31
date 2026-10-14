using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B3 RID: 179
	public abstract class IOperatorImp
	{
		// Token: 0x06000BF8 RID: 3064 RVA: 0x000F4D2C File Offset: 0x000F2F2C
		public virtual bool ApplyOp(string Op, bool operand1, bool operand2)
		{
			int a_ = 19;
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
					if (!(Op == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
					{
						num2 = (short)1298923529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = (operand1 || operand2);
					num2 = (short)754581510;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1925513218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_256;
				case 3:
					goto IL_EE;
				case 4:
					goto IL_23D;
				case 5:
					num2 = (short)475529217;
					if (num2 != 0)
					{
					}
					if (!(Op == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("낕뺗", a_)))
					{
						num2 = (short)1943142407;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = (operand1 && operand2);
					num2 = (short)1632632835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_CE;
				case 7:
					num2 = (short)1016266752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!(Op == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랕", a_)))
					{
						num2 = (short)1850540033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = !operand2;
					num2 = (short)1476329476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)316801024;
					short num3 = num2;
					num2 = (short)505937928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_41;
			}
			IL_CE:
			IL_EE:
			IL_23D:
			return result;
			IL_256:
			num2 = (short)1117579697;
			short num4 = num2;
			num2 = (short)855566769;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1101922304;
				if (num2 != 0)
				{
				}
				throw new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕힟첡蒣\ud8a7쾩\udeab쾭쒯\uddb1욳隵", a_) + Op);
			}
			return result;
			IL_41:
			result = false;
			num2 = (short)2001469445;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
