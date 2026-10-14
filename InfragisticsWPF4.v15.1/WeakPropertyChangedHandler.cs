using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x020000AF RID: 175
	internal class WeakPropertyChangedHandler<TInstance> : global::Infragistics.WeakEventHandler<TInstance, global::System.ComponentModel.INotifyPropertyChanged, global::System.ComponentModel.PropertyChangedEventArgs> where TInstance : class
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00018F97 File Offset: 0x00017197
		public WeakPropertyChangedHandler(TInstance instance, global::System.ComponentModel.INotifyPropertyChanged eventSource, global::System.Action<TInstance, object, global::System.ComponentModel.PropertyChangedEventArgs> onEventAction) : base(instance, eventSource, onEventAction, delegate(global::Infragistics.WeakEventHandler<TInstance, global::System.ComponentModel.INotifyPropertyChanged, global::System.ComponentModel.PropertyChangedEventArgs> weakHandler, global::System.ComponentModel.INotifyPropertyChanged evSource)
		{
			evSource.PropertyChanged -= weakHandler.OnEvent;
		})
		{
		}
	}
}
