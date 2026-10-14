using System;
using System.Collections.Generic;

namespace AcpCommonLib
{
	// Token: 0x02000028 RID: 40
	public interface IAcpFeatureSection : global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A1 RID: 417
		int FeatureSectionId { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		string FeatureSectionName { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		global::AcpCommonLib.IAcpFeatureNode Parent { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001A6 RID: 422
		global::AcpCommonLib.IAcpRecordset ParentRecset { get; }

		// Token: 0x060001A7 RID: 423
		void Init();

		// Token: 0x060001A8 RID: 424
		void PopulateReferences();

		// Token: 0x060001A9 RID: 425
		void DropReferences();

		// Token: 0x060001AA RID: 426
		void SetupDependencies();

		// Token: 0x060001AB RID: 427
		void SetConstraints();

		// Token: 0x1700009D RID: 157
		global::AcpCommonLib.IAcpField this[string name]
		{
			get;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001AD RID: 429
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> FieldsCollection { get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001AE RID: 430
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> FieldsCollectionByOrder { get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001AF RID: 431
		bool HasEmbeddedRecset { get; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001B0 RID: 432
		// (set) Token: 0x060001B1 RID: 433
		global::AcpCommonLib.IAcpRecordset EmbeddedRecset { get; set; }

		// Token: 0x060001B2 RID: 434
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token);

		// Token: 0x060001B3 RID: 435
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token);

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001B4 RID: 436
		// (set) Token: 0x060001B5 RID: 437
		string UIName { get; set; }

		// Token: 0x060001B6 RID: 438
		string Path(string delimiter);

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001B7 RID: 439
		global::AcpCommonLib.IAcpField CurrentField { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001B8 RID: 440
		bool _HasDiffs { get; }

		// Token: 0x060001B9 RID: 441
		void ClearHasDiffs();

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001BA RID: 442
		bool HasVisibleObjects { get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001BB RID: 443
		// (set) Token: 0x060001BC RID: 444
		int DataTransferOrder { get; set; }
	}
}
