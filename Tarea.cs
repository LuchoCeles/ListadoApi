namespace ListadoApi;

public class Tarea {
    public Guid? id{get;set;}
    public string titulo {get;set;}
    public string descripcion { get; set; }
    public string fecha { get; set; }
    public string estado { get; set; }
    public Tarea(Guid? id,string titulo,string descripcion,string fecha,string estado){
        this.id=id;
        this.titulo=titulo;
        this.descripcion=descripcion;
        this.fecha=fecha;
        this.estado=estado;
    }
}