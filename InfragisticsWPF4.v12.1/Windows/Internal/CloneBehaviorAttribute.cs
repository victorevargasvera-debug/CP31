using System;

namespace Infragistics.Windows.Internal
{
	// Token: 0x02000189 RID: 393
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class CloneBehaviorAttribute : global::System.Attribute
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x00029FC9 File Offset: 0x000281C9
		public CloneBehaviorAttribute(global::Infragistics.Windows.Internal.CloneBehavior behavior)
		{
			this._behavior = behavior;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00029FD8 File Offset: 0x000281D8
		public global::Infragistics.Windows.Internal.CloneBehavior Behavior
		{
			get
			{
				return this._behavior;
			}
		}

		// Token: 0x040006CA RID: 1738
		private global::Infragistics.Windows.Internal.CloneBehavior _behavior;
	}
}
