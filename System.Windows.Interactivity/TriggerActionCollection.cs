using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000018 RID: 24
	public class TriggerActionCollection : global::System.Windows.Interactivity.AttachableCollection<global::System.Windows.Interactivity.TriggerAction>
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x000040C8 File Offset: 0x000022C8
		internal TriggerActionCollection()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000040D0 File Offset: 0x000022D0
		protected override void OnAttached()
		{
			foreach (global::System.Windows.Interactivity.TriggerAction triggerAction in this)
			{
				triggerAction.Attach(base.AssociatedObject);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004124 File Offset: 0x00002324
		protected override void OnDetaching()
		{
			foreach (global::System.Windows.Interactivity.TriggerAction triggerAction in this)
			{
				triggerAction.Detach();
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004174 File Offset: 0x00002374
		internal override void ItemAdded(global::System.Windows.Interactivity.TriggerAction item)
		{
			if (item.IsHosted)
			{
				throw new global::System.InvalidOperationException(global::ExceptionStringTable.CannotHostTriggerActionMultipleTimesExceptionMessage);
			}
			if (base.AssociatedObject != null)
			{
				item.Attach(base.AssociatedObject);
			}
			item.IsHosted = true;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000041A4 File Offset: 0x000023A4
		internal override void ItemRemoved(global::System.Windows.Interactivity.TriggerAction item)
		{
			if (((global::System.Windows.Interactivity.IAttachedObject)item).AssociatedObject != null)
			{
				item.Detach();
			}
			item.IsHosted = false;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000041BB File Offset: 0x000023BB
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::System.Windows.Interactivity.TriggerActionCollection();
		}
	}
}
