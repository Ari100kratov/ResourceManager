using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.View
{
    public interface IMainView
    {
        string SelectedLibrary { get; set; }

        string SelectedResource { get; set; }

        string SelectedPath { get; set; }

        SourceEnum SelectedSourceEnum { get; set; }

        IList<ResourceItem> ResourceItemList { get; set; }

        IList<string> LibraryList { get; set; }

        IList<string> ResourceList { get; set; }

        Dictionary<int, string> SourceEnumDict { get; set; }

    }
}
