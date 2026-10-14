using System;
using System.Globalization;
using System.IO;
using Gibraltar.Data;
using Gibraltar.Data.Internal;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000233 RID: 563
	internal class FileMessenger : global::Gibraltar.Messaging.MessengerBase
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x00063338 File Offset: 0x00061538
		public static string SessionFileNamePrefix(string productName, string applicationName)
		{
			return global::Gibraltar.FileSystemTools.SanitizeFileName(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1}", new object[]
			{
				productName,
				applicationName
			}));
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0006335C File Offset: 0x0006155C
		protected override void OnCommand(global::Gibraltar.Messaging.MessagingCommand command, object state, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			if (command == global::Gibraltar.Messaging.MessagingCommand.CloseFile)
			{
				maintenanceRequested = global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.Explicit;
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0006336C File Offset: 0x0006156C
		protected override void OnInitialize(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			base.Caption = "Standard File Messenger";
			base.Description = "Messenger implementation that writes messages to files through a buffer.  Supports synchronous and asynchronous messaging.";
			global::Gibraltar.Messaging.FileMessengerConfiguration fileMessengerConfiguration = (global::Gibraltar.Messaging.FileMessengerConfiguration)configuration;
			this.m_MaxFileSizeBytes = (long)((fileMessengerConfiguration.MaxFileSize < 1) ? 1024 : fileMessengerConfiguration.MaxFileSize);
			this.m_MaxFileSizeBytes *= 1048576L;
			this.m_MaxLogDurationSeconds = (long)(fileMessengerConfiguration.MaxFileDuration * 60);
			this.m_RepositoryMaintenanceEnabled = fileMessengerConfiguration.EnableFilePruning;
			this.m_MaxLocalDiskUsage = fileMessengerConfiguration.MaxLocalDiskUsage;
			this.m_MaxLocalFileAge = fileMessengerConfiguration.MaxLocalFileAge;
			this.m_RepositoryFolder = global::Gibraltar.Monitor.LocalRepository.CalculateRepositoryPath(base.Publisher.SessionSummary.Product, fileMessengerConfiguration.Folder);
			this.m_SessionLockFolder = global::System.IO.Path.Combine(this.m_RepositoryFolder, "RunningSessions");
			global::Gibraltar.FileSystemTools.EnsurePathExists(this.m_RepositoryFolder);
			global::Gibraltar.FileSystemTools.EnsurePathExists(this.m_SessionLockFolder);
			base.AutoFlush = true;
			base.AutoFlushInterval = global::System.Math.Min(fileMessengerConfiguration.AutoFlushInterval, fileMessengerConfiguration.IndexUpdateInterval);
			if (string.IsNullOrEmpty(this.m_RepositoryFolder))
			{
				throw new global::System.IO.DirectoryNotFoundException("No log folder could be determined, so the file messenger can't log.");
			}
			this.ScheduleRepositoryMaintenance(0, 0);
			this.GetSessionFileLock();
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00063498 File Offset: 0x00061698
		protected override void OnWrite(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			if (this.m_CurrentSerializer == null)
			{
				this.OpenFile();
			}
			this.m_CurrentSerializer.Write(packet);
			if (writeThrough)
			{
				this.OnFlush();
			}
			if (this.m_CurrentFile.Length > this.m_MaxFileSizeBytes)
			{
				maintenanceRequested = global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.Regular;
				return;
			}
			if (global::System.DateTime.Now > this.m_FileExpiration)
			{
				maintenanceRequested = global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.Regular;
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00063504 File Offset: 0x00061704
		protected override void OnExit()
		{
			if (this.m_CurrentSerializer != null)
			{
				this.m_CurrentSerializer.SessionHeader.StatusName = this.m_CurrentSerializer.SessionHeader.ToString();
				this.m_CurrentSerializer.Synchronous = true;
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0006354C File Offset: 0x0006174C
		protected override void OnFlush()
		{
			if (this.m_CurrentSerializer != null)
			{
				this.m_CurrentSerializer.Flush();
			}
			if (this.m_RepositoryMaintenanceRequested && !base.Exiting && global::System.DateTimeOffset.Now > this.m_RepositoryMaintenanceScheduledDateTime)
			{
				this.m_RepositoryMaintenanceRequested = false;
				if (this.m_Maintainer == null)
				{
					try
					{
						this.m_Maintainer = new global::Gibraltar.Data.Internal.RepositoryMaintenance(this.m_RepositoryFolder, base.Publisher.SessionSummary.Product, base.Publisher.SessionSummary.Application, this.m_MaxLocalFileAge, this.m_MaxLocalDiskUsage, !global::Gibraltar.Monitor.Log.SilentMode);
					}
					catch (global::System.Exception ex)
					{
						global::System.GC.KeepAlive(ex);
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Repository.Maintenance", "Unable to initialize repository maintenance", "While attempting to initialize the repository maintenance class in the file messenger an exception was thrown:\r\n{0}", new object[]
							{
								ex.Message
							});
						}
					}
				}
				if (this.m_Maintainer != null)
				{
					this.m_Maintainer.PerformMaintenance(true);
				}
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0006365C File Offset: 0x0006185C
		protected override void OnMaintenance()
		{
			this.OpenFile();
			this.ScheduleRepositoryMaintenance(0, 0);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0006366C File Offset: 0x0006186C
		protected override void OnClose()
		{
			this.CloseFile(true);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00063678 File Offset: 0x00061878
		private void GetSessionFileLock()
		{
			if (this.m_SessionFileLock != null)
			{
				return;
			}
			string lockName = global::Gibraltar.Monitor.Log.SessionSummary.Id.ToString();
			this.m_SessionFileLock = global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_SessionLockFolder, lockName, 0, true);
			if (this.m_SessionFileLock == null)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar.Agent.FileMessenger", "Gibraltar Agent unable to get the unique lock for a new session", "The Gibraltar Agent's FileMessenger was not able to lock this active session as Running.  This could interfere with efficiently distinguishing whether this session has crashed or is still running.", new object[0]);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000636EC File Offset: 0x000618EC
		private void ReleaseSessionFileLock()
		{
			if (this.m_SessionFileLock == null)
			{
				return;
			}
			try
			{
				this.m_SessionFileLock.Dispose();
				this.m_SessionFileLock = null;
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent.FileMessenger", "Gibraltar Agent got an error while releasing the unique lock for this session", "The Gibraltar Agent's FileMessenger was not able to properly release the lock as this session exits.  This will likely take care of itself as the process exits, but an exception here is unexpected and unusual.", new object[0]);
				if (this.m_SessionFileLock != null && this.m_SessionFileLock.IsDisposed)
				{
					this.m_SessionFileLock = null;
				}
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00063774 File Offset: 0x00061974
		private void ScheduleRepositoryMaintenance(int minDelaySec, int maxDelaySec)
		{
			if (!this.m_RepositoryMaintenanceEnabled || base.Exiting)
			{
				return;
			}
			int num = (maxDelaySec == 0) ? 0 : global::Gibraltar.Messaging.FileMessenger.m_RandomGenerator.Next(minDelaySec, maxDelaySec);
			global::System.DateTimeOffset dateTimeOffset = global::System.DateTimeOffset.Now.AddSeconds((double)num);
			if (this.m_RepositoryMaintenanceRequested)
			{
				this.m_RepositoryMaintenanceScheduledDateTime = ((dateTimeOffset < this.m_RepositoryMaintenanceScheduledDateTime) ? dateTimeOffset : this.m_RepositoryMaintenanceScheduledDateTime);
				return;
			}
			this.m_RepositoryMaintenanceScheduledDateTime = dateTimeOffset;
			this.m_RepositoryMaintenanceRequested = true;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00063804 File Offset: 0x00061A04
		private void CloseFile(bool isLastFile)
		{
			if (this.m_CurrentSerializer != null)
			{
				try
				{
					this.m_CurrentSerializer.Close(isLastFile);
					if (!isLastFile)
					{
						this.m_CurrentSerializer.SessionHeader.StatusName = global::Loupe.Extensibility.Data.SessionStatus.Running.ToString();
					}
				}
				finally
				{
					this.m_CurrentSerializer = null;
				}
			}
			if (this.m_CurrentFile != null)
			{
				try
				{
					this.m_CurrentFile.Flush();
					this.m_CurrentFile.Close();
				}
				finally
				{
					this.m_CurrentFile.Dispose();
					this.m_CurrentFile = null;
				}
			}
			if (isLastFile)
			{
				this.ReleaseSessionFileLock();
			}
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x000638BC File Offset: 0x00061ABC
		private void OpenFile()
		{
			this.CloseFile(false);
			this.m_CurrentSessionFile++;
			string text = global::System.IO.Path.Combine(this.m_RepositoryFolder, this.MakeFileName());
			text = global::Gibraltar.FileSystemTools.MakeFileNamePathUnique(text);
			global::Gibraltar.FileSystemTools.EnsurePathExists(text);
			this.m_CurrentFile = new global::System.IO.FileStream(text, global::System.IO.FileMode.CreateNew, global::System.IO.FileAccess.Write);
			this.m_CurrentSerializer = new global::Gibraltar.Monitor.Internal.GLFWriter(this.m_CurrentFile, base.Publisher.SessionSummary, this.m_CurrentSessionFile, new global::System.DateTimeOffset?(global::System.DateTimeOffset.Now));
			global::Gibraltar.Messaging.ICachedMessengerPacket[] headerPackets = base.Publisher.HeaderPackets;
			if (headerPackets != null)
			{
				foreach (global::Gibraltar.Messaging.ICachedMessengerPacket packet in headerPackets)
				{
					this.m_CurrentSerializer.Write(packet);
				}
			}
			this.m_FileExpiration = global::System.DateTime.Now.AddSeconds((double)this.m_MaxLogDurationSeconds);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00063994 File Offset: 0x00061B94
		private string MakeFileName()
		{
			return global::Gibraltar.FileSystemTools.SanitizeFileName(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1:yyyy-MM-dd-HH-mm-ss}-{2}.{3}", new object[]
			{
				global::Gibraltar.Messaging.FileMessenger.SessionFileNamePrefix(base.Publisher.SessionSummary.Product, base.Publisher.SessionSummary.Application),
				base.Publisher.SessionSummary.StartDateTime.UtcDateTime,
				this.m_CurrentSessionFile,
				"glf"
			}));
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00063A20 File Offset: 0x00061C20
		public FileMessenger() : base(true)
		{
		}

		// Token: 0x04000A46 RID: 2630
		public const string LogExtension = "glf";

		// Token: 0x04000A47 RID: 2631
		public const string PackageExtension = "glp";

		// Token: 0x04000A48 RID: 2632
		public const string SessionLockFolderName = "RunningSessions";

		// Token: 0x04000A49 RID: 2633
		private static readonly global::System.Random m_RandomGenerator = new global::System.Random();

		// Token: 0x04000A4A RID: 2634
		private string m_RepositoryFolder;

		// Token: 0x04000A4B RID: 2635
		private string m_SessionLockFolder;

		// Token: 0x04000A4C RID: 2636
		private int m_CurrentSessionFile;

		// Token: 0x04000A4D RID: 2637
		private global::System.DateTime m_FileExpiration;

		// Token: 0x04000A4E RID: 2638
		private global::System.IO.FileStream m_CurrentFile;

		// Token: 0x04000A4F RID: 2639
		private global::Gibraltar.Monitor.Internal.GLFWriter m_CurrentSerializer;

		// Token: 0x04000A50 RID: 2640
		private global::Gibraltar.Data.Internal.RepositoryMaintenance m_Maintainer;

		// Token: 0x04000A51 RID: 2641
		private global::Gibraltar.Data.InterprocessLock m_SessionFileLock;

		// Token: 0x04000A52 RID: 2642
		private int m_MaxLocalDiskUsage;

		// Token: 0x04000A53 RID: 2643
		private int m_MaxLocalFileAge;

		// Token: 0x04000A54 RID: 2644
		private long m_MaxFileSizeBytes;

		// Token: 0x04000A55 RID: 2645
		private long m_MaxLogDurationSeconds;

		// Token: 0x04000A56 RID: 2646
		private bool m_RepositoryMaintenanceEnabled;

		// Token: 0x04000A57 RID: 2647
		private bool m_RepositoryMaintenanceRequested;

		// Token: 0x04000A58 RID: 2648
		private global::System.DateTimeOffset m_RepositoryMaintenanceScheduledDateTime;
	}
}
