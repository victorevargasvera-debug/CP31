using System;
using System.Collections.Generic;

namespace AcpCommonLib
{
	// Token: 0x02000026 RID: 38
	public interface IAcpFeatureNode : global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000176 RID: 374
		// (set) Token: 0x06000177 RID: 375
		global::AcpCommonLib.IAcpRecordset Parent { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000178 RID: 376
		// (set) Token: 0x06000179 RID: 377
		string FeatureName { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600017A RID: 378
		string ReferenceKey { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600017B RID: 379
		int NodeId { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600017C RID: 380
		string UIPagePath { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017D RID: 381
		// (set) Token: 0x0600017E RID: 382
		string TreeNodeLabel { get; set; }

		// Token: 0x0600017F RID: 383
		void PopulateReferences();

		// Token: 0x06000180 RID: 384
		void DropReferences();

		// Token: 0x17000088 RID: 136
		global::AcpCommonLib.IAcpFeatureSection this[int id]
		{
			get;
		}

		// Token: 0x06000182 RID: 386
		void AddFeatureSection(global::AcpCommonLib.IAcpFeatureSection section);

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000183 RID: 387
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> FeatureSectionsCollection { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000184 RID: 388
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> FeatureSectionsCollectionByOrder { get; }

		// Token: 0x06000185 RID: 389
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token);

		// Token: 0x06000186 RID: 390
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token);

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000187 RID: 391
		// (set) Token: 0x06000188 RID: 392
		string UIName { get; set; }

		// Token: 0x06000189 RID: 393
		string Path(string delimiter);

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600018A RID: 394
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> EmbeddedRecordsets { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600018B RID: 395
		bool Deleted { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600018C RID: 396
		bool _HasDiffs { get; }

		// Token: 0x0600018D RID: 397
		void ClearHasDiffs();

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600018E RID: 398
		bool HasVisibleObjects { get; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600018F RID: 399
		// (set) Token: 0x06000190 RID: 400
		global::AcpCommonLib.Permissions Permissions { get; set; }
	}
}
