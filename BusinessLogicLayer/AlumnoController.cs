using BusinessLogicLayer.Model;
using DataAccessLayer.Model;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class AlumnoController : BaseController<AlumnoViewModel>
    {
        public override List<AlumnoViewModel> GetAll()
        {
            var list = repository.Alumnos.GetAll();
            var list2 = new List<AlumnoViewModel>();
            foreach(var x in list)
            {
                list2.Add(new AlumnoViewModel(x));
            } 
            return list2;
        }

        //asdasdasd
        public bool Guardar(AlumnoViewModel alumno)
        {
            var alumnodo = new AlumnoDO(alumno.Nombre, alumno.Apellido);            
            return repository.Alumnos.Insert(alumnodo);
        }

        public bool Actualizar(AlumnoViewModel alumno)
        {
            var alumnodo = new AlumnoDO(alumno.Nombre, alumno.Apellido, alumno.ID);
            return repository.Alumnos.Update(alumnodo);
        }
        public bool Borrar(int id)
        {            
            repository.Alumnos.Delete(id);
            return repository.Alumnos.Delete(id);

        }

    }
}
