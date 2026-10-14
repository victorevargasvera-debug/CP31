using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000449 RID: 1097
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	internal class ComHelper
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x000A99FC File Offset: 0x000A7BFC
		public bool IsZipFile(string filename)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(filename);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000A9A04 File Offset: 0x000A7C04
		public bool IsZipFileWithExtract(string filename)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(filename, true);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000A9A10 File Offset: 0x000A7C10
		public bool CheckZip(string filename)
		{
			return global::Ionic.Zip.ZipFile.CheckZip(filename);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000A9A18 File Offset: 0x000A7C18
		public bool CheckZipPassword(string filename, string password)
		{
			return global::Ionic.Zip.ZipFile.CheckZipPassword(filename, password);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000A9A24 File Offset: 0x000A7C24
		public void FixZipDirectory(string filename)
		{
			global::Ionic.Zip.ZipFile.FixZipDirectory(filename);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000A9A2C File Offset: 0x000A7C2C
		public string GetZipLibraryVersion()
		{
			return global::Ionic.Zip.ZipFile.LibraryVersion.ToString();
		}
	}
}
