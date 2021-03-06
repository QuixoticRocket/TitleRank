﻿using System;
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
        internal static readonly int TitleFieldNumber = 1;
        internal static readonly int UrlFieldNumber = 0;
        internal static readonly string IdHeading = "ID";
        internal static readonly string LevelPartialHeading = "Level "; //note the space.. we expect a number to be appended
        internal static readonly string CurrentUrlHeading = "Current URL";

        private static readonly string ParentMismatchExceptionMessageStringFormat = "Node is already the child of another Parent" + Environment.NewLine + "Row number: {0} | existing parent row number {1} | new parent row number {2}";
        private static readonly string MalformedRowErrorTextStringFormat = "Row number {0} is malformed. Expected {1} fields but found {2}";
        private static readonly string ChildProcessingFailureTextStringFormat = "Exception thrown trying to test parent row {0} and possible child row {1}" + Environment.NewLine +  "Exception message: {2}";
        

        internal static string GetParentMismatchExceptionMessageStringFormat(int childRowNumber, int existingParentRowNumber, int newParentRowNumber)
        {
            return string.Format(ParentMismatchExceptionMessageStringFormat, childRowNumber, existingParentRowNumber, newParentRowNumber);
        }

        internal static string GetMalformedRowErrorText(int rownumber, int foundfieldcount)
        {
            return string.Format(MalformedRowErrorTextStringFormat, rownumber, inputFieldCountPerRow, foundfieldcount);
        }

        /// <summary>
        /// Appends the taxt and a newline character
        /// </summary>
        /// <param name="text">the text to append</param>
        /// <param name="textbox">the textbox to append to</param>
        internal static void appendTextToTextbox(string text, System.Windows.Forms.TextBox textbox)
        {
            textbox.AppendText(text);
            textbox.AppendText(Environment.NewLine);
        }

        internal static string GetChildProcessingFailureMessage(int parentRowNumber, int childRowNumber, Exception ex)
        {
            return string.Format(ChildProcessingFailureTextStringFormat, parentRowNumber, childRowNumber, ex.Message);
        }
    }
}
