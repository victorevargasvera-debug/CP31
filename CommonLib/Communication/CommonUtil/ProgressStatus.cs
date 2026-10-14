using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000068 RID: 104
	[global::System.Runtime.Serialization.DataContract]
	public enum ProgressStatus
	{
		// Token: 0x040002B4 RID: 692
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x040002B5 RID: 693
		[global::System.Runtime.Serialization.EnumMember]
		ReadingCP,
		// Token: 0x040002B6 RID: 694
		[global::System.Runtime.Serialization.EnumMember]
		ReadCPDone,
		// Token: 0x040002B7 RID: 695
		[global::System.Runtime.Serialization.EnumMember]
		ReadingLLP,
		// Token: 0x040002B8 RID: 696
		[global::System.Runtime.Serialization.EnumMember]
		ReadLLPDone,
		// Token: 0x040002B9 RID: 697
		[global::System.Runtime.Serialization.EnumMember]
		WritingCP,
		// Token: 0x040002BA RID: 698
		[global::System.Runtime.Serialization.EnumMember]
		ErasingCP,
		// Token: 0x040002BB RID: 699
		[global::System.Runtime.Serialization.EnumMember]
		EraseCPDone,
		// Token: 0x040002BC RID: 700
		[global::System.Runtime.Serialization.EnumMember]
		WriteCPDone,
		// Token: 0x040002BD RID: 701
		[global::System.Runtime.Serialization.EnumMember]
		WritingLLP,
		// Token: 0x040002BE RID: 702
		[global::System.Runtime.Serialization.EnumMember]
		WriteLLPDone,
		// Token: 0x040002BF RID: 703
		[global::System.Runtime.Serialization.EnumMember]
		WritingLanguages,
		// Token: 0x040002C0 RID: 704
		[global::System.Runtime.Serialization.EnumMember]
		WriteLanguagesDone,
		// Token: 0x040002C1 RID: 705
		[global::System.Runtime.Serialization.EnumMember]
		WritingSoftware,
		// Token: 0x040002C2 RID: 706
		[global::System.Runtime.Serialization.EnumMember]
		WriteSoftwareDone,
		// Token: 0x040002C3 RID: 707
		[global::System.Runtime.Serialization.EnumMember]
		EraseFlash,
		// Token: 0x040002C4 RID: 708
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeFlashStrap,
		// Token: 0x040002C5 RID: 709
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeFDT,
		// Token: 0x040002C6 RID: 710
		[global::System.Runtime.Serialization.EnumMember]
		ReadImage,
		// Token: 0x040002C7 RID: 711
		[global::System.Runtime.Serialization.EnumMember]
		WriteImage,
		// Token: 0x040002C8 RID: 712
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeRadio,
		// Token: 0x040002C9 RID: 713
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeHost,
		// Token: 0x040002CA RID: 714
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeDsp,
		// Token: 0x040002CB RID: 715
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeMace,
		// Token: 0x040002CC RID: 716
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeOptBrd,
		// Token: 0x040002CD RID: 717
		[global::System.Runtime.Serialization.EnumMember]
		UpgradeAccBrd,
		// Token: 0x040002CE RID: 718
		[global::System.Runtime.Serialization.EnumMember]
		UpgradePsdt,
		// Token: 0x040002CF RID: 719
		[global::System.Runtime.Serialization.EnumMember]
		BootCommitting,
		// Token: 0x040002D0 RID: 720
		[global::System.Runtime.Serialization.EnumMember]
		BootCommittingDone,
		// Token: 0x040002D1 RID: 721
		[global::System.Runtime.Serialization.EnumMember]
		ReadingBootData,
		// Token: 0x040002D2 RID: 722
		[global::System.Runtime.Serialization.EnumMember]
		ReadingBootDataDone,
		// Token: 0x040002D3 RID: 723
		[global::System.Runtime.Serialization.EnumMember]
		WritingBootData,
		// Token: 0x040002D4 RID: 724
		[global::System.Runtime.Serialization.EnumMember]
		WritingBootDataDone,
		// Token: 0x040002D5 RID: 725
		[global::System.Runtime.Serialization.EnumMember]
		PrepareData,
		// Token: 0x040002D6 RID: 726
		[global::System.Runtime.Serialization.EnumMember]
		WritingLP,
		// Token: 0x040002D7 RID: 727
		[global::System.Runtime.Serialization.EnumMember]
		WritingVA,
		// Token: 0x040002D8 RID: 728
		[global::System.Runtime.Serialization.EnumMember]
		WritingTTS,
		// Token: 0x040002D9 RID: 729
		[global::System.Runtime.Serialization.EnumMember]
		PasswordResetDone
	}
}
