using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleRank
{
    internal class TitleRankNode
    {
        internal TitleRankNode Parent { get; set; }
        internal List<TitleRankNode> Children { get; set; }

        internal readonly int RowNumber;
        internal readonly string Url;
        internal readonly string Title;

        internal bool IsOrphan = false;

        internal int SiblingNumber { get; set; }
        internal string ParentId { get; set; }

        private string _cleanUrl = null;
        private string cleanUrl
        {
            get
            {
                if (string.IsNullOrEmpty(_cleanUrl))
                {
                    _cleanUrl = Url;
                    if (_cleanUrl.IndexOf('?') > 0)
                    {
                        _cleanUrl = _cleanUrl.Substring(0, Url.IndexOf('?'));
                    }
                }

                return _cleanUrl;
            }
        }

        private int? _truelevel = null;
        internal int Level
        {
            get
            {
                if (!_truelevel.HasValue)
                {

                    //count the /s after we strip off http:// or https://
                    int returnvalue = cleanUrl.Replace(Shared.httpColonWhackWhack, string.Empty).Replace(Shared.httpsColonWhackWhack, string.Empty).Count(x => x == Shared.Whack);

                    //if we end with a whack then drop the level count by one
                    if (cleanUrl.EndsWith(Shared.Whack.ToString()))
                    {
                        returnvalue--;
                    }

                    _truelevel = returnvalue;

                }

                //special case: 0 is home and must be bumped to 1
                if (_truelevel.Value < 1)
                {
                    return 1;
                }
                return _truelevel.Value;
            }
        }

        internal bool isHomeLevelNode
        {
            get
            {
                if (!_truelevel.HasValue)
                {
                    int temp = Level; //force a calulation
                }

                return _truelevel.Value == 0;
            }
        }

        private string _setId = null;
        internal string Id
        {
            get
            {
                if(!string.IsNullOrEmpty(_setId))
                {
                    return _setId;
                }

                if (IsOrphan)
                {
                    return Shared.OrphanId;
                }
                if (Level > 1)
                {
                    return ParentId + Shared.idSeparator + SiblingNumber.ToString();
                }
                return SiblingNumber.ToString();
            }
            set
            {
                _setId = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rowNumber">The row number read from the input file for error tracking</param>
        internal TitleRankNode(int rowNumber, string url, string title)
        {
            Children = new List<TitleRankNode>();
            RowNumber = rowNumber;
            Url = url;
            Title = title;
        }

        /// <summary>
        /// Adds the child to the collection and reorders it (applying the appropriate sibling number)
        /// order is based on url.
        /// If this child is already the child of another row an exception will be thrown
        /// </summary>
        /// <param name="child">the child to add. will have properties updated.</param>
        /// <param name="siblingStartingNumber">optional starting number defaulting to 1, used for level 1s as they need to mix with home nodes</param>
        internal void AddChild(ref TitleRankNode child, int siblingStartingNumber = 1)
        {
            if (child.Parent != null && child.Parent != this)
            {
                throw new Exception(Shared.GetParentMismatchExceptionMessageStringFormat(child.RowNumber, child.Parent.RowNumber, this.RowNumber));
            }

            Children.Add(child);
            child.Parent = this;
            child.ParentId = this.Id;

            Children = Children.OrderBy(x => x.Url).ToList();
            int count = siblingStartingNumber; //1 based counting for ids
            foreach (var c in Children)
            {
                c.SiblingNumber = count;
                count++;
            }
        }

        /// <summary>
        /// Tests to see if this is a child of the supplied parent url / level combination
        /// </summary>
        ///<param name="parent">the parent node to consider</param>
        /// <returns>true if this is a direct child node, else false</returns>
        internal bool IsDirectChildOfUrl(TitleRankNode parent)
        {
            if (parent._truelevel != (this._truelevel - 1))
            {
                return false;
            }

            string tempurlstring = parent.Url;
            if (!parent.Url.EndsWith(Shared.Whack.ToString()))
            {
                tempurlstring += Shared.Whack;
            }

            //if this is the next level down and we start with the parent url then this must be a child, else not
            return Url.StartsWith(tempurlstring, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
