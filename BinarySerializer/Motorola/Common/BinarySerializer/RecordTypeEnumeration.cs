using System;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x0200000B RID: 11
	public enum RecordTypeEnumeration
	{
		// Token: 0x04000012 RID: 18
		SerializedStreamHeader,
		// Token: 0x04000013 RID: 19
		ClassWithId,
		// Token: 0x04000014 RID: 20
		SystemClassWithMembers,
		// Token: 0x04000015 RID: 21
		ClassWithMembers,
		// Token: 0x04000016 RID: 22
		SystemClassWithMembersAndTypes,
		// Token: 0x04000017 RID: 23
		ClassWithMembersAndTypes,
		// Token: 0x04000018 RID: 24
		BinaryObjectString,
		// Token: 0x04000019 RID: 25
		BinaryArray,
		// Token: 0x0400001A RID: 26
		MemberPrimitiveTyped,
		// Token: 0x0400001B RID: 27
		MemberReference,
		// Token: 0x0400001C RID: 28
		ObjectNull,
		// Token: 0x0400001D RID: 29
		MessageEnd,
		// Token: 0x0400001E RID: 30
		BinaryLibrary,
		// Token: 0x0400001F RID: 31
		ObjectNullMultiple256,
		// Token: 0x04000020 RID: 32
		ObjectNullMultiple,
		// Token: 0x04000021 RID: 33
		ArraySinglePrimitive,
		// Token: 0x04000022 RID: 34
		ArraySingleObject,
		// Token: 0x04000023 RID: 35
		ArraySingleString,
		// Token: 0x04000024 RID: 36
		MethodCall = 21,
		// Token: 0x04000025 RID: 37
		MethodReturn
	}
}
