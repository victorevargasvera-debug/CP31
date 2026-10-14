using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x020001FF RID: 511
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Package))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, long>>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionList))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Group))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.IEntity))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummary>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.BatchOpJobViewSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationProgress))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey))]
	[global::System.Serializable]
	public class ClientEventEntry
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x0010ED84 File Offset: 0x0010CF84
		public ClientEventEntry(global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType eventType, object eventArgs)
		{
			this.EventType = eventType;
			this.EventArgs = eventArgs;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0010EDA8 File Offset: 0x0010CFA8
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0010EE58 File Offset: 0x0010D058
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType EventType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1879295562;
				short num2 = num;
				num = (short)77252170;
				switch (num2 == num)
				{
				}
				num = (short)1970798593;
				if (num != 0)
				{
				}
				num = (short)967770112;
				if (num != 0)
				{
				}
				num = (short)1505296384;
				short num3 = num;
				return this.<EventType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1657281022;
				short num2 = num;
				num = (short)493951486;
				switch (num2 == num)
				{
				}
				num = (short)2107310081;
				if (num != 0)
				{
				}
				num = (short)1296564224;
				if (num != 0)
				{
				}
				num = (short)1492975616;
				short num3 = num;
				this.<EventType>k__BackingField = value;
			}
		}

		// Token: 0x04000BA0 RID: 2976
		[global::System.Runtime.Serialization.DataMember]
		public object EventArgs;
	}
}
