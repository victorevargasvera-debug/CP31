using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace DevAge.IO.IsolatedStorage
{
	// Token: 0x0200027E RID: 638
	internal abstract class IsolatedStorageSettingBase
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x0007415C File Offset: 0x0007235C
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00074164 File Offset: 0x00072364
		public virtual string StorageFileName
		{
			get
			{
				return this.m_FileName;
			}
			set
			{
				this.m_FileName = value;
			}
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00074170 File Offset: 0x00072370
		public IsolatedStorageSettingBase()
		{
			this.m_FileName = null;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00074180 File Offset: 0x00072380
		protected virtual global::System.IO.IsolatedStorage.IsolatedStorageFile GetStorage()
		{
			return global::System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForAssembly();
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00074188 File Offset: 0x00072388
		public virtual void Load()
		{
			if (this.m_FileName == null)
			{
				throw new global::System.ApplicationException("Invalid filename");
			}
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				global::System.IO.IsolatedStorage.IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(this.StorageFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, storage);
				}
				catch (global::System.IO.FileNotFoundException)
				{
					isolatedStorageFileStream = null;
				}
				if (isolatedStorageFileStream == null)
				{
					this.OnCreate();
				}
				else
				{
					try
					{
						this.OnLoad(isolatedStorageFileStream);
					}
					finally
					{
						isolatedStorageFileStream.Close();
					}
				}
				storage.Close();
			}
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00074234 File Offset: 0x00072434
		public virtual void Reset()
		{
			if (this.m_FileName == null)
			{
				throw new global::System.ApplicationException("Invalid filename");
			}
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				try
				{
					storage.DeleteFile(this.StorageFileName);
				}
				catch (global::System.Exception)
				{
				}
				finally
				{
					this.OnCreate();
				}
				storage.Close();
			}
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000742C4 File Offset: 0x000724C4
		public virtual void Save()
		{
			if (this.m_FileName == null)
			{
				throw new global::System.ApplicationException("Invalid filename");
			}
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				using (global::System.IO.IsolatedStorage.IsolatedStorageFileStream isolatedStorageFileStream = new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(this.StorageFileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, storage))
				{
					this.OnSave(isolatedStorageFileStream);
					isolatedStorageFileStream.Close();
				}
				storage.Close();
			}
		}

		// Token: 0x06002087 RID: 8327
		protected abstract void OnCreate();

		// Token: 0x06002088 RID: 8328
		protected abstract void OnLoad(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File);

		// Token: 0x06002089 RID: 8329
		protected abstract void OnSave(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File);

		// Token: 0x04000C06 RID: 3078
		private string m_FileName;
	}
}
