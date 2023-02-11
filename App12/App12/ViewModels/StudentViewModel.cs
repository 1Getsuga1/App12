using App12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App12.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        StudentsListViewModel lvm;

        public Student _Student { get; private set; }

        public StudentViewModel()
        {
            _Student = new Student();
        }

        public StudentsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string FIO
        {
            get { return _Student.FIO; }
            set
            {
                if (_Student.FIO != value)
                {
                    _Student.FIO = value;
                    OnPropertyChanged("FIO");
                }
            }
        }
        public string Street
        {
            get { return _Student.Street; }
            set
            {
                if (_Student.Street != value)
                {
                    _Student.Street = value;
                    OnPropertyChanged("Street");
                }
            }
        }
        public string Apartament
        {
            get { return _Student.Apartament; }
            set
            {
                if (_Student.Apartament != value)
                {
                    _Student.Apartament = value;
                    OnPropertyChanged("Apartament");
                }
            }
        }

        

        public string House
        {
            get { return _Student.House; }
            set
            {
                if (_Student.House != value)
                {
                    _Student.House = value;
                    OnPropertyChanged("House");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(FIO.Trim())) ||
                    (!string.IsNullOrEmpty(Apartament.Trim())) ||
                    (!string.IsNullOrEmpty(Street.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
