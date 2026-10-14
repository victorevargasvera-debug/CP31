using System;
using System.ComponentModel;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200001A RID: 26
	internal class WeakBindingListChangedHandler<TOwner> where TOwner : class
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00004E0C File Offset: 0x0000300C
		internal WeakBindingListChangedHandler(global::System.Action<TOwner, object, global::System.ComponentModel.ListChangedEventArgs> handler, TOwner owner, global::System.ComponentModel.IBindingList bindingList)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(bindingList);
			global::Infragistics.CoreUtilities.ValidateNotNull(handler);
			this._owner = new global::System.WeakReference(owner);
			this._bindingList = bindingList;
			this._handler = handler;
			bindingList.ListChanged += this.OnListChanged;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004E5C File Offset: 0x0000305C
		private void OnListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			TOwner towner = (TOwner)((object)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._owner));
			if (towner != null)
			{
				this._handler(towner, sender, e);
				return;
			}
			this.Unhook();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004E97 File Offset: 0x00003097
		internal void Unhook()
		{
			this._bindingList.ListChanged -= this.OnListChanged;
		}

		// Token: 0x04000035 RID: 53
		private global::System.Action<TOwner, object, global::System.ComponentModel.ListChangedEventArgs> _handler;

		// Token: 0x04000036 RID: 54
		private global::System.WeakReference _owner;

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IBindingList _bindingList;
	}
}
