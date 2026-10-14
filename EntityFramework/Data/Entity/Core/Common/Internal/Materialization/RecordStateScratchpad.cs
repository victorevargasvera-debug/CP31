using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063E RID: 1598
	internal class RecordStateScratchpad
	{
		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x0010ECA9 File Offset: 0x0010CEA9
		// (set) Token: 0x06004CF2 RID: 19698 RVA: 0x0010ECB1 File Offset: 0x0010CEB1
		internal int StateSlotNumber { get; set; }

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x0010ECBA File Offset: 0x0010CEBA
		// (set) Token: 0x06004CF4 RID: 19700 RVA: 0x0010ECC2 File Offset: 0x0010CEC2
		internal int ColumnCount { get; set; }

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x0010ECCB File Offset: 0x0010CECB
		// (set) Token: 0x06004CF6 RID: 19702 RVA: 0x0010ECD3 File Offset: 0x0010CED3
		internal global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo { get; set; }

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x0010ECDC File Offset: 0x0010CEDC
		// (set) Token: 0x06004CF8 RID: 19704 RVA: 0x0010ECE4 File Offset: 0x0010CEE4
		internal global::System.Linq.Expressions.Expression GatherData { get; set; }

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x0010ECED File Offset: 0x0010CEED
		// (set) Token: 0x06004CFA RID: 19706 RVA: 0x0010ECF5 File Offset: 0x0010CEF5
		internal string[] PropertyNames { get; set; }

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x0010ECFE File Offset: 0x0010CEFE
		// (set) Token: 0x06004CFC RID: 19708 RVA: 0x0010ED06 File Offset: 0x0010CF06
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] TypeUsages { get; set; }

		// Token: 0x06004CFD RID: 19709 RVA: 0x0010ED10 File Offset: 0x0010CF10
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory Compile()
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] array = new global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[this._nestedRecordStateScratchpads.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this._nestedRecordStateScratchpads[i].Compile();
			}
			return (global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory)global::System.Activator.CreateInstance(typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory), new object[]
			{
				this.StateSlotNumber,
				this.ColumnCount,
				array,
				this.DataRecordInfo,
				this.GatherData,
				this.PropertyNames,
				this.TypeUsages
			});
		}

		// Token: 0x04001B5B RID: 7003
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad> _nestedRecordStateScratchpads = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad>();
	}
}
