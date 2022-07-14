using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YerbaFrontEnd.Models;

namespace YerbaFrontEnd.Serivces.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
