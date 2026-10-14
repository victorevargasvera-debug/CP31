using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004A RID: 74
	internal class RaiseEventDefinition<TEventArgs> : global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition where TEventArgs : global::System.EventArgs
	{
		// Token: 0x06000364 RID: 868 RVA: 0x00011F3A File Offset: 0x0001013A
		public RaiseEventDefinition(object sender, global::System.EventHandler<TEventArgs> handlerList, TEventArgs args)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(sender);
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(args);
			this._sender = sender;
			this._handlerList = handlerList;
			this._args = args;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00011F68 File Offset: 0x00010168
		public void Raise()
		{
			if (this._handlerList != null)
			{
				this._handlerList(this._sender, this._args);
			}
		}

		// Token: 0x0400012A RID: 298
		private object _sender;

		// Token: 0x0400012B RID: 299
		private global::System.EventHandler<TEventArgs> _handlerList;

		// Token: 0x0400012C RID: 300
		private TEventArgs _args;
	}
}
