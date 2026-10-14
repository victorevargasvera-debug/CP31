using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012F RID: 303
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class IGRoutedCommand : global::System.Windows.Input.RoutedCommand, global::Infragistics.Windows.Commands.ICommandEx
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x0002559D File Offset: 0x0002379D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedCommand(string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired) : base(name, ownerType)
		{
			this._minimumStateDisallowed = minimumStateDisallowed;
			this._minimumStateRequired = minimumStateRequired;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000255B6 File Offset: 0x000237B6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedCommand(string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired, bool forceHandled) : this(name, ownerType, minimumStateDisallowed, minimumStateRequired)
		{
			this._forceHandled = forceHandled;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000255CB File Offset: 0x000237CB
		public bool ForceHandled
		{
			get
			{
				return this._forceHandled;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000255D3 File Offset: 0x000237D3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateDisallowed
		{
			get
			{
				return this._minimumStateDisallowed;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000255DB File Offset: 0x000237DB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateRequired
		{
			get
			{
				return this._minimumStateRequired;
			}
		}

		// Token: 0x040004B7 RID: 1207
		private long _minimumStateDisallowed;

		// Token: 0x040004B8 RID: 1208
		private long _minimumStateRequired;

		// Token: 0x040004B9 RID: 1209
		private bool _forceHandled;
	}
}
