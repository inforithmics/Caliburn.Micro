﻿using Caliburn.Micro.WinRT.Sample.Results;
using Caliburn.Micro.WinRT.Sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.WinRT.Sample.ViewModels
{
    public class ConventionsViewModel : ViewModelBase
    {
        private DateTime currentDate = DateTime.Now;
        private TimeSpan currentTime = DateTime.Now.TimeOfDay;
        private string searchText;

        public ConventionsViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public DateTime CurrentDate
        {
            get
            {
                return currentDate;
            }
            set
            {
                currentDate = value;
                NotifyOfPropertyChange();
            }
        }

        public TimeSpan CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                currentTime = value;
                NotifyOfPropertyChange();
            }
        }

        public string SearchText
        {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;
                NotifyOfPropertyChange();
            }
        }

        public IEnumerable<IResult> ExecuteSearch()
        {
            yield return new MessageDialogResult("Search Executed", String.Format("Searching for {0}", SearchText));
        }
    }
}
