using System;
using System.Collections.Generic;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal class DirectorAnalyzer
    {
        public void Construct(IBuilderAnalyzer i_BuilderAnalyzer)
        {
            i_BuilderAnalyzer.BuildLikesAnalyzer();
            i_BuilderAnalyzer.BuildCommentsAnalyzer();
            i_BuilderAnalyzer.BuildBiggestFollowerAnalyzer();
        }
    }
}
