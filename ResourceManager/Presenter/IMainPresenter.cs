using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.Presenter
{
    public interface IMainPresenter
    {
        void SelectedLibraryChange();

        void SelectedResourceChange();

        void SelectedPathChange();

        void SelectedSourceChange();

        void SaveChanges();

        void CreateBackup();

        void Show();

        void Close();
    }
}
