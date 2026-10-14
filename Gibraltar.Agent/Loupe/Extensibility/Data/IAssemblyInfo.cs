using System;
using System.Reflection;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000060 RID: 96
	internal interface IAssemblyInfo : global::System.IComparable<global::Loupe.Extensibility.Data.IAssemblyInfo>, global::System.IEquatable<global::Loupe.Extensibility.Data.IAssemblyInfo>
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004EC RID: 1260
		global::Loupe.Extensibility.Data.ISession Session { get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004ED RID: 1261
		string Caption { get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004EE RID: 1262
		string Description { get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060004EF RID: 1263
		global::System.Guid Id { get; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004F0 RID: 1264
		string CultureName { get; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004F1 RID: 1265
		string FullName { get; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004F2 RID: 1266
		string ImageRuntimeVersion { get; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004F3 RID: 1267
		string Location { get; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004F4 RID: 1268
		string Name { get; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004F5 RID: 1269
		global::System.Reflection.ProcessorArchitecture ProcessorArchitecture { get; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004F6 RID: 1270
		bool GlobalAssemblyCache { get; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004F7 RID: 1271
		string Version { get; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004F8 RID: 1272
		string FileVersion { get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004F9 RID: 1273
		global::System.DateTimeOffset LoadedTimeStamp { get; }
	}
}
