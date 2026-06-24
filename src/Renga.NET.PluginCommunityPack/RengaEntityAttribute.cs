using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renga.NET.PluginCommunityPack
{
    public class RengaEntityAttribute : Attribute
    {
        public string NameRu { get; set; }
        public string NameEn { get; set; }
        public RengaSDKVariant StartSupport { get; set; }
        public RengaSDKVariant EndSupport { get; set; }
    }
}
