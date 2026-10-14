using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Gibraltar.Data;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200017D RID: 381
	internal class SessionUploadRequest : global::Gibraltar.Server.Client.WebChannelRequestBase, global::System.IDisposable
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x0002AD7C File Offset: 0x00028F7C
		public SessionUploadRequest(global::System.Guid clientId, global::Gibraltar.Monitor.LocalRepository repository, global::System.Guid sessionId, global::System.Guid? fileId, bool purgeSessionOnSuccess) : base(true, false)
		{
			this.ClientId = clientId;
			this.Repository = repository;
			this.SessionId = sessionId;
			this.FileId = fileId;
			this.PurgeSessionOnSuccess = purgeSessionOnSuccess;
			this.m_Initialized = false;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0002ADC4 File Offset: 0x00028FC4
		public bool PrepareSession()
		{
			this.Initialize();
			return this.m_SessionTransportLock != null;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0002ADD8 File Offset: 0x00028FD8
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		public global::Gibraltar.Monitor.LocalRepository Repository { get; private set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0002ADEC File Offset: 0x00028FEC
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0002ADF4 File Offset: 0x00028FF4
		public global::System.Guid ClientId { get; private set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0002AE00 File Offset: 0x00029000
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0002AE08 File Offset: 0x00029008
		public global::System.Guid SessionId { get; private set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0002AE14 File Offset: 0x00029014
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0002AE1C File Offset: 0x0002901C
		public global::System.Guid? FileId { get; set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0002AE28 File Offset: 0x00029028
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0002AE30 File Offset: 0x00029030
		public bool PurgeSessionOnSuccess { get; private set; }

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0002AE3C File Offset: 0x0002903C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0002AE4C File Offset: 0x0002904C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				if (this.m_SessionTransportLock != null)
				{
					this.m_SessionTransportLock.Dispose();
					this.m_SessionTransportLock = null;
				}
				if (this.m_DeleteTemporaryFilesOnDispose)
				{
					this.SafeDeleteTemporaryData();
				}
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0002AE84 File Offset: 0x00029084
		private void PerformCleanup(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			try
			{
				connection.UploadData(this.GenerateResourceUri(), "DELETE", "application/octet-stream", new byte[0], null, new int?(-1));
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0002AED4 File Offset: 0x000290D4
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			if (!this.m_Initialized)
			{
				this.Initialize();
			}
			if (this.m_SessionTransportLock == null)
			{
				throw new global::System.InvalidOperationException("The session is currently being transported by another process.");
			}
			if (this.m_PerformCleanup)
			{
				this.m_PerformCleanup = false;
				this.PerformCleanup(connection);
			}
			using (global::System.IO.Stream stream = this.Repository.LoadSessionFileStream(this.SessionId, this.FileId.Value))
			{
				global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<string>> list = new global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<string>>();
				if (stream.CanSeek)
				{
					try
					{
						using (global::System.Security.Cryptography.SHA1CryptoServiceProvider sha1CryptoServiceProvider = new global::System.Security.Cryptography.SHA1CryptoServiceProvider())
						{
							string value = global::System.BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(stream));
							list.Add(new global::Gibraltar.NameValuePair<string>("X-Gibraltar-Hash", value));
						}
						stream.Position = 0L;
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Publish", "Unable to calculate hash for session file due to " + ex.GetType() + " exception.", "The upload will proceed but without the hash to check the accuracy of the upload.\r\nException: {0}\r\n{1}\r\n", new object[]
							{
								ex.GetType(),
								ex.Message
							});
						}
					}
				}
				if (stream.Length < 300000L)
				{
					byte[] array = new byte[stream.Length];
					stream.Read(array, 0, array.Length);
					connection.UploadData(this.GenerateResourceUri(), "PUT", "application/octet-stream", array, list, new int?(-1));
				}
				else
				{
					stream.Position = (long)this.m_BytesWritten;
					int num = 0;
					byte[] array2 = new byte[100000];
					while ((long)this.m_BytesWritten < stream.Length)
					{
						if (stream.Length - stream.Position < (long)array2.Length)
						{
							array2 = new byte[stream.Length - stream.Position];
						}
						stream.Read(array2, 0, array2.Length);
						bool flag = stream.Position == stream.Length;
						string relativeUrl = string.Format("{0}?Start={1}&Complete={2}&FileSize={3}", new object[]
						{
							this.GenerateResourceUri(),
							this.m_BytesWritten,
							flag,
							stream.Length
						});
						bool flag2 = false;
						try
						{
							connection.UploadData(relativeUrl, "POST", "application/octet-stream", array2, list, new int?(-1));
						}
						catch (global::System.Net.WebException ex2)
						{
							if (ex2.Status == global::System.Net.WebExceptionStatus.ProtocolError && ((global::System.Net.HttpWebResponse)ex2.Response).StatusCode == global::System.Net.HttpStatusCode.BadRequest)
							{
								if (!global::Gibraltar.Monitor.Log.SilentMode)
								{
									global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Repository.Publish", "Server exchange error, we will assume client and server are out of sync.", "The server returned a Bad Request Error (400) which generally means there is either a session-specific transfer problem that may be resolved by restarting the transfer from zero or an internal server problem.\r\nException: {0}", new object[]
									{
										ex2
									});
								}
								if (num < 4)
								{
									flag2 = true;
									num++;
								}
							}
							if (!flag2)
							{
								throw;
							}
						}
						if (flag2)
						{
							this.PerformCleanup(connection);
							stream.Position = 0L;
							this.m_BytesWritten = 0;
						}
						else
						{
							this.m_BytesWritten = (int)stream.Position;
							this.UpdateProgressTrackingFile();
						}
					}
				}
			}
			this.SafeDeleteTemporaryData();
			if (this.PurgeSessionOnSuccess)
			{
				this.SafePurgeSession();
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0002B258 File Offset: 0x00029458
		private int LoadProgressTrackingFile()
		{
			int result;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.m_TempSessionProgressFileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.None))
			{
				using (global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(fileStream, global::System.Text.Encoding.UTF8))
				{
					result = binaryReader.ReadInt32();
				}
			}
			return result;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0002B2C4 File Offset: 0x000294C4
		private void UpdateProgressTrackingFile()
		{
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.m_TempSessionProgressFileNamePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None))
			{
				using (global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8))
				{
					binaryWriter.Write(this.m_BytesWritten);
					binaryWriter.Flush();
				}
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0002B33C File Offset: 0x0002953C
		private void SafePurgeSession()
		{
			try
			{
				if (this.FileId != null)
				{
					this.Repository.Remove(this.SessionId, this.FileId.Value);
				}
				else
				{
					this.Repository.Remove(this.SessionId);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0002B3B4 File Offset: 0x000295B4
		private void SafeDeleteTemporaryData()
		{
			global::Gibraltar.Server.Client.SessionUploadRequest.SafeDeleteFile(this.m_TempSessionProgressFileNamePath);
			this.m_DeleteTemporaryFilesOnDispose = false;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0002B3C8 File Offset: 0x000295C8
		private static void SafeDeleteFile(string fileNamePath)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				return;
			}
			try
			{
				global::System.IO.File.Delete(fileNamePath);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0002B408 File Offset: 0x00029608
		private string GenerateResourceUri()
		{
			if (this.FileId == null)
			{
				return string.Format("/Hosts/{0}/Sessions/{1}/session.glf", this.ClientId, this.SessionId);
			}
			return string.Format("/Hosts/{0}/Sessions/{1}/Files/{2}.zip", this.ClientId, this.SessionId, this.FileId);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0002B478 File Offset: 0x00029678
		private string GenerateTemporarySessionPath()
		{
			string text;
			if (this.Repository != null)
			{
				text = global::System.IO.Path.Combine(this.Repository.TempPath, "Session_Upload");
			}
			else
			{
				text = global::System.IO.Path.GetTempFileName();
				global::System.IO.File.Delete(text);
				this.m_DeleteTemporaryFilesOnDispose = true;
			}
			global::System.IO.Directory.CreateDirectory(text);
			return text;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0002B4CC File Offset: 0x000296CC
		private string GenerateTemporarySessionFileName()
		{
			if (this.FileId == null)
			{
				return string.Format("{0}_{1}", this.SessionId, this.ClientId);
			}
			return string.Format("{0}_{1}_{2}", this.SessionId, this.ClientId, this.FileId);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0002B53C File Offset: 0x0002973C
		private string GenerateTemporarySessionFileNamePath()
		{
			return global::System.IO.Path.Combine(this.GenerateTemporarySessionPath(), this.GenerateTemporarySessionFileName());
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0002B550 File Offset: 0x00029750
		private void Initialize()
		{
			if (this.m_Initialized)
			{
				return;
			}
			string str = this.GenerateTemporarySessionFileNamePath();
			if (this.m_SessionTransportLock == null)
			{
				this.m_SessionTransportLock = global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.GenerateTemporarySessionPath(), this.GenerateTemporarySessionFileName(), 0, true);
			}
			if (this.m_SessionTransportLock != null)
			{
				this.m_TempSessionProgressFileNamePath = str + ".txt";
				this.m_BytesWritten = 0;
				if (global::System.IO.File.Exists(this.m_TempSessionProgressFileNamePath))
				{
					try
					{
						this.m_BytesWritten = this.LoadProgressTrackingFile();
						goto IL_9F;
					}
					catch
					{
						this.m_PerformCleanup = true;
						global::Gibraltar.Server.Client.SessionUploadRequest.SafeDeleteFile(this.m_TempSessionProgressFileNamePath);
						goto IL_9F;
					}
				}
				global::Gibraltar.Server.Client.SessionUploadRequest.SafeDeleteFile(this.m_TempSessionProgressFileNamePath);
				IL_9F:
				this.m_Initialized = true;
			}
		}

		// Token: 0x04000549 RID: 1353
		private const string SessionTempFolder = "Session_Upload";

		// Token: 0x0400054A RID: 1354
		private const int SinglePassCutoffBytes = 300000;

		// Token: 0x0400054B RID: 1355
		private const int DefaultSegmentSizeBytes = 100000;

		// Token: 0x0400054C RID: 1356
		private bool m_Initialized;

		// Token: 0x0400054D RID: 1357
		private bool m_PerformCleanup;

		// Token: 0x0400054E RID: 1358
		private int m_BytesWritten;

		// Token: 0x0400054F RID: 1359
		private string m_TempSessionProgressFileNamePath;

		// Token: 0x04000550 RID: 1360
		private global::Gibraltar.Data.InterprocessLock m_SessionTransportLock;

		// Token: 0x04000551 RID: 1361
		private bool m_DeleteTemporaryFilesOnDispose;
	}
}
