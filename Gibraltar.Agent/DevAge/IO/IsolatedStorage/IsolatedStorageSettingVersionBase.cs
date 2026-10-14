using System;
using System.IO.IsolatedStorage;
using System.Text;

namespace DevAge.IO.IsolatedStorage
{
	// Token: 0x020002A9 RID: 681
	internal abstract class IsolatedStorageSettingVersionBase : global::DevAge.IO.IsolatedStorage.IsolatedStorageSettingBase
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x0007826C File Offset: 0x0007646C
		public IsolatedStorageSettingVersionBase(int p_Version)
		{
			this.m_Version = p_Version;
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0007827C File Offset: 0x0007647C
		public virtual int Version
		{
			get
			{
				return this.m_Version;
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00078284 File Offset: 0x00076484
		protected override void OnLoad(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File)
		{
			string a = global::DevAge.IO.StreamPersistence.ReadString(p_File, global::System.Text.Encoding.UTF8);
			if (a != "BINSETTING")
			{
				throw new global::DevAge.IO.InvalidDataException();
			}
			int p_CurrentVersion = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
			this.OnLoad(p_File, p_CurrentVersion);
		}

		// Token: 0x060021EA RID: 8682
		protected abstract void OnLoad(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File, int p_CurrentVersion);

		// Token: 0x060021EB RID: 8683 RVA: 0x000782C8 File Offset: 0x000764C8
		protected override void OnSave(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File)
		{
			global::DevAge.IO.StreamPersistence.Write(p_File, "BINSETTING", global::System.Text.Encoding.UTF8);
			global::DevAge.IO.StreamPersistence.Write(p_File, this.Version);
		}

		// Token: 0x04000C55 RID: 3157
		private const string c_Check = "BINSETTING";

		// Token: 0x04000C56 RID: 3158
		private int m_Version;
	}
}
