using System;
using System.Collections.Generic;
using ANDISI_Entidades;
using ANDISI_Datos;
using ANDISI_Entidades.Menu;


namespace ANDISI_Negocio
{
    public class NMenu
    {
        private readonly DMenu dMenu = null;

        public NMenu()
        {
            dMenu = new DMenu();

        }
        public IList<EMenuDinamico> RecuperaMenu(int pIdUsuario)
        {
            return dMenu.RecuperaMenu(pIdUsuario);  
        }

        public IList<EMetaData> RecuperaMetaData(int id_submenu)
        {
            return dMenu.RecuperaMetaData(id_submenu);
        }

    }
}
