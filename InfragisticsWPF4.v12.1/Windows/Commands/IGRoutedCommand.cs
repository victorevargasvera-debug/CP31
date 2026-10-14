using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000111 RID: 273
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class IGRoutedCommand : global::System.Windows.Input.RoutedCommand, global::Infragistics.Windows.Commands.ICommandEx
	{
		// Token: 0x06000A3F RID: 2623 RVA: 0x000219D5 File Offset: 0x0001FBD5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedCommand(string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired) : base(name, ownerType)
		{
			this._minimumStateDisallowed = minimumStateDisallowed;
			this._minimumStateRequired = minimumStateRequired;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000219EE File Offset: 0x0001FBEE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedCommand(string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired, bool forceHandled) : this(name, ownerType, minimumStateDisallowed, minimumStateRequired)
		{
			this._forceHandled = forceHandled;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00021A03 File Offset: 0x0001FC03
		public bool ForceHandled
		{
			get
			{
				return this._forceHandled;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00021A0B File Offset: 0x0001FC0B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateDisallowed
		{
			get
			{
				return this._minimumStateDisallowed;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00021A13 File Offset: 0x0001FC13
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateRequired
		{
			get
			{
				return this._minimumStateRequired;
			}
		}

		// Token: 0x04000404 RID: 1028
		private long _minimumStateDisallowed;

		// Token: 0x04000405 RID: 1029
		private long _minimumStateRequired;

		// Token: 0x04000406 RID: 1030
		private bool _forceHandled;
	}
}
