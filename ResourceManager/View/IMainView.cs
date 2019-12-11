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
        MainPresenter Presenter { set; }

        string SelectedLibrary { get; set; }

        string SelectedResource { get; set; }

        SourceEnum SelectedSourceEnum { get; set; }

        IList<ResourceItem> ResourceItemList { get; set; }

        event EventHandler SelectedLibraryChanged;

        event EventHandler SelectedResourceChanged;

        event EventHandler SelectedSourceEnumChanged;

        event EventHandler SaveChanges; 
    }
}
