using Service_Station.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceStation.Services
{
    public interface IGenericDetails

    {

        IEnumerable GetAll();

        IEnumerable GetByID(int id);

        bool Insert(Client dt);

        bool Update(Client dt, int id);

        bool Delete(Client dt, int id);

    }
}
