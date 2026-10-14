using System;
using System.Collections;
using NPOI.HPSF.Wellknown;

namespace NPOI.HPSF
{
	// Token: 0x0200050A RID: 1290
	[global::System.Serializable]
	public class DocumentSummaryInformation : global::NPOI.HPSF.SpecialPropertySet
	{
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x00091E89 File Offset: 0x00090089
		public override global::NPOI.HPSF.Wellknown.PropertyIDMap PropertySetIDMap
		{
			get
			{
				return global::NPOI.HPSF.Wellknown.PropertyIDMap.DocumentSummaryInformationProperties;
			}
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00091E90 File Offset: 0x00090090
		public DocumentSummaryInformation(global::NPOI.HPSF.PropertySet ps) : base(ps)
		{
			if (!this.IsDocumentSummaryInformation)
			{
				throw new global::NPOI.HPSF.UnexpectedPropertySetTypeException("Not a " + base.GetType().Name);
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x00091EBC File Offset: 0x000900BC
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x00091EC5 File Offset: 0x000900C5
		public string Category
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

		// Token: 0x06003022 RID: 12322 RVA: 0x00091ED9 File Offset: 0x000900D9
		public void RemoveCategory()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(2L);
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00091EED File Offset: 0x000900ED
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x00091EF6 File Offset: 0x000900F6
		public string PresentationFormat
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

		// Token: 0x06003025 RID: 12325 RVA: 0x00091F0A File Offset: 0x0009010A
		public void RemovePresentationFormat()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(3L);
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x00091F1E File Offset: 0x0009011E
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x00091F27 File Offset: 0x00090127
		public int ByteCount
		{
			get
			{
				return this.GetPropertyIntValue(4);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(4, value);
			}
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00091F3B File Offset: 0x0009013B
		public void RemoveByteCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(4L);
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x00091F4F File Offset: 0x0009014F
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x00091F58 File Offset: 0x00090158
		public int LineCount
		{
			get
			{
				return this.GetPropertyIntValue(5);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(5, value);
			}
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00091F6C File Offset: 0x0009016C
		public void RemoveLineCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(5L);
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x00091F80 File Offset: 0x00090180
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x00091F89 File Offset: 0x00090189
		public int ParCount
		{
			get
			{
				return this.GetPropertyIntValue(6);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(6, value);
			}
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00091F9D File Offset: 0x0009019D
		public void RemoveParCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(6L);
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00091FB1 File Offset: 0x000901B1
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x00091FBA File Offset: 0x000901BA
		public int SlideCount
		{
			get
			{
				return this.GetPropertyIntValue(7);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(7, value);
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00091FCE File Offset: 0x000901CE
		public void RemoveSlideCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(7L);
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x00091FE2 File Offset: 0x000901E2
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x00091FEB File Offset: 0x000901EB
		public int NoteCount
		{
			get
			{
				return this.GetPropertyIntValue(8);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(8, value);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00091FFF File Offset: 0x000901FF
		public void RemoveNoteCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(8L);
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x00092013 File Offset: 0x00090213
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x0009201D File Offset: 0x0009021D
		public int HiddenCount
		{
			get
			{
				return this.GetPropertyIntValue(9);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.Sections[0]).SetProperty(9, value);
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00092038 File Offset: 0x00090238
		public void RemoveHiddenCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(9L);
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x0009204D File Offset: 0x0009024D
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x00092057 File Offset: 0x00090257
		public int MMClipCount
		{
			get
			{
				return this.GetPropertyIntValue(10);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(10, value);
			}
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x0009206C File Offset: 0x0009026C
		public void RemoveMMClipCount()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(10L);
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x00092081 File Offset: 0x00090281
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x0009208B File Offset: 0x0009028B
		public bool Scale
		{
			get
			{
				return this.GetPropertyBooleanValue(11);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(11, value);
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000920A0 File Offset: 0x000902A0
		public void RemoveScale()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(11L);
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x000920B5 File Offset: 0x000902B5
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x000920C4 File Offset: 0x000902C4
		public byte[] HeadingPair
		{
			get
			{
				return (byte[])this.GetProperty(12);
			}
			set
			{
				throw new global::System.NotImplementedException("Writing byte arrays ");
			}
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000920D0 File Offset: 0x000902D0
		public void RemoveHeadingPair()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(12L);
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x000920E5 File Offset: 0x000902E5
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x000920F4 File Offset: 0x000902F4
		public byte[] Docparts
		{
			get
			{
				return (byte[])this.GetProperty(13);
			}
			set
			{
				throw new global::System.NotImplementedException("Writing byte arrays");
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x00092100 File Offset: 0x00090300
		public void RemoveDocparts()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(13L);
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00092115 File Offset: 0x00090315
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x0009211F File Offset: 0x0009031F
		public string Manager
		{
			get
			{
				return base.GetPropertyStringValue(14);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(14, value);
			}
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00092134 File Offset: 0x00090334
		public void RemoveManager()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(14L);
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x00092149 File Offset: 0x00090349
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x00092153 File Offset: 0x00090353
		public string Company
		{
			get
			{
				return base.GetPropertyStringValue(15);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(15, value);
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x00092168 File Offset: 0x00090368
		public void RemoveCompany()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(15L);
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x0009217D File Offset: 0x0009037D
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00092187 File Offset: 0x00090387
		public bool LinksDirty
		{
			get
			{
				return this.GetPropertyBooleanValue(16);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(16, value);
			}
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0009219C File Offset: 0x0009039C
		public void RemoveLinksDirty()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty(16L);
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x000921B1 File Offset: 0x000903B1
		// (set) Token: 0x0600304E RID: 12366 RVA: 0x000921BE File Offset: 0x000903BE
		public int CharCountWithSpaces
		{
			get
			{
				return this.GetPropertyIntValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CCHWITHSPACES);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CCHWITHSPACES, value);
			}
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000921D6 File Offset: 0x000903D6
		public void RemoveCharCountWithSpaces()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CCHWITHSPACES);
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x000921EE File Offset: 0x000903EE
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x000921FB File Offset: 0x000903FB
		public bool HyperlinksChanged
		{
			get
			{
				return this.GetPropertyBooleanValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_HYPERLINKSCHANGED);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_HYPERLINKSCHANGED, value);
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00092213 File Offset: 0x00090413
		public void RemoveHyperlinksChanged()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_HYPERLINKSCHANGED);
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x0009222B File Offset: 0x0009042B
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x00092238 File Offset: 0x00090438
		public int ApplicationVersion
		{
			get
			{
				return this.GetPropertyIntValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_VERSION);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_VERSION, value);
			}
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00092250 File Offset: 0x00090450
		public void RemoveApplicationVersion()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_VERSION);
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x00092268 File Offset: 0x00090468
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x00092294 File Offset: 0x00090494
		public byte[] VBADigitalSignature
		{
			get
			{
				object property = this.GetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DIGSIG);
				if (property != null && property is byte[])
				{
					return (byte[])property;
				}
				return null;
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DIGSIG, value);
			}
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000922AC File Offset: 0x000904AC
		public void RemoveVBADigitalSignature()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DIGSIG);
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x000922C4 File Offset: 0x000904C4
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x000922D1 File Offset: 0x000904D1
		public string ContentType
		{
			get
			{
				return base.GetPropertyStringValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTTYPE);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTTYPE, value);
			}
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000922E9 File Offset: 0x000904E9
		public void RemoveContentType()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTTYPE);
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x00092301 File Offset: 0x00090501
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x0009230E File Offset: 0x0009050E
		public string ContentStatus
		{
			get
			{
				return base.GetPropertyStringValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTSTATUS);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTSTATUS, value);
			}
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x00092326 File Offset: 0x00090526
		public void RemoveContentStatus()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_CONTENTSTATUS);
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x0009233E File Offset: 0x0009053E
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x0009234B File Offset: 0x0009054B
		public string Language
		{
			get
			{
				return base.GetPropertyStringValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_LANGUAGE);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_LANGUAGE, value);
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00092363 File Offset: 0x00090563
		public void RemoveLanguage()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_LANGUAGE);
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0009237B File Offset: 0x0009057B
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00092388 File Offset: 0x00090588
		public string DocumentVersion
		{
			get
			{
				return base.GetPropertyStringValue(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DOCVERSION);
			}
			set
			{
				((global::NPOI.HPSF.MutableSection)this.FirstSection).SetProperty(global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DOCVERSION, value);
			}
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x000923A0 File Offset: 0x000905A0
		public void RemoveDocumentVersion()
		{
			((global::NPOI.HPSF.MutableSection)this.FirstSection).RemoveProperty((long)global::NPOI.HPSF.Wellknown.PropertyIDMap.PID_DOCVERSION);
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000923B8 File Offset: 0x000905B8
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x00092460 File Offset: 0x00090660
		public global::NPOI.HPSF.CustomProperties CustomProperties
		{
			get
			{
				global::NPOI.HPSF.CustomProperties customProperties = null;
				if (this.SectionCount >= 2)
				{
					customProperties = new global::NPOI.HPSF.CustomProperties();
					global::NPOI.HPSF.Section section = this.Sections[1];
					global::System.Collections.IDictionary dictionary = section.Dictionary;
					global::NPOI.HPSF.Property[] properties = section.Properties;
					int num = 0;
					foreach (global::NPOI.HPSF.Property property in properties)
					{
						long id = property.ID;
						if (id != 0L && id != 1L)
						{
							num++;
							global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(property, (string)dictionary[id]);
							customProperties.Put(customProperty.Name, customProperty);
						}
					}
					if (customProperties.Count != num)
					{
						customProperties.IsPure = false;
					}
				}
				return customProperties;
			}
			set
			{
				this.EnsureSection2();
				global::NPOI.HPSF.MutableSection mutableSection = (global::NPOI.HPSF.MutableSection)this.Sections[1];
				global::System.Collections.IDictionary dictionary = value.Dictionary;
				mutableSection.Clear();
				int num = value.Codepage;
				if (num < 0)
				{
					num = mutableSection.Codepage;
				}
				if (num < 0)
				{
					num = 1200;
				}
				value.Codepage = num;
				mutableSection.Codepage = num;
				mutableSection.Dictionary = dictionary;
				foreach (object obj in value.Values)
				{
					global::NPOI.HPSF.Property property = (global::NPOI.HPSF.Property)obj;
					mutableSection.SetProperty(property);
				}
			}
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x000924F0 File Offset: 0x000906F0
		private void EnsureSection2()
		{
			if (this.SectionCount < 2)
			{
				global::NPOI.HPSF.MutableSection mutableSection = new global::NPOI.HPSF.MutableSection();
				mutableSection.SetFormatID(global::NPOI.HPSF.Wellknown.SectionIDMap.DOCUMENT_SUMMARY_INFORMATION_ID2);
				this.AddSection(mutableSection);
			}
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0009251E File Offset: 0x0009071E
		public void RemoveCustomProperties()
		{
			if (this.SectionCount >= 2)
			{
				this.Sections.RemoveAt(1);
				return;
			}
			throw new global::NPOI.HPSF.HPSFRuntimeException("Illegal internal format of Document SummaryInformation stream: second section is missing.");
		}

		// Token: 0x04001587 RID: 5511
		public const string DEFAULT_STREAM_NAME = "\u0005DocumentSummaryInformation";
	}
}
