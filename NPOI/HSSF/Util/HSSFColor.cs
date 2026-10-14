using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.Util
{
	// Token: 0x02000342 RID: 834
	public class HSSFColor : global::NPOI.SS.UserModel.IColor
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x0004C3A5 File Offset: 0x0004A5A5
		public static global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> GetIndexHash()
		{
			if (global::NPOI.HSSF.Util.HSSFColor.indexHash == null)
			{
				global::NPOI.HSSF.Util.HSSFColor.indexHash = global::NPOI.HSSF.Util.HSSFColor.CreateColorsByIndexMap();
			}
			return global::NPOI.HSSF.Util.HSSFColor.indexHash;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0004C3BD File Offset: 0x0004A5BD
		public static global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> GetMutableIndexHash()
		{
			return global::NPOI.HSSF.Util.HSSFColor.CreateColorsByIndexMap();
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> CreateColorsByIndexMap()
		{
			global::NPOI.HSSF.Util.HSSFColor[] allColors = global::NPOI.HSSF.Util.HSSFColor.GetAllColors();
			global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> dictionary = new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor>(allColors.Length * 3 / 2);
			foreach (global::NPOI.HSSF.Util.HSSFColor hssfcolor in allColors)
			{
				int indexed = (int)hssfcolor.Indexed;
				if (dictionary.ContainsKey(indexed))
				{
					global::NPOI.HSSF.Util.HSSFColor hssfcolor2 = dictionary[indexed];
					throw new global::System.IO.InvalidDataException(string.Concat(new string[]
					{
						"Dup color index (",
						indexed.ToString(),
						") for colors (",
						hssfcolor2.GetType().Name,
						"),(",
						hssfcolor.GetType().Name,
						")"
					}));
				}
				dictionary.Add(indexed, hssfcolor);
			}
			foreach (global::NPOI.HSSF.Util.HSSFColor hssfcolor3 in allColors)
			{
				int index = global::NPOI.HSSF.Util.HSSFColor.GetIndex2(hssfcolor3);
				if (index != -1)
				{
					dictionary[index] = hssfcolor3;
				}
			}
			return dictionary;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0004C4AC File Offset: 0x0004A6AC
		private static int GetIndex2(global::NPOI.HSSF.Util.HSSFColor color)
		{
			global::System.Reflection.FieldInfo field = color.GetType().GetField("Index2", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			if (field == null)
			{
				return -1;
			}
			return global::System.Convert.ToInt32((short)field.GetValue(color));
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		internal static global::NPOI.HSSF.Util.HSSFColor[] GetAllColors()
		{
			return new global::NPOI.HSSF.Util.HSSFColor[]
			{
				new global::NPOI.HSSF.Util.HSSFColor.Black(),
				new global::NPOI.HSSF.Util.HSSFColor.Brown(),
				new global::NPOI.HSSF.Util.HSSFColor.OliveGreen(),
				new global::NPOI.HSSF.Util.HSSFColor.DarkGreen(),
				new global::NPOI.HSSF.Util.HSSFColor.DarkTeal(),
				new global::NPOI.HSSF.Util.HSSFColor.DarkBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.Indigo(),
				new global::NPOI.HSSF.Util.HSSFColor.Grey80Percent(),
				new global::NPOI.HSSF.Util.HSSFColor.Orange(),
				new global::NPOI.HSSF.Util.HSSFColor.DarkYellow(),
				new global::NPOI.HSSF.Util.HSSFColor.Green(),
				new global::NPOI.HSSF.Util.HSSFColor.Teal(),
				new global::NPOI.HSSF.Util.HSSFColor.Blue(),
				new global::NPOI.HSSF.Util.HSSFColor.BlueGrey(),
				new global::NPOI.HSSF.Util.HSSFColor.Grey50Percent(),
				new global::NPOI.HSSF.Util.HSSFColor.Red(),
				new global::NPOI.HSSF.Util.HSSFColor.LightOrange(),
				new global::NPOI.HSSF.Util.HSSFColor.Lime(),
				new global::NPOI.HSSF.Util.HSSFColor.SeaGreen(),
				new global::NPOI.HSSF.Util.HSSFColor.Aqua(),
				new global::NPOI.HSSF.Util.HSSFColor.LightBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.Violet(),
				new global::NPOI.HSSF.Util.HSSFColor.Grey40Percent(),
				new global::NPOI.HSSF.Util.HSSFColor.Pink(),
				new global::NPOI.HSSF.Util.HSSFColor.Gold(),
				new global::NPOI.HSSF.Util.HSSFColor.Yellow(),
				new global::NPOI.HSSF.Util.HSSFColor.BrightGreen(),
				new global::NPOI.HSSF.Util.HSSFColor.Turquoise(),
				new global::NPOI.HSSF.Util.HSSFColor.DarkRed(),
				new global::NPOI.HSSF.Util.HSSFColor.SkyBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.Plum(),
				new global::NPOI.HSSF.Util.HSSFColor.Grey25Percent(),
				new global::NPOI.HSSF.Util.HSSFColor.Rose(),
				new global::NPOI.HSSF.Util.HSSFColor.LightYellow(),
				new global::NPOI.HSSF.Util.HSSFColor.LightGreen(),
				new global::NPOI.HSSF.Util.HSSFColor.LightTurquoise(),
				new global::NPOI.HSSF.Util.HSSFColor.PaleBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.Lavender(),
				new global::NPOI.HSSF.Util.HSSFColor.White(),
				new global::NPOI.HSSF.Util.HSSFColor.CornflowerBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.LemonChiffon(),
				new global::NPOI.HSSF.Util.HSSFColor.Maroon(),
				new global::NPOI.HSSF.Util.HSSFColor.Orchid(),
				new global::NPOI.HSSF.Util.HSSFColor.Coral(),
				new global::NPOI.HSSF.Util.HSSFColor.RoyalBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.LightCornflowerBlue(),
				new global::NPOI.HSSF.Util.HSSFColor.Tan()
			};
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0004C69A File Offset: 0x0004A89A
		public static global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Util.HSSFColor> GetTripletHash()
		{
			return global::NPOI.HSSF.Util.HSSFColor.CreateColorsByHexStringMap();
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0004C6A4 File Offset: 0x0004A8A4
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Util.HSSFColor> CreateColorsByHexStringMap()
		{
			global::NPOI.HSSF.Util.HSSFColor[] allColors = global::NPOI.HSSF.Util.HSSFColor.GetAllColors();
			global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Util.HSSFColor> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.HSSF.Util.HSSFColor>(allColors.Length * 3 / 2);
			foreach (global::NPOI.HSSF.Util.HSSFColor hssfcolor in allColors)
			{
				string hexString = hssfcolor.GetHexString();
				if (dictionary.ContainsKey(hexString))
				{
					throw new global::System.IO.InvalidDataException(string.Concat(new string[]
					{
						"Dup color hexString (",
						hexString,
						") for color (",
						hssfcolor.GetType().Name,
						")"
					}));
				}
				dictionary[hexString] = hssfcolor;
			}
			return dictionary;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public virtual short Indexed
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0004C72E File Offset: 0x0004A92E
		public byte[] RGB
		{
			get
			{
				return this.GetTriplet();
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0004C736 File Offset: 0x0004A936
		public virtual byte[] GetTriplet()
		{
			return global::NPOI.HSSF.Util.HSSFColor.Black.Triplet;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0004C73D File Offset: 0x0004A93D
		public virtual string GetHexString()
		{
			return "0:0:0";
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0004C744 File Offset: 0x0004A944
		public static global::NPOI.HSSF.Util.HSSFColor ToHSSFColor(global::NPOI.SS.UserModel.IColor color)
		{
			if (color != null && !(color is global::NPOI.HSSF.Util.HSSFColor))
			{
				throw new global::System.ArgumentException("Only HSSFColor objects are supported");
			}
			return (global::NPOI.HSSF.Util.HSSFColor)color;
		}

		// Token: 0x040009F5 RID: 2549
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Util.HSSFColor> indexHash;

		// Token: 0x040009F6 RID: 2550
		public const short COLOR_NORMAL = 32767;

		// Token: 0x020005CA RID: 1482
		public class Black : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x06003508 RID: 13576 RVA: 0x00017DF4 File Offset: 0x00015FF4
			public override short Indexed
			{
				get
				{
					return 8;
				}
			}

			// Token: 0x06003509 RID: 13577 RVA: 0x0004C736 File Offset: 0x0004A936
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Black.Triplet;
			}

			// Token: 0x0600350A RID: 13578 RVA: 0x0004C73D File Offset: 0x0004A93D
			public override string GetHexString()
			{
				return "0:0:0";
			}

			// Token: 0x04001987 RID: 6535
			public const short Index = 8;

			// Token: 0x04001988 RID: 6536
			public static readonly byte[] Triplet = new byte[3];

			// Token: 0x04001989 RID: 6537
			public const string HexString = "0:0:0";
		}

		// Token: 0x020005CB RID: 1483
		public class Brown : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x0600350D RID: 13581 RVA: 0x00066981 File Offset: 0x00064B81
			public override short Indexed
			{
				get
				{
					return 60;
				}
			}

			// Token: 0x0600350E RID: 13582 RVA: 0x000A4C7E File Offset: 0x000A2E7E
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Brown.Triplet;
			}

			// Token: 0x0600350F RID: 13583 RVA: 0x000A4C85 File Offset: 0x000A2E85
			public override string GetHexString()
			{
				return "9999:3333:0";
			}

			// Token: 0x06003511 RID: 13585 RVA: 0x000A4C8C File Offset: 0x000A2E8C
			// Note: this type is marked as 'beforefieldinit'.
			static Brown()
			{
				byte[] array = new byte[3];
				array[0] = 153;
				array[1] = 51;
				global::NPOI.HSSF.Util.HSSFColor.Brown.Triplet = array;
			}

			// Token: 0x0400198A RID: 6538
			public const short Index = 60;

			// Token: 0x0400198B RID: 6539
			public static readonly byte[] Triplet;

			// Token: 0x0400198C RID: 6540
			public const string HexString = "9999:3333:0";
		}

		// Token: 0x020005CC RID: 1484
		public class OliveGreen : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06003512 RID: 13586 RVA: 0x000A4CA6 File Offset: 0x000A2EA6
			public override short Indexed
			{
				get
				{
					return 59;
				}
			}

			// Token: 0x06003513 RID: 13587 RVA: 0x000A4CAA File Offset: 0x000A2EAA
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.OliveGreen.Triplet;
			}

			// Token: 0x06003514 RID: 13588 RVA: 0x000A4CB1 File Offset: 0x000A2EB1
			public override string GetHexString()
			{
				return "3333:3333:0";
			}

			// Token: 0x06003516 RID: 13590 RVA: 0x000A4CB8 File Offset: 0x000A2EB8
			// Note: this type is marked as 'beforefieldinit'.
			static OliveGreen()
			{
				byte[] array = new byte[3];
				array[0] = 51;
				array[1] = 51;
				global::NPOI.HSSF.Util.HSSFColor.OliveGreen.Triplet = array;
			}

			// Token: 0x0400198D RID: 6541
			public const short Index = 59;

			// Token: 0x0400198E RID: 6542
			public static readonly byte[] Triplet;

			// Token: 0x0400198F RID: 6543
			public const string HexString = "3333:3333:0";
		}

		// Token: 0x020005CD RID: 1485
		public class DarkGreen : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06003517 RID: 13591 RVA: 0x000A4CCF File Offset: 0x000A2ECF
			public override short Indexed
			{
				get
				{
					return 58;
				}
			}

			// Token: 0x06003518 RID: 13592 RVA: 0x000A4CD3 File Offset: 0x000A2ED3
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.DarkGreen.Triplet;
			}

			// Token: 0x06003519 RID: 13593 RVA: 0x000A4CDA File Offset: 0x000A2EDA
			public override string GetHexString()
			{
				return "0:3333:0";
			}

			// Token: 0x0600351B RID: 13595 RVA: 0x000A4CE1 File Offset: 0x000A2EE1
			// Note: this type is marked as 'beforefieldinit'.
			static DarkGreen()
			{
				byte[] array = new byte[3];
				array[1] = 51;
				global::NPOI.HSSF.Util.HSSFColor.DarkGreen.Triplet = array;
			}

			// Token: 0x04001990 RID: 6544
			public const short Index = 58;

			// Token: 0x04001991 RID: 6545
			public static readonly byte[] Triplet;

			// Token: 0x04001992 RID: 6546
			public const string HexString = "0:3333:0";
		}

		// Token: 0x020005CE RID: 1486
		public class DarkTeal : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x0600351C RID: 13596 RVA: 0x000A4CF3 File Offset: 0x000A2EF3
			public override short Indexed
			{
				get
				{
					return 56;
				}
			}

			// Token: 0x0600351D RID: 13597 RVA: 0x000A4CF7 File Offset: 0x000A2EF7
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.DarkTeal.Triplet;
			}

			// Token: 0x0600351E RID: 13598 RVA: 0x000A4CFE File Offset: 0x000A2EFE
			public override string GetHexString()
			{
				return "0:3333:6666";
			}

			// Token: 0x04001993 RID: 6547
			public const short Index = 56;

			// Token: 0x04001994 RID: 6548
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				51,
				102
			};

			// Token: 0x04001995 RID: 6549
			public const string HexString = "0:3333:6666";
		}

		// Token: 0x020005CF RID: 1487
		public class DarkBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06003521 RID: 13601 RVA: 0x000199E4 File Offset: 0x00017BE4
			public override short Indexed
			{
				get
				{
					return 18;
				}
			}

			// Token: 0x06003522 RID: 13602 RVA: 0x000A4D1C File Offset: 0x000A2F1C
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.DarkBlue.Triplet;
			}

			// Token: 0x06003523 RID: 13603 RVA: 0x000A4D23 File Offset: 0x000A2F23
			public override string GetHexString()
			{
				return "0:0:8080";
			}

			// Token: 0x04001996 RID: 6550
			public const short Index = 18;

			// Token: 0x04001997 RID: 6551
			public const short Index2 = 32;

			// Token: 0x04001998 RID: 6552
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				0,
				128
			};

			// Token: 0x04001999 RID: 6553
			public const string HexString = "0:0:8080";
		}

		// Token: 0x020005D0 RID: 1488
		public class Indigo : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06003526 RID: 13606 RVA: 0x000A4D3F File Offset: 0x000A2F3F
			public override short Indexed
			{
				get
				{
					return 62;
				}
			}

			// Token: 0x06003527 RID: 13607 RVA: 0x000A4D43 File Offset: 0x000A2F43
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Indigo.Triplet;
			}

			// Token: 0x06003528 RID: 13608 RVA: 0x000A4D4A File Offset: 0x000A2F4A
			public override string GetHexString()
			{
				return "3333:3333:9999";
			}

			// Token: 0x0400199A RID: 6554
			public const short Index = 62;

			// Token: 0x0400199B RID: 6555
			public static readonly byte[] Triplet = new byte[]
			{
				51,
				51,
				153
			};

			// Token: 0x0400199C RID: 6556
			public const string HexString = "3333:3333:9999";
		}

		// Token: 0x020005D1 RID: 1489
		public class Grey80Percent : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x0600352B RID: 13611 RVA: 0x000A4D69 File Offset: 0x000A2F69
			public override short Indexed
			{
				get
				{
					return 63;
				}
			}

			// Token: 0x0600352C RID: 13612 RVA: 0x000A4D6D File Offset: 0x000A2F6D
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Grey80Percent.Triplet;
			}

			// Token: 0x0600352D RID: 13613 RVA: 0x000A4D74 File Offset: 0x000A2F74
			public override string GetHexString()
			{
				return "3333:3333:3333";
			}

			// Token: 0x0400199D RID: 6557
			public const short Index = 63;

			// Token: 0x0400199E RID: 6558
			public static readonly byte[] Triplet = new byte[]
			{
				51,
				51,
				51
			};

			// Token: 0x0400199F RID: 6559
			public const string HexString = "3333:3333:3333";
		}

		// Token: 0x020005D2 RID: 1490
		public class DarkRed : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x06003530 RID: 13616 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
			public override short Indexed
			{
				get
				{
					return 16;
				}
			}

			// Token: 0x06003531 RID: 13617 RVA: 0x000A4D93 File Offset: 0x000A2F93
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.DarkRed.Triplet;
			}

			// Token: 0x06003532 RID: 13618 RVA: 0x000A4D9A File Offset: 0x000A2F9A
			public override string GetHexString()
			{
				return "8080:0:0";
			}

			// Token: 0x06003534 RID: 13620 RVA: 0x000A4DA1 File Offset: 0x000A2FA1
			// Note: this type is marked as 'beforefieldinit'.
			static DarkRed()
			{
				byte[] array = new byte[3];
				array[0] = 128;
				global::NPOI.HSSF.Util.HSSFColor.DarkRed.Triplet = array;
			}

			// Token: 0x040019A0 RID: 6560
			public const short Index = 16;

			// Token: 0x040019A1 RID: 6561
			public const short Index2 = 37;

			// Token: 0x040019A2 RID: 6562
			public static readonly byte[] Triplet;

			// Token: 0x040019A3 RID: 6563
			public const string HexString = "8080:0:0";
		}

		// Token: 0x020005D3 RID: 1491
		public class Orange : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x06003535 RID: 13621 RVA: 0x000A4DB6 File Offset: 0x000A2FB6
			public override short Indexed
			{
				get
				{
					return 53;
				}
			}

			// Token: 0x06003536 RID: 13622 RVA: 0x000A4DBA File Offset: 0x000A2FBA
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Orange.Triplet;
			}

			// Token: 0x06003537 RID: 13623 RVA: 0x000A4DC1 File Offset: 0x000A2FC1
			public override string GetHexString()
			{
				return "FFFF:6666:0";
			}

			// Token: 0x06003539 RID: 13625 RVA: 0x000A4DC8 File Offset: 0x000A2FC8
			// Note: this type is marked as 'beforefieldinit'.
			static Orange()
			{
				byte[] array = new byte[3];
				array[0] = byte.MaxValue;
				array[1] = 102;
				global::NPOI.HSSF.Util.HSSFColor.Orange.Triplet = array;
			}

			// Token: 0x040019A4 RID: 6564
			public const short Index = 53;

			// Token: 0x040019A5 RID: 6565
			public static readonly byte[] Triplet;

			// Token: 0x040019A6 RID: 6566
			public const string HexString = "FFFF:6666:0";
		}

		// Token: 0x020005D4 RID: 1492
		public class DarkYellow : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x0600353A RID: 13626 RVA: 0x000199B2 File Offset: 0x00017BB2
			public override short Indexed
			{
				get
				{
					return 19;
				}
			}

			// Token: 0x0600353B RID: 13627 RVA: 0x000A4DE2 File Offset: 0x000A2FE2
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.DarkYellow.Triplet;
			}

			// Token: 0x0600353C RID: 13628 RVA: 0x000A4DE9 File Offset: 0x000A2FE9
			public override string GetHexString()
			{
				return "8080:8080:0";
			}

			// Token: 0x0600353E RID: 13630 RVA: 0x000A4DF0 File Offset: 0x000A2FF0
			// Note: this type is marked as 'beforefieldinit'.
			static DarkYellow()
			{
				byte[] array = new byte[3];
				array[0] = 128;
				array[1] = 128;
				global::NPOI.HSSF.Util.HSSFColor.DarkYellow.Triplet = array;
			}

			// Token: 0x040019A7 RID: 6567
			public const short Index = 19;

			// Token: 0x040019A8 RID: 6568
			public static readonly byte[] Triplet;

			// Token: 0x040019A9 RID: 6569
			public const string HexString = "8080:8080:0";
		}

		// Token: 0x020005D5 RID: 1493
		public class Green : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x0600353F RID: 13631 RVA: 0x0006D7BF File Offset: 0x0006B9BF
			public override short Indexed
			{
				get
				{
					return 17;
				}
			}

			// Token: 0x06003540 RID: 13632 RVA: 0x000A4E0D File Offset: 0x000A300D
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Green.Triplet;
			}

			// Token: 0x06003541 RID: 13633 RVA: 0x000A4E14 File Offset: 0x000A3014
			public override string GetHexString()
			{
				return "0:8080:0";
			}

			// Token: 0x06003543 RID: 13635 RVA: 0x000A4E1B File Offset: 0x000A301B
			// Note: this type is marked as 'beforefieldinit'.
			static Green()
			{
				byte[] array = new byte[3];
				array[1] = 128;
				global::NPOI.HSSF.Util.HSSFColor.Green.Triplet = array;
			}

			// Token: 0x040019AA RID: 6570
			public const short Index = 17;

			// Token: 0x040019AB RID: 6571
			public static readonly byte[] Triplet;

			// Token: 0x040019AC RID: 6572
			public const string HexString = "0:8080:0";
		}

		// Token: 0x020005D6 RID: 1494
		public class Teal : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x06003544 RID: 13636 RVA: 0x0006B70C File Offset: 0x0006990C
			public override short Indexed
			{
				get
				{
					return 21;
				}
			}

			// Token: 0x06003545 RID: 13637 RVA: 0x000A4E30 File Offset: 0x000A3030
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Teal.Triplet;
			}

			// Token: 0x06003546 RID: 13638 RVA: 0x000A4E37 File Offset: 0x000A3037
			public override string GetHexString()
			{
				return "0:8080:8080";
			}

			// Token: 0x040019AD RID: 6573
			public const short Index = 21;

			// Token: 0x040019AE RID: 6574
			public const short Index2 = 38;

			// Token: 0x040019AF RID: 6575
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				128,
				128
			};

			// Token: 0x040019B0 RID: 6576
			public const string HexString = "0:8080:8080";
		}

		// Token: 0x020005D7 RID: 1495
		public class Blue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x06003549 RID: 13641 RVA: 0x000184AD File Offset: 0x000166AD
			public override short Indexed
			{
				get
				{
					return 12;
				}
			}

			// Token: 0x0600354A RID: 13642 RVA: 0x000A4E5B File Offset: 0x000A305B
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Blue.Triplet;
			}

			// Token: 0x0600354B RID: 13643 RVA: 0x000A4E62 File Offset: 0x000A3062
			public override string GetHexString()
			{
				return "0:0:FFFF";
			}

			// Token: 0x040019B1 RID: 6577
			public const short Index = 12;

			// Token: 0x040019B2 RID: 6578
			public const short Index2 = 39;

			// Token: 0x040019B3 RID: 6579
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				0,
				byte.MaxValue
			};

			// Token: 0x040019B4 RID: 6580
			public const string HexString = "0:0:FFFF";
		}

		// Token: 0x020005D8 RID: 1496
		public class BlueGrey : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x0600354E RID: 13646 RVA: 0x000A4E7E File Offset: 0x000A307E
			public override short Indexed
			{
				get
				{
					return 54;
				}
			}

			// Token: 0x0600354F RID: 13647 RVA: 0x000A4E82 File Offset: 0x000A3082
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.BlueGrey.Triplet;
			}

			// Token: 0x06003550 RID: 13648 RVA: 0x000A4E89 File Offset: 0x000A3089
			public override string GetHexString()
			{
				return "6666:6666:9999";
			}

			// Token: 0x040019B5 RID: 6581
			public const short Index = 54;

			// Token: 0x040019B6 RID: 6582
			public static readonly byte[] Triplet = new byte[]
			{
				102,
				102,
				153
			};

			// Token: 0x040019B7 RID: 6583
			public const string HexString = "6666:6666:9999";
		}

		// Token: 0x020005D9 RID: 1497
		public class Grey50Percent : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x06003553 RID: 13651 RVA: 0x0006A6BA File Offset: 0x000688BA
			public override short Indexed
			{
				get
				{
					return 23;
				}
			}

			// Token: 0x06003554 RID: 13652 RVA: 0x000A4EA8 File Offset: 0x000A30A8
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Grey50Percent.Triplet;
			}

			// Token: 0x06003555 RID: 13653 RVA: 0x000A4EAF File Offset: 0x000A30AF
			public override string GetHexString()
			{
				return "8080:8080:8080";
			}

			// Token: 0x040019B8 RID: 6584
			public const short Index = 23;

			// Token: 0x040019B9 RID: 6585
			public static readonly byte[] Triplet = new byte[]
			{
				128,
				128,
				128
			};

			// Token: 0x040019BA RID: 6586
			public const string HexString = "8080:8080:8080";
		}

		// Token: 0x020005DA RID: 1498
		public class Red : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x06003558 RID: 13656 RVA: 0x00018662 File Offset: 0x00016862
			public override short Indexed
			{
				get
				{
					return 10;
				}
			}

			// Token: 0x06003559 RID: 13657 RVA: 0x000A4ECE File Offset: 0x000A30CE
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Red.Triplet;
			}

			// Token: 0x0600355A RID: 13658 RVA: 0x000A4ED5 File Offset: 0x000A30D5
			public override string GetHexString()
			{
				return "FFFF:0:0";
			}

			// Token: 0x0600355C RID: 13660 RVA: 0x000A4EDC File Offset: 0x000A30DC
			// Note: this type is marked as 'beforefieldinit'.
			static Red()
			{
				byte[] array = new byte[3];
				array[0] = byte.MaxValue;
				global::NPOI.HSSF.Util.HSSFColor.Red.Triplet = array;
			}

			// Token: 0x040019BB RID: 6587
			public const short Index = 10;

			// Token: 0x040019BC RID: 6588
			public static readonly byte[] Triplet;

			// Token: 0x040019BD RID: 6589
			public const string HexString = "FFFF:0:0";
		}

		// Token: 0x020005DB RID: 1499
		public class LightOrange : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x0600355D RID: 13661 RVA: 0x000A4EF1 File Offset: 0x000A30F1
			public override short Indexed
			{
				get
				{
					return 52;
				}
			}

			// Token: 0x0600355E RID: 13662 RVA: 0x000A4EF5 File Offset: 0x000A30F5
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightOrange.Triplet;
			}

			// Token: 0x0600355F RID: 13663 RVA: 0x000A4EFC File Offset: 0x000A30FC
			public override string GetHexString()
			{
				return "FFFF:9999:0";
			}

			// Token: 0x06003561 RID: 13665 RVA: 0x000A4F03 File Offset: 0x000A3103
			// Note: this type is marked as 'beforefieldinit'.
			static LightOrange()
			{
				byte[] array = new byte[3];
				array[0] = byte.MaxValue;
				array[1] = 153;
				global::NPOI.HSSF.Util.HSSFColor.LightOrange.Triplet = array;
			}

			// Token: 0x040019BE RID: 6590
			public const short Index = 52;

			// Token: 0x040019BF RID: 6591
			public static readonly byte[] Triplet;

			// Token: 0x040019C0 RID: 6592
			public const string HexString = "FFFF:9999:0";
		}

		// Token: 0x020005DC RID: 1500
		public class Lime : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x06003562 RID: 13666 RVA: 0x000A4F20 File Offset: 0x000A3120
			public override short Indexed
			{
				get
				{
					return 50;
				}
			}

			// Token: 0x06003563 RID: 13667 RVA: 0x000A4F24 File Offset: 0x000A3124
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Lime.Triplet;
			}

			// Token: 0x06003564 RID: 13668 RVA: 0x000A4F2B File Offset: 0x000A312B
			public override string GetHexString()
			{
				return "9999:CCCC:0";
			}

			// Token: 0x06003566 RID: 13670 RVA: 0x000A4F32 File Offset: 0x000A3132
			// Note: this type is marked as 'beforefieldinit'.
			static Lime()
			{
				byte[] array = new byte[3];
				array[0] = 153;
				array[1] = 204;
				global::NPOI.HSSF.Util.HSSFColor.Lime.Triplet = array;
			}

			// Token: 0x040019C1 RID: 6593
			public const short Index = 50;

			// Token: 0x040019C2 RID: 6594
			public static readonly byte[] Triplet;

			// Token: 0x040019C3 RID: 6595
			public const string HexString = "9999:CCCC:0";
		}

		// Token: 0x020005DD RID: 1501
		public class SeaGreen : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x06003567 RID: 13671 RVA: 0x000A4F4F File Offset: 0x000A314F
			public override short Indexed
			{
				get
				{
					return 57;
				}
			}

			// Token: 0x06003568 RID: 13672 RVA: 0x000A4F53 File Offset: 0x000A3153
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.SeaGreen.Triplet;
			}

			// Token: 0x06003569 RID: 13673 RVA: 0x000A4F5A File Offset: 0x000A315A
			public override string GetHexString()
			{
				return "3333:9999:6666";
			}

			// Token: 0x040019C4 RID: 6596
			public const short Index = 57;

			// Token: 0x040019C5 RID: 6597
			public static readonly byte[] Triplet = new byte[]
			{
				51,
				153,
				102
			};

			// Token: 0x040019C6 RID: 6598
			public const string HexString = "3333:9999:6666";
		}

		// Token: 0x020005DE RID: 1502
		public class Aqua : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x0600356C RID: 13676 RVA: 0x0006B5D9 File Offset: 0x000697D9
			public override short Indexed
			{
				get
				{
					return 49;
				}
			}

			// Token: 0x0600356D RID: 13677 RVA: 0x000A4F79 File Offset: 0x000A3179
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Aqua.Triplet;
			}

			// Token: 0x0600356E RID: 13678 RVA: 0x000A4F80 File Offset: 0x000A3180
			public override string GetHexString()
			{
				return "3333:CCCC:CCCC";
			}

			// Token: 0x040019C7 RID: 6599
			public const short Index = 49;

			// Token: 0x040019C8 RID: 6600
			public static readonly byte[] Triplet = new byte[]
			{
				51,
				204,
				204
			};

			// Token: 0x040019C9 RID: 6601
			public const string HexString = "3333:CCCC:CCCC";
		}

		// Token: 0x020005DF RID: 1503
		public class LightBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x06003571 RID: 13681 RVA: 0x000A4F9F File Offset: 0x000A319F
			public override short Indexed
			{
				get
				{
					return 48;
				}
			}

			// Token: 0x06003572 RID: 13682 RVA: 0x000A4FA3 File Offset: 0x000A31A3
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightBlue.Triplet;
			}

			// Token: 0x06003573 RID: 13683 RVA: 0x000A4FAA File Offset: 0x000A31AA
			public override string GetHexString()
			{
				return "3333:6666:FFFF";
			}

			// Token: 0x040019CA RID: 6602
			public const short Index = 48;

			// Token: 0x040019CB RID: 6603
			public static readonly byte[] Triplet = new byte[]
			{
				51,
				102,
				byte.MaxValue
			};

			// Token: 0x040019CC RID: 6604
			public const string HexString = "3333:6666:FFFF";
		}

		// Token: 0x020005E0 RID: 1504
		public class Violet : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x06003576 RID: 13686 RVA: 0x00018AA0 File Offset: 0x00016CA0
			public override short Indexed
			{
				get
				{
					return 20;
				}
			}

			// Token: 0x06003577 RID: 13687 RVA: 0x000A4FC9 File Offset: 0x000A31C9
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Violet.Triplet;
			}

			// Token: 0x06003578 RID: 13688 RVA: 0x000A4FD0 File Offset: 0x000A31D0
			public override string GetHexString()
			{
				return "8080:0:8080";
			}

			// Token: 0x040019CD RID: 6605
			public const short Index = 20;

			// Token: 0x040019CE RID: 6606
			public const short Index2 = 36;

			// Token: 0x040019CF RID: 6607
			public static readonly byte[] Triplet = new byte[]
			{
				128,
				0,
				128
			};

			// Token: 0x040019D0 RID: 6608
			public const string HexString = "8080:0:8080";
		}

		// Token: 0x020005E1 RID: 1505
		public class Grey40Percent : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x0600357B RID: 13691 RVA: 0x000A4FF4 File Offset: 0x000A31F4
			public override short Indexed
			{
				get
				{
					return 55;
				}
			}

			// Token: 0x0600357C RID: 13692 RVA: 0x000A4FF8 File Offset: 0x000A31F8
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Grey40Percent.Triplet;
			}

			// Token: 0x0600357D RID: 13693 RVA: 0x000A4FFF File Offset: 0x000A31FF
			public override string GetHexString()
			{
				return "9696:9696:9696";
			}

			// Token: 0x040019D1 RID: 6609
			public const short Index = 55;

			// Token: 0x040019D2 RID: 6610
			public static readonly byte[] Triplet = new byte[]
			{
				150,
				150,
				150
			};

			// Token: 0x040019D3 RID: 6611
			public const string HexString = "9696:9696:9696";
		}

		// Token: 0x020005E2 RID: 1506
		public class Pink : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x06003580 RID: 13696 RVA: 0x00018987 File Offset: 0x00016B87
			public override short Indexed
			{
				get
				{
					return 14;
				}
			}

			// Token: 0x06003581 RID: 13697 RVA: 0x000A501E File Offset: 0x000A321E
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Pink.Triplet;
			}

			// Token: 0x06003582 RID: 13698 RVA: 0x000A5025 File Offset: 0x000A3225
			public override string GetHexString()
			{
				return "FFFF:0:FFFF";
			}

			// Token: 0x040019D4 RID: 6612
			public const short Index = 14;

			// Token: 0x040019D5 RID: 6613
			public const short Index2 = 33;

			// Token: 0x040019D6 RID: 6614
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				0,
				byte.MaxValue
			};

			// Token: 0x040019D7 RID: 6615
			public const string HexString = "FFFF:0:FFFF";
		}

		// Token: 0x020005E3 RID: 1507
		public class Gold : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x06003585 RID: 13701 RVA: 0x00071219 File Offset: 0x0006F419
			public override short Indexed
			{
				get
				{
					return 51;
				}
			}

			// Token: 0x06003586 RID: 13702 RVA: 0x000A5049 File Offset: 0x000A3249
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Gold.Triplet;
			}

			// Token: 0x06003587 RID: 13703 RVA: 0x000A5050 File Offset: 0x000A3250
			public override string GetHexString()
			{
				return "FFFF:CCCC:0";
			}

			// Token: 0x06003589 RID: 13705 RVA: 0x000A5057 File Offset: 0x000A3257
			// Note: this type is marked as 'beforefieldinit'.
			static Gold()
			{
				byte[] array = new byte[3];
				array[0] = byte.MaxValue;
				array[1] = 204;
				global::NPOI.HSSF.Util.HSSFColor.Gold.Triplet = array;
			}

			// Token: 0x040019D8 RID: 6616
			public const short Index = 51;

			// Token: 0x040019D9 RID: 6617
			public static readonly byte[] Triplet;

			// Token: 0x040019DA RID: 6618
			public const string HexString = "FFFF:CCCC:0";
		}

		// Token: 0x020005E4 RID: 1508
		public class Yellow : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x0600358A RID: 13706 RVA: 0x000184E9 File Offset: 0x000166E9
			public override short Indexed
			{
				get
				{
					return 13;
				}
			}

			// Token: 0x0600358B RID: 13707 RVA: 0x000A5074 File Offset: 0x000A3274
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Yellow.Triplet;
			}

			// Token: 0x0600358C RID: 13708 RVA: 0x000A507B File Offset: 0x000A327B
			public override string GetHexString()
			{
				return "FFFF:FFFF:0";
			}

			// Token: 0x0600358E RID: 13710 RVA: 0x000A5082 File Offset: 0x000A3282
			// Note: this type is marked as 'beforefieldinit'.
			static Yellow()
			{
				byte[] array = new byte[3];
				array[0] = byte.MaxValue;
				array[1] = byte.MaxValue;
				global::NPOI.HSSF.Util.HSSFColor.Yellow.Triplet = array;
			}

			// Token: 0x040019DB RID: 6619
			public const short Index = 13;

			// Token: 0x040019DC RID: 6620
			public const short Index2 = 34;

			// Token: 0x040019DD RID: 6621
			public static readonly byte[] Triplet;

			// Token: 0x040019DE RID: 6622
			public const string HexString = "FFFF:FFFF:0";
		}

		// Token: 0x020005E5 RID: 1509
		public class BrightGreen : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x0600358F RID: 13711 RVA: 0x000A509F File Offset: 0x000A329F
			public override string GetHexString()
			{
				return "0:FFFF:0";
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06003590 RID: 13712 RVA: 0x00016C75 File Offset: 0x00014E75
			public override short Indexed
			{
				get
				{
					return 11;
				}
			}

			// Token: 0x06003591 RID: 13713 RVA: 0x000A50A6 File Offset: 0x000A32A6
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.BrightGreen.Triplet;
			}

			// Token: 0x06003593 RID: 13715 RVA: 0x000A50AD File Offset: 0x000A32AD
			// Note: this type is marked as 'beforefieldinit'.
			static BrightGreen()
			{
				byte[] array = new byte[3];
				array[1] = byte.MaxValue;
				global::NPOI.HSSF.Util.HSSFColor.BrightGreen.Triplet = array;
			}

			// Token: 0x040019DF RID: 6623
			public const short Index = 11;

			// Token: 0x040019E0 RID: 6624
			public const short Index2 = 35;

			// Token: 0x040019E1 RID: 6625
			public static readonly byte[] Triplet;

			// Token: 0x040019E2 RID: 6626
			public const string HexString = "0:FFFF:0";
		}

		// Token: 0x020005E6 RID: 1510
		public class Turquoise : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06003594 RID: 13716 RVA: 0x00073259 File Offset: 0x00071459
			public override short Indexed
			{
				get
				{
					return 15;
				}
			}

			// Token: 0x06003595 RID: 13717 RVA: 0x000A50C2 File Offset: 0x000A32C2
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Turquoise.Triplet;
			}

			// Token: 0x06003596 RID: 13718 RVA: 0x000A50C9 File Offset: 0x000A32C9
			public override string GetHexString()
			{
				return "0:FFFF:FFFF";
			}

			// Token: 0x040019E3 RID: 6627
			public const short Index = 15;

			// Token: 0x040019E4 RID: 6628
			public const short Index2 = 35;

			// Token: 0x040019E5 RID: 6629
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				byte.MaxValue,
				byte.MaxValue
			};

			// Token: 0x040019E6 RID: 6630
			public const string HexString = "0:FFFF:FFFF";
		}

		// Token: 0x020005E7 RID: 1511
		public class SkyBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06003599 RID: 13721 RVA: 0x00077FA4 File Offset: 0x000761A4
			public override short Indexed
			{
				get
				{
					return 40;
				}
			}

			// Token: 0x0600359A RID: 13722 RVA: 0x000A50ED File Offset: 0x000A32ED
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.SkyBlue.Triplet;
			}

			// Token: 0x0600359B RID: 13723 RVA: 0x000A50F4 File Offset: 0x000A32F4
			public override string GetHexString()
			{
				return "0:CCCC:FFFF";
			}

			// Token: 0x040019E7 RID: 6631
			public const short Index = 40;

			// Token: 0x040019E8 RID: 6632
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				204,
				byte.MaxValue
			};

			// Token: 0x040019E9 RID: 6633
			public const string HexString = "0:CCCC:FFFF";
		}

		// Token: 0x020005E8 RID: 1512
		public class Plum : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x0600359E RID: 13726 RVA: 0x00078F85 File Offset: 0x00077185
			public override short Indexed
			{
				get
				{
					return 61;
				}
			}

			// Token: 0x0600359F RID: 13727 RVA: 0x000A5118 File Offset: 0x000A3318
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Plum.Triplet;
			}

			// Token: 0x060035A0 RID: 13728 RVA: 0x000A511F File Offset: 0x000A331F
			public override string GetHexString()
			{
				return "9999:3333:6666";
			}

			// Token: 0x040019EA RID: 6634
			public const short Index = 61;

			// Token: 0x040019EB RID: 6635
			public const short Index2 = 25;

			// Token: 0x040019EC RID: 6636
			public static readonly byte[] Triplet = new byte[]
			{
				153,
				51,
				102
			};

			// Token: 0x040019ED RID: 6637
			public const string HexString = "9999:3333:6666";
		}

		// Token: 0x020005E9 RID: 1513
		public class Grey25Percent : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x060035A3 RID: 13731 RVA: 0x000A513E File Offset: 0x000A333E
			public override short Indexed
			{
				get
				{
					return 22;
				}
			}

			// Token: 0x060035A4 RID: 13732 RVA: 0x000A5142 File Offset: 0x000A3342
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Grey25Percent.Triplet;
			}

			// Token: 0x060035A5 RID: 13733 RVA: 0x000A5149 File Offset: 0x000A3349
			public override string GetHexString()
			{
				return "C0C0:C0C0:C0C0";
			}

			// Token: 0x040019EE RID: 6638
			public const short Index = 22;

			// Token: 0x040019EF RID: 6639
			public static readonly byte[] Triplet = new byte[]
			{
				192,
				192,
				192
			};

			// Token: 0x040019F0 RID: 6640
			public const string HexString = "C0C0:C0C0:C0C0";
		}

		// Token: 0x020005EA RID: 1514
		public class Rose : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00016E26 File Offset: 0x00015026
			public override short Indexed
			{
				get
				{
					return 45;
				}
			}

			// Token: 0x060035A9 RID: 13737 RVA: 0x000A5168 File Offset: 0x000A3368
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Rose.Triplet;
			}

			// Token: 0x060035AA RID: 13738 RVA: 0x000A516F File Offset: 0x000A336F
			public override string GetHexString()
			{
				return "FFFF:9999:CCCC";
			}

			// Token: 0x040019F1 RID: 6641
			public const short Index = 45;

			// Token: 0x040019F2 RID: 6642
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				153,
				204
			};

			// Token: 0x040019F3 RID: 6643
			public const string HexString = "FFFF:9999:CCCC";
		}

		// Token: 0x020005EB RID: 1515
		public class Tan : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x060035AD RID: 13741 RVA: 0x0006ACA9 File Offset: 0x00068EA9
			public override short Indexed
			{
				get
				{
					return 47;
				}
			}

			// Token: 0x060035AE RID: 13742 RVA: 0x000A518E File Offset: 0x000A338E
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Tan.Triplet;
			}

			// Token: 0x060035AF RID: 13743 RVA: 0x000A5195 File Offset: 0x000A3395
			public override string GetHexString()
			{
				return "FFFF:CCCC:9999";
			}

			// Token: 0x040019F4 RID: 6644
			public const short Index = 47;

			// Token: 0x040019F5 RID: 6645
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				204,
				153
			};

			// Token: 0x040019F6 RID: 6646
			public const string HexString = "FFFF:CCCC:9999";
		}

		// Token: 0x020005EC RID: 1516
		public class LightYellow : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE8 RID: 3560
			// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0007091E File Offset: 0x0006EB1E
			public override short Indexed
			{
				get
				{
					return 43;
				}
			}

			// Token: 0x060035B3 RID: 13747 RVA: 0x000A51B4 File Offset: 0x000A33B4
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightYellow.Triplet;
			}

			// Token: 0x060035B4 RID: 13748 RVA: 0x000A51BB File Offset: 0x000A33BB
			public override string GetHexString()
			{
				return "FFFF:FFFF:9999";
			}

			// Token: 0x040019F7 RID: 6647
			public const short Index = 43;

			// Token: 0x040019F8 RID: 6648
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				153
			};

			// Token: 0x040019F9 RID: 6649
			public const string HexString = "FFFF:FFFF:9999";
		}

		// Token: 0x020005ED RID: 1517
		public class LightGreen : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DE9 RID: 3561
			// (get) Token: 0x060035B7 RID: 13751 RVA: 0x000709C2 File Offset: 0x0006EBC2
			public override short Indexed
			{
				get
				{
					return 42;
				}
			}

			// Token: 0x060035B8 RID: 13752 RVA: 0x000A51DA File Offset: 0x000A33DA
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightGreen.Triplet;
			}

			// Token: 0x060035B9 RID: 13753 RVA: 0x000A51E1 File Offset: 0x000A33E1
			public override string GetHexString()
			{
				return "CCCC:FFFF:CCCC";
			}

			// Token: 0x040019FA RID: 6650
			public const short Index = 42;

			// Token: 0x040019FB RID: 6651
			public static readonly byte[] Triplet = new byte[]
			{
				204,
				byte.MaxValue,
				204
			};

			// Token: 0x040019FC RID: 6652
			public const string HexString = "CCCC:FFFF:CCCC";
		}

		// Token: 0x020005EE RID: 1518
		public class LightTurquoise : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DEA RID: 3562
			// (get) Token: 0x060035BC RID: 13756 RVA: 0x000642DC File Offset: 0x000624DC
			public override short Indexed
			{
				get
				{
					return 41;
				}
			}

			// Token: 0x060035BD RID: 13757 RVA: 0x000A5200 File Offset: 0x000A3400
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightTurquoise.Triplet;
			}

			// Token: 0x060035BE RID: 13758 RVA: 0x000A5207 File Offset: 0x000A3407
			public override string GetHexString()
			{
				return "CCCC:FFFF:FFFF";
			}

			// Token: 0x040019FD RID: 6653
			public const short Index = 41;

			// Token: 0x040019FE RID: 6654
			public const short Index2 = 27;

			// Token: 0x040019FF RID: 6655
			public static readonly byte[] Triplet = new byte[]
			{
				204,
				byte.MaxValue,
				byte.MaxValue
			};

			// Token: 0x04001A00 RID: 6656
			public const string HexString = "CCCC:FFFF:FFFF";
		}

		// Token: 0x020005EF RID: 1519
		public class PaleBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DEB RID: 3563
			// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00019462 File Offset: 0x00017662
			public override short Indexed
			{
				get
				{
					return 44;
				}
			}

			// Token: 0x060035C2 RID: 13762 RVA: 0x000A5226 File Offset: 0x000A3426
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.PaleBlue.Triplet;
			}

			// Token: 0x060035C3 RID: 13763 RVA: 0x000A522D File Offset: 0x000A342D
			public override string GetHexString()
			{
				return "9999:CCCC:FFFF";
			}

			// Token: 0x04001A01 RID: 6657
			public const short Index = 44;

			// Token: 0x04001A02 RID: 6658
			public static readonly byte[] Triplet = new byte[]
			{
				153,
				204,
				byte.MaxValue
			};

			// Token: 0x04001A03 RID: 6659
			public const string HexString = "9999:CCCC:FFFF";
		}

		// Token: 0x020005F0 RID: 1520
		public class Lavender : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DEC RID: 3564
			// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000A524C File Offset: 0x000A344C
			public override short Indexed
			{
				get
				{
					return 46;
				}
			}

			// Token: 0x060035C7 RID: 13767 RVA: 0x000A5250 File Offset: 0x000A3450
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Lavender.Triplet;
			}

			// Token: 0x060035C8 RID: 13768 RVA: 0x000A5257 File Offset: 0x000A3457
			public override string GetHexString()
			{
				return "CCCC:9999:FFFF";
			}

			// Token: 0x04001A04 RID: 6660
			public const short Index = 46;

			// Token: 0x04001A05 RID: 6661
			public static readonly byte[] Triplet = new byte[]
			{
				204,
				153,
				byte.MaxValue
			};

			// Token: 0x04001A06 RID: 6662
			public const string HexString = "CCCC:9999:FFFF";
		}

		// Token: 0x020005F1 RID: 1521
		public class White : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DED RID: 3565
			// (get) Token: 0x060035CB RID: 13771 RVA: 0x00016AA5 File Offset: 0x00014CA5
			public override short Indexed
			{
				get
				{
					return 9;
				}
			}

			// Token: 0x060035CC RID: 13772 RVA: 0x000A5276 File Offset: 0x000A3476
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.White.Triplet;
			}

			// Token: 0x060035CD RID: 13773 RVA: 0x000A527D File Offset: 0x000A347D
			public override string GetHexString()
			{
				return "FFFF:FFFF:FFFF";
			}

			// Token: 0x04001A07 RID: 6663
			public const short Index = 9;

			// Token: 0x04001A08 RID: 6664
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			};

			// Token: 0x04001A09 RID: 6665
			public const string HexString = "FFFF:FFFF:FFFF";
		}

		// Token: 0x020005F2 RID: 1522
		public class CornflowerBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DEE RID: 3566
			// (get) Token: 0x060035D0 RID: 13776 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
			public override short Indexed
			{
				get
				{
					return 24;
				}
			}

			// Token: 0x060035D1 RID: 13777 RVA: 0x000A529C File Offset: 0x000A349C
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.CornflowerBlue.Triplet;
			}

			// Token: 0x060035D2 RID: 13778 RVA: 0x000A52A3 File Offset: 0x000A34A3
			public override string GetHexString()
			{
				return "9999:9999:FFFF";
			}

			// Token: 0x04001A0A RID: 6666
			public const short Index = 24;

			// Token: 0x04001A0B RID: 6667
			public static readonly byte[] Triplet = new byte[]
			{
				153,
				153,
				byte.MaxValue
			};

			// Token: 0x04001A0C RID: 6668
			public const string HexString = "9999:9999:FFFF";
		}

		// Token: 0x020005F3 RID: 1523
		public class LemonChiffon : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DEF RID: 3567
			// (get) Token: 0x060035D5 RID: 13781 RVA: 0x00078AA8 File Offset: 0x00076CA8
			public override short Indexed
			{
				get
				{
					return 26;
				}
			}

			// Token: 0x060035D6 RID: 13782 RVA: 0x000A52C2 File Offset: 0x000A34C2
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LemonChiffon.Triplet;
			}

			// Token: 0x060035D7 RID: 13783 RVA: 0x000A52C9 File Offset: 0x000A34C9
			public override string GetHexString()
			{
				return "FFFF:FFFF:CCCC";
			}

			// Token: 0x04001A0D RID: 6669
			public const short Index = 26;

			// Token: 0x04001A0E RID: 6670
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				204
			};

			// Token: 0x04001A0F RID: 6671
			public const string HexString = "FFFF:FFFF:CCCC";
		}

		// Token: 0x020005F4 RID: 1524
		public class Maroon : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DF0 RID: 3568
			// (get) Token: 0x060035DA RID: 13786 RVA: 0x00079096 File Offset: 0x00077296
			public override short Indexed
			{
				get
				{
					return 25;
				}
			}

			// Token: 0x060035DB RID: 13787 RVA: 0x000A52E8 File Offset: 0x000A34E8
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Maroon.Triplet;
			}

			// Token: 0x060035DC RID: 13788 RVA: 0x000A52EF File Offset: 0x000A34EF
			public override string GetHexString()
			{
				return "8000:0:0";
			}

			// Token: 0x060035DE RID: 13790 RVA: 0x000A52F6 File Offset: 0x000A34F6
			// Note: this type is marked as 'beforefieldinit'.
			static Maroon()
			{
				byte[] array = new byte[3];
				array[0] = 127;
				global::NPOI.HSSF.Util.HSSFColor.Maroon.Triplet = array;
			}

			// Token: 0x04001A10 RID: 6672
			public const short Index = 25;

			// Token: 0x04001A11 RID: 6673
			public static readonly byte[] Triplet;

			// Token: 0x04001A12 RID: 6674
			public const string HexString = "8000:0:0";
		}

		// Token: 0x020005F5 RID: 1525
		public class Orchid : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DF1 RID: 3569
			// (get) Token: 0x060035DF RID: 13791 RVA: 0x0006F0EE File Offset: 0x0006D2EE
			public override short Indexed
			{
				get
				{
					return 28;
				}
			}

			// Token: 0x060035E0 RID: 13792 RVA: 0x000A5308 File Offset: 0x000A3508
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Orchid.Triplet;
			}

			// Token: 0x060035E1 RID: 13793 RVA: 0x000A530F File Offset: 0x000A350F
			public override string GetHexString()
			{
				return "6666:0:6666";
			}

			// Token: 0x04001A13 RID: 6675
			public const short Index = 28;

			// Token: 0x04001A14 RID: 6676
			public static readonly byte[] Triplet = new byte[]
			{
				102,
				0,
				102
			};

			// Token: 0x04001A15 RID: 6677
			public const string HexString = "6666:0:6666";
		}

		// Token: 0x020005F6 RID: 1526
		public class Coral : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DF2 RID: 3570
			// (get) Token: 0x060035E4 RID: 13796 RVA: 0x00074168 File Offset: 0x00072368
			public override short Indexed
			{
				get
				{
					return 29;
				}
			}

			// Token: 0x060035E5 RID: 13797 RVA: 0x000A532D File Offset: 0x000A352D
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Coral.Triplet;
			}

			// Token: 0x060035E6 RID: 13798 RVA: 0x000A5334 File Offset: 0x000A3534
			public override string GetHexString()
			{
				return "FFFF:8080:8080";
			}

			// Token: 0x04001A16 RID: 6678
			public const short Index = 29;

			// Token: 0x04001A17 RID: 6679
			public static readonly byte[] Triplet = new byte[]
			{
				byte.MaxValue,
				128,
				128
			};

			// Token: 0x04001A18 RID: 6680
			public const string HexString = "FFFF:8080:8080";
		}

		// Token: 0x020005F7 RID: 1527
		public class RoyalBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x060035E9 RID: 13801 RVA: 0x00020904 File Offset: 0x0001EB04
			public override short Indexed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x060035EA RID: 13802 RVA: 0x000A5353 File Offset: 0x000A3553
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.RoyalBlue.Triplet;
			}

			// Token: 0x060035EB RID: 13803 RVA: 0x000A535A File Offset: 0x000A355A
			public override string GetHexString()
			{
				return "0:6666:CCCC";
			}

			// Token: 0x04001A19 RID: 6681
			public const short Index = 30;

			// Token: 0x04001A1A RID: 6682
			public static readonly byte[] Triplet = new byte[]
			{
				0,
				102,
				204
			};

			// Token: 0x04001A1B RID: 6683
			public const string HexString = "0:6666:CCCC";
		}

		// Token: 0x020005F8 RID: 1528
		public class LightCornflowerBlue : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x17000DF4 RID: 3572
			// (get) Token: 0x060035EE RID: 13806 RVA: 0x000A537B File Offset: 0x000A357B
			public override short Indexed
			{
				get
				{
					return 31;
				}
			}

			// Token: 0x060035EF RID: 13807 RVA: 0x000A537F File Offset: 0x000A357F
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.LightCornflowerBlue.Triplet;
			}

			// Token: 0x060035F0 RID: 13808 RVA: 0x000A5386 File Offset: 0x000A3586
			public override string GetHexString()
			{
				return "CCCC:CCCC:FFFF";
			}

			// Token: 0x04001A1C RID: 6684
			public const short Index = 31;

			// Token: 0x04001A1D RID: 6685
			public static readonly byte[] Triplet = new byte[]
			{
				204,
				204,
				byte.MaxValue
			};

			// Token: 0x04001A1E RID: 6686
			public const string HexString = "CCCC:CCCC:FFFF";
		}

		// Token: 0x020005F9 RID: 1529
		public class Automatic : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x060035F3 RID: 13811 RVA: 0x0004C736 File Offset: 0x0004A936
			public override byte[] GetTriplet()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Black.Triplet;
			}

			// Token: 0x060035F4 RID: 13812 RVA: 0x0004C73D File Offset: 0x0004A93D
			public override string GetHexString()
			{
				return "0:0:0";
			}

			// Token: 0x060035F5 RID: 13813 RVA: 0x000A53A5 File Offset: 0x000A35A5
			public static global::NPOI.HSSF.Util.HSSFColor GetInstance()
			{
				return global::NPOI.HSSF.Util.HSSFColor.Automatic.instance;
			}

			// Token: 0x04001A1F RID: 6687
			private static global::NPOI.HSSF.Util.HSSFColor instance = new global::NPOI.HSSF.Util.HSSFColor.Automatic();

			// Token: 0x04001A20 RID: 6688
			public const short Index = 64;
		}
	}
}
