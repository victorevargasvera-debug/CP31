using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000112 RID: 274
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class IGRoutedUICommand : global::System.Windows.Input.RoutedUICommand, global::Infragistics.Windows.Commands.ICommandEx
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00021A1B File Offset: 0x0001FC1B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedUICommand(string text, string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired) : base(text, name, ownerType)
		{
			this._minimumStateDisallowed = minimumStateDisallowed;
			this._minimumStateRequired = minimumStateRequired;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00021A36 File Offset: 0x0001FC36
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedUICommand(string text, string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired, bool forceHandled) : this(text, name, ownerType, minimumStateDisallowed, minimumStateRequired)
		{
			this._forceHandled = forceHandled;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00021A4D File Offset: 0x0001FC4D
		public bool ForceHandled
		{
			get
			{
				return this._forceHandled;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00021A55 File Offset: 0x0001FC55
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateDisallowed
		{
			get
			{
				return this._minimumStateDisallowed;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00021A5D File Offset: 0x0001FC5D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateRequired
		{
			get
			{
				return this._minimumStateRequired;
			}
		}

		// Token: 0x04000407 RID: 1031
		private long _minimumStateDisallowed;

		// Token: 0x04000408 RID: 1032
		private long _minimumStateRequired;

		// Token: 0x04000409 RID: 1033
		private bool _forceHandled;
	}
}
