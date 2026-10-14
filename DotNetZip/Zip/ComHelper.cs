using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x0200002E RID: 46
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	public class ComHelper
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00011574 File Offset: 0x0000F774
		public bool IsZipFile(string filename)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(filename);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001157C File Offset: 0x0000F77C
		public bool IsZipFileWithExtract(string filename)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(filename, true);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00011585 File Offset: 0x0000F785
		public bool CheckZip(string filename)
		{
			return global::Ionic.Zip.ZipFile.CheckZip(filename);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001158D File Offset: 0x0000F78D
		public bool CheckZipPassword(string filename, string password)
		{
			return global::Ionic.Zip.ZipFile.CheckZipPassword(filename, password);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00011596 File Offset: 0x0000F796
		public void FixZipDirectory(string filename)
		{
			global::Ionic.Zip.ZipFile.FixZipDirectory(filename);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001159E File Offset: 0x0000F79E
		public string GetZipLibraryVersion()
		{
			return global::Ionic.Zip.ZipFile.LibraryVersion.ToString();
		}
	}
}
