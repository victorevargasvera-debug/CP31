using System;
using System.Threading;
using SpecialFeatures.Flashport.FlashkeyLib;

namespace SpecialFeatures.Flashport
{
	// Token: 0x020000C8 RID: 200
	public static class FlashKeyManagerSingleTon
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x001048B8 File Offset: 0x00102AB8
		public static global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager Instance
		{
			get
			{
				short num = (short)76414977;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1879012217;
					short num3 = num;
					num = (short)281637753;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16E;
					case 1:
						break;
					default:
					{
						num = (short)653852672;
						short num4 = num;
						break;
					}
					}
					num = (short)1137180672;
					if (num != 0)
					{
					}
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)1679228929;
						if (num != 0)
						{
						}
						goto IL_16E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.a = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager();
							goto IL_193;
						}
						finally
						{
							num = (short)429391873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)127926274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_138;
									}
									continue;
								case 2:
									goto IL_16B;
								}
								IL_138:
								if (!flag)
								{
									break;
								}
								num = (short)1459421184;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16B:;
						}
						goto IL_16E;
					}
					IL_A3:
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.a == null)
					{
						num = (short)1126170624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_16E:
					obj = global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.b;
					flag = false;
					num = (short)1578696706;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_193:
				return global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.a;
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00104A70 File Offset: 0x00102C70
		public static void ReleaseFlashKeyManager()
		{
			short num = (short)1054627135;
			short num2 = num;
			num = (short)874468671;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1377828864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)290390017;
			if (num != 0)
			{
			}
			num = (short)619315200;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.a = null;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00104B20 File Offset: 0x00102D20
		// Note: this type is marked as 'beforefieldinit'.
		static FlashKeyManagerSingleTon()
		{
			short num = (short)1613945344;
			short num2 = num;
			num = (short)926669312;
			switch (num2 == num)
			{
			default:
			{
				num = (short)237502464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1666711553;
			if (num != 0)
			{
			}
			num = (short)1963655168;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.a = null;
			global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.b = new object();
		}

		// Token: 0x0400061A RID: 1562
		private static global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyManager a;

		// Token: 0x0400061B RID: 1563
		private static object b;
	}
}
