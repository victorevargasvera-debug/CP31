using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000A RID: 10
	public class DeviceCapabilityResponse
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public static implicit operator global::MSI.DeviceCapabilityResponse(global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse parameter)
		{
			short num = (short)1291634099;
			short num2 = num;
			num = (short)1988806067;
			switch (num2 == num)
			{
			}
			num = (short)1502871553;
			if (num != 0)
			{
			}
			num = (short)1749549056;
			if (num != 0)
			{
			}
			num = (short)713490432;
			short num3 = num;
			return parameter.a;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004E58 File Offset: 0x00003058
		public static implicit operator global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse(global::MSI.DeviceCapabilityResponse parameter)
		{
			short num = (short)1084686337;
			if (num != 0)
			{
			}
			num = (short)149430846;
			short num2 = num;
			num = (short)1021125182;
			switch (num2 == num)
			{
			}
			num = (short)1894449152;
			if (num != 0)
			{
			}
			num = (short)1914765312;
			short num3 = num;
			return new global::CommonLicenseInterfaceWrapper.DeviceCapabilityResponse
			{
				a = parameter
			};
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004F0C File Offset: 0x0000310C
		static DeviceCapabilityResponse()
		{
			short num = (short)158871836;
			short num2 = num;
			num = (short)796012828;
			switch (num2 == num)
			{
			}
			num = (short)1595408384;
			if (num != 0)
			{
			}
			num = (short)300875777;
			if (num != 0)
			{
			}
			num = (short)1883439104;
			short num3 = num;
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004FBC File Offset: 0x000031BC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005070 File Offset: 0x00003270
		public int binaryResponseSize
		{
			get
			{
				short num = (short)1286329455;
				short num2 = num;
				num = (short)1864881263;
				switch (num2 == num)
				{
				}
				num = (short)1591541760;
				if (num != 0)
				{
				}
				num = (short)1685848065;
				if (num != 0)
				{
				}
				num = (short)461832192;
				short num3 = num;
				return this.a.binaryResponseSize;
			}
			set
			{
				short num = (short)572063745;
				if (num != 0)
				{
				}
				num = (short)1047640162;
				short num2 = num;
				num = (short)209500258;
				switch (num2 == num)
				{
				}
				num = (short)122421248;
				if (num != 0)
				{
				}
				num = (short)1406664704;
				short num3 = num;
				this.a.binaryResponseSize = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005128 File Offset: 0x00003328
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000051DC File Offset: 0x000033DC
		public byte[] binaryResponse
		{
			get
			{
				short num = (short)992606196;
				short num2 = num;
				num = (short)1387853812;
				switch (num2 == num)
				{
				}
				num = (short)724959233;
				if (num != 0)
				{
				}
				num = (short)755630080;
				if (num != 0)
				{
				}
				num = (short)21692416;
				short num3 = num;
				return this.a.binaryResponse;
			}
			set
			{
				short num = (short)313099438;
				short num2 = num;
				num = (short)1733461166;
				switch (num2 == num)
				{
				}
				num = (short)370933760;
				if (num != 0)
				{
				}
				num = (short)749076481;
				if (num != 0)
				{
				}
				num = (short)1132396544;
				short num3 = num;
				this.a.binaryResponse = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005290 File Offset: 0x00003490
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005348 File Offset: 0x00003548
		public global::CommonLicenseInterfaceWrapper.DeviceInfo deviceInfo
		{
			get
			{
				short num = (short)1903558657;
				if (num != 0)
				{
				}
				num = (short)1750837123;
				short num2 = num;
				num = (short)826124163;
				switch (num2 == num)
				{
				}
				num = (short)1687748608;
				if (num != 0)
				{
				}
				num = (short)1738407936;
				short num3 = num;
				return this.a.deviceInfo;
			}
			set
			{
				short num = (short)266235774;
				short num2 = num;
				num = (short)1648652158;
				switch (num2 == num)
				{
				}
				num = (short)990380032;
				if (num != 0)
				{
				}
				num = (short)1090191361;
				if (num != 0)
				{
				}
				num = (short)273547264;
				short num3 = num;
				this.a.deviceInfo = value;
			}
		}

		// Token: 0x04000019 RID: 25
		private global::MSI.DeviceCapabilityResponse a = new global::MSI.DeviceCapabilityResponse();
	}
}
