using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.ServiceModel.CallBack
{
	// Token: 0x0200000C RID: 12
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, long>>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.BatchOpJobViewSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationProgress))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Package))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.IEntity))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Group))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionList))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
	[global::System.Serializable]
	public class ServerEventEntry
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004674 File Offset: 0x00002874
		public ServerEventEntry(global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventType eventType, object eventArgs)
		{
			this.EventType = eventType;
			this.EventArgs = eventArgs;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004698 File Offset: 0x00002898
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000474C File Offset: 0x0000294C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventType EventType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)76948252;
				short num2 = num;
				num = (short)70525724;
				switch (num2 == num)
				{
				}
				num = (short)872808449;
				if (num != 0)
				{
				}
				num = (short)1774583808;
				short num3 = num;
				num = (short)543621120;
				if (num != 0)
				{
				}
				return this.<EventType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1970569659;
				short num2 = num;
				num = (short)745701819;
				switch (num2 == num)
				{
				}
				num = (short)1139408897;
				if (num != 0)
				{
				}
				num = (short)2003959808;
				short num3 = num;
				num = (short)4784128;
				if (num != 0)
				{
				}
				this.<EventType>k__BackingField = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004800 File Offset: 0x00002A00
		public global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry ToEventEntry()
		{
			short num = (short)1931834664;
			short num2 = num;
			num = (short)1861252392;
			switch (num2 == num)
			{
			}
			num = (short)1555824641;
			if (num != 0)
			{
			}
			num = (short)1385758720;
			short num3 = num;
			num = (short)174325760;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType eventType = (global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType)this.EventType;
			eventType.ToString() != this.EventType.ToString();
			return new global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry(eventType, this.EventArgs);
		}

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.Serialization.DataMember]
		public object EventArgs;
	}
}
