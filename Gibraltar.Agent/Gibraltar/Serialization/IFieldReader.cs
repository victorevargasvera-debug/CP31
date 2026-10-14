using System;

namespace Gibraltar.Serialization
{
	// Token: 0x020000FD RID: 253
	internal interface IFieldReader
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000A72 RID: 2674
		global::Gibraltar.Serialization.UniqueStringList Strings { get; }

		// Token: 0x06000A73 RID: 2675
		ulong PeekUInt64();

		// Token: 0x06000A74 RID: 2676
		bool ReadBool();

		// Token: 0x06000A75 RID: 2677
		bool[] ReadBoolArray();

		// Token: 0x06000A76 RID: 2678
		string ReadString();

		// Token: 0x06000A77 RID: 2679
		string[] ReadStringArray();

		// Token: 0x06000A78 RID: 2680
		int ReadInt32();

		// Token: 0x06000A79 RID: 2681
		int[] ReadInt32Array();

		// Token: 0x06000A7A RID: 2682
		long ReadInt64();

		// Token: 0x06000A7B RID: 2683
		long[] ReadInt64Array();

		// Token: 0x06000A7C RID: 2684
		uint ReadUInt32();

		// Token: 0x06000A7D RID: 2685
		uint[] ReadUInt32Array();

		// Token: 0x06000A7E RID: 2686
		ulong ReadUInt64();

		// Token: 0x06000A7F RID: 2687
		ulong[] ReadUInt64Array();

		// Token: 0x06000A80 RID: 2688
		double ReadDouble();

		// Token: 0x06000A81 RID: 2689
		double[] ReadDoubleArray();

		// Token: 0x06000A82 RID: 2690
		global::System.TimeSpan ReadTimeSpan();

		// Token: 0x06000A83 RID: 2691
		global::System.TimeSpan[] ReadTimeSpanArray();

		// Token: 0x06000A84 RID: 2692
		global::System.DateTime ReadDateTime();

		// Token: 0x06000A85 RID: 2693
		global::System.DateTime[] ReadDateTimeArray();

		// Token: 0x06000A86 RID: 2694
		global::System.DateTimeOffset ReadDateTimeOffset();

		// Token: 0x06000A87 RID: 2695
		global::System.DateTimeOffset[] ReadDateTimeOffsetArray();

		// Token: 0x06000A88 RID: 2696
		global::System.Guid ReadGuid();

		// Token: 0x06000A89 RID: 2697
		global::System.Guid[] ReadGuidArray();

		// Token: 0x06000A8A RID: 2698
		object ReadField();

		// Token: 0x06000A8B RID: 2699
		object ReadField(global::Gibraltar.Serialization.FieldType fieldType);

		// Token: 0x06000A8C RID: 2700
		object[] ReadFieldArray();
	}
}
