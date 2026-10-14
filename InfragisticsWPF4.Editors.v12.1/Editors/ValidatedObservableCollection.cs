using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000065 RID: 101
	internal class ValidatedObservableCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00017882 File Offset: 0x00015A82
		public ValidatedObservableCollection(bool allowNull, global::Infragistics.Windows.Editors.ValidatedObservableCollection<T>.ValidateCallback validationCallback)
		{
			this._allowNull = allowNull;
			this._validationCallback = validationCallback;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00017898 File Offset: 0x00015A98
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

		// Token: 0x060005CA RID: 1482 RVA: 0x000178C9 File Offset: 0x00015AC9
		protected override void InsertItem(int index, T item)
		{
			this.ValidateItem(item);
			base.InsertItem(index, item);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000178DA File Offset: 0x00015ADA
		protected override void SetItem(int index, T item)
		{
			this.ValidateItem(item);
			base.SetItem(index, item);
		}

		// Token: 0x040001F3 RID: 499
		private global::Infragistics.Windows.Editors.ValidatedObservableCollection<T>.ValidateCallback _validationCallback;

		// Token: 0x040001F4 RID: 500
		private bool _allowNull;

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060005CD RID: 1485
		public delegate void ValidateCallback(T item);
	}
}
