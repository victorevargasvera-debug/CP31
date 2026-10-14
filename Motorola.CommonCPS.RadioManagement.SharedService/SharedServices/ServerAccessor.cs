using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000059 RID: 89
	public class ServerAccessor
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x00044A90 File Offset: 0x00042C90
		protected ServerAccessor()
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00044AA4 File Offset: 0x00042CA4
		public static void SetInteraction(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor value)
		{
			short num = (short)1206609741;
			short num2 = num;
			num = (short)1310418765;
			switch (num2 == num)
			{
			}
			num = (short)1696268288;
			short num3 = num;
			num = (short)943194113;
			if (num != 0)
			{
			}
			num = (short)65273856;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a = value;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00044B58 File Offset: 0x00042D58
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor GetInstance(bool needConnect = true, bool waitConnect = false)
		{
			short num = (short)1290600449;
			if (num != 0)
			{
			}
			num = (short)192479232;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)592151594;
					short num3 = num;
					num = (short)1011581994;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)788594688;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_126;
				case 2:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a.Connect(false);
					num = (short)569769992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1427505161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a.IsConnected && needConnect)
					{
						num = (short)814415875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 5:
					goto IL_1B1;
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.RmServerAccessor(needConnect);
					num = (short)520749056;
					short num4 = num;
					num = (short)517931013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.None)
					{
						num = (short)1967783937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 8:
					goto IL_242;
				case 9:
					if (waitConnect)
					{
						num = (short)465371138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a.Connect(true);
					num = (short)90636295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BF:
				if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a == null)
				{
					num = (short)423231494;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1406795780;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_126:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerNotAvailabe, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CantConnectWebService.ToString(), null));
			IL_1B1:
			IL_242:
			IL_244:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.a;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00044DB0 File Offset: 0x00042FB0
		public static string GetSha256HashCode(byte[] data)
		{
			int a_ = 3;
			short num = (short)1104478208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Security.Cryptography.SHA256 sha = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
				string result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					string text;
					int num3;
					byte[] array;
					for (;;)
					{
						IL_38:
						switch (num2)
						{
						case 0:
							goto IL_140;
						case 1:
							goto IL_BF;
						case 2:
							num = (short)1300234241;
							if (num != 0)
							{
							}
							result = text.ToUpperInvariant();
							num = (short)1333329920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_BF;
						case 4:
							if (num3 >= array.Length)
							{
								num = (short)2029518850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += array[num3].ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("꺛", a_), global::System.Globalization.CultureInfo.InvariantCulture);
							num3++;
							num = (short)2140340227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53;
						IL_BF:
						num = (short)1045692420;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_140:
					goto IL_1FA;
					IL_53:
					array = sha.ComputeHash(data);
					text = "";
					num3 = 0;
					num = (short)882835457;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_38;
				}
				finally
				{
					num = (short)173303791;
					short num4 = num;
					num = (short)102328303;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1C1:
						if (sha == null)
						{
							goto IL_1F9;
						}
						num = (short)1095237634;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)722927616;
						if (num != 0)
						{
						}
						num = (short)166592513;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1F7;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1C1;
							}
							continue;
						case 2:
							((global::System.IDisposable)sha).Dispose();
							num = (short)287506432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1;
					}
					IL_1F7:
					IL_1F9:;
				}
				IL_1FA:
				num = (short)706019328;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00045000 File Offset: 0x00043200
		public static string GetSha256HashCode(global::System.IO.Stream stream)
		{
			int a_ = 19;
			short num = (short)1215168512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1240924161;
				if (num != 0)
				{
				}
				num = (short)1770782720;
				short num3 = num;
				global::System.Security.Cryptography.SHA256 sha = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
				string result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					string text;
					int num4;
					byte[] array;
					for (;;)
					{
						IL_8A:
						switch (num2)
						{
						case 0:
							goto IL_16C;
						case 1:
							goto IL_112;
						case 2:
							result = text.ToUpperInvariant();
							num = (short)899547136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_112;
						case 4:
							if (num4 >= array.Length)
							{
								num = (short)1166147586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += array[num4].ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튩麫", a_), global::System.Globalization.CultureInfo.InvariantCulture);
							num4++;
							num = (short)1361248259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5;
						IL_112:
						num = (short)1850343428;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_16C:
					return result;
					IL_A5:
					array = sha.ComputeHash(stream);
					text = "";
					num4 = 0;
					num = (short)1078132737;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_8A;
				}
				finally
				{
					num = (short)1899887102;
					short num5 = num;
					num = (short)916388350;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1EF:
						if (sha == null)
						{
							goto IL_228;
						}
						num = (short)2096234498;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1169293312;
						if (num != 0)
						{
						}
						num = (short)1499201537;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_226;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1EF;
							}
							continue;
						case 2:
							((global::System.IDisposable)sha).Dispose();
							num = (short)540934144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					}
					IL_226:
					IL_228:;
				}
				return result;
			}
			}
		}

		// Token: 0x0400007C RID: 124
		private static global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor a;
	}
}
