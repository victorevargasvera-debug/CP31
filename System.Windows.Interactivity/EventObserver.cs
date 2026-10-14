using System;
using System.Reflection;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000B RID: 11
	public sealed class EventObserver : global::System.IDisposable
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002964 File Offset: 0x00000B64
		public EventObserver(global::System.Reflection.EventInfo eventInfo, object target, global::System.Delegate handler)
		{
			if (eventInfo == null)
			{
				throw new global::System.ArgumentNullException("eventInfo");
			}
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			this.eventInfo = eventInfo;
			this.target = target;
			this.handler = handler;
			this.eventInfo.AddEventHandler(this.target, handler);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029C0 File Offset: 0x00000BC0
		public void Dispose()
		{
			this.eventInfo.RemoveEventHandler(this.target, this.handler);
		}

		// Token: 0x04000010 RID: 16
		private global::System.Reflection.EventInfo eventInfo;

		// Token: 0x04000011 RID: 17
		private object target;

		// Token: 0x04000012 RID: 18
		private global::System.Delegate handler;
	}
}
