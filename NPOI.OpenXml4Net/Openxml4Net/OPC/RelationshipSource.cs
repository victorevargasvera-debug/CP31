using System;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200001B RID: 27
	internal interface RelationshipSource
	{
		// Token: 0x06000138 RID: 312
		global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType);

		// Token: 0x06000139 RID: 313
		global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string id);

		// Token: 0x0600013A RID: 314
		global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType);

		// Token: 0x0600013B RID: 315
		global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType, string id);

		// Token: 0x0600013C RID: 316
		void ClearRelationships();

		// Token: 0x0600013D RID: 317
		void RemoveRelationship(string id);

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013E RID: 318
		global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection Relationships { get; }

		// Token: 0x0600013F RID: 319
		global::NPOI.OpenXml4Net.OPC.PackageRelationship GetRelationship(string id);

		// Token: 0x06000140 RID: 320
		global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationshipsByType(string relationshipType);

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000141 RID: 321
		bool HasRelationships { get; }

		// Token: 0x06000142 RID: 322
		bool IsRelationshipExists(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel);
	}
}
