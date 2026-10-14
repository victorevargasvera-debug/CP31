using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000193 RID: 403
	internal class LocalRepository : global::Loupe.Extensibility.IRepository
	{
		// Token: 0x14000064 RID: 100
		// (add) Token: 0x060010F4 RID: 4340 RVA: 0x00030298 File Offset: 0x0002E498
		// (remove) Token: 0x060010F5 RID: 4341 RVA: 0x000302D4 File Offset: 0x0002E4D4
		public event global::System.ComponentModel.CollectionChangeEventHandler CollectionChanged;

		// Token: 0x060010F6 RID: 4342 RVA: 0x00030310 File Offset: 0x0002E510
		public LocalRepository(string productName, string overridePath = null)
		{
			this.m_Caption = productName;
			this.m_RepositoryPath = global::Gibraltar.Monitor.LocalRepository.CalculateRepositoryPath(productName, overridePath);
			this.m_RepositoryTempPath = global::System.IO.Path.Combine(this.m_RepositoryPath, "Temp");
			this.m_SessionLockFolder = global::System.IO.Path.Combine(this.m_RepositoryPath, "RunningSessions");
			this.m_RepositoryArchivePath = global::System.IO.Path.Combine(this.m_RepositoryPath, "Archive");
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Local Repository", "Opening local repository " + this.m_Caption, "Path: {0}", new object[]
				{
					this.m_RepositoryPath
				});
			}
			global::System.IO.Directory.CreateDirectory(this.m_RepositoryTempPath);
			global::System.IO.Directory.CreateDirectory(this.m_RepositoryArchivePath);
			using (this.GetMaintenanceLock())
			{
				string path = global::System.IO.Path.Combine(this.m_RepositoryPath, "_ReadMe.txt");
				if (!global::System.IO.File.Exists(path))
				{
					try
					{
						global::System.IO.File.WriteAllText(path, "This directory contains log files.  You may delete log files (*.glf) safely, however renaming them is not recommended.");
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Local Repository", "Unable to create readme file in repository", "Path: {0}\r\nException: {1}", new object[]
							{
								this.m_RepositoryPath,
								ex.Message
							});
						}
					}
				}
				string path2 = global::System.IO.Path.Combine(this.m_RepositoryPath, "repository.gak");
				if (global::System.IO.File.Exists(path2))
				{
					try
					{
						string g = global::System.IO.File.ReadAllText(path2, global::System.Text.Encoding.UTF8);
						this.m_RepositoryId = new global::System.Guid(g);
					}
					catch (global::System.Exception ex2)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Local Repository", "Unable to read repository Id, a new one will be created", "Path: {0}\r\nException: {1}", new object[]
							{
								this.m_RepositoryPath,
								ex2.Message
							});
						}
					}
				}
				if (this.m_RepositoryId == global::System.Guid.Empty)
				{
					this.m_RepositoryId = global::System.Guid.NewGuid();
					try
					{
						global::System.IO.File.WriteAllText(path2, this.m_RepositoryId.ToString(), global::System.Text.Encoding.UTF8);
						global::System.IO.File.SetAttributes(path2, global::System.IO.FileAttributes.Hidden);
					}
					catch (global::System.Exception ex3)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex3, "Loupe.Local Repository", "Unable to store repository Id in repository.  This will lead to server integration challenges", "Path: {0}\r\nException: {1}", new object[]
							{
								this.m_RepositoryPath,
								ex3.Message
							});
						}
					}
				}
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000305DC File Offset: 0x0002E7DC
		public static string CalculateRepositoryPath(string productName, string overridePath = null)
		{
			string text = global::Gibraltar.Data.PathManager.FindBestPath(global::Gibraltar.Data.PathType.Collection, overridePath);
			if (string.IsNullOrEmpty(overridePath))
			{
				productName = global::Gibraltar.FileSystemTools.SanitizeFileName(productName);
				text = global::System.IO.Path.Combine(text, productName);
			}
			return text;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00030614 File Offset: 0x0002E814
		public static string DefaultRepositoryPath
		{
			get
			{
				return global::Gibraltar.Data.PathManager.FindBestPath(global::Gibraltar.Data.PathType.Collection, null);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00030620 File Offset: 0x0002E820
		public global::System.Guid Id
		{
			get
			{
				return this.m_RepositoryId;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00030628 File Offset: 0x0002E828
		public bool IsDirty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0003062C File Offset: 0x0002E82C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00030630 File Offset: 0x0002E830
		public string Name
		{
			get
			{
				return this.m_RepositoryPath;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00030638 File Offset: 0x0002E838
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00030640 File Offset: 0x0002E840
		public string Description
		{
			get
			{
				return this.m_RepositoryPath;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00030648 File Offset: 0x0002E848
		public bool SupportsFragments
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0003064C File Offset: 0x0002E84C
		public global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IRepositoryProduct> Products
		{
			get
			{
				throw new global::System.NotImplementedException("Getting the set of products, applications, and versions from the local repository isn't implemented yet");
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00030658 File Offset: 0x0002E858
		public bool AddSession(global::System.IO.Stream sessionStream)
		{
			using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(sessionStream))
			{
				if (!glfreader.IsSessionStream)
				{
					throw new global::System.InvalidOperationException("The provided stream is not a session file");
				}
				global::Gibraltar.Data.SessionHeader sessionHeader = glfreader.SessionHeader;
				string path = string.Format("{0}-{1}-{2}.glf", sessionHeader.Id, sessionHeader.FileId, sessionHeader.FileSequence);
				string text = global::System.IO.Path.Combine(this.m_RepositoryPath, path);
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (global::System.IO.File.Exists(text))
					{
						return false;
					}
					using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenWrite(text))
					{
						sessionStream.Position = 0L;
						global::Gibraltar.FileSystemTools.StreamContentCopy(sessionStream, fileStream, false);
						fileStream.SetLength(fileStream.Position);
						fileStream.Close();
					}
					if (this.m_SessionCache != null)
					{
						global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
						if (this.m_SessionCache.TryGetValue(sessionHeader.Id, out sessionFileInfo))
						{
							sessionFileInfo.AddFragment(sessionHeader, new global::System.IO.FileInfo(text), true);
						}
						else
						{
							sessionFileInfo = new global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>(sessionHeader, new global::System.IO.FileInfo(text), true);
							this.m_SessionCache.Add(sessionFileInfo.Id, sessionFileInfo);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000307EC File Offset: 0x0002E9EC
		public global::Gibraltar.Monitor.Session GetSession(global::System.Guid sessionId, global::System.Guid[] fragmentIds = null)
		{
			global::Gibraltar.Monitor.Session session = null;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Guid> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Guid>();
			if (fragmentIds != null)
			{
				foreach (global::System.Guid guid in fragmentIds)
				{
					dictionary.Add(guid, guid);
				}
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					global::Gibraltar.Monitor.SessionCollection sessionCollection = new global::Gibraltar.Monitor.SessionCollection();
					foreach (global::System.IO.FileInfo fileInfo in sessionFileInfo.Fragments)
					{
						if (fragmentIds != null)
						{
							global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo.FullName);
							if (!dictionary.ContainsKey(sessionHeader.FileId))
							{
								continue;
							}
						}
						session = sessionCollection.Add(fileInfo.FullName);
					}
				}
			}
			if (session == null)
			{
				throw new global::System.IO.FileNotFoundException("Unable to find any session in the repository with the id " + sessionId);
			}
			return session;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00030918 File Offset: 0x0002EB18
		public global::System.Collections.Generic.IList<global::System.Guid> GetSessionFileIds(global::System.Guid sessionId)
		{
			global::System.Collections.Generic.List<global::System.Guid> list = new global::System.Collections.Generic.List<global::System.Guid>();
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					foreach (global::System.IO.FileInfo fileInfo in sessionFileInfo.Fragments)
					{
						try
						{
							global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo.FullName);
							list.Add(sessionHeader.FileId);
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, true, "Loupe.Local Repository", "Unable to read session fragment file header due to " + ex.GetType(), "We will skip this file for the session.\r\nSession Id: {0}\r\n{1}", new object[]
								{
									sessionId,
									ex.Message
								});
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00030A28 File Offset: 0x0002EC28
		public global::Loupe.Extensibility.Data.ISession LoadSession(global::System.Guid sessionId)
		{
			throw new global::System.NotSupportedException("Loading sessions from a local repository isn't implemented yet.");
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00030A34 File Offset: 0x0002EC34
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00030A3C File Offset: 0x0002EC3C
		public bool IsLoggingEnabled
		{
			get
			{
				return this.m_LoggingEnabled;
			}
			set
			{
				this.m_LoggingEnabled = value;
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00030A48 File Offset: 0x0002EC48
		public global::System.IO.Stream LoadSessionStream(global::System.Guid sessionId)
		{
			global::Gibraltar.Monitor.Session session = this.GetSession(sessionId, null);
			global::System.IO.FileStream tempFileStream = global::Gibraltar.FileSystemTools.GetTempFileStream();
			session.Write(tempFileStream);
			tempFileStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
			return tempFileStream;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00030A78 File Offset: 0x0002EC78
		public global::System.IO.Stream LoadSessionFileStream(global::System.Guid sessionId, global::System.Guid fileId)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::System.IO.Stream stream;
				if (this.TryLoadSessionFileStream(sessionId, fileId, out stream))
				{
					using (stream)
					{
						global::System.IO.FileStream tempFileStream = global::Gibraltar.FileSystemTools.GetTempFileStream();
						global::Gibraltar.FileSystemTools.StreamContentCopy(stream, tempFileStream, true);
						return tempFileStream;
					}
				}
				throw new global::System.InvalidOperationException(string.Concat(new object[]
				{
					"There is no session file with the Id ",
					fileId,
					" for session Id ",
					sessionId
				}));
			}
			global::System.IO.Stream result;
			return result;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00030B20 File Offset: 0x0002ED20
		public bool TryLoadSessionFileStream(global::System.Guid sessionId, global::System.Guid fileId, out global::System.IO.Stream stream)
		{
			this.EnsureCacheLoaded();
			stream = null;
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (!this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					result = false;
				}
				else
				{
					global::System.IO.FileInfo fileInfo = global::Gibraltar.Monitor.LocalRepository.FindFragment(sessionFileInfo, fileId);
					if (fileInfo == null)
					{
						result = false;
					}
					else
					{
						stream = fileInfo.Open(global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		public void LoadSessionFiles(global::System.Guid sessionId, out global::Gibraltar.Data.SessionHeader sessionHeader, out global::System.Collections.Generic.IList<global::System.IO.FileInfo> sessionFragments)
		{
			this.EnsureCacheLoaded();
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					sessionHeader = sessionFileInfo.Header;
					sessionFragments = sessionFileInfo.Fragments;
				}
				else
				{
					sessionHeader = null;
					sessionFragments = null;
				}
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00030C0C File Offset: 0x0002EE0C
		public void Refresh()
		{
			this.Refresh(false, true, global::Gibraltar.Data.SessionCriteria.AllSessions);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00030C18 File Offset: 0x0002EE18
		public void Refresh(bool async, bool force)
		{
			this.Refresh(async, force, global::Gibraltar.Data.SessionCriteria.AllSessions);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00030C24 File Offset: 0x0002EE24
		internal void Refresh(bool async, bool force, global::Gibraltar.Data.SessionCriteria sessionCriteria)
		{
			if (async)
			{
				object queueLock = this.m_QueueLock;
				lock (queueLock)
				{
					if (this.m_RefreshRequests.Count < 10)
					{
						this.m_RefreshRequests.Enqueue(new global::Gibraltar.Monitor.LocalRepository.RefreshRequest(force, sessionCriteria));
					}
					if (!this.m_AsyncRefreshThreadActive)
					{
						this.m_AsyncRefreshThreadActive = true;
						global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncRefresh));
					}
					return;
				}
			}
			this.PerformRefresh(force, sessionCriteria);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00030CB0 File Offset: 0x0002EEB0
		public bool Remove(global::System.Guid sessionId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo = null;
				if (!this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					result = false;
				}
				else
				{
					bool flag = false;
					foreach (global::System.IO.FileInfo fileInfo in new global::System.Collections.Generic.List<global::System.IO.FileInfo>(sessionFileInfo.Fragments))
					{
						flag = (global::Gibraltar.Data.Win32Helper.SafeDeleteFile(fileInfo.FullName) || flag);
					}
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00030D60 File Offset: 0x0002EF60
		public bool Remove(global::System.Collections.Generic.IList<global::System.Guid> sessionIds)
		{
			bool flag = false;
			foreach (global::System.Guid sessionId in sessionIds)
			{
				flag = (this.Remove(sessionId) || flag);
			}
			return flag;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00030DB8 File Offset: 0x0002EFB8
		public bool Remove(global::System.Guid sessionId, global::System.Guid fileId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo = null;
				if (!this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					result = false;
				}
				else
				{
					global::System.IO.FileInfo fileInfo = null;
					foreach (global::System.IO.FileInfo fileInfo2 in sessionFileInfo.Fragments)
					{
						global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo2.FullName);
						if (sessionHeader != null && sessionHeader.FileId == fileId)
						{
							fileInfo = fileInfo2;
							break;
						}
					}
					if (fileInfo == null)
					{
						result = false;
					}
					else
					{
						result = global::Gibraltar.Data.Win32Helper.SafeDeleteFile(fileInfo.FullName);
					}
				}
			}
			return result;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00030EA0 File Offset: 0x0002F0A0
		public bool SessionDataExists(global::System.Guid sessionId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				result = this.m_SessionCache.ContainsKey(sessionId);
			}
			return result;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00030EEC File Offset: 0x0002F0EC
		public bool SessionDataExists(global::System.Guid sessionId, global::System.Guid fileId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::System.IO.FileInfo fileInfo = null;
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					fileInfo = global::Gibraltar.Monitor.LocalRepository.FindFragment(sessionFileInfo, fileId);
				}
				result = (fileInfo != null);
			}
			return result;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00030F4C File Offset: 0x0002F14C
		public bool SessionExists(global::System.Guid sessionId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				result = this.m_SessionCache.ContainsKey(sessionId);
			}
			return result;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00030F98 File Offset: 0x0002F198
		public bool SessionIsRunning(global::System.Guid sessionId)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
				if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
				{
					result = sessionFileInfo.IsRunning;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00030FF8 File Offset: 0x0002F1F8
		public bool SetSessionNew(global::System.Guid sessionId, bool isNew)
		{
			bool result = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				string destinationDirectory = isNew ? this.m_RepositoryPath : this.m_RepositoryArchivePath;
				result = this.SetSessionNew(destinationDirectory, sessionId, isNew);
				this.InvalidateCache();
			}
			return result;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00031060 File Offset: 0x0002F260
		public bool SetSessionsNew(global::System.Collections.Generic.IList<global::System.Guid> sessionIds, bool isNew)
		{
			bool result = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				string destinationDirectory = isNew ? this.m_RepositoryPath : this.m_RepositoryArchivePath;
				foreach (global::System.Guid sessionId in sessionIds)
				{
					result = this.SetSessionNew(destinationDirectory, sessionId, isNew);
				}
				this.InvalidateCache();
			}
			return result;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00031104 File Offset: 0x0002F304
		public global::Loupe.Extensibility.Data.ISessionSummaryCollection Find(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match)
		{
			if (match == null)
			{
				throw new global::System.ArgumentNullException("match");
			}
			global::Gibraltar.Monitor.Internal.SessionSummaryCollection sessionSummaryCollection = new global::Gibraltar.Monitor.Internal.SessionSummaryCollection(this);
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureCacheLoaded();
				foreach (global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo in this.m_SessionCache.Values)
				{
					if (match(sessionFileInfo.Header))
					{
						sessionSummaryCollection.Add(sessionFileInfo.Header);
					}
				}
			}
			return sessionSummaryCollection;
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x000311B8 File Offset: 0x0002F3B8
		public virtual global::Loupe.Extensibility.Data.ISessionSummaryCollection Sessions
		{
			get
			{
				throw new global::System.NotImplementedException("A general sessions collection isn't available in the raw local repository");
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x000311C4 File Offset: 0x0002F3C4
		public string TempPath
		{
			get
			{
				return this.m_RepositoryTempPath;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000311CC File Offset: 0x0002F3CC
		public global::Gibraltar.Data.AutoSendConsent GetAutoSendConsent(string product, string application)
		{
			global::Gibraltar.Data.AutoSendConsent result = null;
			string text = global::System.IO.Path.Combine(this.m_RepositoryPath, global::Gibraltar.Monitor.LocalRepository.GenerateConsentFileName(product, application));
			if (global::System.IO.File.Exists(text))
			{
				result = global::Gibraltar.Data.AutoSendConsent.LoadFile(text);
			}
			return result;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00031208 File Offset: 0x0002F408
		public global::Gibraltar.Data.AutoSendConsent AddOrGetAutoSendConsent(string product, string application, global::System.Version applicationVersion)
		{
			global::Gibraltar.Data.AutoSendConsent autoSendConsent = this.GetAutoSendConsent(product, application);
			if (autoSendConsent == null)
			{
				autoSendConsent = new global::Gibraltar.Data.AutoSendConsent(product, application, applicationVersion, global::Gibraltar.Monitor.Log.SessionSummary.FullyQualifiedUserName);
			}
			return autoSendConsent;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0003123C File Offset: 0x0002F43C
		public void SaveAutoSendConsent(global::Gibraltar.Data.AutoSendConsent bestConsent)
		{
			string fileNamePath = global::System.IO.Path.Combine(this.m_RepositoryPath, global::Gibraltar.Monitor.LocalRepository.GenerateConsentFileName(bestConsent.ProductName, bestConsent.ApplicationName));
			bestConsent.Save(fileNamePath);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00031274 File Offset: 0x0002F474
		public static global::Gibraltar.Data.SessionHeader LoadSessionHeader(string sessionFileNamePath)
		{
			global::Gibraltar.Data.SessionHeader result = null;
			try
			{
				using (global::System.IO.FileStream fileStream = global::Gibraltar.Data.Win32Helper.OpenFileStream(sessionFileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
				{
					if (fileStream != null && global::Gibraltar.Data.GLFReader.IsGLF(fileStream))
					{
						using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(fileStream))
						{
							result = glfreader.SessionHeader;
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Local Repository", "Unexpected exception while attempting to load a session header", "While opening the file '{0}' an exception was thrown reading the session header. This may indicate a corrupt file.\r\nException: {1}\r\n", new object[]
					{
						sessionFileNamePath,
						ex.Message
					});
				}
			}
			return result;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00031338 File Offset: 0x0002F538
		protected string RepositoryPath
		{
			get
			{
				return this.m_RepositoryPath;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00031340 File Offset: 0x0002F540
		protected string RepositoryLockPath
		{
			get
			{
				return this.m_SessionLockFolder;
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00031348 File Offset: 0x0002F548
		protected virtual void OnCollectionChanged(global::System.ComponentModel.CollectionChangeEventArgs e)
		{
			global::System.ComponentModel.CollectionChangeEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00031370 File Offset: 0x0002F570
		protected virtual void OnRefresh(bool force)
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x00031374 File Offset: 0x0002F574
		protected virtual global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> SessionCache
		{
			get
			{
				this.EnsureCacheLoaded();
				return this.m_SessionCache;
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00031384 File Offset: 0x0002F584
		private void AsyncRefresh(object state)
		{
			bool flag = false;
			try
			{
				global::Gibraltar.Monitor.LocalRepository.RefreshRequest refreshRequest;
				do
				{
					refreshRequest = null;
					object queueLock = this.m_QueueLock;
					lock (queueLock)
					{
						if (this.m_RefreshRequests.Count == 0)
						{
							this.m_AsyncRefreshThreadActive = false;
							flag = true;
							break;
						}
						refreshRequest = this.m_RefreshRequests.Dequeue();
					}
					if (refreshRequest != null)
					{
						this.PerformRefresh(refreshRequest.Force, refreshRequest.Criteria);
					}
				}
				while (refreshRequest != null);
			}
			catch (global::System.Exception exception)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.RecordException(0, exception, null, "Loupe.Local Repository", true);
				}
			}
			finally
			{
				if (!flag)
				{
					object queueLock = this.m_QueueLock;
					lock (queueLock)
					{
						this.m_AsyncRefreshThreadActive = false;
					}
				}
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00031474 File Offset: 0x0002F674
		private void PerformRefresh(bool force, global::Gibraltar.Data.SessionCriteria sessionCriteria)
		{
			if (force)
			{
				this.UpdateCache(sessionCriteria);
			}
			else
			{
				this.InvalidateCache();
			}
			this.OnRefresh(force);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00031498 File Offset: 0x0002F698
		private global::System.IDisposable GetMaintenanceLock()
		{
			return global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_RepositoryPath, "Maintenance", 0, true);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000314B0 File Offset: 0x0002F6B0
		private void EnsureCacheLoaded()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionCache == null)
				{
					this.UpdateCache(global::Gibraltar.Data.SessionCriteria.AllSessions);
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000314FC File Offset: 0x0002F6FC
		private void InvalidateCache()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionCache = null;
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0003153C File Offset: 0x0002F73C
		private static global::System.IO.FileInfo FindFragment(global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo, global::System.Guid fileId)
		{
			global::System.IO.FileInfo result = null;
			foreach (global::System.IO.FileInfo fileInfo in sessionFileInfo.Fragments)
			{
				global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo.FullName);
				if (sessionHeader != null && sessionHeader.FileId == fileId)
				{
					result = fileInfo;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x000315B8 File Offset: 0x0002F7B8
		protected void UpdateCache(global::Gibraltar.Data.SessionCriteria sessionCriteria = global::Gibraltar.Data.SessionCriteria.AllSessions)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> sessionCache = this.LoadSessions(sessionCriteria);
				this.m_SessionCache = sessionCache;
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00031600 File Offset: 0x0002F800
		private global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> LoadSessions(global::Gibraltar.Data.SessionCriteria sessionCriteria = global::Gibraltar.Data.SessionCriteria.AllSessions)
		{
			if (this.m_LoggingEnabled)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Local Repository", "Creating index of local repository sessions", "Repository Folder: {0}", new object[]
				{
					this.m_RepositoryPath
				});
			}
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>>();
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>>();
			this.LoadSessionsFromDirectory(this.m_RepositoryPath, dictionary, dictionary2, true);
			if ((sessionCriteria & global::Gibraltar.Data.SessionCriteria.CompletedSessions) > global::Gibraltar.Data.SessionCriteria.None)
			{
				this.LoadSessionsFromDirectory(this.m_RepositoryArchivePath, dictionary, dictionary2, false);
			}
			global::System.Collections.Generic.Dictionary<global::System.Guid, bool> dictionary3 = new global::System.Collections.Generic.Dictionary<global::System.Guid, bool>();
			foreach (global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo in dictionary.Values)
			{
				bool isRunning;
				if (!dictionary3.TryGetValue(sessionFileInfo.Id, out isRunning))
				{
					dictionary3.Add(sessionFileInfo.Id, this.IsSessionRunning(sessionFileInfo.Id));
				}
				sessionFileInfo.IsRunning = isRunning;
			}
			foreach (global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> session in dictionary2.Values)
			{
				this.CheckAndPerformCrashedSessionConversion(session);
			}
			if (this.m_LoggingEnabled)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Local Repository", "Finished creating index of local repository sessions", "Repository Folder: {0}\r\nSessions found: {1}", new object[]
				{
					this.m_RepositoryPath,
					dictionary.Count
				});
			}
			return dictionary;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00031780 File Offset: 0x0002F980
		private void LoadSessionsFromDirectory(string directory, global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> sessions, global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> crashConversionCandidates, bool isNew)
		{
			if (!global::System.IO.Directory.Exists(directory))
			{
				return;
			}
			global::System.IO.FileInfo[] files;
			try
			{
				files = new global::System.IO.DirectoryInfo(directory).GetFiles("*.glf", global::System.IO.SearchOption.TopDirectoryOnly);
			}
			catch (global::System.IO.DirectoryNotFoundException)
			{
				return;
			}
			catch (global::System.UnauthorizedAccessException)
			{
				return;
			}
			foreach (global::System.IO.FileInfo fileInfo in files)
			{
				global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo.FullName);
				if (sessionHeader == null)
				{
					if (this.m_LoggingEnabled)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Local Repository", "Skipping local repository fragment because the session header couldn't be loaded", "File: {0}", new object[]
						{
							fileInfo.Name
						});
					}
				}
				else
				{
					global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
					if (sessions.TryGetValue(sessionHeader.Id, out sessionFileInfo))
					{
						sessionFileInfo.AddFragment(sessionHeader, fileInfo, isNew);
					}
					else
					{
						sessionFileInfo = new global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>(sessionHeader, fileInfo, isNew);
						sessions.Add(sessionFileInfo.Id, sessionFileInfo);
					}
					if (sessionHeader.Status == global::Loupe.Extensibility.Data.SessionStatus.Running && !crashConversionCandidates.ContainsKey(sessionHeader.Id))
					{
						crashConversionCandidates.Add(sessionHeader.Id, sessionFileInfo);
					}
				}
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000318B0 File Offset: 0x0002FAB0
		private bool IsSessionRunning(global::System.Guid sessionId)
		{
			return !global::Gibraltar.Data.InterprocessLockManager.QueryLockAvailable(this, this.m_SessionLockFolder, sessionId.ToString());
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000318D4 File Offset: 0x0002FAD4
		private bool CheckAndPerformCrashedSessionConversion(global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> session)
		{
			bool result = false;
			try
			{
				using (global::Gibraltar.Data.InterprocessLock runningSessionLock = this.GetRunningSessionLock(session.Id))
				{
					if (runningSessionLock == null)
					{
						return result;
					}
					bool flag = false;
					foreach (global::System.IO.FileInfo fileInfo in session.Fragments)
					{
						if (this.m_LoggingEnabled)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Local Repository", "Opening Session File", "Opening session {0} using file '{1}'.", new object[]
							{
								session.Id,
								fileInfo.FullName
							});
						}
						global::System.IO.FileStream fileStream = null;
						global::Gibraltar.Data.GLFReader glfreader = null;
						try
						{
							fileStream = global::Gibraltar.Data.Win32Helper.OpenFileStream(fileInfo.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.Read);
							if (fileStream == null)
							{
								if (this.m_LoggingEnabled)
								{
									global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Local Repository", "Unable to Mark Session as Crashed", "Unable to completely convert session {0} from being marked as running to crashed in repository at '{1}' because the fragment '{2}' could not be opened", new object[]
									{
										session.Id,
										this.m_RepositoryPath,
										fileInfo.Name
									});
								}
							}
							else
							{
								glfreader = new global::Gibraltar.Data.GLFReader(fileStream);
								glfreader.SessionHeader.StatusName = global::Loupe.Extensibility.Data.SessionStatus.Crashed.ToString();
								global::Gibraltar.Monitor.Internal.GLFWriter.UpdateSessionHeader(glfreader, fileStream);
								flag = true;
							}
						}
						catch (global::System.Exception ex)
						{
							global::System.GC.KeepAlive(ex);
							if (this.m_LoggingEnabled)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Local Repository", "Unable to Mark Session as Crashed", "Unable to completely convert session {0} from being marked as running to crashed in repository at '{1}' because the fragment '{2}' failed due to an exception:\r\n {2}", new object[]
								{
									session.Id,
									this.m_RepositoryPath,
									fileInfo.Name,
									ex
								});
							}
						}
						finally
						{
							if (glfreader != null)
							{
								glfreader.Dispose();
							}
							if (fileStream != null)
							{
								fileStream.Dispose();
							}
						}
					}
					if (flag)
					{
						result = true;
						session.Header.StatusName = global::Loupe.Extensibility.Data.SessionStatus.Crashed.ToString();
						runningSessionLock.DisposeProxyOnClose = true;
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.KeepAlive(ex2);
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Local Repository", "Unable to Mark Session as Crashed", "Unable to completely convert a session from being marked as running to crashed in repository at {0} due to an exception:\r\n {1}", new object[]
					{
						this.m_RepositoryPath,
						ex2
					});
				}
			}
			return result;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00031B9C File Offset: 0x0002FD9C
		private global::Gibraltar.Data.InterprocessLock GetRunningSessionLock(global::System.Guid sessionId)
		{
			return global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_SessionLockFolder, sessionId.ToString(), 0, true);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00031BBC File Offset: 0x0002FDBC
		private static string GenerateConsentFileName(string product, string applicationName)
		{
			string fileName;
			if (string.IsNullOrEmpty(applicationName))
			{
				fileName = string.Format("{0}.gasc", product);
			}
			else
			{
				fileName = string.Format("{0} {1}.gasc", product, applicationName);
			}
			return global::Gibraltar.FileSystemTools.SanitizeFileName(fileName);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00031C00 File Offset: 0x0002FE00
		private bool SetSessionNew(string destinationDirectory, global::System.Guid sessionId, bool isNew)
		{
			bool result = false;
			global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo> sessionFileInfo;
			if (this.m_SessionCache.TryGetValue(sessionId, out sessionFileInfo))
			{
				foreach (global::System.IO.FileInfo fileInfo in sessionFileInfo.Fragments)
				{
					try
					{
						if (!destinationDirectory.Equals(fileInfo.DirectoryName, global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							global::Gibraltar.Data.Win32Helper.SafeDeleteFile(global::System.IO.Path.Combine(destinationDirectory, fileInfo.Name));
							global::System.IO.Directory.CreateDirectory(destinationDirectory);
							fileInfo.MoveTo(global::System.IO.Path.Combine(destinationDirectory, fileInfo.Name));
							result = true;
						}
					}
					catch (global::System.IO.FileNotFoundException ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, true, "Loupe.Local Repository", "While changing a session fragment file new state to " + isNew.ToString() + " the file was not found", "It's most likely already been moved to the appropriate status or was deleted.\r\nSession Id: {0}\r\nFragment: {1}\r\nException:\r\n{2}: {3}", new object[]
							{
								sessionId,
								fileInfo.Name,
								ex.GetType(),
								ex.Message
							});
						}
					}
					catch (global::System.Exception ex2)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, true, "Loupe.Local Repository", string.Concat(new object[]
							{
								"Unable to update session fragment new state to ",
								isNew.ToString(),
								" due to ",
								ex2.GetType()
							}), "It's most likely in use by another process, so we'll have another opportunity to get it later.\r\nSession Id: {0}\r\nFragment: {1}\r\nException:\r\n{2}: {3}", new object[]
							{
								sessionId,
								fileInfo.Name,
								ex2.GetType(),
								ex2.Message
							});
						}
					}
				}
				this.m_SessionCache.Remove(sessionId);
			}
			return result;
		}

		// Token: 0x040005C4 RID: 1476
		protected const string LogCategory = "Loupe.Local Repository";

		// Token: 0x040005C5 RID: 1477
		private const string RepositoryTempFolder = "Temp";

		// Token: 0x040005C6 RID: 1478
		internal const string RepositoryArchiveFolder = "Archive";

		// Token: 0x040005C7 RID: 1479
		internal const string RepositoryKeyFile = "repository.gak";

		// Token: 0x040005C8 RID: 1480
		internal const string ComputerKeyFile = "computer.gak";

		// Token: 0x040005C9 RID: 1481
		private readonly object m_Lock = new object();

		// Token: 0x040005CA RID: 1482
		private readonly object m_QueueLock = new object();

		// Token: 0x040005CB RID: 1483
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.LocalRepository.RefreshRequest> m_RefreshRequests = new global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.LocalRepository.RefreshRequest>();

		// Token: 0x040005CC RID: 1484
		private readonly string m_Caption;

		// Token: 0x040005CD RID: 1485
		private readonly string m_RepositoryPath;

		// Token: 0x040005CE RID: 1486
		private readonly global::System.Guid m_RepositoryId;

		// Token: 0x040005CF RID: 1487
		private readonly string m_RepositoryTempPath;

		// Token: 0x040005D0 RID: 1488
		private readonly string m_SessionLockFolder;

		// Token: 0x040005D1 RID: 1489
		private global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::System.IO.FileInfo>> m_SessionCache;

		// Token: 0x040005D2 RID: 1490
		private bool m_LoggingEnabled;

		// Token: 0x040005D3 RID: 1491
		private string m_RepositoryArchivePath;

		// Token: 0x040005D4 RID: 1492
		private bool m_AsyncRefreshThreadActive;

		// Token: 0x020004A4 RID: 1188
		private class RefreshRequest
		{
			// Token: 0x0600335F RID: 13151 RVA: 0x000BA6DC File Offset: 0x000B88DC
			public RefreshRequest(bool force, global::Gibraltar.Data.SessionCriteria sessionCriteria)
			{
				this.Criteria = sessionCriteria;
				this.Force = force;
				this.Timestamp = global::System.DateTime.Now;
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x06003360 RID: 13152 RVA: 0x000BA70C File Offset: 0x000B890C
			// (set) Token: 0x06003361 RID: 13153 RVA: 0x000BA714 File Offset: 0x000B8914
			public global::System.DateTime Timestamp { get; private set; }

			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x06003362 RID: 13154 RVA: 0x000BA720 File Offset: 0x000B8920
			// (set) Token: 0x06003363 RID: 13155 RVA: 0x000BA728 File Offset: 0x000B8928
			public global::Gibraltar.Data.SessionCriteria Criteria { get; private set; }

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x06003364 RID: 13156 RVA: 0x000BA734 File Offset: 0x000B8934
			// (set) Token: 0x06003365 RID: 13157 RVA: 0x000BA73C File Offset: 0x000B893C
			public bool Force { get; private set; }
		}
	}
}
