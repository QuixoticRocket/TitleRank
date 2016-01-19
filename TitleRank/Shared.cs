using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleRank
{
    internal static class Shared
    {
        internal static readonly string idSeparator = ".";
        internal static readonly string httpColonWhackWhack = "http://";
        internal static readonly string httpsColonWhackWhack = "https://";
        internal static readonly char Whack = '/';
        internal static readonly string OrphanId = "Orphan Row";
        internal static readonly int inputFieldCountPerRow = 2;
        internal static readonly int TitleFieldNumber = 0;
        internal static readonly int UrlFieldNumber = 1;

        private static readonly string ParentMismatchExceptionMessageStringFormat = "Node is already the child of another Parent" + Environment.NewLine + "Row number: {0} | existing parent row number {1} | new parent row number {2}";
        private static readonly string MalformedRowErrorTextStringFormat = "Row number {0} is malformed. Expected {1} fields but found {2}";

        internal static string GetParentMismatchExceptionMessageStringFormat(int childRowNumber, int existingParentRowNumber, int newParentRowNumber)
        {
            return string.Format(ParentMismatchExceptionMessageStringFormat, childRowNumber, existingParentRowNumber, newParentRowNumber);
        }

        internal static string GetMalformedRowErrorText(int rownumber, int foundfieldcount)
        {
            return string.Format(MalformedRowErrorTextStringFormat, rownumber, inputFieldCountPerRow, foundfieldcount);
        }
    }
}
