using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using CodeplugExchangeLibrary.Enums;
using CodeplugExchangeLibrary.Exceptions;
using CodeplugExchangeLibrary.Utilities;
using Ionic.Zip;
using MotorolaSolutions.RadioCentral.CodeplugExchangeLibrary.Extensions;

namespace CodeplugExchangeLibrary
{
	// Token: 0x02000006 RID: 6
	public static class CodeplugExchangeFileFactory
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000357C File Offset: 0x0000177C
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile Open(string path, global::System.Security.SecureString password)
		{
			short num;
			if (!global::Ionic.Zip.ZipFile.CheckZipPassword(path, password.ToPlainString()))
			{
				num = (short)1488454872;
				short num2 = num;
				num = (short)465044696;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1908408321;
					if (num != 0)
					{
					}
					num = (short)1629683712;
					if (num != 0)
					{
					}
					return null;
				}
			}
			num = (short)288948224;
			short num3 = num;
			return new global::CodeplugExchangeLibrary.CodeplugExchangeFile(global::Ionic.Zip.ZipFile.Read(path), password, global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.Existing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003644 File Offset: 0x00001844
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile Open(global::System.IO.Stream fileStream, string password)
		{
			short num;
			global::CodeplugExchangeLibrary.CodeplugExchangeFile result;
			try
			{
				num = (short)1975255040;
				switch (num)
				{
				default:
				{
					fileStream.Position = 0L;
					global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(fileStream);
					goto IL_2F;
					try
					{
						for (;;)
						{
							IL_2F:
							global::System.Collections.Generic.IEnumerator<global::Ionic.Zip.ZipEntry> enumerator = zipFile.GetEnumerator();
							try
							{
								num = (short)351797253;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_179;
									case 1:
									{
										global::Ionic.Zip.ZipEntry zipEntry;
										zipEntry.ExtractWithPassword(global::System.IO.Stream.Null, password);
										num = (short)1455554564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1265172488;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Ionic.Zip.ZipEntry zipEntry = enumerator.Current;
										num = (short)1397489671;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)152764422;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_84;
										}
										continue;
									case 6:
									{
										global::Ionic.Zip.ZipEntry zipEntry;
										if (zipEntry.UsesEncryption)
										{
											num = (short)164954113;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::Ionic.Zip.ZipEntry zipEntry;
										if (!zipEntry.IsDirectory)
										{
											num = (short)1433010179;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										num = (short)1374552064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_C1:
									num = (short)1494482946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_84:
									goto IL_C1;
								}
								IL_179:;
							}
							finally
							{
								num = (short)1720451073;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1E3;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1AE;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)46268416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1AE:
									if (enumerator == null)
									{
										break;
									}
									num = (short)491716610;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1E3:;
							}
							num = (short)339339950;
							short num3 = num;
							num = (short)613411502;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_21C;
							}
						}
						IL_21C:
						num = (short)1322450944;
						if (num != 0)
						{
						}
					}
					finally
					{
						num = (short)946864129;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_29A;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_265;
								}
								continue;
							case 2:
								((global::System.IDisposable)zipFile).Dispose();
								num = (short)1852833792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_265:
							if (zipFile == null)
							{
								break;
							}
							num = (short)75431938;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_29A:;
					}
					fileStream.Position = 0L;
					result = new global::CodeplugExchangeLibrary.CodeplugExchangeFile(global::Ionic.Zip.ZipFile.Read(fileStream), password.ToSecureString(), global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.Existing);
					break;
				}
				}
			}
			catch (global::Ionic.Zip.BadPasswordException)
			{
				result = null;
			}
			num = (short)65536001;
			if (num != 0)
			{
			}
			num = (short)1238827008;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000039B0 File Offset: 0x00001BB0
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile Open(string path, string password)
		{
			short num = (short)248785311;
			short num2 = num;
			num = (short)1664231839;
			switch (num2 == num)
			{
			default:
			{
				num = (short)356777984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)10485761;
			if (num != 0)
			{
			}
			num = (short)988610560;
			if (num != 0)
			{
			}
			return global::CodeplugExchangeLibrary.CodeplugExchangeFileFactory.Open(path, password.ToSecureString());
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003A68 File Offset: 0x00001C68
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile Create(byte[] cmpCodeplugBytes, global::System.Security.SecureString password, global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata metadata)
		{
			int a_ = 10;
			short num = (short)137773652;
			short num2 = num;
			num = (short)2065384020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1756037120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)930807808;
			if (num != 0)
			{
			}
			num = (short)1394999297;
			if (num != 0)
			{
			}
			global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile();
			zipFile.AddEntry(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("꓆ꛈ꿊꣌뿎뷐ꛒ닔淪뫘뛚규", a_), cmpCodeplugBytes);
			zipFile.AddEntry(global::CodeplugExchangeLibrary.Exceptions.InvalidCxfFilePasswordException.b("꫆곈뿊곌ꯎ냐꟒듔", a_), global::CodeplugExchangeLibrary.Utilities.XmlProcessingHelper.Serialize<global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata>(metadata));
			return new global::CodeplugExchangeLibrary.CodeplugExchangeFile(zipFile, password, global::CodeplugExchangeLibrary.Enums.CodeplugExchangeFileType.New);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003B5C File Offset: 0x00001D5C
		public static global::CodeplugExchangeLibrary.CodeplugExchangeFile Create(byte[] cmpCodeplugBytes, string password, global::CodeplugExchangeLibrary.CodeplugExchageFileMetadata metadata)
		{
			short num = (short)1571375745;
			short num2 = num;
			num = (short)538593921;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1593835520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1573715969;
			if (num != 0)
			{
			}
			num = (short)879230976;
			if (num != 0)
			{
			}
			return global::CodeplugExchangeLibrary.CodeplugExchangeFileFactory.Create(cmpCodeplugBytes, password.ToSecureString(), metadata);
		}
	}
}
