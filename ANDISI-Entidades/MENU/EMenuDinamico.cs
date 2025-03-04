namespace ANDISI_Entidades.Menu
{
    
    public class EMenuDinamico 
    { 
          public string Area { get; set; }  

          public int IdMenuItem { get; set; }   
        
          public string DescripcionMenu {  get; set; }

          public string IconoMenu {  get; set; }    

          public int idSubmenuIten {  get; set; }  
      
          public string DescripcionSubmenu {  get; set; }  

          public string AccionForm { get; set; } 

          public string IconoSubmenu {  get; set; }
        
          public string Ruta { get; set; }

    }

    public class EMetaData
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UserControl { get; set; }
        public bool IsExpanded { get; set; }
        public string RutaUserControl { get; set; }

    }
}
