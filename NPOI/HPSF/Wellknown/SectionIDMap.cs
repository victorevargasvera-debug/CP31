using System;
using System.Collections;
using System.Text;

namespace NPOI.HPSF.Wellknown
{
	// Token: 0x02000528 RID: 1320
	public class SectionIDMap : global::System.Collections.Hashtable
	{
		// Token: 0x06003193 RID: 12691 RVA: 0x00095CD5 File Offset: 0x00093ED5
		public static global::NPOI.HPSF.Wellknown.SectionIDMap GetInstance()
		{
			if (global::NPOI.HPSF.Wellknown.SectionIDMap.defaultMap == null)
			{
				global::NPOI.HPSF.Wellknown.SectionIDMap sectionIDMap = new global::NPOI.HPSF.Wellknown.SectionIDMap();
				sectionIDMap.Put(global::NPOI.HPSF.Wellknown.SectionIDMap.SUMMARY_INFORMATION_ID, global::NPOI.HPSF.Wellknown.PropertyIDMap.SummaryInformationProperties);
				sectionIDMap.Put(global::NPOI.HPSF.Wellknown.SectionIDMap.DOCUMENT_SUMMARY_INFORMATION_ID1, global::NPOI.HPSF.Wellknown.PropertyIDMap.DocumentSummaryInformationProperties);
				global::NPOI.HPSF.Wellknown.SectionIDMap.defaultMap = sectionIDMap;
			}
			return global::NPOI.HPSF.Wellknown.SectionIDMap.defaultMap;
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00095D10 File Offset: 0x00093F10
		public static string GetPIDString(byte[] sectionFormatID, long pid)
		{
			global::NPOI.HPSF.Wellknown.PropertyIDMap propertyIDMap = global::NPOI.HPSF.Wellknown.SectionIDMap.GetInstance().Get(sectionFormatID);
			if (propertyIDMap == null)
			{
				return "[undefined]";
			}
			string text = (string)propertyIDMap.Get(pid);
			if (text == null)
			{
				return "[undefined]";
			}
			return text;
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00095D49 File Offset: 0x00093F49
		public global::NPOI.HPSF.Wellknown.PropertyIDMap Get(byte[] sectionFormatID)
		{
			return (global::NPOI.HPSF.Wellknown.PropertyIDMap)this[global::System.Text.Encoding.UTF8.GetString(sectionFormatID)];
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00095D64 File Offset: 0x00093F64
		public object Put(byte[] sectionFormatID, global::NPOI.HPSF.Wellknown.PropertyIDMap propertyIDMap)
		{
			this[sectionFormatID] = propertyIDMap;
			return propertyIDMap;
		}

		// Token: 0x04001619 RID: 5657
		public static readonly byte[] SUMMARY_INFORMATION_ID = new byte[]
		{
			242,
			159,
			133,
			224,
			79,
			249,
			16,
			104,
			171,
			145,
			8,
			0,
			43,
			39,
			179,
			217
		};

		// Token: 0x0400161A RID: 5658
		public static readonly byte[] DOCUMENT_SUMMARY_INFORMATION_ID1 = new byte[]
		{
			213,
			205,
			213,
			2,
			46,
			156,
			16,
			27,
			147,
			151,
			8,
			0,
			43,
			44,
			249,
			174
		};

		// Token: 0x0400161B RID: 5659
		public static readonly byte[] DOCUMENT_SUMMARY_INFORMATION_ID2 = new byte[]
		{
			213,
			205,
			213,
			5,
			46,
			156,
			16,
			27,
			147,
			151,
			8,
			0,
			43,
			44,
			249,
			174
		};

		// Token: 0x0400161C RID: 5660
		public const string UNDEFINED = "[undefined]";

		// Token: 0x0400161D RID: 5661
		private static global::NPOI.HPSF.Wellknown.SectionIDMap defaultMap;
	}
}
