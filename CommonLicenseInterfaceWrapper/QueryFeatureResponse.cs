using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000016 RID: 22
	public class QueryFeatureResponse
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0000ABFC File Offset: 0x00008DFC
		public static implicit operator global::MSI.QueryFeatureResponse(global::CommonLicenseInterfaceWrapper.QueryFeatureResponse parameter)
		{
			short num = (short)2003331270;
			short num2 = num;
			num = (short)403400902;
			switch (num2 == num)
			{
			}
			num = (short)1230176257;
			if (num != 0)
			{
			}
			num = (short)809435136;
			short num3 = num;
			num = (short)11862016;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000ACAC File Offset: 0x00008EAC
		public static implicit operator global::CommonLicenseInterfaceWrapper.QueryFeatureResponse(global::MSI.QueryFeatureResponse parameter)
		{
			short num = (short)556986126;
			short num2 = num;
			num = (short)1119874830;
			switch (num2 == num)
			{
			}
			num = (short)837156865;
			if (num != 0)
			{
			}
			num = (short)391839744;
			short num3 = num;
			num = (short)1083441152;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.QueryFeatureResponse
			{
				a = parameter
			};
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000AD64 File Offset: 0x00008F64
		static QueryFeatureResponse()
		{
			short num = (short)1450788125;
			short num2 = num;
			num = (short)488195357;
			switch (num2 == num)
			{
			}
			num = (short)1746599937;
			if (num != 0)
			{
			}
			num = (short)936312832;
			short num3 = num;
			num = (short)1091829760;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000AE18 File Offset: 0x00009018
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000B004 File Offset: 0x00009204
		public global::System.Collections.Generic.ICollection<global::CommonLicenseInterfaceWrapper.FeatureProperties> featurePropertiesList
		{
			get
			{
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureProperties> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.FeatureProperties>();
				global::System.Collections.Generic.IEnumerator<global::MSI.FeatureProperties> enumerator = this.a.featurePropertiesList.GetEnumerator();
				short num;
				try
				{
					num = (short)1974823287;
					short num2 = num;
					num = (short)1540581751;
					int num3;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_7B:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						break;
					default:
						num = (short)1698168832;
						if (num != 0)
						{
						}
						num = (short)122552323;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						IL_85:
						switch (num3)
						{
						case 0:
							num = (short)1539571716;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1959460864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::MSI.FeatureProperties parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)1370030081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_7B;
						case 4:
							goto IL_115;
						}
						break;
					}
					goto IL_CA;
					IL_115:
					goto IL_17D;
					IL_9F:
					IL_CA:
					num = (short)1551302658;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_85;
				}
				finally
				{
					num = (short)1320353793;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1182531586;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_147;
							}
							continue;
						case 2:
							goto IL_17A;
						}
						IL_147:
						if (enumerator == null)
						{
							break;
						}
						num = (short)748748800;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17A:;
				}
				IL_17D:
				num = (short)986710016;
				short num4 = num;
				num = (short)732758017;
				if (num != 0)
				{
				}
				return list;
			}
			set
			{
				short num = (short)1208745985;
				if (num != 0)
				{
				}
				num = (short)1067909120;
				short num2 = num;
				global::System.Collections.Generic.List<global::MSI.FeatureProperties> list = new global::System.Collections.Generic.List<global::MSI.FeatureProperties>();
				global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.FeatureProperties> enumerator = value.GetEnumerator();
				try
				{
					num = (short)252675758;
					short num3 = num;
					num = (short)1170048686;
					int num4;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_C0:
						switch (0)
						{
						case 0:
							goto IL_E4;
						}
						break;
					default:
						num = (short)674037760;
						if (num != 0)
						{
						}
						num = (short)517537795;
						num4 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						IL_CA:
						switch (num4)
						{
						case 0:
							num = (short)1582235652;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1742012416;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::CommonLicenseInterfaceWrapper.FeatureProperties parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)1882193921;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_C0;
						case 4:
							goto IL_15B;
						}
						break;
					}
					goto IL_110;
					IL_15B:
					goto IL_1C3;
					IL_E4:
					IL_110:
					num = (short)2112421890;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_CA;
				}
				finally
				{
					num = (short)1688600577;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1283588098;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_18D;
							}
							continue;
						case 2:
							goto IL_1C0;
						}
						IL_18D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)384696320;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1C0:;
				}
				IL_1C3:
				this.a.featurePropertiesList = list;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000B1F0 File Offset: 0x000093F0
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public global::System.Collections.Generic.IDictionary<string, string> dictionary
		{
			get
			{
				short num = (short)1173783188;
				short num2 = num;
				num = (short)1744011924;
				switch (num2 == num)
				{
				}
				num = (short)170393601;
				if (num != 0)
				{
				}
				num = (short)229376000;
				short num3 = num;
				num = (short)1498546176;
				if (num != 0)
				{
				}
				return this.a.dictionary;
			}
			set
			{
				short num = (short)691567772;
				short num2 = num;
				num = (short)1765637276;
				switch (num2 == num)
				{
				}
				num = (short)732299264;
				if (num != 0)
				{
				}
				num = (short)278331393;
				if (num != 0)
				{
				}
				num = (short)1525022720;
				short num3 = num;
				this.a.dictionary = value;
			}
		}

		// Token: 0x04000025 RID: 37
		private global::MSI.QueryFeatureResponse a = new global::MSI.QueryFeatureResponse();
	}
}
