using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x0200000D RID: 13
	public class EntitlementResponse
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000065C8 File Offset: 0x000047C8
		public static implicit operator global::MSI.EntitlementResponse(global::CommonLicenseInterfaceWrapper.EntitlementResponse parameter)
		{
			short num = (short)738852864;
			short num2 = num;
			num = (short)964251334;
			short num3 = num;
			num = (short)1922715334;
			switch (num3 == num)
			{
			}
			num = (short)169476097;
			if (num != 0)
			{
			}
			num = (short)2125529088;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006674 File Offset: 0x00004874
		public static implicit operator global::CommonLicenseInterfaceWrapper.EntitlementResponse(global::MSI.EntitlementResponse parameter)
		{
			short num = (short)1810956288;
			short num2 = num;
			num = (short)707595986;
			short num3 = num;
			num = (short)194842322;
			switch (num3 == num)
			{
			}
			num = (short)2136211457;
			if (num != 0)
			{
			}
			num = (short)1475674112;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.EntitlementResponse
			{
				a = parameter
			};
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000672C File Offset: 0x0000492C
		static EntitlementResponse()
		{
			short num = (short)1856569344;
			short num2 = num;
			num = (short)131705051;
			short num3 = num;
			num = (short)551856347;
			switch (num3 == num)
			{
			}
			num = (short)552730624;
			if (num != 0)
			{
			}
			num = (short)463667201;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000067DC File Offset: 0x000049DC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000069E0 File Offset: 0x00004BE0
		public global::System.Collections.Generic.IEnumerable<global::CommonLicenseInterfaceWrapper.LineItem> lineItemList
		{
			get
			{
				short num = (short)574029825;
				if (num != 0)
				{
				}
				num = (short)467861504;
				short num2 = num;
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.LineItem> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.LineItem>();
				global::System.Collections.Generic.IEnumerator<global::MSI.LineItem> enumerator = this.a.lineItemList.GetEnumerator();
				try
				{
					num = (short)144179200;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_88:
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 1:
							num = (short)735444995;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								global::MSI.LineItem parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)2062629726;
								short num4 = num;
								num = (short)1184643934;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1073872896;
									if (num != 0)
									{
									}
									num = (short)1560739844;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_88;
								}
							}
							num = (short)56885249;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_171;
						}
						IL_11D:
						num = (short)327745538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2:
						goto IL_11D;
					}
					IL_171:;
				}
				finally
				{
					num = (short)1936130050;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1014824961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1D6;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1A3;
							}
							continue;
						}
						IL_1A3:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1364918272;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1D6:;
				}
				return list;
			}
			set
			{
				global::System.Collections.Generic.List<global::MSI.LineItem> list = new global::System.Collections.Generic.List<global::MSI.LineItem>();
				global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.LineItem> enumerator = value.GetEnumerator();
				short num;
				try
				{
					num = (short)1773862912;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_2D:
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_47;
							}
							continue;
						case 1:
							num = (short)1969750019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							while (enumerator.MoveNext())
							{
								global::CommonLicenseInterfaceWrapper.LineItem parameter = enumerator.Current;
								list.Add(parameter);
								num = (short)425089701;
								short num3 = num;
								num = (short)870865573;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1673658368;
									if (num != 0)
									{
									}
									num = (short)962199556;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_2D;
								}
							}
							num = (short)56229889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_113;
						}
						IL_BF:
						num = (short)630587394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_47:
						goto IL_BF;
					}
					IL_113:;
				}
				finally
				{
					num = (short)764674050;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)752156673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_17C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_147;
							}
							continue;
						}
						IL_147:
						if (enumerator == null)
						{
							break;
						}
						num = (short)868483072;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_17C:;
				}
				num = (short)424738816;
				short num4 = num;
				num = (short)111476737;
				if (num != 0)
				{
				}
				this.a.lineItemList = list;
			}
		}

		// Token: 0x0400001C RID: 28
		private global::MSI.EntitlementResponse a = new global::MSI.EntitlementResponse();
	}
}
