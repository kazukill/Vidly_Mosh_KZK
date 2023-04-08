using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Mosh_KZK.Models;

namespace Vidly_Mosh_KZK.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}