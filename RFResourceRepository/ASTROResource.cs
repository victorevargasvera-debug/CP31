using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace RFResourceRepository
{
	// Token: 0x0200000A RID: 10
	public class ASTROResource : global::RFResourceRepository.RFResourceHelperBase
	{
		// Token: 0x06004096 RID: 16534 RVA: 0x00348E1C File Offset: 0x0034701C
		public override string GetRFResourceValueByResourceID(string resourceID, string[] args = null)
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
						goto IL_2C;
					}
					int num;
					string @string;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_86;
						case 1:
							if (@string == null)
							{
								num2 = (short)1773797379;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)904462337;
							if (num2 != 0)
							{
							}
							result = @string;
							num2 = (short)624427014;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_81;
						case 3:
							result = resourceID;
							num2 = (short)181469186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							if (@string == null)
							{
								num2 = (short)1306132485;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_86;
						case 5:
						{
							num2 = (short)1002481313;
							short num3 = num2;
							num2 = (short)2095294113;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)928645120;
								if (num2 != 0)
								{
								}
								@string = global::RFResourceRepository.RFResources.ResourceManager.GetString(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
								num2 = (short)904855552;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 6:
							goto IL_176;
						}
						break;
						IL_86:
						num2 = (short)1666318337;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_2C:
					@string = global::RFResourceRepository.ASTRORFResources.ResourceManager.GetString(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
					num2 = (short)379060228;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_81:
				IL_176:;
			}
			catch
			{
				result = resourceID;
			}
			num2 = (short)1351680000;
			short num4 = num2;
			return result;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00348FEC File Offset: 0x003471EC
		public override global::System.Resources.ResourceManager GetRFResourceManager()
		{
			short num = (short)1548723715;
			short num2 = num;
			num = (short)1231529475;
			switch (num2 == num)
			{
			}
			num = (short)1559363585;
			if (num != 0)
			{
			}
			num = (short)1249181696;
			short num3 = num;
			num = (short)868155392;
			if (num != 0)
			{
			}
			return global::RFResourceRepository.ASTRORFResources.ResourceManager;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0034909C File Offset: 0x0034729C
		public override string GetErrorMessageByID(string errorID, string[] args = null)
		{
			short num;
			string result;
			try
			{
				num = (short)519391663;
				short num2 = num;
				num = (short)112216495;
				global::System.Reflection.PropertyInfo property;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1FE:
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
					num = (short)2125201419;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)529006592;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					break;
				}
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						goto IL_180;
					case 1:
						goto IL_185;
					case 2:
						if (args.Length == 0)
						{
							num = (short)888471562;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE;
					case 3:
						num = (short)969342978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_128;
					case 5:
						if (property == null)
						{
							num = (short)662962185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					case 6:
						result = errorID;
						num = (short)1125253124;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (property == null)
						{
							num = (short)1808531462;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2039545864;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (args != null)
						{
							num = (short)150470659;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 9:
						property = typeof(global::RFResourceRepository.RFErrorResources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						num = (short)1336147969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_15A;
					case 11:
						goto IL_231;
					}
					goto IL_8B;
					IL_15A:
					result = property.GetValue(null, null).ToString();
					num = (short)231997440;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)822149127;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				IL_180:
				IL_231:
				goto IL_238;
				IL_8B:
				property = typeof(global::RFResourceRepository.ASTRORFErrorResources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				num = (short)1182662661;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			catch
			{
				result = errorID;
			}
			IL_238:
			num = (short)1928462336;
			short num4 = num;
			num = (short)1667170305;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00349350 File Offset: 0x00347550
		public override string GetResourceByID(string resourceID, string[] args = null)
		{
			short num;
			string result;
			try
			{
				num = (short)409083957;
				short num2 = num;
				num = (short)871178293;
				global::System.Reflection.PropertyInfo property;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1FB:
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
					num = (short)1671888907;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1172897792;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					break;
				}
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
						goto IL_17F;
					case 1:
						goto IL_184;
					case 2:
						if (args.Length == 0)
						{
							num = (short)419299338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB;
					case 3:
						num = (short)1608450050;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_128;
					case 5:
						if (property == null)
						{
							num = (short)2012741641;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 6:
						result = resourceID;
						num = (short)1595408388;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (property == null)
						{
							num = (short)1042612230;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1881604104;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (args != null)
						{
							num = (short)2023424003;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 9:
						property = typeof(global::RFResourceRepository.RFResources).GetProperty(resourceID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						num = (short)197001217;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_15A;
					case 11:
						goto IL_22D;
					}
					goto IL_8C;
					IL_15A:
					result = property.GetValue(null, null).ToString();
					num = (short)1124335616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_184:
					num = (short)1278148615;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				IL_17F:
				IL_22D:
				goto IL_234;
				IL_8C:
				property = typeof(global::RFResourceRepository.ASTRORFResources).GetProperty(resourceID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				num = (short)222298117;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			catch
			{
				result = resourceID;
			}
			IL_234:
			num = (short)967507968;
			short num4 = num;
			num = (short)1058996225;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
