using BlogProjectNy.Models;
using BlogProjectNy.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNy.Service
{
    public class APIservice
    {
        static HttpClient httpClient = new HttpClient();
        private static string GetMoviesurl = "http://localhost:44332/";
        public async Task<ObservableCollection<Movies>> GetMovies()
        {
            string getMovies = await httpClient.GetStringAsync(GetMoviesurl + "api/movies");
            var movies = JsonConvert.DeserializeObject<ObservableCollection<Movies>>(getMovies);
            return movies;
        }
        public async Task<ObservableCollection<Movies>> AddMovies()
        {
            return null;
        }
        public async Task<ObservableCollection<Movies>> EditPostBlogs()
        {
            return null;
        }
        public async Task<HttpResponseMessage> DeleteMovie(int ID)
        {
            var removemovie = await httpClient.DeleteAsync(GetMoviesurl + "api/movies/" + ID);
            return removemovie;
        }
    }
}
