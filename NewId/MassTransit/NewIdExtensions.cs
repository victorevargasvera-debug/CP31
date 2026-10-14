using System;

namespace MassTransit
{
	// Token: 0x0200000B RID: 11
	public static class NewIdExtensions
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public static global::MassTransit.NewId ToNewId(this global::System.Guid guid)
		{
			byte[] array = guid.ToByteArray();
			return new global::MassTransit.NewId(ref array);
		}
	}
}
