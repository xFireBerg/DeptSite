using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
namespace Assignment2
{
    public interface IDialer
    {
        Task<bool> DialAsync(string number);
    }
}
