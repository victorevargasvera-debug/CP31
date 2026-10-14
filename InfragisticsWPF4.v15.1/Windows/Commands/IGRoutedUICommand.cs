using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000130 RID: 304
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class IGRoutedUICommand : global::System.Windows.Input.RoutedUICommand, global::Infragistics.Windows.Commands.ICommandEx
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x000255E3 File Offset: 0x000237E3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedUICommand(string text, string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired) : base(text, name, ownerType)
		{
			this._minimumStateDisallowed = minimumStateDisallowed;
			this._minimumStateRequired = minimumStateRequired;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000255FE File Offset: 0x000237FE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public IGRoutedUICommand(string text, string name, global::System.Type ownerType, long minimumStateDisallowed, long minimumStateRequired, bool forceHandled) : this(text, name, ownerType, minimumStateDisallowed, minimumStateRequired)
		{
			this._forceHandled = forceHandled;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00025615 File Offset: 0x00023815
		public bool ForceHandled
		{
			get
			{
				return this._forceHandled;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002561D File Offset: 0x0002381D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateDisallowed
		{
			get
			{
				return this._minimumStateDisallowed;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00025625 File Offset: 0x00023825
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public long MinimumStateRequired
		{
			get
			{
				return this._minimumStateRequired;
			}
		}

		// Token: 0x040004BA RID: 1210
		private long _minimumStateDisallowed;

		// Token: 0x040004BB RID: 1211
		private long _minimumStateRequired;

		// Token: 0x040004BC RID: 1212
		private bool _forceHandled;
	}
}
