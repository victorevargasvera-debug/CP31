using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000187 RID: 391
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixCfsModelType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDMR3Site>))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionList))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionItem>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.LinkType))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificate>))]
	[global::System.Serializable]
	public class SyncData_FieldItem
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x000E0048 File Offset: 0x000DE248
		public SyncData_FieldItem()
		{
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000E005C File Offset: 0x000DE25C
		public SyncData_FieldItem(string fieldID, object fieldValue)
		{
			this.FieldID = fieldID;
			this.FieldValue = fieldValue;
			this.NotAboutConfiguration = false;
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000E0084 File Offset: 0x000DE284
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x000E0138 File Offset: 0x000DE338
		[global::System.Runtime.Serialization.DataMember]
		public string FieldID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1213464577;
				if (num != 0)
				{
				}
				num = (short)1252921428;
				short num2 = num;
				num = (short)239603796;
				switch (num2 == num)
				{
				}
				num = (short)903544832;
				if (num != 0)
				{
				}
				num = (short)980615168;
				short num3 = num;
				return this.<FieldID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1394715508;
				short num2 = num;
				num = (short)867478388;
				switch (num2 == num)
				{
				}
				num = (short)760414209;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				if (num != 0)
				{
				}
				num = (short)1207697408;
				short num3 = num;
				this.<FieldID>k__BackingField = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000E01EC File Offset: 0x000DE3EC
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x000E029C File Offset: 0x000DE49C
		[global::System.Runtime.Serialization.DataMember]
		public object FieldValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)265829227;
				short num2 = num;
				num = (short)859061099;
				switch (num2 == num)
				{
				}
				num = (short)1669988353;
				if (num != 0)
				{
				}
				num = (short)1952251904;
				if (num != 0)
				{
				}
				num = (short)440532992;
				short num3 = num;
				return this.<FieldValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)520323124;
				short num2 = num;
				num = (short)1347518516;
				switch (num2 == num)
				{
				}
				num = (short)22282241;
				if (num != 0)
				{
				}
				num = (short)405012480;
				if (num != 0)
				{
				}
				num = (short)1370947584;
				short num3 = num;
				this.<FieldValue>k__BackingField = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x000E034C File Offset: 0x000DE54C
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x000E03FC File Offset: 0x000DE5FC
		[global::System.Runtime.Serialization.DataMember]
		public bool NotAboutConfiguration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)405334276;
				short num2 = num;
				num = (short)1088612612;
				switch (num2 == num)
				{
				}
				num = (short)1400897537;
				if (num != 0)
				{
				}
				num = (short)853016576;
				if (num != 0)
				{
				}
				num = (short)98762752;
				short num3 = num;
				return this.<NotAboutConfiguration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2001266726;
				short num2 = num;
				num = (short)2093082662;
				switch (num2 == num)
				{
				}
				num = (short)1096744960;
				if (num != 0)
				{
				}
				num = (short)1506410497;
				if (num != 0)
				{
				}
				num = (short)898826240;
				short num3 = num;
				this.<NotAboutConfiguration>k__BackingField = value;
			}
		}
	}
}
