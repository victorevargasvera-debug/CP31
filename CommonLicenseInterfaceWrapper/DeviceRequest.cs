using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000C RID: 12
	public class DeviceRequest
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public static implicit operator global::MSI.DeviceRequest(global::CommonLicenseInterfaceWrapper.DeviceRequest parameter)
		{
			short num = (short)1374617600;
			short num2 = num;
			num = (short)1085669870;
			short num3 = num;
			num = (short)1315176942;
			switch (num3 == num)
			{
			}
			num = (short)671088640;
			if (num != 0)
			{
			}
			num = (short)216203265;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005B50 File Offset: 0x00003D50
		public static implicit operator global::CommonLicenseInterfaceWrapper.DeviceRequest(global::MSI.DeviceRequest parameter)
		{
			short num = (short)413401088;
			short num2 = num;
			num = (short)1049362433;
			if (num != 0)
			{
			}
			num = (short)985373095;
			short num3 = num;
			num = (short)615487911;
			switch (num3 == num)
			{
			}
			num = (short)385089536;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.DeviceRequest
			{
				a = parameter
			};
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005C08 File Offset: 0x00003E08
		static DeviceRequest()
		{
			short num = (short)1512833024;
			short num2 = num;
			num = (short)1816493617;
			short num3 = num;
			num = (short)724336177;
			switch (num3 == num)
			{
			}
			num = (short)1296760833;
			if (num != 0)
			{
			}
			num = (short)1792409600;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005CBC File Offset: 0x00003EBC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005EC0 File Offset: 0x000040C0
		public global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo> activationInfoList
		{
			get
			{
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo>();
				global::System.Collections.Generic.IEnumerator<global::MSI.ActivationInfo> enumerator = this.a.activationInfoList.GetEnumerator();
				short num;
				try
				{
					num = (short)786366464;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_37:
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_51;
							}
							continue;
						case 1:
							num = (short)1564016643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								num = (short)790626305;
								if (num != 0)
								{
								}
								global::MSI.ActivationInfo parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)946534143;
								short num3 = num;
								num = (short)838989567;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1553203200;
									if (num != 0)
									{
									}
									num = (short)1713766404;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_37;
								}
							}
							num = (short)2102788097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_146;
						}
						IL_F3:
						num = (short)1019609090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_51:
						goto IL_F3;
					}
					IL_146:;
				}
				finally
				{
					num = (short)854917122;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)214368257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1AD;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_179;
							}
							continue;
						}
						IL_179:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1317273600;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1AD:;
				}
				num = (short)2013986816;
				short num4 = num;
				return list;
			}
			set
			{
				global::System.Collections.Generic.List<global::MSI.ActivationInfo> list = new global::System.Collections.Generic.List<global::MSI.ActivationInfo>();
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ActivationInfo>.Enumerator enumerator = value.GetEnumerator();
				short num;
				try
				{
					num = (short)390660096;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_2E:
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_48;
							}
							continue;
						case 1:
							num = (short)2013069315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								global::CommonLicenseInterfaceWrapper.ActivationInfo parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)1640192631;
								short num3 = num;
								num = (short)318069367;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)325844992;
									if (num != 0)
									{
									}
									num = (short)168558596;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_2E;
								}
							}
							num = (short)1092747265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_118;
						}
						IL_C3:
						num = (short)1386217474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_48:
						goto IL_C3;
					}
					IL_118:;
				}
				finally
				{
					num = (short)738656257;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				num = (short)912523264;
				short num4 = num;
				this.a.activationInfoList = list;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006070 File Offset: 0x00004270
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000612C File Offset: 0x0000432C
		public global::CommonLicenseInterfaceWrapper.DeviceInfo deviceInfo
		{
			get
			{
				short num = (short)1485111296;
				short num2 = num;
				num = (short)2027683841;
				if (num != 0)
				{
				}
				num = (short)989168372;
				short num3 = num;
				num = (short)773686004;
				switch (num3 == num)
				{
				}
				num = (short)202637312;
				if (num != 0)
				{
				}
				return this.a.deviceInfo;
			}
			set
			{
				short num = (short)77398016;
				short num2 = num;
				num = (short)1515425009;
				short num3 = num;
				num = (short)1482001649;
				switch (num3 == num)
				{
				}
				num = (short)2110849025;
				if (num != 0)
				{
				}
				num = (short)1137967104;
				if (num != 0)
				{
				}
				this.a.deviceInfo = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000061EC File Offset: 0x000043EC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000063F8 File Offset: 0x000045F8
		public global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount> featureInfoCountList
		{
			get
			{
				short num = (short)444530689;
				if (num != 0)
				{
				}
				num = (short)781058048;
				short num2 = num;
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount>();
				global::System.Collections.Generic.IEnumerator<global::MSI.FeatureInfoCount> enumerator = this.a.featureInfoCountList.GetEnumerator();
				try
				{
					num = (short)1451556864;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_8C:
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 1:
							num = (short)1983250435;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								global::MSI.FeatureInfoCount parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)2138981120;
								short num4 = num;
								num = (short)2056078080;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1378680832;
									if (num != 0)
									{
									}
									num = (short)1117650948;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_8C;
								}
							}
							num = (short)854720513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_176;
						}
						IL_121:
						num = (short)98893826;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6:
						goto IL_121;
					}
					IL_176:;
				}
				finally
				{
					num = (short)763887618;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1782382593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1DC;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1A8;
							}
							continue;
						}
						IL_1A8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1514536960;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1DC:;
				}
				return list;
			}
			set
			{
				global::System.Collections.Generic.List<global::MSI.FeatureInfoCount> list = new global::System.Collections.Generic.List<global::MSI.FeatureInfoCount>();
				short num;
				using (global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureInfoCount>.Enumerator enumerator = value.GetEnumerator())
				{
					num = (short)193658880;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_2F:
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_49;
							}
							continue;
						case 1:
							num = (short)1594294275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								global::CommonLicenseInterfaceWrapper.FeatureInfoCount parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)1252466657;
								short num3 = num;
								num = (short)813768673;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1963458560;
									if (num != 0)
									{
									}
									num = (short)1428422657;
									if (num != 0)
									{
									}
									num = (short)306380804;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_2F;
								}
							}
							num = (short)1310982145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_140;
						}
						IL_EB:
						num = (short)2015887362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_49:
						goto IL_EB;
					}
					IL_140:;
				}
				num = (short)583532544;
				short num4 = num;
				this.a.featureInfoCountList = list;
			}
		}

		// Token: 0x0400001B RID: 27
		private global::MSI.DeviceRequest a = new global::MSI.DeviceRequest();
	}
}
