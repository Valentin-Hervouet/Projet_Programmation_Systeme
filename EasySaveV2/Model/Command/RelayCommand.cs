using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EasySaveV2.Model.Commands
{
    public class RelayCommand : ICommand
    {
        private Action commandTask;

        public RelayCommand(Action WorkToDo)
        {
            commandTask = WorkToDo;
        }


        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            commandTask();
        }
    }
}
