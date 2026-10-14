using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000007 RID: 7
	public class MigrationOpUtility : global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002414 File Offset: 0x00000614
		public static global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility Instance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1627649974;
				short num2 = num;
				num = (short)481621942;
				switch (num2 == num)
				{
				}
				num = (short)925958144;
				if (num != 0)
				{
				}
				num = (short)649068544;
				short num3 = num;
				num = (short)1099825153;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024C4 File Offset: 0x000006C4
		public string DownloadArchiveFile(global::System.Guid fileUuid, string hashCode)
		{
			int a_ = 18;
			short num = (short)1562464633;
			short num2 = num;
			num = (short)241848697;
			switch (num2 == num)
			{
			}
			num = (short)1484390401;
			if (num != 0)
			{
			}
			num = (short)1624571904;
			short num3 = num;
			num = (short)836173824;
			if (num != 0)
			{
			}
			string a_2 = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile);
			string text = fileUuid.ToString();
			text += global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("淪듘룚", a_);
			return global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a(fileUuid, a_2, text, hashCode);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025AC File Offset: 0x000007AC
		public string DownloadPBAFile(global::System.Guid fileUuid, string hashCode)
		{
			int a_ = 4;
			short num = (short)614029349;
			short num2 = num;
			num = (short)2067355685;
			switch (num2 == num)
			{
			}
			num = (short)1669988353;
			if (num != 0)
			{
			}
			num = (short)2138243072;
			short num3 = num;
			num = (short)1056636928;
			if (num != 0)
			{
			}
			string a_2 = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.PbaFile);
			return global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a(fileUuid, a_2, fileUuid.ToString() + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("돊뷌귎냐", a_), hashCode);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000268C File Offset: 0x0000088C
		public void DeleteFile(string filePath)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)700710912;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E;
					case 1:
					{
						num = (short)1883146200;
						short num3 = num;
						num = (short)1074104280;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)111280128;
							if (num != 0)
							{
							}
							goto IL_EE;
						}
						break;
					}
					case 2:
						goto IL_105;
					case 3:
						global::System.IO.File.Delete(filePath);
						num = (short)1705312257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E;
					IL_1E:
					switch (0)
					{
					case 0:
						IL_3E:
						num = (short)1808596993;
						if (num != 0)
						{
						}
						if (!global::System.IO.File.Exists(filePath))
						{
							goto IL_EE;
						}
						num = (short)1030946819;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_EE:
					num = (short)1106116610;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_105:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("釖룘닚뇜뫞藠쏢釤裦짨迪裬菮铰蟲郴ퟶ跸鏺飼\udffe最樂椄戆㌈⬊", a_) + ex.Message);
			}
			num = (short)1804861440;
			short num4 = num;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002804 File Offset: 0x00000A04
		public string GenerateConfigurationName(string templateName)
		{
			int a_ = 4;
			short num = (short)751697921;
			if (num != 0)
			{
			}
			num = (short)1224033953;
			short num2 = num;
			num = (short)1212237473;
			switch (num2 == num)
			{
			}
			num = (short)559349760;
			short num3 = num;
			num = (short)579665920;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("諈꓊ꏌ꧎룐듒ꃔꗖ룘꿚드냞迠쯢뇤苦蓨鯪臬軮藰雲\ud8f4賶째蛺퓼", a_), templateName);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000028D4 File Offset: 0x00000AD4
		public global::Motorola.CommonCPS.Server.EntityModel.Radio CreateConversionRadioByArchiveFile(global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertionInfo)
		{
			short num = (short)884736001;
			if (num != 0)
			{
			}
			num = (short)80192278;
			short num2 = num;
			num = (short)1626841878;
			switch (num2 == num)
			{
			}
			num = (short)433455104;
			short num3 = num;
			num = (short)1943601152;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.Radio result = null;
			if (convertionInfo.ArchiveFileUuid != null)
			{
				string archiveFilePath = this.DownloadArchiveFile(convertionInfo.ArchiveFileUuid.Value, convertionInfo.ArchiveFileHashCode);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ParseArchiveParameters parseArchiveParameters = new global::Motorola.CommonCPS.RadioManagement.UIModels.ParseArchiveParameters();
				parseArchiveParameters.ArchiveFilePath = archiveFilePath;
				parseArchiveParameters.LanguagePacksInDB = convertionInfo.LanguagePacksInDB;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000029C8 File Offset: 0x00000BC8
		public void ClearLocalFolder(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType)
		{
			int a_ = 4;
			short num = (short)1577844736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				string path;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						try
						{
							global::System.IO.DirectoryInfo directoryInfo;
							switch (0)
							{
							case 0:
								break;
							default:
								for (;;)
								{
									IL_18F:
									num = (short)1518652860;
									short num3 = num;
									num = (short)619040188;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_205;
									default:
										num = (short)307101696;
										if (num != 0)
										{
										}
										switch (num2)
										{
										case 0:
											goto IL_28D;
										case 1:
										{
											global::System.IO.FileInfo[] files = directoryInfo.GetFiles();
											int num4 = 0;
											num = (short)1567686662;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
										{
											global::System.IO.FileInfo[] files;
											int num4;
											if (num4 >= files.Length)
											{
												num = (short)270663684;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											files[num4].Delete();
											num4++;
											num = (short)2108030976;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											if (directoryInfo.Exists)
											{
												num = (short)1978204161;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2C7;
										case 4:
											goto IL_2C7;
										case 5:
											goto IL_2DF;
										case 6:
											goto IL_28D;
										}
										goto IL_1FE;
										IL_28D:
										num = (short)1534918658;
										num2 = (int)((global::System.IntPtr)num);
										break;
										IL_2C7:
										num = (short)1429667845;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_2DF:
								return;
							}
							IL_1FE:
							directoryInfo = new global::System.IO.DirectoryInfo(path);
							IL_205:
							num = (short)1120731139;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_18F;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("迈꫊꓌ꏎ듐럒ꏖ뛘ﯚ맜뫞跠蛢釤苦짨鿪藬諮퇰闲鳴鯶鳸쇺\uddfc", a_) + ex.Message);
							return;
						}
						goto IL_30E;
					case 1:
						num = (short)1097400321;
						if (num != 0)
						{
						}
						path = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("闈蛊ꋌ믎뻐ꇒ뫔믖룘蟚黜냞賠転諤触ꫨ믪뻬돮ꏰ뻲뛴", a_), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("裈맊껌꟎룐ꗒ냔藖볘ꯚ닜곞裠韢諤闦部", a_));
						num = (short)1313931268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_30E;
					case 3:
						if (fileType == global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile)
						{
							num = (short)1611464704;
							short num5 = num;
							num = (short)1400176641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)933167110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_B8;
					case 5:
						goto IL_B8;
					case 6:
						if (fileType == global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.PbaFile)
						{
							num = (short)2005663746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_54;
					IL_B8:
					num = (short)1264648192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					path = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("闈蛊ꋌ믎뻐ꇒ뫔믖룘蟚黜냞賠転諤触ꫨ믪뻬돮ꏰ뻲뛴", a_), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("駈觊賌鷎듐ꏒ뫔ꓖ냘꿚닜귞飠", a_));
					num = (short)1104019461;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_54:
				path = "";
				num = (short)2025848835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D4C File Offset: 0x00000F4C
		private static bool a(string A_0, string A_1)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)1716191233;
				if (num != 0)
				{
				}
				num = (short)134873088;
				short num2 = num;
				result = false;
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					num = (short)504299520;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_93;
							}
							continue;
						case 1:
							goto IL_DC;
						case 2:
							goto IL_F0;
						case 3:
						{
							string sha256HashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetSha256HashCode(fileStream);
							result = string.Equals(A_1, sha256HashCode);
							num = (short)1174339585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_93:
						if (fileStream.Length > 0L)
						{
							num = (short)2107506691;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DC:
						num = (short)411172866;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_F0:;
				}
				finally
				{
					num = (short)703463424;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_122;
							}
							continue;
						case 1:
							goto IL_156;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1974861825;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_122:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1099497474;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_156:;
				}
				num = (short)585782045;
				short num4 = num;
				num = (short)738677533;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_18F;
				}
			}
			IL_18F:
			num = (short)1661927424;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002F10 File Offset: 0x00001110
		private static string a(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType A_0)
		{
			int a_ = 16;
			short num;
			string result;
			try
			{
				num = (short)2109865984;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)402194433;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					string path;
					for (;;)
					{
						IL_57:
						switch (num2)
						{
						case 0:
							path = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("铔ꗖ뫘돚드꧞蓠뇢胤韦蛨飪蓬鯮黰臲賴", a_);
							num = (short)2137784323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.PbaFile)
							{
								num = (short)1964310533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EE;
						case 2:
						{
							string text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("觔髖뛘꿚닜귞軠迢蓤믦ꫨ蓪胬苮黰鷲뛴ꟶ꫸ꟺ꿼닾䈀", a_), path);
							global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(text);
							if (!directoryInfo.Exists)
							{
								directoryInfo.Create();
							}
							result = text;
							num = (short)1863712774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_BB;
						case 4:
							goto IL_9A;
						case 5:
						{
							num = (short)1489636981;
							short num3 = num;
							num = (short)1599934069;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_9A;
							default:
								num = (short)1533607936;
								if (num != 0)
								{
								}
								path = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("藔闖飘觚룜꿞軠郢賤鏦蛨駪铬", a_);
								num = (short)609157127;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_20D;
						case 7:
							goto IL_BB;
						}
						goto IL_7E;
						IL_9A:
						if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile)
						{
							num = (short)1456078848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1611137025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BB:
						num = (short)199950338;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1EE:
					throw new global::System.NotSupportedException();
					IL_20D:
					break;
					IL_7E:
					path = "";
					num = (short)112066564;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, systemException);
			}
			num = (short)1566834688;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000317C File Offset: 0x0000137C
		private static string a(global::System.Guid A_0, string A_1, string A_2, string A_3)
		{
			short num;
			string result;
			try
			{
				num = (short)1612709888;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					string text;
					bool flag;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							global::System.IO.File.Delete(text);
							num = (short)1190264841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_217;
						case 2:
							if (flag)
							{
								num = (short)1378615302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24E;
						case 3:
							goto IL_24E;
						case 4:
							if (global::System.IO.File.Exists(text))
							{
								num = (short)987693067;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_217;
						case 5:
							if (global::System.IO.File.Exists(text))
							{
								num = (short)710410240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_119;
						case 6:
							num = (short)1051787269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)746651649;
							if (num != 0)
							{
							}
							num = (short)1049952260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!string.IsNullOrEmpty(A_3))
							{
								goto IL_89;
							}
							goto IL_217;
						case 9:
							goto IL_119;
						case 10:
							goto IL_269;
						case 11:
						{
							num = (short)67551707;
							short num3 = num;
							num = (short)876462555;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_89;
							default:
								num = (short)123666432;
								if (num != 0)
								{
								}
								flag = !global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a(text, A_3);
								num = (short)662175745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_5F;
						IL_89:
						num = (short)383713287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_119:
						byte[] fileContent = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetFileContent(A_0);
						global::System.IO.File.WriteAllBytes(text, fileContent);
						num = (short)413859843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_217:
						num = (short)1993670658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24E:
						result = text;
						num = (short)1173749770;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_269:
					break;
					IL_5F:
					text = global::System.IO.Path.Combine(A_1, A_2);
					flag = true;
					num = (short)2121531400;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DBMIGRATION_DONWLOAD_FILE_ERROR, systemException);
			}
			num = (short)308084736;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000347C File Offset: 0x0000167C
		// Note: this type is marked as 'beforefieldinit'.
		static MigrationOpUtility()
		{
			short num = (short)1552634239;
			short num2 = num;
			num = (short)1057116543;
			switch (num2 == num)
			{
			default:
			{
				num = (short)432406528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)251265025;
			if (num != 0)
			{
			}
			num = (short)1101529088;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.a = new global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility();
		}

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility a;
	}
}
