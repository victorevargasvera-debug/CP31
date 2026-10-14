using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200004B RID: 75
	internal class ValidatedObservableCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x06000323 RID: 803 RVA: 0x0000F058 File Offset: 0x0000D258
		public ValidatedObservableCollection(bool allowNull, global::Infragistics.Controls.Editors.ValidatedObservableCollection<T>.ValidateCallback validationCallback)
		{
			this._allowNull = allowNull;
			this._validationCallback = validationCallback;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000F06E File Offset: 0x0000D26E
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

		// Token: 0x06000325 RID: 805 RVA: 0x0000F09F File Offset: 0x0000D29F
		protected override void InsertItem(int index, T item)
		{
			this.ValidateItem(item);
			base.InsertItem(index, item);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		protected override void SetItem(int index, T item)
		{
			this.ValidateItem(item);
			base.SetItem(index, item);
		}

		// Token: 0x040001C6 RID: 454
		private global::Infragistics.Controls.Editors.ValidatedObservableCollection<T>.ValidateCallback _validationCallback;

		// Token: 0x040001C7 RID: 455
		private bool _allowNull;

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000328 RID: 808
		public delegate void ValidateCallback(T item);
	}
}
