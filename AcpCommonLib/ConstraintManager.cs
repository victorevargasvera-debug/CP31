using System;
using System.Runtime.CompilerServices;
using AcpUtility;

namespace AcpCommonLib
{
	// Token: 0x0200000D RID: 13
	public static class ConstraintManager
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000083E8 File Offset: 0x000065E8
		static ConstraintManager()
		{
			short num = (short)2139426146;
			short num2 = num;
			num = (short)214502754;
			switch (num2 == num)
			{
			}
			num = (short)923860992;
			if (num != 0)
			{
			}
			num = (short)2039480321;
			if (num != 0)
			{
			}
			num = (short)687538176;
			short num3 = num;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000849C File Offset: 0x0000669C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00008548 File Offset: 0x00006748
		public static bool Suspended
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1379932155;
				short num2 = num;
				num = (short)2124093435;
				switch (num2 == num)
				{
				}
				num = (short)1037238273;
				if (num != 0)
				{
				}
				num = (short)1530593280;
				if (num != 0)
				{
				}
				num = (short)1427832832;
				short num3 = num;
				return global::AcpCommonLib.ConstraintManager.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)936968193;
				if (num != 0)
				{
				}
				num = (short)1443899642;
				short num2 = num;
				num = (short)2034182394;
				switch (num2 == num)
				{
				}
				num = (short)2113404928;
				if (num != 0)
				{
				}
				num = (short)1323499520;
				short num3 = num;
				global::AcpCommonLib.ConstraintManager.a = value;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000085F4 File Offset: 0x000067F4
		public static bool Suspend()
		{
			short num = (short)1206831492;
			short num2 = num;
			num = (short)95930756;
			switch (num2 == num)
			{
			}
			num = (short)548208641;
			if (num != 0)
			{
			}
			num = (short)940900352;
			if (num != 0)
			{
			}
			num = (short)1313013760;
			short num3 = num;
			bool result = !global::AcpCommonLib.ConstraintManager.Suspended;
			global::AcpCommonLib.ConstraintManager.Suspended = true;
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000086AC File Offset: 0x000068AC
		public static void Resume()
		{
			short num = (short)1093533697;
			if (num != 0)
			{
			}
			num = (short)1181071677;
			short num2 = num;
			num = (short)2033105213;
			switch (num2 == num)
			{
			}
			num = (short)77070336;
			if (num != 0)
			{
			}
			num = (short)1954545664;
			short num3 = num;
			global::AcpCommonLib.ConstraintManager.Suspended = false;
		}

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a;
	}
}
