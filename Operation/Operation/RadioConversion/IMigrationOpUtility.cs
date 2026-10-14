using System;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000004 RID: 4
	public interface IMigrationOpUtility
	{
		// Token: 0x06000009 RID: 9
		string DownloadArchiveFile(global::System.Guid fileUuid, string hashCode);

		// Token: 0x0600000A RID: 10
		string DownloadPBAFile(global::System.Guid fileUuid, string hashCode);

		// Token: 0x0600000B RID: 11
		void DeleteFile(string filePath);

		// Token: 0x0600000C RID: 12
		string GenerateConfigurationName(string templateName);

		// Token: 0x0600000D RID: 13
		global::Motorola.CommonCPS.Server.EntityModel.Radio CreateConversionRadioByArchiveFile(global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertionInfo);

		// Token: 0x0600000E RID: 14
		void ClearLocalFolder(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType);
	}
}
