using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200000D RID: 13
	public class CombineToolEnh : global::Motorola.Common.CommonLib.CombineTool
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00008A88 File Offset: 0x00006C88
		public static byte[] SerializeObject(object obj)
		{
			short num = (short)193158545;
			short num2 = num;
			num = (short)2131516817;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)395313152;
				if (num != 0)
				{
				}
				num = (short)305922048;
				short num3 = num;
				num = (short)2086928385;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, obj);
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)1999175681;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1614544898;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EB;
							}
							continue;
						case 2:
							goto IL_11E;
						}
						IL_EB:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)900595712;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11E:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public static byte[] Encode(byte[] pbaBytes, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, object>> objKeyValuePairList)
		{
			short num = (short)172294144;
			short num2 = num;
			num = (short)917953005;
			short num3 = num;
			num = (short)203282925;
			switch (num3 == num)
			{
			}
			num = (short)1651507200;
			if (num != 0)
			{
			}
			num = (short)1663172609;
			if (num != 0)
			{
			}
			byte[] devBytes = global::Motorola.Common.CommonLib.CombineToolEnh.SerializeObject(deviceInfo);
			return global::Motorola.Common.CommonLib.CombineToolEnh.Encode(pbaBytes, devBytes, objKeyValuePairList);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00008C80 File Offset: 0x00006E80
		public static byte[] Encode(byte[] pbaBytes, byte[] devBytes, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, object>> objKeyValuePairList)
		{
			short num = (short)1916469248;
			switch (num)
			{
			default:
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				byte[] result;
				try
				{
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
							binaryWriter.Write(devBytes.Length);
							binaryWriter.Write(devBytes);
							using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, object>>.Enumerator enumerator = objKeyValuePairList.GetEnumerator())
							{
								num = (short)1941897216;
								int num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_BC;
										}
										continue;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)860749826;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, object> keyValuePair = enumerator.Current;
										int key = (int)keyValuePair.Key;
										byte[] array = global::Motorola.Common.CommonLib.CombineToolEnh.SerializeObject(keyValuePair.Value);
										binaryWriter.Write(key);
										binaryWriter.Write(array.Length);
										binaryWriter.Write(array);
										num = (short)372113411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)716767236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_167;
									}
									IL_10F:
									num = (short)362151937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_BC:
									goto IL_10F;
								}
								IL_167:;
							}
						}
						finally
						{
							num = (short)807731201;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)binaryWriter).Dispose();
									num = (short)393150466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_18F;
								case 2:
									goto IL_231;
								}
								goto IL_1AC;
								IL_18F:
								switch (0)
								{
								case 0:
								{
									IL_1AC:
									if (binaryWriter == null)
									{
										goto IL_233;
									}
									num = (short)1046081082;
									short num3 = num;
									num = (short)2139024954;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_18F;
									default:
										num = (short)339607552;
										if (num != 0)
										{
										}
										num = (short)1961951232;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
									break;
								}
								}
							}
							IL_231:
							IL_233:;
						}
					}
					finally
					{
						num = (short)1782317057;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)zippingAndEncryptingStream).Dispose();
								num = (short)1203175426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_266;
								}
								continue;
							case 2:
								goto IL_29C;
							}
							IL_266:
							if (zippingAndEncryptingStream == null)
							{
								break;
							}
							num = (short)239337472;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_29C:;
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)22806529;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)740425730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2DB;
							}
							continue;
						case 2:
							goto IL_310;
						}
						IL_2DB:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)211222528;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_310:;
				}
				num = (short)689504256;
				short num4 = num;
				num = (short)744751105;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00009058 File Offset: 0x00007258
		public static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>> DecodeEnh(byte[] combinedData)
		{
			short num = (short)300417024;
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
				byte[] array;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>> list;
				for (;;)
				{
					IL_27:
					int num3;
					int num4;
					global::Motorola.Common.CommonLib.ObjectIdentifier key;
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
						if (num3 < 2)
						{
							num = (short)938213379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						key = (global::Motorola.Common.CommonLib.ObjectIdentifier)global::System.BitConverter.ToInt32(array, num4);
						num4 += 4;
						num5 = global::System.BitConverter.ToInt32(array, num4);
						num4 += 4;
						num = (short)1880031240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_9F;
					case 2:
						if (num4 >= num6)
						{
							num = (short)1643053065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1220214784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)989200384;
						short num7 = num;
						key = (global::Motorola.Common.CommonLib.ObjectIdentifier)num3;
						num5 = global::System.BitConverter.ToInt32(array, num4);
						num4 += 4;
						num = (short)479133703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus(array))
						{
							num = (short)1623785473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1340506513;
						short num8 = num;
						num = (short)1040679313;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9F;
						default:
							goto IL_296;
						}
						break;
					}
					case 5:
						num = (short)507052033;
						if (num != 0)
						{
						}
						goto IL_1CD;
					case 6:
						goto IL_1CD;
					case 7:
						goto IL_A4;
					case 8:
						goto IL_A4;
					case 9:
						return list;
					}
					goto IL_56;
					IL_9F:
					num4 = global::Motorola.Common.CommonLib.CombineTool.MagicHeader.Length + global::Motorola.Common.CommonLib.CombineTool.Version.Length;
					num6 = array.Length;
					list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>>();
					num5 = 0;
					key = global::Motorola.Common.CommonLib.ObjectIdentifier.PbaObject;
					num3 = 0;
					num = (short)173604870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4:
					list.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>(key, array.Skip(num4).Take(num5).ToArray<byte>()));
					num4 += num5;
					num3++;
					num = (short)2129526789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CD:
					num = (short)114884610;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_296:
				num = (short)1458176000;
				if (num != 0)
				{
				}
				return new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>>
				{
					new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>(global::Motorola.Common.CommonLib.ObjectIdentifier.PbaObject, array),
					new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.CommonLib.ObjectIdentifier, byte[]>(global::Motorola.Common.CommonLib.ObjectIdentifier.DeviceInfo, new byte[0])
				};
				IL_56:
				byte[] inputByteArray = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.RemoveCopyRightHeader(combinedData);
				array = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptAndUnzipByteArray(inputByteArray);
				num = (short)52232196;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
