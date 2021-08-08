using ElicitInc.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElicitInc.Services
{
    public interface IElicitService
    {
        List<Elicit> ReadAll();
        //List<Project> ReadById(int id);
        //int Post(ElicitAddRequest model);
        //int Put(ElicitUpdateRequest model);
        //int Delete(int id);
    }
}