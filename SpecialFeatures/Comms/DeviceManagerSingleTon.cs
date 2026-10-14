using System;
using System.Threading;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000160 RID: 352
	public static class DeviceManagerSingleTon
	{
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00184F1C File Offset: 0x0018311C
		public static global::SpecialFeatures.Comms.IDeviceManager Instance
		{
			get
			{
				short num = (short)633405442;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						num = (short)405798912;
						short num3 = num;
						num = (short)1225261057;
						if (num != 0)
						{
						}
						goto IL_174;
					}
					case 1:
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							global::SpecialFeatures.Comms.DeviceManagerSingleTon.a = new global::SpecialFeatures.Comms.DeviceManager();
							goto IL_19A;
						}
						finally
						{
							num = (short)390397954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)299678537;
									short num4 = num;
									num = (short)2049227593;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)451215360;
										if (num != 0)
										{
										}
										global::System.Threading.Monitor.Exit(obj);
										num = (short)921305089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_171;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_EA;
									}
									continue;
								}
								IL_EA:
								if (!flag)
								{
									break;
								}
								num = (short)1569325056;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_171:;
						}
						goto IL_174;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (global::SpecialFeatures.Comms.DeviceManagerSingleTon.a == null)
					{
						num = (short)1039990784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_174:
					obj = global::SpecialFeatures.Comms.DeviceManagerSingleTon.b;
					flag = false;
					num = (short)284295169;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19A:
				return global::SpecialFeatures.Comms.DeviceManagerSingleTon.a;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x001850D8 File Offset: 0x001832D8
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceManagerSingleTon()
		{
			short num = (short)1846777022;
			short num2 = num;
			num = (short)1328190654;
			switch (num2 == num)
			{
			}
			num = (short)2107768832;
			if (num != 0)
			{
			}
			num = (short)2050359297;
			if (num != 0)
			{
			}
			num = (short)319881216;
			short num3 = num;
			global::SpecialFeatures.Comms.DeviceManagerSingleTon.a = null;
			global::SpecialFeatures.Comms.DeviceManagerSingleTon.b = new object();
		}

		// Token: 0x040009BF RID: 2495
		private static global::SpecialFeatures.Comms.IDeviceManager a;

		// Token: 0x040009C0 RID: 2496
		private static object b;
	}
}
