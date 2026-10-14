using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041F RID: 1055
	public class SSTDeserializer
	{
		// Token: 0x060026B9 RID: 9913 RVA: 0x000744B4 File Offset: 0x000726B4
		public SSTDeserializer(global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings)
		{
			this.strings = strings;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000744C4 File Offset: 0x000726C4
		public void ManufactureStrings(int stringCount, global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			for (int i = 0; i < stringCount; i++)
			{
				global::NPOI.HSSF.Record.UnicodeString str;
				if (in1.Available() == 0 && !in1.HasNextRecord)
				{
					global::System.Console.WriteLine("Ran out of data before creating all the strings! String at index " + i.ToString());
					str = new global::NPOI.HSSF.Record.UnicodeString("");
				}
				else
				{
					str = new global::NPOI.HSSF.Record.UnicodeString(in1);
				}
				global::NPOI.HSSF.Record.SSTDeserializer.AddToStringTable(this.strings, str);
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00074523 File Offset: 0x00072723
		public static void AddToStringTable(global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings, global::NPOI.HSSF.Record.UnicodeString str)
		{
			strings.Add(str);
		}

		// Token: 0x0400102D RID: 4141
		private global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> strings;
	}
}
