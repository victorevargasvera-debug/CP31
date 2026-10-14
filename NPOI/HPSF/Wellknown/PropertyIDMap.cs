using System;
using System.Collections;

namespace NPOI.HPSF.Wellknown
{
	// Token: 0x02000527 RID: 1319
	public class PropertyIDMap : global::System.Collections.Hashtable
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x00095A02 File Offset: 0x00093C02
		public PropertyIDMap(int initialCapacity, float loadFactor) : base(initialCapacity, loadFactor)
		{
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00095A0C File Offset: 0x00093C0C
		public PropertyIDMap(global::System.Collections.IDictionary map) : base(map)
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00095A18 File Offset: 0x00093C18
		public object Put(long id, string idString)
		{
			this[id] = idString;
			return idString;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00095A35 File Offset: 0x00093C35
		public object Get(long id)
		{
			return this[id];
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x00095A44 File Offset: 0x00093C44
		public static global::NPOI.HPSF.Wellknown.PropertyIDMap SummaryInformationProperties
		{
			get
			{
				if (global::NPOI.HPSF.Wellknown.PropertyIDMap.summaryInformationProperties == null)
				{
					global::NPOI.HPSF.Wellknown.PropertyIDMap propertyIDMap = new global::NPOI.HPSF.Wellknown.PropertyIDMap(18, 1f);
					propertyIDMap.Put(2L, "PID_TITLE");
					propertyIDMap.Put(3L, "PID_SUBJECT");
					propertyIDMap.Put(4L, "PID_AUTHOR");
					propertyIDMap.Put(5L, "PID_KEYWORDS");
					propertyIDMap.Put(6L, "PID_COMMENTS");
					propertyIDMap.Put(7L, "PID_TEMPLATE");
					propertyIDMap.Put(8L, "PID_LASTAUTHOR");
					propertyIDMap.Put(9L, "PID_REVNUMBER");
					propertyIDMap.Put(10L, "PID_EDITTIME");
					propertyIDMap.Put(11L, "PID_LASTPRINTED");
					propertyIDMap.Put(12L, "PID_Create_DTM");
					propertyIDMap.Put(13L, "PID_LASTSAVE_DTM");
					propertyIDMap.Put(14L, "PID_PAGECOUNT");
					propertyIDMap.Put(15L, "PID_WORDCOUNT");
					propertyIDMap.Put(16L, "PID_CHARCOUNT");
					propertyIDMap.Put(17L, "PID_THUMBNAIL");
					propertyIDMap.Put(18L, "PID_APPNAME");
					propertyIDMap.Put(19L, "PID_SECURITY");
					global::NPOI.HPSF.Wellknown.PropertyIDMap.summaryInformationProperties = propertyIDMap;
				}
				return global::NPOI.HPSF.Wellknown.PropertyIDMap.summaryInformationProperties;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x00095B78 File Offset: 0x00093D78
		public static global::NPOI.HPSF.Wellknown.PropertyIDMap DocumentSummaryInformationProperties
		{
			get
			{
				if (global::NPOI.HPSF.Wellknown.PropertyIDMap.documentSummaryInformationProperties == null)
				{
					global::NPOI.HPSF.Wellknown.PropertyIDMap propertyIDMap = new global::NPOI.HPSF.Wellknown.PropertyIDMap(17, 1f);
					propertyIDMap.Put(0L, "PID_DICTIONARY");
					propertyIDMap.Put(1L, "PID_CODEPAGE");
					propertyIDMap.Put(2L, "PID_CATEGORY");
					propertyIDMap.Put(3L, "PID_PRESFORMAT");
					propertyIDMap.Put(4L, "PID_BYTECOUNT");
					propertyIDMap.Put(5L, "PID_LINECOUNT");
					propertyIDMap.Put(6L, "PID_PARCOUNT");
					propertyIDMap.Put(7L, "PID_SLIDECOUNT");
					propertyIDMap.Put(8L, "PID_NOTECOUNT");
					propertyIDMap.Put(9L, "PID_HIDDENCOUNT");
					propertyIDMap.Put(10L, "PID_MMCLIPCOUNT");
					propertyIDMap.Put(11L, "PID_SCALE");
					propertyIDMap.Put(12L, "PID_HEADINGPAIR");
					propertyIDMap.Put(13L, "PID_DOCPARTS");
					propertyIDMap.Put(14L, "PID_MANAGER");
					propertyIDMap.Put(15L, "PID_COMPANY");
					propertyIDMap.Put(16L, "PID_LINKSDIRTY");
					global::NPOI.HPSF.Wellknown.PropertyIDMap.documentSummaryInformationProperties = propertyIDMap;
				}
				return global::NPOI.HPSF.Wellknown.PropertyIDMap.documentSummaryInformationProperties;
			}
		}

		// Token: 0x040015EB RID: 5611
		public const int PID_TITLE = 2;

		// Token: 0x040015EC RID: 5612
		public const int PID_SUBJECT = 3;

		// Token: 0x040015ED RID: 5613
		public const int PID_AUTHOR = 4;

		// Token: 0x040015EE RID: 5614
		public const int PID_KEYWORDS = 5;

		// Token: 0x040015EF RID: 5615
		public const int PID_COMMENTS = 6;

		// Token: 0x040015F0 RID: 5616
		public const int PID_TEMPLATE = 7;

		// Token: 0x040015F1 RID: 5617
		public const int PID_LASTAUTHOR = 8;

		// Token: 0x040015F2 RID: 5618
		public const int PID_REVNUMBER = 9;

		// Token: 0x040015F3 RID: 5619
		public const int PID_EDITTIME = 10;

		// Token: 0x040015F4 RID: 5620
		public const int PID_LASTPRINTED = 11;

		// Token: 0x040015F5 RID: 5621
		public const int PID_Create_DTM = 12;

		// Token: 0x040015F6 RID: 5622
		public const int PID_LASTSAVE_DTM = 13;

		// Token: 0x040015F7 RID: 5623
		public const int PID_PAGECOUNT = 14;

		// Token: 0x040015F8 RID: 5624
		public const int PID_WORDCOUNT = 15;

		// Token: 0x040015F9 RID: 5625
		public const int PID_CHARCOUNT = 16;

		// Token: 0x040015FA RID: 5626
		public const int PID_THUMBNAIL = 17;

		// Token: 0x040015FB RID: 5627
		public const int PID_APPNAME = 18;

		// Token: 0x040015FC RID: 5628
		public const int PID_SECURITY = 19;

		// Token: 0x040015FD RID: 5629
		public const int PID_DICTIONARY = 0;

		// Token: 0x040015FE RID: 5630
		public const int PID_CODEPAGE = 1;

		// Token: 0x040015FF RID: 5631
		public const int PID_CATEGORY = 2;

		// Token: 0x04001600 RID: 5632
		public const int PID_PRESFORMAT = 3;

		// Token: 0x04001601 RID: 5633
		public const int PID_BYTECOUNT = 4;

		// Token: 0x04001602 RID: 5634
		public const int PID_LINECOUNT = 5;

		// Token: 0x04001603 RID: 5635
		public const int PID_PARCOUNT = 6;

		// Token: 0x04001604 RID: 5636
		public const int PID_SLIDECOUNT = 7;

		// Token: 0x04001605 RID: 5637
		public const int PID_NOTECOUNT = 8;

		// Token: 0x04001606 RID: 5638
		public const int PID_HIDDENCOUNT = 9;

		// Token: 0x04001607 RID: 5639
		public const int PID_MMCLIPCOUNT = 10;

		// Token: 0x04001608 RID: 5640
		public const int PID_SCALE = 11;

		// Token: 0x04001609 RID: 5641
		public const int PID_HEADINGPAIR = 12;

		// Token: 0x0400160A RID: 5642
		public const int PID_DOCPARTS = 13;

		// Token: 0x0400160B RID: 5643
		public const int PID_MANAGER = 14;

		// Token: 0x0400160C RID: 5644
		public const int PID_COMPANY = 15;

		// Token: 0x0400160D RID: 5645
		public const int PID_LINKSDIRTY = 16;

		// Token: 0x0400160E RID: 5646
		public static int PID_CCHWITHSPACES = 17;

		// Token: 0x0400160F RID: 5647
		public static int PID_HYPERLINKSCHANGED = 22;

		// Token: 0x04001610 RID: 5648
		public static int PID_VERSION = 23;

		// Token: 0x04001611 RID: 5649
		public static int PID_DIGSIG = 24;

		// Token: 0x04001612 RID: 5650
		public static int PID_CONTENTTYPE = 26;

		// Token: 0x04001613 RID: 5651
		public static int PID_CONTENTSTATUS = 27;

		// Token: 0x04001614 RID: 5652
		public static int PID_LANGUAGE = 28;

		// Token: 0x04001615 RID: 5653
		public static int PID_DOCVERSION = 29;

		// Token: 0x04001616 RID: 5654
		public const int PID_MAX = 31;

		// Token: 0x04001617 RID: 5655
		private static global::NPOI.HPSF.Wellknown.PropertyIDMap summaryInformationProperties;

		// Token: 0x04001618 RID: 5656
		private static global::NPOI.HPSF.Wellknown.PropertyIDMap documentSummaryInformationProperties;
	}
}
