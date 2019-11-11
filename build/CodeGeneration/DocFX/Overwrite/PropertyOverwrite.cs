﻿// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/docfx/blob/master/LICENSE

using System.Diagnostics;

namespace CodeGeneration.DocFX.Overwrite
{
    [DebuggerDisplay("Name: {" + nameof(Name) + "}")]
    internal class PropertyOverwrite
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool? Secret { get; set; }
        public char? Separator { get; set; }
        public bool? NoArgument { get; set; }
        public bool? CustomImpl { get; set; }
        public string ItemFormat { get; set; }
        public string Help { get; set; }
        public string Format { get; set; }
    }
}