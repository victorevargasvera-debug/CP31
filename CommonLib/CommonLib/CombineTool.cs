using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200000B RID: 11
	public class CombineTool
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00006B04 File Offset: 0x00004D04
		public static byte[] Encode(byte[] pbaBytes, object deviceInfo)
		{
			short num = (short)446758913;
			if (num != 0)
			{
			}
			num = (short)1798373376;
			short num2 = num;
			num = (short)573742152;
			short num3 = num;
			num = (short)323656776;
			switch (num3 == num)
			{
			}
			num = (short)1648295936;
			if (num != 0)
			{
			}
			byte[] deviceInfo2 = global::Motorola.Common.CommonLib.CombineTool.a(deviceInfo);
			return global::Motorola.Common.CommonLib.CombineTool.Encode(pbaBytes, deviceInfo2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00006BBC File Offset: 0x00004DBC
		private static byte[] a(object A_0)
		{
			short num = (short)828676853;
			short num2 = num;
			num = (short)1317772021;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)2052456448;
				short num3 = num;
				break;
			}
			}
			num = (short)1734606848;
			if (num != 0)
			{
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			try
			{
				new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, A_0);
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)1765867520;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C3;
						}
						continue;
					case 1:
						goto IL_11E;
					case 2:
						num = (short)1276116993;
						if (num != 0)
						{
						}
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)551747585;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C3:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)951910402;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_11E:;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00006CFC File Offset: 0x00004EFC
		public static byte[] Encode(byte[] pbaBytes, byte[] deviceInfo)
		{
			short num = (short)584581120;
			switch (num)
			{
			default:
			{
				num = (short)154009600;
				short num2 = num;
				num = (short)551550977;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				byte[] result;
				try
				{
					num = (short)1344449109;
					short num3 = num;
					num = (short)1902160469;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)605880320;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.WriteCopyrightHeader(memoryStream);
						global::System.IO.Stream zippingAndEncryptingStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetZippingAndEncryptingStream(memoryStream);
						try
						{
							global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(zippingAndEncryptingStream);
							try
							{
								binaryWriter.Write(global::Motorola.Common.CommonLib.CombineTool.MagicHeader);
								binaryWriter.Write(global::Motorola.Common.CommonLib.CombineTool.Version);
								binaryWriter.Write(pbaBytes.Length);
								binaryWriter.Write(pbaBytes);
								binaryWriter.Write(deviceInfo.Length);
								binaryWriter.Write(deviceInfo);
							}
							finally
							{
								num = (short)1150222336;
								int num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_14E;
										}
										continue;
									case 1:
										goto IL_183;
									case 2:
										((global::System.IDisposable)binaryWriter).Dispose();
										num = (short)1032388609;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_14E:
									if (binaryWriter == null)
									{
										break;
									}
									num = (short)882835458;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_183:;
							}
						}
						finally
						{
							num = (short)1485307904;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B9;
									}
									continue;
								case 1:
									goto IL_1EE;
								case 2:
									((global::System.IDisposable)zippingAndEncryptingStream).Dispose();
									num = (short)1330839553;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B9:
								if (zippingAndEncryptingStream == null)
								{
									break;
								}
								num = (short)1566179330;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_1EE:;
						}
						break;
					}
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)422379520;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_22C;
							}
							continue;
						case 1:
							goto IL_264;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)104988673;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_22C:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)928514050;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_264:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00006FC0 File Offset: 0x000051C0
		public static byte[] Encode(string encryptedSerializedPbaFilePath, int serializedPbaDataLength, string deviceInfoFilePath)
		{
			short num = (short)298594393;
			short num2 = num;
			num = (short)1407397977;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1919418368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)47710209;
			if (num != 0)
			{
			}
			num = (short)1490878464;
			if (num != 0)
			{
			}
			byte[] deviceInfo = global::System.IO.File.ReadAllBytes(deviceInfoFilePath);
			return global::Motorola.Common.CommonLib.CombineTool.Encode(encryptedSerializedPbaFilePath, serializedPbaDataLength, deviceInfo);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00007078 File Offset: 0x00005278
		public static byte[] Encode(string encryptedSerializedPbaFilePath, int serializedPbaDataLength, object deviceInfo)
		{
			short num = (short)1690917545;
			short num2 = num;
			num = (short)528833193;
			switch (num2 == num)
			{
			default:
			{
				num = (short)413990912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1095630849;
			if (num != 0)
			{
			}
			num = (short)1003159552;
			if (num != 0)
			{
			}
			byte[] deviceInfo2 = global::Motorola.Common.CommonLib.CombineTool.a(deviceInfo);
			return global::Motorola.Common.CommonLib.CombineTool.Encode(encryptedSerializedPbaFilePath, serializedPbaDataLength, deviceInfo2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00007130 File Offset: 0x00005330
		public static byte[] Encode(string encryptedSerializedPbaFilePath, int serializedPbaDataLength, byte[] deviceInfo)
		{
			short num = (short)316342272;
			switch (num)
			{
			default:
			{
				num = (short)917045248;
				short num2 = num;
				string tempFileName = global::System.IO.Path.GetTempFileName();
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(tempFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.Read | global::System.IO.FileShare.Write | global::System.IO.FileShare.Delete, 4096, global::System.IO.FileOptions.DeleteOnClose);
				byte[] result;
				try
				{
					global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(encryptedSerializedPbaFilePath, global::System.IO.FileAccess.Read);
					try
					{
						global::System.IO.Stream stream2 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(tempFileName, global::System.IO.FileAccess.Write);
						try
						{
							global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.WriteCopyrightHeader(stream2);
							global::System.IO.Stream zippingAndEncryptingStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetZippingAndEncryptingStream(stream2);
							try
							{
								global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(zippingAndEncryptingStream);
								try
								{
									binaryWriter.Write(global::Motorola.Common.CommonLib.CombineTool.MagicHeader);
									binaryWriter.Write(global::Motorola.Common.CommonLib.CombineTool.Version);
									binaryWriter.Write(serializedPbaDataLength);
									stream.CopyTo(zippingAndEncryptingStream);
									binaryWriter.Write(deviceInfo.Length);
									binaryWriter.Write(deviceInfo);
									goto IL_3E1;
								}
								finally
								{
									num = (short)192610304;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_111;
											}
											continue;
										case 1:
											goto IL_149;
										case 2:
											((global::System.IDisposable)binaryWriter).Dispose();
											num = (short)503119873;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_111:
										if (binaryWriter == null)
										{
											break;
										}
										num = (short)127860738;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_149:;
								}
							}
							finally
							{
								num = (short)1564147712;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_17F;
										}
										continue;
									case 1:
										goto IL_20A;
									case 2:
										((global::System.IDisposable)zippingAndEncryptingStream).Dispose();
										num = (short)1057882113;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_17F:
									if (zippingAndEncryptingStream == null)
									{
										break;
									}
									num = (short)2039229871;
									short num4 = num;
									num = (short)383135151;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_20A;
									default:
										num = (short)1530724352;
										if (num != 0)
										{
										}
										num = (short)427884546;
										num3 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_20A:;
							}
						}
						finally
						{
							num = (short)930349056;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_241;
									}
									continue;
								case 1:
									goto IL_279;
								case 2:
									((global::System.IDisposable)stream2).Dispose();
									num = (short)648216577;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_241:
								if (stream2 == null)
								{
									break;
								}
								num = (short)483196930;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_279:;
						}
					}
					finally
					{
						num = (short)1888616448;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2AE;
								}
								continue;
							case 1:
								goto IL_2E4;
							case 2:
								((global::System.IDisposable)stream).Dispose();
								num = (short)1753612289;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2AE:
							if (stream == null)
							{
								break;
							}
							num = (short)1748959234;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2E4:;
					}
					global::System.IO.Stream stream3;
					try
					{
						IL_2E7:
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						try
						{
							stream3.CopyTo(memoryStream);
							result = memoryStream.ToArray();
							goto IL_460;
						}
						finally
						{
							num = (short)1515192320;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_339;
									}
									continue;
								case 1:
									goto IL_370;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1078263809;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_339:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)453574658;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_370:;
						}
					}
					finally
					{
						num = (short)906297344;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3A6;
								}
								continue;
							case 1:
								goto IL_3DE;
							case 2:
								((global::System.IDisposable)stream3).Dispose();
								num = (short)61669377;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3A6:
							if (stream3 == null)
							{
								break;
							}
							num = (short)1172570114;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_3DE:;
					}
					IL_3E1:
					stream3 = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(fileStream, true);
					goto IL_2E7;
				}
				finally
				{
					num = (short)154796032;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_426;
							}
							continue;
						case 1:
							goto IL_45D;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)628555777;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_426:
						if (fileStream == null)
						{
							break;
						}
						num = (short)2106327042;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_45D:;
				}
				IL_460:
				num = (short)121962497;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00007674 File Offset: 0x00005874
		public static byte[] EncodeForDepot(byte[] pbaBytes, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)879246567;
			short num2 = num;
			num = (short)1557019879;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1651638272;
				short num3 = num;
				num = (short)52559872;
				if (num != 0)
				{
				}
				num = (short)1631584256;
				switch (num)
				{
				default:
				{
					global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Motorola.Common.Communication.CommonUtil.DeviceInfo));
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						dataContractSerializer.WriteObject(memoryStream, deviceInfo);
						byte[] array = memoryStream.ToArray();
						byte[] inputByteArray = global::Motorola.Common.CommonLib.CombineTool.a<byte>(new byte[][]
						{
							global::Motorola.Common.CommonLib.CombineTool.MagicHeaderBytes,
							global::Motorola.Common.CommonLib.CombineTool.Version,
							global::System.BitConverter.GetBytes(pbaBytes.Length),
							pbaBytes,
							global::System.BitConverter.GetBytes(array.Length),
							array
						});
						result = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.AddCopyRightHeader(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.ZipAndEncryptByteArray(inputByteArray));
					}
					finally
					{
						num = (short)1124466688;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_13A;
								}
								continue;
							case 1:
								goto IL_197;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1515454465;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_13A:
							num = (short)964624385;
							if (num != 0)
							{
							}
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1977417730;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_197:;
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00007830 File Offset: 0x00005A30
		public static bool IsPbaPlus_enhanced(byte[] combinedData)
		{
			short num = (short)53246811;
			short num2 = num;
			num = (short)1000176475;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1847394304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2070609921;
			if (num != 0)
			{
			}
			num = (short)1741422592;
			if (num != 0)
			{
			}
			byte[] inputByteArray = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.RemoveCopyRightHeader(combinedData);
			return global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptAndUnzipByteArray(inputByteArray));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000078F0 File Offset: 0x00005AF0
		public static global::System.Collections.Generic.List<byte[]> Decode(byte[] combinedData)
		{
			short num = (short)1080754176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				byte[] array;
				for (;;)
				{
					IL_28:
					int index;
					int count;
					global::System.IO.MemoryStream memoryStream2;
					switch (num2)
					{
					case 0:
						num = (short)1937702913;
						if (num != 0)
						{
						}
						if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(array))
						{
							num = (short)719978498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_397;
					case 1:
						try
						{
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array, index, count);
							try
							{
								global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(memoryStream2);
								try
								{
									global::System.IO.BinaryReader binaryReader2 = new global::System.IO.BinaryReader(memoryStream);
									try
									{
										return new global::System.Collections.Generic.List<byte[]>(2)
										{
											binaryReader.ReadBytes((int)binaryReader.BaseStream.Length),
											binaryReader2.ReadBytes((int)binaryReader2.BaseStream.Length)
										};
									}
									finally
									{
										num = (short)885587968;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_149;
												}
												continue;
											case 1:
												goto IL_1D2;
											case 2:
												((global::System.IDisposable)binaryReader2).Dispose();
												num = (short)1559232513;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_149:
											if (binaryReader2 == null)
											{
												break;
											}
											num = (short)1792064454;
											short num3 = num;
											num = (short)1194441670;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1D2;
											default:
												num = (short)2130182144;
												if (num != 0)
												{
												}
												num = (short)1167785986;
												num2 = (int)((global::System.IntPtr)num);
												break;
											}
										}
										IL_1D2:;
									}
								}
								finally
								{
									num = (short)1927086080;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_207;
											}
											continue;
										case 1:
											goto IL_23F;
										case 2:
											((global::System.IDisposable)binaryReader).Dispose();
											num = (short)63373313;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_207:
										if (binaryReader == null)
										{
											break;
										}
										num = (short)1460600834;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_23F:;
								}
							}
							finally
							{
								num = (short)1931411456;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_274;
										}
										continue;
									case 1:
										goto IL_2AD;
									case 2:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)733216769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_274:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)318963714;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2AD:;
							}
						}
						finally
						{
							num = (short)738721792;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2E3;
									}
									continue;
								case 1:
									goto IL_31B;
								case 2:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = (short)1284046849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2E3:
								if (memoryStream2 == null)
								{
									break;
								}
								num = (short)16121858;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31B:;
						}
						goto IL_31E;
					case 2:
						goto IL_31E;
					}
					goto IL_3B;
					IL_31E:
					int num4 = global::System.BitConverter.ToInt32(array, global::Motorola.Common.CommonLib.CombineTool.MagicHeader.Length + global::Motorola.Common.CommonLib.CombineTool.Version.Length);
					index = 16 + num4;
					count = global::System.BitConverter.ToInt32(array, 12 + num4);
					memoryStream2 = new global::System.IO.MemoryStream(array, 12, num4);
					num = (short)1367080960;
					short num5 = num;
					num = (short)1278607361;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_397:
				return new global::System.Collections.Generic.List<byte[]>(2)
				{
					array,
					new byte[0]
				};
				IL_3B:
				byte[] inputByteArray = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.RemoveCopyRightHeader(combinedData);
				array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptAndUnzipByteArray(inputByteArray);
				num = (short)1171062784;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00007D14 File Offset: 0x00005F14
		public static byte[] DecodeDeviceInfo(byte[] combinedData)
		{
			short num = (short)1006829568;
			switch (num)
			{
			default:
			{
				num = (short)1298923521;
				if (num != 0)
				{
				}
				num = (short)1487339520;
				short num2 = num;
				global::System.IO.Stream decodingStream = global::Motorola.Common.CommonLib.CombineTool.GetDecodingStream(combinedData);
				byte[] result;
				try
				{
					global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(decodingStream);
					try
					{
						num = (short)937951233;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								binaryReader.ReadBytes(4);
								int num4 = binaryReader.ReadInt32();
								decodingStream.Position += (long)num4;
								int count = binaryReader.ReadInt32();
								result = binaryReader.ReadBytes(count);
								num = (short)1910898691;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B5;
								}
								continue;
							case 2:
								goto IL_147;
							case 3:
								goto IL_127;
							}
							IL_B5:
							if (binaryReader.ReadChars(4).SequenceEqual(global::Motorola.Common.CommonLib.CombineTool.MagicHeader))
							{
								num = (short)1862533120;
								num3 = (int)((global::System.IntPtr)num);
							}
							else
							{
								result = null;
								num = (short)1406861314;
								num3 = (int)((global::System.IntPtr)num);
							}
						}
						IL_127:
						IL_147:;
					}
					finally
					{
						num = (short)286720000;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_162;
							case 1:
								goto IL_207;
							case 2:
								((global::System.IDisposable)binaryReader).Dispose();
								num = (short)1579679745;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
							IL_162:
							switch (0)
							{
							case 0:
							{
								IL_17F:
								if (binaryReader == null)
								{
									goto IL_209;
								}
								num = (short)1204550385;
								short num5 = num;
								num = (short)739048177;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_162;
								default:
									num = (short)1535574016;
									if (num != 0)
									{
									}
									num = (short)1986789378;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
								break;
							}
							}
						}
						IL_207:
						IL_209:;
					}
				}
				finally
				{
					num = (short)683474944;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_23C;
							}
							continue;
						case 1:
							goto IL_271;
						case 2:
							((global::System.IDisposable)decodingStream).Dispose();
							num = (short)1826422785;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_23C:
						if (decodingStream == null)
						{
							break;
						}
						num = (short)1484455938;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_271:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00007FCC File Offset: 0x000061CC
		public static global::System.IO.Stream GetDecodingStream(byte[] combinedData)
		{
			short num = (short)1898446848;
			short num2 = num;
			num = (short)1404655514;
			short num3 = num;
			num = (short)596858778;
			global::System.IO.MemoryStream memoryStream;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1277362176;
				if (num != 0)
				{
				}
				memoryStream = new global::System.IO.MemoryStream(combinedData, false);
				global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(memoryStream, global::System.Text.Encoding.UTF8, true);
				try
				{
					num = (short)458620929;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.ReadCopyrightHeader(binaryReader);
				}
				finally
				{
					num = (short)1643905025;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)binaryReader).Dispose();
							num = (short)1689387010;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 2:
							goto IL_120;
						}
						IL_ED:
						if (binaryReader == null)
						{
							break;
						}
						num = (short)167837696;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_120:;
				}
				break;
			}
			}
			return new global::Motorola.Common.Communication.CommonUtil.ProxyStream(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetDecryptingAndUnzippingStream(memoryStream), true);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00008120 File Offset: 0x00006320
		public static object ByteArrayToObject(byte[] byteArray)
		{
			short num;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(byteArray);
				try
				{
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					memoryStream.Position = 0L;
					return binaryFormatter.Deserialize(memoryStream);
				}
				finally
				{
					num = (short)982122497;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1017905154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_52;
							}
							continue;
						case 2:
							goto IL_86;
						}
						IL_52:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1109458944;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_86:;
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1426819367;
			short num3 = num;
			num = (short)1681492263;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				object result;
				return result;
			}
			default:
			{
				num = (short)199491585;
				if (num != 0)
				{
				}
				num = (short)1031274496;
				short num4 = num;
				num = (short)449183744;
				if (num != 0)
				{
				}
				return null;
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00008274 File Offset: 0x00006474
		public static global::Motorola.Common.Communication.CommonUtil.DeviceInfo DecodeDeviceInfoForDepot(byte[] deviceInfoByteArray)
		{
			short num;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(deviceInfoByteArray);
				try
				{
					return (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Motorola.Common.Communication.CommonUtil.DeviceInfo)).ReadObject(memoryStream);
				}
				finally
				{
					num = (short)623443969;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)881655810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5A;
							}
							continue;
						case 2:
							goto IL_8E;
						}
						IL_5A:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)969474048;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_8E:;
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)141279325;
			short num3 = num;
			num = (short)1019265117;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo result;
				return result;
			}
			default:
			{
				num = (short)517799937;
				if (num != 0)
				{
				}
				num = (short)1057554432;
				short num4 = num;
				num = (short)193986560;
				if (num != 0)
				{
				}
				return null;
			}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000083D0 File Offset: 0x000065D0
		private static a[] a<a>(params a[][] A_0)
		{
			short num = (short)1973944320;
			switch (num)
			{
			default:
			{
				num = (short)233832448;
				short num2 = num;
				num = (short)390529024;
				int num3 = (int)((global::System.IntPtr)num);
				a[] array2;
				for (;;)
				{
					int num4;
					int num5;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 1:
						goto IL_168;
					case 2:
					{
						if (num4 >= A_0.Length)
						{
							num = (short)1134362628;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						a[] array = A_0[num4];
						global::System.Buffer.BlockCopy(array, 0, array2, num5, array.Length);
						num5 += array.Length;
						num4++;
						num = (short)689635331;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)569180161;
						if (num != 0)
						{
						}
						goto IL_186;
					case 4:
						return array2;
					}
					IL_83:
					array2 = new a[A_0.Sum(new global::System.Func<a[], int>(global::Motorola.Common.CommonLib.CombineTool.<>c__16<a>.<>9.a))];
					num5 = 0;
					num4 = 0;
					num = (short)1068878726;
					short num6 = num;
					num = (short)116050822;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_168:
						break;
					default:
						num = (short)1272643584;
						if (num != 0)
						{
						}
						num = (short)522452993;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_186:
					num = (short)2126446594;
					num3 = (int)((global::System.IntPtr)num);
				}
				return array2;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000085A4 File Offset: 0x000067A4
		protected static bool IsPbaPlus(byte[] data)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num2;
			short num3;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (num2 > 3)
					{
						num3 = (short)982646790;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_11C;
				case 1:
					goto IL_158;
				case 2:
					result = false;
					num3 = (short)791085061;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if ((char)data[num2] != global::Motorola.Common.CommonLib.CombineTool.MagicHeader[num2])
					{
						num3 = (short)562626562;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_E4;
				case 4:
					goto IL_158;
				case 5:
					goto IL_E4;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_E4:
				num2++;
				num3 = (short)727252996;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_158:
				num3 = (short)331350016;
				num = (int)((global::System.IntPtr)num3);
			}
			return result;
			IL_2C:
			num3 = (short)169934848;
			short num4 = num3;
			result = true;
			num2 = 0;
			num3 = (short)284100427;
			short num5 = num3;
			num3 = (short)513607499;
			switch ((num5 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_11C:
				num3 = (short)291045379;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
			{
				num3 = (short)373424129;
				if (num3 != 0)
				{
				}
				num3 = (short)757661696;
				if (num3 != 0)
				{
				}
				num3 = (short)1287651329;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00008740 File Offset: 0x00006940
		public static byte[] WrapEZC(byte[] pbaData)
		{
			while (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(pbaData))
			{
				short num = (short)2044131072;
				short num2 = num;
				num = (short)556791552;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)305135616;
					if (num != 0)
					{
					}
					num = (short)1096876032;
					short num3 = num;
					num = (short)1639907329;
					if (num != 0)
					{
					}
					return global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.AddCopyRightHeader(global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.ZipAndEncryptByteArray(pbaData));
				}
				}
			}
			return pbaData;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000881C File Offset: 0x00006A1C
		// Note: this type is marked as 'beforefieldinit'.
		static CombineTool()
		{
			int a_ = 10;
			short num = (short)2031747072;
			short num2 = num;
			num = (short)1222428673;
			short num3 = num;
			num = (short)86362113;
			switch (num3 == num)
			{
			}
			num = (short)1406337024;
			if (num != 0)
			{
			}
			num = (short)953876481;
			if (num != 0)
			{
			}
			global::Motorola.Common.CommonLib.CombineTool.MagicHeader = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帍刏匑㼓", a_).ToCharArray();
			global::Motorola.Common.CommonLib.CombineTool.MagicHeaderBytes = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帍刏匑㼓", a_));
			global::Motorola.Common.CommonLib.CombineTool.Version = new byte[]
			{
				0,
				0,
				0,
				1
			};
		}

		// Token: 0x04000033 RID: 51
		protected static readonly char[] MagicHeader;

		// Token: 0x04000034 RID: 52
		protected static readonly byte[] MagicHeaderBytes;

		// Token: 0x04000035 RID: 53
		protected static readonly byte[] Version;
	}
}
