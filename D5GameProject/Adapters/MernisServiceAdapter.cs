using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace D5GameProject.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            TCDogrula.KPSPublicSoapClient client = new TCDogrula.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper, gamer.LastName.ToUpper(), gamer.BirthYear.Year);

        }
    }
}
