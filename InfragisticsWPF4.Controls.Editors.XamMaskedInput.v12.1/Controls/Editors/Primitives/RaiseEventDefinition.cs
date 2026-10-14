using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004B RID: 75
	internal class RaiseEventDefinition<TEventArgs> : global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition where TEventArgs : global::System.EventArgs
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00012002 File Offset: 0x00010202
		public RaiseEventDefinition(object sender, global::System.EventHandler<TEventArgs> handlerList, TEventArgs args)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(sender);
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(args);
			this._sender = sender;
			this._handlerList = handlerList;
			this._args = args;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00012030 File Offset: 0x00010230
		public void Raise()
		{
			if (this._handlerList != null)
			{
				this._handlerList(this._sender, this._args);
			}
		}

		// Token: 0x04000125 RID: 293
		private object _sender;

		// Token: 0x04000126 RID: 294
		private global::System.EventHandler<TEventArgs> _handlerList;

		// Token: 0x04000127 RID: 295
		private TEventArgs _args;
	}
}
