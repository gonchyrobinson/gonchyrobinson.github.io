﻿using DiegoMoyanoProject.Models;
using Microsoft.Identity.Client;
using System.ComponentModel;

namespace DiegoMoyanoProject.ViewModels.UserData
{
    public class IndexDateUserDataViewModel
    {
        public List<ImageDataViewModel> Images { get; set; }
        public string SelectedDate { get; set; }
        public List<DateTime> Dates { get; set; }
        public IndexDateUserDataViewModel() { }
        public IndexDateUserDataViewModel(List<ImageDataViewModel> images, List<DateTime> dates, DateTime date)
        {
            Images = images;
            Dates = dates;
            SelectedDate = date.ToString("MMMM");
        }   
    }
}
