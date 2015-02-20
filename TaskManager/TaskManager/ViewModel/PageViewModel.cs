using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Model;
using TaskManager.Mvvm;

namespace TaskManager.ViewModel
{
    public  abstract class PageViewModel : ViewModelBase
    {
        public ViewModelBase Main { get; private set; }

        protected PageViewModel(IDataProvider model, ViewModelBase main)
            : base(model)
        {
            Main = main;
        }
    }
}
