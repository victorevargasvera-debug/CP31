using System;
using System.Collections.Generic;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Gibraltar.Monitor.Windows;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x0200023A RID: 570
	internal class MonitorMessenger : global::Gibraltar.Messaging.MessengerBase
	{
		// Token: 0x06001CB6 RID: 7350 RVA: 0x00064D64 File Offset: 0x00062F64
		internal static void Register(global::Gibraltar.Monitor.Windows.LiveLogViewer viewer)
		{
			if (viewer == null)
			{
				return;
			}
			object obj = global::Gibraltar.Messaging.MonitorMessenger.s_ViewerLock;
			lock (obj)
			{
				global::Gibraltar.Messaging.MonitorMessenger.s_ActiveViewers.Add(viewer);
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00064DAC File Offset: 0x00062FAC
		internal static void Unregister(global::Gibraltar.Monitor.Windows.LiveLogViewer viewer)
		{
			if (viewer == null)
			{
				return;
			}
			object obj = global::Gibraltar.Messaging.MonitorMessenger.s_ViewerLock;
			lock (obj)
			{
				global::Gibraltar.Messaging.MonitorMessenger.s_ActiveViewers.Remove(viewer);
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00064DF4 File Offset: 0x00062FF4
		public static global::Loupe.Extensibility.Data.ILogMessage[] GetMessageBuffer(global::Gibraltar.Monitor.Windows.LiveLogViewer registerViewer)
		{
			object obj = global::Gibraltar.Messaging.MonitorMessenger.s_ViewerLock;
			global::Loupe.Extensibility.Data.ILogMessage[] result;
			lock (obj)
			{
				global::Loupe.Extensibility.Data.ILogMessage[] array = global::Gibraltar.Messaging.MonitorMessenger.s_Buffer.ToArray();
				if (registerViewer != null)
				{
					global::Gibraltar.Messaging.MonitorMessenger.s_ActiveViewers.Add(registerViewer);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00064E48 File Offset: 0x00063048
		private static void QueueMessageToViewers(global::Gibraltar.Monitor.Internal.LogMessagePacket newMessage)
		{
			if (newMessage == null)
			{
				return;
			}
			object obj = global::Gibraltar.Messaging.MonitorMessenger.s_ViewerLock;
			global::Gibraltar.Monitor.Windows.LiveLogViewer[] array;
			lock (obj)
			{
				array = global::Gibraltar.Messaging.MonitorMessenger.s_ActiveViewers.ToArray();
				if (global::Gibraltar.Messaging.MonitorMessenger.s_BufferSize > 0)
				{
					global::Gibraltar.Messaging.MonitorMessenger.s_Buffer.Enqueue(newMessage);
				}
				while (global::Gibraltar.Messaging.MonitorMessenger.s_Buffer.Count > global::Gibraltar.Messaging.MonitorMessenger.s_BufferSize)
				{
					global::Gibraltar.Messaging.MonitorMessenger.s_Buffer.Dequeue();
				}
			}
			global::Gibraltar.Monitor.Windows.LiveLogViewer[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].QueueViewerMessage(newMessage);
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00064EE8 File Offset: 0x000630E8
		protected override void OnWrite(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = packet as global::Gibraltar.Monitor.Internal.LogMessagePacket;
			if (logMessagePacket != null)
			{
				global::Gibraltar.Messaging.MonitorMessenger.QueueMessageToViewers(logMessagePacket);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00064F0C File Offset: 0x0006310C
		protected override void OnInitialize(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			global::Gibraltar.Messaging.ViewerMessengerConfiguration viewerMessengerConfiguration = configuration as global::Gibraltar.Messaging.ViewerMessengerConfiguration;
			if (viewerMessengerConfiguration == null)
			{
				return;
			}
			object obj = global::Gibraltar.Messaging.MonitorMessenger.s_ViewerLock;
			lock (obj)
			{
				global::Gibraltar.Messaging.MonitorMessenger.s_BufferSize = viewerMessengerConfiguration.MaxMessages;
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00064F5C File Offset: 0x0006315C
		protected override void OnClose()
		{
			base.OnClose();
			global::Gibraltar.Monitor.Listener.OnManagerExit();
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00064F6C File Offset: 0x0006316C
		protected override void OnExit()
		{
			base.OnExit();
			global::Gibraltar.Monitor.Listener.OnManagerExit();
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00064F7C File Offset: 0x0006317C
		protected override void OnCommand(global::Gibraltar.Messaging.MessagingCommand command, object state, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			base.OnCommand(command, state, writeThrough, ref maintenanceRequested);
			if (command == global::Gibraltar.Messaging.MessagingCommand.ShowLiveView)
			{
				global::Gibraltar.Monitor.Listener.ShowViewerForm();
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00064F98 File Offset: 0x00063198
		public MonitorMessenger() : base(true)
		{
		}

		// Token: 0x04000A90 RID: 2704
		public const int DefaultBufferSize = 1000;

		// Token: 0x04000A91 RID: 2705
		private static int s_BufferSize = 1000;

		// Token: 0x04000A92 RID: 2706
		private static readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.LiveLogViewer> s_ActiveViewers = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.LiveLogViewer>();

		// Token: 0x04000A93 RID: 2707
		private static readonly global::System.Collections.Generic.Queue<global::Loupe.Extensibility.Data.ILogMessage> s_Buffer = new global::System.Collections.Generic.Queue<global::Loupe.Extensibility.Data.ILogMessage>();

		// Token: 0x04000A94 RID: 2708
		private static readonly object s_ViewerLock = new object();
	}
}
