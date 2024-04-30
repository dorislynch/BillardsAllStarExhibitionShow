using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Billards.All.Star.Exhibition.Show.RNBillardsAllStarExhibitionShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBillardsAllStarExhibitionShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBillardsAllStarExhibitionShowModule"/>.
        /// </summary>
        internal RNBillardsAllStarExhibitionShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBillardsAllStarExhibitionShow";
            }
        }
    }
}
