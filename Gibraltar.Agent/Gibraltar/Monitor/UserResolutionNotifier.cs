using System;
using System.Security.Principal;
using Gibraltar.Messaging;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000180 RID: 384
	internal class UserResolutionNotifier : global::System.IDisposable
	{
		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06001010 RID: 4112 RVA: 0x0002C220 File Offset: 0x0002A420
		// (remove) Token: 0x06001011 RID: 4113 RVA: 0x0002C25C File Offset: 0x0002A45C
		public event global::Gibraltar.Monitor.UserResolutionNotifier.ResolveUserHandler ResolveUser;

		// Token: 0x06001012 RID: 4114 RVA: 0x0002C298 File Offset: 0x0002A498
		public UserResolutionNotifier(bool anonymousMode)
		{
			if (!anonymousMode)
			{
				global::Gibraltar.Messaging.Publisher.MessageDispatching += this.PublisherOnMessageDispatching;
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
		public void Dispose()
		{
			global::Gibraltar.Messaging.Publisher.MessageDispatching -= this.PublisherOnMessageDispatching;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
		private void PublisherOnMessageDispatching(object sender, global::Gibraltar.Messaging.PacketEventArgs e)
		{
			global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = e.Packet as global::Gibraltar.Monitor.Internal.LogMessagePacket;
			if (logMessagePacket == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(logMessagePacket.UserName))
			{
				return;
			}
			global::Gibraltar.Monitor.ApplicationUser currentApplicationUser = this.GetCurrentApplicationUser(logMessagePacket.UserName, logMessagePacket.UserPrincipal, logMessagePacket.Timestamp, logMessagePacket.Sequence);
			if (currentApplicationUser != null)
			{
				logMessagePacket.UserPacket = currentApplicationUser.Packet;
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0002C340 File Offset: 0x0002A540
		private global::Gibraltar.Monitor.ApplicationUser GetCurrentApplicationUser(string userName, global::System.Security.Principal.IPrincipal principal, global::System.DateTimeOffset timestamp, long sequence)
		{
			if (global::Gibraltar.Monitor.UserResolutionNotifier.t_InResolveUserEvent)
			{
				return null;
			}
			global::Gibraltar.Monitor.UserResolutionNotifier.ResolveUserHandler resolveUser = this.ResolveUser;
			if (resolveUser == null && global::Gibraltar.Monitor.UserResolutionNotifier.s_Users.Count == 0)
			{
				return null;
			}
			if (string.IsNullOrEmpty(userName))
			{
				return null;
			}
			global::Gibraltar.Monitor.ApplicationUser applicationUser;
			if (!global::Gibraltar.Monitor.UserResolutionNotifier.s_Users.TryFindUserName(userName, out applicationUser))
			{
				if (resolveUser == null)
				{
					return null;
				}
				global::Gibraltar.Monitor.ResolveUserEventArgs resolveUserEventArgs = new global::Gibraltar.Monitor.ResolveUserEventArgs(userName, principal, timestamp, sequence);
				try
				{
					global::Gibraltar.Monitor.UserResolutionNotifier.t_InResolveUserEvent = true;
					resolveUser(null, resolveUserEventArgs);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				finally
				{
					global::Gibraltar.Monitor.UserResolutionNotifier.t_InResolveUserEvent = false;
				}
				applicationUser = resolveUserEventArgs.User;
				if (applicationUser != null)
				{
					applicationUser = global::Gibraltar.Monitor.UserResolutionNotifier.s_Users.TrySetValue(applicationUser);
				}
			}
			return applicationUser;
		}

		// Token: 0x0400055F RID: 1375
		private static readonly global::Gibraltar.Monitor.ApplicationUserCollection s_Users = new global::Gibraltar.Monitor.ApplicationUserCollection();

		// Token: 0x04000561 RID: 1377
		[global::System.ThreadStatic]
		private static bool t_InResolveUserEvent;

		// Token: 0x0200049F RID: 1183
		// (Invoke) Token: 0x06003346 RID: 13126
		public delegate void ResolveUserHandler(object sender, global::Gibraltar.Monitor.ResolveUserEventArgs e);
	}
}
