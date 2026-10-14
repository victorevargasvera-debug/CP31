using System;
using System.Collections;

namespace NPOI.HPSF
{
	// Token: 0x02000523 RID: 1315
	public class Variant
	{
		// Token: 0x0600317B RID: 12667 RVA: 0x00094EA0 File Offset: 0x000930A0
		static Variant()
		{
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
			hashtable[0] = "VT_EMPTY";
			hashtable[1] = "VT_NULL";
			hashtable[2] = "VT_I2";
			hashtable[3] = "VT_I4";
			hashtable[4] = "VT_R4";
			hashtable[5] = "VT_R8";
			hashtable[6] = "VT_CY";
			hashtable[7] = "VT_DATE";
			hashtable[8] = "VT_BSTR";
			hashtable[9] = "VT_DISPATCH";
			hashtable[10] = "VT_ERROR";
			hashtable[11] = "VT_BOOL";
			hashtable[12] = "VT_VARIANT";
			hashtable[13] = "VT_UNKNOWN";
			hashtable[14] = "VT_DECIMAL";
			hashtable[16] = "VT_I1";
			hashtable[17] = "VT_UI1";
			hashtable[18] = "VT_UI2";
			hashtable[19] = "VT_UI4";
			hashtable[20] = "VT_I8";
			hashtable[21] = "VT_UI8";
			hashtable[22] = "VT_INT";
			hashtable[23] = "VT_UINT";
			hashtable[24] = "VT_VOID";
			hashtable[25] = "VT_HRESULT";
			hashtable[26] = "VT_PTR";
			hashtable[27] = "VT_SAFEARRAY";
			hashtable[28] = "VT_CARRAY";
			hashtable[29] = "VT_USERDEFINED";
			hashtable[30] = "VT_LPSTR";
			hashtable[31] = "VT_LPWSTR";
			hashtable[64] = "VT_FILETIME";
			hashtable[65] = "VT_BLOB";
			hashtable[66] = "VT_STREAM";
			hashtable[67] = "VT_STORAGE";
			hashtable[68] = "VT_STREAMED_OBJECT";
			hashtable[69] = "VT_STORED_OBJECT";
			hashtable[70] = "VT_BLOB_OBJECT";
			hashtable[71] = "VT_CF";
			hashtable[72] = "VT_CLSID";
			global::NPOI.HPSF.Variant.numberToName = hashtable;
			global::System.Collections.Hashtable hashtable2 = new global::System.Collections.Hashtable();
			hashtable2[0] = 0;
			hashtable2[1] = -2;
			hashtable2[2] = 2;
			hashtable2[3] = 4;
			hashtable2[4] = 4;
			hashtable2[5] = 8;
			hashtable2[6] = -2;
			hashtable2[7] = -2;
			hashtable2[8] = -2;
			hashtable2[9] = -2;
			hashtable2[10] = -2;
			hashtable2[11] = -2;
			hashtable2[12] = -2;
			hashtable2[13] = -2;
			hashtable2[14] = -2;
			hashtable2[16] = -2;
			hashtable2[17] = -2;
			hashtable2[18] = -2;
			hashtable2[19] = -2;
			hashtable2[20] = -2;
			hashtable2[21] = -2;
			hashtable2[22] = -2;
			hashtable2[23] = -2;
			hashtable2[24] = -2;
			hashtable2[25] = -2;
			hashtable2[26] = -2;
			hashtable2[27] = -2;
			hashtable2[28] = -2;
			hashtable2[29] = -2;
			hashtable2[30] = -1;
			hashtable2[31] = -2;
			hashtable2[64] = 8;
			hashtable2[65] = -2;
			hashtable2[66] = -2;
			hashtable2[67] = -2;
			hashtable2[68] = -2;
			hashtable2[69] = -2;
			hashtable2[70] = -2;
			hashtable2[71] = -2;
			hashtable2[72] = -2;
			global::NPOI.HPSF.Variant.numberToLength = hashtable2;
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x00095498 File Offset: 0x00093698
		public static string GetVariantName(long variantType)
		{
			string text = (string)global::NPOI.HPSF.Variant.numberToName[variantType];
			if (text == null)
			{
				return "unknown variant type";
			}
			return text;
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000954C8 File Offset: 0x000936C8
		public static int GetVariantLength(long variantType)
		{
			long num = (long)((int)variantType);
			if (global::NPOI.HPSF.Variant.numberToLength.Contains(num))
			{
				return -2;
			}
			return global::System.Convert.ToInt32((long)global::NPOI.HPSF.Variant.numberToLength[num]);
		}

		// Token: 0x040015AE RID: 5550
		public const int VT_EMPTY = 0;

		// Token: 0x040015AF RID: 5551
		public const int VT_NULL = 1;

		// Token: 0x040015B0 RID: 5552
		public const int VT_I2 = 2;

		// Token: 0x040015B1 RID: 5553
		public const int VT_I4 = 3;

		// Token: 0x040015B2 RID: 5554
		public const int VT_R4 = 4;

		// Token: 0x040015B3 RID: 5555
		public const int VT_R8 = 5;

		// Token: 0x040015B4 RID: 5556
		public const int VT_CY = 6;

		// Token: 0x040015B5 RID: 5557
		public const int VT_DATE = 7;

		// Token: 0x040015B6 RID: 5558
		public const int VT_BSTR = 8;

		// Token: 0x040015B7 RID: 5559
		public const int VT_DISPATCH = 9;

		// Token: 0x040015B8 RID: 5560
		public const int VT_ERROR = 10;

		// Token: 0x040015B9 RID: 5561
		public const int VT_BOOL = 11;

		// Token: 0x040015BA RID: 5562
		public const int VT_VARIANT = 12;

		// Token: 0x040015BB RID: 5563
		public const int VT_UNKNOWN = 13;

		// Token: 0x040015BC RID: 5564
		public const int VT_DECIMAL = 14;

		// Token: 0x040015BD RID: 5565
		public const int VT_I1 = 16;

		// Token: 0x040015BE RID: 5566
		public const int VT_UI1 = 17;

		// Token: 0x040015BF RID: 5567
		public const int VT_UI2 = 18;

		// Token: 0x040015C0 RID: 5568
		public const int VT_UI4 = 19;

		// Token: 0x040015C1 RID: 5569
		public const int VT_I8 = 20;

		// Token: 0x040015C2 RID: 5570
		public const int VT_UI8 = 21;

		// Token: 0x040015C3 RID: 5571
		public const int VT_INT = 22;

		// Token: 0x040015C4 RID: 5572
		public const int VT_UINT = 23;

		// Token: 0x040015C5 RID: 5573
		public const int VT_VOID = 24;

		// Token: 0x040015C6 RID: 5574
		public const int VT_HRESULT = 25;

		// Token: 0x040015C7 RID: 5575
		public const int VT_PTR = 26;

		// Token: 0x040015C8 RID: 5576
		public const int VT_SAFEARRAY = 27;

		// Token: 0x040015C9 RID: 5577
		public const int VT_CARRAY = 28;

		// Token: 0x040015CA RID: 5578
		public const int VT_USERDEFINED = 29;

		// Token: 0x040015CB RID: 5579
		public const int VT_LPSTR = 30;

		// Token: 0x040015CC RID: 5580
		public const int VT_LPWSTR = 31;

		// Token: 0x040015CD RID: 5581
		public const int VT_FILETIME = 64;

		// Token: 0x040015CE RID: 5582
		public const int VT_BLOB = 65;

		// Token: 0x040015CF RID: 5583
		public const int VT_STREAM = 66;

		// Token: 0x040015D0 RID: 5584
		public const int VT_STORAGE = 67;

		// Token: 0x040015D1 RID: 5585
		public const int VT_STREAMED_OBJECT = 68;

		// Token: 0x040015D2 RID: 5586
		public const int VT_STORED_OBJECT = 69;

		// Token: 0x040015D3 RID: 5587
		public const int VT_BLOB_OBJECT = 70;

		// Token: 0x040015D4 RID: 5588
		public const int VT_CF = 71;

		// Token: 0x040015D5 RID: 5589
		public const int VT_CLSID = 72;

		// Token: 0x040015D6 RID: 5590
		public const int VT_VERSIONED_STREAM = 73;

		// Token: 0x040015D7 RID: 5591
		public const int VT_VECTOR = 4096;

		// Token: 0x040015D8 RID: 5592
		public const int VT_ARRAY = 8192;

		// Token: 0x040015D9 RID: 5593
		public const int VT_BYREF = 16384;

		// Token: 0x040015DA RID: 5594
		public const int VT_RESERVED = 32768;

		// Token: 0x040015DB RID: 5595
		public const int VT_ILLEGAL = 65535;

		// Token: 0x040015DC RID: 5596
		public const int VT_ILLEGALMASKED = 4095;

		// Token: 0x040015DD RID: 5597
		public const int VT_TYPEMASK = 4095;

		// Token: 0x040015DE RID: 5598
		private static global::System.Collections.IDictionary numberToName;

		// Token: 0x040015DF RID: 5599
		private static global::System.Collections.IDictionary numberToLength;

		// Token: 0x040015E0 RID: 5600
		public const int Length_UNKNOWN = -2;

		// Token: 0x040015E1 RID: 5601
		public const int Length_VARIABLE = -1;

		// Token: 0x040015E2 RID: 5602
		public const int Length_0 = 0;

		// Token: 0x040015E3 RID: 5603
		public const int Length_2 = 2;

		// Token: 0x040015E4 RID: 5604
		public const int Length_4 = 4;

		// Token: 0x040015E5 RID: 5605
		public const int Length_8 = 8;
	}
}
