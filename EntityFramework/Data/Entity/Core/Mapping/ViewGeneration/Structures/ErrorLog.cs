using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A3 RID: 1443
	internal class ErrorLog : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004613 RID: 17939 RVA: 0x000F62F3 File Offset: 0x000F44F3
		internal ErrorLog()
		{
			this.m_log = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record>();
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x000F6306 File Offset: 0x000F4506
		internal int Count
		{
			get
			{
				return this.m_log.Count;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x000F6313 File Offset: 0x000F4513
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Errors
		{
			get
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record in this.m_log)
				{
					yield return record.Error;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000F6323 File Offset: 0x000F4523
		internal void AddEntry(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record)
		{
			this.m_log.Add(record);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000F6334 File Offset: 0x000F4534
		internal void Merge(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog log)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record item in log.m_log)
			{
				this.m_log.Add(item);
			}
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x000F638C File Offset: 0x000F458C
		internal void PrintTrace()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ToCompactString(stringBuilder);
			global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(stringBuilder.ToString());
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x000F63B4 File Offset: 0x000F45B4
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record in this.m_log)
			{
				record.ToCompactString(builder);
			}
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x000F6408 File Offset: 0x000F4608
		internal string ToUserString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record in this.m_log)
			{
				string value = record.ToUserString();
				stringBuilder.AppendLine(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400190C RID: 6412
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record> m_log;

		// Token: 0x02000BCC RID: 3020
		internal class Record : global::System.Data.Entity.Core.Common.Utils.InternalBase
		{
			// Token: 0x0600681B RID: 26651 RVA: 0x00162234 File Offset: 0x00160434
			internal Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, string message, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappers, string debugMessage)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> inputCellsForWrappers = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.GetInputCellsForWrappers(wrappers);
				this.Init(errorCode, message, inputCellsForWrappers, debugMessage);
			}

			// Token: 0x0600681C RID: 26652 RVA: 0x00162259 File Offset: 0x00160459
			internal Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, string message, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell sourceCell, string debugMessage)
			{
				this.Init(errorCode, message, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell[]
				{
					sourceCell
				}, debugMessage);
			}

			// Token: 0x0600681D RID: 26653 RVA: 0x00162275 File Offset: 0x00160475
			internal Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, string message, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> sourceCells, string debugMessage)
			{
				this.Init(errorCode, message, sourceCells, debugMessage);
			}

			// Token: 0x0600681E RID: 26654 RVA: 0x00162288 File Offset: 0x00160488
			internal Record(global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError error)
			{
				this.m_debugMessage = error.ToString();
				this.m_mappingError = error;
			}

			// Token: 0x0600681F RID: 26655 RVA: 0x001622A4 File Offset: 0x001604A4
			private void Init(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, string message, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> sourceCells, string debugMessage)
			{
				this.m_sourceCells = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(sourceCells);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel cellLabel = this.m_sourceCells[0].CellLabel;
				string sourceLocation = cellLabel.SourceLocation;
				int startLineNumber = cellLabel.StartLineNumber;
				int startLinePosition = cellLabel.StartLinePosition;
				string message2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record.InternalToString(message, debugMessage, this.m_sourceCells, errorCode, false);
				this.m_debugMessage = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record.InternalToString(message, debugMessage, this.m_sourceCells, errorCode, true);
				this.m_mappingError = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(message2, (int)errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceLocation, startLineNumber, startLinePosition);
			}

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x06006820 RID: 26656 RVA: 0x0016231A File Offset: 0x0016051A
			internal global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError Error
			{
				get
				{
					return this.m_mappingError;
				}
			}

			// Token: 0x06006821 RID: 26657 RVA: 0x00162322 File Offset: 0x00160522
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append(this.m_debugMessage);
			}

			// Token: 0x06006822 RID: 26658 RVA: 0x00162334 File Offset: 0x00160534
			private static void GetUserLinesFromCells(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> sourceCells, global::System.Text.StringBuilder lineBuilder, bool isInvariant)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> enumerable = sourceCells.OrderBy((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell) => cell.CellLabel.StartLineNumber, global::System.Collections.Generic.Comparer<int>.Default);
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in enumerable)
				{
					if (!flag)
					{
						lineBuilder.Append(isInvariant ? global::System.Data.Entity.Resources.EntityRes.GetString("ViewGen_CommaBlank") : ", ");
					}
					flag = false;
					lineBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
					{
						cell2.CellLabel.StartLineNumber
					});
				}
			}

			// Token: 0x06006823 RID: 26659 RVA: 0x001623EC File Offset: 0x001605EC
			private static string InternalToString(string message, string debugMessage, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> sourceCells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode errorCode, bool isInvariant)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				if (isInvariant)
				{
					stringBuilder.AppendLine(debugMessage);
					stringBuilder.Append(isInvariant ? "ERROR" : global::System.Data.Entity.Resources.Strings.ViewGen_Error);
					global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(stringBuilder, " ({0}): ", new object[]
					{
						(int)errorCode
					});
				}
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record.GetUserLinesFromCells(sourceCells, stringBuilder2, isInvariant);
				if (isInvariant)
				{
					if (sourceCells.Count > 1)
					{
						global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(stringBuilder, "Problem in Mapping Fragments starting at lines {0}: ", new object[]
						{
							stringBuilder2.ToString()
						});
					}
					else
					{
						global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(stringBuilder, "Problem in Mapping Fragment starting at line {0}: ", new object[]
						{
							stringBuilder2.ToString()
						});
					}
				}
				else if (sourceCells.Count > 1)
				{
					stringBuilder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_ErrorLog2(stringBuilder2.ToString()));
				}
				else
				{
					stringBuilder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_ErrorLog(stringBuilder2.ToString()));
				}
				stringBuilder.AppendLine(message);
				return stringBuilder.ToString();
			}

			// Token: 0x06006824 RID: 26660 RVA: 0x001624D0 File Offset: 0x001606D0
			internal string ToUserString()
			{
				return this.m_mappingError.ToString();
			}

			// Token: 0x04002EC4 RID: 11972
			private global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError m_mappingError;

			// Token: 0x04002EC5 RID: 11973
			private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> m_sourceCells;

			// Token: 0x04002EC6 RID: 11974
			private string m_debugMessage;
		}
	}
}
