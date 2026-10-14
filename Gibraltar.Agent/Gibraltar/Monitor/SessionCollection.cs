using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A7 RID: 423
	internal class SessionCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.Session>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.Session>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Session>, global::System.Collections.IEnumerable
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x00035D58 File Offset: 0x00033F58
		public global::Gibraltar.Monitor.Session Add(string fileNamePath)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Open(fileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			return this.Add(fileStream, true);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00035D7C File Offset: 0x00033F7C
		public global::Gibraltar.Monitor.Session Add(global::System.IO.Stream fileStream)
		{
			return this.Add(fileStream, false);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00035D88 File Offset: 0x00033F88
		public global::Gibraltar.Monitor.Session Add(global::System.IO.Stream fileStream, bool useOriginalStream)
		{
			if (fileStream == null)
			{
				throw new global::System.ArgumentNullException("fileStream");
			}
			long position = fileStream.Position;
			if (!global::Gibraltar.Data.GLFReader.IsGLF(fileStream))
			{
				fileStream.Position = position;
				throw new global::System.ArgumentException("The provided data stream is not a valid GLF session stream.", "fileStream");
			}
			global::System.IO.Stream stream;
			if (!useOriginalStream)
			{
				fileStream.Position = 0L;
				stream = global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(fileStream);
				stream.Position = position;
				fileStream.Position = position;
			}
			else
			{
				stream = fileStream;
			}
			global::Gibraltar.Data.GLFReader sessionFileReader = new global::Gibraltar.Data.GLFReader(stream);
			return this.Add(sessionFileReader);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00035E0C File Offset: 0x0003400C
		internal global::Gibraltar.Monitor.Session Add(global::Gibraltar.Data.GLFReader sessionFileReader)
		{
			if (sessionFileReader == null)
			{
				throw new global::System.ArgumentNullException("sessionFileReader");
			}
			global::Gibraltar.Monitor.Session session = null;
			if (sessionFileReader.IsSessionStream)
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_SessionsById.TryGetValue(sessionFileReader.SessionHeader.Id, out session);
					if (session == null)
					{
						session = new global::Gibraltar.Monitor.Session(sessionFileReader);
						this.Add(session);
					}
					else
					{
						session.Fragments.Add(sessionFileReader);
					}
				}
			}
			return session;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00035EA8 File Offset: 0x000340A8
		public void Add(global::Gibraltar.Monitor.Session item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionsById.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("There is already a field definition with the provided name.", "item");
				}
				this.m_SessionsById.Add(item.Id, item);
				this.m_SessionsList.Add(item, item);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00035F3C File Offset: 0x0003413C
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionsById.Clear();
				this.m_SessionsList.Clear();
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00035F88 File Offset: 0x00034188
		public bool Contains(global::Gibraltar.Monitor.Session item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionsById.ContainsKey(item.Id);
			}
			return result;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00035FE8 File Offset: 0x000341E8
		public void CopyTo(global::Gibraltar.Monitor.Session[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionsList.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00036030 File Offset: 0x00034230
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.Session> GetEnumerator()
		{
			return this.m_SessionsList.Values.GetEnumerator();
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00036044 File Offset: 0x00034244
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0003604C File Offset: 0x0003424C
		public bool Remove(global::System.Guid sessionId)
		{
			bool result = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.Session key;
				if (this.TryGetValue(sessionId, out key))
				{
					if (this.m_SessionsList.Remove(key))
					{
						result = true;
					}
					if (this.m_SessionsById.Remove(sessionId))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000360BC File Offset: 0x000342BC
		public bool Remove(global::Gibraltar.Monitor.Session item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			bool result = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionsList.Remove(item))
				{
					result = true;
				}
				if (this.m_SessionsById.Remove(item.Id))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00036138 File Offset: 0x00034338
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_SessionsList.Count;
				}
				return count;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0003617C File Offset: 0x0003437C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00036180 File Offset: 0x00034380
		public int IndexOf(global::Gibraltar.Monitor.Session item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_SessionsList.IndexOfValue(item);
			}
			return result;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000361DC File Offset: 0x000343DC
		public int IndexOf(global::System.Guid ID)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.IndexOf(this.m_SessionsById[ID]);
			}
			return result;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00036228 File Offset: 0x00034428
		public void Insert(int index, global::Gibraltar.Monitor.Session item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00036230 File Offset: 0x00034430
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000692 RID: 1682
		public global::Gibraltar.Monitor.Session this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Session result;
				lock (@lock)
				{
					result = this.m_SessionsList.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000693 RID: 1683
		public global::Gibraltar.Monitor.Session this[global::System.Guid ID]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Session result;
				lock (@lock)
				{
					result = this.m_SessionsById[ID];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000362D8 File Offset: 0x000344D8
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.Session value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionsById.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00036320 File Offset: 0x00034520
		public bool ContainsKey(global::System.Guid key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionsById.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x04000649 RID: 1609
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Session> m_SessionsById = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Session>();

		// Token: 0x0400064A RID: 1610
		private readonly global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Session, global::Gibraltar.Monitor.Session> m_SessionsList = new global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Session, global::Gibraltar.Monitor.Session>();

		// Token: 0x0400064B RID: 1611
		private readonly object m_Lock = new object();
	}
}
