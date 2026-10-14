using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000066 RID: 102
	internal interface IEventMetricValueDefinition : global::System.IEquatable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000506 RID: 1286
		global::Loupe.Extensibility.Data.EventMetricValueTrend DefaultTrend { get; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000507 RID: 1287
		global::Loupe.Extensibility.Data.IEventMetricDefinition Definition { get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000508 RID: 1288
		string Name { get; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000509 RID: 1289
		string Caption { get; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600050A RID: 1290
		string Description { get; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600050B RID: 1291
		global::System.Type Type { get; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600050C RID: 1292
		bool IsTrendable { get; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600050D RID: 1293
		string UnitCaption { get; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600050E RID: 1294
		int Index { get; }
	}
}
