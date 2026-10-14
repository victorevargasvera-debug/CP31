using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200006B RID: 107
	internal class ValidatedObservableCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00018F3E File Offset: 0x0001713E
		public ValidatedObservableCollection(bool allowNull, global::Infragistics.Windows.Editors.ValidatedObservableCollection<T>.ValidateCallback validationCallback)
		{
			this._allowNull = allowNull;
			this._validationCallback = validationCallback;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00018F54 File Offset: 0x00017154
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

		// Token: 0x06000622 RID: 1570 RVA: 0x00018F85 File Offset: 0x00017185
		protected override void InsertItem(int index, T item)
		{
			this.ValidateItem(item);
			base.InsertItem(index, item);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00018F96 File Offset: 0x00017196
		protected override void SetItem(int index, T item)
		{
			this.ValidateItem(item);
			base.SetItem(index, item);
		}

		// Token: 0x04000226 RID: 550
		private global::Infragistics.Windows.Editors.ValidatedObservableCollection<T>.ValidateCallback _validationCallback;

		// Token: 0x04000227 RID: 551
		private bool _allowNull;

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000625 RID: 1573
		public delegate void ValidateCallback(T item);
	}
}
