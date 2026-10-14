using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.RMDiscoveryServiceInterface;
using Motorola.Security.SamlTokenComponent;

namespace AutoUpdate
{
	// Token: 0x02000005 RID: 5
	public class AutoUpdateHelper
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003124 File Offset: 0x00001324
		public static global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement GetChannel(string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType = "RMDiscoveryServer", string pac = "", string userName = null, global::System.Security.SecureString pswd = null, bool activating = false, string jwtToken = null)
		{
			short num = (short)1543943912;
			short num2 = num;
			num = (short)2054207208;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1504641024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1982464001;
			if (num != 0)
			{
			}
			num = (short)794492928;
			if (num != 0)
			{
			}
			global::AutoUpdate.AutoUpdateHelper.channel = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx2<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement>(currentUserType, authType, discoveryHost, discoveryPort, svcType, pac, userName, pswd, activating, 5, 2000, "", jwtToken);
			return global::AutoUpdate.AutoUpdateHelper.channel.CreateChannel();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003200 File Offset: 0x00001400
		private static string b()
		{
			short num;
			string fullName;
			try
			{
				num = (short)1203408818;
				short num2 = num;
				num = (short)1731039154;
				switch (num2 == num)
				{
				}
				num = (short)1524105216;
				if (num != 0)
				{
				}
				fullName = global::System.IO.Directory.CreateDirectory(global::AutoUpdate.AutoUpdateHelper.AutoUpdateDir, global::AutoUpdate.AutoUpdateHelper.a()).FullName;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AutoUpdate_Create_DownloadFolder_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.AutoUpdate_Create_DownloadFolder_Error, ex);
			}
			num = (short)21430272;
			short num3 = num;
			num = (short)1814167553;
			if (num != 0)
			{
			}
			return fullName;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000032E4 File Offset: 0x000014E4
		private static string d(string A_0)
		{
			short num;
			string fullName;
			try
			{
				num = (short)620185187;
				short num2 = num;
				num = (short)833832547;
				switch (num2 == num)
				{
				}
				num = (short)768278528;
				if (num != 0)
				{
				}
				num = (short)1045102593;
				if (num != 0)
				{
				}
				fullName = global::System.IO.Directory.CreateDirectory(global::System.IO.Path.Combine(A_0, global::System.Guid.NewGuid().ToString()), global::AutoUpdate.AutoUpdateHelper.a()).FullName;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AutoUpdate_Create_DownloadFolder_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.AutoUpdate_Create_DownloadFolder_Error, ex);
			}
			num = (short)683606016;
			short num3 = num;
			return fullName;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033D8 File Offset: 0x000015D8
		private static void c(string A_0)
		{
			short num;
			try
			{
				num = (short)2111332366;
				short num2 = num;
				num = (short)1556439054;
				switch (num2 == num)
				{
				}
				num = (short)536018944;
				if (num != 0)
				{
				}
				global::System.IO.File.Delete(A_0);
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AutoUpdate_DeleteExistingDownloadFile_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.AutoUpdate_DeleteExistingDownloadFile_Error, ex);
			}
			num = (short)1020788736;
			short num3 = num;
			num = (short)1826291713;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000034AC File Offset: 0x000016AC
		private static bool a(global::System.DateTime A_0, long A_1, long A_2, long A_3, long A_4, global::System.IProgress<global::AutoUpdate.DownloadStatus> A_5 = null)
		{
			short num = (short)1149114955;
			short num2 = num;
			num = (short)27073099;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_101:
				num = (short)1635188740;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1351221248;
				if (num != 0)
				{
				}
				num = (short)1678508034;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_101;
				case 1:
					goto IL_136;
				case 2:
					num = (short)2055077889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 3:
				{
					global::AutoUpdate.DownloadStatus downloadStatus = new global::AutoUpdate.DownloadStatus();
					downloadStatus.Update(A_0, A_2, A_3, A_4);
					A_5.Report(downloadStatus);
					num = (short)236257281;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (A_5 != null)
					{
						num = (short)1291059203;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_AC:
				num = (short)794755072;
				short num4 = num;
				int num5 = (int)(A_1 * 100L / A_3);
				int num6 = (int)(A_2 * 100L / A_3);
				if (num5 == num6)
				{
					return false;
				}
				num = (short)1170407424;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_136:
			return true;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003628 File Offset: 0x00001828
		private static global::System.Threading.Tasks.Task a(global::System.IO.Stream A_0, string A_1, global::System.Threading.CancellationTokenSource A_2, long A_3, long A_4 = 0L, global::System.Security.Cryptography.HashAlgorithm A_5 = null, global::System.IProgress<global::AutoUpdate.DownloadStatus> A_6 = null)
		{
			short num = (short)717497294;
			short num2 = num;
			num = (short)2002723790;
			switch (num2 == num)
			{
			}
			num = (short)761659392;
			if (num != 0)
			{
			}
			num = (short)107675649;
			if (num != 0)
			{
			}
			num = (short)2125725696;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.a a;
			a.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			a.e = A_0;
			a.c = A_1;
			a.f = A_2;
			a.h = A_3;
			a.d = A_4;
			a.g = A_5;
			a.i = A_6;
			a.a = -1;
			a.b.Start<global::AutoUpdate.AutoUpdateHelper.a>(ref a);
			return a.b.Task;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000373C File Offset: 0x0000193C
		public static global::System.Threading.Tasks.Task<global::AutoUpdate.AutoUpgradeFile> GetFile(string clientName, string pac, global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement discoveryClient, global::System.Threading.CancellationTokenSource token, global::System.IProgress<global::AutoUpdate.DownloadStatus> progressReport = null)
		{
			short num = (short)1490397208;
			short num2 = num;
			num = (short)1145219096;
			switch (num2 == num)
			{
			}
			num = (short)148373505;
			if (num != 0)
			{
			}
			num = (short)796786688;
			if (num != 0)
			{
			}
			num = (short)406716416;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.b b;
			b.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::AutoUpdate.AutoUpgradeFile>.Create();
			b.c = clientName;
			b.d = pac;
			b.e = discoveryClient;
			b.f = token;
			b.g = progressReport;
			b.a = -1;
			b.b.Start<global::AutoUpdate.AutoUpdateHelper.b>(ref b);
			return b.b.Task;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000383C File Offset: 0x00001A3C
		private static bool a(long A_0, string A_1)
		{
			short num = (short)1999003931;
			short num2 = num;
			num = (short)1720672539;
			switch (num2 == num)
			{
			}
			num = (short)1837760513;
			if (num != 0)
			{
			}
			num = (short)1500053504;
			if (num != 0)
			{
			}
			num = (short)1366228992;
			short num3 = num;
			return new global::System.IO.DriveInfo(global::System.IO.Path.GetPathRoot(A_1)).AvailableFreeSpace > A_0 * 3L;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000038FC File Offset: 0x00001AFC
		private static global::System.Threading.Tasks.Task<bool> b(string A_0)
		{
			short num = (short)671028589;
			short num2 = num;
			num = (short)2117801325;
			switch (num2 == num)
			{
			}
			num = (short)1663107072;
			if (num != 0)
			{
			}
			num = (short)292290561;
			if (num != 0)
			{
			}
			num = (short)575143936;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.c c;
			c.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			c.c = A_0;
			c.a = -1;
			c.b.Start<global::AutoUpdate.AutoUpdateHelper.c>(ref c);
			return c.b.Task;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000039DC File Offset: 0x00001BDC
		private static global::System.Threading.Tasks.Task a(string A_0, string A_1, long A_2, long A_3, global::System.Threading.CancellationTokenSource A_4, global::System.IProgress<global::AutoUpdate.DownloadStatus> A_5 = null)
		{
			short num = (short)412614657;
			if (num != 0)
			{
			}
			num = (short)1131774825;
			short num2 = num;
			num = (short)1424655209;
			switch (num2 == num)
			{
			}
			num = (short)1631453184;
			if (num != 0)
			{
			}
			num = (short)380698624;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.d d;
			d.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			d.c = A_0;
			d.g = A_1;
			d.d = A_2;
			d.e = A_3;
			d.f = A_4;
			d.h = A_5;
			d.a = -1;
			d.b.Start<global::AutoUpdate.AutoUpdateHelper.d>(ref d);
			return d.b.Task;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003AE4 File Offset: 0x00001CE4
		private static byte[] a(global::System.Security.Cryptography.HashAlgorithm A_0, string A_1)
		{
			short num = (short)420766821;
			short num2 = num;
			num = (short)1721525349;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1884422144;
				if (num != 0)
				{
				}
				num = (short)458096641;
				if (num != 0)
				{
				}
				num = (short)951844864;
				short num3 = num;
				global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(A_1);
				try
				{
					result = A_0.ComputeHash(fileStream);
				}
				finally
				{
					num = (short)663552001;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_113;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DE;
							}
							continue;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)2110455808;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DE:
						if (fileStream == null)
						{
							break;
						}
						num = (short)465043458;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_113:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003C18 File Offset: 0x00001E18
		public static global::System.Threading.Tasks.Task<string> GetFileByHttpMultiThread(string url, string filePath, long fileLength, global::System.Threading.CancellationTokenSource token, global::System.IProgress<global::AutoUpdate.DownloadStatus> progressReport = null)
		{
			short num = (short)1210561850;
			short num2 = num;
			num = (short)1244312890;
			switch (num2 == num)
			{
			}
			num = (short)1502543873;
			if (num != 0)
			{
			}
			num = (short)2019098624;
			if (num != 0)
			{
			}
			num = (short)538312704;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.f f;
			f.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			f.e = url;
			f.f = filePath;
			f.c = fileLength;
			f.g = token;
			f.d = progressReport;
			f.a = -1;
			f.b.Start<global::AutoUpdate.AutoUpdateHelper.f>(ref f);
			return f.b.Task;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003D18 File Offset: 0x00001F18
		public static global::System.Threading.Tasks.Task<string> GetFileByHttpSingleThread(string url, string filePath, long fileLength, global::System.Threading.CancellationTokenSource token, global::System.IProgress<global::AutoUpdate.DownloadStatus> progressReport = null)
		{
			short num = (short)1380902264;
			short num2 = num;
			num = (short)1739908472;
			switch (num2 == num)
			{
			}
			num = (short)814743553;
			if (num != 0)
			{
			}
			num = (short)25821184;
			if (num != 0)
			{
			}
			num = (short)850132992;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.g g;
			g.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			g.c = url;
			g.d = filePath;
			g.f = fileLength;
			g.e = token;
			g.g = progressReport;
			g.a = -1;
			g.b.Start<global::AutoUpdate.AutoUpdateHelper.g>(ref g);
			return g.b.Task;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003E18 File Offset: 0x00002018
		public static global::System.Threading.Tasks.Task<global::AutoUpdate.AutoUpgradeFile> GetFileByHttp(string clientName, string pac, string family, global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement discoveryClient, global::System.Threading.CancellationTokenSource token, global::System.IProgress<global::AutoUpdate.DownloadStatus> progressReport = null)
		{
			short num = (short)1583446524;
			short num2 = num;
			num = (short)297171452;
			switch (num2 == num)
			{
			}
			num = (short)274661376;
			if (num != 0)
			{
			}
			num = (short)1156775937;
			if (num != 0)
			{
			}
			num = (short)1336868864;
			short num3 = num;
			global::AutoUpdate.AutoUpdateHelper.h h;
			h.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::AutoUpdate.AutoUpgradeFile>.Create();
			h.c = clientName;
			h.d = pac;
			h.e = family;
			h.f = discoveryClient;
			h.g = token;
			h.h = progressReport;
			h.a = -1;
			h.b.Start<global::AutoUpdate.AutoUpdateHelper.h>(ref h);
			return h.b.Task;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003F20 File Offset: 0x00002120
		private static string a(string A_0)
		{
			short num = (short)1219656143;
			short num2 = num;
			num = (short)271022543;
			switch (num2 == num)
			{
			}
			num = (short)2070872064;
			if (num != 0)
			{
			}
			num = (short)50003969;
			if (num != 0)
			{
			}
			num = (short)392036352;
			short num3 = num;
			string text = global::System.IO.Path.Combine(global::AutoUpdate.AutoUpdateHelper.d(global::AutoUpdate.AutoUpdateHelper.b()), A_0);
			global::AutoUpdate.AutoUpdateHelper.c(text);
			global::System.IO.File.Create(text).Dispose();
			return text;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003FEC File Offset: 0x000021EC
		public static void StartCpsInstallation(string filePath, string commandLineArguments)
		{
			short num = (short)1175322624;
			switch (num)
			{
			default:
			{
				num = (short)1112014849;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)740884480;
					short num3 = num;
					num = (short)373293057;
					if (num != 0)
					{
					}
					global::System.Diagnostics.Process process;
					switch (num2)
					{
					case 0:
						try
						{
							process.Start();
							return;
						}
						catch (global::System.Exception ex)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Starting_Installation_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.Starting_Installation_Failed, ex);
						}
						finally
						{
							num = (short)1361379329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_14D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_117;
									}
									continue;
								case 2:
									((global::System.IDisposable)process).Dispose();
									num = (short)1190330368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_117:
								if (process == null)
								{
									break;
								}
								num = (short)1494679554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_14D:;
						}
						goto IL_150;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 2:
						goto IL_150;
					}
					IL_9F:
					if (global::System.IO.File.Exists(filePath))
					{
						num = (short)17104898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_150:
					global::System.Diagnostics.ProcessStartInfo startInfo = new global::System.Diagnostics.ProcessStartInfo(filePath, commandLineArguments);
					process = new global::System.Diagnostics.Process
					{
						StartInfo = startInfo
					};
					num = (short)928899808;
					short num4 = num;
					num = (short)559735520;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)1063714816;
						if (num != 0)
						{
						}
						num = (short)817102848;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.Generic_File_Does_NOT_Exist.ToString(), null));
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004208 File Offset: 0x00002408
		public static bool CheckIfUserIsAdmin()
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)746520576;
				switch (num)
				{
				default:
				{
					result = false;
					try
					{
						global::System.DirectoryServices.AccountManagement.PrincipalContext principalContext = new global::System.DirectoryServices.AccountManagement.PrincipalContext(global::System.DirectoryServices.AccountManagement.ContextType.Machine, null);
						try
						{
							num = (short)1355743232;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_62;
									}
									continue;
								case 1:
									goto IL_CF;
								case 2:
									result = true;
									num = (short)1483472899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_B7;
								}
								IL_62:
								global::System.DirectoryServices.AccountManagement.Principal principal = global::System.DirectoryServices.AccountManagement.UserPrincipal.Current;
								string identityValue = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.BuiltinAdministratorsSid, null).ToString();
								global::System.DirectoryServices.AccountManagement.GroupPrincipal group = global::System.DirectoryServices.AccountManagement.GroupPrincipal.FindByIdentity(principalContext, identityValue);
								if (principal.IsMemberOf(group))
								{
									num = (short)1979908098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B7:
								num = (short)790102017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CF:;
						}
						finally
						{
							num = (short)1754660865;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_139;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_104;
									}
									continue;
								case 2:
									((global::System.IDisposable)principalContext).Dispose();
									num = (short)1592721408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_104:
								if (principalContext == null)
								{
									break;
								}
								num = (short)485228546;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_139:;
						}
					}
					catch
					{
						result = false;
					}
					num = (short)412793155;
					short num3 = num;
					num = (short)463518019;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_177;
					}
					break;
				}
				}
			}
			IL_177:
			num = (short)1629093889;
			if (num != 0)
			{
			}
			num = (short)1227882496;
			short num4 = num;
			num = (short)254935040;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004428 File Offset: 0x00002628
		public static void KillAllOtherInstancesOfCurrentProcess()
		{
			short num = (short)73728000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::System.Diagnostics.Process[] processesByName;
				int num3;
				string fileName;
				global::System.Diagnostics.Process currentProcess;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (processesByName[num3].MainModule.FileName.Equals(fileName))
						{
							num = (short)97648646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D;
					case 2:
						goto IL_18D;
					case 3:
					{
						num = (short)1750794240;
						short num4 = num;
						if (currentProcess.Id != processesByName[num3].Id)
						{
							num = (short)639500292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D;
					}
					case 4:
						processesByName[num3].Kill();
						num = (short)249626631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_18D;
					case 6:
					{
						num = (short)1194896664;
						short num5 = num;
						num = (short)1598467352;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18D;
						default:
							num = (short)1627717632;
							if (num != 0)
							{
							}
							num = (short)1891041283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)441581569;
						if (num != 0)
						{
						}
						goto IL_8D;
					case 8:
						if (num3 >= processesByName.Length)
						{
							num = (short)1619132416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1850343425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_52;
					IL_8D:
					num3++;
					num = (short)741081093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)441581576;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				currentProcess = global::System.Diagnostics.Process.GetCurrentProcess();
				fileName = currentProcess.MainModule.FileName;
				processesByName = global::System.Diagnostics.Process.GetProcessesByName(currentProcess.ProcessName);
				num3 = 0;
				num = (short)1567227906;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004670 File Offset: 0x00002870
		public static int DetectAllOtherInstancesOfCurrentProcess()
		{
			short num = (short)1788870656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num3;
				global::System.Diagnostics.Process[] processesByName;
				int num4;
				string fileName;
				global::System.Diagnostics.Process currentProcess;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return num3;
					case 1:
						if (processesByName[num4].MainModule.FileName.Equals(fileName))
						{
							num = (short)908656641;
							if (num != 0)
							{
							}
							num = (short)139198470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					case 2:
						goto IL_18F;
					case 3:
					{
						num = (short)1213988864;
						short num5 = num;
						if (currentProcess.Id != processesByName[num4].Id)
						{
							num = (short)241762308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
					}
					case 4:
						num3++;
						num = (short)487129095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_18F;
					case 6:
					{
						num = (short)1148085148;
						short num6 = num;
						num = (short)1911710620;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18F;
						default:
							num = (short)392036352;
							if (num != 0)
							{
							}
							num = (short)299368451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_8F;
					case 8:
						if (num4 >= processesByName.Length)
						{
							num = (short)1441136640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1681981441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_52;
					IL_8F:
					num4++;
					num = (short)1182924805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F:
					num = (short)861274120;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num3;
				IL_52:
				num3 = 0;
				currentProcess = global::System.Diagnostics.Process.GetCurrentProcess();
				fileName = currentProcess.MainModule.FileName;
				processesByName = global::System.Diagnostics.Process.GetProcessesByName(currentProcess.ProcessName);
				num4 = 0;
				num = (short)635961346;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000048BC File Offset: 0x00002ABC
		public static bool CheckIfOtherInstallationIsInProgress()
		{
			short num = (short)1144782852;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.ServiceProcess.ServiceController serviceController;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (serviceController.CanShutdown)
					{
						num = (short)43581442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (serviceController == null)
					{
						num = (short)1243545605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1312030720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1125730432;
					short num3 = num;
					num = (short)697649280;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E9;
					}
					break;
				}
				case 3:
					return false;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					num = (short)549584899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				num = (short)1303969792;
				short num4 = num;
				serviceController = global::System.ServiceProcess.ServiceController.GetServices().FirstOrDefault(new global::System.Func<global::System.ServiceProcess.ServiceController, bool>(global::AutoUpdate.AutoUpdateHelper.<>c.<>9.a));
				num = (short)1841496065;
				if (num != 0)
				{
				}
				num = (short)1960509441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			num = (short)722862080;
			if (num != 0)
			{
			}
			return !serviceController.CanStop;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004A70 File Offset: 0x00002C70
		public static bool CompareUpgradePackageVersiontoLocal(string upgradePackageVersion)
		{
			short num = (short)1170341888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_14E;
					case 1:
					{
						global::System.Version v;
						global::System.Version version;
						if (v > version)
						{
							num = (short)23199744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
					{
						try
						{
							global::System.Version v = new global::System.Version(upgradePackageVersion);
							goto IL_5B;
						}
						catch
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Invalid_VersionNumber_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.Invalid_VersionNumber_Error.ToString(), null));
						}
						goto IL_14E;
						IL_5B:
						num = (short)1638201461;
						short num3 = num;
						num = (short)1867184245;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)214827008;
							short num4 = num;
							break;
						}
						}
						num = (short)1741815808;
						if (num != 0)
						{
						}
						global::System.Version version = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
						num = (short)505282561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return result;
					}
					goto IL_3E;
					IL_14E:
					num = (short)1122959361;
					if (num != 0)
					{
					}
					result = true;
					num = (short)2089484291;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3E:
				result = false;
				num = (short)1338179586;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004C24 File Offset: 0x00002E24
		private static global::System.Security.AccessControl.DirectorySecurity a()
		{
			short num = (short)667116490;
			short num2 = num;
			num = (short)686646218;
			switch (num2 == num)
			{
			}
			num = (short)698679297;
			if (num != 0)
			{
			}
			num = (short)701366272;
			short num3 = num;
			num = (short)1654128640;
			if (num != 0)
			{
			}
			global::System.Security.AccessControl.DirectorySecurity directorySecurity = new global::System.Security.AccessControl.DirectorySecurity();
			directorySecurity.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null), global::System.Security.AccessControl.FileSystemRights.FullControl, global::System.Security.AccessControl.InheritanceFlags.ContainerInherit | global::System.Security.AccessControl.InheritanceFlags.ObjectInherit, global::System.Security.AccessControl.PropagationFlags.NoPropagateInherit, global::System.Security.AccessControl.AccessControlType.Allow));
			return directorySecurity;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004CF0 File Offset: 0x00002EF0
		private static void a(global::System.Exception A_0, bool A_1)
		{
			short num = (short)1530102076;
			short num2 = num;
			num = (short)554008892;
			switch (num2 == num)
			{
			}
			num = (short)465240065;
			if (num != 0)
			{
			}
			num = (short)220266496;
			short num3 = num;
			num = (short)735707136;
			if (num != 0)
			{
			}
			global::AutoUpdate.AutoUpdateHelper.a(A_0.ToString(), A_1);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004DA4 File Offset: 0x00002FA4
		private static void a(string A_0, bool A_1)
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)645005313;
				if (num != 0)
				{
				}
				num = (short)6718599;
				short num2 = num;
				num = (short)355435655;
				switch (num2 == num)
				{
				}
				num = (short)1499136000;
				if (num != 0)
				{
				}
				string source = global::AutoUpdate.AutoUpgradeFile.b("⹢੤፦٨ᥪɬͮၰ卲❴㩶奸㩺ࡼ୾ﾊ꾎\ud990璉ﲘ", a_);
				global::System.Diagnostics.EventLogEntryType type;
				if (A_1)
				{
					type = global::System.Diagnostics.EventLogEntryType.Error;
				}
				else
				{
					type = global::System.Diagnostics.EventLogEntryType.Information;
				}
				global::System.Diagnostics.EventLog.WriteEntry(source, A_0, type);
			}
			catch
			{
			}
			num = (short)1571028992;
			short num3 = num;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004E8C File Offset: 0x0000308C
		public static void DeleteAutoUpdateOutdatedFiles(double offsetHoursToDelete)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)1655767040;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					global::System.DateTime a_2;
					global::System.IO.DirectoryInfo directoryInfo;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							goto IL_234;
						case 1:
						{
							int num3;
							global::System.IO.FileInfo[] files;
							if (num3 >= files.Length)
							{
								num = (short)151650309;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AutoUpdate.AutoUpdateHelper.a(files[num3], a_2);
							num3++;
							num = (short)1124335618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_1F6;
						case 3:
						{
							global::System.IO.FileInfo[] files = directoryInfo.GetFiles();
							int num3 = 0;
							num = (short)1750597641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_C4;
						case 5:
						{
							global::System.IO.DirectoryInfo[] directories = directoryInfo.GetDirectories();
							int num3 = 0;
							num = (short)1684340740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							int num3;
							global::System.IO.DirectoryInfo[] directories;
							if (num3 >= directories.Length)
							{
								goto IL_E6;
							}
							global::AutoUpdate.AutoUpdateHelper.a(directories[num3], a_2);
							num3++;
							num = (short)1636630536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)1639448586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_C4;
						case 9:
							goto IL_1F6;
						case 10:
							goto IL_234;
						case 11:
							if (directoryInfo.Exists)
							{
								num = (short)1393491971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AutoUpdate.AutoUpdateHelper.a(global::AutoUpdate.AutoUpgradeFile.b("⽭կٱ᭳͵ࡷṹᵻ੽ꊁﲍ낏ﮓ뮛肟잡\udca3쾥\udba7\udea9貫잭\udeaf銱ힳ\udab5톷\udfb9튻쪽꿁ꗃꗅꃇꏉꋋꯍﻏ", a_), false);
							num = (short)567345152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							num = (short)1470496769;
							if (num != 0)
							{
							}
							num = (short)1987907214;
							short num4 = num;
							num = (short)355143310;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E6;
							default:
								goto IL_2AA;
							}
							break;
						}
						}
						goto IL_6B;
						IL_C4:
						num = (short)1607335942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E6:
						num = (short)2077622279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F6:
						num = (short)220856321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_234:
						num = (short)1947074572;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2AA:
					num = (short)394330112;
					if (num != 0)
					{
					}
					break;
					IL_6B:
					directoryInfo = new global::System.IO.DirectoryInfo(global::AutoUpdate.AutoUpdateHelper.AutoUpdateDir);
					a_2 = global::System.DateTime.Now.AddHours(offsetHoursToDelete);
					num = (short)2140078091;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception a_3)
			{
				global::AutoUpdate.AutoUpdateHelper.a(a_3, true);
			}
			num = (short)29032448;
			short num5 = num;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000051A8 File Offset: 0x000033A8
		private static void a(global::System.IO.FileInfo A_0, global::System.DateTime A_1)
		{
			int a_ = 2;
			short num;
			try
			{
				num = (short)1038483458;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FC;
					case 1:
						goto IL_AF;
					case 2:
					{
						num = (short)216645864;
						short num3 = num;
						num = (short)450216168;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AF;
						default:
							num = (short)360054784;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_8A;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_115;
					}
					IL_8A:
					if (A_0.CreationTime < A_1)
					{
						num = (short)2059796481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FC;
					IL_AF:
					A_0.Delete();
					global::AutoUpdate.AutoUpdateHelper.a(global::AutoUpdate.AutoUpgradeFile.b("ᱜ⩞ᕠౢၤᝦ൨੪ᥬ੮兰ᕲᱴ᭶ᱸ孺", a_) + A_0.Name + global::AutoUpdate.AutoUpgradeFile.b("絜㙞በ䍢Ťɦը๪ᥬ੮ᕰ卲ٴɶ᩸᡺᡼౾ꎌ", a_), false);
					num = (short)1313144832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC:
					num = (short)2087124995;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_115:;
			}
			catch (global::System.Exception a_2)
			{
				global::AutoUpdate.AutoUpdateHelper.a(a_2, true);
			}
			num = (short)2012151808;
			short num4 = num;
			num = (short)615841793;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005340 File Offset: 0x00003540
		private static void a(global::System.IO.DirectoryInfo A_0, global::System.DateTime A_1)
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)231473154;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F8;
					case 1:
						goto IL_AB;
					case 2:
					{
						num = (short)1508553242;
						short num3 = num;
						num = (short)627028506;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB;
						default:
							num = (short)952041472;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_87;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_10F;
					}
					IL_87:
					if (A_0.CreationTime < A_1)
					{
						num = (short)1294073857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8;
					IL_AB:
					A_0.Delete(true);
					global::AutoUpdate.AutoUpdateHelper.a(global::AutoUpdate.AutoUpgradeFile.b("⅟ᝡၣ॥ᵧᩩ࡫཭ѯ᝱味ၵ᝷ᙹ᡻᭽ꊁ", a_) + A_0.Name + global::AutoUpdate.AutoUpgradeFile.b("䁟ୡᝣ䙥౧ཀྵk୭ѯ᝱ၳ噵୷ཹύᵽﶇ뺏", a_), false);
					num = (short)1213857792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8:
					num = (short)1439694851;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:;
			}
			catch (global::System.Exception a_2)
			{
				global::AutoUpdate.AutoUpdateHelper.a(a_2, true);
			}
			num = (short)1510866944;
			short num4 = num;
			num = (short)695664641;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000054E4 File Offset: 0x000036E4
		// Note: this type is marked as 'beforefieldinit'.
		static AutoUpdateHelper()
		{
			int a_ = 10;
			short num = (short)851705857;
			if (num != 0)
			{
			}
			num = (short)164653110;
			short num2 = num;
			num = (short)1589012534;
			switch (num2 == num)
			{
			}
			num = (short)99811328;
			short num3 = num;
			num = (short)1142095872;
			if (num != 0)
			{
			}
			global::AutoUpdate.AutoUpdateHelper.AutoUpdateDir = global::System.Environment.GetEnvironmentVariable(global::AutoUpdate.AutoUpgradeFile.b("ㅤ≦⑨㭪", a_)) + global::AutoUpdate.AutoUpgradeFile.b("㥤♦ᱨὪɬ㩮ŰᝲᑴͶᱸ", a_);
			global::AutoUpdate.AutoUpdateHelper.channel = null;
			global::AutoUpdate.AutoUpdateHelper.b = new global::System.Net.Http.HttpClient();
		}

		// Token: 0x0400000D RID: 13
		public static string AutoUpdateDir;

		// Token: 0x0400000E RID: 14
		public static global::System.ServiceModel.ChannelFactory<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement> channel;

		// Token: 0x0400000F RID: 15
		private const string a = "Motorola RM Autoupdate Helper";

		// Token: 0x04000010 RID: 16
		private static readonly global::System.Net.Http.HttpClient b;

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x06000042 RID: 66 RVA: 0x00007BC0 File Offset: 0x00005DC0
			internal void e(global::AutoUpdate.DownloadStatus A_0)
			{
				short num;
				for (;;)
				{
					num = (short)1393164289;
					if (num != 0)
					{
					}
					num = (short)95354880;
					switch (num)
					{
					default:
					{
						global::System.Collections.Generic.Dictionary<long, long> obj = this.a;
						bool flag = false;
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							long a_ = this.a.Values.Sum();
							this.a[A_0.Offset] = A_0.DownloadedSize;
							long a_2 = this.a.Values.Sum();
							global::AutoUpdate.AutoUpdateHelper.a(this.b, a_, a_2, this.c, 0L, this.d);
						}
						finally
						{
							num = (short)1121845249;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_118;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E1;
									}
									continue;
								case 2:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)2041249792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E1:
								if (!flag)
								{
									break;
								}
								num = (short)489619458;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_118:;
						}
						num = (short)1103237575;
						short num3 = num;
						num = (short)1319047623;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_150;
						}
						break;
					}
					}
				}
				IL_150:
				num = (short)997195776;
				if (num != 0)
				{
				}
				num = (short)1176764416;
				short num4 = num;
			}

			// Token: 0x04000043 RID: 67
			public global::System.Collections.Generic.Dictionary<long, long> a;

			// Token: 0x04000044 RID: 68
			public global::System.DateTime b;

			// Token: 0x04000045 RID: 69
			public long c;

			// Token: 0x04000046 RID: 70
			public global::System.IProgress<global::AutoUpdate.DownloadStatus> d;
		}
	}
}
