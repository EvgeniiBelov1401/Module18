using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Models
{
    internal interface ICommand
    {
        Task Execute(string videoURL);
    }
}
