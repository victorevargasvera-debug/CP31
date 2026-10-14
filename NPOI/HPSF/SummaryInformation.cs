using System;
using NPOI.HPSF.Wellknown;

namespace NPOI.HPSF
{
	// Token: 0x0200051D RID: 1309
	[global::System.Serializable]
	public class SummaryInformation : global::NPOI.HPSF.SpecialPropertySet
	{
		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x00094780 File Offset: 0x00092980
		public override global::NPOI.HPSF.Wellknown.PropertyIDMap PropertySetIDMap
		{
			get
			{
				return global::NPOI.HPSF.Wellknown.PropertyIDMap.SummaryInformationProperties;
			}
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00094787 File Offset: 0x00092987
		public SummaryInformation(global::NPOI.HPSF.PropertySet ps) : base(ps)
		{
			if (!this.IsSummaryInformation)
			{
				throw new global::NPOI.HPSF.UnexpectedPropertySetTypeException("Not a " + base.GetType().Name);
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x00091EBC File Offset: 0x000900BC
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x00091EC5 File Offset: 0x000900C5
		public string Title
		{
			get
			{
				return base.GetPropertyStringValue(2);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(2, value);
			}
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00091ED9 File Offset: 0x000900D9
		public void RemoveTitle()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(2L);
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00091EED File Offset: 0x000900ED
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x00091EF6 File Offset: 0x000900F6
		public string Subject
		{
			get
			{
				return base.GetPropertyStringValue(3);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(3, value);
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00091F0A File Offset: 0x0009010A
		public void RemoveSubject()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(3L);
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000947B3 File Offset: 0x000929B3
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x000947BC File Offset: 0x000929BC
		public string Author
		{
			get
			{
				return base.GetPropertyStringValue(4);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(4, value);
			}
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00091F3B File Offset: 0x0009013B
		public void RemoveAuthor()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(4L);
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x000947D0 File Offset: 0x000929D0
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x000947D9 File Offset: 0x000929D9
		public string Keywords
		{
			get
			{
				return base.GetPropertyStringValue(5);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(5, value);
			}
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00091F6C File Offset: 0x0009016C
		public void RemoveKeywords()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(5L);
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000947ED File Offset: 0x000929ED
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x000947F6 File Offset: 0x000929F6
		public string Comments
		{
			get
			{
				return base.GetPropertyStringValue(6);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(6, value);
			}
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00091F9D File Offset: 0x0009019D
		public void RemoveComments()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(6L);
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0009480A File Offset: 0x00092A0A
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00094813 File Offset: 0x00092A13
		public string Template
		{
			get
			{
				return base.GetPropertyStringValue(7);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(7, value);
			}
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00091FCE File Offset: 0x000901CE
		public void RemoveTemplate()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(7L);
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x00094827 File Offset: 0x00092A27
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x00094830 File Offset: 0x00092A30
		public string LastAuthor
		{
			get
			{
				return base.GetPropertyStringValue(8);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(8, value);
			}
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00091FFF File Offset: 0x000901FF
		public void RemoveLastAuthor()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(8L);
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x00094844 File Offset: 0x00092A44
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0009484E File Offset: 0x00092A4E
		public string RevNumber
		{
			get
			{
				return base.GetPropertyStringValue(9);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(9, value);
			}
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00092038 File Offset: 0x00090238
		public void RemoveRevNumber()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(9L);
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x00094863 File Offset: 0x00092A63
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x00094884 File Offset: 0x00092A84
		public long EditTime
		{
			get
			{
				if (this.GetProperty(10) == null)
				{
					return 0L;
				}
				return global::NPOI.HPSF.Util.DateToFileTime((global::System.DateTime)this.GetProperty(10));
			}
			set
			{
				global::System.DateTime dateTime = global::NPOI.HPSF.Util.FiletimeToDate(value);
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(10, 64L, dateTime);
			}
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0009206C File Offset: 0x0009026C
		public void RemoveEditTime()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(10L);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x000948B3 File Offset: 0x00092AB3
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x000948C2 File Offset: 0x00092AC2
		public global::System.DateTime? LastPrinted
		{
			get
			{
				return (global::System.DateTime?)this.GetProperty(11);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(11, 64L, value);
			}
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000920A0 File Offset: 0x000902A0
		public void RemoveLastPrinted()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(11L);
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000948DF File Offset: 0x00092ADF
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x000948EE File Offset: 0x00092AEE
		public global::System.DateTime? CreateDateTime
		{
			get
			{
				return (global::System.DateTime?)this.GetProperty(12);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(12, 64L, value);
			}
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000920D0 File Offset: 0x000902D0
		public void RemoveCreateDateTime()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(12L);
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x0009490B File Offset: 0x00092B0B
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x0009491A File Offset: 0x00092B1A
		public global::System.DateTime? LastSaveDateTime
		{
			get
			{
				return (global::System.DateTime?)this.GetProperty(13);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(13, 64L, value);
			}
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00092100 File Offset: 0x00090300
		public void RemoveLastSaveDateTime()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(13L);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x00094937 File Offset: 0x00092B37
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x00094941 File Offset: 0x00092B41
		public int PageCount
		{
			get
			{
				return this.GetPropertyIntValue(14);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(14, value);
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00092134 File Offset: 0x00090334
		public void RemovePageCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(14L);
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00094956 File Offset: 0x00092B56
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00094960 File Offset: 0x00092B60
		public int WordCount
		{
			get
			{
				return this.GetPropertyIntValue(15);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(15, value);
			}
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00092168 File Offset: 0x00090368
		public void RemoveWordCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(15L);
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x00094975 File Offset: 0x00092B75
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x0009497F File Offset: 0x00092B7F
		public int CharCount
		{
			get
			{
				return this.GetPropertyIntValue(16);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(16, value);
			}
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x0009219C File Offset: 0x0009039C
		public void RemoveCharCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(16L);
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x00094994 File Offset: 0x00092B94
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x000949A3 File Offset: 0x00092BA3
		public byte[] Thumbnail
		{
			get
			{
				return (byte[])this.GetProperty(17);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(17, 30L, value);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x000949BC File Offset: 0x00092BBC
		public global::NPOI.HPSF.Thumbnail ThumbnailThumbnail
		{
			get
			{
				byte[] thumbnail = this.Thumbnail;
				if (thumbnail == null)
				{
					return null;
				}
				return new global::NPOI.HPSF.Thumbnail(thumbnail);
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000949DB File Offset: 0x00092BDB
		public void RemoveThumbnail()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(17L);
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x000949F0 File Offset: 0x00092BF0
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x000949FA File Offset: 0x00092BFA
		public string ApplicationName
		{
			get
			{
				return base.GetPropertyStringValue(18);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(18, value);
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00094A0F File Offset: 0x00092C0F
		public void RemoveApplicationName()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(18L);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x00094A24 File Offset: 0x00092C24
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x00094A2E File Offset: 0x00092C2E
		public int Security
		{
			get
			{
				return this.GetPropertyIntValue(19);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(19, value);
			}
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00094A43 File Offset: 0x00092C43
		public void RemoveSecurity()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(19L);
		}

		// Token: 0x040015A0 RID: 5536
		public const string DEFAULT_STREAM_NAME = "\u0005SummaryInformation";
	}
}
