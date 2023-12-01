using Lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    public class EjercicioViewModel : ViewModelBase
    {

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        string desc;
        public string Desc
        {
            get { return desc; }
            set
            {
                if (desc != value)
                {
                    desc = value;
                    OnPropertyChanged();
                }
            }
        }

        string selectedStatus;
        public string SelectedStatus
        {
            get { return selectedStatus; }
            set
            {
                if (selectedStatus != value)
                {
                    selectedStatus = value;
                    OnPropertyChanged();
                }
            }
        }




        ObservableCollection<TaskModel> tasks;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }

        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        private List<TaskModel> TaskModels;
        public EjercicioViewModel()
        { 
            Tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel task= new TaskModel();
                task.Title = this.Title;
                task.Desc = this.Desc;
                task.SelectedStatus = this.SelectedStatus;
                TaskModels.Add(task);
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }


    }
}
