﻿using System;
using System.Windows.Input;
using WPF_MVVM.Commands;
using WPF_MVVM.Models;

namespace WPF_MVVM.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;

            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(nameof(FloorNumber)); }
        }
        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged(nameof(RoomNumber)); }
        }
        private DateTime _startDate = new DateTime(2023, 1, 1);
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }
        private DateTime _endDate = new DateTime(2023, 1, 1);
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public MakeReservationViewModel(Hotel hotel)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel);
        }

        public MakeReservationViewModel()
        {
        }
    }
}
