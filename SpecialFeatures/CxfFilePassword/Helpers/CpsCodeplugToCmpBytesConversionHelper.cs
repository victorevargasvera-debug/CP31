using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CxfFilePassword.Helpers
{
	// Token: 0x02000152 RID: 338
	internal class CpsCodeplugToCmpBytesConversionHelper
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0017CC10 File Offset: 0x0017AE10
		private static int IshTypeHeaderOffset
		{
			get
			{
				short num = (short)462512264;
				short num2 = num;
				num = (short)1043292296;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return 0;
				case 1:
					break;
				default:
				{
					num = (short)244711424;
					short num3 = num;
					break;
				}
				}
				num = (short)806879233;
				if (num != 0)
				{
				}
				num = (short)82247680;
				if (num != 0)
				{
				}
				if (global::System.BitConverter.IsLittleEndian)
				{
					return 4;
				}
				return 0;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0017CCC8 File Offset: 0x0017AEC8
		private static int IshIdHeaderOffset
		{
			get
			{
				short num = (short)9041043;
				short num2 = num;
				num = (short)1427960979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386545152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)581566464;
				if (num != 0)
				{
				}
				num = (short)168296449;
				if (num != 0)
				{
				}
				return 2;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0017CD70 File Offset: 0x0017AF70
		private static int IshItemSizeHeaderOffset
		{
			get
			{
				short num = (short)1362231450;
				short num2 = num;
				num = (short)1038745754;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return 4;
				case 1:
					break;
				default:
				{
					num = (short)1663762432;
					short num3 = num;
					break;
				}
				}
				num = (short)294780929;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				if (num != 0)
				{
				}
				if (global::System.BitConverter.IsLittleEndian)
				{
					return 0;
				}
				return 4;
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0017CE28 File Offset: 0x0017B028
		public static byte[] ConvertCpsCodeplugToCmpBytes(global::Motorola.Acp.PackUnpack.Ish.Codeplug codeplug)
		{
			short num = (short)809538299;
			short num2 = num;
			num = (short)902861563;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1397817344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1544749057;
			if (num != 0)
			{
			}
			num = (short)1794113536;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.a(codeplug));
			return global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.a(pbaObject);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0017CEE8 File Offset: 0x0017B0E8
		private static byte a(byte A_0)
		{
			int a_ = 6;
			short num = (short)1933508610;
			int num2 = (int)((global::System.IntPtr)num);
			byte result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FA;
				case 1:
					num = (short)1216151556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					goto IL_D8;
				case 4:
					goto IL_117;
				case 5:
					return result;
				}
				IL_45:
				switch (A_0)
				{
				case 0:
					num = (short)2103771137;
					if (num != 0)
					{
					}
					result = 208;
					num = (short)914554885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					result = 210;
					break;
				case 2:
					result = 212;
					num = (short)1127088131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
				{
					num = (short)181184744;
					short num3 = num;
					num = (short)1744021736;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1468203008;
						if (num != 0)
						{
						}
						num = (short)1665073153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				num = (short)862584832;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D8:
			IL_FA:
			return result;
			IL_117:
			num = (short)264634368;
			short num4 = num;
			throw new global::System.InvalidOperationException(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988ﾌﮎﲔ뮚토욢薤肦튨鮪킬袮醰\udab2운鞶ힸ풺즼龾돀ꛂꛄ꣆껈ꗊ꓌뗎듐럒", a_), A_0));
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0017D0A4 File Offset: 0x0017B2A4
		private static global::Motorola.Common.Communication.CommonUtil.IshItemCollection a(global::Motorola.Acp.PackUnpack.Ish.Codeplug A_0)
		{
			int a_ = 2;
			short num = (short)184300312;
			short num2 = num;
			num = (short)999764760;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1472790528;
				if (num != 0)
				{
				}
				num = (short)1701707777;
				if (num != 0)
				{
				}
				num = (short)602996736;
				short num3 = num;
				num = (short)2021195776;
				switch (num)
				{
				}
				break;
			}
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			byte[] array = new byte[6];
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = A_0.Partitions.GetEnumerator();
			try
			{
				num = (short)1650917385;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array2;
					short num5;
					ushort ishType;
					ushort ishId;
					switch (num4)
					{
					case 0:
						goto IL_17B;
					case 1:
						goto IL_17B;
					case 2:
						global::System.Array.Reverse(array);
						num = (short)1854603272;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						if (partition.Image.Read(array2, 0, array2.Length) != (int)num5)
						{
							num = (short)1923743755;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte partitionNumber;
						global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber, ishType, ishId);
						global::Motorola.Common.Communication.CommonUtil.IshItem item = new global::Motorola.Common.Communication.CommonUtil.IshItem((int)num5, array2, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined);
						ishItemCollection.Add(headers, item);
						num = (short)681115649;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (global::System.BitConverter.IsLittleEndian)
						{
							num = (short)717357058;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					case 6:
					{
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream image;
						if (image.Read(array, 0, 6) == 0)
						{
							num = (short)1989017604;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)84017157;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1367801868;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_289;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_13B;
						}
						continue;
					case 10:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)210370567;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
						byte partitionNumber = global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.a((byte)partition.PartitionType);
						global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream image = partition.Image;
						image.Position = 0L;
						num = (short)1193148416;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_302;
					case 12:
						goto IL_353;
					}
					goto IL_13B;
					IL_17B:
					num = (short)1629028358;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					num = (short)1924333578;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_13B:
					goto IL_247;
					IL_289:
					ishType = global::System.BitConverter.ToUInt16(array, global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.IshTypeHeaderOffset);
					ishId = global::System.BitConverter.ToUInt16(array, global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.IshIdHeaderOffset);
					num5 = global::System.BitConverter.ToInt16(array, global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.IshItemSizeHeaderOffset);
					array2 = new byte[(int)num5];
					num = (short)49872899;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_302:
				throw new global::System.InvalidOperationException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힄권랖ﶘ漢ﺞ膠쪢횤螦\udaa8욪첬쎮\uddb0횲잴鞶춸펺\udcbc톾Ꟃꃄꇆꃈꗊ꣌ꯎ뫒ꇔ닖듘ﯚ껜뛞鯠蛢쯤쟦꿨苪臬諮퇰髲蛴ퟶ铸髺釼駾渀焂栄戆洈┊ⴌ与猐簒朔挖瀘甚稜ㄞ༠ഢ", a_));
				IL_353:;
			}
			finally
			{
				num = (short)1068040192;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_388;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)390725634;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3C0;
					}
					IL_388:
					if (enumerator == null)
					{
						break;
					}
					num = (short)888471553;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_3C0:;
			}
			return ishItemCollection;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0017D494 File Offset: 0x0017B694
		private static byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1391357315;
			short num2 = num;
			num = (short)995913091;
			switch (num2 == num)
			{
			default:
			{
				num = (short)692715520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)189399041;
			if (num != 0)
			{
			}
			num = (short)1379008512;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true).Serialize(global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.b, A_0);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0017D550 File Offset: 0x0017B750
		// Note: this type is marked as 'beforefieldinit'.
		static CpsCodeplugToCmpBytesConversionHelper()
		{
			short num = (short)1499407616;
			short num2 = num;
			num = (short)1365124352;
			switch (num2 == num)
			{
			default:
			{
				num = (short)275709952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2059993089;
			if (num != 0)
			{
			}
			num = (short)1620246528;
			if (num != 0)
			{
			}
			global::SpecialFeatures.CxfFilePassword.Helpers.CpsCodeplugToCmpBytesConversionHelper.b = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader
			{
				HeaderVer = 16,
				FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full,
				Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData
			};
		}

		// Token: 0x0400093A RID: 2362
		private const int a = 6;

		// Token: 0x0400093B RID: 2363
		private static readonly global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader b;
	}
}
