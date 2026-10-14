using System;
using System.Collections.Generic;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000C9 RID: 201
	public class SingleRegistrationStyle
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0000D821 File Offset: 0x0000BA21
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0000D829 File Offset: 0x0000BA29
		public global::System.Guid Id { get; set; } = global::System.Guid.NewGuid();

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000D832 File Offset: 0x0000BA32
		public global::System.Collections.Generic.ICollection<global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs>> RegisteredHandlers { get; } = new global::System.Collections.Generic.List<global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs>>();

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000D83A File Offset: 0x0000BA3A
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0000D842 File Offset: 0x0000BA42
		public bool PreserveDefaults { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000D84B File Offset: 0x0000BA4B
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0000D853 File Offset: 0x0000BA53
		public global::Autofac.Core.IComponentRegistration Target { get; set; }
	}
}
