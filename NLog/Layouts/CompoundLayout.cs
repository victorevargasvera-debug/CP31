using System;
using System.Collections.Generic;
using System.Text;
using NLog.Config;

namespace NLog.Layouts
{
	// Token: 0x02000098 RID: 152
	[global::NLog.Layouts.Layout("CompoundLayout")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class CompoundLayout : global::NLog.Layouts.Layout
	{
		// Token: 0x0600098A RID: 2442 RVA: 0x00018741 File Offset: 0x00016941
		public CompoundLayout()
		{
			this.Layouts = new global::System.Collections.Generic.List<global::NLog.Layouts.Layout>();
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00018754 File Offset: 0x00016954
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0001875C File Offset: 0x0001695C
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Layouts.Layout), "layout")]
		public global::System.Collections.Generic.IList<global::NLog.Layouts.Layout> Layouts { get; private set; }

		// Token: 0x0600098D RID: 2445 RVA: 0x00018768 File Offset: 0x00016968
		protected override void InitializeLayout()
		{
			base.InitializeLayout();
			foreach (global::NLog.Layouts.Layout layout in this.Layouts)
			{
				layout.Initialize(base.LoggingConfiguration);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000187C0 File Offset: 0x000169C0
		internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.PrecalculateBuilderInternal(logEvent, target);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000187CA File Offset: 0x000169CA
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return base.RenderAllocateBuilder(logEvent, null);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000187D4 File Offset: 0x000169D4
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			for (int i = 0; i < this.Layouts.Count; i++)
			{
				this.Layouts[i].RenderAppendBuilder(logEvent, target, false);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001880C File Offset: 0x00016A0C
		protected override void CloseLayout()
		{
			foreach (global::NLog.Layouts.Layout layout in this.Layouts)
			{
				layout.Close();
			}
			base.CloseLayout();
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001885C File Offset: 0x00016A5C
		public override string ToString()
		{
			return base.ToStringWithNestedItems<global::NLog.Layouts.Layout>(this.Layouts, (global::NLog.Layouts.Layout l) => l.ToString());
		}
	}
}
