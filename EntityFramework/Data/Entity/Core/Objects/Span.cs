using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Text;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000431 RID: 1073
	internal sealed class Span
	{
		// Token: 0x06003445 RID: 13381 RVA: 0x000A7CB7 File Offset: 0x000A5EB7
		internal Span()
		{
			this._spanList = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Span.SpanPath>();
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x000A7CCA File Offset: 0x000A5ECA
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Span.SpanPath> SpanList
		{
			get
			{
				return this._spanList;
			}
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000A7CD2 File Offset: 0x000A5ED2
		internal static bool RequiresRelationshipSpan(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			return mergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x000A7CDB File Offset: 0x000A5EDB
		internal static global::System.Data.Entity.Core.Objects.Span IncludeIn(global::System.Data.Entity.Core.Objects.Span spanToIncludeIn, string pathToInclude)
		{
			if (spanToIncludeIn == null)
			{
				spanToIncludeIn = new global::System.Data.Entity.Core.Objects.Span();
			}
			spanToIncludeIn.Include(pathToInclude);
			return spanToIncludeIn;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000A7CF0 File Offset: 0x000A5EF0
		internal static global::System.Data.Entity.Core.Objects.Span CopyUnion(global::System.Data.Entity.Core.Objects.Span span1, global::System.Data.Entity.Core.Objects.Span span2)
		{
			if (span1 == null)
			{
				return span2;
			}
			if (span2 == null)
			{
				return span1;
			}
			global::System.Data.Entity.Core.Objects.Span span3 = span1.Clone();
			foreach (global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath in span2.SpanList)
			{
				span3.AddSpanPath(spanPath);
			}
			return span3;
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x000A7D58 File Offset: 0x000A5F58
		internal string GetCacheKey()
		{
			if (this._cacheKey == null && this._spanList.Count > 0)
			{
				if (this._spanList.Count == 1 && this._spanList[0].Navigations.Count == 1)
				{
					this._cacheKey = this._spanList[0].Navigations[0];
				}
				else
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					for (int i = 0; i < this._spanList.Count; i++)
					{
						if (i > 0)
						{
							stringBuilder.Append(";");
						}
						global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath = this._spanList[i];
						stringBuilder.Append(spanPath.Navigations[0]);
						for (int j = 1; j < spanPath.Navigations.Count; j++)
						{
							stringBuilder.Append(".");
							stringBuilder.Append(spanPath.Navigations[j]);
						}
					}
					this._cacheKey = stringBuilder.ToString();
				}
			}
			return this._cacheKey;
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000A7E60 File Offset: 0x000A6060
		public void Include(string path)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath = new global::System.Data.Entity.Core.Objects.Span.SpanPath(global::System.Data.Entity.Core.Objects.Span.ParsePath(path));
			this.AddSpanPath(spanPath);
			this._cacheKey = null;
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x000A7E93 File Offset: 0x000A6093
		internal global::System.Data.Entity.Core.Objects.Span Clone()
		{
			global::System.Data.Entity.Core.Objects.Span span = new global::System.Data.Entity.Core.Objects.Span();
			span.SpanList.AddRange(this._spanList);
			span._cacheKey = this._cacheKey;
			return span;
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000A7EB7 File Offset: 0x000A60B7
		internal void AddSpanPath(global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath)
		{
			if (this.ValidateSpanPath(spanPath))
			{
				this.RemoveExistingSubPaths(spanPath);
				this._spanList.Add(spanPath);
			}
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		private bool ValidateSpanPath(global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath)
		{
			for (int i = 0; i < this._spanList.Count; i++)
			{
				if (spanPath.IsSubPath(this._spanList[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000A7F14 File Offset: 0x000A6114
		private void RemoveExistingSubPaths(global::System.Data.Entity.Core.Objects.Span.SpanPath spanPath)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Span.SpanPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Span.SpanPath>();
			for (int i = 0; i < this._spanList.Count; i++)
			{
				if (this._spanList[i].IsSubPath(spanPath))
				{
					list.Add(this._spanList[i]);
				}
			}
			foreach (global::System.Data.Entity.Core.Objects.Span.SpanPath item in list)
			{
				this._spanList.Remove(item);
			}
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000A7FAC File Offset: 0x000A61AC
		private static global::System.Collections.Generic.List<string> ParsePath(string path)
		{
			global::System.Collections.Generic.List<string> list = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.ParseMultipartIdentifier(path, "[", "]", '.');
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i] == null)
				{
					list.RemoveAt(i);
				}
				else if (list[i].Length == 0)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectQuery_Span_SpanPathSyntaxError);
				}
			}
			return list;
		}

		// Token: 0x040010DE RID: 4318
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Span.SpanPath> _spanList;

		// Token: 0x040010DF RID: 4319
		private string _cacheKey;

		// Token: 0x02000A3F RID: 2623
		internal class SpanPath
		{
			// Token: 0x06006180 RID: 24960 RVA: 0x0014EB67 File Offset: 0x0014CD67
			public SpanPath(global::System.Collections.Generic.List<string> navigations)
			{
				this.Navigations = navigations;
			}

			// Token: 0x06006181 RID: 24961 RVA: 0x0014EB78 File Offset: 0x0014CD78
			public bool IsSubPath(global::System.Data.Entity.Core.Objects.Span.SpanPath rhs)
			{
				if (this.Navigations.Count > rhs.Navigations.Count)
				{
					return false;
				}
				for (int i = 0; i < this.Navigations.Count; i++)
				{
					if (!this.Navigations[i].Equals(rhs.Navigations[i], global::System.StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x04002A2A RID: 10794
			public readonly global::System.Collections.Generic.List<string> Navigations;
		}
	}
}
