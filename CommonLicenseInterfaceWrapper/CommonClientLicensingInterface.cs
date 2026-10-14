using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000007 RID: 7
	public class CommonClientLicensingInterface : global::System.IDisposable
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002648 File Offset: 0x00000848
		public static implicit operator global::MSI.CommonClientLicensingInterface(global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface parameter)
		{
			short num = (short)223166473;
			short num2 = num;
			num = (short)538853385;
			switch (num2 == num)
			{
			}
			num = (short)227606529;
			if (num != 0)
			{
			}
			num = (short)877133824;
			if (num != 0)
			{
			}
			num = (short)161742848;
			short num3 = num;
			return parameter.a;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026F8 File Offset: 0x000008F8
		public static implicit operator global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface(global::MSI.CommonClientLicensingInterface parameter)
		{
			short num = (short)932628909;
			short num2 = num;
			num = (short)1858521517;
			switch (num2 == num)
			{
			}
			num = (short)513605633;
			if (num != 0)
			{
			}
			num = (short)403243008;
			if (num != 0)
			{
			}
			num = (short)1271332864;
			short num3 = num;
			return new global::CommonLicenseInterfaceWrapper.CommonClientLicensingInterface
			{
				a = parameter
			};
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027AC File Offset: 0x000009AC
		static CommonClientLicensingInterface()
		{
			short num = (short)1439503139;
			short num2 = num;
			num = (short)2053706531;
			switch (num2 == num)
			{
			}
			num = (short)695140352;
			if (num != 0)
			{
			}
			num = (short)1130692609;
			if (num != 0)
			{
			}
			num = (short)1137180672;
			short num3 = num;
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002858 File Offset: 0x00000A58
		public void Dispose()
		{
			short num = (short)1244463105;
			if (num != 0)
			{
			}
			num = (short)1264422523;
			short num2 = num;
			num = (short)1967820411;
			switch (num2 == num)
			{
			}
			num = (short)710737920;
			if (num != 0)
			{
			}
			num = (short)1872166912;
			short num3 = num;
			this.a.Dispose();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000290C File Offset: 0x00000B0C
		private CommonClientLicensingInterface()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002920 File Offset: 0x00000B20
		public CommonClientLicensingInterface(global::CommonLicenseInterfaceWrapper.ConfigInfo cfgInfo, global::CommonLicenseInterfaceWrapper.DeviceInfo devInfo)
		{
			this.a = new global::MSI.CommonClientLicensingInterface(cfgInfo, devInfo);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000294C File Offset: 0x00000B4C
		public global::CommonLicenseInterfaceWrapper.CllCode Error()
		{
			short num = (short)1405566102;
			short num2 = num;
			num = (short)2105752726;
			switch (num2 == num)
			{
			}
			num = (short)1332740097;
			if (num != 0)
			{
			}
			num = (short)381157376;
			if (num != 0)
			{
			}
			num = (short)1611268096;
			short num3 = num;
			return this.a.Error();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A00 File Offset: 0x00000C00
		public global::CommonLicenseInterfaceWrapper.QueryFeatureResponse queryFeatures(global::CommonLicenseInterfaceWrapper.FeatureInfo featureInfo)
		{
			short num = (short)815434425;
			short num2 = num;
			num = (short)865110713;
			switch (num2 == num)
			{
			}
			num = (short)920584193;
			if (num != 0)
			{
			}
			num = (short)1128202240;
			if (num != 0)
			{
			}
			num = (short)622854144;
			short num3 = num;
			return this.a.queryFeatures(featureInfo);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public global::CommonLicenseInterfaceWrapper.GetEntitlementResponse getEntitlementDetails(string entitlementID)
		{
			short num = (short)34076479;
			short num2 = num;
			num = (short)817887039;
			switch (num2 == num)
			{
			}
			num = (short)693108737;
			if (num != 0)
			{
			}
			num = (short)658112512;
			if (num != 0)
			{
			}
			num = (short)625278976;
			short num3 = num;
			return this.a.getEntitlementDetails(entitlementID);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B7C File Offset: 0x00000D7C
		public global::System.Collections.Generic.ICollection<global::CommonLicenseInterfaceWrapper.Entry> getDevicesQuery(string activationID, string empty)
		{
			global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.Entry> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.Entry>();
			global::System.Collections.Generic.IEnumerator<global::MSI.Entry> enumerator = this.a.getDevicesQuery(activationID, empty).GetEnumerator();
			short num;
			try
			{
				num = (short)596508676;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_64:
					switch (num2)
					{
					case 0:
						num = (short)686751746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						while (enumerator.MoveNext())
						{
							global::MSI.Entry parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)1533258938;
							short num3 = num;
							num = (short)947104954;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)744554496;
								if (num != 0)
								{
								}
								num = (short)2043478019;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_64;
							}
						}
						num = (short)182583296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14C;
					case 4:
						num = (short)1590296577;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					IL_F8:
					num = (short)1950089217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					goto IL_F8;
				}
				IL_14C:;
			}
			finally
			{
				num = (short)1521090562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1449852929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1B4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_17E;
						}
						continue;
					}
					IL_17E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)625934336;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B4:;
			}
			num = (short)780861440;
			short num4 = num;
			return list;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D88 File Offset: 0x00000F88
		public global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse sendRequestToFNOServer(global::CommonLicenseInterfaceWrapper.DeviceRequest serverRequest)
		{
			short num = (short)1420210039;
			short num2 = num;
			num = (short)597995383;
			switch (num2 == num)
			{
			}
			num = (short)1826488320;
			if (num != 0)
			{
			}
			num = (short)231276544;
			short num3 = num;
			num = (short)429785089;
			if (num != 0)
			{
			}
			return this.a.sendRequestToFNOServer(serverRequest);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002E4C File Offset: 0x0000104C
		public global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse sendRefreshRequestToFNOServer(global::CommonLicenseInterfaceWrapper.DeviceRequest serverRequest)
		{
			short num = (short)1851686596;
			short num2 = num;
			num = (short)1796570820;
			switch (num2 == num)
			{
			}
			num = (short)303955969;
			if (num != 0)
			{
			}
			num = (short)1838940160;
			short num3 = num;
			num = (short)1830092800;
			if (num != 0)
			{
			}
			return this.a.sendRefreshRequestToFNOServer(serverRequest);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F0C File Offset: 0x0000110C
		public global::CommonLicenseInterfaceWrapper.QueryFeatureResponse queryFeaturesFromResponse(global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse devResponse, global::CommonLicenseInterfaceWrapper.FeatureInfo featureInfo)
		{
			short num = (short)1804955319;
			short num2 = num;
			num = (short)1768844983;
			switch (num2 == num)
			{
			}
			num = (short)2120679424;
			if (num != 0)
			{
			}
			num = (short)661389312;
			short num3 = num;
			num = (short)1861812225;
			if (num != 0)
			{
			}
			return this.a.queryFeaturesFromResponse(devResponse, featureInfo);
		}

		// Token: 0x04000014 RID: 20
		private global::MSI.CommonClientLicensingInterface a;
	}
}
