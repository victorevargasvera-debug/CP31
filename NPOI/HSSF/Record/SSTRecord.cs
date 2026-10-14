using System;
using System.Collections;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000420 RID: 1056
	public class SSTRecord : global::NPOI.HSSF.Record.Cont.ContinuableRecord
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x0007452D File Offset: 0x0007272D
		public SSTRecord()
		{
			this.field_1_num_strings = 0;
			this.field_2_num_unique_strings = 0;
			this.field_3_strings = new global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString>();
			this.deserializer = new global::NPOI.HSSF.Record.SSTDeserializer(this.field_3_strings);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00074560 File Offset: 0x00072760
		public SSTRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_num_strings = in1.ReadInt();
			this.field_2_num_unique_strings = in1.ReadInt();
			this.field_3_strings = new global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString>();
			this.deserializer = new global::NPOI.HSSF.Record.SSTDeserializer(this.field_3_strings);
			this.deserializer.ManufactureStrings(this.field_2_num_unique_strings, in1);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000745BC File Offset: 0x000727BC
		public int AddString(global::NPOI.HSSF.Record.UnicodeString str)
		{
			this.field_1_num_strings++;
			global::NPOI.HSSF.Record.UnicodeString unicodeString = (str == null) ? global::NPOI.HSSF.Record.SSTRecord.EMPTY_STRING : str;
			int index = this.field_3_strings.GetIndex(unicodeString);
			int result;
			if (index != -1)
			{
				result = index;
			}
			else
			{
				result = this.field_3_strings.Size;
				this.field_2_num_unique_strings++;
				global::NPOI.HSSF.Record.SSTDeserializer.AddToStringTable(this.field_3_strings, unicodeString);
			}
			return result;
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x0007461F File Offset: 0x0007281F
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x00074627 File Offset: 0x00072827
		public int NumStrings
		{
			get
			{
				return this.field_1_num_strings;
			}
			set
			{
				this.field_1_num_strings = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x00074630 File Offset: 0x00072830
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x00074638 File Offset: 0x00072838
		public int NumUniqueStrings
		{
			get
			{
				return this.field_2_num_unique_strings;
			}
			set
			{
				this.field_2_num_unique_strings = value;
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00074641 File Offset: 0x00072841
		public global::NPOI.HSSF.Record.UnicodeString GetString(int id)
		{
			return this.field_3_strings[id];
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0007464F File Offset: 0x0007284F
		public bool IsString16bit(int id)
		{
			return (this.field_3_strings[id].OptionFlags & 1) == 1;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00074668 File Offset: 0x00072868
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SST]\n");
			stringBuilder.Append("    .numstrings     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.NumStrings)).Append("\n");
			stringBuilder.Append("    .uniquestrings  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.NumUniqueStrings)).Append("\n");
			for (int i = 0; i < this.field_3_strings.Size; i++)
			{
				global::NPOI.HSSF.Record.UnicodeString unicodeString = this.field_3_strings[i];
				stringBuilder.Append("    .string_" + i.ToString() + "      = ").Append(unicodeString.GetDebugInfo()).Append("\n");
			}
			stringBuilder.Append("[/SST]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0007473A File Offset: 0x0007293A
		public override short Sid
		{
			get
			{
				return 252;
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00074630 File Offset: 0x00072830
		public override int GetHashCode()
		{
			return this.field_2_num_unique_strings;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00074744 File Offset: 0x00072944
		public override bool Equals(object o)
		{
			if (o == null || o.GetType() != base.GetType())
			{
				return false;
			}
			global::NPOI.HSSF.Record.SSTRecord sstrecord = (global::NPOI.HSSF.Record.SSTRecord)o;
			return this.field_1_num_strings == sstrecord.field_1_num_strings && this.field_2_num_unique_strings == sstrecord.field_2_num_unique_strings && this.field_3_strings.Equals(sstrecord.field_3_strings);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0007479F File Offset: 0x0007299F
		public global::System.Collections.IEnumerator GetStrings()
		{
			return this.field_3_strings.GetEnumerator();
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000747AC File Offset: 0x000729AC
		public int CountStrings
		{
			get
			{
				return this.field_3_strings.Size;
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000747BC File Offset: 0x000729BC
		protected override void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			global::NPOI.HSSF.Record.SSTSerializer sstserializer = new global::NPOI.HSSF.Record.SSTSerializer(this.field_3_strings, this.NumStrings, this.NumUniqueStrings);
			sstserializer.Serialize(out1);
			this.bucketAbsoluteOffsets = sstserializer.BucketAbsoluteOffsets;
			this.bucketRelativeOffsets = sstserializer.BucketRelativeOffsets;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00074800 File Offset: 0x00072A00
		private global::NPOI.HSSF.Record.SSTDeserializer GetDeserializer()
		{
			return this.deserializer;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00074808 File Offset: 0x00072A08
		public global::NPOI.HSSF.Record.ExtSSTRecord CreateExtSSTRecord(int sstOffset)
		{
			if (this.bucketAbsoluteOffsets == null || this.bucketRelativeOffsets == null)
			{
				throw new global::System.InvalidOperationException("SST record has not yet been Serialized.");
			}
			global::NPOI.HSSF.Record.ExtSSTRecord extSSTRecord = new global::NPOI.HSSF.Record.ExtSSTRecord();
			extSSTRecord.NumStringsPerBucket = 8;
			int[] array = (int[])this.bucketAbsoluteOffsets.Clone();
			int[] array2 = (int[])this.bucketRelativeOffsets.Clone();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] += sstOffset;
			}
			extSSTRecord.SetBucketOffsets(array, array2);
			return extSSTRecord;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00074882 File Offset: 0x00072A82
		public int CalcExtSSTRecordSize()
		{
			return global::NPOI.HSSF.Record.ExtSSTRecord.GetRecordSizeForStrings(this.field_3_strings.Size);
		}

		// Token: 0x0400102E RID: 4142
		public const short sid = 252;

		// Token: 0x0400102F RID: 4143
		private static readonly global::NPOI.HSSF.Record.UnicodeString EMPTY_STRING = new global::NPOI.HSSF.Record.UnicodeString("");

		// Token: 0x04001030 RID: 4144
		public const int MAX_RECORD_SIZE = 8228;

		// Token: 0x04001031 RID: 4145
		public const int STD_RECORD_OVERHEAD = 4;

		// Token: 0x04001032 RID: 4146
		public const int SST_RECORD_OVERHEAD = 12;

		// Token: 0x04001033 RID: 4147
		public const int MAX_DATA_SPACE = 8216;

		// Token: 0x04001034 RID: 4148
		private int field_1_num_strings;

		// Token: 0x04001035 RID: 4149
		private int field_2_num_unique_strings;

		// Token: 0x04001036 RID: 4150
		private global::NPOI.Util.IntMapper<global::NPOI.HSSF.Record.UnicodeString> field_3_strings;

		// Token: 0x04001037 RID: 4151
		private global::NPOI.HSSF.Record.SSTDeserializer deserializer;

		// Token: 0x04001038 RID: 4152
		private int[] bucketAbsoluteOffsets;

		// Token: 0x04001039 RID: 4153
		private int[] bucketRelativeOffsets;
	}
}
