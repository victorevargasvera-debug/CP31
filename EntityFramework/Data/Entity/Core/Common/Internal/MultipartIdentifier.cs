using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Common.Internal
{
	// Token: 0x02000632 RID: 1586
	internal static class MultipartIdentifier
	{
		// Token: 0x06004C6F RID: 19567 RVA: 0x0010C5D2 File Offset: 0x0010A7D2
		private static void IncrementStringCount(global::System.Collections.Generic.List<string> ary, ref int position)
		{
			position++;
			ary.Add(string.Empty);
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x0010C5E5 File Offset: 0x0010A7E5
		private static bool IsWhitespace(char ch)
		{
			return char.IsWhiteSpace(ch);
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x0010C5F0 File Offset: 0x0010A7F0
		internal static global::System.Collections.Generic.List<string> ParseMultipartIdentifier(string name, string leftQuote, string rightQuote, char separator)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(null);
			int index = 0;
			global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(name.Length);
			global::System.Text.StringBuilder stringBuilder2 = null;
			char c = ' ';
			foreach (char c2 in name)
			{
				switch (mpistate)
				{
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value:
					if (!global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IsWhitespace(c2))
					{
						int index2;
						if (c2 == separator)
						{
							list[index] = string.Empty;
							global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IncrementStringCount(list, ref index);
						}
						else if (-1 != (index2 = leftQuote.IndexOf(c2)))
						{
							c = rightQuote[index2];
							stringBuilder.Length = 0;
							mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseQuote;
						}
						else
						{
							if (-1 != rightQuote.IndexOf(c2))
							{
								throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
							}
							stringBuilder.Length = 0;
							stringBuilder.Append(c2);
							mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseNonQuote;
						}
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseNonQuote:
					if (c2 == separator)
					{
						list[index] = stringBuilder.ToString();
						global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IncrementStringCount(list, ref index);
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value;
					}
					else
					{
						if (-1 != rightQuote.IndexOf(c2))
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
						}
						if (-1 != leftQuote.IndexOf(c2))
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
						}
						if (global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IsWhitespace(c2))
						{
							list[index] = stringBuilder.ToString();
							if (stringBuilder2 == null)
							{
								stringBuilder2 = new global::System.Text.StringBuilder();
							}
							stringBuilder2.Length = 0;
							stringBuilder2.Append(c2);
							mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForNextCharOrSeparator;
						}
						else
						{
							stringBuilder.Append(c2);
						}
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForSeparator:
					if (!global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IsWhitespace(c2))
					{
						if (c2 != separator)
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
						}
						global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IncrementStringCount(list, ref index);
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value;
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForNextCharOrSeparator:
					if (!global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IsWhitespace(c2))
					{
						if (c2 == separator)
						{
							global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IncrementStringCount(list, ref index);
							mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value;
						}
						else
						{
							stringBuilder.Append(stringBuilder2);
							stringBuilder.Append(c2);
							list[index] = stringBuilder.ToString();
							mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseNonQuote;
						}
					}
					else
					{
						stringBuilder2.Append(c2);
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseQuote:
					if (c2 == c)
					{
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_RightQuote;
					}
					else
					{
						stringBuilder.Append(c2);
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_RightQuote:
					if (c2 == c)
					{
						stringBuilder.Append(c2);
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseQuote;
					}
					else if (c2 == separator)
					{
						list[index] = stringBuilder.ToString();
						global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IncrementStringCount(list, ref index);
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value;
					}
					else
					{
						if (!global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.IsWhitespace(c2))
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
						}
						list[index] = stringBuilder.ToString();
						mpistate = global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForSeparator;
					}
					break;
				}
			}
			switch (mpistate)
			{
			case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_Value:
			case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForSeparator:
			case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_LookForNextCharOrSeparator:
				return list;
			case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_ParseNonQuote:
			case global::System.Data.Entity.Core.Common.Internal.MultipartIdentifier.MPIState.MPI_RightQuote:
				list[index] = stringBuilder.ToString();
				return list;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidMultipartNameDelimiterUsage, "path");
		}

		// Token: 0x04001AD6 RID: 6870
		private const int MaxParts = 4;

		// Token: 0x04001AD7 RID: 6871
		internal const int ServerIndex = 0;

		// Token: 0x04001AD8 RID: 6872
		internal const int CatalogIndex = 1;

		// Token: 0x04001AD9 RID: 6873
		internal const int SchemaIndex = 2;

		// Token: 0x04001ADA RID: 6874
		internal const int TableIndex = 3;

		// Token: 0x02000C5C RID: 3164
		private enum MPIState
		{
			// Token: 0x040030ED RID: 12525
			MPI_Value,
			// Token: 0x040030EE RID: 12526
			MPI_ParseNonQuote,
			// Token: 0x040030EF RID: 12527
			MPI_LookForSeparator,
			// Token: 0x040030F0 RID: 12528
			MPI_LookForNextCharOrSeparator,
			// Token: 0x040030F1 RID: 12529
			MPI_ParseQuote,
			// Token: 0x040030F2 RID: 12530
			MPI_RightQuote
		}
	}
}
