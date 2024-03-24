using Microsoft.AspNetCore.Mvc;

namespace ListadoApi;

[ApiController]
[Route("[controller]")]

public class TareaController{
    public enum Estado {Pendiente,Progreso, Completada}
    public static List<Tarea> tareas = new List<Tarea>();
    [HttpPost(Name ="PostTarea")]
    public Tarea PostTarea([FromBody]string x,string titulo,string descripcion, string fecha, Estado estado){
        Tarea tarea = new Tarea(Guid.NewGuid(),titulo,descripcion,fecha,Convert.ToString(estado));
        tareas.Add(tarea);
        return tarea;
    }
    /*[HttpGet(Name ="GetListadoPorId")]
    public Tarea GetListadoPorId(Guid id){
        return tareas.FirstOrDefault(x=> x.id== id);
    }*/

    [HttpGet(Name ="GetListado")]
    public List<Tarea> GetListado(){
        return tareas;
    }
    [HttpDelete(Name ="DeleteTarea")]
    public void DeleteTarea(Guid id){
        tareas.Remove(tareas.FirstOrDefault(x=> x.id== id));
    }
    [HttpPut(Name ="PutTarea")]
    public void PutTarea([FromBody]string x,Guid id,string titulo,string descripcion, string fecha, Estado estado){
        int i = tareas.FindIndex(x => x.id == id);
        if(i>-1){
            tareas[i].titulo = titulo;
            tareas[i].descripcion = descripcion;
            tareas[i].fecha=fecha;
            tareas[i].estado=Convert.ToString(estado);
        }
    }
    //[HttpPatch(Name ="")]
}