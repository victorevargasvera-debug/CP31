using System;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001AE RID: 430
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class CloneBehaviorAttribute : global::System.Attribute
	{
		// Token: 0x06000E79 RID: 3705 RVA: 0x0002E6CA File Offset: 0x0002C8CA
		public CloneBehaviorAttribute(global::Infragistics.Windows.Internal.CloneBehavior behavior)
		{
			this._behavior = behavior;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0002E6D9 File Offset: 0x0002C8D9
		public global::Infragistics.Windows.Internal.CloneBehavior Behavior
		{
			get
			{
				return this._behavior;
			}
		}

		// Token: 0x040007F0 RID: 2032
		private global::Infragistics.Windows.Internal.CloneBehavior _behavior;
	}
}
