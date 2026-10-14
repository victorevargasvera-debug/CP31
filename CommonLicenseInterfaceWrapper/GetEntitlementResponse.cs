using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000012 RID: 18
	public class GetEntitlementResponse
	{
		// Token: 0x0600008E RID: 142 RVA: 0x0000861C File Offset: 0x0000681C
		public static implicit operator global::MSI.GetEntitlementResponse(global::CommonLicenseInterfaceWrapper.GetEntitlementResponse parameter)
		{
			short num = (short)129093626;
			short num2 = num;
			num = (short)77647866;
			switch (num2 == num)
			{
			default:
			{
				num = (short)514850816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)990248961;
			if (num != 0)
			{
			}
			num = (short)1098055680;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000086CC File Offset: 0x000068CC
		public static implicit operator global::CommonLicenseInterfaceWrapper.GetEntitlementResponse(global::MSI.GetEntitlementResponse parameter)
		{
			short num = (short)39799735;
			short num2 = num;
			num = (short)227822519;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2014052352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1270546433;
			if (num != 0)
			{
			}
			num = (short)111869952;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.GetEntitlementResponse
			{
				a = parameter
			};
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008784 File Offset: 0x00006984
		static GetEntitlementResponse()
		{
			short num = (short)1857541596;
			short num2 = num;
			num = (short)1217648092;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1828716544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)195035137;
			if (num != 0)
			{
			}
			num = (short)972095488;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00008830 File Offset: 0x00006A30
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00008A24 File Offset: 0x00006C24
		public global::System.Collections.Generic.IEnumerable<global::CommonLicenseInterfaceWrapper.EntitlementResponse> entitlementResponseList
		{
			get
			{
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.EntitlementResponse> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.EntitlementResponse>();
				global::System.Collections.Generic.IEnumerator<global::MSI.EntitlementResponse> enumerator = this.a.entitlementResponseList.GetEnumerator();
				short num;
				try
				{
					num = (short)546177028;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)385810435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::MSI.EntitlementResponse parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)1527971840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_ED;
						case 3:
							num = (short)778960897;
							if (num != 0)
							{
							}
							num = (short)744030210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_51;
							}
							continue;
						}
						IL_7C:
						num = (short)980484097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_51:
						goto IL_7C;
					}
					IL_ED:;
				}
				finally
				{
					num = (short)1460076546;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1A9;
						case 1:
						{
							num = (short)452716164;
							short num3 = num;
							num = (short)256173700;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_128;
							default:
								num = (short)395706368;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1937047552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_122;
							}
							continue;
						}
						goto IL_122;
						IL_128:
						num = (short)267911169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_122:
						if (enumerator != null)
						{
							goto IL_128;
						}
						break;
					}
					IL_1A9:;
				}
				num = (short)1540292608;
				short num4 = num;
				return list;
			}
			set
			{
				global::System.Collections.Generic.List<global::MSI.EntitlementResponse> list = new global::System.Collections.Generic.List<global::MSI.EntitlementResponse>();
				global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.EntitlementResponse> enumerator = value.GetEnumerator();
				short num;
				try
				{
					num = (short)377356292;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1253769219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::CommonLicenseInterfaceWrapper.EntitlementResponse parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)185597952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_BC;
						case 3:
							num = (short)1736114178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_47;
							}
							continue;
						}
						IL_72:
						num = (short)1436352513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_47:
						goto IL_72;
					}
					IL_BC:;
				}
				finally
				{
					num = (short)1719074818;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1A0;
						case 1:
						{
							num = (short)1582368400;
							short num3 = num;
							num = (short)1523058320;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11E;
							default:
								num = (short)786497536;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)904527872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_F1;
							}
							continue;
						}
						goto IL_F1;
						IL_11E:
						num = (short)1894776833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_F1:
						num = (short)1261764609;
						if (num != 0)
						{
						}
						if (enumerator != null)
						{
							goto IL_11E;
						}
						break;
					}
					IL_1A0:;
				}
				num = (short)1171324928;
				short num4 = num;
				this.a.entitlementResponseList = list;
			}
		}

		// Token: 0x04000021 RID: 33
		private global::MSI.GetEntitlementResponse a = new global::MSI.GetEntitlementResponse();
	}
}
