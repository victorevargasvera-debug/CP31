using System;

namespace CommonUtility.DesignPattern
{
	// Token: 0x02000058 RID: 88
	public class Singleton<T> where T : new()
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0002F60C File Offset: 0x0002D80C
		protected Singleton()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0002F620 File Offset: 0x0002D820
		public static T SingleInstance
		{
			get
			{
				short num = (short)1762233603;
				short num2 = num;
				num = (short)675712259;
				switch (num2 == num)
				{
				}
				num = (short)75431936;
				short num3 = num;
				num = (short)1005715457;
				if (num != 0)
				{
				}
				num = (short)917176320;
				if (num != 0)
				{
				}
				return global::CommonUtility.DesignPattern.Singleton<T>.a;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		// Note: this type is marked as 'beforefieldinit'.
		static Singleton()
		{
			short num = (short)1106771969;
			if (num != 0)
			{
			}
			num = (short)1532521071;
			short num2 = num;
			num = (short)996371055;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1705639936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1013645312;
			if (num != 0)
			{
			}
			global::CommonUtility.DesignPattern.Singleton<T>.a = global::System.Activator.CreateInstance<T>();
		}

		// Token: 0x04000119 RID: 281
		private static T a;
	}
}
