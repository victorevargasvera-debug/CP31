using System;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200004B RID: 75
	public class AddCurrentRecordContainerTask : global::AcpBusinessLayer.UndoRedo.AddRecordContainerTask
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00067D44 File Offset: 0x00065F44
		internal AddCurrentRecordContainerTask(global::AcpBusinessLayer.FeatureNode record)
		{
			int a_ = 4;
			base..ctor("");
			base.Description = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韕볗뻙ﳛ鷝迟鋡鷣웥꟧賩쳫", a_) + record.FeatureName;
			base.Records = new global::AcpBusinessLayer.FeatureNode[]
			{
				record
			};
			global::AcpBusinessLayer.UndoRedo.AddRecordTask task = new global::AcpBusinessLayer.UndoRedo.AddRecordTask(record, true);
			base.AddTask(task);
			base.PopulateRecRefFieldTasks(record);
		}
	}
}
