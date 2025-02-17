﻿using EnvDTE;

namespace DoxygenComments.Styles
{
    interface ICommentStyle
    {
        string CreateCommentBeginning(
            int     nEditPointIndent,
            bool    bUseBannerStyle);

        string CreateCommentMiddle(
            int     nEditPointIndent,
            int     nTagsIndent, 
            int     nMaxTagLength, 
            string  sTag, 
            string  sTagText,
            bool    bInOutString,
            int     nParamsIndent = -1,
            string  sParamText = null);

        string CreateEmptyString(
            int     nEditPointIndent);

        string CreateCommentEnding(
            int     nEditPointIndent,
            bool    bUseBannerStyle);
    }
}
