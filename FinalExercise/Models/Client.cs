using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Models
{
    internal class Client
    {
        ICommand _command;
        public string VideoURL { get; set; }

        public Client(ICommand command, string videoURL)
        {
            _command = command;
            VideoURL = videoURL;
        }

        public void Run()
        {
            _command.Execute(VideoURL);
        }
    }
}
