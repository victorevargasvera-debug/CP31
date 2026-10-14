using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace RFResourceRepository
{
	// Token: 0x0200000F RID: 15
	public class RFResource : global::RFResourceRepository.RFResourceHelperBase
	{
		// Token: 0x060040AC RID: 16556 RVA: 0x0034A628 File Offset: 0x00348828
		public override string GetRFResourceValueByResourceID(string resourceID, string[] args = null)
		{
			short num2;
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				string @string;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1658368620;
						short num3 = num2;
						num2 = (short)888844908;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B1;
						default:
							num2 = (short)398262272;
							if (num2 != 0)
							{
							}
							if (@string == null)
							{
								num2 = (short)981073921;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = @string;
							num2 = (short)1063714819;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_B1;
					case 2:
						goto IL_CB;
					case 3:
						goto IL_E8;
					}
					goto IL_20;
					IL_B1:
					result = resourceID;
					num2 = (short)1774911490;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_CB:
				IL_E8:
				goto IL_EF;
				IL_20:
				@string = global::RFResourceRepository.RFResources.ResourceManager.GetString(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
				num2 = (short)531431424;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch
			{
				result = resourceID;
			}
			IL_EF:
			num2 = (short)1289879552;
			short num4 = num2;
			num2 = (short)2090795009;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0034A788 File Offset: 0x00348988
		public override global::System.Resources.ResourceManager GetRFResourceManager()
		{
			short num = (short)1551357317;
			short num2 = num;
			num = (short)152753541;
			switch (num2 == num)
			{
			}
			num = (short)1893531649;
			if (num != 0)
			{
			}
			num = (short)577765376;
			short num3 = num;
			num = (short)1222901760;
			if (num != 0)
			{
			}
			return global::RFResourceRepository.RFResources.ResourceManager;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0034A838 File Offset: 0x00348A38
		public override string GetErrorMessageByID(string errorID, string[] args = null)
		{
			short num2;
			string result;
			try
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					int num;
					global::System.Reflection.PropertyInfo property;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_157;
						case 1:
							if (property == null)
							{
								num2 = (short)240058371;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)954990598;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_1B3;
						case 3:
							result = errorID;
							num2 = (short)699138048;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							goto IL_159;
						case 5:
						{
							if (args.Length != 0)
							{
								result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
								num2 = (short)2062745602;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)656639991;
							short num3 = num2;
							num2 = (short)869697527;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1988296704;
								if (num2 != 0)
								{
								}
								num2 = (short)1438187524;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 6:
							if (args != null)
							{
								num2 = (short)124715015;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_159;
						case 7:
							num2 = (short)2072444933;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 8:
							goto IL_17E;
						}
						break;
						IL_159:
						result = property.GetValue(null, null).ToString();
						num2 = (short)1056702472;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_34:
					property = typeof(global::RFResourceRepository.RFErrorResources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
					num2 = (short)626851841;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_157:
				IL_17E:
				IL_1B3:;
			}
			catch
			{
				result = errorID;
			}
			num2 = (short)503185408;
			short num4 = num2;
			num2 = (short)226492417;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0034AA70 File Offset: 0x00348C70
		public override string GetResourceByID(string resourceID, string[] args = null)
		{
			short num2;
			string result;
			try
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					int num;
					global::System.Reflection.PropertyInfo property;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_158;
						case 1:
							if (property == null)
							{
								num2 = (short)2029453315;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)152174598;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_1B4;
						case 3:
							result = resourceID;
							num2 = (short)570163200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							goto IL_15A;
						case 5:
						{
							if (args.Length != 0)
							{
								result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
								num2 = (short)605487106;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)2081146764;
							short num3 = num2;
							num2 = (short)786220940;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)354091008;
								if (num2 != 0)
								{
								}
								num2 = (short)2005532676;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 6:
							if (args != null)
							{
								num2 = (short)871301127;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_15A;
						case 7:
							num2 = (short)751960069;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 8:
							goto IL_180;
						}
						break;
						IL_15A:
						result = property.GetValue(null, null).ToString();
						num2 = (short)1628307464;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_34:
					property = typeof(global::RFResourceRepository.RFResources).GetProperty(resourceID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
					num2 = (short)152633345;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_158:
				IL_180:
				IL_1B4:;
			}
			catch
			{
				result = resourceID;
			}
			num2 = (short)2023424000;
			short num4 = num2;
			num2 = (short)1023803393;
			if (num2 != 0)
			{
			}
			return result;
		}
	}
}
