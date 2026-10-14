using System;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200004F RID: 79
	public class AddMultipleCurrRecordsContainerTask : global::AcpBusinessLayer.UndoRedo.AddRecordContainerTask
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0006951C File Offset: 0x0006771C
		internal AddMultipleCurrRecordsContainerTask(global::AcpBusinessLayer.FeatureNode[] records)
		{
			int a_ = 6;
			base..ctor("");
			base.Description = string.Concat(new string[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("駗뻙룛ﻝ", a_),
				records.Length.ToString(),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("맙돛껝觟蟡韣웥蟧賩쳫", a_),
				records[0].FeatureName,
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("꣙맛뷝迟郡胣", a_)
			});
			base.Records = records;
			global::AcpBusinessLayer.AddMultipleRecordsTask task = new global::AcpBusinessLayer.AddMultipleRecordsTask(records, true);
			base.AddTask(task);
			foreach (global::AcpBusinessLayer.FeatureNode record in records)
			{
				base.PopulateRecRefFieldTasks(record);
			}
		}
	}
}
