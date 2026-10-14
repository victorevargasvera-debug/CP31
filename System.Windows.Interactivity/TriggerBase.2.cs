using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000019 RID: 25
	public abstract class TriggerBase<T> : global::System.Windows.Interactivity.TriggerBase where T : global::System.Windows.DependencyObject
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000041C2 File Offset: 0x000023C2
		protected TriggerBase() : base(typeof(T))
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000041D4 File Offset: 0x000023D4
		protected new T AssociatedObject
		{
			get
			{
				return (T)((object)base.AssociatedObject);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000041E1 File Offset: 0x000023E1
		protected sealed override global::System.Type AssociatedObjectTypeConstraint
		{
			get
			{
				return base.AssociatedObjectTypeConstraint;
			}
		}
	}
}
