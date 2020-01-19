using HY.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Logic.Managers
{
    public class TaskManager : HYManager
    {
        public TaskManager()
        {
            Entities.Add(new HYEntity("Task"));
            InitializeManager();
        }
    }
}
