using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleRank
{
    internal class RowProcessor
    {

        internal List<TitleRankNode> CreateGraphsFromInput(Stream inputStream, bool ignoreFirstLine, char splitChar, ref string outputText)
        {
            //read all input into a list
            List<TitleRankNode> allNodes = new List<TitleRankNode>();

            StreamReader reader = new StreamReader(inputStream);

            string lineToProcess;

            int rownumber = 1;

            if (ignoreFirstLine)
            {
                lineToProcess = !reader.EndOfStream ? reader.ReadLine() : string.Empty;
                rownumber++;
            }

            while (!reader.EndOfStream)
            {
                lineToProcess = reader.ReadLine();
                string[] splitString = lineToProcess.Split(splitChar);

                if (splitString.Length != Shared.inputFieldCountPerRow)
                {
                    outputText += Shared.GetMalformedRowErrorText(rownumber, splitString.Length);
                    outputText += Environment.NewLine;
                }
                else
                {
                    allNodes.Add(new TitleRankNode(rownumber, splitString[Shared.UrlFieldNumber], splitString[Shared.TitleFieldNumber]));
                }
                rownumber++;
            }

            reader.Dispose();

            //order list by level, then url
            allNodes = allNodes.OrderBy(n => n.Level).ThenBy(n => n.Url).ToList();

            //find home(s)
            List<TitleRankNode> homeNodes = allNodes.Where(n => n.isHomeLevelNode).ToList();
            //if there are no home level nodes then find lowest levels and they become home level nodes
            if(homeNodes.Count == 0)
            {
                int lowestLevel = allNodes.Select(n => n.Level).Min();
                homeNodes = allNodes.Where(n => n.Level == lowestLevel).ToList();
            }
            allNodes.RemoveAll(x => homeNodes.Contains(x));

            //go through each home item and see if we can find children, add them to the parent, remove them from allnodes, then go through children finding children recursively until done

            //check if there are any orphans... if so then link them directly under home
        }
    }
}
