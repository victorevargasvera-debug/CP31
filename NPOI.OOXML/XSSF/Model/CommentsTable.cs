using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E1 RID: 225
	public class CommentsTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x0003049D File Offset: 0x0002E69D
		public CommentsTable()
		{
			this.comments = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments();
			this.comments.AddNewCommentList();
			this.comments.AddNewAuthors().AddAuthor(global::NPOI.XSSF.Model.CommentsTable.DEFAULT_AUTHOR);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000304D0 File Offset: 0x0002E6D0
		internal CommentsTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000304E5 File Offset: 0x0002E6E5
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public CommentsTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000304F0 File Offset: 0x0002E6F0
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument commentsDocument = global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.comments = commentsDocument.GetComments();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00030538 File Offset: 0x0002E738
		public void WriteTo(global::System.IO.Stream out1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument commentsDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument();
			commentsDocument.SetComments(this.comments);
			commentsDocument.Save(out1);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00030554 File Offset: 0x0002E754
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003057A File Offset: 0x0002E77A
		[global::System.Obsolete("2015-11-23 (circa POI 3.14beta1). Use {@link #referenceUpdated(CellAddress, CTComment)} instead")]
		public void ReferenceUpdated(string oldReference, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment comment)
		{
			this.ReferenceUpdated(new global::NPOI.SS.Util.CellAddress(oldReference), comment);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00030589 File Offset: 0x0002E789
		public void ReferenceUpdated(global::NPOI.SS.Util.CellAddress oldReference, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment comment)
		{
			if (this.commentRefs != null)
			{
				this.commentRefs.Remove(oldReference);
				this.commentRefs[new global::NPOI.SS.Util.CellAddress(comment.@ref)] = comment;
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000305B7 File Offset: 0x0002E7B7
		public int GetNumberOfComments()
		{
			return this.comments.commentList.SizeOfCommentArray();
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000305C9 File Offset: 0x0002E7C9
		public int GetNumberOfAuthors()
		{
			return this.comments.authors.SizeOfAuthorArray();
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000305DB File Offset: 0x0002E7DB
		public string GetAuthor(long authorId)
		{
			return this.comments.authors.GetAuthorArray((int)authorId);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000305F0 File Offset: 0x0002E7F0
		public int FindAuthor(string author)
		{
			for (int i = 0; i < this.comments.authors.SizeOfAuthorArray(); i++)
			{
				if (this.comments.authors.GetAuthorArray(i).Equals(author))
				{
					return i;
				}
			}
			return this.AddNewAuthor(author);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003063A File Offset: 0x0002E83A
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #findCellComment(CellAddress)} instead")]
		public global::NPOI.XSSF.UserModel.XSSFComment FindCellComment(string cellRef)
		{
			return this.FindCellComment(new global::NPOI.SS.Util.CellAddress(cellRef));
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00030648 File Offset: 0x0002E848
		public global::NPOI.XSSF.UserModel.XSSFComment FindCellComment(global::NPOI.SS.Util.CellAddress cellAddress)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ctcomment = this.GetCTComment(cellAddress);
			if (ctcomment != null)
			{
				return new global::NPOI.XSSF.UserModel.XSSFComment(this, ctcomment, null);
			}
			return null;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0003066A File Offset: 0x0002E86A
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link CommentsTable#getCTComment(CellAddress)} instead")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment GetCTComment(string ref1)
		{
			return this.GetCTComment(new global::NPOI.SS.Util.CellAddress(ref1));
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00030678 File Offset: 0x0002E878
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment GetCTComment(global::NPOI.SS.Util.CellAddress cellRef)
		{
			this.PrepareCTCommentCache();
			if (this.commentRefs.ContainsKey(cellRef))
			{
				return this.commentRefs[cellRef];
			}
			return null;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0003069C File Offset: 0x0002E89C
		public global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> GetCellComments()
		{
			this.PrepareCTCommentCache();
			global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.SS.Util.CellAddress, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment> keyValuePair in this.commentRefs)
			{
				dictionary.Add(keyValuePair.Key, new global::NPOI.XSSF.UserModel.XSSFComment(this, keyValuePair.Value, null));
			}
			return dictionary;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00030710 File Offset: 0x0002E910
		private void PrepareCTCommentCache()
		{
			if (this.commentRefs == null)
			{
				this.commentRefs = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment>();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment in this.comments.commentList.GetCommentArray())
				{
					this.commentRefs.Add(new global::NPOI.SS.Util.CellAddress(ct_Comment.@ref), ct_Comment);
				}
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0003076A File Offset: 0x0002E96A
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #newComment(CellAddress)} instead")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment NewComment(string ref1)
		{
			return this.NewComment(new global::NPOI.SS.Util.CellAddress(ref1));
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00030778 File Offset: 0x0002E978
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment NewComment(global::NPOI.SS.Util.CellAddress ref1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment = this.comments.commentList.AddNewComment();
			ct_Comment.@ref = ref1.FormatAsString();
			ct_Comment.authorId = (uint)global::NPOI.XSSF.Model.CommentsTable.DEFAULT_AUTHOR_ID;
			if (this.commentRefs != null)
			{
				this.commentRefs.Add(ref1, ct_Comment);
			}
			return ct_Comment;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000307C3 File Offset: 0x0002E9C3
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #removeComment(CellAddress)} instead")]
		public bool RemoveComment(string cellRef)
		{
			return this.RemoveComment(new global::NPOI.SS.Util.CellAddress(cellRef));
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000307D4 File Offset: 0x0002E9D4
		public bool RemoveComment(global::NPOI.SS.Util.CellAddress cellRef)
		{
			string text = cellRef.FormatAsString();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList commentList = this.comments.commentList;
			if (commentList != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment[] commentArray = commentList.GetCommentArray();
				for (int i = 0; i < commentArray.Length; i++)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment = commentArray[i];
					if (text.Equals(ct_Comment.@ref))
					{
						commentList.RemoveComment(i);
						if (this.commentRefs != null)
						{
							this.commentRefs.Remove(cellRef);
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00030840 File Offset: 0x0002EA40
		private int AddNewAuthor(string author)
		{
			int num = this.comments.authors.SizeOfAuthorArray();
			this.comments.authors.Insert(num, author);
			return num;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00030871 File Offset: 0x0002EA71
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments GetCTComments()
		{
			return this.comments;
		}

		// Token: 0x04000417 RID: 1047
		public static string DEFAULT_AUTHOR = "";

		// Token: 0x04000418 RID: 1048
		public static int DEFAULT_AUTHOR_ID = 0;

		// Token: 0x04000419 RID: 1049
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments comments;

		// Token: 0x0400041A RID: 1050
		private global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment> commentRefs;
	}
}
