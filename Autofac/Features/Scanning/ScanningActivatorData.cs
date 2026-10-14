using System;
using System.Collections.Generic;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.Scanning
{
	// Token: 0x02000028 RID: 40
	public class ScanningActivatorData : global::Autofac.Builder.ReflectionActivatorData
	{
		// Token: 0x06000146 RID: 326 RVA: 0x000054AA File Offset: 0x000036AA
		public ScanningActivatorData() : base(typeof(object))
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000054DD File Offset: 0x000036DD
		public global::System.Collections.Generic.ICollection<global::System.Func<global::System.Type, bool>> Filters { get; } = new global::System.Collections.Generic.List<global::System.Func<global::System.Type, bool>>();

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000054E5 File Offset: 0x000036E5
		public global::System.Collections.Generic.ICollection<global::System.Action<global::System.Type, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>>> ConfigurationActions { get; } = new global::System.Collections.Generic.List<global::System.Action<global::System.Type, global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>>>();

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000054ED File Offset: 0x000036ED
		public global::System.Collections.Generic.ICollection<global::System.Action<global::Autofac.Core.IComponentRegistry>> PostScanningCallbacks { get; } = new global::System.Collections.Generic.List<global::System.Action<global::Autofac.Core.IComponentRegistry>>();
	}
}
