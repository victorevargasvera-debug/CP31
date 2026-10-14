using System;
using System.Collections.Generic;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000040 RID: 64
	public class XWPFNumbering : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00008436 File Offset: 0x00006636
		public XWPFNumbering(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.isNew = true;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000845C File Offset: 0x0000665C
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFNumbering(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008465 File Offset: 0x00006665
		public XWPFNumbering()
		{
			this.abstractNums = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFAbstractNum>();
			this.nums = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFNum>();
			this.isNew = true;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000084A0 File Offset: 0x000066A0
		internal override void OnDocumentRead()
		{
			global::System.IO.Stream inputStream = base.GetPackagePart().GetInputStream();
			try
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument numberingDocument = global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(inputStream), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.ctNumbering = numberingDocument.Numbering;
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctNum in this.ctNumbering.GetNumList())
				{
					this.nums.Add(new global::NPOI.XWPF.UserModel.XWPFNum(ctNum, this));
				}
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum ctAbstractNum in this.ctNumbering.GetAbstractNumList())
				{
					this.abstractNums.Add(new global::NPOI.XWPF.UserModel.XWPFAbstractNum(ctAbstractNum, this));
				}
				this.isNew = false;
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			finally
			{
				if (inputStream != null)
				{
					inputStream.Close();
				}
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000085AC File Offset: 0x000067AC
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			new global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument(this.ctNumbering).Save(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000085DC File Offset: 0x000067DC
		public void SetNumbering(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering numbering)
		{
			this.ctNumbering = numbering;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000085E8 File Offset: 0x000067E8
		public bool NumExist(string numID)
		{
			using (global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFNum>.Enumerator enumerator = this.nums.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetCTNum().numId.Equals(numID))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000864C File Offset: 0x0000684C
		public string AddNum(global::NPOI.XWPF.UserModel.XWPFNum num)
		{
			this.ctNumbering.AddNewNum();
			int pos = this.ctNumbering.GetNumList().Count - 1;
			this.ctNumbering.SetNumArray(pos, num.GetCTNum());
			this.nums.Add(num);
			return num.GetCTNum().numId;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000086A4 File Offset: 0x000068A4
		public string AddNum(string abstractNumID)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num = this.ctNumbering.AddNewNum();
			ct_Num.AddNewAbstractNumId();
			ct_Num.abstractNumId.val = abstractNumID;
			ct_Num.numId = (this.nums.Count + 1).ToString();
			global::NPOI.XWPF.UserModel.XWPFNum item = new global::NPOI.XWPF.UserModel.XWPFNum(ct_Num, this);
			this.nums.Add(item);
			return ct_Num.numId;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008704 File Offset: 0x00006904
		public void AddNum(string abstractNumID, string numID)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ct_Num = this.ctNumbering.AddNewNum();
			ct_Num.AddNewAbstractNumId();
			ct_Num.abstractNumId.val = abstractNumID;
			ct_Num.numId = numID;
			global::NPOI.XWPF.UserModel.XWPFNum item = new global::NPOI.XWPF.UserModel.XWPFNum(ct_Num, this);
			this.nums.Add(item);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000874C File Offset: 0x0000694C
		public global::NPOI.XWPF.UserModel.XWPFNum GetNum(string numID)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFNum xwpfnum in this.nums)
			{
				if (xwpfnum.GetCTNum().numId.Equals(numID))
				{
					return xwpfnum;
				}
			}
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000087B4 File Offset: 0x000069B4
		public global::NPOI.XWPF.UserModel.XWPFAbstractNum GetAbstractNum(string abstractNumID)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFAbstractNum xwpfabstractNum in this.abstractNums)
			{
				if (xwpfabstractNum.GetAbstractNum().abstractNumId.Equals(abstractNumID))
				{
					return xwpfabstractNum;
				}
			}
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000881C File Offset: 0x00006A1C
		public string GetIdOfAbstractNum(global::NPOI.XWPF.UserModel.XWPFAbstractNum abstractNum)
		{
			global::NPOI.XWPF.UserModel.XWPFAbstractNum xwpfabstractNum = new global::NPOI.XWPF.UserModel.XWPFAbstractNum(abstractNum.GetCTAbstractNum().Copy(), this);
			for (int i = 0; i < this.abstractNums.Count; i++)
			{
				xwpfabstractNum.GetCTAbstractNum().abstractNumId = i.ToString();
				xwpfabstractNum.SetNumbering(this);
				if (xwpfabstractNum.GetCTAbstractNum().ValueEquals(this.abstractNums[i].GetCTAbstractNum()))
				{
					return xwpfabstractNum.GetCTAbstractNum().abstractNumId;
				}
			}
			return null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00008898 File Offset: 0x00006A98
		public string AddAbstractNum(global::NPOI.XWPF.UserModel.XWPFAbstractNum abstractNum)
		{
			int count = this.abstractNums.Count;
			if (abstractNum.GetAbstractNum() != null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_AbstractNum abstractNum2 = abstractNum.GetAbstractNum();
				abstractNum2.abstractNumId = count.ToString();
				this.ctNumbering.AddNewAbstractNum().Set(abstractNum2);
			}
			else
			{
				this.ctNumbering.AddNewAbstractNum();
				abstractNum.GetAbstractNum().abstractNumId = count.ToString();
				this.ctNumbering.SetAbstractNumArray(count, abstractNum.GetAbstractNum());
			}
			this.abstractNums.Add(abstractNum);
			return abstractNum.GetAbstractNum().abstractNumId;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00008928 File Offset: 0x00006B28
		public string AddAbstractNum()
		{
			global::NPOI.XWPF.UserModel.XWPFAbstractNum xwpfabstractNum = new global::NPOI.XWPF.UserModel.XWPFAbstractNum(this.ctNumbering.AddNewAbstractNum(), this);
			xwpfabstractNum.AbstractNumId = this.abstractNums.Count.ToString();
			xwpfabstractNum.MultiLevelType = global::NPOI.XWPF.UserModel.MultiLevelType.HybridMultilevel;
			xwpfabstractNum.InitLvl();
			this.abstractNums.Add(xwpfabstractNum);
			return xwpfabstractNum.GetAbstractNum().abstractNumId;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00008984 File Offset: 0x00006B84
		public bool RemoveAbstractNum(string abstractNumID)
		{
			if (int.Parse(abstractNumID) < this.abstractNums.Count)
			{
				this.ctNumbering.RemoveAbstractNum(int.Parse(abstractNumID));
				this.abstractNums.RemoveAt(int.Parse(abstractNumID));
				return true;
			}
			return false;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000089C0 File Offset: 0x00006BC0
		public string GetAbstractNumID(string numID)
		{
			global::NPOI.XWPF.UserModel.XWPFNum num = this.GetNum(numID);
			if (num == null)
			{
				return null;
			}
			if (num.GetCTNum() == null)
			{
				return null;
			}
			if (num.GetCTNum().abstractNumId == null)
			{
				return null;
			}
			return num.GetCTNum().abstractNumId.val;
		}

		// Token: 0x040001E0 RID: 480
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFAbstractNum> abstractNums = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFAbstractNum>();

		// Token: 0x040001E1 RID: 481
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFNum> nums = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFNum>();

		// Token: 0x040001E2 RID: 482
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering ctNumbering;

		// Token: 0x040001E3 RID: 483
		private bool isNew;
	}
}
