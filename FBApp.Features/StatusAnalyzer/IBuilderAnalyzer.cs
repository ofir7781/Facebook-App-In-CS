using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal interface IBuilderAnalyzer
    {
        void BuildLikesAnalyzer();

        void BuildCommentsAnalyzer();

        void BuildBiggestFollowerAnalyzer();

        AnalysisProduct GetProduct();
    }
}
