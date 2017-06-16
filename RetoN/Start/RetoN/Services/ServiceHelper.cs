using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.WindowsAzure.MobileServices;

namespace RetoN.Services
{
    public class ServiceHelper
    {
        MobileServiceClient clienteServicio = new MobileServiceClient(@"http://xamarinchampions.azurewebsites.net");

        private IMobileServiceTable<TorneoItem> _TorneoItemTable;

        public async Task InsertarEntidad(string direccionCorreo, string reto, string AndroidId)
        {
            _TorneoItemTable = clienteServicio.GetTable<TorneoItem>();


            await _TorneoItemTable.InsertAsync(new TorneoItem
            {
                Email = direccionCorreo,
                Reto = reto,
                DeviceId = AndroidId
            });
        }
    }
}