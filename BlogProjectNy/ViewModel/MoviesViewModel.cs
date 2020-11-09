using BlogProjectNy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNy.ViewModel
{
    public class MoviesViewModel
    {
        public ObservableCollection<Movies> movies { get; set; }
        public Movies movie { get; set; }

        public MoviesViewModel()
        {
            movies = new ObservableCollection<Movies>();
        }
    }
}
