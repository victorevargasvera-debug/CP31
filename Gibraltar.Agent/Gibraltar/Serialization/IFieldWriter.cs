using System;

namespace Gibraltar.Serialization
{
	// Token: 0x020000FE RID: 254
	internal interface IFieldWriter
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000A8D RID: 2701
		long Position { get; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000A8E RID: 2702
		long Length { get; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000A8F RID: 2703
		global::Gibraltar.Serialization.UniqueStringList Strings { get; }

		// Token: 0x06000A90 RID: 2704
		void Commit();

		// Token: 0x06000A91 RID: 2705
		void Rollback();

		// Token: 0x06000A92 RID: 2706
		void Write(object value);

		// Token: 0x06000A93 RID: 2707
		void Write(object value, global::Gibraltar.Serialization.FieldType fieldType);

		// Token: 0x06000A94 RID: 2708
		void Write(bool value);

		// Token: 0x06000A95 RID: 2709
		void Write(bool[] array);

		// Token: 0x06000A96 RID: 2710
		void Write(string value);

		// Token: 0x06000A97 RID: 2711
		void Write(string[] array);

		// Token: 0x06000A98 RID: 2712
		void Write(int value);

		// Token: 0x06000A99 RID: 2713
		void Write(int[] array);

		// Token: 0x06000A9A RID: 2714
		void Write(long value);

		// Token: 0x06000A9B RID: 2715
		void Write(long[] array);

		// Token: 0x06000A9C RID: 2716
		void Write(uint value);

		// Token: 0x06000A9D RID: 2717
		void Write(uint[] array);

		// Token: 0x06000A9E RID: 2718
		void Write(ulong value);

		// Token: 0x06000A9F RID: 2719
		void Write(ulong[] array);

		// Token: 0x06000AA0 RID: 2720
		void Write(double value);

		// Token: 0x06000AA1 RID: 2721
		void Write(double[] array);

		// Token: 0x06000AA2 RID: 2722
		void Write(global::System.TimeSpan value);

		// Token: 0x06000AA3 RID: 2723
		void Write(global::System.TimeSpan[] array);

		// Token: 0x06000AA4 RID: 2724
		void Write(global::System.DateTime value);

		// Token: 0x06000AA5 RID: 2725
		void Write(global::System.DateTime[] array);

		// Token: 0x06000AA6 RID: 2726
		void Write(global::System.DateTimeOffset value);

		// Token: 0x06000AA7 RID: 2727
		void Write(global::System.DateTimeOffset[] array);

		// Token: 0x06000AA8 RID: 2728
		void Write(global::System.Guid value);

		// Token: 0x06000AA9 RID: 2729
		void Write(global::System.Guid[] array);

		// Token: 0x06000AAA RID: 2730
		byte[] ToArray();
	}
}
