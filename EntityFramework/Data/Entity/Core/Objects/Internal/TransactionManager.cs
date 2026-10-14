using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200045A RID: 1114
	internal class TransactionManager
	{
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x000AFFDA File Offset: 0x000AE1DA
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x000AFFE2 File Offset: 0x000AE1E2
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> PromotedRelationships { get; private set; }

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000AFFEB File Offset: 0x000AE1EB
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x000AFFF3 File Offset: 0x000AE1F3
		internal global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.EntityEntry> PromotedKeyEntries { get; private set; }

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x000AFFFC File Offset: 0x000AE1FC
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x000B0004 File Offset: 0x000AE204
		internal global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference> PopulatedEntityReferences { get; private set; }

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x000B000D File Offset: 0x000AE20D
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x000B0015 File Offset: 0x000AE215
		internal global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference> AlignedEntityReferences { get; private set; }

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x000B001E File Offset: 0x000AE21E
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x000B0026 File Offset: 0x000AE226
		internal global::System.Data.Entity.Core.Objects.MergeOption? OriginalMergeOption
		{
			get
			{
				return this._originalMergeOption;
			}
			set
			{
				this._originalMergeOption = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x000B002F File Offset: 0x000AE22F
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x000B0037 File Offset: 0x000AE237
		internal global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> ProcessedEntities { get; private set; }

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x000B0040 File Offset: 0x000AE240
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x000B0048 File Offset: 0x000AE248
		internal global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> WrappedEntities { get; private set; }

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x000B0051 File Offset: 0x000AE251
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x000B0059 File Offset: 0x000AE259
		internal bool TrackProcessedEntities { get; private set; }

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x000B0062 File Offset: 0x000AE262
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x000B006A File Offset: 0x000AE26A
		internal bool IsAddTracking { get; private set; }

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x000B0073 File Offset: 0x000AE273
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x000B007B File Offset: 0x000AE27B
		internal bool IsAttachTracking { get; private set; }

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x000B0084 File Offset: 0x000AE284
		// (set) Token: 0x060036AA RID: 13994 RVA: 0x000B008C File Offset: 0x000AE28C
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>> AddedRelationshipsByGraph { get; private set; }

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x000B0095 File Offset: 0x000AE295
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x000B009D File Offset: 0x000AE29D
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>> DeletedRelationshipsByGraph { get; private set; }

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x000B00A6 File Offset: 0x000AE2A6
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x000B00AE File Offset: 0x000AE2AE
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>> AddedRelationshipsByForeignKey { get; private set; }

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x000B00B7 File Offset: 0x000AE2B7
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x000B00BF File Offset: 0x000AE2BF
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>> AddedRelationshipsByPrincipalKey { get; private set; }

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000B00C8 File Offset: 0x000AE2C8
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x000B00D0 File Offset: 0x000AE2D0
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>> DeletedRelationshipsByForeignKey { get; private set; }

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000B00D9 File Offset: 0x000AE2D9
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x000B00E1 File Offset: 0x000AE2E1
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd>> ChangedForeignKeys { get; private set; }

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x000B00EA File Offset: 0x000AE2EA
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x000B00F2 File Offset: 0x000AE2F2
		internal bool IsDetectChanges { get; private set; }

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x000B00FB File Offset: 0x000AE2FB
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x000B0103 File Offset: 0x000AE303
		internal bool IsAlignChanges { get; private set; }

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x000B010C File Offset: 0x000AE30C
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x000B0114 File Offset: 0x000AE314
		internal bool IsLocalPublicAPI { get; private set; }

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x000B011D File Offset: 0x000AE31D
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x000B0125 File Offset: 0x000AE325
		internal bool IsOriginalValuesGetter { get; private set; }

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x000B012E File Offset: 0x000AE32E
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x000B0136 File Offset: 0x000AE336
		internal bool IsForeignKeyUpdate { get; private set; }

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x000B013F File Offset: 0x000AE33F
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x000B0147 File Offset: 0x000AE347
		internal bool IsRelatedEndAdd { get; private set; }

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x000B0150 File Offset: 0x000AE350
		internal bool IsGraphUpdate
		{
			get
			{
				return this._graphUpdateCount != 0;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000B015B File Offset: 0x000AE35B
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x000B0163 File Offset: 0x000AE363
		internal object EntityBeingReparented { get; set; }

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000B016C File Offset: 0x000AE36C
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x000B0174 File Offset: 0x000AE374
		internal bool IsDetaching { get; private set; }

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000B017D File Offset: 0x000AE37D
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x000B0185 File Offset: 0x000AE385
		internal global::System.Data.Entity.Core.Objects.DataClasses.EntityReference RelationshipBeingUpdated { get; private set; }

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x000B018E File Offset: 0x000AE38E
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x000B0196 File Offset: 0x000AE396
		internal bool IsFixupByReference { get; private set; }

		// Token: 0x060036CA RID: 14026 RVA: 0x000B01A0 File Offset: 0x000AE3A0
		internal void BeginAddTracking()
		{
			this.IsAddTracking = true;
			this.PopulatedEntityReferences = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
			this.AlignedEntityReferences = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
			this.PromotedRelationships = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>();
			if (!this.IsDetectChanges)
			{
				this.TrackProcessedEntities = true;
				this.ProcessedEntities = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
				this.WrappedEntities = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x000B01FF File Offset: 0x000AE3FF
		internal void EndAddTracking()
		{
			this.IsAddTracking = false;
			this.PopulatedEntityReferences = null;
			this.AlignedEntityReferences = null;
			this.PromotedRelationships = null;
			if (!this.IsDetectChanges)
			{
				this.TrackProcessedEntities = false;
				this.ProcessedEntities = null;
				this.WrappedEntities = null;
			}
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x000B023C File Offset: 0x000AE43C
		internal void BeginAttachTracking()
		{
			this.IsAttachTracking = true;
			this.PromotedRelationships = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>();
			this.PromotedKeyEntries = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.EntityEntry>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
			this.PopulatedEntityReferences = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
			this.AlignedEntityReferences = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.EntityReference>();
			this.TrackProcessedEntities = true;
			this.ProcessedEntities = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			this.WrappedEntities = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
			this.OriginalMergeOption = null;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000B02B4 File Offset: 0x000AE4B4
		internal void EndAttachTracking()
		{
			this.IsAttachTracking = false;
			this.PromotedRelationships = null;
			this.PromotedKeyEntries = null;
			this.PopulatedEntityReferences = null;
			this.AlignedEntityReferences = null;
			this.TrackProcessedEntities = false;
			this.ProcessedEntities = null;
			this.WrappedEntities = null;
			this.OriginalMergeOption = null;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000B0308 File Offset: 0x000AE508
		internal bool BeginDetectChanges()
		{
			if (this.IsDetectChanges)
			{
				return false;
			}
			this.IsDetectChanges = true;
			this.TrackProcessedEntities = true;
			this.ProcessedEntities = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			this.WrappedEntities = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default);
			this.DeletedRelationshipsByGraph = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>>();
			this.AddedRelationshipsByGraph = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>>>();
			this.DeletedRelationshipsByForeignKey = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>>();
			this.AddedRelationshipsByForeignKey = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>>();
			this.AddedRelationshipsByPrincipalKey = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.EntityKey>>>();
			this.ChangedForeignKeys = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd>>();
			return true;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x000B038C File Offset: 0x000AE58C
		internal void EndDetectChanges()
		{
			this.IsDetectChanges = false;
			this.TrackProcessedEntities = false;
			this.ProcessedEntities = null;
			this.WrappedEntities = null;
			this.DeletedRelationshipsByGraph = null;
			this.AddedRelationshipsByGraph = null;
			this.DeletedRelationshipsByForeignKey = null;
			this.AddedRelationshipsByForeignKey = null;
			this.AddedRelationshipsByPrincipalKey = null;
			this.ChangedForeignKeys = null;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x000B03DF File Offset: 0x000AE5DF
		internal void BeginAlignChanges()
		{
			this.IsAlignChanges = true;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000B03E8 File Offset: 0x000AE5E8
		internal void EndAlignChanges()
		{
			this.IsAlignChanges = false;
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x000B03F1 File Offset: 0x000AE5F1
		internal void ResetProcessedEntities()
		{
			this.ProcessedEntities.Clear();
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000B03FE File Offset: 0x000AE5FE
		internal void BeginLocalPublicAPI()
		{
			this.IsLocalPublicAPI = true;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000B0407 File Offset: 0x000AE607
		internal void EndLocalPublicAPI()
		{
			this.IsLocalPublicAPI = false;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x000B0410 File Offset: 0x000AE610
		internal void BeginOriginalValuesGetter()
		{
			this.IsOriginalValuesGetter = true;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x000B0419 File Offset: 0x000AE619
		internal void EndOriginalValuesGetter()
		{
			this.IsOriginalValuesGetter = false;
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x000B0422 File Offset: 0x000AE622
		internal void BeginForeignKeyUpdate(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference relationship)
		{
			this.RelationshipBeingUpdated = relationship;
			this.IsForeignKeyUpdate = true;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x000B0432 File Offset: 0x000AE632
		internal void EndForeignKeyUpdate()
		{
			this.RelationshipBeingUpdated = null;
			this.IsForeignKeyUpdate = false;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x000B0442 File Offset: 0x000AE642
		internal void BeginRelatedEndAdd()
		{
			this.IsRelatedEndAdd = true;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x000B044B File Offset: 0x000AE64B
		internal void EndRelatedEndAdd()
		{
			this.IsRelatedEndAdd = false;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000B0454 File Offset: 0x000AE654
		internal void BeginGraphUpdate()
		{
			this._graphUpdateCount++;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000B0464 File Offset: 0x000AE664
		internal void EndGraphUpdate()
		{
			this._graphUpdateCount--;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x000B0474 File Offset: 0x000AE674
		internal void BeginDetaching()
		{
			this.IsDetaching = true;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000B047D File Offset: 0x000AE67D
		internal void EndDetaching()
		{
			this.IsDetaching = false;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000B0486 File Offset: 0x000AE686
		internal void BeginFixupKeysByReference()
		{
			this.IsFixupByReference = true;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x000B048F File Offset: 0x000AE68F
		internal void EndFixupKeysByReference()
		{
			this.IsFixupByReference = false;
		}

		// Token: 0x040011B4 RID: 4532
		private global::System.Data.Entity.Core.Objects.MergeOption? _originalMergeOption;

		// Token: 0x040011C6 RID: 4550
		private int _graphUpdateCount;
	}
}
