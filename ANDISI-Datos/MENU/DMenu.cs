
using ANDISI_Entidades;
using ANDISI_Entidades.Menu;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;


namespace ANDISI_Datos
{
    
    public class DMenu
    {
        private readonly DConnectionFactory dConnectionFactory = null;

        public DMenu()
        {
            dConnectionFactory = new DConnectionFactory();
        }
       
        public IList<EMenuDinamico> RecuperaMenu( int pIdUsuario)
        {
            using (var connection = dConnectionFactory.GetConnectionMenuDinamico)
            {
                const string ConsultaSQL = @"SELECT Area.descripcion Area,
                                                   Menu.id_menu IdMenuItem, Menu.titulo DescripcionMenu, Menu.icono IconoMenu,
                                                   SubMenu.id_submenu idSubmenuIten, SubMenu.titulo DescripcionSubmenu,SubMenu.RutaUserControl Ruta ,SubMenu.NombreAccion AccionForm, SubMenu.icono IconoSubmenu

                                             FROM  tbl_Perfiles Perfil,
                                                   cat_usuario Usuario,
	                                               cat_area Area,
	                                               cat_menuitem Menu,
	                                               cat_submenuItems SubMenu
                                              WHERE
                                                   Perfil.id_perfil=Usuario.id_perfil AND
	                                               Perfil.id_area=Area.id_area AND
	                                               Perfil.id_menu=Menu.id_menu AND
	                                               Menu.id_menu=SubMenu.id_menu AND
	                                               Usuario.id_usuario=@pIdUsuario";

                var parameters = new DynamicParameters();
                
                parameters.Add("@pIdUsuario", pIdUsuario, DbType.Int32);

                var response = connection.Query<EMenuDinamico>(ConsultaSQL, parameters, commandType: CommandType.Text).ToList();
               
                return response;
            }
        }
        public IList<EMetaData> RecuperaMetaData(int id_submenu)
        {
            using (var connection = dConnectionFactory.GetConnectionMenuDinamico)
            {
                const string ConsultaSQL = @"select Id,Titulo AS Nombre, Descripcion,UserControl,IsExpanded,RutaUserControl from cat_metadata_submenus where Id_SubMenu=@pIdsubmenu";

                var parameters = new DynamicParameters();

                parameters.Add("@pIdsubmenu", id_submenu, DbType.Int32);

                var response = connection.Query<EMetaData>(ConsultaSQL, parameters, commandType: CommandType.Text).ToList();

                return response;
            }
        }

    }


    

    







}
