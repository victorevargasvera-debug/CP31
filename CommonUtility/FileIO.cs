using System;
using System.IO;

namespace CommonUtility
{
	// Token: 0x02000036 RID: 54
	public static class FileIO
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001D930 File Offset: 0x0001BB30
		public static string CruncherTempFolder
		{
			get
			{
				int a_ = 9;
				short num = (short)1469743977;
				short num2 = num;
				num = (short)449479529;
				switch (num2 == num)
				{
				}
				num = (short)1662779393;
				if (num != 0)
				{
				}
				num = (short)744488960;
				if (num != 0)
				{
				}
				num = (short)472711168;
				short num3 = num;
				return global::CommonUtility.VersionUtility.b("眹医䨽⼿ぁ⭃⩅⥇ᙉཋ⅍㵏㽑㭓㡕᭗ਖ਼ཛɝ㉟⽡䑣ⱥݧࡩ䱫㹭ɯᵱᝳ፵୷ॹ፻౽", a_);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		public static string GerenateTemperaryFile(byte[] dataBuf)
		{
			int a_ = 14;
			short num = (short)202702848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				string text;
				string text2;
				for (;;)
				{
					IL_30:
					global::System.IO.FileStream fileStream;
					switch (num2)
					{
					case 0:
						if (dataBuf != null)
						{
							num = (short)1509556228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 1:
						goto IL_21B;
					case 2:
						global::System.IO.Directory.CreateDirectory(text2);
						num = (short)1556873217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1161625600;
						short num3 = num;
						if (!global::System.IO.Directory.Exists(text2))
						{
							num = (short)584450049;
							if (num != 0)
							{
							}
							num = (short)1118633986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B;
					}
					case 4:
						goto IL_1D3;
					case 5:
						try
						{
							fileStream.Write(dataBuf, 0, dataBuf.Length);
							fileStream.Flush();
							fileStream.Close();
							return text;
						}
						finally
						{
							num = (short)1134100481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 2:
								{
									num = (short)1331793252;
									short num4 = num;
									num = (short)640847204;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1958936576;
										if (num != 0)
										{
										}
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)697827328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_148:
								if (fileStream == null)
								{
									break;
								}
								num = (short)111935490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D0:;
						}
						goto IL_1D3;
					}
					goto IL_4F;
					IL_1D3:
					fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
					num = (short)2021392389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					text = global::System.IO.Path.Combine(text2, global::System.Guid.NewGuid().ToString());
					num = (short)295436288;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_4F:
				text2 = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::CommonUtility.VersionUtility.b("爾⹀㝂⩄㕆♈❊ⱌፎቐ㱒㡔㩖㙘㕚Ṝཞ㉠㽢㝤⩦䥨Ⅺɬ൮兰⍲ݴᡶ᩸Ṻ๼౾", a_));
				num = (short)842858499;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001DC7C File Offset: 0x0001BE7C
		public static byte[] ReadFile(string filepath)
		{
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filepath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			byte[] result;
			short num;
			try
			{
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, (int)fileStream.Length);
				fileStream.Close();
				result = array;
			}
			finally
			{
				num = (short)917372929;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 2:
					{
						num = (short)1186967055;
						short num3 = num;
						num = (short)1130409487;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2011037696;
							if (num != 0)
							{
							}
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1869545472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_66:
					if (fileStream == null)
					{
						break;
					}
					num = (short)405340161;
					if (num != 0)
					{
					}
					num = (short)2142699522;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:;
			}
			num = (short)544407552;
			short num4 = num;
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			int a_ = 6;
			short num = (short)1167327232;
			switch (num)
			{
			default:
			{
				num = (short)1526988808;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_45:
					global::System.IO.DirectoryInfo[] directories;
					int i;
					global::System.IO.FileInfo[] files;
					switch (num2)
					{
					case 0:
						goto IL_20D;
					case 1:
					{
						global::System.IO.DirectoryInfo[] array = directories;
						i = 0;
						num = (short)239403008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.IO.DirectoryInfo[] array;
						while (i < array.Length)
						{
							num = (short)1081174940;
							short num3 = num;
							num = (short)2118675356;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1930166272;
								if (num != 0)
								{
								}
								global::System.IO.DirectoryInfo directoryInfo = array[i];
								string destDirName2 = global::System.IO.Path.Combine(destDirName, directoryInfo.Name);
								global::CommonUtility.FileIO.DirectoryCopy(directoryInfo.FullName, destDirName2, copySubDirs);
								i++;
								num = (short)479068169;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_45;
							}
							}
						}
						num = (short)861929473;
						if (num != 0)
						{
						}
						num = (short)602669062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (i >= files.Length)
						{
							num = (short)1974992896;
							short num4 = num;
							num = (short)40435716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.FileInfo fileInfo = files[i];
						string destFileName = global::System.IO.Path.Combine(destDirName, fileInfo.Name);
						fileInfo.CopyTo(destFileName, true);
						i++;
						num = (short)467730437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)992411658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_AD;
					case 6:
						return;
					case 7:
						goto IL_AD;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					case 9:
						goto IL_20D;
					case 10:
						if (copySubDirs)
						{
							num = (short)825098241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_78;
					IL_AD:
					num = (short)81592323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D:
					num = (short)462028802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78:
					global::System.IO.DirectoryInfo directoryInfo2 = new global::System.IO.DirectoryInfo(sourceDirName);
					if (!directoryInfo2.Exists)
					{
						break;
					}
					directories = directoryInfo2.GetDirectories();
					if (!global::System.IO.Directory.Exists(destDirName))
					{
						global::System.IO.Directory.CreateDirectory(destDirName);
					}
					files = directoryInfo2.GetFiles();
					i = 0;
					num = (short)1012989959;
					num2 = (int)((global::System.IntPtr)num);
				}
				throw new global::System.IO.DirectoryNotFoundException(global::CommonUtility.VersionUtility.b("搶嘸为似尾⑀捂⅄⹆㭈⹊⹌㭎㹐⅒ⱔ睖㵘㑚㡜ⱞ䅠ൢ੤፦䥨๪ᕬٮɰݲ啴ᡶ୸孺ṼၾꞆ歷꾎떔ﮞ鮠莢", a_) + sourceDirName);
			}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		public static void DeleteDirectoryForcely(string sourceDirName)
		{
			short num = (short)1255014400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::System.IO.DirectoryInfo directoryInfo;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_BD;
					case 1:
						goto IL_194;
					case 2:
						return;
					case 3:
						goto IL_194;
					case 4:
					{
						int num3;
						global::System.IO.FileInfo[] files;
						if (num3 >= files.Length)
						{
							num = (short)1766981637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.FileInfo fileInfo = files[num3];
						global::System.IO.File.SetAttributes(fileInfo.FullName, global::System.IO.FileAttributes.Normal);
						global::System.IO.File.Delete(fileInfo.FullName);
						num3++;
						num = (short)644677635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1CA;
					case 6:
						goto IL_BD;
					case 7:
					{
						if (!directoryInfo.Exists)
						{
							num = (short)356122626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.IO.DirectoryInfo[] directories = directoryInfo.GetDirectories();
						int num3 = 0;
						num = (short)1781727232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num3;
						global::System.IO.DirectoryInfo[] directories;
						if (num3 >= directories.Length)
						{
							num = (short)1518338057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::CommonUtility.FileIO.DeleteDirectoryForcely(directories[num3].FullName);
						num3++;
						num = (short)1433600006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.IO.FileInfo[] files = directoryInfo.GetFiles();
						int num3 = 0;
						num = (short)1910046721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_56;
					IL_BD:
					num = (short)428624724;
					short num4 = num;
					num = (short)1030310740;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1260584961;
						if (num != 0)
						{
						}
						num = (short)860618752;
						if (num != 0)
						{
						}
						num = (short)1895825416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_194:
					num = (short)1584529412;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1CA:
				num = (short)108068864;
				short num5 = num;
				directoryInfo.Delete();
				return;
				IL_56:
				directoryInfo = new global::System.IO.DirectoryInfo(sourceDirName);
				num = (short)2029387783;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x040000A2 RID: 162
		private const string a = "Motorola\\CommonCPS\\RM Job Processor";
	}
}
