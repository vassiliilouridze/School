using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labo4.ViewModel
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }

        [PreferredConstructor]
        public MainPageViewModel(INavigationService navigationService)
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
            _navigationService = navigationService;
        }
        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                if (_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudent");
                }
            }
        }

        private INavigationService _navigationService;

       

        private ICommand _editStudentCommand;

        public ICommand EditStudentCommand
        {
            get
            {
                if (this._editStudentCommand == null)
                {
                    this._editStudentCommand = new RelayCommand(() => EditStudent());
                }
                return _editStudentCommand;
            }

        }

        private void EditStudent()
        {
            if (CanExecute())
            {
                _navigationService.NavigateTo("SecondPage", SelectedStudent);
            }
        }

        private bool CanExecute()
        {
            return SelectedStudent != null;
        }
    }
}
