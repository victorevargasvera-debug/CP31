using System;

namespace AcpUtility
{
	// Token: 0x02000003 RID: 3
	public static class AcpStringExtensions
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static string AcpStringFormat(this string fmt, params object[] args)
		{
			int a_ = 15;
			short num;
			string result;
			for (;;)
			{
				num = (short)414253056;
				short num2 = num;
				result = string.Empty;
				try
				{
					result = string.Format(fmt, args);
				}
				catch (global::System.ArgumentNullException)
				{
					result = global::AcpUtility.StreamExtensions.b("剫偭偯ⅱsѵᅷᑹ᭻幽ꚅ曆뎑뒓ꪕ꒗", a_);
				}
				catch (global::System.FormatException)
				{
					result = global::AcpUtility.StreamExtensions.b("剫偭偯ⅱsѵᅷᑹ᭻幽ꚅ曆뎑뒓ꪕ꒗", a_);
				}
				catch (global::System.Exception)
				{
					throw;
				}
				num = (short)1934638900;
				short num3 = num;
				num = (short)2037464884;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A0;
				}
			}
			IL_A0:
			num = (short)1499070465;
			if (num != 0)
			{
			}
			num = (short)372047872;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
