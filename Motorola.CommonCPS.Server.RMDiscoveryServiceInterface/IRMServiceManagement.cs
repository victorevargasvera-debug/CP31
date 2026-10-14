using System;
using System.Collections.Generic;
using System.ServiceModel;
using ASK.Interface;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000003 RID: 3
	[global::System.ServiceModel.ServiceContract]
	public interface IRMServiceManagement
	{
		// Token: 0x06000004 RID: 4
		[global::System.ServiceModel.OperationContract]
		string GetVersion();

		// Token: 0x06000005 RID: 5
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.FileReply GetFileContentEnhancement(global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.FileRequest request);

		// Token: 0x06000006 RID: 6
		[global::System.ServiceModel.OperationContract]
		global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.FileLinkReply GetInstallerLink(global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.FileLinkRequest request);

		// Token: 0x06000007 RID: 7
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData), Action = "http://MotorolaRMServer/CustomExceptionAction")]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.SystemKeyOperationResult> UpLoadSystemKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> sysKeys);

		// Token: 0x06000008 RID: 8
		[global::System.ServiceModel.OperationContract]
		int ChangePassword(string oldPassword, string newPassword);
	}
}
