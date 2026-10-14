using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004B RID: 75
	internal class ValidatedObservableCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00011F89 File Offset: 0x00010189
		public ValidatedObservableCollection(bool allowNull, global::Infragistics.Controls.Editors.Primitives.ValidatedObservableCollection<T>.ValidateCallback validationCallback)
		{
			this._allowNull = allowNull;
			this._validationCallback = validationCallback;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00011F9F File Offset: 0x0001019F
		private void ValidateItem(T item)
		{
			if (!this._allowNull && item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (this._validationCallback != null)
			{
				this._validationCallback(item);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00011FD0 File Offset: 0x000101D0
		protected override void InsertItem(int index, T item)
		{
			this.ValidateItem(item);
			base.InsertItem(index, item);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00011FE1 File Offset: 0x000101E1
		protected override void SetItem(int index, T item)
		{
			this.ValidateItem(item);
			base.SetItem(index, item);
		}

		// Token: 0x0400012D RID: 301
		private global::Infragistics.Controls.Editors.Primitives.ValidatedObservableCollection<T>.ValidateCallback _validationCallback;

		// Token: 0x0400012E RID: 302
		private bool _allowNull;

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600036B RID: 875
		public delegate void ValidateCallback(T item);
	}
}
