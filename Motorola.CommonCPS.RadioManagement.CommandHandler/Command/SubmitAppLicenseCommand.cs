using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200008E RID: 142
	internal class SubmitAppLicenseCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00035FF8 File Offset: 0x000341F8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1457717248;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
				{
					if (registerApplicationLicenseContext.CurrentMode != 0)
					{
						num = (short)2011299847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)508235068;
					short num3 = num;
					num = (short)479595836;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B;
					default:
						num = (short)1111883776;
						if (num != 0)
						{
						}
						num = (short)1601110022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (registerApplicationLicenseContext == null)
					{
						num = (short)987234307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)7208961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return false;
				case 4:
					goto IL_19C;
				case 5:
					goto IL_5F;
				case 6:
					goto IL_EF;
				case 7:
					if (registerApplicationLicenseContext.CurrentMode == 1)
					{
						num = (short)1991180292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A0;
				}
				goto IL_44;
				IL_4B:
				num = (short)1160445957;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44:
				if (paras.Length == 0)
				{
					goto IL_4B;
				}
				registerApplicationLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext);
				num = (short)1198129154;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5F:
			num = (short)1512439809;
			if (num != 0)
			{
			}
			return false;
			IL_EF:
			return this.b(registerApplicationLicenseContext);
			IL_19C:
			return this.a(registerApplicationLicenseContext);
			IL_1A0:
			num = (short)1682374656;
			short num4 = num;
			return false;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000361D0 File Offset: 0x000343D0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)510066688;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 1:
					goto IL_203;
				case 2:
					goto IL_D8;
				case 3:
					goto IL_17A;
				case 4:
					if (registerApplicationLicenseContext.CurrentMode == 0)
					{
						num = (short)183173123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)10551304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_65;
				case 6:
					goto IL_13F;
				case 7:
				{
					num = (short)1205272576;
					short num3 = num;
					if (registerApplicationLicenseContext == null)
					{
						num = (short)1169424386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)991690761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (registerApplicationLicenseContext.CurrentMode == 1)
					{
						num = (short)1821048838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20A;
				case 9:
				{
					if (paras.Length != 0)
					{
						num = (short)675086340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1504254626;
					short num4 = num;
					num = (short)739580578;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20A;
					default:
						num = (short)643170304;
						if (num != 0)
						{
						}
						num = (short)943915009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4D:
				if (paras.Length == 0)
				{
					num = (short)113836037;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					registerApplicationLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext);
					num = (short)925302791;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_65:
			return null;
			IL_D8:
			num = (short)1104478209;
			if (num != 0)
			{
			}
			return null;
			IL_13F:
			return this.c(registerApplicationLicenseContext);
			IL_17A:
			return this.d(registerApplicationLicenseContext);
			IL_203:
			return null;
			IL_20A:
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000363E8 File Offset: 0x000345E8
		private object d(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext A_0)
		{
			short num = (short)1896952439;
			short num2 = num;
			num = (short)1737372279;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)88801281;
				if (num != 0)
				{
				}
				num = (short)1546452992;
				if (num != 0)
				{
				}
				num = (short)1473904640;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					case 1:
					{
						num = (short)1089142784;
						short num4 = num;
						if (list.Count == 0)
						{
							num = (short)1363345410;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					}
					case 2:
						goto IL_119;
					}
					IL_A0:
					list = A_0.EIDInfos.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidInfor)
					{
						short num5 = (short)532740843;
						short num6 = num5;
						num5 = (short)963443435;
						switch (num6 == num5)
						{
						}
						num5 = (short)1466236928;
						short num7 = num5;
						num5 = (short)934477825;
						if (num5 != 0)
						{
						}
						num5 = (short)1386872832;
						if (num5 != 0)
						{
						}
						return eidInfor.RadioCountUpdates > 0;
					}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>();
					num = (short)329908225;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_119:
				return null;
			}
			}
			IL_137:
			global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitAppLicenseBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitAppLicenseBatchOp(list);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>(op);
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0003653C File Offset: 0x0003473C
		private object c(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext A_0)
		{
			short num = (short)1145288280;
			short num2 = num;
			num = (short)61650520;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E4:
				num = (short)1323892737;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1023148032;
				if (num != 0)
				{
				}
				num = (short)591986689;
				if (num != 0)
				{
				}
				num = (short)1752825858;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_C4;
				case 1:
					goto IL_F8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				}
				IL_A2:
				if (global::System.IO.File.Exists(A_0.LicenseFile))
				{
					goto IL_DB;
				}
				num = (short)1182072832;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_FileOpenError);
			IL_DB:
			string licenseFile = A_0.LicenseFile;
			byte[] licenseFile2 = null;
			goto IL_E4;
			IL_F8:
			try
			{
				licenseFile2 = global::System.IO.File.ReadAllBytes(licenseFile);
				goto IL_105;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_FileNotFound);
			}
			goto IL_DB;
			IL_105:
			num = (short)66584576;
			short num4 = num;
			global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitAppLicenseFileOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.SubmitAppLicenseFileOp(licenseFile2);
			base.ExecuteBatchOp<string>(op);
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00036698 File Offset: 0x00034898
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext A_0)
		{
			short num = (short)1711538176;
			short num2 = num;
			num = (short)1408696323;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> enumerator;
				switch (num3)
				{
				case 0:
					return false;
				case 1:
					try
					{
						num = (short)661258243;
						num3 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)593821701;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)1785135104;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)238944262;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_152;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_C8;
								}
								continue;
							case 4:
								result = true;
								num = (short)619905026;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_16E;
							case 6:
								if (enumerator.Current.RadioCountUpdates > 0)
								{
									num = (short)1249181700;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_104:
							num = (short)580583425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C8:
							goto IL_104;
						}
						IL_152:
						return result;
						IL_16E:
						return false;
					}
					finally
					{
						num = (short)1491182415;
						short num4 = num;
						num = (short)2037883727;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1F2:
							num = (short)708837376;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1159200768;
							if (num != 0)
							{
							}
							num = (short)953548802;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1294270465;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_223;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1EF;
								}
								continue;
							}
							break;
						}
						IL_1EF:
						if (enumerator != null)
						{
							goto IL_1F2;
						}
						IL_223:;
					}
					goto IL_226;
				case 2:
				{
					bool result;
					try
					{
						num = (short)453378051;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)992083970;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo = enumerator.Current;
								num = (short)1736376324;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								result = false;
								num = (short)1243414534;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)212402181;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_2DF;
								}
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo eidinfo;
								if (eidinfo.RadioCountUpdates > int.Parse(eidinfo.Available, global::System.Globalization.CultureInfo.CurrentCulture))
								{
									num = (short)1075052545;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_39A;
							case 6:
								goto IL_2F7;
							}
							IL_34A:
							num = (short)153223168;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2DF:
							goto IL_34A;
						}
						IL_2F7:
						return result;
						IL_39A:
						goto IL_226;
					}
					finally
					{
						num = (short)389349378;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1363542017;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_404;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_3D0;
								}
								continue;
							}
							IL_3D0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)283049984;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_404:;
					}
					return result;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				}
				IL_5E:
				if (A_0.EIDInfos.Count == 0)
				{
					num = (short)993787904;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1470955521;
				if (num != 0)
				{
				}
				enumerator = A_0.EIDInfos.GetEnumerator();
				num = (short)980287490;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_226:
				enumerator = A_0.EIDInfos.GetEnumerator();
				num = (short)987430913;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00036AE4 File Offset: 0x00034CE4
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext A_0)
		{
			short num = (short)1740308481;
			if (num != 0)
			{
			}
			if (string.IsNullOrEmpty(A_0.LicenseFile))
			{
				num = (short)1486038844;
				short num2 = num;
				num = (short)508766012;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)639107072;
					short num3 = num;
					num = (short)370737152;
					if (num != 0)
					{
					}
					break;
				}
				}
				return false;
			}
			return true;
		}
	}
}
