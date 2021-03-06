using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                gamer.IdentityNumber, gamer.FirstName, gamer.LastName, gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;

        }
       // new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
    }
}
