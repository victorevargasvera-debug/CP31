using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x0200000E RID: 14
	public abstract class MathContainer : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00004363 File Offset: 0x00002563
		public MathContainer(global::NPOI.OpenXmlFormats.Shared.IOMathContainer c, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.container = c;
			this.parent = p;
			this.document = p.Document;
			this.FillLists(c.Items);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004391 File Offset: 0x00002591
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.document;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004399 File Offset: 0x00002599
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000043A8 File Offset: 0x000025A8
		private void FillLists(global::System.Collections.ArrayList items)
		{
			this.runs = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSharedRun>();
			this.accs = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFAcc>();
			this.naries = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFNary>();
			this.sSubs = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSSub>();
			this.sSups = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSSup>();
			this.fs = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFF>();
			this.rads = new global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFRad>();
			this.BuildListsInOrderFromXml(items);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000440C File Offset: 0x0000260C
		private void BuildListsInOrderFromXml(global::System.Collections.ArrayList items)
		{
			foreach (object obj in items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_R)
				{
					this.runs.Add(new global::NPOI.XWPF.Usermodel.XWPFSharedRun(obj as global::NPOI.OpenXmlFormats.Shared.CT_R, this));
				}
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Acc)
				{
					this.accs.Add(new global::NPOI.XWPF.Usermodel.XWPFAcc(obj as global::NPOI.OpenXmlFormats.Shared.CT_Acc, this));
				}
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Nary)
				{
					this.naries.Add(new global::NPOI.XWPF.Usermodel.XWPFNary(obj as global::NPOI.OpenXmlFormats.Shared.CT_Nary, this));
				}
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SSub)
				{
					this.sSubs.Add(new global::NPOI.XWPF.Usermodel.XWPFSSub(obj as global::NPOI.OpenXmlFormats.Shared.CT_SSub, this));
				}
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_F)
				{
					this.fs.Add(new global::NPOI.XWPF.Usermodel.XWPFF(obj as global::NPOI.OpenXmlFormats.Shared.CT_F, this));
				}
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Rad)
				{
					this.rads.Add(new global::NPOI.XWPF.Usermodel.XWPFRad(obj as global::NPOI.OpenXmlFormats.Shared.CT_Rad, this));
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004514 File Offset: 0x00002714
		public global::NPOI.XWPF.Usermodel.XWPFSharedRun CreateRun()
		{
			global::NPOI.XWPF.Usermodel.XWPFSharedRun xwpfsharedRun = new global::NPOI.XWPF.Usermodel.XWPFSharedRun(this.container.AddNewR(), this);
			this.runs.Add(xwpfsharedRun);
			return xwpfsharedRun;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004540 File Offset: 0x00002740
		public global::NPOI.XWPF.Usermodel.XWPFAcc CreateAcc()
		{
			global::NPOI.XWPF.Usermodel.XWPFAcc xwpfacc = new global::NPOI.XWPF.Usermodel.XWPFAcc(this.container.AddNewAcc(), this);
			this.accs.Add(xwpfacc);
			return xwpfacc;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000456C File Offset: 0x0000276C
		public global::NPOI.XWPF.Usermodel.XWPFNary CreateNary()
		{
			global::NPOI.XWPF.Usermodel.XWPFNary xwpfnary = new global::NPOI.XWPF.Usermodel.XWPFNary(this.container.AddNewNary(), this);
			this.naries.Add(xwpfnary);
			return xwpfnary;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004598 File Offset: 0x00002798
		public global::NPOI.XWPF.Usermodel.XWPFSSub CreateSSub()
		{
			global::NPOI.XWPF.Usermodel.XWPFSSub xwpfssub = new global::NPOI.XWPF.Usermodel.XWPFSSub(this.container.AddNewSSub(), this);
			this.sSubs.Add(xwpfssub);
			return xwpfssub;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000045C4 File Offset: 0x000027C4
		public global::NPOI.XWPF.Usermodel.XWPFSSup CreateSSup()
		{
			global::NPOI.XWPF.Usermodel.XWPFSSup xwpfssup = new global::NPOI.XWPF.Usermodel.XWPFSSup(this.container.AddNewSSup(), this);
			this.sSups.Add(xwpfssup);
			return xwpfssup;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000045F0 File Offset: 0x000027F0
		public global::NPOI.XWPF.Usermodel.XWPFF CreateF()
		{
			global::NPOI.XWPF.Usermodel.XWPFF xwpff = new global::NPOI.XWPF.Usermodel.XWPFF(this.container.AddNewF(), this);
			this.fs.Add(xwpff);
			return xwpff;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000461C File Offset: 0x0000281C
		public global::NPOI.XWPF.Usermodel.XWPFRad CreateRad()
		{
			global::NPOI.XWPF.Usermodel.XWPFRad xwpfrad = new global::NPOI.XWPF.Usermodel.XWPFRad(this.container.AddNewRad(), this);
			this.rads.Add(xwpfrad);
			return xwpfrad;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004648 File Offset: 0x00002848
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFSharedRun> Runs
		{
			get
			{
				return this.runs.AsReadOnly();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00004655 File Offset: 0x00002855
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFAcc> Accs
		{
			get
			{
				return this.accs.AsReadOnly();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004662 File Offset: 0x00002862
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFNary> Naries
		{
			get
			{
				return this.naries.AsReadOnly();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000466F File Offset: 0x0000286F
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFSSub> SSubs
		{
			get
			{
				return this.sSubs.AsReadOnly();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000467C File Offset: 0x0000287C
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFF> Fs
		{
			get
			{
				return this.fs.AsReadOnly();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004689 File Offset: 0x00002889
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.Usermodel.XWPFRad> Rads
		{
			get
			{
				return this.rads.AsReadOnly();
			}
		}

		// Token: 0x04000024 RID: 36
		protected global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000025 RID: 37
		protected global::NPOI.XWPF.UserModel.XWPFDocument document;

		// Token: 0x04000026 RID: 38
		protected global::NPOI.OpenXmlFormats.Shared.IOMathContainer container;

		// Token: 0x04000027 RID: 39
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSharedRun> runs;

		// Token: 0x04000028 RID: 40
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFNary> naries;

		// Token: 0x04000029 RID: 41
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFAcc> accs;

		// Token: 0x0400002A RID: 42
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSSub> sSubs;

		// Token: 0x0400002B RID: 43
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFSSup> sSups;

		// Token: 0x0400002C RID: 44
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFF> fs;

		// Token: 0x0400002D RID: 45
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.Usermodel.XWPFRad> rads;
	}
}
