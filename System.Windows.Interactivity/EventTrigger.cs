using System;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000F RID: 15
	public class EventTrigger : global::System.Windows.Interactivity.EventTriggerBase<object>
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000344C File Offset: 0x0000164C
		public EventTrigger()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003454 File Offset: 0x00001654
		public EventTrigger(string eventName)
		{
			this.EventName = eventName;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003463 File Offset: 0x00001663
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003475 File Offset: 0x00001675
		public string EventName
		{
			get
			{
				return (string)base.GetValue(global::System.Windows.Interactivity.EventTrigger.EventNameProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Interactivity.EventTrigger.EventNameProperty, value);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003483 File Offset: 0x00001683
		protected override string GetEventName()
		{
			return this.EventName;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000348B File Offset: 0x0000168B
		private static void OnEventNameChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			((global::System.Windows.Interactivity.EventTrigger)sender).OnEventNameChanged((string)args.OldValue, (string)args.NewValue);
		}

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty EventNameProperty = global::System.Windows.DependencyProperty.Register("EventName", typeof(string), typeof(global::System.Windows.Interactivity.EventTrigger), new global::System.Windows.FrameworkPropertyMetadata("Loaded", new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.EventTrigger.OnEventNameChanged)));
	}
}
