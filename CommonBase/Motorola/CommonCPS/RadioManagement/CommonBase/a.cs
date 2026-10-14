using System;
using System.Globalization;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x02000009 RID: 9
	internal class a : global::Motorola.CommonCPS.RadioManagement.CommonBase.IResource
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public string GetStringByResourceID(string resourceID, string[] args = null)
		{
			short num = (short)1520893952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string result = resourceID;
				try
				{
					string text;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PACType bll_PAC;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_2C:
							switch (num2)
							{
							case 0:
								goto IL_324;
							case 1:
								if (args != null)
								{
									num = (short)1534853133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F9;
							case 2:
								goto IL_27C;
							case 3:
								if (text == null)
								{
									num = (short)558366726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_27C;
							case 4:
								if (args.Length == 0)
								{
									num = (short)1201078279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, text, args);
								num = (short)578355211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (text != null)
								{
									num = (short)8519688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_30B;
							case 6:
								text = global::RFResourceRepository.RFResources.ResourceManager.GetString(resourceID);
								num = (short)276692994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_F9;
							case 8:
								num = (short)1259405313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								switch (bll_PAC)
								{
								case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO:
								case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PBB:
									text = global::RFResourceRepository.ASTRORFResources.ResourceManager.GetString(resourceID);
									num = (short)1769406478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR:
									text = global::RFResourceRepository.PCRRFResources.ResourceManager.GetString(resourceID);
									num = (short)369557516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.TETRA:
									goto IL_1D4;
								default:
									num = (short)2110980106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 10:
								num = (short)619642895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_30B;
							case 12:
								goto IL_2D3;
							case 13:
								num = (short)146079748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_2D3;
							case 15:
								goto IL_1D4;
							case 16:
								goto IL_2D3;
							case 17:
								goto IL_30B;
							}
							goto IL_7B;
							IL_F9:
							result = text;
							num = (short)2138243089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1D4:
							text = null;
							num = (short)481668371;
							short num3 = num;
							num = (short)656190739;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_87;
							default:
								num = (short)1035862016;
								if (num != 0)
								{
								}
								num = (short)57016336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_27C:
							num = (short)1656094725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2D3:
							num = (short)1866727427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_30B:
							num = (short)1351680000;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_324:
						goto IL_329;
					}
					IL_7B:
					bll_PAC = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetBLL_PAC();
					text = "";
					IL_87:
					num = (short)8585225;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2C;
				}
				catch
				{
				}
				IL_329:
				num = (short)208535553;
				if (num != 0)
				{
				}
				num = (short)1674117120;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005E50 File Offset: 0x00004050
		public string GetStringByErrorAndResourceID(string resourceID, string[] args = null)
		{
			short num = (short)886833152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string result = resourceID;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					string text;
					global::Motorola.CommonCPS.Server.CommonDBConstants.PACType bll_PAC;
					for (;;)
					{
						IL_2D:
						switch (num2)
						{
						case 0:
							goto IL_204;
						case 1:
							if (args != null)
							{
								num = (short)543686668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_ED;
						case 2:
							goto IL_204;
						case 3:
							goto IL_ED;
						case 4:
							if (text != null)
							{
								num = (short)1318322183;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C0;
						case 5:
						{
							num = (short)2060188969;
							short num3 = num;
							num = (short)1182793001;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10D;
							default:
								num = (short)2005598208;
								if (num != 0)
								{
								}
								goto IL_2A0;
							}
							break;
						}
						case 6:
							switch (bll_PAC)
							{
							case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO:
							case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PBB:
								text = global::RFResourceRepository.ASTROResourceHelper.Instance().GetRFResourceByID(resourceID, null);
								num = (short)1958936576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR:
								text = global::RFResourceRepository.PCRResourceHelper.Instance().GetRFResourceByID(resourceID, null);
								num = (short)1595736072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.TETRA:
								goto IL_2A0;
							default:
								num = (short)1712193545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							num = (short)2040463361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_204;
						case 9:
							goto IL_10D;
						case 10:
							num = (short)865992705;
							if (num != 0)
							{
							}
							if (args.Length == 0)
							{
								num = (short)942735363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, text, args);
							num = (short)604897293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_2D8;
						case 12:
							num = (short)685899786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2C0;
						case 14:
							goto IL_2C0;
						}
						goto IL_70;
						IL_ED:
						result = text;
						num = (short)878968846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10D:
						num = (short)1348009989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_204:
						num = (short)1089798148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A0:
						text = resourceID;
						num = (short)139001858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C0:
						num = (short)591724555;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2D8:
					goto IL_2DD;
					IL_70:
					bll_PAC = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetBLL_PAC();
					text = "";
					num = (short)16121862;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2D;
				}
				catch
				{
				}
				IL_2DD:
				num = (short)944898048;
				short num4 = num;
				return result;
			}
			}
		}
	}
}
