using System;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E4 RID: 484
	public interface IDBNodeVisitor
	{
		// Token: 0x06001811 RID: 6161
		void VisitRecord_Begin(global::Motorola.CommonCPS.Server.EntityModel.Record record);

		// Token: 0x06001812 RID: 6162
		void VisitRefSet_Begin(global::Motorola.CommonCPS.Server.EntityModel.RefSet refSet);

		// Token: 0x06001813 RID: 6163
		void VisitRefSet_End(global::Motorola.CommonCPS.Server.EntityModel.RefSet refSet);

		// Token: 0x06001814 RID: 6164
		void VisitRecord_End(global::Motorola.CommonCPS.Server.EntityModel.Record record);
	}
}
