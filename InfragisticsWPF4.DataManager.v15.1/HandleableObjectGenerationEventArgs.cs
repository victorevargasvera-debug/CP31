using System;

namespace Infragistics
{
	// Token: 0x02000027 RID: 39
	public class HandleableObjectGenerationEventArgs : global::Infragistics.HandleableEventArgs
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000D225 File Offset: 0x0000B425
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000D22D File Offset: 0x0000B42D
		public object NewObject { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000D236 File Offset: 0x0000B436
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000D23E File Offset: 0x0000B43E
		public global::System.Type ObjectType { get; protected internal set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000D247 File Offset: 0x0000B447
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000D24F File Offset: 0x0000B44F
		public global::System.Type CollectionType { get; protected internal set; }
	}
}
