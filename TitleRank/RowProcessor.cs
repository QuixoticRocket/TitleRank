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

        internal List<TitleRankNode> CreateGraphsFromInput(Stream inputStream, bool ignoreFirstLine, char splitChar, ref System.Windows.Forms.TextBox outputText)
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
                    Shared.appendTextToTextbox(Shared.GetMalformedRowErrorText(rownumber, splitString.Length), outputText);
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

            int homeCount = 1;
            foreach (var homenode in allNodes.Where(x => x.isHomeLevelNode))
            {
                homenode.Id = homeCount.ToString();
                homeCount++;
            }


            //go through each home item and see if we can find children, add them to the parent, then go through children finding children recursively until done

            //attach level 1s to home nodes (which are also sorta level 1s)
            foreach (var homeparent in allNodes.Where(x => x.isHomeLevelNode))
            {
                foreach (var possibleChild in allNodes.Where(x => x.Level == 1 && !x.isHomeLevelNode))
                {
                    try
                    {
                        if (possibleChild.IsDirectChildOfUrl(homeparent))
                        {
                            TitleRankNode child = allNodes.First(n => n == possibleChild);
                            homeparent.AddChild(ref child, homeCount);
                        }
                    }
                    catch (Exception ex)
                    {
                        //log and move on
                        Shared.appendTextToTextbox(Shared.GetChildProcessingFailureMessage(homeparent.RowNumber, possibleChild.RowNumber, ex), outputText);
                    }
                }
            }

            int currenttLevel = 1;
            int maxlevel = allNodes.Select(n => n.Level).Max();
            while(currenttLevel < maxlevel)
            {
                int nextLevel = currenttLevel + 1;
                //foreach node at current level, go through each node at next level and
                foreach (var parent in allNodes.Where(x => !x.isHomeLevelNode && x.Level == currenttLevel))
                {
                    foreach (var possibleChild in allNodes.Where(x => x.Level == nextLevel && x.Parent == null))
                    {
                        try
                        {
                            if (possibleChild.IsDirectChildOfUrl(parent))
                            {
                                TitleRankNode child = allNodes.First(n => n == possibleChild);
                                parent.AddChild(ref child);
                            }
                        }
                        catch(Exception ex)
                        {
                            //log and move on
                            Shared.appendTextToTextbox(Shared.GetChildProcessingFailureMessage(parent.RowNumber, possibleChild.RowNumber, ex), outputText);
                        }
                    }
                }
                currenttLevel = nextLevel;
            }

            //check if there are any orphans... if so then link them directly under home
            List<TitleRankNode> orphans = allNodes.Where(x => x.Parent == null && !x.isHomeLevelNode).ToList();
            orphans.ForEach(x => x.IsOrphan = true);

            return allNodes;
        }
    }
}
