using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000010 RID: 16
	public static class Interaction
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000034EB File Offset: 0x000016EB
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000034F2 File Offset: 0x000016F2
		internal static bool ShouldRunInDesignMode { get; set; }

		// Token: 0x0600006E RID: 110 RVA: 0x000034FC File Offset: 0x000016FC
		public static global::System.Windows.Interactivity.TriggerCollection GetTriggers(global::System.Windows.DependencyObject obj)
		{
			global::System.Windows.Interactivity.TriggerCollection triggerCollection = (global::System.Windows.Interactivity.TriggerCollection)obj.GetValue(global::System.Windows.Interactivity.Interaction.TriggersProperty);
			if (triggerCollection == null)
			{
				triggerCollection = new global::System.Windows.Interactivity.TriggerCollection();
				obj.SetValue(global::System.Windows.Interactivity.Interaction.TriggersProperty, triggerCollection);
			}
			return triggerCollection;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003530 File Offset: 0x00001730
		public static global::System.Windows.Interactivity.BehaviorCollection GetBehaviors(global::System.Windows.DependencyObject obj)
		{
			global::System.Windows.Interactivity.BehaviorCollection behaviorCollection = (global::System.Windows.Interactivity.BehaviorCollection)obj.GetValue(global::System.Windows.Interactivity.Interaction.BehaviorsProperty);
			if (behaviorCollection == null)
			{
				behaviorCollection = new global::System.Windows.Interactivity.BehaviorCollection();
				obj.SetValue(global::System.Windows.Interactivity.Interaction.BehaviorsProperty, behaviorCollection);
			}
			return behaviorCollection;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003564 File Offset: 0x00001764
		private static void OnBehaviorsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.BehaviorCollection behaviorCollection = (global::System.Windows.Interactivity.BehaviorCollection)args.OldValue;
			global::System.Windows.Interactivity.BehaviorCollection behaviorCollection2 = (global::System.Windows.Interactivity.BehaviorCollection)args.NewValue;
			if (behaviorCollection != behaviorCollection2)
			{
				if (behaviorCollection != null && ((global::System.Windows.Interactivity.IAttachedObject)behaviorCollection).AssociatedObject != null)
				{
					behaviorCollection.Detach();
				}
				if (behaviorCollection2 != null && obj != null)
				{
					if (((global::System.Windows.Interactivity.IAttachedObject)behaviorCollection2).AssociatedObject != null)
					{
						throw new global::System.InvalidOperationException(global::ExceptionStringTable.CannotHostBehaviorCollectionMultipleTimesExceptionMessage);
					}
					behaviorCollection2.Attach(obj);
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000035C0 File Offset: 0x000017C0
		private static void OnTriggersChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Interactivity.TriggerCollection triggerCollection = args.OldValue as global::System.Windows.Interactivity.TriggerCollection;
			global::System.Windows.Interactivity.TriggerCollection triggerCollection2 = args.NewValue as global::System.Windows.Interactivity.TriggerCollection;
			if (triggerCollection != triggerCollection2)
			{
				if (triggerCollection != null && ((global::System.Windows.Interactivity.IAttachedObject)triggerCollection).AssociatedObject != null)
				{
					triggerCollection.Detach();
				}
				if (triggerCollection2 != null && obj != null)
				{
					if (((global::System.Windows.Interactivity.IAttachedObject)triggerCollection2).AssociatedObject != null)
					{
						throw new global::System.InvalidOperationException(global::ExceptionStringTable.CannotHostTriggerCollectionMultipleTimesExceptionMessage);
					}
					triggerCollection2.Attach(obj);
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000361C File Offset: 0x0000181C
		internal static bool IsElementLoaded(global::System.Windows.FrameworkElement element)
		{
			return element.IsLoaded;
		}

		// Token: 0x04000020 RID: 32
		private static readonly global::System.Windows.DependencyProperty TriggersProperty = global::System.Windows.DependencyProperty.RegisterAttached("ShadowTriggers", typeof(global::System.Windows.Interactivity.TriggerCollection), typeof(global::System.Windows.Interactivity.Interaction), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.Interaction.OnTriggersChanged)));

		// Token: 0x04000021 RID: 33
		private static readonly global::System.Windows.DependencyProperty BehaviorsProperty = global::System.Windows.DependencyProperty.RegisterAttached("ShadowBehaviors", typeof(global::System.Windows.Interactivity.BehaviorCollection), typeof(global::System.Windows.Interactivity.Interaction), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Interactivity.Interaction.OnBehaviorsChanged)));
	}
}
