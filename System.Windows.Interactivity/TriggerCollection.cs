using System;

namespace System.Windows.Interactivity
{
	// Token: 0x0200001B RID: 27
	public sealed class TriggerCollection : global::System.Windows.Interactivity.AttachableCollection<global::System.Windows.Interactivity.TriggerBase>
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00004202 File Offset: 0x00002402
		internal TriggerCollection()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000420C File Offset: 0x0000240C
		protected override void OnAttached()
		{
			foreach (global::System.Windows.Interactivity.TriggerBase triggerBase in this)
			{
				triggerBase.Attach(base.AssociatedObject);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004260 File Offset: 0x00002460
		protected override void OnDetaching()
		{
			foreach (global::System.Windows.Interactivity.TriggerBase triggerBase in this)
			{
				triggerBase.Detach();
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000042B0 File Offset: 0x000024B0
		internal override void ItemAdded(global::System.Windows.Interactivity.TriggerBase item)
		{
			if (base.AssociatedObject != null)
			{
				item.Attach(base.AssociatedObject);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000042C6 File Offset: 0x000024C6
		internal override void ItemRemoved(global::System.Windows.Interactivity.TriggerBase item)
		{
			if (((global::System.Windows.Interactivity.IAttachedObject)item).AssociatedObject != null)
			{
				item.Detach();
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000042D6 File Offset: 0x000024D6
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::System.Windows.Interactivity.TriggerCollection();
		}
	}
}
