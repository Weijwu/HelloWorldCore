﻿/*******************************************************************************
 *                      VIRTUE DIAGNOSTICS SINGAPORE PTE. LTD.                 *
 *******************************************************************************
 * Copyright    : Copyright(c) Virtue Diagnostics Singapore Pte. Ltd.          *
 *                All rights reserved.                                         *
 *                                                                             *
 * Author       : Justin Adrias                                                *
 *******************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Virtue.iGene_Pad.TVK.ViewModel
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            this.OnNotifyPropertyChange(propertyName);
            return true;
        }

        private void OnNotifyPropertyChange(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
