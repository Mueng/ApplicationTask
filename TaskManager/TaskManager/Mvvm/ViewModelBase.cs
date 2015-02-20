using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Model;

namespace TaskManager.Mvvm
{
    public abstract class ViewModelBase : BindableObject
    {
        protected ViewModelBase(IDataProvider model)
        {
            Model = model;
        }

        protected IDataProvider Model { get; private set; }

        public bool IsClosed { get; private set; }

        public virtual void Close()
        {
            IsClosed = true;
            if (Closed != null)
                Closed(this, new EventArgs());
        }

        /// <summary>
        /// Close ViewModel
        /// </summary>
        public event EventHandler<EventArgs> Closed;
    }
}