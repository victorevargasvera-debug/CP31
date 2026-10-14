using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace RFResourceRepository
{
	// Token: 0x0200000D RID: 13
	public class PCRResource : global::RFResourceRepository.RFResourceHelperBase
	{
		// Token: 0x060040A4 RID: 16548 RVA: 0x00349BC4 File Offset: 0x00347DC4
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
							goto IL_87;
						case 1:
							if (@string == null)
							{
								num2 = (short)813629443;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = @string;
							num2 = (short)1715339270;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_82;
						case 3:
							result = resourceID;
							num2 = (short)261816322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							if (@string == null)
							{
								num2 = (short)814350341;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_87;
						case 5:
						{
							num2 = (short)2049446834;
							short num3 = num2;
							num2 = (short)1366430642;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)835649536;
								if (num2 != 0)
								{
								}
								@string = global::RFResourceRepository.RFResources.ResourceManager.GetString(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
								num2 = (short)1907752960;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 6:
							goto IL_152;
						}
						break;
						IL_87:
						num2 = (short)857735169;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_2C:
					@string = global::RFResourceRepository.PCRRFResources.ResourceManager.GetString(resourceID, global::System.Globalization.CultureInfo.CurrentCulture);
					num2 = (short)140574724;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_82:
				IL_152:;
			}
			catch
			{
				result = resourceID;
			}
			num2 = (short)2029846528;
			short num4 = num2;
			num2 = (short)801964033;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00349D9C File Offset: 0x00347F9C
		public override global::System.Resources.ResourceManager GetRFResourceManager()
		{
			short num = (short)874819855;
			short num2 = num;
			num = (short)758165775;
			switch (num2 == num)
			{
			}
			num = (short)284426240;
			if (num != 0)
			{
			}
			num = (short)1490550784;
			short num3 = num;
			num = (short)470220801;
			if (num != 0)
			{
			}
			return global::RFResourceRepository.PCRRFResources.ResourceManager;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x00349E4C File Offset: 0x0034804C
		public override string GetErrorMessageByID(string errorID, string[] args = null)
		{
			short num;
			string result;
			try
			{
				num = (short)2145123667;
				short num2 = num;
				num = (short)469695827;
				global::System.Reflection.PropertyInfo property;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_221:
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
					num = (short)1711407115;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)799211520;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					break;
				}
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						goto IL_1A5;
					case 1:
						goto IL_1AA;
					case 2:
						if (args.Length == 0)
						{
							num = (short)250019850;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 3:
						num = (short)95748098;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_14E;
					case 5:
						num = (short)1878196225;
						if (num != 0)
						{
						}
						if (property == null)
						{
							num = (short)342949897;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AA;
					case 6:
						result = errorID;
						num = (short)1517879300;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (property == null)
						{
							num = (short)223215622;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)45350920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (args != null)
						{
							num = (short)1717633027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180;
					case 9:
						property = typeof(global::RFResourceRepository.RFErrorResources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						num = (short)674627585;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_180;
					case 11:
						goto IL_254;
					}
					goto IL_8A;
					IL_180:
					result = property.GetValue(null, null).ToString();
					num = (short)1222836224;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AA:
					num = (short)887881735;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_14E:
				IL_1A5:
				IL_254:
				goto IL_25B;
				IL_8A:
				property = typeof(global::RFResourceRepository.PCRRFErrorResources).GetProperty(errorID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				num = (short)180486149;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			catch
			{
				result = errorID;
			}
			IL_25B:
			num = (short)298844160;
			short num4 = num;
			return result;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0034A0FC File Offset: 0x003482FC
		public override string GetResourceByID(string resourceID, string[] args = null)
		{
			short num2;
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				int num;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_133;
					case 1:
						goto IL_138;
					case 2:
						if (args.Length == 0)
						{
							num2 = (short)39452682;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, property.GetValue(null, null).ToString(), args);
						num2 = (short)1646854155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)440270850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_DC;
					case 5:
						if (property == null)
						{
							num2 = (short)189071369;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_138;
					case 6:
						goto IL_C2;
					case 7:
						if (property == null)
						{
							num2 = (short)221904902;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1044905992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
					{
						if (args == null)
						{
							goto IL_10E;
						}
						num2 = (short)1325590912;
						short num3 = num2;
						num2 = (short)531884416;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C2;
						default:
							num2 = (short)346750977;
							if (num2 != 0)
							{
							}
							num2 = (short)1690763264;
							if (num2 != 0)
							{
							}
							num2 = (short)449839107;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 9:
						property = typeof(global::RFResourceRepository.RFResources).GetProperty(resourceID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						num2 = (short)1334771713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_10E;
					case 11:
						goto IL_254;
					}
					goto IL_40;
					IL_C2:
					result = resourceID;
					num2 = (short)1588330500;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_10E:
					result = property.GetValue(null, null).ToString();
					num2 = (short)1234239488;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_138:
					num2 = (short)1975517191;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_DC:
				IL_133:
				IL_254:
				goto IL_25B;
				IL_40:
				property = typeof(global::RFResourceRepository.PCRRFResources).GetProperty(resourceID, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				num2 = (short)627179525;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch
			{
				result = resourceID;
			}
			IL_25B:
			num2 = (short)1214447616;
			short num4 = num2;
			return result;
		}
	}
}
