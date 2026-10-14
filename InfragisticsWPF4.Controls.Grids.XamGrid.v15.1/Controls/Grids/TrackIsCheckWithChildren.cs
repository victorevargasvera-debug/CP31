using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000EE RID: 238
	public abstract class TrackIsCheckWithChildren<TChildType> : global::Infragistics.Controls.Grids.TrackIsChecked where TChildType : global::Infragistics.Controls.Grids.TrackIsChecked
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00020219 File Offset: 0x0001E419
		public global::System.Collections.Generic.List<TChildType> Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00020224 File Offset: 0x0001E424
		protected internal override void InvalidateIsChecked()
		{
			if (this._isInvalidatingChildren)
			{
				return;
			}
			if (this._children.Count == 0)
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			foreach (TChildType tchildType in this._children)
			{
				if (tchildType.IsChecked == true)
				{
					flag = true;
				}
				else if (tchildType.IsChecked == false)
				{
					flag2 = true;
				}
				else
				{
					flag3 = true;
				}
				if (flag && flag2)
				{
					this.ChangeSilent(null);
					return;
				}
			}
			if (flag && !flag2 && !flag3)
			{
				this.ChangeSilent(new bool?(true));
				return;
			}
			if (!flag && flag2 && !flag3)
			{
				this.ChangeSilent(new bool?(false));
				return;
			}
			this.ChangeSilent(null);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00020334 File Offset: 0x0001E534
		protected internal override void InvalidateChildren(bool? newValue)
		{
			this._isInvalidatingChildren = true;
			foreach (TChildType tchildType in this._children)
			{
				tchildType.IsChecked = newValue;
			}
			this._isInvalidatingChildren = false;
		}

		// Token: 0x040001F0 RID: 496
		private bool _isInvalidatingChildren;

		// Token: 0x040001F1 RID: 497
		private global::System.Collections.Generic.List<TChildType> _children = new global::System.Collections.Generic.List<TChildType>();
	}
}
