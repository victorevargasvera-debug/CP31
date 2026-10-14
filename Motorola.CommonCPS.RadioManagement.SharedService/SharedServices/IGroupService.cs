using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000041 RID: 65
	public interface IGroupService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060005FB RID: 1531
		global::Motorola.CommonCPS.RadioManagement.UIModels.Group AddGroup(global::System.Guid? parentGroupUuid);

		// Token: 0x060005FC RID: 1532
		string GetGroupName(global::System.Guid groupUuid);

		// Token: 0x060005FD RID: 1533
		void DeleteGroup(global::System.Guid groupUuid);

		// Token: 0x060005FE RID: 1534
		int GetRadioCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups = false);

		// Token: 0x060005FF RID: 1535
		byte[] UpdatedGroup(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group);

		// Token: 0x06000600 RID: 1536
		bool ValidateGroupName(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, string newName, out string error);

		// Token: 0x06000601 RID: 1537
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> GetGroupsTree();

		// Token: 0x06000602 RID: 1538
		global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroup(global::System.Guid? guid);

		// Token: 0x06000603 RID: 1539
		global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroup(string guid);

		// Token: 0x06000604 RID: 1540
		global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroupByPath(string groupPath);

		// Token: 0x06000605 RID: 1541
		string GetGroupFullPath(global::System.Guid? groupId);

		// Token: 0x06000606 RID: 1542
		string CheckGroupNameBeforeImportingFromFile(string groupNameFromFile, global::Motorola.CommonCPS.RadioManagement.UIModels.Group currentGroupName);

		// Token: 0x06000607 RID: 1543
		bool CheckIfTheGroupIsParentOrAncestor(global::Motorola.CommonCPS.RadioManagement.UIModels.Group groupToCheck, global::Motorola.CommonCPS.RadioManagement.UIModels.Group possibleAncestor);
	}
}
