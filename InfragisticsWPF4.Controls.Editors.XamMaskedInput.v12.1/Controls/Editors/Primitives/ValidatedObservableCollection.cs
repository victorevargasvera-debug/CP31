using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004C RID: 76
	internal class ValidatedObservableCollection<T> : global::System.Collections.ObjectModel.ObservableCollection<T>
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00012051 File Offset: 0x00010251
		public ValidatedObservableCollection(bool allowNull, global::Infragistics.Controls.Editors.Primitives.ValidatedObservableCollection<T>.ValidateCallback validationCallback)
		{
			this._allowNull = allowNull;
			this._validationCallback = validationCallback;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00012067 File Offset: 0x00010267
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

		// Token: 0x06000363 RID: 867 RVA: 0x00012098 File Offset: 0x00010298
		protected override void InsertItem(int index, T item)
		{
			this.ValidateItem(item);
			base.InsertItem(index, item);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000120A9 File Offset: 0x000102A9
		protected override void SetItem(int index, T item)
		{
			this.ValidateItem(item);
			base.SetItem(index, item);
		}

		// Token: 0x04000128 RID: 296
		private global::Infragistics.Controls.Editors.Primitives.ValidatedObservableCollection<T>.ValidateCallback _validationCallback;

		// Token: 0x04000129 RID: 297
		private bool _allowNull;

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000366 RID: 870
		public delegate void ValidateCallback(T item);
	}
}
